using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using KhuChungCuDatTam.Helpers;
using KhuChungCuDatTam.Models;

namespace KhuChungCuDatTam.UserControls
{
    public partial class ucCuDan : UserControl
    {
        private static readonly Color CLR_BG = Color.FromArgb(15, 23, 42);
        private static readonly Color CLR_CARD = Color.FromArgb(30, 41, 59);
        private static readonly Color CLR_MUTED = Color.FromArgb(100, 116, 139);
        private static readonly Color CLR_PRIMARY = Color.FromArgb(59, 130, 246);
        private static readonly Color CLR_SUCCESS = Color.FromArgb(16, 185, 129);
        private static readonly Color CLR_DANGER = Color.FromArgb(239, 68, 68);
        private static readonly Color CLR_WARN = Color.FromArgb(245, 158, 11);

        private int _selectedId = -1;   

        public ucCuDan()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint, true);
        }

        private void ucCuDan_Load(object sender, EventArgs e)
        {
            ApplyRoundedCard(pnlFormCard);
            ApplyRoundedCard(pnlGridCard);

            LoadCanHo();
            LoadData();
        }

        public void LoadData()
        {
            try
            {
                using (var db = new DbChungCu())
                {
                    var list = db.cu_dan
                                 .Include("can_ho")
                                 .OrderBy(c => c.ho_ten)
                                 .ToList();

                    BindGrid(list);
                }
            }
            catch (Exception ex)
            {
                ShowError("Tải dữ liệu thất bại", ex);
            }
        }

        public void LoadCanHo()
        {
            try
            {
                using (var db = new DbChungCu())
                {
                    var list = db.can_ho
                                 .OrderBy(c => c.so_can_ho)
                                 .Select(c => new { c.id, c.so_can_ho })
                                 .ToList();

                    cboCanHo.DataSource = list;
                    cboCanHo.DisplayMember = "so_can_ho";
                    cboCanHo.ValueMember = "id";
                    cboCanHo.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                ShowError("Tải danh sách căn hộ thất bại", ex);
            }
        }

        public void ClearForm()
        {
            _selectedId = -1;

            txtHoTen.Clear();
            dtNgaySinh.Value = DateTime.Today;
            cboLoaiCuDan.SelectedIndex = -1;
            txtSDT.Clear();
            txtEmail.Clear();
            txtCCCD.Clear();
            cboCanHo.SelectedIndex = -1;

            if (dgvCuDan.Rows.Count > 0)
                dgvCuDan.ClearSelection();

            txtHoTen.Focus();
        }

        public void InsertCuDan()
        {
            if (!ValidateForm()) return;

            try
            {
                using (var db = new DbChungCu())
                {
                    var cuDan = new cu_dan
                    {
                        ho_ten = txtHoTen.Text.Trim(),
                        ngay_sinh = dtNgaySinh.Value.Date,
                        loai_cu_dan = cboLoaiCuDan.SelectedItem?.ToString() ?? "",
                        so_dien_thoai = txtSDT.Text.Trim(),
                        email = txtEmail.Text.Trim(),
                        cmnd_cccd = txtCCCD.Text.Trim(),
                        can_ho_id = (int)cboCanHo.SelectedValue,
                        ngay_vao = DateTime.Today
                    };
                    
                    db.cu_dan.Add(cuDan);
                    db.SaveChanges();
                    AuditLogHelper.GhiLog("THÊM", "cu_dan", cuDan.id,
    $"Thêm cư dân {cuDan.ho_ten} – {cuDan.loai_cu_dan} – căn hộ ID {cuDan.can_ho_id}");
                }

                MessageBox.Show("✅ Thêm cư dân thành công!",
                    "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadData();
                ClearForm();
            }
            catch (Exception ex)
            {
                ShowError("Thêm cư dân thất bại", ex);
            }
        }

        public void UpdateCuDan()
        {
            if (_selectedId <= 0)
            {
                MessageBox.Show("⚠️ Vui lòng chọn một cư dân để sửa.",
                    "Chưa chọn dòng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateForm()) return;

            try
            {
                using (var db = new DbChungCu())
                {
                    var cuDan = db.cu_dan.FirstOrDefault(c => c.id == _selectedId);
                    if (cuDan == null)
                    {
                        MessageBox.Show("⚠️ Không tìm thấy cư dân này trong CSDL.",
                            "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    cuDan.ho_ten = txtHoTen.Text.Trim();
                    cuDan.ngay_sinh = dtNgaySinh.Value.Date;
                    cuDan.loai_cu_dan = cboLoaiCuDan.SelectedItem?.ToString() ?? "";
                    cuDan.so_dien_thoai = txtSDT.Text.Trim();
                    cuDan.email = txtEmail.Text.Trim();
                    cuDan.cmnd_cccd = txtCCCD.Text.Trim();
                    cuDan.can_ho_id = (int)cboCanHo.SelectedValue;

                    db.SaveChanges();
                    AuditLogHelper.GhiLog("SỬA", "cu_dan", _selectedId,
    $"Cập nhật cư dân {cuDan.ho_ten} – {cuDan.loai_cu_dan} – căn hộ ID {cuDan.can_ho_id}");
                }

                MessageBox.Show("✅ Cập nhật cư dân thành công!",
                    "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadData();
                ClearForm();
            }
            catch (Exception ex)
            {
                ShowError("Cập nhật cư dân thất bại", ex);
            }
        }

        public void DeleteCuDan()
        {
            if (_selectedId <= 0)
            {
                MessageBox.Show("⚠️ Vui lòng chọn một cư dân để xóa.",
                    "Chưa chọn dòng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tenCuDan = txtHoTen.Text.Trim();
            var confirm = MessageBox.Show(
                $"❗ Bạn có chắc muốn xóa cư dân \"{tenCuDan}\" không?\n\nHành động này không thể hoàn tác.",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);

            if (confirm != DialogResult.Yes) return;

            try
            {
                using (var db = new DbChungCu())
                {
                    var cuDan = db.cu_dan.FirstOrDefault(c => c.id == _selectedId);
                    if (cuDan == null) return;
                    string logInfo = $"Xóa cư dân {cuDan.ho_ten} – CCCD {cuDan.cmnd_cccd}";
                    db.cu_dan.Remove(cuDan);
                    db.SaveChanges();
                    AuditLogHelper.GhiLog("XÓA", "cu_dan", _selectedId, logInfo);
                }

                MessageBox.Show("✅ Xóa cư dân thành công!",
                    "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadData();
                ClearForm();
            }
            catch (Exception ex)
            {
                if (ex.InnerException?.InnerException?.Message.Contains("FOREIGN KEY") == true ||
                    ex.InnerException?.Message.Contains("FOREIGN KEY") == true)
                {
                    MessageBox.Show(
                        "⛔ Không thể xóa cư dân này vì đang có dữ liệu liên quan\n(hợp đồng, phương tiện, khiếu nại, v.v.).",
                        "Không thể xóa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ShowError("Xóa cư dân thất bại", ex);
                }
            }
        }

        public void SearchCuDan()
        {
            string kw = txtSearch.Text.Trim().ToLower();

            try
            {
                using (var db = new DbChungCu())
                {
                    var query = db.cu_dan.Include("can_ho").AsQueryable();

                    if (!string.IsNullOrEmpty(kw))
                    {
                        query = query.Where(c =>
                            c.ho_ten.ToLower().Contains(kw) ||
                            c.so_dien_thoai.ToLower().Contains(kw) ||
                            c.cmnd_cccd.ToLower().Contains(kw) ||
                            c.loai_cu_dan.ToLower().Contains(kw) ||
                            (c.email != null && c.email.ToLower().Contains(kw)) ||
                            c.can_ho.so_can_ho.ToLower().Contains(kw));
                    }

                    var list = query.OrderBy(c => c.ho_ten).ToList();
                    BindGrid(list);
                }
            }
            catch (Exception ex)
            {
                ShowError("Tìm kiếm thất bại", ex);
            }
        }
        private void btnThem_Click(object sender, EventArgs e) => InsertCuDan();
        private void btnSua_Click(object sender, EventArgs e) => UpdateCuDan();
        private void btnXoa_Click(object sender, EventArgs e) => DeleteCuDan();
        private void btnLamMoi_Click(object sender, EventArgs e) { LoadData(); ClearForm(); }
        private void txtSearch_TextChanged(object sender, EventArgs e) => SearchCuDan();

        private void dgvCuDan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                var row = dgvCuDan.Rows[e.RowIndex];

                _selectedId = Convert.ToInt32(row.Cells["colId"].Value);

                txtHoTen.Text = row.Cells["colHoTen"].Value?.ToString() ?? "";
                txtSDT.Text = row.Cells["colSDT"].Value?.ToString() ?? "";
                txtEmail.Text = row.Cells["colEmail"].Value?.ToString() ?? "";
                txtCCCD.Text = row.Cells["colCCCD"].Value?.ToString() ?? "";

                var ngaySinhVal = row.Cells["colNgaySinh"].Value;
                if (ngaySinhVal != null && ngaySinhVal != DBNull.Value)
                    dtNgaySinh.Value = Convert.ToDateTime(ngaySinhVal);
                else
                    dtNgaySinh.Value = DateTime.Today;

                string loai = row.Cells["colLoaiCuDan"].Value?.ToString() ?? "";
                cboLoaiCuDan.SelectedIndex = cboLoaiCuDan.Items.IndexOf(loai);

                var canHoIdVal = row.Cells["colCanHoId"].Value;
                if (canHoIdVal != null && canHoIdVal != DBNull.Value)
                    cboCanHo.SelectedValue = Convert.ToInt32(canHoIdVal);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"[ucCuDan.CellClick] {ex.Message}");
            }
        }

        private void BindGrid(List<cu_dan> list)
        {
            dgvCuDan.Rows.Clear();

            foreach (var c in list)
            {
                int idx = dgvCuDan.Rows.Add(
                    c.id,
                    c.can_ho_id,
                    c.ho_ten,
                    c.ngay_sinh.HasValue ? c.ngay_sinh.Value.ToString("dd/MM/yyyy") : "",
                    MapLoaiCuDan(c.loai_cu_dan),
                    c.so_dien_thoai ?? "",
                    c.email ?? "",
                    c.cmnd_cccd ?? "",
                    c.can_ho?.so_can_ho ?? ""
                );

                ColorLoaiRow(dgvCuDan.Rows[idx], c.loai_cu_dan);
            }

            UpdateRecordCount(list.Count);
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                Warn("Vui lòng nhập Họ và Tên.", txtHoTen);
                return false;
            }

            if (txtHoTen.Text.Trim().Length < 2)
            {
                Warn("Họ và Tên phải có ít nhất 2 ký tự.", txtHoTen);
                return false;
            }

            if (cboLoaiCuDan.SelectedIndex < 0)
            {
                Warn("Vui lòng chọn Loại Cư Dân.", cboLoaiCuDan);
                return false;
            }

            if (cboCanHo.SelectedIndex < 0)
            {
                Warn("Vui lòng chọn Căn Hộ.", cboCanHo);
                return false;
            }

            string sdt = txtSDT.Text.Trim();
            if (!string.IsNullOrEmpty(sdt))
            {
                if (sdt.Length < 9 || sdt.Length > 11 || !System.Text.RegularExpressions.Regex.IsMatch(sdt, @"^\d+$"))
                {
                    Warn("Số điện thoại không hợp lệ (9–11 chữ số).", txtSDT);
                    return false;
                }
            }

            string email = txtEmail.Text.Trim();
            if (!string.IsNullOrEmpty(email))
            {
                if (!email.Contains("@") || !email.Contains("."))
                {
                    Warn("Email không đúng định dạng.", txtEmail);
                    return false;
                }
            }

            string cccd = txtCCCD.Text.Trim();
            if (!string.IsNullOrEmpty(cccd))
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(cccd, @"^\d{9}$|^\d{12}$"))
                {
                    Warn("CMND/CCCD phải có 9 hoặc 12 chữ số.", txtCCCD);
                    return false;
                }
            }

            if (dtNgaySinh.Value.Date > DateTime.Today)
            {
                Warn("Ngày sinh không được là ngày trong tương lai.", dtNgaySinh);
                return false;
            }

            return true;
        }

        private static string MapLoaiCuDan(string raw)
        {
            switch (raw?.ToLower())
            {
                case "chu_ho": return "👑 Chủ hộ";
                case "thanh_vien": return "👥 Thành viên";
                default: return raw ?? "";
            }
        }

        private void ColorLoaiRow(DataGridViewRow row, string loai)
        {
            Color fg;
            switch (loai?.ToLower())
            {
                case "chu_ho": fg = CLR_PRIMARY; break;
                case "thanh_vien": fg = CLR_SUCCESS; break;
                default: fg = CLR_MUTED; break;
            }
            row.Cells["colLoaiCuDan"].Style.ForeColor = fg;
        }

        private void UpdateRecordCount(int count)
        {
            lblRecordCount.Text = $"{count:N0} cư dân";
        }

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
            System.Diagnostics.Debug.WriteLine($"[ucCuDan] {context}: {ex}");
        }
    }
}