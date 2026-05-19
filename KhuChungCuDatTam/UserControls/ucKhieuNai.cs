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
    public partial class ucKhieuNai : UserControl
    {
        private int _selectedId = -1;

        public ucKhieuNai()
        {
            InitializeComponent();
        }


        private void ucKhieuNai_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;

            SetupDataGridView();
            SetupCboTrangThai();
            LoadCuDan();
            LoadNhanVien();
            LoadData();
            LoadThongKe();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchKhieuNai();
        }

        private void dgvKhieuNai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                var row = dgvKhieuNai.Rows[e.RowIndex];

                _selectedId = Convert.ToInt32(row.Cells["colId"].Value);

                int cuDanId = Convert.ToInt32(row.Cells["colCuDanId"].Value);
                cboCuDan.SelectedValue = cuDanId;

                txtMoTa.Text = row.Cells["colMoTa"].Value?.ToString();
                txtPhanHoi.Text = row.Cells["colPhanHoi"].Value?.ToString();

                object ngayGui = row.Cells["colNgayGuiRaw"].Value;
                if (ngayGui != null && ngayGui != DBNull.Value)
                    dtNgayGui.Value = Convert.ToDateTime(ngayGui);
                else
                    dtNgayGui.Value = DateTime.Now;

                cboTrangThai.SelectedValue = row.Cells["colTrangThai"].Value?.ToString();

                object nvId = row.Cells["colNhanVienId"].Value;
                if (nvId != null && nvId != DBNull.Value)
                    cboNhanVien.SelectedValue = Convert.ToInt32(nvId);
                else
                    cboNhanVien.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi chọn dòng: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SetupCboTrangThai()
        {
            var list = new[]
            {
                new { Value = "moi",        Display = "Mới" },
                new { Value = "dang_xu_ly", Display = "Đang xử lý" },
                new { Value = "da_xu_ly",   Display = "Đã xử lý" }
            };
            cboTrangThai.DataSource = list;
            cboTrangThai.DisplayMember = "Display";
            cboTrangThai.ValueMember = "Value";
            cboTrangThai.SelectedIndex = -1;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            InsertKhieuNai();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            UpdateKhieuNai();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DeleteKhieuNai();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearForm();
        }


        private void SetupDataGridView()
        {
            dgvKhieuNai.AutoGenerateColumns = false;
            dgvKhieuNai.Columns.Clear();

            dgvKhieuNai.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colId",
                DataPropertyName = "id",
                Visible = false
            });
            dgvKhieuNai.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colCuDanId",
                DataPropertyName = "cu_dan_id",
                Visible = false
            });
            dgvKhieuNai.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colNhanVienId",
                DataPropertyName = "nhan_vien_xu_ly_id",
                Visible = false
            });
            dgvKhieuNai.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colNgayGuiRaw",
                DataPropertyName = "ngay_gui_raw",
                Visible = false
            });
            dgvKhieuNai.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colPhanHoi",
                DataPropertyName = "phan_hoi",
                Visible = false
            });
            dgvKhieuNai.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colMoTa",
                DataPropertyName = "mo_ta",
                Visible = false
            });

            dgvKhieuNai.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colSTT",
                HeaderText = "STT",
                Width = 45,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            });
            dgvKhieuNai.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colHoTen",
                DataPropertyName = "ho_ten",
                HeaderText = "Cư Dân",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 22
            });
            dgvKhieuNai.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colMoTaHien",
                DataPropertyName = "mo_ta_hien",
                HeaderText = "Mô Tả",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 30
            });
            dgvKhieuNai.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colNgayGui",
                DataPropertyName = "ngay_gui_str",
                HeaderText = "Ngày Gửi",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 15
            });
            dgvKhieuNai.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colTrangThai",
                DataPropertyName = "trang_thai",
                HeaderText = "Trạng Thái",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 18
            });
            dgvKhieuNai.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colNhanVien",
                DataPropertyName = "ten_nhan_vien",
                HeaderText = "NV Xử Lý",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 20
            });

            dgvKhieuNai.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 41, 59);
            dgvKhieuNai.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvKhieuNai.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 9f, FontStyle.Bold);
            dgvKhieuNai.EnableHeadersVisualStyles = false;

            dgvKhieuNai.DefaultCellStyle.BackColor = Color.FromArgb(15, 23, 42);
            dgvKhieuNai.DefaultCellStyle.ForeColor = Color.White;
            dgvKhieuNai.DefaultCellStyle.SelectionBackColor = Color.FromArgb(59, 130, 246);
            dgvKhieuNai.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvKhieuNai.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(20, 30, 55);

            dgvKhieuNai.CellFormatting += DgvKhieuNai_CellFormatting;
        }

        private void DgvKhieuNai_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvKhieuNai.Rows[e.RowIndex];
            string trangThai = row.Cells["colTrangThai"].Value?.ToString();

            if (trangThai == "moi")
            {
                row.DefaultCellStyle.BackColor = Color.FromArgb(120, 60, 0);
                row.DefaultCellStyle.ForeColor = Color.FromArgb(253, 186, 116);
            }
        }


        public void LoadData()
        {
            try
            {
                using (var db = new DbChungCu())
                {
                    var list = db.khieu_nai
                        .Include("cu_dan")
                        .Include("nguoi_dung")
                        .ToList()
                        .Select(k => new
                        {
                            id = k.id,
                            cu_dan_id = k.cu_dan_id,
                            nhan_vien_xu_ly_id = k.nhan_vien_xu_ly_id,
                            ho_ten = k.cu_dan != null ? k.cu_dan.ho_ten : "(Không rõ)",
                            mo_ta = k.mo_ta,
                            mo_ta_hien = k.mo_ta != null && k.mo_ta.Length > 50
                                                    ? k.mo_ta.Substring(0, 50) + "..."
                                                    : k.mo_ta,
                            ngay_gui_raw = k.ngay_gui,
                            ngay_gui_str = k.ngay_gui.ToString("dd/MM/yyyy"),
                            trang_thai = k.trang_thai,
                            phan_hoi = k.phan_hoi,
                            ten_nhan_vien = k.nguoi_dung != null
                                                    ? k.nguoi_dung.ho_ten
                                                    : "(Chưa phân công)"
                        })
                        .ToList();

                    dgvKhieuNai.DataSource = null;
                    dgvKhieuNai.DataSource = list;

                    for (int i = 0; i < dgvKhieuNai.Rows.Count; i++)
                        dgvKhieuNai.Rows[i].Cells["colSTT"].Value = i + 1;

                    LoadThongKe();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadCuDan()
        {
            try
            {
                using (var db = new DbChungCu())
                {
                    var list = db.cu_dan
                        .Select(c => new { c.id, c.ho_ten })
                        .ToList();

                    cboCuDan.DataSource = null;
                    cboCuDan.DataSource = list;
                    cboCuDan.DisplayMember = "ho_ten";
                    cboCuDan.ValueMember = "id";
                    cboCuDan.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải cư dân: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadNhanVien()
        {
            try
            {
                using (var db = new DbChungCu())
                {
                    var list = db.nguoi_dung
                        .Where(n => n.trang_thai == "active")
                        .Select(n => new { n.id, n.ho_ten })
                        .ToList();

                    var displayList = new List<dynamic>();
                    displayList.Add(new { id = (int?)null, ho_ten = "(Chưa phân công)" });

                    var bindList = list.Select(n => new { id = (int?)n.id, ho_ten = n.ho_ten }).ToList();

                    cboNhanVien.DataSource = null;
                    cboNhanVien.DataSource = bindList;
                    cboNhanVien.DisplayMember = "ho_ten";
                    cboNhanVien.ValueMember = "id";
                    cboNhanVien.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải nhân viên: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadThongKe()
        {
            try
            {
                using (var db = new DbChungCu())
                {
                    var all = db.khieu_nai.ToList();

                    int tong = all.Count;
                    int dangXuLy = all.Count(k => k.trang_thai == "dang_xu_ly");
                    int hoànThanh = all.Count(k => k.trang_thai == "da_xu_ly");

                    lblTongKhieuNai.Text = tong.ToString();
                    lblDangXuLy.Text = dangXuLy.ToString();
                    lblDaHoanThanh.Text = hoànThanh.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải thống kê: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void InsertKhieuNai()
        {
            if (!ValidateForm()) return;

            try
            {
                using (var db = new DbChungCu())
                {
                    var kn = new khieu_nai
                    {
                        cu_dan_id = Convert.ToInt32(cboCuDan.SelectedValue),
                        mo_ta = txtMoTa.Text.Trim(),
                        ngay_gui = dtNgayGui.Value,
                        trang_thai = cboTrangThai.SelectedValue.ToString(),
                        phan_hoi = string.IsNullOrWhiteSpace(txtPhanHoi.Text)
                                                ? null : txtPhanHoi.Text.Trim(),
                        nhan_vien_xu_ly_id = cboNhanVien.SelectedValue == null
                                                ? (int?)null
                                                : Convert.ToInt32(cboNhanVien.SelectedValue)
                    };

                    db.khieu_nai.Add(kn);
                    db.SaveChanges();
                    AuditLogHelper.GhiLog("THÊM", "khieu_nai", kn.id,
    $"Thêm khiếu nại #{kn.id} – cư dân ID {kn.cu_dan_id} – {kn.trang_thai}");
                }

                MessageBox.Show("Thêm khiếu nại thành công!", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm khiếu nại: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateKhieuNai()
        {
            if (_selectedId < 0)
            {
                MessageBox.Show("Vui lòng chọn khiếu nại cần sửa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateForm()) return;

            try
            {
                using (var db = new DbChungCu())
                {
                    var kn = db.khieu_nai.FirstOrDefault(k => k.id == _selectedId);
                    if (kn == null)
                    {
                        MessageBox.Show("Không tìm thấy khiếu nại!", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    kn.cu_dan_id = Convert.ToInt32(cboCuDan.SelectedValue);
                    kn.mo_ta = txtMoTa.Text.Trim();
                    kn.ngay_gui = dtNgayGui.Value;
                    kn.trang_thai = cboTrangThai.SelectedValue.ToString();
                    kn.phan_hoi = string.IsNullOrWhiteSpace(txtPhanHoi.Text)
                                                ? null : txtPhanHoi.Text.Trim();
                    kn.nhan_vien_xu_ly_id = cboNhanVien.SelectedValue == null
                                                ? (int?)null
                                                : Convert.ToInt32(cboNhanVien.SelectedValue);

                    db.SaveChanges();
                    AuditLogHelper.GhiLog("SỬA", "khieu_nai", _selectedId,
    $"Cập nhật khiếu nại #{_selectedId} – trạng thái: {kn.trang_thai} – NV ID {kn.nhan_vien_xu_ly_id}");
                }

                MessageBox.Show("Cập nhật khiếu nại thành công!", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DeleteKhieuNai()
        {
            if (_selectedId < 0)
            {
                MessageBox.Show("Vui lòng chọn khiếu nại cần xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show(
                "Bạn có chắc muốn xóa khiếu nại này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                using (var db = new DbChungCu())
                {
                    var kn = db.khieu_nai.FirstOrDefault(k => k.id == _selectedId);
                    if (kn == null)
                    {
                        MessageBox.Show("Không tìm thấy khiếu nại!", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string logInfo = $"Xóa khiếu nại #{kn.id} – cư dân ID {kn.cu_dan_id} – {kn.trang_thai}";
                    db.khieu_nai.Remove(kn);
                    db.SaveChanges();
                    AuditLogHelper.GhiLog("XÓA", "khieu_nai", _selectedId, logInfo);
                }

                MessageBox.Show("Xóa khiếu nại thành công!", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa khiếu nại: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SearchKhieuNai()
        {
            try
            {
                string keyword = txtSearch.Text.Trim().ToLower();

                using (var db = new DbChungCu())
                {
                    var list = db.khieu_nai
                        .Include("cu_dan")
                        .Include("nguoi_dung")
                        .ToList()
                        .Where(k =>
                            (k.mo_ta != null && k.mo_ta.ToLower().Contains(keyword)) ||
                            (k.trang_thai != null && k.trang_thai.ToLower().Contains(keyword)) ||
                            (k.cu_dan != null && k.cu_dan.ho_ten != null &&
                             k.cu_dan.ho_ten.ToLower().Contains(keyword)) ||
                            (k.phan_hoi != null && k.phan_hoi.ToLower().Contains(keyword))
                        )
                        .Select(k => new
                        {
                            id = k.id,
                            cu_dan_id = k.cu_dan_id,
                            nhan_vien_xu_ly_id = k.nhan_vien_xu_ly_id,
                            ho_ten = k.cu_dan != null ? k.cu_dan.ho_ten : "(Không rõ)",
                            mo_ta = k.mo_ta,
                            mo_ta_hien = k.mo_ta != null && k.mo_ta.Length > 50
                                                    ? k.mo_ta.Substring(0, 50) + "..."
                                                    : k.mo_ta,
                            ngay_gui_raw = k.ngay_gui,
                            ngay_gui_str = k.ngay_gui.ToString("dd/MM/yyyy"),
                            trang_thai = k.trang_thai,
                            phan_hoi = k.phan_hoi,
                            ten_nhan_vien = k.nguoi_dung != null
                                                    ? k.nguoi_dung.ho_ten
                                                    : "(Chưa phân công)"
                        })
                        .ToList();

                    dgvKhieuNai.DataSource = null;
                    dgvKhieuNai.DataSource = list;

                    for (int i = 0; i < dgvKhieuNai.Rows.Count; i++)
                        dgvKhieuNai.Rows[i].Cells["colSTT"].Value = i + 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private bool ValidateForm()
        {
            if (cboCuDan.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn cư dân!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboCuDan.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtMoTa.Text))
            {
                MessageBox.Show("Vui lòng nhập mô tả khiếu nại!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMoTa.Focus();
                return false;
            }

            if (cboTrangThai.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn trạng thái!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboTrangThai.Focus();
                return false;
            }

            return true;
        }

        public void ClearForm()
        {
            _selectedId = -1;
            cboCuDan.SelectedIndex = -1;
            txtMoTa.Text = string.Empty;
            txtPhanHoi.Text = string.Empty;
            dtNgayGui.Value = DateTime.Now;
            cboTrangThai.SelectedIndex = -1;
            cboNhanVien.SelectedIndex = -1;
            txtSearch.Text = string.Empty;
            dgvKhieuNai.ClearSelection();
        }
    }
}