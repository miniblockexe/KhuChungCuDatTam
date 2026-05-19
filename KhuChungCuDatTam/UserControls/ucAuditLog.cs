using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using KhuChungCuDatTam.Models;

namespace KhuChungCuDatTam.UserControls
{
    public partial class ucAuditLog : UserControl
    {
        private List<AuditLogViewModel> _allData = new List<AuditLogViewModel>();
        private List<AuditLogViewModel> _filteredData = new List<AuditLogViewModel>();

        public ucAuditLog()
        {
            InitializeComponent();

            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return;

            this.Load += ucAuditLog_Load;
            btnLoc.Click += btnLoc_Click;
            btnLamMoi.Click += btnLamMoi_Click;
            btnXuatExcel.Click += btnXuatExcel_Click;
            txtSearch.TextChanged += txtSearch_TextChanged;
        }

        private void ucAuditLog_Load(object sender, EventArgs e)
        {
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return;

            try
            {
                dtTuNgay.Value = DateTime.Today.AddDays(-30);
                dtDenNgay.Value = DateTime.Today;

                LoadNguoiDung();
                LoadModule();
                LoadData();
                LoadThongKe();
                ApplyRowAlternateColor();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khởi tạo: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            FilterAuditLog();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearFilter();
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            ExportExcel();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchAuditLog();
        }

        public void LoadData()
        {
            try
            {
                using (var db = new DbChungCu())
                {
                    var logs = db.audit_log
                        .Include("nguoi_dung")
                        .OrderByDescending(x => x.thoi_gian)
                        .ToList();

                    int stt = 1;
                    _allData = logs.Select(x => new AuditLogViewModel
                    {
                        stt = stt++,
                        id = x.id,
                        nguoi_dung_id = x.nguoi_dung_id,
                        ten_nguoi_dung = x.nguoi_dung != null
                                            ? (x.nguoi_dung.ho_ten ?? x.nguoi_dung.ten_dang_nhap)
                                            : "N/A",
                        hanh_dong = x.hanh_dong ?? string.Empty,
                        bang = x.bang ?? string.Empty,
                        ban_ghi_id = x.ban_ghi_id,
                        mo_ta = x.mo_ta ?? string.Empty,
                        thoi_gian = x.thoi_gian,
                        thoi_gian_str = x.thoi_gian.ToString("dd/MM/yyyy HH:mm:ss")
                    }).ToList();

                    _filteredData = new List<AuditLogViewModel>(_allData);
                    BindGrid(_filteredData);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải dữ liệu: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadNguoiDung()
        {
            try
            {
                using (var db = new DbChungCu())
                {
                    var danhSach = db.nguoi_dung
                        .OrderBy(x => x.ho_ten)
                        .Select(x => new { x.id, TenHienThi = x.ho_ten ?? x.ten_dang_nhap })
                        .ToList();

                    cboNguoiDung.Items.Clear();
                    cboNguoiDung.Items.Add(new ComboItem { Id = 0, TenHienThi = "-- Tất cả --" });

                    foreach (var nd in danhSach)
                        cboNguoiDung.Items.Add(new ComboItem { Id = nd.id, TenHienThi = nd.TenHienThi });

                    cboNguoiDung.DisplayMember = "TenHienThi";
                    cboNguoiDung.ValueMember = "Id";
                    cboNguoiDung.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải người dùng: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadModule()
        {
            try
            {
                using (var db = new DbChungCu())
                {
                    var modules = db.audit_log
                        .Where(x => x.bang != null && x.bang != "")
                        .Select(x => x.bang)
                        .Distinct()
                        .OrderBy(x => x)
                        .ToList();

                    cboModule.Items.Clear();
                    cboModule.Items.Add("-- Tất cả --");

                    foreach (var m in modules)
                        cboModule.Items.Add(m);

                    cboModule.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải module: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadThongKe()
        {
            try
            {
                using (var db = new DbChungCu())
                {
                    int tongLog = db.audit_log.Count();

                    DateTime homNayBatDau = DateTime.Today;
                    DateTime homNayKetThuc = DateTime.Today.AddDays(1);
                    int homNay = db.audit_log
                        .Count(x => x.thoi_gian >= homNayBatDau && x.thoi_gian < homNayKetThuc);

                    int nguoiDungHoatDong = db.audit_log
                        .Select(x => x.nguoi_dung_id)
                        .Distinct()
                        .Count();

                    lblTongLog.Text = tongLog.ToString("N0");
                    lblHomNay.Text = homNay.ToString("N0");
                    lblNguoiDungHoatDong.Text = nguoiDungHoatDong.ToString("N0");
                }
            }
            catch (Exception ex)
            {
                lblTongLog.Text = "--";
                lblHomNay.Text = "--";
                lblNguoiDungHoatDong.Text = "--";
                System.Diagnostics.Debug.WriteLine($"[ucAuditLog] LoadThongKe lỗi: {ex.Message}");
            }
        }

        public void FilterAuditLog()
        {
            try
            {
                int nguoiDungId = 0;
                if (cboNguoiDung.SelectedItem is ComboItem selected && selected.Id > 0)
                    nguoiDungId = selected.Id;

                string module = (cboModule.SelectedIndex > 0)
                    ? cboModule.SelectedItem?.ToString()
                    : string.Empty;

                DateTime tuNgay = dtTuNgay.Value.Date;
                DateTime denNgay = dtDenNgay.Value.Date.AddDays(1);
                string keyword = txtSearch.Text.Trim().ToLower();

                _filteredData = _allData.Where(x =>
                {
                    bool okNguoiDung = nguoiDungId == 0 || x.nguoi_dung_id == nguoiDungId;
                    bool okModule = string.IsNullOrEmpty(module)
                        || x.bang.Equals(module, StringComparison.OrdinalIgnoreCase);
                    bool okTuNgay = x.thoi_gian >= tuNgay;
                    bool okDenNgay = x.thoi_gian < denNgay;
                    bool okSearch = string.IsNullOrEmpty(keyword)
                                       || x.ten_nguoi_dung.ToLower().Contains(keyword)
                                       || x.hanh_dong.ToLower().Contains(keyword)
                                       || x.bang.ToLower().Contains(keyword)
                                       || x.mo_ta.ToLower().Contains(keyword);

                    return okNguoiDung && okModule && okTuNgay && okDenNgay && okSearch;
                }).ToList();

                int stt = 1;
                foreach (var item in _filteredData)
                    item.stt = stt++;

                BindGrid(_filteredData);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi lọc dữ liệu: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SearchAuditLog()
        {
            try
            {
                string keyword = txtSearch.Text.Trim().ToLower();

                if (string.IsNullOrEmpty(keyword))
                {
                    BindGrid(_filteredData);
                    return;
                }

                var result = _filteredData.Where(x =>
                    x.ten_nguoi_dung.ToLower().Contains(keyword) ||
                    x.hanh_dong.ToLower().Contains(keyword) ||
                    x.bang.ToLower().Contains(keyword) ||
                    x.mo_ta.ToLower().Contains(keyword)
                ).ToList();

                BindGrid(result);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"[ucAuditLog] SearchAuditLog lỗi: {ex.Message}");
            }
        }

        public void ClearFilter()
        {
            try
            {
                if (cboNguoiDung.Items.Count > 0)
                    cboNguoiDung.SelectedIndex = 0;

                if (cboModule.Items.Count > 0)
                    cboModule.SelectedIndex = 0;

                dtTuNgay.Value = DateTime.Today.AddDays(-30);
                dtDenNgay.Value = DateTime.Today;
                txtSearch.Text = string.Empty;

                _filteredData = new List<AuditLogViewModel>(_allData);

                int stt = 1;
                foreach (var item in _filteredData)
                    item.stt = stt++;

                BindGrid(_filteredData);
                LoadThongKe();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi làm mới: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ExportExcel()
        {
            if (_filteredData == null || _filteredData.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var sfd = new SaveFileDialog())
            {
                sfd.Title = "Xuất Audit Log";
                sfd.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";
                sfd.FileName = $"AuditLog_{DateTime.Now:yyyyMMdd_HHmmss}.csv";
                sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                if (sfd.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    using (var sw = new StreamWriter(sfd.FileName, false, System.Text.Encoding.UTF8))
                    {
                        sw.Write('\uFEFF');
                        sw.WriteLine("STT,Người Dùng,Hành Động,Module / Bảng,Bản Ghi ID,Mô Tả,Thời Gian");

                        foreach (var row in _filteredData)
                        {
                            string moTaSafe = $"\"{row.mo_ta?.Replace("\"", "\"\"") ?? ""}\"";
                            sw.WriteLine(
                                $"{row.stt}," +
                                $"\"{row.ten_nguoi_dung}\"," +
                                $"\"{row.hanh_dong}\"," +
                                $"\"{row.bang}\"," +
                                $"{(row.ban_ghi_id.HasValue ? row.ban_ghi_id.Value.ToString() : "")}," +
                                $"{moTaSafe}," +
                                $"\"{row.thoi_gian_str}\""
                            );
                        }
                    }

                    MessageBox.Show(
                        $"Xuất thành công {_filteredData.Count} bản ghi!\n{sfd.FileName}",
                        "Thành công",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi xuất file: {ex.Message}", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BindGrid(List<AuditLogViewModel> data)
        {
            dgvAuditLog.DataSource = null;
            dgvAuditLog.DataSource = data;
        }

        private void ApplyRowAlternateColor()
        {
            dgvAuditLog.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(22, 33, 52);
            dgvAuditLog.AlternatingRowsDefaultCellStyle.ForeColor =
                Color.FromArgb(226, 232, 240);
            dgvAuditLog.AlternatingRowsDefaultCellStyle.SelectionBackColor =
                Color.FromArgb(59, 130, 246);
            dgvAuditLog.AlternatingRowsDefaultCellStyle.SelectionForeColor =
                Color.White;
        }

        private class AuditLogViewModel
        {
            public int stt { get; set; }
            public int id { get; set; } 
            public int? nguoi_dung_id { get; set; } 
            public string ten_nguoi_dung { get; set; }
            public string hanh_dong { get; set; }
            public string bang { get; set; }
            public int? ban_ghi_id { get; set; }
            public string mo_ta { get; set; }
            public DateTime thoi_gian { get; set; }
            public string thoi_gian_str { get; set; }
        }

        private class ComboItem
        {
            public int Id { get; set; }
            public string TenHienThi { get; set; }
            public override string ToString() => TenHienThi;
        }
    }
}