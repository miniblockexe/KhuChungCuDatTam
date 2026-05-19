using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using KhuChungCuDatTam.Models;
using KhuChungCuDatTam.Helpers;
using KhuChungCuDatTam.Forms;
using KhuChungCuDatTam.ReportView;

namespace KhuChungCuDatTam.UserControls
{
    public partial class ucBaoTri : UserControl
    {
        private int _selectedId = -1;

        public ucBaoTri()
        {
            InitializeComponent();
        }

        private void ucBaoTri_Load(object sender, EventArgs e)
        {
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;

            InitComboBoxData();
            LoadData();
            LoadThongKe();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchBaoTri();
        }

        private void dgvBaoTri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            FillFormFromGrid(e.RowIndex);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            InsertBaoTri();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            UpdateBaoTri();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DeleteBaoTri();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearForm();
            LoadData();
        }

        private void txtChiPhi_Leave(object sender, EventArgs e)
        {
            FormatChiPhi();
        }

        private void txtChiPhi_Enter(object sender, EventArgs e)
        {
            string raw = txtChiPhi.Text.Replace(",", "").Replace(".", "").Trim();
            txtChiPhi.Text = raw;
        }

        private void InitComboBoxData()
        {
            cboTrangThai.Items.Clear();
            cboTrangThai.DataSource = new[]
            {
                new { Value = "moi",        Display = "Mới"         },
                new { Value = "dang_xu_ly", Display = "Đang xử lý" },
                new { Value = "hoan_thanh", Display = "Hoàn thành" },
            };
            cboTrangThai.DisplayMember = "Display";
            cboTrangThai.ValueMember = "Value";
            cboTrangThai.SelectedIndex = 0;

            LoadComboCanHo();
            LoadComboNhanVien();
        }

        private void LoadComboCanHo()
        {
            try
            {
                using (var db = new DbChungCu())
                {
                    var dsCanHo = db.can_ho
                        .OrderBy(x => x.so_can_ho)
                        .Select(x => new { x.id, x.so_can_ho })
                        .ToList();

                    var result = dsCanHo
                        .Select(x => new { id = (int?)x.id, so_can_ho = x.so_can_ho })
                        .ToList();

                    cboCanHo.DataSource = result;
                    cboCanHo.DisplayMember = "so_can_ho";
                    cboCanHo.ValueMember = "id";
                    cboCanHo.SelectedIndex = 0;
                }
            }
            catch { }
        }

        private void LoadComboNhanVien()
        {
            try
            {
                using (var db = new DbChungCu())
                {
                    var dsNV = db.nguoi_dung
                        .Where(x => x.trang_thai == "active" || x.trang_thai == "Active")
                        .OrderBy(x => x.ho_ten)
                        .Select(x => new { x.id, x.ho_ten })
                        .ToList();

                    var result = dsNV
                        .Select(x => new { id = (int?)x.id, ho_ten = x.ho_ten ?? x.id.ToString() })
                        .ToList();

                    cboNhanVien.DataSource = result;
                    cboNhanVien.DisplayMember = "ho_ten";
                    cboNhanVien.ValueMember = "id";

                    if (cboNhanVien.Items.Count > 0)
                        cboNhanVien.SelectedIndex = 0;
                }
            }
            catch { }
        }

        public void LoadData()
        {
            try
            {
                using (var db = new DbChungCu())
                {
                    var list = db.bao_tri
                        .Include("can_ho")
                        .Include("nguoi_dung")
                        .OrderByDescending(x => x.ngay_yeu_cau)
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

        private void BindGrid(List<bao_tri> list)
        {
            dgvBaoTri.Rows.Clear();

            foreach (var bt in list)
            {
                string canHo = bt.can_ho != null ? bt.can_ho.so_can_ho : "(Chung cư)";
                string nhanVien = bt.nguoi_dung != null ? bt.nguoi_dung.ho_ten ?? "---" : "---";
                string chiPhi = bt.chi_phi.HasValue
                    ? bt.chi_phi.Value.ToString("#,##0") + " đ"
                    : "---";
                string ngayHT = bt.ngay_hoan_thanh.HasValue
                    ? bt.ngay_hoan_thanh.Value.ToString("dd/MM/yyyy")
                    : "---";

                int rowIdx = dgvBaoTri.Rows.Add(
                    bt.id,
                    canHo,
                    bt.mo_ta,
                    bt.ngay_yeu_cau.ToString("dd/MM/yyyy"),
                    ngayHT,
                    chiPhi,
                    nhanVien,
                    bt.trang_thai
                );

                if (bt.trang_thai == "dang_xu_ly")
                {
                    dgvBaoTri.Rows[rowIdx].DefaultCellStyle.ForeColor =
                        Color.FromArgb(234, 179, 8);
                    dgvBaoTri.Rows[rowIdx].DefaultCellStyle.Font =
                        new Font(dgvBaoTri.Font, FontStyle.Bold);
                }
                if (bt.trang_thai == "moi")
                {
                    dgvBaoTri.Rows[rowIdx].DefaultCellStyle.ForeColor =
                        Color.FromArgb(251, 146, 60);
                }
            }
        }

        public void LoadThongKe()
        {
            try
            {
                using (var db = new DbChungCu())
                {
                    int tong = db.bao_tri.Count();
                    int dangXuLy = db.bao_tri.Count(x => x.trang_thai == "dang_xu_ly" || x.trang_thai == "moi");
                    int hoanThanh = db.bao_tri.Count(x => x.trang_thai == "hoan_thanh");

                    lblTongBaoTri.Text = tong.ToString();
                    lblDangXuLy.Text = dangXuLy.ToString();
                    lblHoanThanh.Text = hoanThanh.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thống kê: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ClearForm()
        {
            _selectedId = -1;
            txtMoTa.Text = string.Empty;
            txtChiPhi.Text = string.Empty;
            txtSearch.Text = string.Empty;
            dtNgayBaoTri.Value = DateTime.Now;
            dtNgayHoanThanh.Value = DateTime.Now;
            chkNgayHoanThanh.Checked = false;
            dtNgayHoanThanh.Enabled = false;
            cboTrangThai.SelectedIndex = 0;

            if (cboCanHo.Items.Count > 0) cboCanHo.SelectedIndex = 0;
            if (cboNhanVien.Items.Count > 0) cboNhanVien.SelectedIndex = 0;

            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }


        private void FillFormFromGrid(int rowIndex)
        {
            try
            {
                var row = dgvBaoTri.Rows[rowIndex];
                if (row.Cells[0].Value == null) return;

                _selectedId = Convert.ToInt32(row.Cells[0].Value);

                using (var db = new DbChungCu())
                {
                    var bt = db.bao_tri.FirstOrDefault(x => x.id == _selectedId);
                    if (bt == null) return;

                    txtMoTa.Text = bt.mo_ta;
                    dtNgayBaoTri.Value = bt.ngay_yeu_cau;
                    txtChiPhi.Text = bt.chi_phi.HasValue
                        ? bt.chi_phi.Value.ToString("#,##0")
                        : string.Empty;

                    if (bt.ngay_hoan_thanh.HasValue)
                    {
                        chkNgayHoanThanh.Checked = true;
                        dtNgayHoanThanh.Enabled = true;
                        dtNgayHoanThanh.Value = bt.ngay_hoan_thanh.Value;
                    }
                    else
                    {
                        chkNgayHoanThanh.Checked = false;
                        dtNgayHoanThanh.Enabled = false;
                        dtNgayHoanThanh.Value = DateTime.Now;
                    }

                    int tsIdx = cboTrangThai.Items.IndexOf(bt.trang_thai);
                    cboTrangThai.SelectedIndex = tsIdx >= 0 ? tsIdx : 0;

                    SetComboById(cboCanHo, bt.can_ho_id);
                    SetComboById(cboNhanVien, bt.nhan_vien_xu_ly_id);
                }

                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đọc dữ liệu: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetComboById(ComboBox cbo, int? id)
        {
            if (!id.HasValue)
            {
                if (cbo.Items.Count > 0) cbo.SelectedIndex = 0;
                return;
            }

            for (int i = 0; i < cbo.Items.Count; i++)
            {
                dynamic item = cbo.Items[i];
                if (item.id != null && item.id == id.Value)
                {
                    cbo.SelectedIndex = i;
                    return;
                }
            }

            if (cbo.Items.Count > 0) cbo.SelectedIndex = 0;
        }


        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtMoTa.Text))
            {
                MessageBox.Show("Vui lòng nhập mô tả bảo trì.", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMoTa.Focus();
                return false;
            }

            if (cboTrangThai.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn trạng thái.", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtChiPhi.Text))
            {
                string raw = txtChiPhi.Text.Replace(",", "").Trim();
                if (!decimal.TryParse(raw, out _))
                {
                    MessageBox.Show("Chi phí không hợp lệ. Vui lòng nhập số.", "Cảnh báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtChiPhi.Focus();
                    return false;
                }
            }

            return true;
        }

        private void FormatChiPhi()
        {
            string raw = txtChiPhi.Text.Replace(",", "").Trim();
            if (string.IsNullOrEmpty(raw)) return;

            if (decimal.TryParse(raw, out decimal value))
                txtChiPhi.Text = value.ToString("#,##0");
        }

        private decimal? ParseChiPhi()
        {
            string raw = txtChiPhi.Text.Replace(",", "").Trim();
            if (string.IsNullOrEmpty(raw)) return null;
            if (decimal.TryParse(raw, out decimal val)) return val;
            return null;
        }

        private int? GetSelectedCanHoId()
        {
            if (cboCanHo.SelectedItem == null) return null;
            dynamic item = cboCanHo.SelectedItem;
            return item.id as int?;
        }

        private int? GetSelectedNhanVienId()
        {
            if (cboNhanVien.SelectedItem == null) return null;
            dynamic item = cboNhanVien.SelectedItem;
            return item.id as int?;
        }

        public void InsertBaoTri()
        {
            if (!ValidateInput()) return;

            try
            {
                int newId;
                using (var db = new DbChungCu())
                {
                    var bt = new bao_tri
                    {
                        mo_ta = txtMoTa.Text.Trim(),
                        ngay_yeu_cau = dtNgayBaoTri.Value,
                        ngay_hoan_thanh = chkNgayHoanThanh.Checked
                                                ? (DateTime?)dtNgayHoanThanh.Value
                                                : null,
                        chi_phi = ParseChiPhi(),
                        trang_thai = cboTrangThai.SelectedValue?.ToString(),
                        can_ho_id = GetSelectedCanHoId(),
                        nhan_vien_xu_ly_id = GetSelectedNhanVienId()
                    };

                    db.bao_tri.Add(bt);
                    db.SaveChanges();
                    newId = bt.id;
                }

                
                AuditLogHelper.GhiLog(
                    hanhDong: "THÊM",
                    bang: "bao_tri",
                    banGhiId: newId,
                    moTa: $"Thêm bảo trì #{newId}: {txtMoTa.Text.Trim()}"
                );
                

                MessageBox.Show("Thêm bảo trì thành công!", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearForm();
                LoadData();
                LoadThongKe();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm bảo trì: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateBaoTri()
        {
            if (_selectedId < 0)
            {
                MessageBox.Show("Vui lòng chọn bảo trì cần sửa.", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInput()) return;

            try
            {
                string trangThaiCu;
                using (var db = new DbChungCu())
                {
                    var bt = db.bao_tri.FirstOrDefault(x => x.id == _selectedId);
                    if (bt == null)
                    {
                        MessageBox.Show("Không tìm thấy bản ghi bảo trì.", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    trangThaiCu = bt.trang_thai;           

                    bt.mo_ta = txtMoTa.Text.Trim();
                    bt.ngay_yeu_cau = dtNgayBaoTri.Value;
                    bt.ngay_hoan_thanh = chkNgayHoanThanh.Checked
                                                ? (DateTime?)dtNgayHoanThanh.Value
                                                : null;
                    bt.chi_phi = ParseChiPhi();
                    bt.trang_thai = cboTrangThai.SelectedValue?.ToString();
                    bt.can_ho_id = GetSelectedCanHoId();
                    bt.nhan_vien_xu_ly_id = GetSelectedNhanVienId();

                    db.SaveChanges();
                }

                
                string trangThaiMoi = cboTrangThai.SelectedValue?.ToString();
                string moTaLog = $"Cập nhật bảo trì #{_selectedId}: {txtMoTa.Text.Trim()}";
                if (trangThaiCu != trangThaiMoi)
                    moTaLog += $" | Trạng thái: {trangThaiCu} → {trangThaiMoi}";

                AuditLogHelper.GhiLog(
                    hanhDong: "SỬA",
                    bang: "bao_tri",
                    banGhiId: _selectedId,
                    moTa: moTaLog
                );
                

                MessageBox.Show("Cập nhật bảo trì thành công!", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearForm();
                LoadData();
                LoadThongKe();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật bảo trì: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DeleteBaoTri()
        {
            if (_selectedId < 0)
            {
                MessageBox.Show("Vui lòng chọn bảo trì cần xóa.", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show(
                "Bạn có chắc muốn xóa bản ghi bảo trì này?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            try
            {
                string moTaXoa;
                using (var db = new DbChungCu())
                {
                    var bt = db.bao_tri.FirstOrDefault(x => x.id == _selectedId);
                    if (bt == null)
                    {
                        MessageBox.Show("Không tìm thấy bản ghi bảo trì.", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    moTaXoa = $"Xóa bảo trì #{bt.id}: {bt.mo_ta}";

                    db.bao_tri.Remove(bt);
                    db.SaveChanges();
                }

                AuditLogHelper.GhiLog(
                    hanhDong: "XÓA",
                    bang: "bao_tri",
                    banGhiId: _selectedId,
                    moTa: moTaXoa
                );

                MessageBox.Show("Xóa bảo trì thành công!", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearForm();
                LoadData();
                LoadThongKe();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa bảo trì: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SearchBaoTri()
        {
            try
            {
                string keyword = txtSearch.Text.Trim().ToLower();

                using (var db = new DbChungCu())
                {
                    var list = db.bao_tri
                        .Include("can_ho")
                        .Include("nguoi_dung")
                        .Where(x =>
                            x.mo_ta.ToLower().Contains(keyword) ||
                            x.trang_thai.ToLower().Contains(keyword) ||
                            (x.can_ho != null && x.can_ho.so_can_ho.ToLower().Contains(keyword)) ||
                            (x.nguoi_dung != null && x.nguoi_dung.ho_ten.ToLower().Contains(keyword)))
                        .OrderByDescending(x => x.ngay_yeu_cau)
                        .ToList();

                    BindGrid(list);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkNgayHoanThanh_CheckedChanged(object sender, EventArgs e)
        {
            dtNgayHoanThanh.Enabled = chkNgayHoanThanh.Checked;
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            frmBaoCaoVanHanh f = new frmBaoCaoVanHanh();
            f.ShowDialog();
        }
    }
}