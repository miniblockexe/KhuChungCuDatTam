using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.ComponentModel;
using KhuChungCuDatTam.Models;
using KhuChungCuDatTam.Helpers;

namespace KhuChungCuDatTam.UserControls
{
    public partial class ucNguoiDung : UserControl
    {
        private int _selectedId = -1;
        private string _anhDaiDienPath = string.Empty;

        public ucNguoiDung()
        {
            InitializeComponent();
        }

        private void ucNguoiDung_Load(object sender, EventArgs e)
        {
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;

            SetupDataGridView();
            LoadVaiTro();
            LoadCboTrangThai();
            LoadData();
            LoadThongKe();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchNguoiDung();
        }

        private void dgvNguoiDung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvNguoiDung.Rows[e.RowIndex];
            _selectedId = Convert.ToInt32(row.Cells["colId"].Value);
            txtTenDangNhap.Text = row.Cells["colTenDangNhap"].Value?.ToString();
            txtMatKhau.Text = row.Cells["colMatKhau"].Value?.ToString();
            txtHoTen.Text = row.Cells["colHoTen"].Value?.ToString();
            txtEmail.Text = row.Cells["colEmail"].Value?.ToString();
            txtSoDienThoai.Text = row.Cells["colSoDienThoai"].Value?.ToString();

            int vaiTroId = Convert.ToInt32(row.Cells["colVaiTroId"].Value);
            foreach (ComboBoxItem item in cboVaiTro.Items)
            {
                if (item.Value == vaiTroId)
                {
                    cboVaiTro.SelectedItem = item;
                    break;
                }
            }

            string trangThai = row.Cells["colTrangThai"].Value?.ToString();
            cboTrangThai.SelectedValue = trangThai;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            InsertNguoiDung();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            UpdateNguoiDung();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DeleteNguoiDung();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            ChooseImage();
        }


        private void LoadData()
        {
            try
            {
                using (var db = new DbChungCu())
                {
                    var list = db.nguoi_dung
                        .Include("vai_tro")
                        .ToList();

                    BindGrid(list);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BindGrid(List<nguoi_dung> list)
        {
            var data = list.Select(nd => new
            {
                id = nd.id,
                mat_khau = nd.mat_khau,
                vai_tro_id = nd.vai_tro_id,
                ten_dang_nhap = nd.ten_dang_nhap,
                ho_ten = nd.ho_ten,
                email = nd.email,
                so_dien_thoai = nd.so_dien_thoai,
                ten_vai_tro = nd.vai_tro?.ten_vai_tro ?? "",
                trang_thai = nd.trang_thai
            }).ToList();

            dgvNguoiDung.DataSource = null;
            dgvNguoiDung.DataSource = data;
        }

        private void LoadVaiTro()
        {
            try
            {
                using (var db = new DbChungCu())
                {
                    var list = db.vai_tro.ToList();
                    cboVaiTro.Items.Clear();
                    foreach (var vt in list)
                    {
                        cboVaiTro.Items.Add(new ComboBoxItem { Value = vt.id, Display = vt.ten_vai_tro });
                    }
                    if (cboVaiTro.Items.Count > 0)
                        cboVaiTro.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải vai trò: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCboTrangThai()
        {
            cboTrangThai.Items.Clear();
            cboTrangThai.DataSource = new List<ComboBoxItem>
            {
                new ComboBoxItem { Value = 0, Display = "Hoạt động", DbValue = "active"   },
                new ComboBoxItem { Value = 1, Display = "Bị khóa",   DbValue = "inactive" }
            };
            cboTrangThai.DisplayMember = "Display";
            cboTrangThai.ValueMember = "DbValue";
            cboTrangThai.SelectedIndex = 0;
        }

        private void LoadThongKe()
        {
            try
            {
                using (var db = new DbChungCu())
                {
                    int tong = db.nguoi_dung.Count();
                    int hoatDong = db.nguoi_dung.Count(n => n.trang_thai == "active");
                    int biKhoa = db.nguoi_dung.Count(n => n.trang_thai == "inactive");

                    lblTongNguoiDung.Text = tong.ToString();
                    lblDangHoatDong.Text = hoatDong.ToString();
                    lblBiKhoa.Text = biKhoa.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải thống kê: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChooseImage()
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Title = "Chọn ảnh đại diện";
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    _anhDaiDienPath = ofd.FileName;
                }
            }
        }

       

        private void ClearForm()
        {
            _selectedId = -1;
            _anhDaiDienPath = string.Empty;
            txtTenDangNhap.Text = string.Empty;
            txtMatKhau.Text = string.Empty;
            txtHoTen.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtSoDienThoai.Text = string.Empty;
            txtSearch.Text = string.Empty;
            if (cboVaiTro.Items.Count > 0) cboVaiTro.SelectedIndex = 0;
            if (cboTrangThai.Items.Count > 0) cboTrangThai.SelectedIndex = 0;
            dgvNguoiDung.ClearSelection();
        }

        private void InsertNguoiDung()
        {
            if (!ValidateInput()) return;

            try
            {
                using (var db = new DbChungCu())
                {
                    string tenDangNhap = txtTenDangNhap.Text.Trim();
                    bool trung = db.nguoi_dung.Any(n => n.ten_dang_nhap == tenDangNhap);
                    if (trung)
                    {
                        MessageBox.Show("Tên đăng nhập đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var nd = new nguoi_dung
                    {
                        ten_dang_nhap = tenDangNhap,
                        mat_khau = txtMatKhau.Text.Trim(),
                        ho_ten = txtHoTen.Text.Trim(),
                        email = txtEmail.Text.Trim(),
                        so_dien_thoai = txtSoDienThoai.Text.Trim(),
                        vai_tro_id = ((ComboBoxItem)cboVaiTro.SelectedItem).Value,
                        trang_thai = cboTrangThai.SelectedValue?.ToString(),
                        ngay_tao = DateTime.Now
                    };

                    db.nguoi_dung.Add(nd);
                    db.SaveChanges();
                    AuditLogHelper.GhiLog("THÊM", "nguoi_dung", nd.id,
    $"Thêm người dùng {nd.ten_dang_nhap} – {nd.ho_ten} – vai trò ID {nd.vai_tro_id} – {nd.trang_thai}");
                }

                MessageBox.Show("Thêm người dùng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadData();
                LoadThongKe();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm người dùng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateNguoiDung()
        {
            if (_selectedId < 0)
            {
                MessageBox.Show("Vui lòng chọn người dùng cần sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!ValidateInput()) return;

            try
            {
                using (var db = new DbChungCu())
                {
                    var nd = db.nguoi_dung.FirstOrDefault(n => n.id == _selectedId);
                    if (nd == null)
                    {
                        MessageBox.Show("Không tìm thấy người dùng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string tenDangNhap = txtTenDangNhap.Text.Trim();
                    bool trung = db.nguoi_dung.Any(n => n.ten_dang_nhap == tenDangNhap && n.id != _selectedId);
                    if (trung)
                    {
                        MessageBox.Show("Tên đăng nhập đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    nd.ten_dang_nhap = tenDangNhap;
                    nd.mat_khau = txtMatKhau.Text.Trim();
                    nd.ho_ten = txtHoTen.Text.Trim();
                    nd.email = txtEmail.Text.Trim();
                    nd.so_dien_thoai = txtSoDienThoai.Text.Trim();
                    nd.vai_tro_id = ((ComboBoxItem)cboVaiTro.SelectedItem).Value;
                    nd.trang_thai = cboTrangThai.SelectedValue?.ToString();

                    db.SaveChanges();
                    AuditLogHelper.GhiLog("SỬA", "nguoi_dung", _selectedId,
    $"Cập nhật người dùng {nd.ten_dang_nhap} – {nd.ho_ten} – vai trò ID {nd.vai_tro_id} – {nd.trang_thai}");
                }

                MessageBox.Show("Cập nhật người dùng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadData();
                LoadThongKe();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật người dùng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteNguoiDung()
        {
            if (_selectedId < 0)
            {
                MessageBox.Show("Vui lòng chọn người dùng cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Bạn có chắc muốn xóa người dùng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                using (var db = new DbChungCu())
                {
                    var nd = db.nguoi_dung.FirstOrDefault(n => n.id == _selectedId);
                    if (nd == null)
                    {
                        MessageBox.Show("Không tìm thấy người dùng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string logInfo = $"Xóa người dùng {nd.ten_dang_nhap} – {nd.ho_ten} – vai trò ID {nd.vai_tro_id}";
                    db.nguoi_dung.Remove(nd);
                    db.SaveChanges();
                    AuditLogHelper.GhiLog("XÓA", "nguoi_dung", _selectedId, logInfo);
                }

                MessageBox.Show("Xóa người dùng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadData();
                LoadThongKe();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa người dùng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchNguoiDung()
        {
            try
            {
                string keyword = txtSearch.Text.Trim().ToLower();

                using (var db = new DbChungCu())
                {
                    var list = db.nguoi_dung
                        .Include("vai_tro")
                        .Where(n =>
                            n.ten_dang_nhap.ToLower().Contains(keyword) ||
                            n.ho_ten.ToLower().Contains(keyword) ||
                            n.email.ToLower().Contains(keyword) ||
                            n.so_dien_thoai.ToLower().Contains(keyword)
                        )
                        .ToList();

                    BindGrid(list);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDangNhap.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Focus();
                return false;
            }
            if (cboVaiTro.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn vai trò!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cboTrangThai.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn trạng thái!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void SetupDataGridView()
        {
            dgvNguoiDung.AutoGenerateColumns = false;
            dgvNguoiDung.Columns.Clear();

            dgvNguoiDung.Columns.Add(new DataGridViewTextBoxColumn { Name = "colId", DataPropertyName = "id", Visible = false });
            dgvNguoiDung.Columns.Add(new DataGridViewTextBoxColumn { Name = "colMatKhau", DataPropertyName = "mat_khau", Visible = false });
            dgvNguoiDung.Columns.Add(new DataGridViewTextBoxColumn { Name = "colVaiTroId", DataPropertyName = "vai_tro_id", Visible = false });

            dgvNguoiDung.Columns.Add(new DataGridViewTextBoxColumn { Name = "colTenDangNhap", DataPropertyName = "ten_dang_nhap", HeaderText = "Tên Đăng Nhập", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, FillWeight = 20 });
            dgvNguoiDung.Columns.Add(new DataGridViewTextBoxColumn { Name = "colHoTen", DataPropertyName = "ho_ten", HeaderText = "Họ Tên", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, FillWeight = 25 });
            dgvNguoiDung.Columns.Add(new DataGridViewTextBoxColumn { Name = "colEmail", DataPropertyName = "email", HeaderText = "Email", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, FillWeight = 25 });
            dgvNguoiDung.Columns.Add(new DataGridViewTextBoxColumn { Name = "colSoDienThoai", DataPropertyName = "so_dien_thoai", HeaderText = "Số Điện Thoại", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, FillWeight = 15 });
            dgvNguoiDung.Columns.Add(new DataGridViewTextBoxColumn { Name = "colTenVaiTro", DataPropertyName = "ten_vai_tro", HeaderText = "Vai Trò", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, FillWeight = 15 });
            dgvNguoiDung.Columns.Add(new DataGridViewTextBoxColumn { Name = "colTrangThai", DataPropertyName = "trang_thai", HeaderText = "Trạng Thái", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, FillWeight = 15 });

            dgvNguoiDung.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 41, 59);
            dgvNguoiDung.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvNguoiDung.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
            dgvNguoiDung.EnableHeadersVisualStyles = false;
        }


        private class ComboBoxItem
        {
            public int Value { get; set; }
            public string Display { get; set; }
            public string DbValue { get; set; }
            public override string ToString() => Display;
        }
    }
}