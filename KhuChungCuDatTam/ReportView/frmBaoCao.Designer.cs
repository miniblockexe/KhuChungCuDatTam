namespace KhuChungCuDatTam.Forms
{
    partial class frmBaoCao
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlCards;
        private System.Windows.Forms.Panel pnlToolbar;

        private System.Windows.Forms.Label lblThang;
        private System.Windows.Forms.ComboBox cboThang;
        private System.Windows.Forms.Label lblNam;
        private System.Windows.Forms.ComboBox cboNam;
        private System.Windows.Forms.Button btnXemBaoCao;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXuat;

        private System.Windows.Forms.Label lblDoanhThuVal;
        private System.Windows.Forms.Label lblCongNoVal;
        private System.Windows.Forms.Label lblBaoTriVal;
        private System.Windows.Forms.Label lblSoCanHoVal;
        private System.Windows.Forms.Label lblDaTTVal;
        private System.Windows.Forms.Label lblChuaTTVal;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlToolbar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblThang = new System.Windows.Forms.Label();
            this.cboThang = new System.Windows.Forms.ComboBox();
            this.lblNam = new System.Windows.Forms.Label();
            this.cboNam = new System.Windows.Forms.ComboBox();
            this.btnXemBaoCao = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXuat = new System.Windows.Forms.Button();
            this.pnlCards = new System.Windows.Forms.Panel();
            this.card1 = new System.Windows.Forms.Panel();
            this.bar1 = new System.Windows.Forms.Panel();
            this.lbl1T = new System.Windows.Forms.Label();
            this.lblDoanhThuVal = new System.Windows.Forms.Label();
            this.card2 = new System.Windows.Forms.Panel();
            this.bar2 = new System.Windows.Forms.Panel();
            this.lbl2T = new System.Windows.Forms.Label();
            this.lblCongNoVal = new System.Windows.Forms.Label();
            this.card3 = new System.Windows.Forms.Panel();
            this.bar3 = new System.Windows.Forms.Panel();
            this.lbl3T = new System.Windows.Forms.Label();
            this.lblBaoTriVal = new System.Windows.Forms.Label();
            this.card4 = new System.Windows.Forms.Panel();
            this.bar4 = new System.Windows.Forms.Panel();
            this.lbl4T = new System.Windows.Forms.Label();
            this.lblSoCanHoVal = new System.Windows.Forms.Label();
            this.card5 = new System.Windows.Forms.Panel();
            this.bar5 = new System.Windows.Forms.Panel();
            this.lbl5T = new System.Windows.Forms.Label();
            this.lblDaTTVal = new System.Windows.Forms.Label();
            this.card6 = new System.Windows.Forms.Panel();
            this.bar6 = new System.Windows.Forms.Panel();
            this.lbl6T = new System.Windows.Forms.Label();
            this.lblChuaTTVal = new System.Windows.Forms.Label();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pnlToolbar.SuspendLayout();
            this.pnlCards.SuspendLayout();
            this.card1.SuspendLayout();
            this.card2.SuspendLayout();
            this.card3.SuspendLayout();
            this.card4.SuspendLayout();
            this.card5.SuspendLayout();
            this.card6.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlToolbar
            // 
            this.pnlToolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.pnlToolbar.Controls.Add(this.lblTitle);
            this.pnlToolbar.Controls.Add(this.lblThang);
            this.pnlToolbar.Controls.Add(this.cboThang);
            this.pnlToolbar.Controls.Add(this.lblNam);
            this.pnlToolbar.Controls.Add(this.cboNam);
            this.pnlToolbar.Controls.Add(this.btnXemBaoCao);
            this.pnlToolbar.Controls.Add(this.btnLamMoi);
            this.pnlToolbar.Controls.Add(this.btnXuat);
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolbar.Location = new System.Drawing.Point(0, 88);
            this.pnlToolbar.Name = "pnlToolbar";
            this.pnlToolbar.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.pnlToolbar.Size = new System.Drawing.Size(1182, 52);
            this.pnlToolbar.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.lblTitle.Location = new System.Drawing.Point(12, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(228, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "📊  BÁO CÁO THỐNG KÊ";
            // 
            // lblThang
            // 
            this.lblThang.AutoSize = true;
            this.lblThang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblThang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblThang.Location = new System.Drawing.Point(246, 19);
            this.lblThang.Name = "lblThang";
            this.lblThang.Size = new System.Drawing.Size(53, 20);
            this.lblThang.TabIndex = 1;
            this.lblThang.Text = "Tháng:";
            // 
            // cboThang
            // 
            this.cboThang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.cboThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboThang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboThang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.cboThang.Location = new System.Drawing.Point(314, 13);
            this.cboThang.Name = "cboThang";
            this.cboThang.Size = new System.Drawing.Size(100, 28);
            this.cboThang.TabIndex = 2;
            // 
            // lblNam
            // 
            this.lblNam.AutoSize = true;
            this.lblNam.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblNam.Location = new System.Drawing.Point(420, 19);
            this.lblNam.Name = "lblNam";
            this.lblNam.Size = new System.Drawing.Size(44, 20);
            this.lblNam.TabIndex = 3;
            this.lblNam.Text = "Năm:";
            // 
            // cboNam
            // 
            this.cboNam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.cboNam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboNam.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboNam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.cboNam.Location = new System.Drawing.Point(470, 13);
            this.cboNam.Name = "cboNam";
            this.cboNam.Size = new System.Drawing.Size(80, 28);
            this.cboNam.TabIndex = 4;
            // 
            // btnXemBaoCao
            // 
            this.btnXemBaoCao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnXemBaoCao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXemBaoCao.FlatAppearance.BorderSize = 0;
            this.btnXemBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemBaoCao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXemBaoCao.ForeColor = System.Drawing.Color.White;
            this.btnXemBaoCao.Location = new System.Drawing.Point(569, 11);
            this.btnXemBaoCao.Name = "btnXemBaoCao";
            this.btnXemBaoCao.Size = new System.Drawing.Size(90, 30);
            this.btnXemBaoCao.TabIndex = 5;
            this.btnXemBaoCao.Text = "Thống kê";
            this.btnXemBaoCao.UseVisualStyleBackColor = false;
            this.btnXemBaoCao.Click += new System.EventHandler(this.btnXemBaoCao_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(676, 11);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(80, 30);
            this.btnLamMoi.TabIndex = 6;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXuat
            // 
            this.btnXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXuat.FlatAppearance.BorderSize = 0;
            this.btnXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXuat.ForeColor = System.Drawing.Color.White;
            this.btnXuat.Location = new System.Drawing.Point(768, 11);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(100, 30);
            this.btnXuat.TabIndex = 7;
            this.btnXuat.Text = "📥 Xuất CSV";
            this.btnXuat.UseVisualStyleBackColor = false;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // pnlCards
            // 
            this.pnlCards.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.pnlCards.Controls.Add(this.card1);
            this.pnlCards.Controls.Add(this.card2);
            this.pnlCards.Controls.Add(this.card3);
            this.pnlCards.Controls.Add(this.card4);
            this.pnlCards.Controls.Add(this.card5);
            this.pnlCards.Controls.Add(this.card6);
            this.pnlCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCards.Location = new System.Drawing.Point(0, 0);
            this.pnlCards.Name = "pnlCards";
            this.pnlCards.Padding = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.pnlCards.Size = new System.Drawing.Size(1182, 88);
            this.pnlCards.TabIndex = 1;
            // 
            // card1
            // 
            this.card1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.card1.Controls.Add(this.bar1);
            this.card1.Controls.Add(this.lbl1T);
            this.card1.Controls.Add(this.lblDoanhThuVal);
            this.card1.Location = new System.Drawing.Point(8, 8);
            this.card1.Name = "card1";
            this.card1.Size = new System.Drawing.Size(182, 68);
            this.card1.TabIndex = 0;
            // 
            // bar1
            // 
            this.bar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.bar1.Location = new System.Drawing.Point(0, 0);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(4, 68);
            this.bar1.TabIndex = 0;
            // 
            // lbl1T
            // 
            this.lbl1T.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lbl1T.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lbl1T.Location = new System.Drawing.Point(12, 10);
            this.lbl1T.Name = "lbl1T";
            this.lbl1T.Size = new System.Drawing.Size(166, 18);
            this.lbl1T.TabIndex = 1;
            this.lbl1T.Text = "DOANH THU";
            // 
            // lblDoanhThuVal
            // 
            this.lblDoanhThuVal.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblDoanhThuVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.lblDoanhThuVal.Location = new System.Drawing.Point(12, 28);
            this.lblDoanhThuVal.Name = "lblDoanhThuVal";
            this.lblDoanhThuVal.Size = new System.Drawing.Size(166, 28);
            this.lblDoanhThuVal.TabIndex = 2;
            this.lblDoanhThuVal.Text = "0 đ";
            // 
            // card2
            // 
            this.card2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.card2.Controls.Add(this.bar2);
            this.card2.Controls.Add(this.lbl2T);
            this.card2.Controls.Add(this.lblCongNoVal);
            this.card2.Location = new System.Drawing.Point(198, 8);
            this.card2.Name = "card2";
            this.card2.Size = new System.Drawing.Size(182, 68);
            this.card2.TabIndex = 1;
            // 
            // bar2
            // 
            this.bar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.bar2.Location = new System.Drawing.Point(0, 0);
            this.bar2.Name = "bar2";
            this.bar2.Size = new System.Drawing.Size(4, 68);
            this.bar2.TabIndex = 0;
            // 
            // lbl2T
            // 
            this.lbl2T.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lbl2T.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lbl2T.Location = new System.Drawing.Point(12, 10);
            this.lbl2T.Name = "lbl2T";
            this.lbl2T.Size = new System.Drawing.Size(166, 18);
            this.lbl2T.TabIndex = 1;
            this.lbl2T.Text = "TỔNG CÔNG NỢ";
            // 
            // lblCongNoVal
            // 
            this.lblCongNoVal.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblCongNoVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lblCongNoVal.Location = new System.Drawing.Point(12, 28);
            this.lblCongNoVal.Name = "lblCongNoVal";
            this.lblCongNoVal.Size = new System.Drawing.Size(166, 28);
            this.lblCongNoVal.TabIndex = 2;
            this.lblCongNoVal.Text = "0 đ";
            // 
            // card3
            // 
            this.card3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.card3.Controls.Add(this.bar3);
            this.card3.Controls.Add(this.lbl3T);
            this.card3.Controls.Add(this.lblBaoTriVal);
            this.card3.Location = new System.Drawing.Point(388, 8);
            this.card3.Name = "card3";
            this.card3.Size = new System.Drawing.Size(182, 68);
            this.card3.TabIndex = 2;
            // 
            // bar3
            // 
            this.bar3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.bar3.Location = new System.Drawing.Point(0, 0);
            this.bar3.Name = "bar3";
            this.bar3.Size = new System.Drawing.Size(4, 68);
            this.bar3.TabIndex = 0;
            // 
            // lbl3T
            // 
            this.lbl3T.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lbl3T.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lbl3T.Location = new System.Drawing.Point(12, 10);
            this.lbl3T.Name = "lbl3T";
            this.lbl3T.Size = new System.Drawing.Size(166, 18);
            this.lbl3T.TabIndex = 1;
            this.lbl3T.Text = "CHI PHÍ BẢO TRÌ";
            // 
            // lblBaoTriVal
            // 
            this.lblBaoTriVal.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblBaoTriVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.lblBaoTriVal.Location = new System.Drawing.Point(12, 28);
            this.lblBaoTriVal.Name = "lblBaoTriVal";
            this.lblBaoTriVal.Size = new System.Drawing.Size(166, 28);
            this.lblBaoTriVal.TabIndex = 2;
            this.lblBaoTriVal.Text = "0 đ";
            // 
            // card4
            // 
            this.card4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.card4.Controls.Add(this.bar4);
            this.card4.Controls.Add(this.lbl4T);
            this.card4.Controls.Add(this.lblSoCanHoVal);
            this.card4.Location = new System.Drawing.Point(578, 8);
            this.card4.Name = "card4";
            this.card4.Size = new System.Drawing.Size(182, 68);
            this.card4.TabIndex = 3;
            // 
            // bar4
            // 
            this.bar4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.bar4.Location = new System.Drawing.Point(0, 0);
            this.bar4.Name = "bar4";
            this.bar4.Size = new System.Drawing.Size(4, 68);
            this.bar4.TabIndex = 0;
            // 
            // lbl4T
            // 
            this.lbl4T.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lbl4T.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lbl4T.Location = new System.Drawing.Point(12, 10);
            this.lbl4T.Name = "lbl4T";
            this.lbl4T.Size = new System.Drawing.Size(166, 18);
            this.lbl4T.TabIndex = 1;
            this.lbl4T.Text = "SỐ CĂN HỘ";
            // 
            // lblSoCanHoVal
            // 
            this.lblSoCanHoVal.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblSoCanHoVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.lblSoCanHoVal.Location = new System.Drawing.Point(12, 28);
            this.lblSoCanHoVal.Name = "lblSoCanHoVal";
            this.lblSoCanHoVal.Size = new System.Drawing.Size(166, 28);
            this.lblSoCanHoVal.TabIndex = 2;
            this.lblSoCanHoVal.Text = "0";
            // 
            // card5
            // 
            this.card5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.card5.Controls.Add(this.bar5);
            this.card5.Controls.Add(this.lbl5T);
            this.card5.Controls.Add(this.lblDaTTVal);
            this.card5.Location = new System.Drawing.Point(768, 8);
            this.card5.Name = "card5";
            this.card5.Size = new System.Drawing.Size(182, 68);
            this.card5.TabIndex = 4;
            // 
            // bar5
            // 
            this.bar5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.bar5.Location = new System.Drawing.Point(0, 0);
            this.bar5.Name = "bar5";
            this.bar5.Size = new System.Drawing.Size(4, 68);
            this.bar5.TabIndex = 0;
            // 
            // lbl5T
            // 
            this.lbl5T.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lbl5T.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lbl5T.Location = new System.Drawing.Point(12, 10);
            this.lbl5T.Name = "lbl5T";
            this.lbl5T.Size = new System.Drawing.Size(166, 18);
            this.lbl5T.TabIndex = 1;
            this.lbl5T.Text = "ĐÃ THANH TOÁN";
            // 
            // lblDaTTVal
            // 
            this.lblDaTTVal.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblDaTTVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.lblDaTTVal.Location = new System.Drawing.Point(12, 28);
            this.lblDaTTVal.Name = "lblDaTTVal";
            this.lblDaTTVal.Size = new System.Drawing.Size(166, 28);
            this.lblDaTTVal.TabIndex = 2;
            this.lblDaTTVal.Text = "0";
            // 
            // card6
            // 
            this.card6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.card6.Controls.Add(this.bar6);
            this.card6.Controls.Add(this.lbl6T);
            this.card6.Controls.Add(this.lblChuaTTVal);
            this.card6.Location = new System.Drawing.Point(958, 8);
            this.card6.Name = "card6";
            this.card6.Size = new System.Drawing.Size(182, 68);
            this.card6.TabIndex = 5;
            // 
            // bar6
            // 
            this.bar6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.bar6.Location = new System.Drawing.Point(0, 0);
            this.bar6.Name = "bar6";
            this.bar6.Size = new System.Drawing.Size(4, 68);
            this.bar6.TabIndex = 0;
            // 
            // lbl6T
            // 
            this.lbl6T.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lbl6T.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lbl6T.Location = new System.Drawing.Point(12, 10);
            this.lbl6T.Name = "lbl6T";
            this.lbl6T.Size = new System.Drawing.Size(166, 18);
            this.lbl6T.TabIndex = 1;
            this.lbl6T.Text = "CHƯA THANH TOÁN";
            // 
            // lblChuaTTVal
            // 
            this.lblChuaTTVal.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblChuaTTVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lblChuaTTVal.Location = new System.Drawing.Point(12, 28);
            this.lblChuaTTVal.Name = "lblChuaTTVal";
            this.lblChuaTTVal.Size = new System.Drawing.Size(166, 28);
            this.lblChuaTTVal.TabIndex = 2;
            this.lblChuaTTVal.Text = "0";
            // 
            // reportViewer
            // 
            this.reportViewer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(1182, 703);
            this.reportViewer.TabIndex = 2;
            // 
            // frmBaoCao
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1182, 703);
            this.Controls.Add(this.reportViewer);   
            this.Controls.Add(this.pnlToolbar);   
            this.Controls.Add(this.pnlCards);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "frmBaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo Cáo Tài Chính";
            this.pnlToolbar.ResumeLayout(false);
            this.pnlToolbar.PerformLayout();
            this.pnlCards.ResumeLayout(false);
            this.card1.ResumeLayout(false);
            this.card2.ResumeLayout(false);
            this.card3.ResumeLayout(false);
            this.card4.ResumeLayout(false);
            this.card5.ResumeLayout(false);
            this.card6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel card1;
        private System.Windows.Forms.Panel bar1;
        private System.Windows.Forms.Label lbl1T;
        private System.Windows.Forms.Panel card2;
        private System.Windows.Forms.Panel bar2;
        private System.Windows.Forms.Label lbl2T;
        private System.Windows.Forms.Panel card3;
        private System.Windows.Forms.Panel bar3;
        private System.Windows.Forms.Label lbl3T;
        private System.Windows.Forms.Panel card4;
        private System.Windows.Forms.Panel bar4;
        private System.Windows.Forms.Label lbl4T;
        private System.Windows.Forms.Panel card5;
        private System.Windows.Forms.Panel bar5;
        private System.Windows.Forms.Label lbl5T;
        private System.Windows.Forms.Panel card6;
        private System.Windows.Forms.Panel bar6;
        private System.Windows.Forms.Label lbl6T;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
    }
}