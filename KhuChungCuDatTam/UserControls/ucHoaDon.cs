using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using KhuChungCuDatTam.Helpers;
using KhuChungCuDatTam.Models;

namespace KhuChungCuDatTam.UserControls
{
    public partial class ucHoaDon : UserControl
    {
        private int _selectedId = -1;
        private bool _isSearching = false;
        private List<HoaDonView> _allData = new List<HoaDonView>();

        private class HoaDonView
        {
            public int Id { get; set; }
            public string CanHo { get; set; }
            public string CuDan { get; set; }
            public string ThangNam { get; set; }
            public string TienDien { get; set; }
            public string TienNuoc { get; set; }
            public string PhiGuiXe { get; set; }
            public string PhiDichVu { get; set; }
            public string PhiKhac { get; set; }
            public string TongTien { get; set; }
            public string NgayTao { get; set; }
            public string TrangThai { get; set; }
        }

        public ucHoaDon()
        {
            InitializeComponent();

            if (!DesignMode)
            {
                SetupEvents();
                SetupGridColumns();
                LoadCanHo();
                LoadData();
                LoadThongKe();
            }
        }

        private void SetupEvents()
        {
            btnThem.Click += (s, e) => InsertHoaDon();
            btnSua.Click += (s, e) => UpdateHoaDon();
            btnXoa.Click += (s, e) => DeleteHoaDon();
            btnLamMoi.Click += (s, e) => ClearForm();
            btnTinhTong.Click += (s, e) => CalculateTongTien();

            dgvHoaDon.SelectionChanged += DgvHoaDon_SelectionChanged;

            txtSearch.GotFocus += (s, e) =>
            {
                if (txtSearch.Text == "🔍  Tìm kiếm hóa đơn...")
                {
                    txtSearch.Text = "";
                    txtSearch.ForeColor = Color.White;
                }
            };
            txtSearch.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    txtSearch.Text = "🔍  Tìm kiếm hóa đơn...";
                    txtSearch.ForeColor = Color.FromArgb(148, 163, 184);
                }
            };
            txtSearch.TextChanged += (s, e) => SearchHoaDon();

            txtTienDien.TextChanged += (s, e) => CalculateTongTien();
            txtTienNuoc.TextChanged += (s, e) => CalculateTongTien();
            txtPhiGuiXe.TextChanged += (s, e) => CalculateTongTien();
            txtPhiDichVu.TextChanged += (s, e) => CalculateTongTien();
            txtTienPhiKhac.TextChanged += (s, e) => CalculateTongTien();
        }

        private void SetupGridColumns()
        {
            dgvHoaDon.Columns.Clear();
            var cols = new[]
            {
                ("Id",       "ID",          50,  false),
                ("CanHo",    "Căn Hộ",      80,  true),
                ("CuDan",    "Cư Dân",      160, true),
                ("ThangNam", "Tháng/Năm",   90,  true),
                ("TienDien", "Tiền Điện",   100, true),
                ("TienNuoc", "Tiền Nước",   100, true),
                ("PhiGuiXe", "Phí Gửi Xe", 100, true),
                ("PhiDichVu","Phí DV/BT",  100, true),
                ("PhiKhac",  "Phí Khác",   90,  true),
                ("TongTien", "Tổng Tiền",  120, true),
                ("NgayTao",  "Ngày Tạo",   90,  true),
                ("TrangThai","Trạng Thái", 120, true),
            };

            foreach (var (prop, header, minW, visible) in cols)
            {
                var col = new DataGridViewTextBoxColumn
                {
                    DataPropertyName = prop,
                    HeaderText = header,
                    MinimumWidth = minW,
                    Visible = visible,
                    Name = "col_" + prop
                };
                dgvHoaDon.Columns.Add(col);
            }
        }

        private void LoadCanHo()
        {
            try
            {
                using (var db = new DbChungCu())
                {
                    var list = db.can_ho
                        .Include(c => c.cu_dan)
                        .OrderBy(c => c.so_can_ho)
                        .ToList()
                        .Select(c => new
                        {
                            c.id,
                            Display = $"{c.so_can_ho} — {c.cu_dan.FirstOrDefault()?.ho_ten ?? "Chưa có cư dân"}"
                        })
                        .ToList();

                    cboCanHo.DataSource = null;
                    cboCanHo.DataSource = list;
                    cboCanHo.DisplayMember = "Display";
                    cboCanHo.ValueMember = "id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách căn hộ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadData()
        {
            try
            {
                using (var db = new DbChungCu())
                {
                    var list = db.hoa_don
                        .Include(h => h.can_ho)
                        .Include(h => h.can_ho.cu_dan)
                        .OrderByDescending(h => h.ngay_tao)
                        .ToList();

                    _allData = list.Select(h => new HoaDonView
                    {
                        Id = h.id,
                        CanHo = h.can_ho?.so_can_ho ?? "—",
                        CuDan = h.can_ho?.cu_dan?.FirstOrDefault()?.ho_ten ?? "—",
                        ThangNam = h.thang_nam.ToString("MM/yyyy"),
                        TienDien = FormatMoney(h.tien_dien),
                        TienNuoc = FormatMoney(h.tien_nuoc),
                        PhiGuiXe = FormatMoney(h.tien_gui_xe),
                        PhiDichVu = FormatMoney(h.tien_bao_tri),
                        PhiKhac = FormatMoney(h.tien_phi_khac),
                        TongTien = FormatMoney(h.tong_tien),
                        NgayTao = h.ngay_tao.ToString("dd/MM/yyyy"),
                        TrangThai = MapTrangThai(h.trang_thai)
                    }).ToList();

                    BindGrid(_allData);
                    LoadThongKe();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadThongKe()
        {
            try
            {
                using (var db = new DbChungCu())
                {
                    var all = db.hoa_don.ToList();
                    lblTongHoaDonVal.Text = all.Count.ToString();
                    lblDaThanhToanVal.Text = all.Count(h => h.trang_thai == "da_thanh_toan").ToString();
                    lblChuaThanhToanVal.Text = all.Count(h => h.trang_thai == "chua_thanh_toan").ToString();
                    lblQuaHanVal.Text = all.Count(h => h.trang_thai == "qua_han").ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải thống kê: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BindGrid(List<HoaDonView> data)
        {
            dgvHoaDon.DataSource = null;
            dgvHoaDon.DataSource = data;
        }

        public void SearchHoaDon()
        {
            string keyword = txtSearch.Text.Trim().ToLower();
            if (string.IsNullOrWhiteSpace(keyword) || keyword == "🔍  tìm kiếm hóa đơn...")
            {
                BindGrid(_allData);
                return;
            }

            var filtered = _allData
                .Where(h =>
                    h.CanHo.ToLower().Contains(keyword) ||
                    h.CuDan.ToLower().Contains(keyword) ||
                    h.ThangNam.Contains(keyword) ||
                    h.TrangThai.ToLower().Contains(keyword) ||
                    h.TongTien.ToLower().Contains(keyword))
                .ToList();

            BindGrid(filtered);
        }

        private void DgvHoaDon_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHoaDon.SelectedRows.Count == 0) return;

            var row = dgvHoaDon.SelectedRows[0];
            if (row.DataBoundItem is HoaDonView view)
            {
                _selectedId = view.Id;
                FillFormFromId(_selectedId);
            }
        }

        private void FillFormFromId(int id)
        {
            try
            {
                using (var db = new DbChungCu())
                {
                    var h = db.hoa_don
                        .Include(x => x.can_ho)
                        .FirstOrDefault(x => x.id == id);

                    if (h == null) return;

                    cboCanHo.SelectedValue = h.can_ho_id;
                    dtThangNam.Value = h.thang_nam;
                    txtTienDien.Text = h.tien_dien.ToString("#,##0");
                    txtTienNuoc.Text = h.tien_nuoc.ToString("#,##0");
                    txtPhiGuiXe.Text = h.tien_gui_xe.ToString("#,##0");
                    txtPhiDichVu.Text = h.tien_bao_tri.ToString("#,##0");
                    txtTienPhiKhac.Text = h.tien_phi_khac.ToString("#,##0");
                    txtTongTien.Text = h.tong_tien.ToString("#,##0");
                    dtNgayTao.Value = h.ngay_tao;
                    cboTrangThai.SelectedItem = MapTrangThai(h.trang_thai);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đọc dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CalculateTongTien()
        {
            decimal dien = ParseDecimal(txtTienDien.Text);
            decimal nuoc = ParseDecimal(txtTienNuoc.Text);
            decimal xe = ParseDecimal(txtPhiGuiXe.Text);
            decimal baoTri = ParseDecimal(txtPhiDichVu.Text);
            decimal khac = ParseDecimal(txtTienPhiKhac.Text);

            decimal tong = dien + nuoc + xe + baoTri + khac;

            txtTongTien.Text = tong.ToString("#,##0");
        }

        public void InsertHoaDon()
        {
            if (!ValidateForm()) return;

            try
            {
                using (var db = new DbChungCu())
                {
                    var hd = new hoa_don
                    {
                        can_ho_id = (int)cboCanHo.SelectedValue,
                        thang_nam = new DateTime(dtThangNam.Value.Year, dtThangNam.Value.Month, 1),
                        tien_dien = ParseDecimal(txtTienDien.Text),
                        tien_nuoc = ParseDecimal(txtTienNuoc.Text),
                        tien_gui_xe = ParseDecimal(txtPhiGuiXe.Text),
                        tien_bao_tri = ParseDecimal(txtPhiDichVu.Text),
                        tien_phi_khac = ParseDecimal(txtTienPhiKhac.Text),
                        tong_tien = ParseDecimal(txtTongTien.Text),
                        ngay_tao = dtNgayTao.Value,
                        trang_thai = MapTrangThaiReverse(cboTrangThai.SelectedItem?.ToString())
                    };

                    db.hoa_don.Add(hd);
                    db.SaveChanges();
                    AuditLogHelper.GhiLog("THÊM", "hoa_don", hd.id,
    $"Thêm hóa đơn #{hd.id} – căn hộ ID {hd.can_ho_id} – {hd.thang_nam:MM/yyyy} – {hd.tong_tien:#,##0} đ");
                }

                MessageBox.Show("✅ Thêm hóa đơn thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateHoaDon()
        {
            if (_selectedId <= 0)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!ValidateForm()) return;

            try
            {
                using (var db = new DbChungCu())
                {
                    var hd = db.hoa_don.FirstOrDefault(h => h.id == _selectedId);
                    if (hd == null)
                    {
                        MessageBox.Show("Không tìm thấy hóa đơn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    hd.can_ho_id = (int)cboCanHo.SelectedValue;
                    hd.thang_nam = new DateTime(dtThangNam.Value.Year, dtThangNam.Value.Month, 1);
                    hd.tien_dien = ParseDecimal(txtTienDien.Text);
                    hd.tien_nuoc = ParseDecimal(txtTienNuoc.Text);
                    hd.tien_gui_xe = ParseDecimal(txtPhiGuiXe.Text);
                    hd.tien_bao_tri = ParseDecimal(txtPhiDichVu.Text);
                    hd.tien_phi_khac = ParseDecimal(txtTienPhiKhac.Text);
                    hd.tong_tien = ParseDecimal(txtTongTien.Text);
                    hd.ngay_tao = dtNgayTao.Value;
                    hd.trang_thai = MapTrangThaiReverse(cboTrangThai.SelectedItem?.ToString());

                    db.SaveChanges();
                    AuditLogHelper.GhiLog("SỬA", "hoa_don", _selectedId,
    $"Cập nhật hóa đơn #{_selectedId} – {hd.thang_nam:MM/yyyy} – {hd.tong_tien:#,##0} đ – {hd.trang_thai}");
                }

                MessageBox.Show("✅ Cập nhật hóa đơn thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DeleteHoaDon()
        {
            if (_selectedId <= 0)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show(
                "Bạn có chắc muốn xóa hóa đơn này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            try
            {
                using (var db = new DbChungCu())
                {
                    var hd = db.hoa_don
                        .Include(h => h.hoa_don_chi_tiet)
                        .Include(h => h.cong_no)
                        .Include(h => h.thanh_toan)
                        .FirstOrDefault(h => h.id == _selectedId);

                    if (hd == null)
                    {
                        MessageBox.Show("Không tìm thấy hóa đơn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string logInfo = $"Xóa hóa đơn #{hd.id} – căn hộ ID {hd.can_ho_id} – {hd.thang_nam:MM/yyyy} – {hd.tong_tien:#,##0} đ";
                    int deletedId = hd.id;
                    db.hoa_don_chi_tiet.RemoveRange(hd.hoa_don_chi_tiet);
                    db.cong_no.RemoveRange(hd.cong_no);
                    db.thanh_toan.RemoveRange(hd.thanh_toan);
                    db.hoa_don.Remove(hd);
                    db.SaveChanges();
                    AuditLogHelper.GhiLog("XÓA", "hoa_don", deletedId, logInfo);
                }

                MessageBox.Show("✅ Xóa hóa đơn thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ClearForm()
        {
            _selectedId = -1;
            if (cboCanHo.Items.Count > 0) cboCanHo.SelectedIndex = 0;
            dtThangNam.Value = DateTime.Today;
            txtTienDien.Text = "0";
            txtTienNuoc.Text = "0";
            txtPhiGuiXe.Text = "0";
            txtPhiDichVu.Text = "0";
            txtTienPhiKhac.Text = "0";
            txtTongTien.Text = "0";
            dtNgayTao.Value = DateTime.Today;
            cboTrangThai.SelectedIndex = 0;
            dgvHoaDon.ClearSelection();
        }

        private bool ValidateForm()
        {
            if (cboCanHo.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn căn hộ!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboCanHo.Focus();
                return false;
            }

            if (!TryParseDecimalPositive(txtTienDien.Text, out _))
            {
                MessageBox.Show("Tiền điện phải là số không âm!", "Dữ liệu không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTienDien.Focus();
                return false;
            }
            if (!TryParseDecimalPositive(txtTienNuoc.Text, out _))
            {
                MessageBox.Show("Tiền nước phải là số không âm!", "Dữ liệu không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTienNuoc.Focus();
                return false;
            }
            if (!TryParseDecimalPositive(txtPhiGuiXe.Text, out _))
            {
                MessageBox.Show("Phí gửi xe phải là số không âm!", "Dữ liệu không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhiGuiXe.Focus();
                return false;
            }
            if (!TryParseDecimalPositive(txtPhiDichVu.Text, out _))
            {
                MessageBox.Show("Phí dịch vụ phải là số không âm!", "Dữ liệu không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhiDichVu.Focus();
                return false;
            }
            if (!TryParseDecimalPositive(txtTienPhiKhac.Text, out _))
            {
                MessageBox.Show("Phí khác phải là số không âm!", "Dữ liệu không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTienPhiKhac.Focus();
                return false;
            }

            return true;
        }

        private decimal ParseDecimal(string text)
        {
            if (decimal.TryParse(text.Replace(",", "").Trim(), out decimal val))
                return val < 0 ? 0 : val;
            return 0;
        }

        private bool TryParseDecimalPositive(string text, out decimal result)
        {
            result = 0;
            if (!decimal.TryParse(text.Replace(",", "").Trim(), out decimal val)) return false;
            if (val < 0) return false;
            result = val;
            return true;
        }

        private string FormatMoney(decimal amount)
            => amount.ToString("N0") + " đ";

        private string MapTrangThai(string dbVal)
        {
            switch (dbVal?.ToLower())
            {
                case "chua_thanh_toan": return "Chưa thanh toán";
                case "da_thanh_toan": return "Đã thanh toán";
                case "qua_han": return "Quá hạn";
                default: return dbVal ?? "—";
            }
        }
        private string MapTrangThaiReverse(string display)
        {
            switch (display)
            {
                case "Đã thanh toán": return "da_thanh_toan";
                case "Quá hạn": return "qua_han";
                default: return "chua_thanh_toan";
            }
        }
    }
}