using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using KhuChungCuDatTam.Data;
using KhuChungCuDatTam.Models;
using KhuChungCuDatTam.Repositories;

namespace KhuChungCuDatTam
{
    public partial class frmDangKy : Form
    {
        private readonly NguoiDungRepository _nguoiDungRepo = new NguoiDungRepository();
        private readonly VaiTroRepository _vaiTroRepo = new VaiTroRepository();

        private System.Windows.Forms.Timer _debounceTimer;

        public frmDangKy()
        {
            InitializeComponent();

        }
        private void SetLbl(Label lbl, string txt, int y)
        {
            lbl.Text = txt;
            lbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lbl.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            lbl.Location = new System.Drawing.Point(30, y);
            lbl.AutoSize = true;
        }

        private void SetTxt(TextBox tb, int y)
        {
            tb.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            tb.Location = new System.Drawing.Point(30, y);
            tb.Size = new System.Drawing.Size(440, 28);
            tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        }


        private void frmDangKy_Load(object sender, EventArgs e)
        {
            try
            {
                var vaiTros = _vaiTroRepo.LayVaiTroCongKhai();
                cboVaiTro.DataSource = vaiTros;
                cboVaiTro.DisplayMember = "mo_ta"; 
                cboVaiTro.ValueMember = "id";
                if (cboVaiTro.Items.Count > 0)
                    cboVaiTro.SelectedIndex = 0;
                foreach (vai_tro vt in cboVaiTro.Items)
                    if (vt.ten_vai_tro.Contains("Cư dân") || vt.ten_vai_tro.Contains("cu_dan"))
                    { cboVaiTro.SelectedItem = vt; break; }
            }
            catch (Exception ex)
            {
                HienThiLoi($"Không tải được vai trò: {ex.Message}");
            }

            _debounceTimer = new System.Windows.Forms.Timer { Interval = 600 };
            _debounceTimer.Tick += KiemTraTenDangNhap_Tick;
            SetLbl(this.lblHoTen, "Họ và tên *", 96);
            SetTxt(this.txtHoTen, 116);

            SetLbl(this.lblTaiKhoan, "Tên đăng nhập *", 158);
            SetTxt(this.txtTaiKhoan, 178);

            SetLbl(this.lblMatKhau, "Mật khẩu * (≥8 ký tự, hoa+thường+số+đặc biệt)", 228);
            SetTxt(this.txtMatKhau, 248);

            SetLbl(this.lblXacNhan, "Xác nhận mật khẩu *", 300);
            SetTxt(this.txtXacNhan, 320);

            SetLbl(this.lblEmail, "Email", 362);
            SetTxt(this.txtEmail, 382);

            SetLbl(this.lblSDT, "Số điện thoại", 424);
            SetTxt(this.txtSDT, 444);

            SetLbl(this.lblVaiTro, "Vai trò *", 486);
        }


        private void txtTaiKhoan_TextChanged(object sender, EventArgs e)
        {
            lblKiemTraTDN.Text = "Đang kiểm tra...";
            lblKiemTraTDN.ForeColor = System.Drawing.Color.Gray;
            _debounceTimer.Stop();
            _debounceTimer.Start();
        }

        private void KiemTraTenDangNhap_Tick(object sender, EventArgs e)
        {
            _debounceTimer.Stop();
            string tdn = txtTaiKhoan.Text.Trim();

            if (string.IsNullOrEmpty(tdn)) { lblKiemTraTDN.Text = ""; return; }

            if (!Regex.IsMatch(tdn, @"^[a-zA-Z0-9_]{4,50}$"))
            {
                lblKiemTraTDN.Text = "✗ Chỉ dùng chữ cái, số, _ (4-50 ký tự)";
                lblKiemTraTDN.ForeColor = System.Drawing.Color.Crimson;
                return;
            }

            try
            {
                if (_nguoiDungRepo.TonTaiTenDangNhap(tdn))
                {
                    lblKiemTraTDN.Text = "✗ Tên đăng nhập đã tồn tại";
                    lblKiemTraTDN.ForeColor = System.Drawing.Color.Crimson;
                }
                else
                {
                    lblKiemTraTDN.Text = "✓ Tên đăng nhập có thể dùng";
                    lblKiemTraTDN.ForeColor = System.Drawing.Color.Green;
                }
            }
            catch { lblKiemTraTDN.Text = ""; }
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            string mk = txtMatKhau.Text;
            if (string.IsNullOrEmpty(mk)) { lblDoManh.Text = ""; return; }

            var (isValid, thongBao) = HashHelper.KiemTraDoManhMatKhau(mk);
            if (isValid)
            {
                lblDoManh.Text = "✓ Mật khẩu đủ mạnh";
                lblDoManh.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblDoManh.Text = $"✗ {thongBao}";
                lblDoManh.ForeColor = System.Drawing.Color.OrangeRed;
            }
        }

        private void chkHienMK_CheckedChanged(object sender, EventArgs e)
        {
            char c = chkHienMK.Checked ? '\0' : '●';
            txtMatKhau.PasswordChar = c;
            txtXacNhan.PasswordChar = c;
        }

        private void btnHuy_Click(object sender, EventArgs e) => this.Close();

        private void btnDangKy_Click(object sender, EventArgs e)
            => ThucHienDangKy();

        private void ThucHienDangKy()
        {
            lblThongBaoLoi.Visible = false;

            string hoTen = txtHoTen.Text.Trim();
            string tdn = txtTaiKhoan.Text.Trim();
            string mk = txtMatKhau.Text;
            string xacNhan = txtXacNhan.Text;
            string email = txtEmail.Text.Trim();
            string sdt = txtSDT.Text.Trim();

            if (string.IsNullOrEmpty(hoTen))
            { HienThiLoi("Vui lòng nhập họ tên."); txtHoTen.Focus(); return; }

            if (string.IsNullOrEmpty(tdn))
            { HienThiLoi("Vui lòng nhập tên đăng nhập."); txtTaiKhoan.Focus(); return; }

            if (!Regex.IsMatch(tdn, @"^[a-zA-Z0-9_]{4,50}$"))
            { HienThiLoi("Tên đăng nhập chỉ dùng chữ cái, số, _ (4-50 ký tự)."); txtTaiKhoan.Focus(); return; }

            var (mkHopLe, mkThongBao) = HashHelper.KiemTraDoManhMatKhau(mk);
            if (!mkHopLe)
            { HienThiLoi(mkThongBao); txtMatKhau.Focus(); return; }

            if (mk != xacNhan)
            { HienThiLoi("Xác nhận mật khẩu không khớp."); txtXacNhan.Focus(); return; }

            if (!string.IsNullOrEmpty(email) && !Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            { HienThiLoi("Địa chỉ email không hợp lệ."); txtEmail.Focus(); return; }

            if (!string.IsNullOrEmpty(sdt) && !Regex.IsMatch(sdt, @"^0\d{8,9}$"))
            { HienThiLoi("Số điện thoại không hợp lệ (VD: 0901234567)."); txtSDT.Focus(); return; }

            if (cboVaiTro.SelectedItem == null)
            { HienThiLoi("Vui lòng chọn vai trò."); cboVaiTro.Focus(); return; }

            try
            {
                if (_nguoiDungRepo.TonTaiTenDangNhap(tdn))
                { HienThiLoi("Tên đăng nhập đã tồn tại. Vui lòng chọn tên khác."); txtTaiKhoan.Focus(); return; }

                if (!string.IsNullOrEmpty(email) && _nguoiDungRepo.TonTaiEmail(email))
                { HienThiLoi("Email này đã được đăng ký."); txtEmail.Focus(); return; }

                btnDangKy.Enabled = false;
                btnDangKy.Text = "Đang xử lý...";

                var vaiTro = (vai_tro)cboVaiTro.SelectedItem;
                var nguoiDung = new nguoi_dung
                {
                    ho_ten = hoTen,
                    ten_dang_nhap = tdn,
                    mat_khau = mk,  
                    email = string.IsNullOrEmpty(email) ? null : email,
                    so_dien_thoai = string.IsNullOrEmpty(sdt) ? null : sdt,
                    vai_tro_id = vaiTro.id
                };

                int newId = _nguoiDungRepo.DangKy(nguoiDung);
                if (newId > 0)
                {
                    MessageBox.Show(
                        $"✅ Đăng ký thành công!\n\nTài khoản: {tdn}\nVai trò: {vaiTro.ten_vai_tro}\n\nBạn có thể đăng nhập ngay.",
                        "Đăng ký thành công",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    HienThiLoi("Đăng ký thất bại. Vui lòng thử lại.");
                }
            }
            catch (Exception ex)
            {
                HienThiLoi($"Lỗi: {ex.Message}");
            }
            finally
            {
                btnDangKy.Enabled = true;
                btnDangKy.Text = "ĐĂNG KÝ";
            }
        }


        private void HienThiLoi(string thongBao)
        {
            lblThongBaoLoi.Text = thongBao;
            lblThongBaoLoi.Visible = true;
        }
    }
}