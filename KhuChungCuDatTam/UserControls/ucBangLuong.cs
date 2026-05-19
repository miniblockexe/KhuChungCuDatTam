using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using KhuChungCuDatTam.Models;
using KhuChungCuDatTam.Helpers;

namespace KhuChungCuDatTam.UserControls
{
    public partial class ucBangLuong : UserControl
    {
        private int _selectedId = -1;
        private bool _isEditing = false;

        private static readonly Dictionary<string, string> TrangThaiMap = new Dictionary<string, string>
        {
            { "Đã trả",   "da_thanh_toan"    },
            { "Chưa trả", "chua_thanh_toan"  },
            { "Tạm ứng",  "tam_ung"          }
        };

        public ucBangLuong()
        {
            InitializeComponent();
        }

        private void ucBangLuong_Load(object sender, EventArgs e)
        {
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;

            InitComboBoxTrangThai();
            LoadNguoiDung();
            LoadData();
            LoadThongKe();
        }

        private void InitComboBoxTrangThai()
        {
            cboTrangThai.Items.Clear();
            foreach (var key in TrangThaiMap.Keys)
                cboTrangThai.Items.Add(key);
            cboTrangThai.SelectedIndex = 0;
        }

        public void LoadNguoiDung()
        {
            try
            {
                using (var db = new DbChungCu())
                {
                    var list = db.nguoi_dung
                                 .OrderBy(n => n.ho_ten)
                                 .Select(n => new { n.id, HoTen = n.ho_ten ?? n.ten_dang_nhap })
                                 .ToList();

                    cboNguoiDung.DisplayMember = "HoTen";
                    cboNguoiDung.ValueMember = "id";
                    cboNguoiDung.DataSource = list;
                    cboNguoiDung.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                ShowError("Lỗi tải danh sách người dùng: " + ex.Message);
            }
        }

        public void LoadData()
        {
            try
            {
                using (var db = new DbChungCu())
                {
                    var query = db.bang_luong
                                  .Include("nguoi_dung")
                                  .OrderByDescending(b => b.thang_nam)
                                  .ToList();

                    BindGrid(query);
                }
            }
            catch (Exception ex)
            {
                ShowError("Lỗi tải dữ liệu bảng lương: " + ex.Message);
            }
        }

        private void BindGrid(List<bang_luong> data)
        {
            dgvBangLuong.Rows.Clear();

            foreach (var b in data)
            {
                string tenND = b.nguoi_dung?.ho_ten ?? b.nguoi_dung?.ten_dang_nhap ?? "—";
                string ttHienThi = GetTrangThaiDisplay(b.trang_thai);

                int idx = dgvBangLuong.Rows.Add(
                    b.id,
                    tenND,
                    b.thang_nam.ToString("MM/yyyy"),
                    FormatCurrency(b.luong_co_ban),
                    FormatCurrency(b.thuong),
                    FormatCurrency(b.khau_tru),
                    FormatCurrency(b.tong_luong ?? 0),
                    ttHienThi
                );
                dgvBangLuong.Rows[idx].Tag = b.id;
            }
        }

        public void LoadThongKe()
        {
            try
            {
                using (var db = new DbChungCu())
                {
                    var all = db.bang_luong.ToList();

                    lblTongBangLuong.Text = all.Count.ToString();
                    lblTongNhanVien.Text = all.Select(b => b.nguoi_dung_id).Distinct().Count().ToString();
                    lblTongLuongThucLinh.Text = FormatCurrency(all.Sum(b => b.tong_luong ?? 0));
                }
            }
            catch (Exception ex)
            {
                ShowError("Lỗi tải thống kê: " + ex.Message);
            }
        }

        public void SearchBangLuong(string keyword)
        {
            try
            {
                using (var db = new DbChungCu())
                {
                    keyword = keyword?.Trim().ToLower() ?? string.Empty;

                    var query = db.bang_luong
                                  .Include("nguoi_dung")
                                  .ToList()
                                  .Where(b =>
                                      string.IsNullOrEmpty(keyword) ||
                                      (b.nguoi_dung?.ho_ten ?? "").ToLower().Contains(keyword) ||
                                      (b.nguoi_dung?.ten_dang_nhap ?? "").ToLower().Contains(keyword) ||
                                      b.thang_nam.ToString("MM/yyyy").Contains(keyword))
                                  .OrderByDescending(b => b.thang_nam)
                                  .ToList();

                    BindGrid(query);
                }
            }
            catch (Exception ex)
            {
                ShowError("Lỗi tìm kiếm: " + ex.Message);
            }
        }

        public void CalculateTongLuong()
        {
            decimal co_ban = ParseCurrency(txtLuongCoBan.Text);
            decimal thuong = ParseCurrency(txtThuong.Text);
            decimal khau = ParseCurrency(txtKhauTru.Text);
            decimal tong = co_ban + thuong - khau;

            txtTongLuong.Text = FormatCurrency(tong);
        }

        public void InsertBangLuong()
        {
            if (!ValidateForm()) return;

            try
            {
                using (var db = new DbChungCu())
                {
                    var entity = BuildEntityFromForm();

                    db.bang_luong.Add(entity);
                    db.SaveChanges();

                    AuditLogHelper.GhiLog("THÊM", "bang_luong", entity.id,
    $"Thêm bảng lương – NV ID {entity.nguoi_dung_id} – Tháng {entity.thang_nam:MM/yyyy} – Tổng lương {entity.tong_luong:N0}₫");
                }

                ShowSuccess("Thêm bảng lương thành công!");
                RefreshAll();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException dbEx)
            {
                var inner = dbEx.InnerException?.InnerException?.Message
                         ?? dbEx.InnerException?.Message
                         ?? dbEx.Message;
                ShowError("Lỗi thêm bảng lương: " + inner);
            }
            catch (Exception ex)
            {
                ShowError("Lỗi thêm bảng lương: " + (ex.InnerException?.Message ?? ex.Message));
            }
        }

        public void UpdateBangLuong()
        {
            if (_selectedId < 0)
            {
                ShowWarning("Vui lòng chọn bảng lương cần sửa.");
                return;
            }
            if (!ValidateForm()) return;

            try
            {
                using (var db = new DbChungCu())
                {
                    var entity = db.bang_luong.FirstOrDefault(b => b.id == _selectedId);
                    if (entity == null)
                    {
                        ShowWarning("Không tìm thấy bản ghi.");
                        return;
                    }

                    FillEntityFromForm(entity);
                    db.SaveChanges();
                    AuditLogHelper.GhiLog("SỬA", "bang_luong", entity.id,
    $"Cập nhật bảng lương – NV ID {entity.nguoi_dung_id} – Tháng {entity.thang_nam:MM/yyyy} – Tổng lương {entity.tong_luong:N0}₫");
                }

                ShowSuccess("Cập nhật bảng lương thành công!");
                RefreshAll();
            }
            catch (Exception ex)
            {
                ShowError("Lỗi cập nhật bảng lương: " + ex.Message);
            }
        }

        public void DeleteBangLuong()
        {
            if (_selectedId < 0)
            {
                ShowWarning("Vui lòng chọn bảng lương cần xóa.");
                return;
            }

            var confirm = MessageBox.Show(
                "Bạn có chắc muốn xóa bảng lương này?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            try
            {
                using (var db = new DbChungCu())
                {
                    var entity = db.bang_luong.FirstOrDefault(b => b.id == _selectedId);
                    if (entity == null)
                    {
                        ShowWarning("Không tìm thấy bản ghi.");
                        return;
                    }
                    string logInfo = $"Xóa bảng lương – NV ID {entity.nguoi_dung_id} – Tháng {entity.thang_nam:MM/yyyy}";
                    db.bang_luong.Remove(entity);
                    db.SaveChanges();
                    AuditLogHelper.GhiLog("XÓA", "bang_luong", _selectedId, logInfo);
                }

                ShowSuccess("Xóa bảng lương thành công!");
                RefreshAll();
            }
            catch (Exception ex)
            {
                ShowError("Lỗi xóa bảng lương: " + ex.Message);
            }
        }

        private bang_luong BuildEntityFromForm()
        {
            var entity = new bang_luong();
            FillEntityFromForm(entity);
            return entity;
        }

        private void FillEntityFromForm(bang_luong entity)
        {
            entity.nguoi_dung_id = (int)cboNguoiDung.SelectedValue;
            entity.thang_nam = new DateTime(dtThangNam.Value.Year, dtThangNam.Value.Month, 1);
            entity.luong_co_ban = ParseCurrency(txtLuongCoBan.Text);
            entity.thuong = ParseCurrency(txtThuong.Text);
            entity.khau_tru = ParseCurrency(txtKhauTru.Text);
            entity.tong_luong = entity.luong_co_ban + entity.thuong - entity.khau_tru; 
            entity.trang_thai = GetTrangThaiValue(cboTrangThai.SelectedItem?.ToString());
        }

        public void ClearForm()
        {
            _selectedId = -1;
            _isEditing = false;

            if (cboNguoiDung.Items.Count > 0)
                cboNguoiDung.SelectedIndex = 0;

            dtThangNam.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            txtLuongCoBan.Text = "0";
            txtThuong.Text = "0";
            txtKhauTru.Text = "0";
            txtTongLuong.Text = "0";
            cboTrangThai.SelectedIndex = 0;
            txtSearch.Text = string.Empty;

            dgvBangLuong.ClearSelection();
            SetButtonState(false);
        }

        private void RefreshAll()
        {
            ClearForm();
            LoadData();
            LoadThongKe();
        }

        private bool ValidateForm()
        {
            if (cboNguoiDung.SelectedValue == null)
            {
                ShowWarning("Vui lòng chọn nhân viên.");
                cboNguoiDung.Focus();
                return false;
            }

            if (ParseCurrency(txtLuongCoBan.Text) <= 0)
            {
                ShowWarning("Lương cơ bản phải lớn hơn 0.");
                txtLuongCoBan.Focus();
                return false;
            }

            if (cboTrangThai.SelectedItem == null)
            {
                ShowWarning("Vui lòng chọn trạng thái.");
                cboTrangThai.Focus();
                return false;
            }

            return true;
        }

        private void dgvBangLuong_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBangLuong.CurrentRow == null) return;
            if (dgvBangLuong.CurrentRow.Tag == null) return;

            int id = (int)dgvBangLuong.CurrentRow.Tag;
            PopulateFormFromId(id);
        }

        private void PopulateFormFromId(int id)
        {
            try
            {
                using (var db = new DbChungCu())
                {
                    var entity = db.bang_luong
                                   .Include("nguoi_dung")
                                   .FirstOrDefault(b => b.id == id);

                    if (entity == null) return;

                    _selectedId = entity.id;
                    _isEditing = true;

                    SetComboBoxById(cboNguoiDung, entity.nguoi_dung_id);

                    dtThangNam.Value = new DateTime(entity.thang_nam.Year, entity.thang_nam.Month, 1);

                    txtLuongCoBan.Text = FormatCurrency(entity.luong_co_ban);
                    txtThuong.Text = FormatCurrency(entity.thuong);
                    txtKhauTru.Text = FormatCurrency(entity.khau_tru);
                    txtTongLuong.Text = FormatCurrency(entity.tong_luong ?? 0);

                    SetComboBoxByValue(cboTrangThai, GetTrangThaiDisplay(entity.trang_thai));

                    SetButtonState(true);
                }
            }
            catch (Exception ex)
            {
                ShowError("Lỗi đọc dữ liệu: " + ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e) => InsertBangLuong();
        private void btnSua_Click(object sender, EventArgs e) => UpdateBangLuong();
        private void btnXoa_Click(object sender, EventArgs e) => DeleteBangLuong();
        private void btnLamMoi_Click(object sender, EventArgs e) => RefreshAll();
        private void btnTinhLuong_Click(object sender, EventArgs e) => CalculateTongLuong();

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchBangLuong(txtSearch.Text);
        }

        private void txtLuong_Leave(object sender, EventArgs e)
        {
            if (sender is TextBox tb)
            {
                decimal val = ParseCurrency(tb.Text);
                tb.Text = FormatCurrency(val);
            }
            CalculateTongLuong();
        }

        private void SetButtonState(bool isSelected)
        {
            btnSua.Enabled = isSelected;
            btnXoa.Enabled = isSelected;
        }

        private static string FormatCurrency(decimal value)
        {
            return value.ToString("N0") + " ₫";
        }

        private static decimal ParseCurrency(string text)
        {
            if (string.IsNullOrWhiteSpace(text)) return 0;
            string clean = text.Replace("₫", "")
                               .Replace(",", "")
                               .Replace(".", "")
                               .Trim();
            return decimal.TryParse(clean, out decimal result) ? result : 0;
        }

        private static string GetTrangThaiDisplay(string dbValue)
        {
            foreach (var kv in TrangThaiMap)
                if (kv.Value == dbValue) return kv.Key;
            return dbValue;
        }

        private static string GetTrangThaiValue(string display)
        {
            if (display != null && TrangThaiMap.TryGetValue(display, out string val))
                return val;
            return "chua_tra";
        }

        private static void SetComboBoxById(ComboBox cbo, int id)
        {
            foreach (object item in cbo.Items)
            {
                var prop = item.GetType().GetProperty("id");
                if (prop != null && (int)prop.GetValue(item, null) == id)
                {
                    cbo.SelectedItem = item;
                    return;
                }
            }
        }

        private static void SetComboBoxByValue(ComboBox cbo, string value)
        {
            for (int i = 0; i < cbo.Items.Count; i++)
            {
                if (cbo.Items[i].ToString() == value)
                {
                    cbo.SelectedIndex = i;
                    return;
                }
            }
        }

        private static void ShowError(string msg)
        {
            MessageBox.Show(msg, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private static void ShowWarning(string msg)
        {
            MessageBox.Show(msg, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private static void ShowSuccess(string msg)
        {
            MessageBox.Show(msg, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}