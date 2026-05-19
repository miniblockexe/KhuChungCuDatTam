using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using KhuChungCuDatTam.Helpers;
using KhuChungCuDatTam.Models;

namespace KhuChungCuDatTam.UserControls
{
    public partial class ucDichVu : UserControl
    {
        private static readonly Color CLR_BG = Color.FromArgb(15, 23, 42);
        private static readonly Color CLR_CARD = Color.FromArgb(30, 41, 59);
        private static readonly Color CLR_PRIMARY = Color.FromArgb(59, 130, 246);
        private static readonly Color CLR_SUCCESS = Color.FromArgb(16, 185, 129);
        private static readonly Color CLR_DANGER = Color.FromArgb(239, 68, 68);
        private static readonly Color CLR_MUTED = Color.FromArgb(100, 116, 139);
        private static readonly Color CLR_TEXT = Color.White;

        private int _selectedId = -1;

        public ucDichVu()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint, true);
        }

        private void ucDichVu_Load(object sender, EventArgs e)
        {
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;

            InitComboBoxes();
            LoadData();
            LoadThongKe();
        }

        private void InitComboBoxes()
        {
            cboLoaiDichVu.Items.Clear();
            cboLoaiDichVu.Items.AddRange(new object[]
            {
                "Internet", "Gui xe", "Ve sinh", "Gym", "Ho boi", "Khac"
            });
            cboLoaiDichVu.SelectedIndex = -1;
            cboTrangThai.Items.Clear();
            cboTrangThai.Items.Add("hoat_dong");
            cboTrangThai.Items.Add("ngung");
            cboTrangThai.SelectedIndex = -1;
            cboTrangThai.DataSource = new[]
            {
                new { Value = "hoat_dong", Display = "Hoạt động" },
                new { Value = "ngung",     Display = "Ngưng"      },
            };
            cboTrangThai.DisplayMember = "Display";
            cboTrangThai.ValueMember = "Value";
            cboTrangThai.SelectedIndex = -1;
        }

        public void LoadData()
        {
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;
            try
            {
                using (var db = new DbChungCu())
                {
                    var list = db.dich_vu
                                 .OrderBy(d => d.ten_dich_vu)
                                 .ToList()
                                 .Select(d => new DichVuRow
                                 {
                                     Id = d.id,
                                     TenDichVu = d.ten_dich_vu,
                                     LoaiDichVu = d.don_vi ?? "",
                                     DonGia = d.don_gia,
                                     MoTa = d.mo_ta ?? "",
                                     TrangThai = d.trang_thai
                                 })
                                 .ToList();

                    dgvDichVu.DataSource = null;
                    dgvDichVu.DataSource = list;
                    StyleGridRows();
                }
            }
            catch (Exception ex)
            {
                ShowError("Tải dữ liệu thất bại", ex);
            }
        }

        public void LoadThongKe()
        {
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;
            try
            {
                using (var db = new DbChungCu())
                {
                    int tong = db.dich_vu.Count();
                    int hoatDong = db.dich_vu.Count(d => d.trang_thai == "hoat_dong");
                    int tamNgung = db.dich_vu.Count(d => d.trang_thai == "ngung");

                    lblTongDichVu.Text = tong.ToString("N0");
                    lblDangHoatDong.Text = hoatDong.ToString("N0");
                    lblTamNgung.Text = tamNgung.ToString("N0");
                }
            }
            catch (Exception ex)
            {
                ShowError("Tải thống kê thất bại", ex);
            }
        }

        public void ClearForm()
        {
            _selectedId = -1;
            txtTenDichVu.Clear();
            txtDonGia.Clear();
            txtMoTa.Clear();
            cboLoaiDichVu.SelectedIndex = -1;
            cboTrangThai.SelectedIndex = -1;

            if (dgvDichVu.Rows.Count > 0)
                dgvDichVu.ClearSelection();

            txtTenDichVu.Focus();
        }

        public void InsertDichVu()
        {
            if (!ValidateForm()) return;
            try
            {
                using (var db = new DbChungCu())
                {
                    var entity = new dich_vu
                    {
                        ten_dich_vu = txtTenDichVu.Text.Trim(),
                        don_vi = cboLoaiDichVu.SelectedItem?.ToString() ?? "",
                        don_gia = ParseDonGia(),
                        mo_ta = txtMoTa.Text.Trim(),
                        trang_thai = cboTrangThai.SelectedValue?.ToString() ?? "hoat_dong"
                    };

                    db.dich_vu.Add(entity);
                    db.SaveChanges();
                    AuditLogHelper.GhiLog("THÊM", "dich_vu", entity.id,
    $"Thêm dịch vụ {entity.ten_dich_vu} – {entity.don_vi} – {entity.don_gia:#,##0} đ – {entity.trang_thai}");
                }

                MessageBox.Show("Thêm dịch vụ thành công!",
                    "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadData();
                LoadThongKe();
                ClearForm();
            }
            catch (Exception ex)
            {
                ShowError("Thêm dịch vụ thất bại", ex);
            }
        }

        public void UpdateDichVu()
        {
            if (_selectedId <= 0)
            {
                Warn("Vui lòng chọn một dịch vụ để sửa.");
                return;
            }
            if (!ValidateForm()) return;

            try
            {
                using (var db = new DbChungCu())
                {
                    var entity = db.dich_vu.FirstOrDefault(d => d.id == _selectedId);
                    if (entity == null)
                    {
                        Warn("Không tìm thấy dịch vụ. Vui lòng làm mới danh sách.");
                        return;
                    }

                    entity.ten_dich_vu = txtTenDichVu.Text.Trim();
                    entity.don_vi = cboLoaiDichVu.SelectedItem?.ToString() ?? "";
                    entity.don_gia = ParseDonGia();
                    entity.mo_ta = txtMoTa.Text.Trim();
                    entity.trang_thai = cboTrangThai.SelectedValue?.ToString() ?? "hoat_dong";

                    db.SaveChanges();
                    AuditLogHelper.GhiLog("SỬA", "dich_vu", _selectedId,
    $"Cập nhật dịch vụ {entity.ten_dich_vu} – {entity.don_gia:#,##0} đ – {entity.trang_thai}");
                }

                MessageBox.Show("Cập nhật dịch vụ thành công!",
                    "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadData();
                LoadThongKe();
                ClearForm();
            }
            catch (Exception ex)
            {
                ShowError("Cập nhật dịch vụ thất bại", ex);
            }
        }

        public void DeleteDichVu()
        {
            if (_selectedId <= 0)
            {
                Warn("Vui lòng chọn một dịch vụ để xóa.");
                return;
            }

            string ten = txtTenDichVu.Text.Trim();
            var confirm = MessageBox.Show(
                $"Bạn có chắc muốn xóa dịch vụ \"{ten}\" không?\n\nHành động này không thể hoàn tác.",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);

            if (confirm != DialogResult.Yes) return;

            try
            {
                using (var db = new DbChungCu())
                {
                    var entity = db.dich_vu.FirstOrDefault(d => d.id == _selectedId);
                    if (entity == null)
                    {
                        Warn("Không tìm thấy dịch vụ. Vui lòng làm mới danh sách.");
                        return;
                    }
                    string logInfo = $"Xóa dịch vụ {entity.ten_dich_vu} – {entity.don_vi} – {entity.don_gia:#,##0} đ";
                    db.dich_vu.Remove(entity);
                    db.SaveChanges();
                    AuditLogHelper.GhiLog("XÓA", "dich_vu", _selectedId, logInfo);
                }

                MessageBox.Show("Xóa dịch vụ thành công!",
                    "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadData();
                LoadThongKe();
                ClearForm();
            }
            catch (Exception ex)
            {
                bool isFk = ex.InnerException?.InnerException?.Message?.Contains("REFERENCE") == true
                         || ex.InnerException?.Message?.Contains("REFERENCE") == true;

                if (isFk)
                    MessageBox.Show(
                        "Không thể xóa dịch vụ này vì đang có đăng ký liên quan.",
                        "Không thể xóa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    ShowError("Xóa dịch vụ thất bại", ex);
            }
        }

        public void SearchDichVu()
        {
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;

            string kw = txtSearch.Text.Trim().ToLower();

            try
            {
                using (var db = new DbChungCu())
                {
                    var query = db.dich_vu.AsQueryable();

                    if (!string.IsNullOrEmpty(kw))
                    {
                        query = query.Where(d =>
                            d.ten_dich_vu.ToLower().Contains(kw) ||
                            (d.don_vi != null && d.don_vi.ToLower().Contains(kw)) ||
                            d.trang_thai.ToLower().Contains(kw) ||
                            (d.mo_ta != null && d.mo_ta.ToLower().Contains(kw)));
                    }

                    var list = query.OrderBy(d => d.ten_dich_vu)
                                    .ToList()
                                    .Select(d => new DichVuRow
                                    {
                                        Id = d.id,
                                        TenDichVu = d.ten_dich_vu,
                                        LoaiDichVu = d.don_vi ?? "",
                                        DonGia = d.don_gia,
                                        MoTa = d.mo_ta ?? "",
                                        TrangThai = d.trang_thai
                                    })
                                    .ToList();

                    dgvDichVu.DataSource = null;
                    dgvDichVu.DataSource = list;
                    StyleGridRows();
                }
            }
            catch (Exception ex)
            {
                ShowError("Tìm kiếm thất bại", ex);
            }
        }
        
        private void FillFormFromRow(int rowIndex)
        {
            try
            {
                var row = dgvDichVu.Rows[rowIndex];

                _selectedId = Convert.ToInt32(row.Cells["colId"].Value);
                txtTenDichVu.Text = row.Cells["colTenDichVu"].Value?.ToString() ?? "";
                txtMoTa.Text = row.Cells["colMoTa"].Value?.ToString() ?? "";

                if (row.Cells["colDonGia"].Value != null)
                    txtDonGia.Text = Convert.ToDecimal(row.Cells["colDonGia"].Value).ToString("N0");
                else
                    txtDonGia.Text = "";

                string loai = row.Cells["colLoaiDichVu"].Value?.ToString() ?? "";
                string trangThai = row.Cells["colTrangThai"].Value?.ToString() ?? "";

                cboLoaiDichVu.SelectedIndex = cboLoaiDichVu.Items.IndexOf(loai);
                cboTrangThai.SelectedValue = trangThai;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"[ucDichVu.FillFormFromRow] {ex.Message}");
            }
        }

        private void StyleGridRows()
        {
            foreach (DataGridViewRow row in dgvDichVu.Rows)
            {
                if (row.IsNewRow) continue;
                string tt = row.Cells["colTrangThai"].Value?.ToString() ?? "";
                row.Cells["colTrangThai"].Style.ForeColor =
                    tt == "hoat_dong" ? CLR_SUCCESS : CLR_DANGER;
                row.Cells["colTrangThai"].Style.Font =
                    new Font(dgvDichVu.Font, FontStyle.Bold);
            }
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtTenDichVu.Text))
            {
                Warn("Vui lòng nhập Tên Dịch Vụ.", txtTenDichVu);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDonGia.Text))
            {
                Warn("Vui lòng nhập Đơn Giá.", txtDonGia);
                return false;
            }

            string raw = txtDonGia.Text.Replace(",", "").Replace(".", "").Trim();
            if (!decimal.TryParse(raw, out decimal donGia) || donGia < 0)
            {
                Warn("Đơn Giá phải là số không âm.", txtDonGia);
                return false;
            }

            if (cboLoaiDichVu.SelectedIndex < 0)
            {
                Warn("Vui lòng chọn Loại Dịch Vụ.", cboLoaiDichVu);
                return false;
            }

            if (cboTrangThai.SelectedIndex < 0)
            {
                Warn("Vui lòng chọn Trạng Thái.", cboTrangThai);
                return false;
            }

            txtDonGia.Text = donGia.ToString("N0");
            return true;
        }

        private decimal ParseDonGia()
        {
            string raw = txtDonGia.Text.Replace(",", "").Replace(".", "").Trim();
            return decimal.TryParse(raw, out decimal val) ? val : 0;
        }

        private void btnThem_Click(object sender, EventArgs e) => InsertDichVu();
        private void btnSua_Click(object sender, EventArgs e) => UpdateDichVu();
        private void btnXoa_Click(object sender, EventArgs e) => DeleteDichVu();
        private void btnLamMoi_Click(object sender, EventArgs e) { LoadData(); LoadThongKe(); ClearForm(); }

        private void txtSearch_TextChanged(object sender, EventArgs e) => SearchDichVu();

        private void dgvDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            FillFormFromRow(e.RowIndex);
        }

        private void txtDonGia_Leave(object sender, EventArgs e)
        {
            string raw = txtDonGia.Text.Replace(",", "").Replace(".", "").Trim();
            if (decimal.TryParse(raw, out decimal val))
                txtDonGia.Text = val.ToString("N0");
        }

        private void txtDonGia_Enter(object sender, EventArgs e)
        {
            string raw = txtDonGia.Text.Replace(",", "").Replace(".", "").Trim();
            if (decimal.TryParse(raw, out decimal val) && val != 0)
                txtDonGia.Text = val.ToString();
        }

        private static void Warn(string message, Control focusTarget = null)
        {
            MessageBox.Show(message, "Cảnh báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            focusTarget?.Focus();
        }

        private static void ShowError(string context, Exception ex)
        {
            Exception inner = ex;
            while (inner.InnerException != null)
                inner = inner.InnerException;

            string detail = inner.Message;
            MessageBox.Show($"{context}:\n{detail}", "Lỗi",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            System.Diagnostics.Debug.WriteLine($"[ucCanHo] {context}: {ex}");
        }
    }

    internal class DichVuRow
    {
        public int Id { get; set; }
        public string TenDichVu { get; set; }
        public string LoaiDichVu { get; set; }
        public decimal DonGia { get; set; }
        public string MoTa { get; set; }
        public string TrangThai { get; set; }
    }
}