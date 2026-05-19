using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using KhuChungCuDatTam.Helpers;
using KhuChungCuDatTam.Models;

namespace KhuChungCuDatTam.UserControls
{
    public partial class ucHopDong : UserControl
    {
        private int _selectedId = -1;

        public ucHopDong()
        {
            InitializeComponent();
            this.Load += ucHopDong_Load;
        }


        private void ucHopDong_Load(object sender, EventArgs e)
        {
            LoadComboBoxStatic();
            LoadCuDan();
            LoadCanHo();
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            InsertHopDong();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            UpdateHopDong();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DeleteHopDong();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearForm();
            LoadData();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchHopDong();
        }

        private void dgvHopDong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvHopDong.Rows[e.RowIndex];
            _selectedId = Convert.ToInt32(row.Cells["colId"].Value);

            SetComboBoxById(cboCuDan, row.Cells["colCuDanId"].Value);
            SetComboBoxById(cboCanHo, row.Cells["colCanHoId"].Value);
            SetComboBoxByText(cboLoaiHopDong, row.Cells["colLoaiHopDong"].Value?.ToString());
            SetComboBoxByText(cboTrangThai, row.Cells["colTrangThai"].Value?.ToString());

            if (DateTime.TryParse(row.Cells["colNgayBatDau"].Value?.ToString(), out DateTime nbd))
                dtNgayBatDau.Value = nbd;

            if (row.Cells["colNgayKetThuc"].Value != null &&
                DateTime.TryParse(row.Cells["colNgayKetThuc"].Value.ToString(), out DateTime nkt))
                dtNgayKetThuc.Value = nkt;

            txtGiaTri.Text = row.Cells["colGiaTri"].Value?.ToString();
            txtTienDatCoc.Text = row.Cells["colTienDatCoc"].Value?.ToString();
        }


        private void LoadData()
        {
            try
            {
                using (var db = new DbChungCu())
                {
                    var list = db.hop_dong
                        .Include(h => h.cu_dan)
                        .Include(h => h.can_ho)
                        .ToList();

                    BindGrid(list);
                }
            }
            catch (Exception ex)
            {
                ShowError("Tải dữ liệu thất bại", ex);
            }
        }

        private void LoadCuDan()
        {
            try
            {
                using (var db = new DbChungCu())
                {
                    var list = db.cu_dan
                        .OrderBy(c => c.ho_ten)
                        .Select(c => new { c.id, c.ho_ten })
                        .ToList();

                    cboCuDan.DataSource = list;
                    cboCuDan.DisplayMember = "ho_ten";
                    cboCuDan.ValueMember = "id";
                    cboCuDan.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                ShowError("Tải dữ liệu thất bại", ex);
            }
        }

        private void LoadCanHo()
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
                ShowError("Tải dữ liệu thất bại", ex);
            }
        }
        private void LoadComboBoxStatic()
        {
            cboLoaiHopDong.Items.Clear();
            cboLoaiHopDong.Items.Add("so_huu");
            cboLoaiHopDong.Items.Add("cho_thue");
            cboLoaiHopDong.SelectedIndex = -1;

            cboTrangThai.Items.Clear();
            cboTrangThai.Items.Add("dang_hieu_luc");
            cboTrangThai.Items.Add("het_hieu_luc");
            cboTrangThai.Items.Add("da_het");
            cboTrangThai.SelectedIndex = -1;
        }


        private void InsertHopDong()
        {
            if (!ValidateForm()) return;

            try
            {
                using (var db = new DbChungCu())
                {
                    var hd = new hop_dong
                    {
                        cu_dan_id = (int)cboCuDan.SelectedValue,
                        can_ho_id = (int)cboCanHo.SelectedValue,
                        loai_hop_dong = cboLoaiHopDong.SelectedItem.ToString(),
                        ngay_bat_dau = dtNgayBatDau.Value.Date,
                        ngay_ket_thuc = dtNgayKetThuc.Value.Date,
                        gia_tri_hop_dong = ParseDecimal(txtGiaTri.Text),
                        tien_dat_coc = ParseDecimal(txtTienDatCoc.Text) ?? 0,
                        trang_thai = cboTrangThai.SelectedItem.ToString()
                    };

                    db.hop_dong.Add(hd);
                    db.SaveChanges();
                    AuditLogHelper.GhiLog("THÊM", "hop_dong", hd.id,
    $"Thêm hợp đồng #{hd.id} – cư dân ID {hd.cu_dan_id} – căn hộ ID {hd.can_ho_id} – {hd.loai_hop_dong} – {hd.trang_thai}");
                }

                ShowInfo("Thêm hợp đồng thành công!");
                ClearForm();
                LoadData();
            }
            catch (Exception ex)
            {
                ShowError("Tải dữ liệu thất bại", ex);
            }
        }

        private void UpdateHopDong()
        {
            if (_selectedId < 0)
            {
                ShowWarning("Vui lòng chọn hợp đồng cần sửa.");
                return;
            }
            if (!ValidateForm()) return;

            try
            {
                using (var db = new DbChungCu())
                {
                    var hd = db.hop_dong.FirstOrDefault(h => h.id == _selectedId);
                    if (hd == null)
                    {
                        ShowWarning("Không tìm thấy hợp đồng.");
                        return;
                    }

                    hd.cu_dan_id = (int)cboCuDan.SelectedValue;
                    hd.can_ho_id = (int)cboCanHo.SelectedValue;
                    hd.loai_hop_dong = cboLoaiHopDong.SelectedItem.ToString();
                    hd.ngay_bat_dau = dtNgayBatDau.Value.Date;
                    hd.ngay_ket_thuc = dtNgayKetThuc.Value.Date;
                    hd.gia_tri_hop_dong = ParseDecimal(txtGiaTri.Text);
                    hd.tien_dat_coc = ParseDecimal(txtTienDatCoc.Text) ?? 0;
                    hd.trang_thai = cboTrangThai.SelectedItem.ToString();

                    db.SaveChanges();
                    AuditLogHelper.GhiLog("SỬA", "hop_dong", _selectedId,
    $"Cập nhật hợp đồng #{_selectedId} – {hd.loai_hop_dong} – {hd.ngay_bat_dau:dd/MM/yyyy} → {hd.ngay_ket_thuc:dd/MM/yyyy} – {hd.trang_thai}");
                }

                ShowInfo("Cập nhật hợp đồng thành công!");
                ClearForm();
                LoadData();
            }
            catch (Exception ex)
            {
                ShowError("Tải dữ liệu thất bại", ex);
            }
        }

        private void DeleteHopDong()
        {
            if (_selectedId < 0)
            {
                ShowWarning("Vui lòng chọn hợp đồng cần xóa.");
                return;
            }

            var confirm = MessageBox.Show(
                "Bạn có chắc muốn xóa hợp đồng này?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            try
            {
                using (var db = new DbChungCu())
                {
                    var hd = db.hop_dong.FirstOrDefault(h => h.id == _selectedId);
                    if (hd == null)
                    {
                        ShowWarning("Không tìm thấy hợp đồng.");
                        return;
                    }
                    string logInfo = $"Xóa hợp đồng #{hd.id} – cư dân ID {hd.cu_dan_id} – căn hộ ID {hd.can_ho_id} – {hd.loai_hop_dong}";
                    db.hop_dong.Remove(hd);
                    db.SaveChanges();
                    AuditLogHelper.GhiLog("XÓA", "hop_dong", _selectedId, logInfo);
                }

                ShowInfo("Xóa hợp đồng thành công!");
                ClearForm();
                LoadData();
            }
            catch (Exception ex)
            {
                ShowError("Tải dữ liệu thất bại", ex);
            }
        }

        private void SearchHopDong()
        {
            string keyword = txtSearch.Text.Trim().ToLower();

            try
            {
                using (var db = new DbChungCu())
                {
                    var list = db.hop_dong
                        .Include(h => h.cu_dan)
                        .Include(h => h.can_ho)
                        .Where(h =>
                            h.cu_dan.ho_ten.ToLower().Contains(keyword) ||
                            h.can_ho.so_can_ho.ToLower().Contains(keyword) ||
                            h.loai_hop_dong.ToLower().Contains(keyword) ||
                            h.trang_thai.ToLower().Contains(keyword))
                        .ToList();

                    BindGrid(list);
                }
            }
            catch (Exception ex)
            {
                ShowError("Tải dữ liệu thất bại", ex);
            }
        }

        private void ClearForm()
        {
            _selectedId = -1;
            cboCuDan.SelectedIndex = -1;
            cboCanHo.SelectedIndex = -1;
            cboLoaiHopDong.SelectedIndex = -1;
            cboTrangThai.SelectedIndex = -1;
            dtNgayBatDau.Value = DateTime.Today;
            dtNgayKetThuc.Value = DateTime.Today;
            txtGiaTri.Text = string.Empty;
            txtTienDatCoc.Text = string.Empty;
            txtSearch.Text = string.Empty;
        }

        // ─────────────────────────────────────────────
        //  HELPERS
        // ─────────────────────────────────────────────

        private void BindGrid(List<hop_dong> list)
        {
            dgvHopDong.Rows.Clear();

            foreach (var hd in list)
            {
                dgvHopDong.Rows.Add(
                    hd.id,
                    hd.cu_dan_id,
                    hd.can_ho_id,
                    hd.cu_dan?.ho_ten,
                    hd.can_ho?.so_can_ho,
                    hd.loai_hop_dong,
                    hd.ngay_bat_dau.ToString("dd/MM/yyyy"),
                    hd.ngay_ket_thuc?.ToString("dd/MM/yyyy"),
                    hd.gia_tri_hop_dong?.ToString("N0"),
                    hd.tien_dat_coc.ToString("N0"),
                    hd.trang_thai
                );
            }
        }

        private bool ValidateForm()
        {
            if (cboCuDan.SelectedIndex < 0)
            {
                ShowWarning("Vui lòng chọn cư dân.");
                cboCuDan.Focus();
                return false;
            }
            if (cboCanHo.SelectedIndex < 0)
            {
                ShowWarning("Vui lòng chọn căn hộ.");
                cboCanHo.Focus();
                return false;
            }
            if (cboLoaiHopDong.SelectedIndex < 0)
            {
                ShowWarning("Vui lòng chọn loại hợp đồng.");
                cboLoaiHopDong.Focus();
                return false;
            }
            if (cboTrangThai.SelectedIndex < 0)
            {
                ShowWarning("Vui lòng chọn trạng thái.");
                cboTrangThai.Focus();
                return false;
            }
            if (dtNgayKetThuc.Value.Date < dtNgayBatDau.Value.Date)
            {
                ShowWarning("Ngày kết thúc phải sau ngày bắt đầu.");
                return false;
            }
            if (!string.IsNullOrWhiteSpace(txtGiaTri.Text) &&
                !decimal.TryParse(txtGiaTri.Text, out _))
            {
                ShowWarning("Giá trị hợp đồng không hợp lệ.");
                txtGiaTri.Focus();
                return false;
            }
            if (!decimal.TryParse(txtTienDatCoc.Text, out _))
            {
                ShowWarning("Tiền đặt cọc không hợp lệ.");
                txtTienDatCoc.Focus();
                return false;
            }

            return true;
        }

        private static decimal? ParseDecimal(string text)
        {
            if (string.IsNullOrWhiteSpace(text)) return null;
            return decimal.TryParse(text, out decimal val) ? val : (decimal?)null;
        }

        private void SetComboBoxById(ComboBox cbo, object value)
        {
            if (value == null) return;
            cbo.SelectedValue = Convert.ToInt32(value);
        }

        private void SetComboBoxByText(ComboBox cbo, string text)
        {
            if (text == null) return;
            int idx = cbo.Items.IndexOf(text);
            if (idx >= 0) cbo.SelectedIndex = idx;
        }

        private static void ShowInfo(string msg) => MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        private static void ShowWarning(string msg) => MessageBox.Show(msg, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        private static void ShowError(string context, Exception ex)
        {
            Exception inner = ex;
            while (inner.InnerException != null)
                inner = inner.InnerException;

            string detail = inner.Message;
            MessageBox.Show($"{context}:\n{detail}", "Lỗi",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            System.Diagnostics.Debug.WriteLine($"[ucHopDong] {context}: {ex}");
        }
    }
}