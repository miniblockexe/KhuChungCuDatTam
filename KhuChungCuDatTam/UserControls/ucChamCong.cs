using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using KhuChungCuDatTam.Helpers;
using KhuChungCuDatTam.Models;

namespace KhuChungCuDatTam.UserControls
{
    public partial class ucChamCong : UserControl
    {
        private static readonly Color CLR_BG = Color.FromArgb(15, 23, 42);
        private static readonly Color CLR_CARD = Color.FromArgb(30, 41, 59);
        private static readonly Color CLR_MUTED = Color.FromArgb(100, 116, 139);
        private static readonly Color CLR_PRIMARY = Color.FromArgb(59, 130, 246);
        private static readonly Color CLR_SUCCESS = Color.FromArgb(16, 185, 129);
        private static readonly Color CLR_DANGER = Color.FromArgb(239, 68, 68);
        private static readonly Color CLR_WARN = Color.FromArgb(245, 158, 11);

        private int _selectedId = -1;

        public ucChamCong()
        {
            InitializeComponent();
            SetStyle(
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint, true);
        }

        private void ucChamCong_Load(object sender, EventArgs e)
        {
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;

            SetupGridColumns();
            ApplyRoundedCard(pnlFormCard);
            ApplyRoundedCard(pnlGridCard);

            InitTrangThai();
            LoadNguoiDung();
            LoadData();
        }

        private void InitTrangThai()
        {
            var dt = new DataTable();
            dt.Columns.Add("gia_tri", typeof(string));
            dt.Columns.Add("hien_thi", typeof(string)); 

            dt.Rows.Add("di_lam", "Đi Làm");
            dt.Rows.Add("di_tre", "Đi Trễ");
            dt.Rows.Add("nghi_phep", "Nghỉ Phép");
            dt.Rows.Add("ve_som", "Về Sớm");

            cboTrangThai.DataSource = dt;
            cboTrangThai.DisplayMember = "hien_thi";
            cboTrangThai.ValueMember = "gia_tri";
            cboTrangThai.SelectedIndex = -1;
        }

        private void SetupGridColumns()
        {
            colId.DataPropertyName = "id";
            colNguoiDung.DataPropertyName = "ho_ten";
            colNgay.DataPropertyName = "ngay_hien_thi";
            colGioVao.DataPropertyName = "gio_vao_hien_thi";
            colGioRa.DataPropertyName = "gio_ra_hien_thi";
            colTrangThai.DataPropertyName = "trang_thai";
        }

        public void LoadNguoiDung()
        {
            try
            {
                using (var db = new DbChungCu())
                {
                    var list = db.nguoi_dung
                        .OrderBy(n => n.ho_ten)
                        .Select(n => new { n.id, n.ho_ten })
                        .ToList();

                    var dt = new DataTable();
                    dt.Columns.Add("id", typeof(int));
                    dt.Columns.Add("ho_ten", typeof(string));

                    foreach (var n in list)
                        dt.Rows.Add(n.id, string.IsNullOrWhiteSpace(n.ho_ten)
                            ? "(Chưa có tên)" : n.ho_ten);

                    cboNguoiDung.DataSource = dt;
                    cboNguoiDung.DisplayMember = "ho_ten";
                    cboNguoiDung.ValueMember = "id";
                    cboNguoiDung.SelectedIndex = -1;
                }
            }
            catch (Exception ex) { ShowError("Tải danh sách nhân viên thất bại", ex); }
        }

        public void LoadData()
        {
            try
            {
                using (var db = new DbChungCu())
                {
                    var list = db.cham_cong
                        .Include("nguoi_dung")
                        .OrderByDescending(c => c.ngay)
                        .ThenBy(c => c.nguoi_dung.ho_ten)
                        .Select(c => new
                        {
                            c.id,
                            ho_ten = c.nguoi_dung.ho_ten,
                            c.ngay,
                            c.gio_vao,
                            c.gio_ra,
                            c.trang_thai,
                            c.nguoi_dung_id,
                        })
                        .ToList();

                    var rows = list.Select(x => new ChamCongRow
                    {
                        id = x.id,
                        ho_ten = x.ho_ten,
                        ngay = x.ngay,
                        gio_vao = x.gio_vao,
                        gio_ra = x.gio_ra,
                        trang_thai = x.trang_thai,
                        nguoi_dung_id = x.nguoi_dung_id,
                    });

                    var dt = BuildDataTable(rows);
                    dgvChamCong.DataSource = dt;
                    UpdateRecordCount(dt.Rows.Count);
                    LoadThongKe(dt);
                    ColorTrangThaiRows();
                }
            }
            catch (Exception ex) { ShowError("Tải dữ liệu thất bại", ex); }
        }

        public void LoadThongKe(DataTable dt = null)
        {
            try
            {
                if (dt == null)
                    dt = dgvChamCong.DataSource as DataTable;

                if (dt == null) return;

                int tong = dt.Rows.Count;
                int coMat = 0;
                int vangMat = 0;

                foreach (DataRow row in dt.Rows)
                {
                    string tt = row["trang_thai"]?.ToString() ?? "";
                    if (tt == "di_lam" || tt == "di_tre" || tt == "ve_som")
                        coMat++;
                    else if (tt == "nghi_phep")
                        vangMat++;
                }

                lblTongChamCong.Text = tong.ToString("N0");
                lblCoMat.Text = coMat.ToString("N0");
                lblVangMat.Text = vangMat.ToString("N0");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"[ucChamCong.LoadThongKe] {ex.Message}");
            }
        }

        public void InsertChamCong()
        {
            if (!ValidateForm()) return;

            int nguoiDungId = GetSelectedNguoiDungId();
            DateTime ngay = dtNgay.Value.Date;

            try
            {
                using (var db = new DbChungCu())
                {
                    bool daComat = db.cham_cong.Any(c =>
                        c.nguoi_dung_id == nguoiDungId &&
                        c.ngay == ngay);

                    if (daComat)
                    {
                        MessageBox.Show(
                            "⚠️ Nhân viên này đã có bản ghi chấm công trong ngày đã chọn.\n\n" +
                            "Vui lòng chọn bản ghi trên danh sách rồi nhấn  ✏ Sửa  để cập nhật.",
                            "Trùng dữ liệu",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }

                    var cc = new cham_cong
                    {
                        nguoi_dung_id = nguoiDungId,
                        ngay = ngay,
                        gio_vao = dtGioVao.Value.TimeOfDay,
                        gio_ra = dtGioRa.Value.TimeOfDay,
                        trang_thai = cboTrangThai.SelectedValue?.ToString() ?? "",
                    };

                    db.cham_cong.Add(cc);
                    db.SaveChanges();
                    AuditLogHelper.GhiLog("THÊM", "cham_cong", cc.id,
    $"Thêm chấm công – NV ID {cc.nguoi_dung_id} – Ngày {cc.ngay:dd/MM/yyyy} – {cc.trang_thai}");
                }

                MessageBox.Show("✅ Thêm chấm công thành công!",
                    "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearForm();
            }
            catch (Exception ex) { ShowError("Thêm chấm công thất bại", ex); }
        }
        public void UpdateChamCong()
        {
            if (_selectedId <= 0)
            {
                MessageBox.Show("⚠️ Vui lòng chọn một bản ghi để sửa.",
                    "Chưa chọn dòng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!ValidateForm()) return;

            try
            {
                using (var db = new DbChungCu())
                {
                    var cc = db.cham_cong.Find(_selectedId);
                    if (cc == null)
                    {
                        MessageBox.Show("Không tìm thấy bản ghi trong CSDL.",
                            "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    cc.nguoi_dung_id = GetSelectedNguoiDungId();
                    cc.ngay = dtNgay.Value.Date;
                    cc.gio_vao = dtGioVao.Value.TimeOfDay;
                    cc.gio_ra = dtGioRa.Value.TimeOfDay;
                    cc.trang_thai = cboTrangThai.SelectedValue?.ToString() ?? "";

                    db.SaveChanges();
                    AuditLogHelper.GhiLog("SỬA", "cham_cong", cc.id,
    $"Cập nhật chấm công – NV ID {cc.nguoi_dung_id} – Ngày {cc.ngay:dd/MM/yyyy} – {cc.trang_thai}");
                }

                MessageBox.Show("✅ Cập nhật chấm công thành công!",
                    "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearForm();
            }
            catch (Exception ex) { ShowError("Cập nhật chấm công thất bại", ex); }
        }

        public void DeleteChamCong()
        {
            if (_selectedId <= 0)
            {
                MessageBox.Show("⚠️ Vui lòng chọn một bản ghi để xóa.",
                    "Chưa chọn dòng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show(
                "❗ Bạn có chắc muốn xóa bản ghi chấm công này không?\n\nHành động này không thể hoàn tác.",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);

            if (confirm != DialogResult.Yes) return;

            try
            {
                using (var db = new DbChungCu())
                {
                    var cc = db.cham_cong.Find(_selectedId);
                    if (cc != null)
                    {
                        string logInfo = $"Xóa chấm công – NV ID {cc.nguoi_dung_id} – Ngày {cc.ngay:dd/MM/yyyy}";
                        db.cham_cong.Remove(cc);
                        db.SaveChanges();

                        AuditLogHelper.GhiLog("XÓA", "cham_cong", _selectedId, logInfo);
                    }
                }

                MessageBox.Show("✅ Xóa chấm công thành công!",
                    "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearForm();
            }
            catch (Exception ex) { ShowError("Xóa chấm công thất bại", ex); }
        }

        public void SearchChamCong()
        {
            string kw = txtSearch.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(kw))
            {
                LoadData();
                return;
            }

            try
            {
                using (var db = new DbChungCu())
                {
                    var list = db.cham_cong
                        .Include("nguoi_dung")
                        .Where(c =>
                            c.nguoi_dung.ho_ten.ToLower().Contains(kw) ||
                            c.trang_thai.ToLower().Contains(kw))
                        .OrderByDescending(c => c.ngay)
                        .ThenBy(c => c.nguoi_dung.ho_ten)
                        .Select(c => new
                        {
                            c.id,
                            ho_ten = c.nguoi_dung.ho_ten,
                            c.ngay,
                            c.gio_vao,
                            c.gio_ra,
                            c.trang_thai,
                            c.nguoi_dung_id,
                        })
                        .ToList();

                    var rows = list.Select(x => new ChamCongRow
                    {
                        id = x.id,
                        ho_ten = x.ho_ten,
                        ngay = x.ngay,
                        gio_vao = x.gio_vao,
                        gio_ra = x.gio_ra,
                        trang_thai = x.trang_thai,
                        nguoi_dung_id = x.nguoi_dung_id,
                    });

                    var dt = BuildDataTable(rows);
                    dgvChamCong.DataSource = dt;
                    UpdateRecordCount(dt.Rows.Count);
                    LoadThongKe(dt);
                    ColorTrangThaiRows();
                }
            }
            catch (Exception ex) { ShowError("Tìm kiếm thất bại", ex); }
        }

        public void ClearForm()
        {
            _selectedId = -1;

            cboNguoiDung.SelectedIndex = -1;
            dtNgay.Value = DateTime.Today;
            dtGioVao.Value = DateTime.Today.AddHours(8);
            dtGioRa.Value = DateTime.Today.AddHours(17);
            cboTrangThai.SelectedIndex = -1;

            if (dgvChamCong.Rows.Count > 0)
                dgvChamCong.ClearSelection();
        }

        private void btnThem_Click(object sender, EventArgs e) => InsertChamCong();
        private void btnSua_Click(object sender, EventArgs e) => UpdateChamCong();
        private void btnXoa_Click(object sender, EventArgs e) => DeleteChamCong();
        private void btnLamMoi_Click(object sender, EventArgs e) { LoadData(); ClearForm(); }
        private void txtSearch_TextChanged(object sender, EventArgs e) => SearchChamCong();

        private void dgvChamCong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                var row = dgvChamCong.Rows[e.RowIndex];
                _selectedId = Convert.ToInt32(row.Cells["colId"].Value);

                if (!(dgvChamCong.DataSource is DataTable dt)) return;

                DataRow dataRow = dt.Rows[e.RowIndex];

                // Ngày
                if (dataRow["ngay"] != DBNull.Value)
                    dtNgay.Value = Convert.ToDateTime(dataRow["ngay"]);

                // Giờ vào
                if (dataRow["gio_vao_raw"] != DBNull.Value)
                {
                    var ts = (TimeSpan)dataRow["gio_vao_raw"];
                    dtGioVao.Value = DateTime.Today.Add(ts);
                }

                // Giờ ra
                if (dataRow["gio_ra_raw"] != DBNull.Value)
                {
                    var ts = (TimeSpan)dataRow["gio_ra_raw"];
                    dtGioRa.Value = DateTime.Today.Add(ts);
                }

                // Trạng thái
                string trangThai = row.Cells["colTrangThai"].Value?.ToString() ?? "";
                cboTrangThai.SelectedValue = row.Cells["colTrangThai"].Value?.ToString() ?? "";

                // Người dùng
                if (dataRow["nguoi_dung_id"] != DBNull.Value)
                {
                    int nguoiDungId = Convert.ToInt32(dataRow["nguoi_dung_id"]);
                    foreach (DataRowView drv in cboNguoiDung.Items)
                    {
                        if (Convert.ToInt32(drv["id"]) == nguoiDungId)
                        {
                            cboNguoiDung.SelectedItem = drv;
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"[ucChamCong.CellClick] {ex.Message}");
            }
        }

        private bool ValidateForm()
        {
            if (cboNguoiDung.SelectedIndex < 0)
            {
                Warn("Vui lòng chọn Nhân Viên.", cboNguoiDung);
                return false;
            }
            if (cboTrangThai.SelectedIndex < 0)
            {
                Warn("Vui lòng chọn Trạng Thái.", cboTrangThai);
                return false;
            }
            if (dtGioRa.Value.TimeOfDay <= dtGioVao.Value.TimeOfDay)
            {
                Warn("Giờ ra phải sau giờ vào.", dtGioRa);
                return false;
            }
            return true;
        }

        private void ColorTrangThaiRows()
        {
            foreach (DataGridViewRow row in dgvChamCong.Rows)
            {
                if (row.IsNewRow) continue;

                string tt = row.Cells["colTrangThai"].Value?.ToString() ?? "";
                Color fg;
                switch (tt)
                {
                    case "di_lam": fg = CLR_SUCCESS; break;
                    case "di_tre": fg = CLR_WARN; break;
                    case "nghi_phep": fg = CLR_PRIMARY; break;
                    case "ve_som": fg = CLR_DANGER; break;
                    default: fg = CLR_MUTED; break;
                }
                row.Cells["colTrangThai"].Style.ForeColor = fg;
                row.Cells["colTrangThai"].Style.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            }
        }

        private void UpdateRecordCount(int count)
            => lblRecordCount.Text = $"{count:N0} bản ghi";

        private static void ApplyRoundedCard(Panel panel)
        {
            panel.Paint += (s, pe) =>
            {
                var p = (Panel)s;
                using (var path = RoundedPath(p.ClientRectangle, 10))
                    p.Region = new Region(path);
            };
        }

        private static GraphicsPath RoundedPath(Rectangle rect, int radius)
        {
            int d = radius * 2;
            var path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }

        private static DataTable BuildDataTable(IEnumerable<ChamCongRow> rows)
        {
            var dt = new DataTable();
            dt.Columns.Add("id", typeof(int));
            dt.Columns.Add("ho_ten", typeof(string));
            dt.Columns.Add("ngay", typeof(DateTime));
            dt.Columns.Add("ngay_hien_thi", typeof(string));  
            dt.Columns.Add("gio_vao_raw", typeof(TimeSpan));
            dt.Columns.Add("gio_ra_raw", typeof(TimeSpan));
            dt.Columns.Add("gio_vao_hien_thi", typeof(string));  
            dt.Columns.Add("gio_ra_hien_thi", typeof(string));   
            dt.Columns.Add("trang_thai", typeof(string));
            dt.Columns.Add("nguoi_dung_id", typeof(int));

            foreach (var r in rows)
            {
                var row = dt.NewRow();
                row["id"] = r.id;
                row["ho_ten"] = string.IsNullOrWhiteSpace(r.ho_ten) ? "(Chưa có tên)" : r.ho_ten;
                row["ngay"] = r.ngay;
                row["ngay_hien_thi"] = r.ngay.ToString("dd/MM/yyyy");
                row["gio_vao_raw"] = r.gio_vao.HasValue ? (object)r.gio_vao.Value : DBNull.Value;
                row["gio_ra_raw"] = r.gio_ra.HasValue ? (object)r.gio_ra.Value : DBNull.Value;
                row["gio_vao_hien_thi"] = r.gio_vao.HasValue ? FormatTime(r.gio_vao.Value) : "--:--";
                row["gio_ra_hien_thi"] = r.gio_ra.HasValue ? FormatTime(r.gio_ra.Value) : "--:--";
                row["trang_thai"] = r.trang_thai ?? "";
                row["nguoi_dung_id"] = r.nguoi_dung_id;
                dt.Rows.Add(row);
            }

            return dt;
        }

        private static string FormatTime(TimeSpan ts)
            => $"{(int)ts.TotalHours:D2}:{ts.Minutes:D2}";

        private int GetSelectedNguoiDungId()
            => Convert.ToInt32(((DataRowView)cboNguoiDung.SelectedItem)["id"]);

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

            MessageBox.Show($"{context}:\n{inner.Message}", "Lỗi",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            System.Diagnostics.Debug.WriteLine($"[ucChamCong] {context}: {ex}");
        }

        private class ChamCongRow
        {
            public int id { get; set; }
            public string ho_ten { get; set; }
            public DateTime ngay { get; set; }
            public TimeSpan? gio_vao { get; set; }
            public TimeSpan? gio_ra { get; set; }
            public string trang_thai { get; set; }
            public int nguoi_dung_id { get; set; }
        }
    }
}