namespace KhuChungCuDatTam
{
    partial class frmDangKy
    {
        private System.ComponentModel.IContainer components = null;

        // Controls
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblPhuDe;

        // Họ tên
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;

        // Tên đăng nhập
        private System.Windows.Forms.Label lblTaiKhoan;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Label lblKiemTraTDN;

        // Mật khẩu
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label lblDoManh;

        // Xác nhận mật khẩu
        private System.Windows.Forms.Label lblXacNhan;
        private System.Windows.Forms.TextBox txtXacNhan;

        // Email
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;

        // SĐT
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.TextBox txtSDT;

        // Vai trò
        private System.Windows.Forms.Label lblVaiTro;
        private System.Windows.Forms.ComboBox cboVaiTro;

        // Hiện mật khẩu
        private System.Windows.Forms.CheckBox chkHienMK;

        // Thông báo lỗi
        private System.Windows.Forms.Label lblThongBaoLoi;

        // Buttons
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnHuy;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblPhuDe = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblTaiKhoan = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.lblKiemTraTDN = new System.Windows.Forms.Label();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.lblDoManh = new System.Windows.Forms.Label();
            this.lblXacNhan = new System.Windows.Forms.Label();
            this.txtXacNhan = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblVaiTro = new System.Windows.Forms.Label();
            this.cboVaiTro = new System.Windows.Forms.ComboBox();
            this.chkHienMK = new System.Windows.Forms.CheckBox();
            this.lblThongBaoLoi = new System.Windows.Forms.Label();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();

            this.pnlMain.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();

            // ── Form ──────────────────────────────────────────
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 680);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đăng Ký Tài Khoản";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.pnlMain);

            // ── pnlMain ───────────────────────────────────────
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Padding = new System.Windows.Forms.Padding(30, 0, 30, 20);
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.AddRange(new System.Windows.Forms.Control[] {
                pnlHeader, lblHoTen, txtHoTen,
                lblTaiKhoan, txtTaiKhoan, lblKiemTraTDN,
                lblMatKhau, txtMatKhau, lblDoManh, chkHienMK,
                lblXacNhan, txtXacNhan,
                lblEmail, txtEmail,
                lblSDT, txtSDT,
                lblVaiTro, cboVaiTro,
                lblThongBaoLoi,
                btnDangKy, btnHuy
            });

            // ── pnlHeader ─────────────────────────────────────
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Size = new System.Drawing.Size(520, 80);
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(30, 60, 114);
            this.pnlHeader.Controls.Add(this.lblTieuDe);
            this.pnlHeader.Controls.Add(this.lblPhuDe);

            this.lblTieuDe.Text = "Đăng Ký Tài Khoản";
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.White;
            this.lblTieuDe.Location = new System.Drawing.Point(20, 12);
            this.lblTieuDe.AutoSize = true;

            this.lblPhuDe.Text = "Tạo tài khoản mới để truy cập hệ thống";
            this.lblPhuDe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPhuDe.ForeColor = System.Drawing.Color.FromArgb(180, 210, 240);
            this.lblPhuDe.Location = new System.Drawing.Point(22, 48);
            this.lblPhuDe.AutoSize = true;

         

            this.txtHoTen.MaxLength = 100;
         

            // ── Tên đăng nhập ───────────────
            this.txtTaiKhoan.MaxLength = 50;
      
            this.txtTaiKhoan.TextChanged += new System.EventHandler(this.txtTaiKhoan_TextChanged);

            this.lblKiemTraTDN.Text = "";
            this.lblKiemTraTDN.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblKiemTraTDN.Location = new System.Drawing.Point(30, 208);
            this.lblKiemTraTDN.Size = new System.Drawing.Size(440, 16);

            this.txtMatKhau.PasswordChar = '●';
            this.txtMatKhau.MaxLength = 255;
   
            this.txtMatKhau.TextChanged += new System.EventHandler(this.txtMatKhau_TextChanged);

            this.lblDoManh.Text = "";
            this.lblDoManh.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblDoManh.Location = new System.Drawing.Point(30, 278);
            this.lblDoManh.Size = new System.Drawing.Size(330, 16);

            this.chkHienMK.Text = "Hiện mật khẩu";
            this.chkHienMK.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.chkHienMK.ForeColor = System.Drawing.Color.Gray;
            this.chkHienMK.Location = new System.Drawing.Point(360, 278);
            this.chkHienMK.AutoSize = true;
            this.chkHienMK.CheckedChanged += new System.EventHandler(this.chkHienMK_CheckedChanged);

            // ── Xác nhận mật khẩu ───────
            this.txtXacNhan.PasswordChar = '●';
            this.txtXacNhan.MaxLength = 255;

            // ── Email ─────────────────────\
            this.txtEmail.MaxLength = 100;
        

            this.txtSDT.MaxLength = 20;
         

            this.cboVaiTro.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cboVaiTro.Location = new System.Drawing.Point(30, 506);
            this.cboVaiTro.Size = new System.Drawing.Size(440, 28);
            this.cboVaiTro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVaiTro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            // ── Thông báo lỗi ─────────────────────────────────
            this.lblThongBaoLoi.Text = "";
            this.lblThongBaoLoi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblThongBaoLoi.ForeColor = System.Drawing.Color.Crimson;
            this.lblThongBaoLoi.Location = new System.Drawing.Point(30, 544);
            this.lblThongBaoLoi.Size = new System.Drawing.Size(440, 20);
            this.lblThongBaoLoi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ── Buttons ───────────────────────────────────────
            this.btnDangKy.Text = "ĐĂNG KÝ";
            this.btnDangKy.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnDangKy.BackColor = System.Drawing.Color.FromArgb(34, 139, 34);
            this.btnDangKy.ForeColor = System.Drawing.Color.White;
            this.btnDangKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangKy.FlatAppearance.BorderSize = 0;
            this.btnDangKy.Location = new System.Drawing.Point(30, 572);
            this.btnDangKy.Size = new System.Drawing.Size(210, 44);
            this.btnDangKy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);

            this.btnHuy.Text = "HỦY";
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(200, 50, 50);
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.Location = new System.Drawing.Point(260, 572);
            this.btnHuy.Size = new System.Drawing.Size(210, 44);
            this.btnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);

            this.pnlMain.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);

            this.Load += new System.EventHandler(this.frmDangKy_Load);
        }
    }
}