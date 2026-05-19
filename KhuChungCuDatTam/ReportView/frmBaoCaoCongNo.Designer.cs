namespace KhuChungCuDatTam.Forms
{
    partial class frmBaoCaoCongNo
    {
        private System.ComponentModel.IContainer components = null;

  

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
            this.lblTongNoVal = new System.Windows.Forms.Label();

            this.card2 = new System.Windows.Forms.Panel();
            this.bar2 = new System.Windows.Forms.Panel();
            this.lbl2T = new System.Windows.Forms.Label();
            this.lblQuaHanVal = new System.Windows.Forms.Label();

            this.card3 = new System.Windows.Forms.Panel();
            this.bar3 = new System.Windows.Forms.Panel();
            this.lbl3T = new System.Windows.Forms.Label();
            this.lblChuaTTVal = new System.Windows.Forms.Label();

            this.card4 = new System.Windows.Forms.Panel();
            this.bar4 = new System.Windows.Forms.Panel();
            this.lbl4T = new System.Windows.Forms.Label();
            this.lblCanHoNoVal = new System.Windows.Forms.Label();

            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();

            this.pnlToolbar.SuspendLayout();
            this.pnlCards.SuspendLayout();

            this.card1.SuspendLayout();
            this.card2.SuspendLayout();
            this.card3.SuspendLayout();
            this.card4.SuspendLayout();

            this.SuspendLayout();

            // ================= TOOLBAR =================

            this.pnlToolbar.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolbar.Height = 55;
            this.pnlToolbar.Controls.Add(this.lblTitle);
            this.pnlToolbar.Controls.Add(this.lblThang);
            this.pnlToolbar.Controls.Add(this.cboThang);
            this.pnlToolbar.Controls.Add(this.lblNam);
            this.pnlToolbar.Controls.Add(this.cboNam);
            this.pnlToolbar.Controls.Add(this.btnXemBaoCao);
            this.pnlToolbar.Controls.Add(this.btnLamMoi);
            this.pnlToolbar.Controls.Add(this.btnXuat);

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(15, 15);
            this.lblTitle.Text = "📑 BÁO CÁO CÔNG NỢ";

            // lblThang
            this.lblThang.AutoSize = true;
            this.lblThang.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblThang.Location = new System.Drawing.Point(260, 18);
            this.lblThang.Text = "Tháng:";

            // cboThang
            this.cboThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboThang.Location = new System.Drawing.Point(320, 14);
            this.cboThang.Size = new System.Drawing.Size(100, 28);

            // lblNam
            this.lblNam.AutoSize = true;
            this.lblNam.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNam.Location = new System.Drawing.Point(435, 18);
            this.lblNam.Text = "Năm:";

            // cboNam
            this.cboNam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboNam.Location = new System.Drawing.Point(490, 14);
            this.cboNam.Size = new System.Drawing.Size(90, 28);

            // btnXemBaoCao
            this.btnXemBaoCao.BackColor = System.Drawing.Color.FromArgb(59, 130, 246);
            this.btnXemBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemBaoCao.FlatAppearance.BorderSize = 0;
            this.btnXemBaoCao.ForeColor = System.Drawing.Color.White;
            this.btnXemBaoCao.Location = new System.Drawing.Point(600, 12);
            this.btnXemBaoCao.Size = new System.Drawing.Size(100, 30);
            this.btnXemBaoCao.Text = "Thống kê";
            this.btnXemBaoCao.UseVisualStyleBackColor = false;
            this.btnXemBaoCao.Click += new System.EventHandler(this.btnXemBaoCao_Click);

            // btnLamMoi
            this.btnLamMoi.BackColor = System.Drawing.Color.Gray;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(710, 12);
            this.btnLamMoi.Size = new System.Drawing.Size(90, 30);
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);

            // btnXuat
            this.btnXuat.BackColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.btnXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuat.FlatAppearance.BorderSize = 0;
            this.btnXuat.ForeColor = System.Drawing.Color.White;
            this.btnXuat.Location = new System.Drawing.Point(815, 12);
            this.btnXuat.Size = new System.Drawing.Size(120, 30);
            this.btnXuat.Text = "📥 Xuất CSV";
            this.btnXuat.UseVisualStyleBackColor = false;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);

            // ================= CARDS =================

            this.pnlCards.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.pnlCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCards.Height = 95;

            this.pnlCards.Controls.Add(this.card1);
            this.pnlCards.Controls.Add(this.card2);
            this.pnlCards.Controls.Add(this.card3);
            this.pnlCards.Controls.Add(this.card4);

            // ================= CARD 1 =================

            this.card1.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.card1.Location = new System.Drawing.Point(10, 10);
            this.card1.Size = new System.Drawing.Size(250, 70);

            this.card1.Controls.Add(this.bar1);
            this.card1.Controls.Add(this.lbl1T);
            this.card1.Controls.Add(this.lblTongNoVal);

            this.bar1.BackColor = System.Drawing.Color.Red;
            this.bar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bar1.Width = 5;

            this.lbl1T.ForeColor = System.Drawing.Color.Silver;
            this.lbl1T.Location = new System.Drawing.Point(15, 10);
            this.lbl1T.Text = "TỔNG CÔNG NỢ";

            this.lblTongNoVal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTongNoVal.ForeColor = System.Drawing.Color.White;
            this.lblTongNoVal.Location = new System.Drawing.Point(15, 30);
            this.lblTongNoVal.Size = new System.Drawing.Size(220, 30);
            this.lblTongNoVal.Text = "0 đ";

            // ================= CARD 2 =================

            this.card2.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.card2.Location = new System.Drawing.Point(275, 10);
            this.card2.Size = new System.Drawing.Size(250, 70);

            this.card2.Controls.Add(this.bar2);
            this.card2.Controls.Add(this.lbl2T);
            this.card2.Controls.Add(this.lblQuaHanVal);

            this.bar2.BackColor = System.Drawing.Color.Orange;
            this.bar2.Dock = System.Windows.Forms.DockStyle.Left;
            this.bar2.Width = 5;

            this.lbl2T.ForeColor = System.Drawing.Color.Silver;
            this.lbl2T.Location = new System.Drawing.Point(15, 10);
            this.lbl2T.Text = "NỢ QUÁ HẠN";

            this.lblQuaHanVal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblQuaHanVal.ForeColor = System.Drawing.Color.White;
            this.lblQuaHanVal.Location = new System.Drawing.Point(15, 30);
            this.lblQuaHanVal.Size = new System.Drawing.Size(220, 30);
            this.lblQuaHanVal.Text = "0 đ";

            // ================= CARD 3 =================

            this.card3.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.card3.Location = new System.Drawing.Point(540, 10);
            this.card3.Size = new System.Drawing.Size(250, 70);

            this.card3.Controls.Add(this.bar3);
            this.card3.Controls.Add(this.lbl3T);
            this.card3.Controls.Add(this.lblChuaTTVal);

            this.bar3.BackColor = System.Drawing.Color.Crimson;
            this.bar3.Dock = System.Windows.Forms.DockStyle.Left;
            this.bar3.Width = 5;

            this.lbl3T.ForeColor = System.Drawing.Color.Silver;
            this.lbl3T.Location = new System.Drawing.Point(15, 10);
            this.lbl3T.Text = "HÓA ĐƠN CHƯA TT";

            this.lblChuaTTVal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblChuaTTVal.ForeColor = System.Drawing.Color.White;
            this.lblChuaTTVal.Location = new System.Drawing.Point(15, 30);
            this.lblChuaTTVal.Size = new System.Drawing.Size(220, 30);
            this.lblChuaTTVal.Text = "0";

            // ================= CARD 4 =================

            this.card4.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.card4.Location = new System.Drawing.Point(805, 10);
            this.card4.Size = new System.Drawing.Size(250, 70);

            this.card4.Controls.Add(this.bar4);
            this.card4.Controls.Add(this.lbl4T);
            this.card4.Controls.Add(this.lblCanHoNoVal);

            this.bar4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bar4.Dock = System.Windows.Forms.DockStyle.Left;
            this.bar4.Width = 5;

            this.lbl4T.ForeColor = System.Drawing.Color.Silver;
            this.lbl4T.Location = new System.Drawing.Point(15, 10);
            this.lbl4T.Text = "CĂN HỘ ĐANG NỢ";

            this.lblCanHoNoVal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblCanHoNoVal.ForeColor = System.Drawing.Color.White;
            this.lblCanHoNoVal.Location = new System.Drawing.Point(15, 30);
            this.lblCanHoNoVal.Size = new System.Drawing.Size(220, 30);
            this.lblCanHoNoVal.Text = "0";

            // ================= REPORT VIEWER =================

            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer.Location = new System.Drawing.Point(0, 150);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.ServerReport.BearerToken = null;

            // ================= FORM =================

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.ClientSize = new System.Drawing.Size(1200, 720);

            this.Controls.Add(this.reportViewer);
            this.Controls.Add(this.pnlToolbar);
            this.Controls.Add(this.pnlCards);

            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "frmBaoCaoCongNo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo Cáo Công Nợ";

            this.pnlToolbar.ResumeLayout(false);
            this.pnlToolbar.PerformLayout();

            this.pnlCards.ResumeLayout(false);

            this.card1.ResumeLayout(false);
            this.card2.ResumeLayout(false);
            this.card3.ResumeLayout(false);
            this.card4.ResumeLayout(false);

            this.ResumeLayout(false);
        }
        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.Panel pnlCards;

        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.Label lblThang;
        private System.Windows.Forms.ComboBox cboThang;

        private System.Windows.Forms.Label lblNam;
        private System.Windows.Forms.ComboBox cboNam;

        private System.Windows.Forms.Button btnXemBaoCao;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXuat;

        private System.Windows.Forms.Panel card1;
        private System.Windows.Forms.Panel bar1;
        private System.Windows.Forms.Label lbl1T;
        private System.Windows.Forms.Label lblTongNoVal;

        private System.Windows.Forms.Panel card2;
        private System.Windows.Forms.Panel bar2;
        private System.Windows.Forms.Label lbl2T;
        private System.Windows.Forms.Label lblQuaHanVal;

        private System.Windows.Forms.Panel card3;
        private System.Windows.Forms.Panel bar3;
        private System.Windows.Forms.Label lbl3T;
        private System.Windows.Forms.Label lblChuaTTVal;

        private System.Windows.Forms.Panel card4;
        private System.Windows.Forms.Panel bar4;
        private System.Windows.Forms.Label lbl4T;
        private System.Windows.Forms.Label lblCanHoNoVal;

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
    }
}