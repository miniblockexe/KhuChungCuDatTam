    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;
    using KhuChungCuDatTam.Helpers;
    using KhuChungCuDatTam.Models;

namespace KhuChungCuDatTam.UserControls
{
    public partial class ucThanhToan : UserControl
    {
        private int _selectedId = -1;
        private bool _isSearchPlaceholder = true;
        private List<ThanhToanViewModel> _allData = new List<ThanhToanViewModel>();


        private class ThanhToanViewModel
        {
            public int Id { get; set; }
            public int HoaDonId { get; set; }
            public string MaPhieuThu { get; set; }
            public string CanHo { get; set; }
            public string CuDan { get; set; }
            public decimal SoTien { get; set; }
            public string SoTienHienThi { get; set; }
            public DateTime NgayThanhToan { get; set; }
            public string NgayHienThi { get; set; }
            public string PhuongThuc { get; set; }
            public string TrangThaiHoaDon { get; set; }
        }

        public ucThanhToan()
        {
            InitializeComponent();
            SetupPostInit();
        }

        private void SetupPostInit()
        {
            cboPhuongThuc.Items.Clear();
            cboPhuongThuc.Items.AddRange(new object[]
            {
        "the",
        "chuyen_khoan",
        "tien_mat"
            });

            cboTrangThai.Items.Clear();
            cboTrangThai.Items.AddRange(new object[]
            {
        "qua_han",
        "da_tra",
        "chua_tra"
            });
            this.Load += UcThanhToan_Load;
            btnThem.Click += BtnThem_Click;
            btnSua.Click += BtnSua_Click;
            btnXoa.Click += BtnXoa_Click;
            btnLamMoi.Click += BtnLamMoi_Click;
            dgvThanhToan.CellClick += DgvThanhToan_CellClick;
            txtSearch.Enter += TxtSearch_Enter;
            txtSearch.Leave += TxtSearch_Leave;
            txtSearch.TextChanged += TxtSearch_TextChanged;
            cboHoaDon.SelectedIndexChanged += CboHoaDon_SelectedIndexChanged;

            AddHoverEffect(btnThem, Color.FromArgb(59, 130, 246), Color.FromArgb(37, 99, 235));
            AddHoverEffect(btnSua, Color.FromArgb(16, 185, 129), Color.FromArgb(5, 150, 105));
            AddHoverEffect(btnXoa, Color.FromArgb(239, 68, 68), Color.FromArgb(220, 38, 38));
            AddHoverEffect(btnLamMoi, Color.FromArgb(100, 116, 139), Color.FromArgb(71, 85, 105));
        }

        private void AddHoverEffect(Button btn, Color normal, Color hover)
        {
            btn.MouseEnter += (s, e) => btn.BackColor = hover;
            btn.MouseLeave += (s, e) => btn.BackColor = normal;
        }

        private void UcThanhToan_Load(object sender, EventArgs e)
        {
            LoadHoaDon();
            LoadData();
            LoadThongKe();
        }


        public void LoadData()
        {
            try
            {
                using (var db = new DbChungCu())
                {
                    var list = db.thanh_toan
      .Include("hoa_don")
      .Include("hoa_don.can_ho")
      .Include("hoa_don.can_ho.toa_nha")
      .Include("nguoi_dung")
      .Where(t =>
          t.hoa_don != null &&
          (
              // Thay "da_tra" bằng "da_thanh_toan" như trong ảnh bạn chụp
              t.hoa_don.trang_thai == "da_thanh_toan" ||
              t.hoa_don.trang_thai == "chua_tra" ||
              t.hoa_don.trang_thai == "qua_han"
          )
      )
      .OrderByDescending(t => t.ngay_thanh_toan)
      .ToList();
                    var hopDongList = db.hop_dong
                        .Include("cu_dan")
                        .Include("can_ho")
                        .Where(h => h.trang_thai == "dang_hieu_luc")
                        .ToList();

                    _allData = list.Select(t =>
                    {
                        var canHo = t.hoa_don?.can_ho;
                        var soCanHo = canHo != null
                            ? $"{canHo.so_can_ho} - {canHo.toa_nha?.ten_toa}"
                            : "N/A";

                        var hopDong = hopDongList
                            .FirstOrDefault(h => h.can_ho_id == t.hoa_don.can_ho_id);
                        var tenCuDan = hopDong?.cu_dan?.ho_ten ?? "N/A";

                        return new ThanhToanViewModel
                        {
                            Id = t.id,
                            HoaDonId = t.hoa_don_id,
                            MaPhieuThu = t.ma_phieu_thu,
                            CanHo = soCanHo,
                            CuDan = tenCuDan,
                            SoTien = t.so_tien,
                            SoTienHienThi = t.so_tien.ToString("N0") + " ₫",
                            NgayThanhToan = t.ngay_thanh_toan,
                            NgayHienThi = t.ngay_thanh_toan.ToString("dd/MM/yyyy"),
                            PhuongThuc = t.phuong_thuc,
                            TrangThaiHoaDon = t.hoa_don?.trang_thai ?? ""
                        };
                    }).ToList();

                    BindGrid(_allData);
                }
            }
            catch (Exception ex)
            {
                ShowError("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        public void LoadHoaDon()
        {
            try
            {
                using (var db = new DbChungCu())
                {
                    var hoaDons = db.hoa_don
                        .Include("can_ho")
                        .Where(h => h.trang_thai != "da_thanh_toan")
                        .OrderByDescending(h => h.ngay_tao)
                        .ToList()
                        .Select(h => new
                        {
                            h.id,
                            Display = $"HD#{h.id} - {h.can_ho?.so_can_ho} - {h.thang_nam:MM/yyyy} - {h.tong_tien:N0}₫"
                        })
                        .ToList();

                    cboHoaDon.DisplayMember = "Display";
                    cboHoaDon.ValueMember = "id";
                    cboHoaDon.DataSource = hoaDons;
                    cboHoaDon.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                ShowError("Lỗi tải hóa đơn: " + ex.Message);
            }
        }

        public void LoadThongKe()
        {
            try
            {
                using (var db = new DbChungCu())
                {
                    var all = db.thanh_toan.ToList();

                    decimal tongThu = all.Sum(t => t.so_tien);
                    int soGiaoDich = all.Count;

                    decimal homNay = all
                        .Where(t => t.ngay_thanh_toan.Date == DateTime.Today)
                        .Sum(t => t.so_tien);

                    decimal thangNay = all
                        .Where(t => t.ngay_thanh_toan.Month == DateTime.Now.Month
                                 && t.ngay_thanh_toan.Year == DateTime.Now.Year)
                        .Sum(t => t.so_tien);

                    lblTongThuValue.Text = FormatCurrency(tongThu);
                    lblSoLuongValue.Text = soGiaoDich.ToString("N0");
                    lblHomNayValue.Text = FormatCurrency(homNay);
                    lblThangNayValue.Text = FormatCurrency(thangNay);
                }
            }
            catch (Exception ex)
            {
                ShowError("Lỗi tải thống kê: " + ex.Message);
            }
        }

        public void ClearForm()
        {
            _selectedId = -1;
            cboHoaDon.SelectedIndex = -1;
            txtCanHo.Text = string.Empty;
            txtCuDan.Text = string.Empty;
            txtSoTien.Text = string.Empty;
            dtNgayThanhToan.Value = DateTime.Now;
            cboPhuongThuc.SelectedIndex = -1;
            txtMaPhieuThu.Text = string.Empty;
            txtGhiChu.Text = string.Empty;
            cboTrangThai.SelectedIndex = -1;
            btnThem.Enabled = true;
        }

        public void InsertThanhToan()
        {
            if (!ValidateForm()) return;

            try
            {
                using (var db = new DbChungCu())
                {
                    var tt = new thanh_toan
                    {
                        hoa_don_id = (int)cboHoaDon.SelectedValue,
                        so_tien = decimal.Parse(txtSoTien.Text.Replace(",", "").Replace(".", "")),
                        ngay_thanh_toan = dtNgayThanhToan.Value,
                        phuong_thuc = cboPhuongThuc.SelectedItem.ToString(),
                        ma_phieu_thu = string.IsNullOrWhiteSpace(txtMaPhieuThu.Text)
                            ? GenerateMaPhieuThu()
                            : txtMaPhieuThu.Text.Trim(),
                        nhan_vien_thu_id = GetCurrentNhanVienId(db)
                    };

                    db.thanh_toan.Add(tt);
                    db.SaveChanges();
                    AuditLogHelper.GhiLog("THÊM", "thanh_toan", tt.id,
    $"Thêm thanh toán {tt.ma_phieu_thu} – HD#{tt.hoa_don_id} – {tt.so_tien:#,##0} đ – {tt.phuong_thuc}");
                    UpdateTrangThaiHoaDon(db, tt.hoa_don_id, tt.so_tien);

                    ShowSuccess("Thêm thanh toán thành công!");
                    RefreshAll();
                }
            }
            catch (Exception ex)
            {
                ShowError("Lỗi thêm thanh toán: " + ex.Message);
            }
        }

        public void UpdateThanhToan()
        {
            if (_selectedId <= 0)
            {
                ShowWarning("Vui lòng chọn thanh toán cần sửa!");
                return;
            }
            if (!ValidateForm()) return;

            try
            {
                using (var db = new DbChungCu())
                {
                    var tt = db.thanh_toan.FirstOrDefault(t => t.id == _selectedId);
                    if (tt == null)
                    {
                        ShowWarning("Không tìm thấy thanh toán!");
                        return;
                    }

                    tt.hoa_don_id = (int)cboHoaDon.SelectedValue;
                    tt.so_tien = decimal.Parse(txtSoTien.Text.Replace(",", "").Replace(".", ""));
                    tt.ngay_thanh_toan = dtNgayThanhToan.Value;
                    tt.phuong_thuc = cboPhuongThuc.SelectedItem.ToString();
                    if (!string.IsNullOrWhiteSpace(txtMaPhieuThu.Text))
                        tt.ma_phieu_thu = txtMaPhieuThu.Text.Trim();

                    db.SaveChanges();
                    AuditLogHelper.GhiLog("SỬA", "thanh_toan", _selectedId,
    $"Cập nhật thanh toán #{_selectedId} – HD#{tt.hoa_don_id} – {tt.so_tien:#,##0} đ – {tt.phuong_thuc}");

                    ShowSuccess("Cập nhật thanh toán thành công!");
                    RefreshAll();
                }
            }
            catch (Exception ex)
            {
                ShowError("Lỗi cập nhật: " + ex.Message);
            }
        }

        public void DeleteThanhToan()
        {
            if (_selectedId <= 0)
            {
                ShowWarning("Vui lòng chọn thanh toán cần xóa!");
                return;
            }

            var confirm = MessageBox.Show(
                "Bạn có chắc muốn xóa thanh toán này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            try
            {
                using (var db = new DbChungCu())
                {
                    var tt = db.thanh_toan.FirstOrDefault(t => t.id == _selectedId);
                    if (tt == null)
                    {
                        ShowWarning("Không tìm thấy thanh toán!");
                        return;
                    }
                    string logInfo = $"Xóa thanh toán {tt.ma_phieu_thu} – HD#{tt.hoa_don_id} – {tt.so_tien:#,##0} đ";
                    db.thanh_toan.Remove(tt);
                    db.SaveChanges();
                    AuditLogHelper.GhiLog("XÓA", "thanh_toan", _selectedId, logInfo);

                    ShowSuccess("Xóa thanh toán thành công!");
                    RefreshAll();
                }
            }
            catch (Exception ex)
            {
                ShowError("Lỗi xóa: " + ex.Message);
            }
        }

        public void SearchThanhToan(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword) || _isSearchPlaceholder)
            {
                BindGrid(_allData);
                return;
            }

            keyword = keyword.ToLower().Trim();
            var result = _allData.Where(t =>
                (t.MaPhieuThu?.ToLower().Contains(keyword) ?? false) ||
                (t.CanHo?.ToLower().Contains(keyword) ?? false) ||
                (t.CuDan?.ToLower().Contains(keyword) ?? false) ||
                (t.PhuongThuc?.ToLower().Contains(keyword) ?? false) ||
                t.SoTienHienThi.ToLower().Contains(keyword) ||
                t.NgayHienThi.Contains(keyword)
            ).ToList();

            BindGrid(result);
        }

        private void BindGrid(List<ThanhToanViewModel> data)
        {
            var display = data.Select(t => new
            {
                t.Id,
                MaPhieuThu = t.MaPhieuThu,
                CanHo = t.CanHo,
                CuDan = t.CuDan,
                SoTien = t.SoTienHienThi,
                NgayThanhToan = t.NgayHienThi,
                PhuongThuc = t.PhuongThuc,
                TrangThai = t.TrangThaiHoaDon
            }).ToList();

            dgvThanhToan.DataSource = display;

            if (dgvThanhToan.Columns["Id"] != null)
                dgvThanhToan.Columns["Id"].Visible = false;

            SetColumnHeader("MaPhieuThu", "Mã Phiếu Thu");
            SetColumnHeader("CanHo", "Căn Hộ");
            SetColumnHeader("CuDan", "Cư Dân");
            SetColumnHeader("SoTien", "Số Tiền");
            SetColumnHeader("NgayThanhToan", "Ngày TT");
            SetColumnHeader("PhuongThuc", "Phương Thức");
            SetColumnHeader("TrangThai", "Trạng Thái HD");
        }

        private void SetColumnHeader(string colName, string header)
        {
            if (dgvThanhToan.Columns[colName] != null)
                dgvThanhToan.Columns[colName].HeaderText = header;
        }

        private void FillFormFromRow(int id)
        {
            var item = _allData.FirstOrDefault(t => t.Id == id);
            if (item == null) return;

            _selectedId = item.Id;

            // Tắt event tạm để tránh ghi đè
            cboHoaDon.SelectedIndexChanged -= CboHoaDon_SelectedIndexChanged;

            bool found = false;
            foreach (var comboItem in cboHoaDon.Items)
            {
                var prop = comboItem.GetType().GetProperty("id");
                if (prop != null && (int)prop.GetValue(comboItem) == item.HoaDonId)
                {
                    cboHoaDon.SelectedItem = comboItem;
                    found = true;
                    break;
                }
            }

            // Nếu không tìm thấy trong dropdown (hóa đơn đã thanh toán),
            // tự fill thủ công từ dữ liệu có sẵn
            if (!found)
            {
                cboHoaDon.SelectedIndex = -1;
            }

            cboHoaDon.SelectedIndexChanged += CboHoaDon_SelectedIndexChanged;

            // Luôn fill từ _allData (không phụ thuộc vào dropdown trigger)
            txtCanHo.Text = item.CanHo;
            txtCuDan.Text = item.CuDan;
            txtSoTien.Text = item.SoTien.ToString("N0");
            dtNgayThanhToan.Value = item.NgayThanhToan;

            var ptIndex = cboPhuongThuc.Items.IndexOf(item.PhuongThuc);
            cboPhuongThuc.SelectedIndex = ptIndex >= 0 ? ptIndex : -1;

            // Fill mã phiếu thu nếu có
            txtMaPhieuThu.Text = item.MaPhieuThu ?? string.Empty;

            btnThem.Enabled = false;
        }

        private void UpdateTrangThaiHoaDon(DbChungCu db, int hoaDonId, decimal soTienMoi)
        {
            var hoaDon = db.hoa_don.Include("thanh_toan").FirstOrDefault(h => h.id == hoaDonId);
            if (hoaDon == null) return;

            decimal tongDaThanhToan = hoaDon.thanh_toan.Sum(t => t.so_tien);

            if (tongDaThanhToan >= hoaDon.tong_tien)
                hoaDon.trang_thai = "da_thanh_toan";
            else
                hoaDon.trang_thai = "chua_tra";

            db.SaveChanges();
        }

        private bool ValidateForm()
        {
            if (cboHoaDon.SelectedValue == null)
            {
                ShowWarning("Vui lòng chọn hóa đơn!");
                cboHoaDon.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSoTien.Text))
            {
                ShowWarning("Vui lòng nhập số tiền!");
                txtSoTien.Focus();
                return false;
            }

            decimal soTien;
            var cleaned = txtSoTien.Text.Replace(",", "").Replace(".", "").Trim();
            if (!decimal.TryParse(cleaned, out soTien) || soTien <= 0)
            {
                ShowWarning("Số tiền không hợp lệ! Vui lòng nhập số dương.");
                txtSoTien.Focus();
                return false;
            }

            if (cboPhuongThuc.SelectedItem == null)
            {
                ShowWarning("Vui lòng chọn phương thức thanh toán!");
                cboPhuongThuc.Focus();
                return false;
            }

            return true;
        }

        private void RefreshAll()
        {
            ClearForm();
            LoadData();
            LoadThongKe();
            LoadHoaDon();
        }

        private int GetCurrentNhanVienId(DbChungCu db)
        {
            var nd = db.nguoi_dung.FirstOrDefault();
            return nd?.id ?? 1;
        }

        private string GenerateMaPhieuThu()
        {
            return "PT" + DateTime.Now.ToString("yyyyMMddHHmmss");
        }

        private string FormatCurrency(decimal value)
        {
            if (value >= 1_000_000_000)
                return (value / 1_000_000_000).ToString("N1") + " tỷ";
            if (value >= 1_000_000)
                return (value / 1_000_000).ToString("N0") + " tr";
            return value.ToString("N0") + " ₫";
        }

        private void ShowSuccess(string msg) =>
            MessageBox.Show(msg, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

        private void ShowWarning(string msg) =>
            MessageBox.Show(msg, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        private void ShowError(string msg) =>
            MessageBox.Show(msg, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);


        private void BtnThem_Click(object sender, EventArgs e) => InsertThanhToan();
        private void BtnSua_Click(object sender, EventArgs e) => UpdateThanhToan();
        private void BtnXoa_Click(object sender, EventArgs e) => DeleteThanhToan();
        private void BtnLamMoi_Click(object sender, EventArgs e) => RefreshAll();

        private void DgvThanhToan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            try
            {
                var idCell = dgvThanhToan.Rows[e.RowIndex].Cells["Id"];
                if (idCell?.Value == null) return;
                int id = Convert.ToInt32(idCell.Value);
                FillFormFromRow(id);
            }
            catch { /* ignore */ }
        }

        private void TxtSearch_Enter(object sender, EventArgs e)
        {
            if (_isSearchPlaceholder)
            {
                _isSearchPlaceholder = false;
                txtSearch.Text = string.Empty;
                txtSearch.ForeColor = Color.FromArgb(226, 232, 240);
            }
        }

        private void TxtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                _isSearchPlaceholder = true;
                txtSearch.Text = "Tìm kiếm theo mã phiếu, cư dân, căn hộ...";
                txtSearch.ForeColor = Color.FromArgb(100, 116, 139);
                BindGrid(_allData);
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (!_isSearchPlaceholder)
                SearchThanhToan(txtSearch.Text);
        }

        private void CboHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboHoaDon.SelectedValue == null) return;

            try
            {
                int hoaDonId = (int)cboHoaDon.SelectedValue;

                using (var db = new DbChungCu())
                {
                    var hoaDon = db.hoa_don
                        .Include("can_ho")
                        .Include("can_ho.toa_nha")
                        .FirstOrDefault(h => h.id == hoaDonId);

                    if (hoaDon == null) return;

                    var canHo = hoaDon.can_ho;
                    txtCanHo.Text = canHo != null
                        ? $"{canHo.so_can_ho} - {canHo.toa_nha?.ten_toa}"
                        : "N/A";

                    var hopDong = db.hop_dong
                        .Include("cu_dan")
                        .FirstOrDefault(h => h.can_ho_id == hoaDon.can_ho_id
                            && h.trang_thai == "chua_thanh_toan");

                    if (hopDong == null)
                    {
                        hopDong = db.hop_dong
                            .Include("cu_dan")
                            .Where(h => h.can_ho_id == hoaDon.can_ho_id)
                            .OrderByDescending(h => h.id)
                            .FirstOrDefault();
                    }

                    txtCuDan.Text = hopDong?.cu_dan?.ho_ten ?? "N/A";
                    txtSoTien.Text = hoaDon.tong_tien.ToString("N0");
                }
            }
            catch { /* ignore */ }
        }
    }
}