using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using KhuChungCuDatTam.Models;
using KhuChungCuDatTam.Helpers;

namespace KhuChungCuDatTam.UserControls
{
    public partial class ucDangKyDichVu : UserControl
    {
        public ucDangKyDichVu()
        {
            InitializeComponent();
        }

        private void ucDangKyDichVu_Load(object sender, EventArgs e)
        {
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;

            LoadCanHo();
            LoadDichVu();
            LoadTrangThai();
            LoadData();
            LoadThongKe();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchDangKyDichVu();
        }

        private void cboDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;
            AutoFillGiaDichVu();
        }

        private void dgvDangKyDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            FillFormFromGrid(e.RowIndex);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            InsertDangKyDichVu();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            UpdateDangKyDichVu();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DeleteDangKyDichVu();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void LoadData()
        {
            try
            {
                using (var db = new DbChungCu())
                {
                    var list = db.dang_ky_dich_vu
                        .Include("can_ho")
                        .Include("dich_vu")
                        .ToList();

                    BindGrid(list);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCanHo()
        {
            try
            {
                using (var db = new DbChungCu())
                {
                    var list = db.can_ho.ToList();
                    cboCanHo.DataSource = list;
                    cboCanHo.DisplayMember = "so_can_ho";
                    cboCanHo.ValueMember = "id";
                    cboCanHo.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải căn hộ: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDichVu()
        {
            try
            {
                using (var db = new DbChungCu())
                {
                    var list = db.dich_vu.Where(d => d.trang_thai == "active").ToList();
                    if (!list.Any()) list = db.dich_vu.ToList();

                    cboDichVu.DataSource = list;
                    cboDichVu.DisplayMember = "ten_dich_vu";
                    cboDichVu.ValueMember = "id";
                    cboDichVu.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dịch vụ: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTrangThai()
        {
            var list = new List<ComboItem>
            {
                new ComboItem { Text = "Đang sử dụng", Value = "dang_su_dung" },
                new ComboItem { Text = "Đã hủy",        Value = "da_huy"       }
            };

            cboTrangThai.DataSource = list;
            cboTrangThai.DisplayMember = "Text";
            cboTrangThai.ValueMember = "Value";
            cboTrangThai.SelectedIndex = 0;
        }

        private void LoadThongKe()
        {
            try
            {
                using (var db = new DbChungCu())
                {
                    var all = db.dang_ky_dich_vu.ToList();
                    lblTongDangKy.Text = all.Count.ToString();
                    lblDangHoatDong.Text = all.Count(x => x.trang_thai == "dang_su_dung").ToString();
                    lblHetHan.Text = all.Count(x => x.trang_thai == "da_huy").ToString();
                }
            }
            catch
            {
                lblTongDangKy.Text = "0";
                lblDangHoatDong.Text = "0";
                lblHetHan.Text = "0";
            }
        }

        private void InsertDangKyDichVu()
        {
            if (!ValidateForm()) return;

            try
            {
                using (var db = new DbChungCu())
                {
                    var entity = new dang_ky_dich_vu
                    {
                        can_ho_id = (int)cboCanHo.SelectedValue,
                        dich_vu_id = (int)cboDichVu.SelectedValue,
                        ngay_dang_ky = dtNgayDangKy.Value.Date,
                        trang_thai = cboTrangThai.SelectedValue?.ToString() ?? "dang_su_dung",

                        ngay_huy = cboTrangThai.SelectedValue?.ToString() == "da_huy" ? (DateTime?)dtNgayHetHan.Value.Date : null,
                    };

                    db.dang_ky_dich_vu.Add(entity);
                    db.SaveChanges();
                    AuditLogHelper.GhiLog("THÊM", "dang_ky_dich_vu", entity.id,
    $"Đăng ký dịch vụ ID {entity.dich_vu_id} cho căn hộ ID {entity.can_ho_id} – {entity.trang_thai}");
                }

                MessageBox.Show("Thêm đăng ký dịch vụ thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadData();
                LoadThongKe();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm dữ liệu: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateDangKyDichVu()
        {
            if (dgvDangKyDichVu.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn dòng cần sửa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateForm()) return;

            try
            {
                int id = (int)dgvDangKyDichVu.CurrentRow.Cells["colId"].Value;

                using (var db = new DbChungCu())
                {
                    var entity = db.dang_ky_dich_vu.FirstOrDefault(x => x.id == id);
                    if (entity == null)
                    {
                        MessageBox.Show("Không tìm thấy bản ghi!", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    entity.can_ho_id = (int)cboCanHo.SelectedValue;
                    entity.dich_vu_id = (int)cboDichVu.SelectedValue;
                    entity.ngay_dang_ky = dtNgayDangKy.Value.Date;
                    entity.trang_thai = cboTrangThai.SelectedValue?.ToString() ?? "dang_su_dung";

                    entity.ngay_huy = cboTrangThai.SelectedValue?.ToString() == "da_huy" ? (DateTime?)dtNgayHetHan.Value.Date : null;

                    db.SaveChanges();
                    AuditLogHelper.GhiLog("SỬA", "dang_ky_dich_vu", entity.id,
    $"Cập nhật đăng ký #{entity.id} – căn hộ ID {entity.can_ho_id} – {entity.trang_thai}");
                }

                MessageBox.Show("Cập nhật thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadData();
                LoadThongKe();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteDangKyDichVu()
        {
            if (dgvDangKyDichVu.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Bạn có chắc muốn xóa đăng ký này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                int id = (int)dgvDangKyDichVu.CurrentRow.Cells["colId"].Value;

                using (var db = new DbChungCu())
                {
                    var entity = db.dang_ky_dich_vu.FirstOrDefault(x => x.id == id);
                    if (entity == null)
                    {
                        MessageBox.Show("Không tìm thấy bản ghi!", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string logInfo = $"Xóa đăng ký dịch vụ #{entity.id} – căn hộ ID {entity.can_ho_id} – dịch vụ ID {entity.dich_vu_id}";
                    db.dang_ky_dich_vu.Remove(entity);
                    db.SaveChanges();
                    AuditLogHelper.GhiLog("XÓA", "dang_ky_dich_vu", id, logInfo);
                }

                MessageBox.Show("Xóa thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadData();
                LoadThongKe();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa dữ liệu: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchDangKyDichVu()
        {
            try
            {
                string keyword = txtSearch.Text.Trim().ToLower();

                using (var db = new DbChungCu())
                {
                    var list = db.dang_ky_dich_vu
                        .Include("can_ho")
                        .Include("dich_vu")
                        .ToList()
                        .Where(x =>
                            (x.can_ho != null && x.can_ho.so_can_ho != null &&
                             x.can_ho.so_can_ho.ToLower().Contains(keyword)) ||
                            (x.dich_vu != null && x.dich_vu.ten_dich_vu != null &&
                             x.dich_vu.ten_dich_vu.ToLower().Contains(keyword)) ||
                            (x.trang_thai != null &&
                             x.trang_thai.ToLower().Contains(keyword))
                        ).ToList();

                    BindGrid(list);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BindGrid(List<dang_ky_dich_vu> list)
        {
            dgvDangKyDichVu.Rows.Clear();

            foreach (var item in list)
            {
                string soCanHo = item.can_ho?.so_can_ho ?? "(N/A)";
                string tenDichVu = item.dich_vu?.ten_dich_vu ?? "(N/A)";
                decimal donGia = item.dich_vu?.don_gia ?? 0;
                string ngayHuy = item.ngay_huy.HasValue
                    ? item.ngay_huy.Value.ToString("dd/MM/yyyy")
                    : "-";

                dgvDangKyDichVu.Rows.Add(
                    item.id,
                    soCanHo,
                    tenDichVu,
                    item.ngay_dang_ky.ToString("dd/MM/yyyy"),
                    ngayHuy,
                    donGia.ToString("N0") + " đ",
                    item.trang_thai
                );
            }
        }

        private void FillFormFromGrid(int rowIndex)
        {
            try
            {
                var row = dgvDangKyDichVu.Rows[rowIndex];

                int id = Convert.ToInt32(row.Cells["colId"].Value);

                using (var db = new DbChungCu())
                {
                    var entity = db.dang_ky_dich_vu
                        .Include("can_ho")
                        .Include("dich_vu")
                        .FirstOrDefault(x => x.id == id);

                    if (entity == null) return;

                    cboCanHo.SelectedValue = entity.can_ho_id;
                    cboDichVu.SelectedValue = entity.dich_vu_id;
                    dtNgayDangKy.Value = entity.ngay_dang_ky;

                    if (entity.ngay_huy.HasValue)
                        dtNgayHetHan.Value = entity.ngay_huy.Value;

                    cboTrangThai.SelectedItem = entity.trang_thai;

                    if (entity.dich_vu != null)
                        txtGiaDichVu.Text = entity.dich_vu.don_gia.ToString("N0");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đổ dữ liệu: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AutoFillGiaDichVu()
        {
            try
            {
                if (cboDichVu.SelectedValue == null) return;

                int dichVuId = (int)cboDichVu.SelectedValue;

                using (var db = new DbChungCu())
                {
                    var dv = db.dich_vu.FirstOrDefault(x => x.id == dichVuId);
                    if (dv != null)
                        txtGiaDichVu.Text = dv.don_gia.ToString("N0");
                }
            }
            catch {  }
        }

        private void ClearForm()
        {
            cboCanHo.SelectedIndex = -1;
            cboDichVu.SelectedIndex = -1;
            cboTrangThai.SelectedIndex = 0;
            dtNgayDangKy.Value = DateTime.Now;
            dtNgayHetHan.Value = DateTime.Now;
            txtGiaDichVu.Text = string.Empty;
            txtGhiChu.Text = string.Empty;
            txtSearch.Text = string.Empty;
            dgvDangKyDichVu.ClearSelection();
        }

        private bool ValidateForm()
        {
            if (cboCanHo.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn căn hộ!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboCanHo.Focus();
                return false;
            }

            if (cboDichVu.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn dịch vụ!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboDichVu.Focus();
                return false;
            }

            if (cboTrangThai.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn trạng thái!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboTrangThai.Focus();
                return false;
            }

            return true;
        }
    }
}