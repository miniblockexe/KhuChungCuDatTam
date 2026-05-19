using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using KhuChungCuDatTam.Helpers;
using KhuChungCuDatTam.Models;

namespace KhuChungCuDatTam.UserControls
{
    public partial class ucCanHo : UserControl
    {
        private static readonly Color CLR_BG = Color.FromArgb(15, 23, 42);
        private static readonly Color CLR_CARD = Color.FromArgb(30, 41, 59);
        private static readonly Color CLR_MUTED = Color.FromArgb(100, 116, 139);
        private static readonly Color CLR_PRIMARY = Color.FromArgb(59, 130, 246);
        private static readonly Color CLR_SUCCESS = Color.FromArgb(16, 185, 129);
        private static readonly Color CLR_DANGER = Color.FromArgb(239, 68, 68);
        private static readonly Color CLR_WARN = Color.FromArgb(245, 158, 11);

        private int _selectedId = -1;

        public ucCanHo()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint, true);
        }

        private void ucCanHo_Load(object sender, EventArgs e)
        {
            ApplyRoundedCard(pnlFormCard);
            ApplyRoundedCard(pnlGridCard);

            LoadToaNha();
            LoadData();
        }

        public void LoadData()
        {
            try
            {
                using (var db = new DbChungCu())
                {
                    var list = db.can_ho
                        .Include("toa_nha")
                        .OrderBy(c => c.toa_nha.ten_toa)
                        .ThenBy(c => c.so_can_ho)
                        .Select(c => new
                        {
                            id = c.id,
                            so_can_ho = c.so_can_ho,
                            tang = c.tang,
                            dien_tich = c.dien_tich,
                            trang_thai = c.trang_thai,
                            ten_toa = c.toa_nha.ten_toa,
                            toa_nha_id = c.toa_nha_id,
                        })
                        .ToList();

                    var dt = new DataTable();
                    dt.Columns.Add("id", typeof(int));
                    dt.Columns.Add("so_can_ho", typeof(string));
                    dt.Columns.Add("tang", typeof(int));
                    dt.Columns.Add("dien_tich", typeof(decimal));
                    dt.Columns.Add("trang_thai", typeof(string));
                    dt.Columns.Add("ten_toa", typeof(string));
                    dt.Columns.Add("toa_nha_id", typeof(int));

                    foreach (var r in list)
                        dt.Rows.Add(r.id, r.so_can_ho, r.tang,
                                    r.dien_tich, r.trang_thai,
                                    r.ten_toa, r.toa_nha_id);

                    dgvCanHo.DataSource = dt;
                    UpdateRecordCount(dt.Rows.Count);
                    ColorTrangThaiRows();
                }
            }
            catch (Exception ex) { ShowError("Tải dữ liệu thất bại", ex); }
        }

        private void LoadToaNha()
        {
            try
            {
                using (var db = new DbChungCu())
                {
                    var list = db.toa_nha
                        .OrderBy(t => t.ten_toa)
                        .Select(t => new { t.id, t.ten_toa })
                        .ToList();

                    var dt = new DataTable();
                    dt.Columns.Add("id", typeof(int));
                    dt.Columns.Add("ten_toa", typeof(string));

                    foreach (var t in list)
                        dt.Rows.Add(t.id, t.ten_toa);

                    cboToaNha.DataSource = dt;
                    cboToaNha.DisplayMember = "ten_toa";
                    cboToaNha.ValueMember = "id";
                    cboToaNha.SelectedIndex = -1;
                }
            }
            catch (Exception ex) { ShowError("Tải danh sách tòa nhà thất bại", ex); }
        }

        public void ClearForm()
        {
            _selectedId = -1;
            txtMaCan.Clear();
            txtTang.Clear();
            txtDienTich.Clear();
            cboTrangThai.SelectedIndex = -1;
            cboToaNha.SelectedIndex = -1;

            if (dgvCanHo.Rows.Count > 0)
                dgvCanHo.ClearSelection();

            txtMaCan.Focus();
        }

        public void InsertCanHo()
        {
            if (!ValidateForm()) return;

            try
            {
                using (var db = new DbChungCu())
                {
                    var ch = new can_ho
                    {
                        so_can_ho = txtMaCan.Text.Trim(),
                        tang = ParseInt(txtTang.Text),
                        dien_tich = ParseDecimal(txtDienTich.Text),
                        trang_thai = cboTrangThai.SelectedItem?.ToString(),
                        toa_nha_id = GetSelectedToaNhaId(),
                    };

                    db.can_ho.Add(ch);
                    db.SaveChanges();
                    AuditLogHelper.GhiLog("THÊM", "can_ho", ch.id,
                        $"Thêm căn hộ {ch.so_can_ho} tầng {ch.tang}");
                }

                MessageBox.Show("✅ Thêm căn hộ thành công!",
                    "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearForm();
            }
            catch (Exception ex) { ShowError("Thêm căn hộ thất bại", ex); }
        }

        public void UpdateCanHo()
        {
            if (_selectedId <= 0)
            {
                MessageBox.Show("⚠️ Vui lòng chọn một căn hộ để sửa.",
                    "Chưa chọn dòng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!ValidateForm()) return;

            try
            {
                using (var db = new DbChungCu())
                {
                    var ch = db.can_ho.Find(_selectedId);
                    if (ch == null)
                    {
                        MessageBox.Show("Không tìm thấy căn hộ này trong CSDL.",
                            "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    ch.so_can_ho = txtMaCan.Text.Trim();
                    ch.tang = ParseInt(txtTang.Text);
                    ch.dien_tich = ParseDecimal(txtDienTich.Text);
                    ch.trang_thai = cboTrangThai.SelectedItem?.ToString();
                    ch.toa_nha_id = GetSelectedToaNhaId();

                    db.SaveChanges();
                    AuditLogHelper.GhiLog("SỬA", "can_ho", _selectedId,
                      $"Cập nhật căn hộ {ch.so_can_ho} → trạng thái: {ch.trang_thai}");
                }

                MessageBox.Show("✅ Cập nhật căn hộ thành công!",
                    "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearForm();
            }
            catch (Exception ex) { ShowError("Cập nhật căn hộ thất bại", ex); }
        }

        public void DeleteCanHo()
        {
            if (_selectedId <= 0)
            {
                MessageBox.Show("⚠️ Vui lòng chọn một căn hộ để xóa.",
                    "Chưa chọn dòng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tenCan = txtMaCan.Text.Trim();
            var confirm = MessageBox.Show(
                $"❗ Bạn có chắc muốn xóa căn hộ \"{tenCan}\" không?\n\nHành động này không thể hoàn tác.",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);

            if (confirm != DialogResult.Yes) return;

            try
            {
                using (var db = new DbChungCu())
                {
                    var ch = db.can_ho.Find(_selectedId);
                    if (ch != null)
                    {
                        string tenLog = ch.so_can_ho;
                        db.can_ho.Remove(ch);
                        db.SaveChanges();
                        AuditLogHelper.GhiLog("XÓA", "can_ho", _selectedId,
                          $"Xóa căn hộ {tenLog}");
                    }
                }

                MessageBox.Show("✅ Xóa căn hộ thành công!",
                    "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearForm();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException dbEx)
            {
                MessageBox.Show(
                    "⛔ Không thể xóa căn hộ này vì đang có dữ liệu liên quan\n(cư dân, hóa đơn, hợp đồng, v.v.).",
                    "Không thể xóa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Diagnostics.Debug.WriteLine($"[ucCanHo.Delete] {dbEx}");
            }
            catch (Exception ex) { ShowError("Xóa căn hộ thất bại", ex); }
        }

        public void SearchCanHo()
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
                    var list = db.can_ho
                        .Include("toa_nha")
                        .Where(c =>
                            c.so_can_ho.ToLower().Contains(kw) ||
                            c.trang_thai.ToLower().Contains(kw) ||
                            c.toa_nha.ten_toa.ToLower().Contains(kw))
                        .OrderBy(c => c.toa_nha.ten_toa)
                        .ThenBy(c => c.so_can_ho)
                        .Select(c => new
                        {
                            id = c.id,
                            so_can_ho = c.so_can_ho,
                            tang = c.tang,
                            dien_tich = c.dien_tich,
                            trang_thai = c.trang_thai,
                            ten_toa = c.toa_nha.ten_toa,
                            toa_nha_id = c.toa_nha_id,
                        })
                        .ToList();

                    var dt = new DataTable();
                    dt.Columns.Add("id", typeof(int));
                    dt.Columns.Add("so_can_ho", typeof(string));
                    dt.Columns.Add("tang", typeof(int));
                    dt.Columns.Add("dien_tich", typeof(decimal));
                    dt.Columns.Add("trang_thai", typeof(string));
                    dt.Columns.Add("ten_toa", typeof(string));
                    dt.Columns.Add("toa_nha_id", typeof(int));

                    foreach (var r in list)
                        dt.Rows.Add(r.id, r.so_can_ho, r.tang,
                                    r.dien_tich, r.trang_thai,
                                    r.ten_toa, r.toa_nha_id);

                    dgvCanHo.DataSource = dt;
                    UpdateRecordCount(dt.Rows.Count);
                    ColorTrangThaiRows();
                }
            }
            catch (Exception ex) { ShowError("Tìm kiếm thất bại", ex); }
        }

        private void btnThem_Click(object sender, EventArgs e) => InsertCanHo();
        private void btnSua_Click(object sender, EventArgs e) => UpdateCanHo();
        private void btnXoa_Click(object sender, EventArgs e) => DeleteCanHo();
        private void btnLamMoi_Click(object sender, EventArgs e) { LoadData(); ClearForm(); }
        private void txtSearch_TextChanged(object sender, EventArgs e) => SearchCanHo();

        private void dgvCanHo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                var row = dgvCanHo.Rows[e.RowIndex];

                _selectedId = Convert.ToInt32(row.Cells["colId"].Value);

                txtMaCan.Text = row.Cells["colSoCanHo"].Value?.ToString() ?? "";
                txtTang.Text = row.Cells["colTang"].Value?.ToString() ?? "";
                txtDienTich.Text = row.Cells["colDienTich"].Value?.ToString() ?? "";

                string trangThai = row.Cells["colTrangThai"].Value?.ToString() ?? "";
                cboTrangThai.SelectedIndex = cboTrangThai.Items.IndexOf(trangThai);

                if (dgvCanHo.DataSource is DataTable dt)
                {
                    int toaNhaId = Convert.ToInt32(dt.Rows[e.RowIndex]["toa_nha_id"]);
                    foreach (DataRowView drv in cboToaNha.Items)
                    {
                        if (Convert.ToInt32(drv["id"]) == toaNhaId)
                        {
                            cboToaNha.SelectedItem = drv;
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"[ucCanHo.CellClick] {ex.Message}");
            }
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtMaCan.Text))
            {
                Warn("Vui lòng nhập Số Căn Hộ.", txtMaCan); return false;
            }
            if (!string.IsNullOrWhiteSpace(txtTang.Text))
            {
                if (!int.TryParse(txtTang.Text.Trim(), out int tang) || tang <= 0)
                {
                    Warn("Tầng phải là số nguyên dương.", txtTang); return false;
                }
            }
            if (!string.IsNullOrWhiteSpace(txtDienTich.Text))
            {
                if (!decimal.TryParse(txtDienTich.Text.Trim(), out decimal dt) || dt <= 0)
                {
                    Warn("Diện tích phải là số dương.", txtDienTich); return false;
                }
            }
            if (cboTrangThai.SelectedIndex < 0)
            {
                Warn("Vui lòng chọn Trạng Thái.", cboTrangThai); return false;
            }
            if (cboToaNha.SelectedIndex < 0)
            {
                Warn("Vui lòng chọn Tòa Nhà.", cboToaNha); return false;
            }
            return true;
        }

        private void ColorTrangThaiRows()
        {
            foreach (DataGridViewRow row in dgvCanHo.Rows)
            {
                if (row.IsNewRow) continue;
                string tt = row.Cells["colTrangThai"].Value?.ToString() ?? "";
                Color fg;
                switch (tt)
                {
                    case "da_o": fg = CLR_SUCCESS; break;
                    case "da_cho_thue": fg = CLR_PRIMARY; break;
                    case "trong": fg = CLR_MUTED; break;
                    default: fg = CLR_MUTED; break;
                }
                row.Cells["colTrangThai"].Style.ForeColor = fg;
            }
        }

        private void UpdateRecordCount(int count)
            => lblRecordCount.Text = $"{count:N0} căn hộ";

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

        private static int? ParseInt(string s)
            => int.TryParse(s?.Trim(), out int v) ? (int?)v : null;

        private static decimal? ParseDecimal(string s)
            => decimal.TryParse(s?.Trim(), out decimal v) ? (decimal?)v : null;

        private int GetSelectedToaNhaId()
            => Convert.ToInt32(((DataRowView)cboToaNha.SelectedItem)["id"]);

        
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
}