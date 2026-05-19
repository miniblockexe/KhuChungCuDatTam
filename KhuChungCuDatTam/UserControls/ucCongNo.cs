using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using KhuChungCuDatTam.Forms;
using KhuChungCuDatTam.Helpers;
using KhuChungCuDatTam.Models;

namespace KhuChungCuDatTam.UserControls
{
    public partial class ucCongNo : UserControl
    {
        private int _selectedId = -1;

        public ucCongNo()
        {
            InitializeComponent();

            dtNgayPhatSinh = new DateTimePicker
            {
                Visible = false,
                Name = "dtNgayPhatSinh"
            };
            this.Controls.Add(dtNgayPhatSinh);
        }

        private void ucCongNo_Load(object sender, EventArgs e)
        {
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;

            cboTrangThai.Items.Clear();
            cboTrangThai.Items.Add("Chưa trả");
            cboTrangThai.Items.Add("Đã trả");
            cboTrangThai.Items.Add("Quá hạn");
            cboTrangThai.SelectedIndex = 0;

            LoadHoaDon();
            LoadData();
            LoadThongKe();
        }

        private void LoadHoaDon()
        {
            try
            {
                using (var db = new DbChungCu())
                {
                    var list = db.hoa_don
                        .Include("can_ho")
                        .OrderByDescending(h => h.ngay_tao)
                        .ToList()
                        .Select(h => new
                        {
                            h.id,
                            Display = $"HD#{h.id} – {h.can_ho.so_can_ho} – {h.thang_nam:MM/yyyy} – {h.tong_tien:#,##0} đ"
                        })
                        .ToList();

                    cboHoaDon.DataSource = null;
                    cboHoaDon.DataSource = list;
                    cboHoaDon.DisplayMember = "Display";
                    cboHoaDon.ValueMember = "id";
                    cboHoaDon.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải hóa đơn:\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadData()
        {
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;

            try
            {
                using (var db = new DbChungCu())
                {
                    AutoUpdateQuaHan(db);

                    var list = db.cong_no
                        .Include("can_ho")
                        .Include("hoa_don")
                        .OrderByDescending(c => c.id)
                        .ToList()
                        .Select(c => new CongNoViewModel
                        {
                            id = c.id,
                            hoa_don_id = c.hoa_don_id,
                            can_ho_id = c.can_ho_id,
                            so_tien_no = c.so_tien_no,
                            han_thanh_toan = c.han_thanh_toan,
                            trang_thai = c.trang_thai,
                            MaHoaDon = c.hoa_don != null ? $"HD#{c.hoa_don.id}" : "(Chưa có)",
                            SoCanHo = c.can_ho != null ? c.can_ho.so_can_ho : "",
                            TenCuDan = LayTenCuDan(db, c.can_ho_id),
                            SoTienNoFormat = c.so_tien_no.ToString("#,##0") + " đ",
                            HanThanhToanFormat = c.han_thanh_toan.HasValue
                                                 ? c.han_thanh_toan.Value.ToString("dd/MM/yyyy")
                                                 : "—"
                        })
                        .ToList();

                    BindGrid(list);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu:\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadThongKe()
        {
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;
            try
            {
                using (var db = new DbChungCu())
                {
                    var all = db.cong_no.ToList();
                    decimal tongNo = all.Sum(c => c.so_tien_no);
                    int daThanhToan = all.Count(c => c.trang_thai == "da_tra");
                    int quaHan = all.Count(c => c.trang_thai == "qua_han");

                    lblTongCongNo.Text = tongNo.ToString("#,##0") + " đ";
                    lblDaThanhToan.Text = daThanhToan.ToString();
                    lblQuaHan.Text = quaHan.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải thống kê:\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchCongNo(string keyword)
        {
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;

            try
            {
                keyword = keyword?.Trim().ToLower() ?? "";

                using (var db = new DbChungCu())
                {
                    var list = db.cong_no
                        .Include("can_ho")
                        .Include("hoa_don")
                        .ToList()
                        .Select(c => new CongNoViewModel
                        {
                            id = c.id,
                            hoa_don_id = c.hoa_don_id,
                            can_ho_id = c.can_ho_id,
                            so_tien_no = c.so_tien_no,
                            han_thanh_toan = c.han_thanh_toan,
                            trang_thai = c.trang_thai,
                            MaHoaDon = c.hoa_don != null ? $"HD#{c.hoa_don.id}" : "(Chua co)",
                            SoCanHo = c.can_ho != null ? c.can_ho.so_can_ho : "",
                            TenCuDan = LayTenCuDan(db, c.can_ho_id),
                            SoTienNoFormat = c.so_tien_no.ToString("#,##0") + " d",
                            HanThanhToanFormat = c.han_thanh_toan.HasValue
                                                 ? c.han_thanh_toan.Value.ToString("dd/MM/yyyy")
                                                 : "—"
                        })
                        .Where(c =>
                            string.IsNullOrEmpty(keyword) ||
                            c.SoCanHo.ToLower().Contains(keyword) ||
                            c.TenCuDan.ToLower().Contains(keyword) ||
                            c.trang_thai.ToLower().Contains(keyword) ||
                            c.MaHoaDon.ToLower().Contains(keyword))
                        .OrderByDescending(c => c.id)
                        .ToList();

                    BindGrid(list);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm:\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InsertCongNo()
        {
            if (!ValidateForm()) return;

            try
            {
                using (var db = new DbChungCu())
                {
                    int hoaDonId = GetSelectedHoaDonId();
                    var hoaDon = db.hoa_don.FirstOrDefault(h => h.id == hoaDonId);
                    if (hoaDon == null)
                    {
                        MessageBox.Show("Không tìm thấy hóa đơn!", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string trangThai = MappingTrangThai(cboTrangThai.SelectedItem?.ToString());

                    var congNo = new cong_no
                    {
                        hoa_don_id = hoaDonId,
                        can_ho_id = hoaDon.can_ho_id,
                        so_tien_no = decimal.Parse(txtSoTienNo.Text.Trim()),
                        han_thanh_toan = dtHanThanhToan.Value.Date,
                        trang_thai = trangThai
                    };

                    db.cong_no.Add(congNo);
                    db.SaveChanges();
                    AuditLogHelper.GhiLog("THÊM", "cong_no", congNo.id,
    $"Thêm công nợ HD#{hoaDonId} – {congNo.so_tien_no:#,##0} đ – {trangThai}");
                }

                MessageBox.Show("Thêm công nợ thành công!", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                LoadThongKe();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm công nợ:\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateCongNo()
        {
            if (_selectedId <= 0)
            {
                MessageBox.Show("Vui lòng chọn công nợ cần sửa!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateForm()) return;

            try
            {
                using (var db = new DbChungCu())
                {
                    var congNo = db.cong_no.FirstOrDefault(c => c.id == _selectedId);
                    if (congNo == null)
                    {
                        MessageBox.Show("Không tìm thấy công nợ!",
                            "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    int hoaDonId = GetSelectedHoaDonId();
                    var hoaDon = db.hoa_don.FirstOrDefault(h => h.id == hoaDonId);
                    if (hoaDon == null)
                    {
                        MessageBox.Show("Không tìm thấy hóa đơn!", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    congNo.hoa_don_id = hoaDonId;
                    congNo.can_ho_id = hoaDon.can_ho_id;
                    congNo.so_tien_no = decimal.Parse(txtSoTienNo.Text.Trim());
                    congNo.han_thanh_toan = dtHanThanhToan.Value.Date;
                    congNo.trang_thai = MappingTrangThai(cboTrangThai.SelectedItem?.ToString());

                    db.SaveChanges();
                    AuditLogHelper.GhiLog("SỬA", "cong_no", _selectedId,
    $"Cập nhật công nợ #{_selectedId} – {congNo.so_tien_no:#,##0} đ – {congNo.trang_thai}");
                }

                MessageBox.Show("Cập nhật công nợ thành công!", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                LoadThongKe();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật công nợ:\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteCongNo()
        {
            if (_selectedId <= 0)
            {
                MessageBox.Show("Vui lòng chọn công nợ cần xóa!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show(
                "Bạn có chắc muốn xóa công nợ này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            try
            {
                using (var db = new DbChungCu())
                {
                    var congNo = db.cong_no.FirstOrDefault(c => c.id == _selectedId);
                    if (congNo == null)
                    {
                        MessageBox.Show("Không tìm thấy công nợ!",
                            "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string logInfo = $"Xóa công nợ #{congNo.id} – {congNo.so_tien_no:#,##0} đ – {congNo.trang_thai}";

                    db.cong_no.Remove(congNo);
                    db.SaveChanges();
                    AuditLogHelper.GhiLog("XÓA", "cong_no", _selectedId, logInfo);
                }

                MessageBox.Show("Xóa công nợ thành công!", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                LoadThongKe();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa công nợ:\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            _selectedId = -1;
            cboHoaDon.SelectedIndex = -1;
            dtHanThanhToan.Value = DateTime.Today;
            txtSoTienNo.Text = "";
            txtGhiChu.Text = "";
            cboTrangThai.SelectedIndex = 0;
            txtSearch.Text = "";
            dgvCongNo.ClearSelection();
        }

        private void btnThem_Click(object sender, EventArgs e) => InsertCongNo();
        private void btnSua_Click(object sender, EventArgs e) => UpdateCongNo();
        private void btnXoa_Click(object sender, EventArgs e) => DeleteCongNo();
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearForm();
            LoadData();
            LoadThongKe();
        }

        private void dgvCongNo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                var row = dgvCongNo.Rows[e.RowIndex];
                if (row.DataBoundItem is CongNoViewModel vm)
                {
                    _selectedId = vm.id;

                    // Chọn hóa đơn trong combo
                    if (vm.hoa_don_id.HasValue)
                        SetComboById(cboHoaDon, vm.hoa_don_id.Value);
                    else
                        cboHoaDon.SelectedIndex = -1;

                    // Ngày hạn
                    dtHanThanhToan.Value = vm.han_thanh_toan ?? DateTime.Today;

                    // Số tiền
                    txtSoTienNo.Text = vm.so_tien_no.ToString("#,##0");

                    // Ghi chú (field ảo, để trống)
                    txtGhiChu.Text = "";

                    // Trạng thái
                    SetComboByDisplay(cboTrangThai, vm.trang_thai);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi chọn dòng:\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchCongNo(txtSearch.Text);
        }
        private void AutoUpdateQuaHan(DbChungCu db)
        {
            try
            {
                var today = DateTime.Today;
                var list = db.cong_no
                    .Where(c => c.trang_thai == "chua_tra"
                             && c.han_thanh_toan.HasValue
                             && c.han_thanh_toan.Value < today)
                    .ToList();
                foreach (var item in list) item.trang_thai = "qua_han";
                if (list.Count > 0) db.SaveChanges();
            }
            catch { }
        }

        private string LayTenCuDan(DbChungCu db, int canHoId)
        {
            try
            {
                var hopDong = db.hop_dong
                    .Include("cu_dan")
                    .Where(h => h.can_ho_id == canHoId && h.trang_thai == "active")
                    .FirstOrDefault()
                    ?? db.hop_dong
                        .Include("cu_dan")
                        .Where(h => h.can_ho_id == canHoId)
                        .OrderByDescending(h => h.ngay_bat_dau)
                        .FirstOrDefault();

                return hopDong?.cu_dan?.ho_ten ?? "—";
            }
            catch
            {
                return "—";
            }
        }

        private void BindGrid(List<CongNoViewModel> list)
        {
            dgvCongNo.DataSource = null;
            dgvCongNo.DataSource = list;
        }

        private int GetSelectedHoaDonId()
        {
            if (cboHoaDon.SelectedValue == null) return 0;
            return Convert.ToInt32(cboHoaDon.SelectedValue);
        }

        private void SetComboById(ComboBox cbo, int id)
        {
            foreach (var item in cbo.Items)
            {
                var prop = item.GetType().GetProperty("id");
                if (prop != null && Convert.ToInt32(prop.GetValue(item)) == id)
                {
                    cbo.SelectedItem = item;
                    return;
                }
            }
            cbo.SelectedIndex = -1;
        }

        private void SetComboByDisplay(ComboBox cbo, string dbValue)
        {
            string display = ReverseMapTrangThai(dbValue);
            for (int i = 0; i < cbo.Items.Count; i++)
            {
                if (cbo.Items[i].ToString() == display)
                {
                    cbo.SelectedIndex = i;
                    return;
                }
            }
            cbo.SelectedIndex = 0;
        }

        private string MappingTrangThai(string display)
        {
            switch (display)
            {
                case "Đã trả": return "da_tra";
                case "Quá hạn": return "qua_han";
                default: return "chua_tra";
            }
        }

        private string ReverseMapTrangThai(string dbValue)
        {
            switch (dbValue)
            {
                case "da_tra": return "Đã trả";
                case "qua_han": return "Quá hạn";
                default: return "Chưa trả";
            }
        }


        private bool ValidateForm()
        {
            if (cboHoaDon.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn!", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboHoaDon.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSoTienNo.Text))
            {
                MessageBox.Show("Vui lòng nhập số tiền nợ!", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoTienNo.Focus();
                return false;
            }

            string soTienText = txtSoTienNo.Text.Replace(",", "").Trim();
            if (!decimal.TryParse(soTienText, out decimal soTien) || soTien <= 0)
            {
                MessageBox.Show("Số tiền nợ không hợp lệ!", "Lỗi dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoTienNo.Focus();
                return false;
            }

            txtSoTienNo.Text = soTien.ToString("#,##0");

            if (cboTrangThai.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn trạng thái!", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboTrangThai.Focus();
                return false;
            }

            return true;
        }
        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            frmBaoCaoCongNo f = new frmBaoCaoCongNo();
            f.ShowDialog();
        }
    }

    internal class CongNoViewModel
    {
        public int id { get; set; }
        public int? hoa_don_id { get; set; }
        public int can_ho_id { get; set; }
        public decimal so_tien_no { get; set; }
        public DateTime? han_thanh_toan { get; set; }
        public string trang_thai { get; set; }

        public string MaHoaDon { get; set; }
        public string SoCanHo { get; set; }
        public string TenCuDan { get; set; }
        public string SoTienNoFormat { get; set; }
        public string HanThanhToanFormat { get; set; }
    }
}