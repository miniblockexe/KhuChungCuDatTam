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
            public partial class ucThongBao : UserControl
            {
                private int _selectedId = -1;

                public ucThongBao()
                {
                    InitializeComponent();
                }

                private void ucThongBao_Load(object sender, EventArgs e)
                {
                    if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;

                    InitComboBoxData();
                    LoadData();
                    LoadThongKe();
                }

                private void txtSearch_TextChanged(object sender, EventArgs e)
                {
                    SearchThongBao();
                }

                private void dgvThongBao_CellClick(object sender, DataGridViewCellEventArgs e)
                {
                    if (e.RowIndex < 0) return;
                    FillFormFromGrid(e.RowIndex);
                }

                private void btnThem_Click(object sender, EventArgs e)
                {
                    InsertThongBao();
                }

                private void btnSua_Click(object sender, EventArgs e)
                {
                    UpdateThongBao();
                }

                private void btnXoa_Click(object sender, EventArgs e)
                {
                    DeleteThongBao();
                }

                private void btnLamMoi_Click(object sender, EventArgs e)
                {
                    ClearForm();
                    LoadData();
                }

                private void btnGuiThongBao_Click(object sender, EventArgs e)
                {
                    SendThongBao();
                }
                private void InitComboBoxData()
                {
                    // cboLoaiThongBao - dùng Value/Display
                    var loaiList = new[]
                    {
                        new { Value = "su_kien",   Display = "Sự kiện" },
                        new { Value = "bao_tri",   Display = "Bảo trì" },
                        new { Value = "khuyen_mai",Display = "Khuyến mãi" },
                        new { Value = "quy_dinh",  Display = "Quy định" },
                        new { Value = "khac",      Display = "Khác" }
                    };
                    cboLoaiThongBao.DataSource = loaiList;
                    cboLoaiThongBao.DisplayMember = "Display";
                    cboLoaiThongBao.ValueMember = "Value";
                    cboLoaiThongBao.SelectedIndex = 0;

                    cboDoiTuongGui.Items.Clear();
                    cboDoiTuongGui.Items.AddRange(new object[]
                    {
                        "Toàn bộ cư dân", "Theo tầng", "Theo căn hộ"
                    });
                    cboDoiTuongGui.SelectedIndex = 0;

                    cboTrangThai.Items.Clear();
                    cboTrangThai.Items.AddRange(new object[] { "Nháp", "Đã gửi" });
                    cboTrangThai.SelectedIndex = 0;
                }

                public void LoadData()
                {
                    try
                    {
                        using (var db = new DbChungCu())
                        {
                            var list = db.thong_bao
                                .OrderByDescending(x => x.ngay_gui)
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

                private void BindGrid(List<thong_bao> list)
                {
                    dgvThongBao.Rows.Clear();

                    foreach (var tb in list)
                    {
                        string doiTuong = tb.gui_tat_ca ? "Toàn bộ cư dân" : "Chọn lọc";
                        string trangThai = tb.gui_tat_ca ? "Đã gửi" : "Nháp"; 

                        int rowIdx = dgvThongBao.Rows.Add(
                            tb.id,
                            tb.tieu_de,
                            tb.loai,
                            doiTuong,
                            tb.ngay_gui.ToString("dd/MM/yyyy HH:mm"),
                            trangThai
                        );

                        if (trangThai == "Nháp")
                        {
                            dgvThongBao.Rows[rowIdx].DefaultCellStyle.ForeColor =
                                Color.FromArgb(148, 163, 184); // xám
                        }
                        else if (trangThai == "Đã gửi")
                        {
                            dgvThongBao.Rows[rowIdx].DefaultCellStyle.ForeColor =
                                Color.FromArgb(34, 197, 94); // xanh lá
                        }

                        if (tb.loai == "bao_tri")
                        {
                            dgvThongBao.Rows[rowIdx].DefaultCellStyle.ForeColor =
                                Color.FromArgb(239, 68, 68); // đỏ override
                            dgvThongBao.Rows[rowIdx].DefaultCellStyle.Font =
                                new Font(dgvThongBao.Font, FontStyle.Bold);
                        }
                    }
                }

                public void LoadThongKe()
                {
                    try
                    {
                        using (var db = new DbChungCu())
                        {
                            int tongTB = db.thong_bao.Count();
                            int daGui = db.thong_bao.Count(x => x.gui_tat_ca);
                            int nhap = tongTB - daGui;

                            int chuaDoc = db.thong_bao_cu_dan.Count(x => !x.da_doc);

                            lblTongThongBao.Text = tongTB.ToString();
                            lblDaGui.Text = daGui.ToString();
                            lblNhap.Text = nhap.ToString();
                            lblNhap.Tag = chuaDoc; 
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
                    txtTieuDe.Text = string.Empty;
                    txtNoiDung.Text = string.Empty;
                    txtSearch.Text = string.Empty;
                    dtNgayTao.Value = DateTime.Now;
                    cboLoaiThongBao.SelectedIndex = 0;
                    cboDoiTuongGui.SelectedIndex = 0;
                    cboTrangThai.SelectedIndex = 0;

                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    btnGuiThongBao.Enabled = false;
                }

                private void FillFormFromGrid(int rowIndex)
                {
                    try
                    {
                        var row = dgvThongBao.Rows[rowIndex];
                        if (row.Cells[0].Value == null) return;

                        _selectedId = Convert.ToInt32(row.Cells[0].Value);

                        bool daGui = false;

                        using (var db = new DbChungCu())
                        {
                            var tb = db.thong_bao.FirstOrDefault(x => x.id == _selectedId);
                            if (tb == null) return;

                            txtTieuDe.Text = tb.tieu_de;
                            txtNoiDung.Text = tb.noi_dung;
                            dtNgayTao.Value = tb.ngay_gui;

                            cboLoaiThongBao.SelectedValue = tb.loai;
                            cboDoiTuongGui.SelectedIndex = tb.gui_tat_ca ? 0 : 2;
                            cboTrangThai.SelectedIndex = tb.gui_tat_ca ? 1 : 0;

                            daGui = tb.gui_tat_ca;
                        }

                        btnGuiThongBao.Enabled = !daGui;
                        btnSua.Enabled = !daGui;
                        btnXoa.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi đọc dữ liệu: " + ex.Message, "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                private bool ValidateInput()
                {
                    if (string.IsNullOrWhiteSpace(txtTieuDe.Text))
                    {
                        MessageBox.Show("Vui lòng nhập tiêu đề thông báo.", "Cảnh báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtTieuDe.Focus();
                        return false;
                    }

                    if (string.IsNullOrWhiteSpace(txtNoiDung.Text))
                    {
                        MessageBox.Show("Vui lòng nhập nội dung thông báo.", "Cảnh báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtNoiDung.Focus();
                        return false;
                    }

                    if (cboLoaiThongBao.SelectedItem == null)
                    {
                        MessageBox.Show("Vui lòng chọn loại thông báo.", "Cảnh báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }

                    return true;
                }

                private bool GetGuiTatCa()
                {
                    return cboDoiTuongGui.SelectedIndex == 0;
                }

                private int GetDefaultNguoiGuiId()
                {
                    try
                    {
                        using (var db = new DbChungCu())
                        {
                            var nd = db.nguoi_dung.FirstOrDefault();
                            return nd != null ? nd.id : 1;
                        }
                    }
                    catch
                    {
                        return 1;
                    }
                }

                public void InsertThongBao()
                {
                    if (!ValidateInput()) return;

                    try
                    {
                        using (var db = new DbChungCu())
                        {
                            var tb = new thong_bao
                            {
                                tieu_de = txtTieuDe.Text.Trim(),
                                noi_dung = txtNoiDung.Text.Trim(),
                                ngay_gui = dtNgayTao.Value,
                                loai = cboLoaiThongBao.SelectedValue.ToString(),
                                gui_tat_ca = false,  
                                nguoi_gui_id = GetDefaultNguoiGuiId()
                            };

                            db.thong_bao.Add(tb);
                            db.SaveChanges();
                        }

                        MessageBox.Show("Thêm thông báo thành công!", "Thành công",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ClearForm();
                        LoadData();
                        LoadThongKe();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi thêm thông báo: " + ex.Message, "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                public void UpdateThongBao()
                {
                    if (_selectedId < 0)
                    {
                        MessageBox.Show("Vui lòng chọn thông báo cần sửa.", "Cảnh báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (!ValidateInput()) return;

                    try
                    {
                        using (var db = new DbChungCu())
                        {
                            var tb = db.thong_bao.FirstOrDefault(x => x.id == _selectedId);
                            if (tb == null)
                            {
                                MessageBox.Show("Không tìm thấy thông báo.", "Lỗi",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            tb.tieu_de = txtTieuDe.Text.Trim();
                            tb.noi_dung = txtNoiDung.Text.Trim();
                            tb.ngay_gui = dtNgayTao.Value;
                            tb.loai = cboLoaiThongBao.SelectedValue.ToString();
                            tb.gui_tat_ca = GetGuiTatCa();

                            db.SaveChanges();
                        AuditLogHelper.GhiLog("SỬA", "thong_bao", _selectedId,
        $"Cập nhật thông báo #{_selectedId}: {tb.tieu_de} – loại: {tb.loai} – gửi tất cả: {tb.gui_tat_ca}");
                    }

                        MessageBox.Show("Cập nhật thông báo thành công!", "Thành công",
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

                public void DeleteThongBao()
                {
                    if (_selectedId < 0)
                    {
                        MessageBox.Show("Vui lòng chọn thông báo cần xóa.", "Cảnh báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var confirm = MessageBox.Show("Bạn có chắc muốn xóa thông báo này?", "Xác nhận",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (confirm != DialogResult.Yes) return;

                    try
                    {
                        using (var db = new DbChungCu())
                        {
                            var tb = db.thong_bao.FirstOrDefault(x => x.id == _selectedId);
                            if (tb == null)
                            {
                                MessageBox.Show("Không tìm thấy thông báo.", "Lỗi",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        string logInfo = $"Xóa thông báo #{tb.id}: {tb.tieu_de} – loại: {tb.loai}";
                        db.Database.ExecuteSqlCommand(
                                 "DELETE FROM thong_bao_cu_dan WHERE thong_bao_id = @p0",
                                 _selectedId
                             );

                            db.thong_bao.Remove(tb);
                            db.SaveChanges();
                        AuditLogHelper.GhiLog("XÓA", "thong_bao", _selectedId, logInfo);
                    }

                        MessageBox.Show("Xóa thông báo thành công!", "Thành công",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ClearForm();
                        LoadData();
                        LoadThongKe();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa thông báo: " + ex.Message, "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                public void SearchThongBao()
                {
                    try
                    {
                        string keyword = txtSearch.Text.Trim().ToLower();

                        using (var db = new DbChungCu())
                        {
                            var list = db.thong_bao
                                .Where(x =>
                                    x.tieu_de.ToLower().Contains(keyword) ||
                                    x.noi_dung.ToLower().Contains(keyword) ||
                                    x.loai.ToLower().Contains(keyword))
                                .OrderByDescending(x => x.ngay_gui)
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

                // =====================================================================
                // SEND THÔNG BÁO
                // =====================================================================
                public void SendThongBao()
                {
                    if (_selectedId < 0)
                    {
                        MessageBox.Show("Vui lòng chọn thông báo cần gửi.", "Cảnh báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var confirm = MessageBox.Show("Xác nhận gửi thông báo này đến cư dân?", "Xác nhận gửi",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirm != DialogResult.Yes) return;

                    try
                    {
                        using (var db = new DbChungCu())
                        {
                            var tb = db.thong_bao.FirstOrDefault(x => x.id == _selectedId);
                            if (tb == null)
                            {
                                MessageBox.Show("Không tìm thấy thông báo.", "Lỗi",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            tb.gui_tat_ca = true;
                            tb.ngay_gui = DateTime.Now;
                            db.SaveChanges();
                        AuditLogHelper.GhiLog("GỬI", "thong_bao", _selectedId,
        $"Gửi thông báo #{_selectedId}: {tb.tieu_de} đến toàn bộ cư dân");

                        var dsCuDan = db.cu_dan.Select(c => c.id).ToList();

                            foreach (int cuDanId in dsCuDan)
                            {
                                db.Database.ExecuteSqlCommand(
                                    @"IF NOT EXISTS (
                                SELECT 1 FROM thong_bao_cu_dan 
                                WHERE thong_bao_id = @p0 AND cu_dan_id = @p1
                              )
                              INSERT INTO thong_bao_cu_dan (thong_bao_id, cu_dan_id, da_doc)
                              VALUES (@p0, @p1, 0)",
                                    _selectedId, cuDanId
                                );
                            }
                        }

                        MessageBox.Show("Gửi thông báo thành công!", "Thành công",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ClearForm();
                        LoadData();
                        LoadThongKe();
                    }
                    catch (Exception ex)
                    {
                        string msg = ex.Message;
                        var inner = ex.InnerException;
                        while (inner != null) { msg += "\n→ " + inner.Message; inner = inner.InnerException; }
                        MessageBox.Show("Lỗi gửi thông báo: " + msg, "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }