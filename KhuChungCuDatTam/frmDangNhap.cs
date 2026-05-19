using System;
using System.Windows.Forms;
using KhuChungCuDatTam.Helpers;
using KhuChungCuDatTam.Models;
using KhuChungCuDatTam.Repositories;

namespace KhuChungCuDatTam
{
    public partial class frmDangNhap : Form
    {
        private readonly NguoiDungRepository _nguoiDungRepo = new NguoiDungRepository();

        public frmDangNhap()
        {
            InitializeComponent();
            BoGocPanel();
        }

        private void BoGocPanel()
        {
            if (pnlCard != null)
            {
                pnlCard.Region = System.Drawing.Region.FromHrgn(
                    NativeMethods.CreateRoundRectRgn(
                        0, 0, pnlCard.Width, pnlCard.Height, 16, 16));
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            string loi = KiemTraKetNoiDB();
            if (loi != null)
            {
                HienThiLoi($"⚠ Không kết nối được Database: {loi}");
                btnDangNhap.Enabled = false;
            }

            txtTaiKhoan.Focus();
        }

        private static string KiemTraKetNoiDB()
        {
            try
            {
                using (var db = new DbChungCu())
                {
                    db.Database.Connection.Open();
                    db.Database.Connection.Close();
                }
                return null;        
            }
            catch (Exception ex)
            {
                return ex.Message;  
            }
        }

        private void frmDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ThucHienDangNhap();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
            => ThucHienDangNhap();

        private void chkHienMatKhau_CheckedChanged(object sender, EventArgs e)
            => txtMatKhau.PasswordChar = chkHienMatKhau.Checked ? '\0' : '●';

        private void lblQuenMatKhau_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Vui lòng liên hệ quản trị viên để đặt lại mật khẩu.\n\nHotline: 0800 123 456",
                "Quên mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lnkDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frm = new frmDangKy();
            frm.ShowDialog(this);
        }

        private void ThucHienDangNhap()
        {
            string tenDangNhap = txtTaiKhoan.Text.Trim();
            string matKhau = txtMatKhau.Text;

            if (string.IsNullOrEmpty(tenDangNhap))
            {
                HienThiLoi("Vui lòng nhập tên đăng nhập.");
                txtTaiKhoan.Focus();
                return;
            }
            if (string.IsNullOrEmpty(matKhau))
            {
                HienThiLoi("Vui lòng nhập mật khẩu.");
                txtMatKhau.Focus();
                return;
            }

            try
            {
                btnDangNhap.Enabled = false;
                btnDangNhap.Text = "Đang xử lý...";
                lblThongBaoLoi.Visible = false;

                var nguoiDung = _nguoiDungRepo.DangNhap(tenDangNhap, matKhau);

                if (nguoiDung == null)
                {
                    HienThiLoi("Tên đăng nhập hoặc mật khẩu không đúng.");
                    txtMatKhau.Clear();
                    txtMatKhau.Focus();
                    return;
                }

                SessionManager.BatDauPhien(nguoiDung);
                AuditLogHelper.CurrentUserId = nguoiDung.id;
                PermissionHelper.LoadQuyen(SessionManager.VaiTroId);
                MoFormChinh();
            }
            catch (Exception ex)
            {
                HienThiLoi($"Lỗi hệ thống: {ex.Message}");
            }
            finally
            {
                btnDangNhap.Enabled = true;
                btnDangNhap.Text = "ĐĂNG NHẬP";
            }
        }

        private void MoFormChinh()
        {
            var frm = new frmMain();
            frm.Show();
            this.Hide();

            frm.FormClosed += (s, args) =>
            {
                SessionManager.KetThucPhien();
                Application.Exit();
            };
        }

        private void HienThiLoi(string thongBao)
        {
            lblThongBaoLoi.Text = thongBao;
            lblThongBaoLoi.Visible = true;
        }

        private static class NativeMethods
        {
            [System.Runtime.InteropServices.DllImport("Gdi32.dll",
                EntryPoint = "CreateRoundRectRgn")]
            public static extern System.IntPtr CreateRoundRectRgn(
                int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
                int nWidthEllipse, int nHeightEllipse);
        }
    }
}