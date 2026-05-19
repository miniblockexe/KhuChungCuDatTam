using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using KhuChungCuDatTam.Forms;
using KhuChungCuDatTam.Models;

namespace KhuChungCuDatTam.UserControls
{
    public partial class ucBaoCao : UserControl
    {
        public ucBaoCao()
        {
            InitializeComponent();
        }
        private void ucBaoCao_Load(object sender, EventArgs e)
        {
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;

            try
            {
                InitComboBoxes();
                SetupDataGridColumns();
                SetupCharts();
                LoadThongKe();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khởi tạo báo cáo: " + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitComboBoxes()
        {
            cboThang.Items.Clear();
            cboThang.Items.Add("Tất cả");
            for (int i = 1; i <= 12; i++)
                cboThang.Items.Add(i.ToString());
            cboThang.SelectedIndex = 0;

            cboNam.Items.Clear();
            cboNam.Items.Add("Tất cả");
            int currentYear = DateTime.Now.Year;
            for (int y = currentYear - 4; y <= currentYear; y++)
                cboNam.Items.Add(y.ToString());

            string sCurrentYear = currentYear.ToString();
            if (cboNam.Items.Contains(sCurrentYear))
                cboNam.SelectedItem = sCurrentYear;
            else
                cboNam.SelectedIndex = 0;
        }

        private void SetupDataGridColumns()
        {
            dgvBaoCao.Columns.Clear();

            AddColumn("colThangNam", "Tháng/Năm", 100, DataGridViewContentAlignment.MiddleCenter);
            AddColumn("colCanHo", "Căn hộ", 90, DataGridViewContentAlignment.MiddleCenter);
            AddColumn("colTongHoaDon", "Tổng HĐ (đ)", 150, DataGridViewContentAlignment.MiddleRight);
            AddColumn("colDaThanhToan", "Đã thanh toán (đ)", 150, DataGridViewContentAlignment.MiddleRight);
            AddColumn("colCongNo", "Còn nợ (đ)", 150, DataGridViewContentAlignment.MiddleRight);
            AddColumn("colBaoTri", "CP Bảo trì (đ)", 150, DataGridViewContentAlignment.MiddleRight);
            AddColumn("colTrangThai", "Trạng thái", 120, DataGridViewContentAlignment.MiddleCenter);
        }

        private void AddColumn(string name, string header, int minWidth,
            DataGridViewContentAlignment alignment)
        {
            var col = new DataGridViewTextBoxColumn
            {
                Name = name,
                HeaderText = header,
                MinimumWidth = minWidth,
                SortMode = DataGridViewColumnSortMode.Automatic
            };
            col.DefaultCellStyle.Alignment = alignment;
            col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBaoCao.Columns.Add(col);
        }

        private void SetupCharts()
        {
            SetupChartDoanhThu();
            SetupChartCongNo();
            SetupChartDichVu();
        }

        private void SetupChartDoanhThu()
        {
            var chart = chartDoanhThu;
            var area = chart.ChartAreas["ChartArea1"];
            var series = chart.Series["SeriesDoanhThu"];

            ApplyDarkChartArea(chart, area);

            chart.Titles.Clear();
            var title = new Title("Doanh Thu Theo Tháng")
            {
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                Docking = Docking.Top
            };
            chart.Titles.Add(title);

            series.ChartType = SeriesChartType.Column;
            series.Color = Color.FromArgb(59, 130, 246);
            series.Font = new Font("Segoe UI", 7F);
            series.IsValueShownAsLabel = false;
            series.BorderWidth = 0;

            ApplyAxisStyle(area);
        }

        private void SetupChartCongNo()
        {
            var chart = chartCongNo;
            var area = chart.ChartAreas["ChartArea2"];
            var series = chart.Series["SeriesCongNo"];

            ApplyDarkChartArea(chart, area);

            chart.Titles.Clear();
            var title = new Title("Phân Bổ Công Nợ")
            {
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                Docking = Docking.Top
            };
            chart.Titles.Add(title);

            var legend = chart.Legends["Legend2"];
            legend.BackColor = Color.FromArgb(30, 41, 59);
            legend.ForeColor = Color.FromArgb(148, 163, 184);
            legend.Font = new Font("Segoe UI", 7.5F);

            series.ChartType = SeriesChartType.Pie;
            series.Font = new Font("Segoe UI", 7.5F);
            series.IsValueShownAsLabel = true;
            series["PieLabelStyle"] = "Outside";
            series.LabelFormat = "#,0 đ";
            series.LabelForeColor = Color.FromArgb(148, 163, 184);

            area.AxisX.Enabled = AxisEnabled.False;
            area.AxisY.Enabled = AxisEnabled.False;
        }

        private void SetupChartDichVu()
        {
            var chart = chartDichVu;
            var area = chart.ChartAreas["ChartArea3"];
            var series = chart.Series["SeriesDichVu"];

            ApplyDarkChartArea(chart, area);

            chart.Titles.Clear();
            var title = new Title("Top 5 Dịch Vụ Sử Dụng")
            {
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                Docking = Docking.Top
            };
            chart.Titles.Add(title);

            series.ChartType = SeriesChartType.Bar;
            series.Color = Color.FromArgb(16, 185, 129);
            series.Font = new Font("Segoe UI", 7F);
            series.IsValueShownAsLabel = true;
            series.LabelFormat = "#,0";
            series.LabelForeColor = Color.White;

            ApplyAxisStyle(area);
        }

        private void ApplyDarkChartArea(Chart chart, ChartArea area)
        {
            chart.BackColor = Color.FromArgb(30, 41, 59);
            chart.BorderlineColor = Color.FromArgb(51, 65, 85);
            chart.BorderlineDashStyle = ChartDashStyle.Solid;
            chart.BorderlineWidth = 1;

            area.BackColor = Color.FromArgb(30, 41, 59);

            var legend = chart.Legends[0];
            legend.BackColor = Color.FromArgb(30, 41, 59);
            legend.ForeColor = Color.FromArgb(148, 163, 184);
            legend.Font = new Font("Segoe UI", 7.5F);
        }

        private void ApplyAxisStyle(ChartArea area)
        {
            Color axisColor = Color.FromArgb(51, 65, 85);
            Color labelColor = Color.FromArgb(148, 163, 184);
            var labelFont = new Font("Segoe UI", 7F);

            area.AxisX.LineColor = axisColor;
            area.AxisX.MajorGrid.LineColor = axisColor;
            area.AxisX.LabelStyle.ForeColor = labelColor;
            area.AxisX.LabelStyle.Font = labelFont;
            area.AxisX.MajorTickMark.LineColor = axisColor;

            area.AxisY.LineColor = axisColor;
            area.AxisY.MajorGrid.LineColor = axisColor;
            area.AxisY.LabelStyle.ForeColor = labelColor;
            area.AxisY.LabelStyle.Font = labelFont;
            area.AxisY.MajorTickMark.LineColor = axisColor;
            area.AxisY.LabelStyle.Format = "#,0";
        }

        public void LoadThongKe()
        {
            try
            {
                using (var db = new DbChungCu())
                {
                    int? thang = GetSelectedThang();
                    int? nam = GetSelectedNam();

                    int tongCuDan = db.cu_dan.Count();
                    lblTongCuDan.Text = tongCuDan.ToString("N0");

                    int tongCanHo = db.can_ho.Count();
                    lblTongCanHo.Text = tongCanHo.ToString("N0");

                    var queryHoaDon = db.hoa_don.AsQueryable();
                    if (thang.HasValue)
                        queryHoaDon = queryHoaDon.Where(h => h.thang_nam.Month == thang.Value);
                    if (nam.HasValue)
                        queryHoaDon = queryHoaDon.Where(h => h.thang_nam.Year == nam.Value);

                    var hoaDonIds = queryHoaDon.Select(h => h.id).ToList();

                    decimal tongDoanhThu = 0;
                    if (hoaDonIds.Any())
                    {
                        tongDoanhThu = db.thanh_toan
                            .Where(t => hoaDonIds.Contains(t.hoa_don_id))
                            .Sum(t => (decimal?)t.so_tien) ?? 0;
                    }
                    lblTongDoanhThu.Text = tongDoanhThu.ToString("N0") + " đ";

                    decimal tongCongNo = db.cong_no
                        .Where(c => c.trang_thai == "chua_thanh_toan"
                                 || c.trang_thai == "qua_han")
                        .Sum(c => (decimal?)c.so_tien_no) ?? 0;
                    lblTongCongNo.Text = tongCongNo.ToString("N0") + " đ";

                    var queryBaoTri = db.bao_tri.AsQueryable();
                    if (nam.HasValue)
                        queryBaoTri = queryBaoTri.Where(b => b.ngay_yeu_cau.Year == nam.Value);
                    if (thang.HasValue)
                        queryBaoTri = queryBaoTri.Where(b => b.ngay_yeu_cau.Month == thang.Value);

                    decimal tongBaoTri = queryBaoTri
                        .Sum(b => (decimal?)b.chi_phi) ?? 0;
                    lblTongBaoTri.Text = tongBaoTri.ToString("N0") + " đ";
                }

                LoadChartDoanhThu();
                LoadChartCongNo();
                LoadChartDichVu();
                LoadDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải thống kê: " + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadChartDoanhThu()
        {
            try
            {
                ClearChart(chartDoanhThu);

                using (var db = new DbChungCu())
                {
                    int displayYear = GetSelectedNam() ?? DateTime.Now.Year;

                    var data = db.thanh_toan
                        .Where(t => t.ngay_thanh_toan.Year == displayYear)
                        .GroupBy(t => t.ngay_thanh_toan.Month)
                        .Select(g => new
                        {
                            Thang = g.Key,
                            TongTien = g.Sum(t => t.so_tien)
                        })
                        .OrderBy(g => g.Thang)
                        .ToList();

                    var series = chartDoanhThu.Series["SeriesDoanhThu"];

                    for (int m = 1; m <= 12; m++)
                    {
                        var item = data.FirstOrDefault(d => d.Thang == m);
                        double val = item != null ? (double)item.TongTien : 0;
                        var pt = series.Points.Add(val);
                        pt.AxisLabel = "T" + m;

                        pt.Color = val > 0
                            ? Color.FromArgb(59, 130, 246)
                            : Color.FromArgb(51, 65, 85);
                    }

                    if (chartDoanhThu.Titles.Count > 0)
                        chartDoanhThu.Titles[0].Text = $"Doanh Thu Theo Tháng – {displayYear}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi biểu đồ doanh thu: " + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadChartCongNo()
        {
            try
            {
                ClearChart(chartCongNo);

                using (var db = new DbChungCu())
                {
                    var data = db.cong_no
                        .GroupBy(c => c.trang_thai)
                        .Select(g => new
                        {
                            TrangThai = g.Key,
                            TongNo = g.Sum(c => c.so_tien_no),
                            SoLuong = g.Count()
                        })
                        .ToList();

                    var series = chartCongNo.Series["SeriesCongNo"];

                    if (!data.Any())
                    {
                        series.Points.AddXY("Không có dữ liệu", 1);
                        return;
                    }

                    var colorMap = new Dictionary<string, Color>
                    {
                        { "chua_thanh_toan", Color.FromArgb(245, 158, 11)  },
                        { "qua_han",         Color.FromArgb(239, 68,  68)  },
                        { "da_thanh_toan",   Color.FromArgb(16,  185, 129) }
                    };

                    var labelMap = new Dictionary<string, string>
                    {
                        { "chua_thanh_toan", "Chưa TT" },
                        { "qua_han",         "Quá hạn" },
                        { "da_thanh_toan",   "Đã TT"   }
                    };

                    foreach (var item in data)
                    {
                        if (item.TongNo <= 0) continue;

                        string label = labelMap.ContainsKey(item.TrangThai)
                            ? labelMap[item.TrangThai]
                            : item.TrangThai;

                        var pt = series.Points.AddXY(label, (double)item.TongNo);

                        if (colorMap.ContainsKey(item.TrangThai))
                            series.Points[series.Points.Count - 1].Color = colorMap[item.TrangThai];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi biểu đồ công nợ: " + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadChartDichVu()
        {
            try
            {
                ClearChart(chartDichVu);

                using (var db = new DbChungCu())
                {
                    var topDichVuIds = db.dang_ky_dich_vu
                        .GroupBy(d => d.dich_vu_id)
                        .Select(g => new { DichVuId = g.Key, SoLuot = g.Count() })
                        .OrderByDescending(g => g.SoLuot)
                        .Take(5)
                        .ToList();

                    if (!topDichVuIds.Any())
                    {
                        chartDichVu.Series["SeriesDichVu"].Points.AddXY("Chưa có dữ liệu", 0);
                        return;
                    }

                    var ids = topDichVuIds.Select(x => x.DichVuId).ToList();
                    var dichVus = db.dich_vu
                        .Where(d => ids.Contains(d.id))
                        .ToDictionary(d => d.id, d => d.ten_dich_vu);

                    var series = chartDichVu.Series["SeriesDichVu"];

                    var reversed = topDichVuIds.OrderBy(x => x.SoLuot).ToList();
                    foreach (var item in reversed)
                    {
                        string ten = dichVus.ContainsKey(item.DichVuId)
                            ? dichVus[item.DichVuId]
                            : "DV #" + item.DichVuId;

                        if (ten.Length > 18) ten = ten.Substring(0, 16) + "..";

                        series.Points.AddXY(ten, item.SoLuot);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi biểu đồ dịch vụ: " + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadDataGrid()
        {
            try
            {
                dgvBaoCao.Rows.Clear();

                using (var db = new DbChungCu())
                {
                    int? thang = GetSelectedThang();
                    int? nam = GetSelectedNam();

                    var queryHD = db.hoa_don.Include("can_ho").AsQueryable();
                    if (thang.HasValue)
                        queryHD = queryHD.Where(h => h.thang_nam.Month == thang.Value);
                    if (nam.HasValue)
                        queryHD = queryHD.Where(h => h.thang_nam.Year == nam.Value);

                    var hoaDons = queryHD.OrderByDescending(h => h.thang_nam).ToList();
                    var hoaDonIds = hoaDons.Select(h => h.id).ToList();

                    if (!hoaDonIds.Any()) return;

                    var mapThanhToan = db.thanh_toan
                        .Where(t => hoaDonIds.Contains(t.hoa_don_id))
                        .GroupBy(t => t.hoa_don_id)
                        .Select(g => new { HdId = g.Key, Tong = g.Sum(t => t.so_tien) })
                        .ToDictionary(x => x.HdId, x => x.Tong);

                    var mapCongNo = db.cong_no
                        .Where(c => c.hoa_don_id.HasValue
                                 && hoaDonIds.Contains(c.hoa_don_id.Value))
                        .GroupBy(c => c.hoa_don_id.Value)
                        .Select(g => new { HdId = g.Key, Tong = g.Sum(c => c.so_tien_no) })
                        .ToDictionary(x => x.HdId, x => x.Tong);

                    var queryBT = db.bao_tri.Where(b => b.can_ho_id.HasValue);
                    if (nam.HasValue)
                        queryBT = queryBT.Where(b => b.ngay_yeu_cau.Year == nam.Value);
                    if (thang.HasValue)
                        queryBT = queryBT.Where(b => b.ngay_yeu_cau.Month == thang.Value);

                    var mapBaoTri = queryBT
                        .GroupBy(b => b.can_ho_id.Value)
                        .Select(g => new { CanHoId = g.Key, Tong = g.Sum(b => b.chi_phi) })
                        .ToDictionary(x => x.CanHoId, x => x.Tong ?? 0);

                    foreach (var hd in hoaDons)
                    {
                        decimal daThanhToan = mapThanhToan.ContainsKey(hd.id)
                            ? mapThanhToan[hd.id] : 0;
                        decimal congNo = mapCongNo.ContainsKey(hd.id)
                            ? mapCongNo[hd.id] : 0;
                        decimal chiPhiBT = mapBaoTri.ContainsKey(hd.can_ho_id)
                            ? mapBaoTri[hd.can_ho_id] : 0;

                        string trangThai = GetTrangThaiHoaDon(hd.trang_thai);
                        string soCanHo = hd.can_ho?.so_can_ho ?? "N/A";

                        int rowIndex = dgvBaoCao.Rows.Add(
                            hd.thang_nam.ToString("MM/yyyy"),
                            soCanHo,
                            hd.tong_tien.ToString("N0"),
                            daThanhToan.ToString("N0"),
                            congNo.ToString("N0"),
                            chiPhiBT.ToString("N0"),
                            trangThai
                        );

                        ApplyRowColor(dgvBaoCao.Rows[rowIndex], hd.trang_thai);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu grid: " + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetTrangThaiHoaDon(string trangThai)
        {
            if (string.IsNullOrEmpty(trangThai)) return "N/A";
            switch (trangThai.ToLower())
            {
                case "da_thanh_toan": return "✔ Đã TT";
                case "chua_thanh_toan": return "⏳ Chưa TT";
                case "qua_han": return "⚠ Quá hạn";
                default: return trangThai;
            }
        }

        private void ApplyRowColor(DataGridViewRow row, string trangThai)
        {
            if (row == null || string.IsNullOrEmpty(trangThai)) return;

            Color cellFore = Color.White;
            switch (trangThai.ToLower())
            {
                case "qua_han":
                    cellFore = Color.FromArgb(252, 165, 165); 
                    break;
                case "chua_thanh_toan":
                    cellFore = Color.FromArgb(253, 230, 138); 
                    break;
                case "da_thanh_toan":
                    cellFore = Color.FromArgb(110, 231, 183);
                    break;
            }

            if (row.Cells["colTrangThai"] != null)
                row.Cells["colTrangThai"].Style.ForeColor = cellFore;
        }

        public void FilterBaoCao()
        {
            LoadThongKe();
        }

        public void ClearChart(Chart chart)
        {
            if (chart == null) return;
            foreach (var series in chart.Series)
                series.Points.Clear();
        }

        private int? GetSelectedThang()
        {
            if (cboThang == null || cboThang.SelectedIndex <= 0) return null;
            if (int.TryParse(cboThang.SelectedItem?.ToString(), out int thang))
                return thang;
            return null;
        }

        private int? GetSelectedNam()
        {
            if (cboNam == null || cboNam.SelectedIndex <= 0) return null;
            if (int.TryParse(cboNam.SelectedItem?.ToString(), out int nam))
                return nam;
            return null;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            FilterBaoCao();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            try
            {
                cboThang.SelectedIndex = 0;

                string sCurrentYear = DateTime.Now.Year.ToString();
                if (cboNam.Items.Contains(sCurrentYear))
                    cboNam.SelectedItem = sCurrentYear;
                else
                    cboNam.SelectedIndex = 0;

                LoadThongKe();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi làm mới: " + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnXemReport_Click(object sender, EventArgs e)
        {
            frmBaoCao frm = new frmBaoCao();
            frm.ShowDialog();
        }
    }
}