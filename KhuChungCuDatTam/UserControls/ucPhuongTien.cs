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
    public partial class ucPhuongTien : UserControl
    {
        private int _selectedId = -1;

        public ucPhuongTien()
        {
            InitializeComponent();
        }


        private void ucPhuongTien_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;

            cboLoaiXe.DataSource = new List<ComboItem>
    {
        new ComboItem { Text = "Xe máy",  Value = "xe_may" },
        new ComboItem { Text = "Ô tô",    Value = "o_to"   },
        new ComboItem { Text = "Xe đạp",  Value = "xe_dap" }
    };
            cboLoaiXe.DisplayMember = "Text";
            cboLoaiXe.ValueMember = "Value";
            cboLoaiXe.SelectedIndex = -1;

            cboTrangThai.DataSource = new List<ComboItem>
    {
        new ComboItem { Text = "Đang gửi",  Value = "dang_gui"  },
        new ComboItem { Text = "Ngừng gửi", Value = "ngung_gui" }
    };
            cboTrangThai.DisplayMember = "Text";
            cboTrangThai.ValueMember = "Value";
            cboTrangThai.SelectedIndex = -1;

            SetupDataGridView();
            LoadCuDan();
            LoadData();
            LoadThongKe();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchPhuongTien();
        }

        private void dgvPhuongTien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                var row = dgvPhuongTien.Rows[e.RowIndex];

                _selectedId = Convert.ToInt32(row.Cells["colId"].Value);

                int cuDanId = Convert.ToInt32(row.Cells["colCuDanId"].Value);
                cboCuDan.SelectedValue = cuDanId;

                txtBienSo.Text = row.Cells["colBienSo"].Value?.ToString();
                cboLoaiXe.SelectedValue = row.Cells["colLoaiXe"].Value?.ToString();
                cboTrangThai.SelectedValue = row.Cells["colTrangThai"].Value?.ToString();
                txtPhiGuiXe.Text = row.Cells["colPhiRaw"].Value?.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi chọn dòng: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            InsertPhuongTien();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            UpdatePhuongTien();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DeletePhuongTien();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void SetupDataGridView()
        {
            dgvPhuongTien.AutoGenerateColumns = false;
            dgvPhuongTien.Columns.Clear();

            dgvPhuongTien.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colId",
                DataPropertyName = "id",
                Visible = false
            });
            dgvPhuongTien.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colCuDanId",
                DataPropertyName = "cu_dan_id",
                Visible = false
            });
            dgvPhuongTien.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colPhiRaw",
                DataPropertyName = "phi_gui_thang",
                Visible = false
            });

            dgvPhuongTien.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colSTT",
                HeaderText = "STT",
                Width = 50,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            });
            dgvPhuongTien.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colHoTen",
                DataPropertyName = "ho_ten",
                HeaderText = "Cư Dân",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 30
            });
            dgvPhuongTien.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colBienSo",
                DataPropertyName = "bien_so",
                HeaderText = "Biển Số",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 20
            });
            dgvPhuongTien.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colLoaiXe",
                DataPropertyName = "loai_xe",
                HeaderText = "Loại Xe",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 20
            });
            dgvPhuongTien.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colPhiGui",
                DataPropertyName = "phi_gui_format",
                HeaderText = "Phí Gửi/Tháng",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 20
            });
            dgvPhuongTien.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colTrangThai",
                DataPropertyName = "trang_thai",
                HeaderText = "Trạng Thái",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 20
            });

            dgvPhuongTien.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 41, 59);
            dgvPhuongTien.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvPhuongTien.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
            dgvPhuongTien.EnableHeadersVisualStyles = false;
            dgvPhuongTien.DefaultCellStyle.BackColor = Color.FromArgb(15, 23, 42);
            dgvPhuongTien.DefaultCellStyle.ForeColor = Color.White;
            dgvPhuongTien.DefaultCellStyle.SelectionBackColor = Color.FromArgb(59, 130, 246);
            dgvPhuongTien.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvPhuongTien.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(20, 30, 55);
        }


        public void LoadData()
        {
            try
            {
                using (var db = new DbChungCu())
                {
                    var list = db.phuong_tien
                        .Include("cu_dan")
                        .ToList()
                        .Select(p => new
                        {
                            id = p.id,
                            cu_dan_id = p.cu_dan_id,
                            ho_ten = p.cu_dan != null ? p.cu_dan.ho_ten : "(Không rõ)",
                            bien_so = p.bien_so,
                            loai_xe = p.loai_xe,
                            phi_gui_thang = p.phi_gui_thang,
                            phi_gui_format = p.phi_gui_thang.ToString("N0") + " ₫",
                            trang_thai = p.trang_thai
                        })
                        .ToList();

                    dgvPhuongTien.DataSource = null;
                    dgvPhuongTien.DataSource = list;

                    for (int i = 0; i < dgvPhuongTien.Rows.Count; i++)
                        dgvPhuongTien.Rows[i].Cells["colSTT"].Value = i + 1;

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

        public void LoadThongKe()
        {
            try
            {
                using (var db = new DbChungCu())
                {
                    var all = db.phuong_tien.ToList();

                    int tongXe = all.Count;
                    int xeMay = all.Count(p => p.loai_xe == "xe_may");
                    int oTo = all.Count(p => p.loai_xe == "o_to");

                    lblTongXe.Text = tongXe.ToString();
                    lblXeMay.Text = xeMay.ToString();
                    lblOTo.Text = oTo.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải thống kê: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void InsertPhuongTien()
        {
            if (!ValidateForm()) return;

            try
            {
                using (var db = new DbChungCu())
                {
                    var pt = new phuong_tien
                    {
                        cu_dan_id = Convert.ToInt32(cboCuDan.SelectedValue),
                        bien_so = txtBienSo.Text.Trim().ToUpper(),
                        loai_xe = cboLoaiXe.SelectedValue.ToString(),
                        trang_thai = cboTrangThai.SelectedValue.ToString(),
                        phi_gui_thang = decimal.Parse(txtPhiGuiXe.Text.Trim()),
                    };

                    db.phuong_tien.Add(pt);
                    db.SaveChanges();
                    AuditLogHelper.GhiLog("THÊM", "phuong_tien", pt.id,
    $"Thêm phương tiện {pt.bien_so} – {pt.loai_xe} – cư dân ID {pt.cu_dan_id} – {pt.trang_thai}");
                }

                MessageBox.Show("Thêm phương tiện thành công!", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadData();
            }
            catch (Exception ex)
            {
                string msg = ex.Message;

                var inner = ex.InnerException;
                while (inner != null)
                {
                    msg += "\n→ " + inner.Message;
                    inner = inner.InnerException;
                }

                MessageBox.Show("Lỗi thêm phương tiện: " + msg, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdatePhuongTien()
        {
            if (_selectedId < 0)
            {
                MessageBox.Show("Vui lòng chọn phương tiện cần sửa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateForm()) return;

            try
            {
                using (var db = new DbChungCu())
                {
                    var pt = db.phuong_tien.FirstOrDefault(p => p.id == _selectedId);
                    if (pt == null)
                    {
                        MessageBox.Show("Không tìm thấy phương tiện!", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    pt.cu_dan_id = Convert.ToInt32(cboCuDan.SelectedValue);
                    pt.bien_so = txtBienSo.Text.Trim().ToUpper();
                    pt.loai_xe = cboLoaiXe.SelectedValue.ToString();     
                    pt.phi_gui_thang = decimal.Parse(txtPhiGuiXe.Text.Trim());
                    pt.trang_thai = cboTrangThai.SelectedValue.ToString(); 

                    db.SaveChanges();
                    AuditLogHelper.GhiLog("SỬA", "phuong_tien", _selectedId,
    $"Cập nhật phương tiện {pt.bien_so} – {pt.loai_xe} – {pt.phi_gui_thang:#,##0} đ – {pt.trang_thai}");
                }

                MessageBox.Show("Cập nhật phương tiện thành công!", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadData();
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                var inner = ex.InnerException;
                while (inner != null)
                {
                    msg += "\n→ " + inner.Message;
                    inner = inner.InnerException;
                }
                MessageBox.Show("Lỗi cập nhật: " + msg, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DeletePhuongTien()
        {
            if (_selectedId < 0)
            {
                MessageBox.Show("Vui lòng chọn phương tiện cần xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show(
                "Bạn có chắc muốn xóa phương tiện này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                using (var db = new DbChungCu())
                {
                    var pt = db.phuong_tien.FirstOrDefault(p => p.id == _selectedId);
                    if (pt == null)
                    {
                        MessageBox.Show("Không tìm thấy phương tiện!", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string logInfo = $"Xóa phương tiện {pt.bien_so} – {pt.loai_xe} – cư dân ID {pt.cu_dan_id}";
                    db.phuong_tien.Remove(pt);
                    db.SaveChanges();
                    AuditLogHelper.GhiLog("XÓA", "phuong_tien", _selectedId, logInfo);
                }

                MessageBox.Show("Xóa phương tiện thành công!", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa phương tiện: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SearchPhuongTien()
        {
            try
            {
                string keyword = txtSearch.Text.Trim().ToLower();

                using (var db = new DbChungCu())
                {
                    var list = db.phuong_tien
                        .Include("cu_dan")
                        .ToList()
                        .Where(p =>
                            (p.bien_so != null && p.bien_so.ToLower().Contains(keyword)) ||
                            (p.loai_xe != null && p.loai_xe.ToLower().Contains(keyword)) ||
                            (p.trang_thai != null && p.trang_thai.ToLower().Contains(keyword)) ||
                            (p.cu_dan != null && p.cu_dan.ho_ten != null &&
                             p.cu_dan.ho_ten.ToLower().Contains(keyword))
                        )
                        .Select(p => new
                        {
                            id = p.id,
                            cu_dan_id = p.cu_dan_id,
                            ho_ten = p.cu_dan != null ? p.cu_dan.ho_ten : "(Không rõ)",
                            bien_so = p.bien_so,
                            loai_xe = p.loai_xe,
                            phi_gui_thang = p.phi_gui_thang,
                            phi_gui_format = p.phi_gui_thang.ToString("N0") + " ₫",
                            trang_thai = p.trang_thai
                        })
                        .ToList();

                    dgvPhuongTien.DataSource = null;
                    dgvPhuongTien.DataSource = list;

                    for (int i = 0; i < dgvPhuongTien.Rows.Count; i++)
                        dgvPhuongTien.Rows[i].Cells["colSTT"].Value = i + 1;
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

            if (string.IsNullOrWhiteSpace(txtBienSo.Text))
            {
                MessageBox.Show("Vui lòng nhập biển số xe!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBienSo.Focus();
                return false;
            }

            if (cboLoaiXe.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn loại xe!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboLoaiXe.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPhiGuiXe.Text))
            {
                MessageBox.Show("Vui lòng nhập phí gửi xe!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhiGuiXe.Focus();
                return false;
            }

            decimal phi;
            if (!decimal.TryParse(txtPhiGuiXe.Text.Trim(), out phi) || phi < 0)
            {
                MessageBox.Show("Phí gửi xe không hợp lệ! Vui lòng nhập số dương.", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhiGuiXe.Focus();
                return false;
            }

            if (cboTrangThai.SelectedValue == null)
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
            txtBienSo.Text = string.Empty;
            cboLoaiXe.SelectedIndex = -1;
            txtPhiGuiXe.Text = string.Empty;
            cboTrangThai.SelectedIndex = -1;
            txtSearch.Text = string.Empty;
            dgvPhuongTien.ClearSelection();
        }
    }
    public class ComboItem
    {
        public string Text { get; set; }
        public string Value { get; set; }
        public override string ToString() => Text;
    }
}