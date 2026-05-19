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
    public partial class ucPhanQuyen : UserControl
    {
        private List<nguoi_dung> _danhSachNguoiDung = new List<nguoi_dung>();
        private List<vai_tro> _danhSachVaiTro = new List<vai_tro>();
        private List<quyen> _danhSachQuyen = new List<quyen>();
        private nguoi_dung _nguoiDungDangChon = null;

        public ucPhanQuyen()
        {
            InitializeComponent();
        }

        private void ucPhanQuyen_Load(object sender, EventArgs e)
        {
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;
            LoadData();
        }

        public void LoadData()
        {
            LoadNguoiDung();
            LoadVaiTro();
            LoadQuyen();
            LoadThongKe();
            LoadTreeView();
            HienThiDanhSach();
        }

        private void LoadNguoiDung()
        {
            try
            {
                using (var db = new DbChungCu())
                {
                    _danhSachNguoiDung = db.nguoi_dung
                        .Include("vai_tro")
                        .OrderBy(x => x.ho_ten)
                        .ToList();

                    cboNguoiDung.DataSource = null;
                    cboNguoiDung.DataSource = _danhSachNguoiDung
                        .Select(x => new { x.id, HienThi = $"{x.ho_ten} ({x.ten_dang_nhap})" })
                        .ToList();
                    cboNguoiDung.DisplayMember = "HienThi";
                    cboNguoiDung.ValueMember = "id";
                    cboNguoiDung.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải người dùng: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadVaiTro()
        {
            try
            {
                using (var db = new DbChungCu())
                {
                    _danhSachVaiTro = db.vai_tro
                        .Include("quyens")
                        .OrderBy(x => x.ten_vai_tro)
                        .ToList();

                    cboVaiTro.DataSource = null;
                    cboVaiTro.DataSource = _danhSachVaiTro
                        .Select(x => new { x.id, x.ten_vai_tro })
                        .ToList();
                    cboVaiTro.DisplayMember = "ten_vai_tro";
                    cboVaiTro.ValueMember = "id";
                    cboVaiTro.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải vai trò: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadQuyen()
        {
            try
            {
                using (var db = new DbChungCu())
                {
                    _danhSachQuyen = db.quyens
                        .Include("vai_tro")
                        .OrderBy(x => x.ten_quyen)
                        .ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải quyền: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadTreeView()
        {
            try
            {
                treeQuyen.Nodes.Clear();

                if (_danhSachVaiTro == null || _danhSachVaiTro.Count == 0) return;

                foreach (var vaiTro in _danhSachVaiTro)
                {
                    var nodeVaiTro = new TreeNode(vaiTro.ten_vai_tro);
                    nodeVaiTro.Tag = "vaitro_" + vaiTro.id;
                    nodeVaiTro.ForeColor = Color.FromArgb(59, 130, 246);

                    var quyenCuaVaiTro = _danhSachQuyen
                        .Where(q => q.vai_tro.Any(vt => vt.id == vaiTro.id))
                        .ToList();

                    foreach (var q in quyenCuaVaiTro)
                    {
                        var nodeQuyen = new TreeNode(q.ten_quyen);
                        nodeQuyen.Tag = "quyen_" + q.id;
                        nodeQuyen.ForeColor = Color.FromArgb(148, 163, 184);
                        nodeVaiTro.Nodes.Add(nodeQuyen);
                    }

                    nodeVaiTro.Checked = quyenCuaVaiTro.Count > 0;
                    treeQuyen.Nodes.Add(nodeVaiTro);
                }

                treeQuyen.ExpandAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải TreeView: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadThongKe()
        {
            try
            {
                using (var db = new DbChungCu())
                {
                    int tongND = db.nguoi_dung.Count();
                    int tongVT = db.vai_tro.Count();
                    int tongQ = db.quyens.Count();

                    lblTongNguoiDung.Text = tongND.ToString();
                    lblTongVaiTro.Text = tongVT.ToString();
                    lblTongQuyen.Text = tongQ.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải thống kê: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HienThiDanhSach(string tuKhoa = "")
        {
            try
            {
                var danhSach = _danhSachNguoiDung.AsEnumerable();

                if (!string.IsNullOrWhiteSpace(tuKhoa))
                {
                    string kw = tuKhoa.ToLower();
                    danhSach = danhSach.Where(x =>
                        (x.ho_ten != null && x.ho_ten.ToLower().Contains(kw)) ||
                        (x.ten_dang_nhap != null && x.ten_dang_nhap.ToLower().Contains(kw)) ||
                        (x.email != null && x.email.ToLower().Contains(kw)));
                }

                var data = danhSach.Select(x => new
                {
                    x.id,
                    HoTen = x.ho_ten ?? "",
                    TenDangNhap = x.ten_dang_nhap ?? "",
                    Email = x.email ?? "",
                    SoDienThoai = x.so_dien_thoai ?? "",
                    VaiTro = x.vai_tro != null ? x.vai_tro.ten_vai_tro : "Chưa gán",
                    TrangThai = x.trang_thai ?? ""
                }).ToList();

                dgvPhanQuyen.DataSource = null;
                dgvPhanQuyen.DataSource = data;

                if (dgvPhanQuyen.Columns.Count > 0)
                {
                    SetColumnHeaders();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi hiển thị danh sách: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetColumnHeaders()
        {
            var headers = new Dictionary<string, string>
            {
                { "id", "ID" },
                { "HoTen", "Họ Tên" },
                { "TenDangNhap", "Tên Đăng Nhập" },
                { "Email", "Email" },
                { "SoDienThoai", "Số Điện Thoại" },
                { "VaiTro", "Vai Trò" },
                { "TrangThai", "Trạng Thái" }
            };

            foreach (DataGridViewColumn col in dgvPhanQuyen.Columns)
            {
                if (headers.ContainsKey(col.Name))
                    col.HeaderText = headers[col.Name];
            }
        }

        public void SearchPhanQuyen()
        {
            HienThiDanhSach(txtSearch.Text);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchPhanQuyen();
        }

        private void dgvPhanQuyen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0) return;

                var row = dgvPhanQuyen.Rows[e.RowIndex];
                if (row.Cells["id"].Value == null) return;

                int id = Convert.ToInt32(row.Cells["id"].Value);
                _nguoiDungDangChon = _danhSachNguoiDung.FirstOrDefault(x => x.id == id);

                if (_nguoiDungDangChon == null) return;

                var nd = _danhSachNguoiDung.FirstOrDefault(x => x.id == id);
                if (nd != null)
                {
                    foreach (dynamic item in cboNguoiDung.Items)
                    {
                        if (item.id == nd.id)
                        {
                            cboNguoiDung.SelectedItem = item;
                            break;
                        }
                    }

                    foreach (dynamic item in cboVaiTro.Items)
                    {
                        if (item.id == nd.vai_tro_id)
                        {
                            cboVaiTro.SelectedItem = item;
                            break;
                        }
                    }

                    HighlightQuyenTheoVaiTro(nd.vai_tro_id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi chọn dòng: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HighlightQuyenTheoVaiTro(int vaiTroId)
        {
            foreach (TreeNode node in treeQuyen.Nodes)
            {
                string tag = node.Tag?.ToString() ?? "";
                bool isCurrentVaiTro = tag == "vaitro_" + vaiTroId;
                node.BackColor = isCurrentVaiTro
                    ? Color.FromArgb(59, 130, 246)
                    : Color.FromArgb(15, 23, 42);
                node.ForeColor = isCurrentVaiTro
                    ? Color.White
                    : Color.FromArgb(59, 130, 246);

                foreach (TreeNode child in node.Nodes)
                {
                    child.BackColor = isCurrentVaiTro
                        ? Color.FromArgb(30, 41, 59)
                        : Color.FromArgb(15, 23, 42);
                    child.ForeColor = Color.FromArgb(148, 163, 184);
                }
            }
        }

        public void SavePhanQuyen()
        {
            try
            {
                if (!ValidateForm()) return;

                int nguoiDungId = Convert.ToInt32(cboNguoiDung.SelectedValue);
                int vaiTroId = Convert.ToInt32(cboVaiTro.SelectedValue);

                using (var db = new DbChungCu())
                {
                    var nd = db.nguoi_dung.FirstOrDefault(x => x.id == nguoiDungId);
                    if (nd == null)
                    {
                        MessageBox.Show("Không tìm thấy người dùng!", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    nd.vai_tro_id = vaiTroId;
                    db.SaveChanges();
                    AuditLogHelper.GhiLog("SỬA", "nguoi_dung", nguoiDungId,
    $"Cập nhật phân quyền người dùng ID {nguoiDungId} → vai trò ID {vaiTroId}");
                }

                MessageBox.Show("Lưu phân quyền thành công!", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadData();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi lưu phân quyền: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateForm()
        {
            if (cboNguoiDung.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn người dùng!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboNguoiDung.Focus();
                return false;
            }

            if (cboVaiTro.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn vai trò!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboVaiTro.Focus();
                return false;
            }

            return true;
        }

        public void ClearForm()
        {
            cboNguoiDung.SelectedIndex = -1;
            cboVaiTro.SelectedIndex = -1;
            txtSearch.Clear();
            _nguoiDungDangChon = null;

            foreach (TreeNode node in treeQuyen.Nodes)
            {
                node.BackColor = Color.FromArgb(15, 23, 42);
                node.ForeColor = Color.FromArgb(59, 130, 246);
                foreach (TreeNode child in node.Nodes)
                {
                    child.BackColor = Color.FromArgb(15, 23, 42);
                    child.ForeColor = Color.FromArgb(148, 163, 184);
                }
            }

            HienThiDanhSach();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateForm()) return;

                int nguoiDungId = Convert.ToInt32(cboNguoiDung.SelectedValue);
                int vaiTroId = Convert.ToInt32(cboVaiTro.SelectedValue);

                using (var db = new DbChungCu())
                {
                    var nd = db.nguoi_dung.FirstOrDefault(x => x.id == nguoiDungId);
                    if (nd == null)
                    {
                        MessageBox.Show("Không tìm thấy người dùng!", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (nd.vai_tro_id == vaiTroId)
                    {
                        MessageBox.Show("Người dùng đã có vai trò này!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    nd.vai_tro_id = vaiTroId;
                    db.SaveChanges();
                }

                MessageBox.Show("Gán vai trò thành công!", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            SavePhanQuyen();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboNguoiDung.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn người dùng cần xóa quyền!", "Cảnh báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var confirm = MessageBox.Show(
                    "Bạn có chắc muốn xóa phân quyền của người dùng này?",
                    "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm != DialogResult.Yes) return;

                int nguoiDungId = Convert.ToInt32(cboNguoiDung.SelectedValue);

                using (var db = new DbChungCu())
                {
                    var nd = db.nguoi_dung.FirstOrDefault(x => x.id == nguoiDungId);
                    if (nd == null)
                    {
                        MessageBox.Show("Không tìm thấy người dùng!", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var vaiTroMacDinh = db.vai_tro.OrderBy(x => x.id).FirstOrDefault();
                    int vaiTroCuId = nd.vai_tro_id;
                    if (vaiTroMacDinh != null)
                        nd.vai_tro_id = vaiTroMacDinh.id;

                    db.SaveChanges();
                    AuditLogHelper.GhiLog("SỬA", "nguoi_dung", nguoiDungId,
    $"Đặt lại vai trò người dùng ID {nguoiDungId}: {vaiTroCuId} → {vaiTroMacDinh?.id}");
                }

                MessageBox.Show("Đã đặt lại vai trò mặc định!", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
            ClearForm();
        }

        private void btnLuuPhanQuyen_Click(object sender, EventArgs e)
        {
            SavePhanQuyen();
        }

        private void treeQuyen_AfterCheck(object sender, TreeViewEventArgs e)
        {
            try
            {
                if (e.Node == null) return;

                treeQuyen.AfterCheck -= treeQuyen_AfterCheck;

                foreach (TreeNode child in e.Node.Nodes)
                {
                    child.Checked = e.Node.Checked;
                }

                treeQuyen.AfterCheck += treeQuyen_AfterCheck;
            }
            catch { }
        }

        private void treeQuyen_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // Có thể mở rộng: xử lý khi chọn node
        }

        private void cboNguoiDung_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboNguoiDung.SelectedValue == null) return;
                if (!int.TryParse(cboNguoiDung.SelectedValue.ToString(), out int id)) return;

                var nd = _danhSachNguoiDung.FirstOrDefault(x => x.id == id);
                if (nd == null) return;

                foreach (dynamic item in cboVaiTro.Items)
                {
                    if (item.id == nd.vai_tro_id)
                    {
                        cboVaiTro.SelectedItem = item;
                        break;
                    }
                }

                HighlightQuyenTheoVaiTro(nd.vai_tro_id);
            }
            catch { }
        }

        private void cboVaiTro_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboVaiTro.SelectedValue == null) return;
                if (!int.TryParse(cboVaiTro.SelectedValue.ToString(), out int vaiTroId)) return;
                HighlightQuyenTheoVaiTro(vaiTroId);
            }
            catch { }
        }
    }
}