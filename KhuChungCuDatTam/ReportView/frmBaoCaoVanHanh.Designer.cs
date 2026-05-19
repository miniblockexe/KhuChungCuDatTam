namespace KhuChungCuDatTam.ReportView
{
    partial class frmBaoCaoVanHanh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.pnlCards = new System.Windows.Forms.Panel();
            this.pnlToolbar = new System.Windows.Forms.Panel();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();

            this.lblTitle = new System.Windows.Forms.Label();
            this.lblThang = new System.Windows.Forms.Label();
            this.cboThang = new System.Windows.Forms.ComboBox();
            this.lblNam = new System.Windows.Forms.Label();
            this.cboNam = new System.Windows.Forms.ComboBox();
            this.btnXemBaoCao = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXuat = new System.Windows.Forms.Button();

            this.card1 = new System.Windows.Forms.Panel();
            this.bar1 = new System.Windows.Forms.Panel();
            this.lbl1T = new System.Windows.Forms.Label();
            this.lblCPBaoTriVal = new System.Windows.Forms.Label();

            this.card2 = new System.Windows.Forms.Panel();
            this.bar2 = new System.Windows.Forms.Panel();
            this.lbl2T = new System.Windows.Forms.Label();
            this.lblSoLanBTVal = new System.Windows.Forms.Label();

            this.card3 = new System.Windows.Forms.Panel();
            this.bar3 = new System.Windows.Forms.Panel();
            this.lbl3T = new System.Windows.Forms.Label();
            this.lblMoTaNhieuNhatVal = new System.Windows.Forms.Label();

            this.card4 = new System.Windows.Forms.Panel();
            this.bar4 = new System.Windows.Forms.Panel();
            this.lbl4T = new System.Windows.Forms.Label();
            this.lblTongKNVal = new System.Windows.Forms.Label();

            this.card5 = new System.Windows.Forms.Panel();
            this.bar5 = new System.Windows.Forms.Panel();
            this.lbl5T = new System.Windows.Forms.Label();
            this.lblDaXuLyVal = new System.Windows.Forms.Label();

            this.card6 = new System.Windows.Forms.Panel();
            this.bar6 = new System.Windows.Forms.Panel();
            this.lbl6T = new System.Windows.Forms.Label();
            this.lblChuaXuLyVal = new System.Windows.Forms.Label();

            this.card7 = new System.Windows.Forms.Panel();
            this.bar7 = new System.Windows.Forms.Panel();
            this.lbl7T = new System.Windows.Forms.Label();
            this.lblLoaiKNVal = new System.Windows.Forms.Label();

            this.card8 = new System.Windows.Forms.Panel();
            this.bar8 = new System.Windows.Forms.Panel();
            this.lbl8T = new System.Windows.Forms.Label();
            this.lblTyLeVal = new System.Windows.Forms.Label();

            this.pnlToolbar.SuspendLayout();
            this.pnlCards.SuspendLayout();
            this.card1.SuspendLayout();
            this.card2.SuspendLayout();
            this.card3.SuspendLayout();
            this.card4.SuspendLayout();
            this.card5.SuspendLayout();
            this.card6.SuspendLayout();
            this.card7.SuspendLayout();
            this.card8.SuspendLayout();
            this.SuspendLayout();

            System.Drawing.Color colBg = System.Drawing.Color.FromArgb(15, 23, 42);
            System.Drawing.Color colPanel = System.Drawing.Color.FromArgb(30, 41, 59);
            System.Drawing.Color colMuted = System.Drawing.Color.FromArgb(148, 163, 184);
            System.Drawing.Color colText = System.Drawing.Color.FromArgb(248, 250, 252);

            System.Drawing.Color colGreen = System.Drawing.Color.FromArgb(16, 185, 129);
            System.Drawing.Color colBlue = System.Drawing.Color.FromArgb(59, 130, 246);
            System.Drawing.Color colRed = System.Drawing.Color.FromArgb(239, 68, 68);
            System.Drawing.Color colAmber = System.Drawing.Color.FromArgb(245, 158, 11);
            System.Drawing.Color colPurple = System.Drawing.Color.FromArgb(139, 92, 246);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = colBg;
            this.ClientSize = new System.Drawing.Size(1182, 703);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(950, 650);
            this.Name = "frmBaoCaoVanHanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo Cáo Vận Hành";

            this.pnlToolbar.BackColor = colPanel;
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolbar.Location = new System.Drawing.Point(0, 0);
            this.pnlToolbar.Name = "pnlToolbar";
            this.pnlToolbar.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.pnlToolbar.Size = new System.Drawing.Size(1182, 58);
            this.pnlToolbar.TabIndex = 0;

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = colText;
            this.lblTitle.Location = new System.Drawing.Point(12, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(187, 21);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "BÁO CÁO VẬN HÀNH";

            this.lblThang.AutoSize = true;
            this.lblThang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblThang.ForeColor = colMuted;
            this.lblThang.Location = new System.Drawing.Point(300, 20);
            this.lblThang.Name = "lblThang";
            this.lblThang.Size = new System.Drawing.Size(42, 15);
            this.lblThang.TabIndex = 1;
            this.lblThang.Text = "Tháng:";

            this.cboThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboThang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboThang.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.cboThang.ForeColor = colText;
            this.cboThang.FormattingEnabled = true;
            this.cboThang.Location = new System.Drawing.Point(355, 16);
            this.cboThang.Name = "cboThang";
            this.cboThang.Size = new System.Drawing.Size(90, 23);
            this.cboThang.TabIndex = 2;

            this.lblNam.AutoSize = true;
            this.lblNam.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNam.ForeColor = colMuted;
            this.lblNam.Location = new System.Drawing.Point(460, 20);
            this.lblNam.Name = "lblNam";
            this.lblNam.Size = new System.Drawing.Size(34, 15);
            this.lblNam.TabIndex = 3;
            this.lblNam.Text = "Năm:";

            this.cboNam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboNam.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboNam.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.cboNam.ForeColor = colText;
            this.cboNam.FormattingEnabled = true;
            this.cboNam.Location = new System.Drawing.Point(505, 16);
            this.cboNam.Name = "cboNam";
            this.cboNam.Size = new System.Drawing.Size(90, 23);
            this.cboNam.TabIndex = 4;

            this.btnXemBaoCao.BackColor = colBlue;
            this.btnXemBaoCao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXemBaoCao.FlatAppearance.BorderSize = 0;
            this.btnXemBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemBaoCao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXemBaoCao.ForeColor = System.Drawing.Color.White;
            this.btnXemBaoCao.Location = new System.Drawing.Point(620, 14);
            this.btnXemBaoCao.Name = "btnXemBaoCao";
            this.btnXemBaoCao.Size = new System.Drawing.Size(110, 32);
            this.btnXemBaoCao.TabIndex = 5;
            this.btnXemBaoCao.Text = "Thống kê";
            this.btnXemBaoCao.UseVisualStyleBackColor = false;
            this.btnXemBaoCao.Click += new System.EventHandler(this.btnXemBaoCao_Click);

            this.btnLamMoi.BackColor = colMuted;
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(740, 14);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 32);
            this.btnLamMoi.TabIndex = 6;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);

            this.btnXuat.BackColor = colGreen;
            this.btnXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXuat.FlatAppearance.BorderSize = 0;
            this.btnXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXuat.ForeColor = System.Drawing.Color.White;
            this.btnXuat.Location = new System.Drawing.Point(850, 14);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(120, 32);
            this.btnXuat.TabIndex = 7;
            this.btnXuat.Text = "Xuất CSV";
            this.btnXuat.UseVisualStyleBackColor = false;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);

            this.pnlToolbar.Controls.Add(this.lblTitle);
            this.pnlToolbar.Controls.Add(this.lblThang);
            this.pnlToolbar.Controls.Add(this.cboThang);
            this.pnlToolbar.Controls.Add(this.lblNam);
            this.pnlToolbar.Controls.Add(this.cboNam);
            this.pnlToolbar.Controls.Add(this.btnXemBaoCao);
            this.pnlToolbar.Controls.Add(this.btnLamMoi);
            this.pnlToolbar.Controls.Add(this.btnXuat);

            this.pnlCards.BackColor = colBg;
            this.pnlCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCards.Location = new System.Drawing.Point(0, 58);
            this.pnlCards.Name = "pnlCards";
            this.pnlCards.Padding = new System.Windows.Forms.Padding(8);
            this.pnlCards.Size = new System.Drawing.Size(1182, 110);
            this.pnlCards.TabIndex = 1;

            this.card1.BackColor = colPanel;
            this.card1.Location = new System.Drawing.Point(8, 10);
            this.card1.Name = "card1";
            this.card1.Size = new System.Drawing.Size(120, 80);
            this.card1.TabIndex = 0;
            this.bar1.BackColor = colGreen;
            this.bar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bar1.Location = new System.Drawing.Point(0, 0);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(5, 80);
            this.bar1.TabIndex = 0;
            this.lbl1T.AutoSize = true;
            this.lbl1T.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lbl1T.ForeColor = colMuted;
            this.lbl1T.Location = new System.Drawing.Point(14, 10);
            this.lbl1T.Name = "lbl1T";
            this.lbl1T.Size = new System.Drawing.Size(76, 13);
            this.lbl1T.TabIndex = 1;
            this.lbl1T.Text = "TỔNG CHI PHÍ";
            this.lblCPBaoTriVal.AutoSize = false;
            this.lblCPBaoTriVal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCPBaoTriVal.ForeColor = colGreen;
            this.lblCPBaoTriVal.Location = new System.Drawing.Point(14, 34);
            this.lblCPBaoTriVal.Name = "lblCPBaoTriVal";
            this.lblCPBaoTriVal.Size = new System.Drawing.Size(100, 30);
            this.lblCPBaoTriVal.TabIndex = 2;
            this.lblCPBaoTriVal.Text = "0 đ";
            this.card1.Controls.Add(this.bar1);
            this.card1.Controls.Add(this.lbl1T);
            this.card1.Controls.Add(this.lblCPBaoTriVal);

            this.card2.BackColor = colPanel;
            this.card2.Location = new System.Drawing.Point(136, 10);
            this.card2.Name = "card2";
            this.card2.Size = new System.Drawing.Size(120, 80);
            this.card2.TabIndex = 1;
            this.bar2.BackColor = colBlue;
            this.bar2.Dock = System.Windows.Forms.DockStyle.Left;
            this.bar2.Location = new System.Drawing.Point(0, 0);
            this.bar2.Name = "bar2";
            this.bar2.Size = new System.Drawing.Size(5, 80);
            this.bar2.TabIndex = 0;
            this.lbl2T.AutoSize = true;
            this.lbl2T.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lbl2T.ForeColor = colMuted;
            this.lbl2T.Location = new System.Drawing.Point(14, 10);
            this.lbl2T.Name = "lbl2T";
            this.lbl2T.Size = new System.Drawing.Size(72, 13);
            this.lbl2T.TabIndex = 1;
            this.lbl2T.Text = "SỐ LẦN BT";
            this.lblSoLanBTVal.AutoSize = false;
            this.lblSoLanBTVal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSoLanBTVal.ForeColor = colBlue;
            this.lblSoLanBTVal.Location = new System.Drawing.Point(14, 34);
            this.lblSoLanBTVal.Name = "lblSoLanBTVal";
            this.lblSoLanBTVal.Size = new System.Drawing.Size(100, 30);
            this.lblSoLanBTVal.TabIndex = 2;
            this.lblSoLanBTVal.Text = "0";
            this.card2.Controls.Add(this.bar2);
            this.card2.Controls.Add(this.lbl2T);
            this.card2.Controls.Add(this.lblSoLanBTVal);

            this.card3.BackColor = colPanel;
            this.card3.Location = new System.Drawing.Point(264, 10);
            this.card3.Name = "card3";
            this.card3.Size = new System.Drawing.Size(150, 80);
            this.card3.TabIndex = 2;
            this.bar3.BackColor = colAmber;
            this.bar3.Dock = System.Windows.Forms.DockStyle.Left;
            this.bar3.Location = new System.Drawing.Point(0, 0);
            this.bar3.Name = "bar3";
            this.bar3.Size = new System.Drawing.Size(5, 80);
            this.bar3.TabIndex = 0;
            this.lbl3T.AutoSize = true;
            this.lbl3T.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lbl3T.ForeColor = colMuted;
            this.lbl3T.Location = new System.Drawing.Point(14, 10);
            this.lbl3T.Name = "lbl3T";
            this.lbl3T.Size = new System.Drawing.Size(82, 13);
            this.lbl3T.TabIndex = 1;
            this.lbl3T.Text = "BT PHỔ BIẾN";
            this.lblMoTaNhieuNhatVal.AutoSize = false;
            this.lblMoTaNhieuNhatVal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblMoTaNhieuNhatVal.ForeColor = colAmber;
            this.lblMoTaNhieuNhatVal.Location = new System.Drawing.Point(14, 34);
            this.lblMoTaNhieuNhatVal.Name = "lblMoTaNhieuNhatVal";
            this.lblMoTaNhieuNhatVal.Size = new System.Drawing.Size(126, 30);
            this.lblMoTaNhieuNhatVal.TabIndex = 2;
            this.lblMoTaNhieuNhatVal.Text = "---";
            this.card3.Controls.Add(this.bar3);
            this.card3.Controls.Add(this.lbl3T);
            this.card3.Controls.Add(this.lblMoTaNhieuNhatVal);

            this.card4.BackColor = colPanel;
            this.card4.Location = new System.Drawing.Point(422, 10);
            this.card4.Name = "card4";
            this.card4.Size = new System.Drawing.Size(120, 80);
            this.card4.TabIndex = 3;
            this.bar4.BackColor = colRed;
            this.bar4.Dock = System.Windows.Forms.DockStyle.Left;
            this.bar4.Location = new System.Drawing.Point(0, 0);
            this.bar4.Name = "bar4";
            this.bar4.Size = new System.Drawing.Size(5, 80);
            this.bar4.TabIndex = 0;
            this.lbl4T.AutoSize = true;
            this.lbl4T.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lbl4T.ForeColor = colMuted;
            this.lbl4T.Location = new System.Drawing.Point(14, 10);
            this.lbl4T.Name = "lbl4T";
            this.lbl4T.Size = new System.Drawing.Size(58, 13);
            this.lbl4T.TabIndex = 1;
            this.lbl4T.Text = "KHIẾU NẠI";
            this.lblTongKNVal.AutoSize = false;
            this.lblTongKNVal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTongKNVal.ForeColor = colRed;
            this.lblTongKNVal.Location = new System.Drawing.Point(14, 34);
            this.lblTongKNVal.Name = "lblTongKNVal";
            this.lblTongKNVal.Size = new System.Drawing.Size(100, 30);
            this.lblTongKNVal.TabIndex = 2;
            this.lblTongKNVal.Text = "0";
            this.card4.Controls.Add(this.bar4);
            this.card4.Controls.Add(this.lbl4T);
            this.card4.Controls.Add(this.lblTongKNVal);

            this.card5.BackColor = colPanel;
            this.card5.Location = new System.Drawing.Point(550, 10);
            this.card5.Name = "card5";
            this.card5.Size = new System.Drawing.Size(120, 80);
            this.card5.TabIndex = 4;
            this.bar5.BackColor = colGreen;
            this.bar5.Dock = System.Windows.Forms.DockStyle.Left;
            this.bar5.Location = new System.Drawing.Point(0, 0);
            this.bar5.Name = "bar5";
            this.bar5.Size = new System.Drawing.Size(5, 80);
            this.bar5.TabIndex = 0;
            this.lbl5T.AutoSize = true;
            this.lbl5T.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lbl5T.ForeColor = colMuted;
            this.lbl5T.Location = new System.Drawing.Point(14, 10);
            this.lbl5T.Name = "lbl5T";
            this.lbl5T.Size = new System.Drawing.Size(58, 13);
            this.lbl5T.TabIndex = 1;
            this.lbl5T.Text = "ĐÃ XỬ LÝ";
            this.lblDaXuLyVal.AutoSize = false;
            this.lblDaXuLyVal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblDaXuLyVal.ForeColor = colGreen;
            this.lblDaXuLyVal.Location = new System.Drawing.Point(14, 34);
            this.lblDaXuLyVal.Name = "lblDaXuLyVal";
            this.lblDaXuLyVal.Size = new System.Drawing.Size(100, 30);
            this.lblDaXuLyVal.TabIndex = 2;
            this.lblDaXuLyVal.Text = "0";
            this.card5.Controls.Add(this.bar5);
            this.card5.Controls.Add(this.lbl5T);
            this.card5.Controls.Add(this.lblDaXuLyVal);

            this.card6.BackColor = colPanel;
            this.card6.Location = new System.Drawing.Point(678, 10);
            this.card6.Name = "card6";
            this.card6.Size = new System.Drawing.Size(120, 80);
            this.card6.TabIndex = 5;
            this.bar6.BackColor = colRed;
            this.bar6.Dock = System.Windows.Forms.DockStyle.Left;
            this.bar6.Location = new System.Drawing.Point(0, 0);
            this.bar6.Name = "bar6";
            this.bar6.Size = new System.Drawing.Size(5, 80);
            this.bar6.TabIndex = 0;
            this.lbl6T.AutoSize = true;
            this.lbl6T.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lbl6T.ForeColor = colMuted;
            this.lbl6T.Location = new System.Drawing.Point(14, 10);
            this.lbl6T.Name = "lbl6T";
            this.lbl6T.Size = new System.Drawing.Size(51, 13);
            this.lbl6T.TabIndex = 1;
            this.lbl6T.Text = "CHƯA XL";
            this.lblChuaXuLyVal.AutoSize = false;
            this.lblChuaXuLyVal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblChuaXuLyVal.ForeColor = colRed;
            this.lblChuaXuLyVal.Location = new System.Drawing.Point(14, 34);
            this.lblChuaXuLyVal.Name = "lblChuaXuLyVal";
            this.lblChuaXuLyVal.Size = new System.Drawing.Size(100, 30);
            this.lblChuaXuLyVal.TabIndex = 2;
            this.lblChuaXuLyVal.Text = "0";
            this.card6.Controls.Add(this.bar6);
            this.card6.Controls.Add(this.lbl6T);
            this.card6.Controls.Add(this.lblChuaXuLyVal);

            this.card7.BackColor = colPanel;
            this.card7.Location = new System.Drawing.Point(806, 10);
            this.card7.Name = "card7";
            this.card7.Size = new System.Drawing.Size(150, 80);
            this.card7.TabIndex = 6;
            this.bar7.BackColor = colAmber;
            this.bar7.Dock = System.Windows.Forms.DockStyle.Left;
            this.bar7.Location = new System.Drawing.Point(0, 0);
            this.bar7.Name = "bar7";
            this.bar7.Size = new System.Drawing.Size(5, 80);
            this.bar7.TabIndex = 0;
            this.lbl7T.AutoSize = true;
            this.lbl7T.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lbl7T.ForeColor = colMuted;
            this.lbl7T.Location = new System.Drawing.Point(14, 10);
            this.lbl7T.Name = "lbl7T";
            this.lbl7T.Size = new System.Drawing.Size(81, 13);
            this.lbl7T.TabIndex = 1;
            this.lbl7T.Text = "KN PHỔ BIẾN";
            this.lblLoaiKNVal.AutoSize = false;
            this.lblLoaiKNVal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblLoaiKNVal.ForeColor = colAmber;
            this.lblLoaiKNVal.Location = new System.Drawing.Point(14, 34);
            this.lblLoaiKNVal.Name = "lblLoaiKNVal";
            this.lblLoaiKNVal.Size = new System.Drawing.Size(126, 30);
            this.lblLoaiKNVal.TabIndex = 2;
            this.lblLoaiKNVal.Text = "---";
            this.card7.Controls.Add(this.bar7);
            this.card7.Controls.Add(this.lbl7T);
            this.card7.Controls.Add(this.lblLoaiKNVal);

            this.card8.BackColor = colPanel;
            this.card8.Location = new System.Drawing.Point(964, 10);
            this.card8.Name = "card8";
            this.card8.Size = new System.Drawing.Size(120, 80);
            this.card8.TabIndex = 7;
            this.bar8.BackColor = colPurple;
            this.bar8.Dock = System.Windows.Forms.DockStyle.Left;
            this.bar8.Location = new System.Drawing.Point(0, 0);
            this.bar8.Name = "bar8";
            this.bar8.Size = new System.Drawing.Size(5, 80);
            this.bar8.TabIndex = 0;
            this.lbl8T.AutoSize = true;
            this.lbl8T.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lbl8T.ForeColor = colMuted;
            this.lbl8T.Location = new System.Drawing.Point(14, 10);
            this.lbl8T.Name = "lbl8T";
            this.lbl8T.Size = new System.Drawing.Size(72, 13);
            this.lbl8T.TabIndex = 1;
            this.lbl8T.Text = "TỶ LỆ GQ";
            this.lblTyLeVal.AutoSize = false;
            this.lblTyLeVal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTyLeVal.ForeColor = colPurple;
            this.lblTyLeVal.Location = new System.Drawing.Point(14, 34);
            this.lblTyLeVal.Name = "lblTyLeVal";
            this.lblTyLeVal.Size = new System.Drawing.Size(100, 30);
            this.lblTyLeVal.TabIndex = 2;
            this.lblTyLeVal.Text = "0%";
            this.card8.Controls.Add(this.bar8);
            this.card8.Controls.Add(this.lbl8T);
            this.card8.Controls.Add(this.lblTyLeVal);

            this.pnlCards.Controls.Add(this.card1);
            this.pnlCards.Controls.Add(this.card2);
            this.pnlCards.Controls.Add(this.card3);
            this.pnlCards.Controls.Add(this.card4);
            this.pnlCards.Controls.Add(this.card5);
            this.pnlCards.Controls.Add(this.card6);
            this.pnlCards.Controls.Add(this.card7);
            this.pnlCards.Controls.Add(this.card8);

            this.reportViewer.BackColor = colBg;
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer.Location = new System.Drawing.Point(0, 168);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;
            this.reportViewer.Size = new System.Drawing.Size(1182, 535);
            this.reportViewer.TabIndex = 2;

            this.Controls.Add(this.reportViewer);
            this.Controls.Add(this.pnlCards);
            this.Controls.Add(this.pnlToolbar);

            this.card8.ResumeLayout(false);
            this.card8.PerformLayout();
            this.card7.ResumeLayout(false);
            this.card7.PerformLayout();
            this.card6.ResumeLayout(false);
            this.card6.PerformLayout();
            this.card5.ResumeLayout(false);
            this.card5.PerformLayout();
            this.card4.ResumeLayout(false);
            this.card4.PerformLayout();
            this.card3.ResumeLayout(false);
            this.card3.PerformLayout();
            this.card2.ResumeLayout(false);
            this.card2.PerformLayout();
            this.card1.ResumeLayout(false);
            this.card1.PerformLayout();
            this.pnlCards.ResumeLayout(false);
            this.pnlToolbar.ResumeLayout(false);
            this.pnlToolbar.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlCards;
        private System.Windows.Forms.Panel pnlToolbar;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblThang;
        private System.Windows.Forms.Label lblNam;

        private System.Windows.Forms.ComboBox cboThang;
        private System.Windows.Forms.ComboBox cboNam;

        private System.Windows.Forms.Button btnXemBaoCao;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXuat;

        private System.Windows.Forms.Panel card1;
        private System.Windows.Forms.Panel bar1;
        private System.Windows.Forms.Label lbl1T;
        private System.Windows.Forms.Label lblCPBaoTriVal;

        private System.Windows.Forms.Panel card2;
        private System.Windows.Forms.Panel bar2;
        private System.Windows.Forms.Label lbl2T;
        private System.Windows.Forms.Label lblSoLanBTVal;

        private System.Windows.Forms.Panel card3;
        private System.Windows.Forms.Panel bar3;
        private System.Windows.Forms.Label lbl3T;
        private System.Windows.Forms.Label lblMoTaNhieuNhatVal;

        private System.Windows.Forms.Panel card4;
        private System.Windows.Forms.Panel bar4;
        private System.Windows.Forms.Label lbl4T;
        private System.Windows.Forms.Label lblTongKNVal;

        private System.Windows.Forms.Panel card5;
        private System.Windows.Forms.Panel bar5;
        private System.Windows.Forms.Label lbl5T;
        private System.Windows.Forms.Label lblDaXuLyVal;

        private System.Windows.Forms.Panel card6;
        private System.Windows.Forms.Panel bar6;
        private System.Windows.Forms.Label lbl6T;
        private System.Windows.Forms.Label lblChuaXuLyVal;

        private System.Windows.Forms.Panel card7;
        private System.Windows.Forms.Panel bar7;
        private System.Windows.Forms.Label lbl7T;
        private System.Windows.Forms.Label lblLoaiKNVal;

        private System.Windows.Forms.Panel card8;
        private System.Windows.Forms.Panel bar8;
        private System.Windows.Forms.Label lbl8T;
        private System.Windows.Forms.Label lblTyLeVal;
    }
}