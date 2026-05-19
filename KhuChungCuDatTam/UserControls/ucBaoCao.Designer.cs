namespace KhuChungCuDatTam.UserControls
{
    partial class ucBaoCao
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblFilterThang = new System.Windows.Forms.Label();
            this.cboThang = new System.Windows.Forms.ComboBox();
            this.lblFilterNam = new System.Windows.Forms.Label();
            this.cboNam = new System.Windows.Forms.ComboBox();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.panelStats = new System.Windows.Forms.Panel();
            this.tlpStats = new System.Windows.Forms.TableLayoutPanel();
            this.cardCuDan = new System.Windows.Forms.Panel();
            this.lblTitleCuDan = new System.Windows.Forms.Label();
            this.lblTongCuDan = new System.Windows.Forms.Label();
            this.cardCanHo = new System.Windows.Forms.Panel();
            this.lblTitleCanHo = new System.Windows.Forms.Label();
            this.lblTongCanHo = new System.Windows.Forms.Label();
            this.cardDoanhThu = new System.Windows.Forms.Panel();
            this.lblTitleDoanhThu = new System.Windows.Forms.Label();
            this.lblTongDoanhThu = new System.Windows.Forms.Label();
            this.cardCongNo = new System.Windows.Forms.Panel();
            this.lblTitleCongNo = new System.Windows.Forms.Label();
            this.lblTongCongNo = new System.Windows.Forms.Label();
            this.cardBaoTri = new System.Windows.Forms.Panel();
            this.lblTitleBaoTri = new System.Windows.Forms.Label();
            this.lblTongBaoTri = new System.Windows.Forms.Label();
            this.panelChart = new System.Windows.Forms.Panel();
            this.tlpChart = new System.Windows.Forms.TableLayoutPanel();
            this.chartDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartCongNo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartDichVu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.dgvBaoCao = new System.Windows.Forms.DataGridView();
            this.btnXemReport = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.panelStats.SuspendLayout();
            this.tlpStats.SuspendLayout();
            this.cardCuDan.SuspendLayout();
            this.cardCanHo.SuspendLayout();
            this.cardDoanhThu.SuspendLayout();
            this.cardCongNo.SuspendLayout();
            this.cardBaoTri.SuspendLayout();
            this.panelChart.SuspendLayout();
            this.tlpChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCongNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDichVu)).BeginInit();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Controls.Add(this.lblFilterThang);
            this.panelTop.Controls.Add(this.cboThang);
            this.panelTop.Controls.Add(this.lblFilterNam);
            this.panelTop.Controls.Add(this.cboNam);
            this.panelTop.Controls.Add(this.btnThongKe);
            this.panelTop.Controls.Add(this.btnLamMoi);
            this.panelTop.Controls.Add(this.btnXemReport);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Padding = new System.Windows.Forms.Padding(17, 0, 17, 0);
            this.panelTop.Size = new System.Drawing.Size(1371, 75);
            this.panelTop.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(17, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(354, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "▣  BÁO CÁO THỐNG KÊ";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFilterThang
            // 
            this.lblFilterThang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFilterThang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblFilterThang.Location = new System.Drawing.Point(377, 23);
            this.lblFilterThang.Name = "lblFilterThang";
            this.lblFilterThang.Size = new System.Drawing.Size(59, 28);
            this.lblFilterThang.TabIndex = 1;
            this.lblFilterThang.Text = "Tháng:";
            this.lblFilterThang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboThang
            // 
            this.cboThang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.cboThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboThang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboThang.ForeColor = System.Drawing.Color.White;
            this.cboThang.Location = new System.Drawing.Point(442, 22);
            this.cboThang.Name = "cboThang";
            this.cboThang.Size = new System.Drawing.Size(85, 28);
            this.cboThang.TabIndex = 2;
            // 
            // lblFilterNam
            // 
            this.lblFilterNam.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFilterNam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblFilterNam.Location = new System.Drawing.Point(539, 23);
            this.lblFilterNam.Name = "lblFilterNam";
            this.lblFilterNam.Size = new System.Drawing.Size(51, 28);
            this.lblFilterNam.TabIndex = 3;
            this.lblFilterNam.Text = "Năm:";
            this.lblFilterNam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboNam
            // 
            this.cboNam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.cboNam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboNam.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboNam.ForeColor = System.Drawing.Color.White;
            this.cboNam.Location = new System.Drawing.Point(597, 22);
            this.cboNam.Name = "cboNam";
            this.cboNam.Size = new System.Drawing.Size(100, 28);
            this.cboNam.TabIndex = 4;
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnThongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Location = new System.Drawing.Point(714, 19);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(120, 36);
            this.btnThongKe.TabIndex = 5;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(846, 19);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(120, 36);
            this.btnLamMoi.TabIndex = 6;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXemReport
            // 
            this.btnXemReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.btnXemReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXemReport.FlatAppearance.BorderSize = 0;
            this.btnXemReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemReport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXemReport.ForeColor = System.Drawing.Color.White;
            this.btnXemReport.Location = new System.Drawing.Point(978, 19);
            this.btnXemReport.Name = "btnXemReport";
            this.btnXemReport.Size = new System.Drawing.Size(140, 36);
            this.btnXemReport.TabIndex = 7;
            this.btnXemReport.Text = "Xem Report";
            this.btnXemReport.UseVisualStyleBackColor = false;
            this.btnXemReport.Click += new System.EventHandler(this.btnXemReport_Click);
            // 
            // panelStats
            // 
            this.panelStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.panelStats.Controls.Add(this.tlpStats);
            this.panelStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStats.Location = new System.Drawing.Point(0, 75);
            this.panelStats.Name = "panelStats";
            this.panelStats.Padding = new System.Windows.Forms.Padding(11, 11, 11, 11);
            this.panelStats.Size = new System.Drawing.Size(1371, 139);
            this.panelStats.TabIndex = 2;
            // 
            // tlpStats
            // 
            this.tlpStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.tlpStats.ColumnCount = 5;
            this.tlpStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpStats.Controls.Add(this.cardCuDan, 0, 0);
            this.tlpStats.Controls.Add(this.cardCanHo, 1, 0);
            this.tlpStats.Controls.Add(this.cardDoanhThu, 2, 0);
            this.tlpStats.Controls.Add(this.cardCongNo, 3, 0);
            this.tlpStats.Controls.Add(this.cardBaoTri, 4, 0);
            this.tlpStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpStats.Location = new System.Drawing.Point(11, 11);
            this.tlpStats.Name = "tlpStats";
            this.tlpStats.RowCount = 1;
            this.tlpStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpStats.Size = new System.Drawing.Size(1349, 117);
            this.tlpStats.TabIndex = 0;
            // 
            // cardCuDan
            // 
            this.cardCuDan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.cardCuDan.Controls.Add(this.lblTitleCuDan);
            this.cardCuDan.Controls.Add(this.lblTongCuDan);
            this.cardCuDan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardCuDan.Location = new System.Drawing.Point(0, 0);
            this.cardCuDan.Margin = new System.Windows.Forms.Padding(0, 0, 9, 0);
            this.cardCuDan.Name = "cardCuDan";
            this.cardCuDan.Padding = new System.Windows.Forms.Padding(16, 9, 16, 9);
            this.cardCuDan.Size = new System.Drawing.Size(260, 117);
            this.cardCuDan.TabIndex = 0;
            // 
            // lblTitleCuDan
            // 
            this.lblTitleCuDan.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitleCuDan.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblTitleCuDan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblTitleCuDan.Location = new System.Drawing.Point(16, 9);
            this.lblTitleCuDan.Name = "lblTitleCuDan";
            this.lblTitleCuDan.Size = new System.Drawing.Size(228, 28);
            this.lblTitleCuDan.TabIndex = 0;
            this.lblTitleCuDan.Text = "TỔNG CƯ DÂN";
            this.lblTitleCuDan.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblTongCuDan
            // 
            this.lblTongCuDan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTongCuDan.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTongCuDan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.lblTongCuDan.Location = new System.Drawing.Point(16, 9);
            this.lblTongCuDan.Name = "lblTongCuDan";
            this.lblTongCuDan.Size = new System.Drawing.Size(228, 99);
            this.lblTongCuDan.TabIndex = 1;
            this.lblTongCuDan.Text = "0";
            this.lblTongCuDan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cardCanHo
            // 
            this.cardCanHo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.cardCanHo.Controls.Add(this.lblTitleCanHo);
            this.cardCanHo.Controls.Add(this.lblTongCanHo);
            this.cardCanHo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardCanHo.Location = new System.Drawing.Point(269, 0);
            this.cardCanHo.Margin = new System.Windows.Forms.Padding(0, 0, 9, 0);
            this.cardCanHo.Name = "cardCanHo";
            this.cardCanHo.Padding = new System.Windows.Forms.Padding(16, 9, 16, 9);
            this.cardCanHo.Size = new System.Drawing.Size(260, 117);
            this.cardCanHo.TabIndex = 1;
            // 
            // lblTitleCanHo
            // 
            this.lblTitleCanHo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitleCanHo.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblTitleCanHo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblTitleCanHo.Location = new System.Drawing.Point(16, 9);
            this.lblTitleCanHo.Name = "lblTitleCanHo";
            this.lblTitleCanHo.Size = new System.Drawing.Size(228, 28);
            this.lblTitleCanHo.TabIndex = 0;
            this.lblTitleCanHo.Text = "TỔNG CĂN HỘ";
            this.lblTitleCanHo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblTongCanHo
            // 
            this.lblTongCanHo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTongCanHo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTongCanHo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.lblTongCanHo.Location = new System.Drawing.Point(16, 9);
            this.lblTongCanHo.Name = "lblTongCanHo";
            this.lblTongCanHo.Size = new System.Drawing.Size(228, 99);
            this.lblTongCanHo.TabIndex = 1;
            this.lblTongCanHo.Text = "0";
            this.lblTongCanHo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cardDoanhThu
            // 
            this.cardDoanhThu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.cardDoanhThu.Controls.Add(this.lblTitleDoanhThu);
            this.cardDoanhThu.Controls.Add(this.lblTongDoanhThu);
            this.cardDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardDoanhThu.Location = new System.Drawing.Point(538, 0);
            this.cardDoanhThu.Margin = new System.Windows.Forms.Padding(0, 0, 9, 0);
            this.cardDoanhThu.Name = "cardDoanhThu";
            this.cardDoanhThu.Padding = new System.Windows.Forms.Padding(16, 9, 16, 9);
            this.cardDoanhThu.Size = new System.Drawing.Size(260, 117);
            this.cardDoanhThu.TabIndex = 2;
            // 
            // lblTitleDoanhThu
            // 
            this.lblTitleDoanhThu.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitleDoanhThu.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblTitleDoanhThu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblTitleDoanhThu.Location = new System.Drawing.Point(16, 9);
            this.lblTitleDoanhThu.Name = "lblTitleDoanhThu";
            this.lblTitleDoanhThu.Size = new System.Drawing.Size(228, 28);
            this.lblTitleDoanhThu.TabIndex = 0;
            this.lblTitleDoanhThu.Text = "DOANH THU";
            this.lblTitleDoanhThu.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblTongDoanhThu
            // 
            this.lblTongDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTongDoanhThu.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTongDoanhThu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.lblTongDoanhThu.Location = new System.Drawing.Point(16, 9);
            this.lblTongDoanhThu.Name = "lblTongDoanhThu";
            this.lblTongDoanhThu.Size = new System.Drawing.Size(228, 99);
            this.lblTongDoanhThu.TabIndex = 1;
            this.lblTongDoanhThu.Text = "0 đ";
            this.lblTongDoanhThu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cardCongNo
            // 
            this.cardCongNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.cardCongNo.Controls.Add(this.lblTitleCongNo);
            this.cardCongNo.Controls.Add(this.lblTongCongNo);
            this.cardCongNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardCongNo.Location = new System.Drawing.Point(807, 0);
            this.cardCongNo.Margin = new System.Windows.Forms.Padding(0, 0, 9, 0);
            this.cardCongNo.Name = "cardCongNo";
            this.cardCongNo.Padding = new System.Windows.Forms.Padding(16, 9, 16, 9);
            this.cardCongNo.Size = new System.Drawing.Size(260, 117);
            this.cardCongNo.TabIndex = 3;
            // 
            // lblTitleCongNo
            // 
            this.lblTitleCongNo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitleCongNo.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblTitleCongNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblTitleCongNo.Location = new System.Drawing.Point(16, 9);
            this.lblTitleCongNo.Name = "lblTitleCongNo";
            this.lblTitleCongNo.Size = new System.Drawing.Size(228, 28);
            this.lblTitleCongNo.TabIndex = 0;
            this.lblTitleCongNo.Text = "TỔNG CÔNG NỢ";
            this.lblTitleCongNo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblTongCongNo
            // 
            this.lblTongCongNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTongCongNo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTongCongNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lblTongCongNo.Location = new System.Drawing.Point(16, 9);
            this.lblTongCongNo.Name = "lblTongCongNo";
            this.lblTongCongNo.Size = new System.Drawing.Size(228, 99);
            this.lblTongCongNo.TabIndex = 1;
            this.lblTongCongNo.Text = "0 đ";
            this.lblTongCongNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cardBaoTri
            // 
            this.cardBaoTri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.cardBaoTri.Controls.Add(this.lblTitleBaoTri);
            this.cardBaoTri.Controls.Add(this.lblTongBaoTri);
            this.cardBaoTri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardBaoTri.Location = new System.Drawing.Point(1076, 0);
            this.cardBaoTri.Margin = new System.Windows.Forms.Padding(0);
            this.cardBaoTri.Name = "cardBaoTri";
            this.cardBaoTri.Padding = new System.Windows.Forms.Padding(16, 9, 16, 9);
            this.cardBaoTri.Size = new System.Drawing.Size(273, 117);
            this.cardBaoTri.TabIndex = 4;
            // 
            // lblTitleBaoTri
            // 
            this.lblTitleBaoTri.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitleBaoTri.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblTitleBaoTri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblTitleBaoTri.Location = new System.Drawing.Point(16, 9);
            this.lblTitleBaoTri.Name = "lblTitleBaoTri";
            this.lblTitleBaoTri.Size = new System.Drawing.Size(241, 28);
            this.lblTitleBaoTri.TabIndex = 0;
            this.lblTitleBaoTri.Text = "CHI PHÍ BẢO TRÌ";
            this.lblTitleBaoTri.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblTongBaoTri
            // 
            this.lblTongBaoTri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTongBaoTri.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTongBaoTri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.lblTongBaoTri.Location = new System.Drawing.Point(16, 9);
            this.lblTongBaoTri.Name = "lblTongBaoTri";
            this.lblTongBaoTri.Size = new System.Drawing.Size(241, 99);
            this.lblTongBaoTri.TabIndex = 1;
            this.lblTongBaoTri.Text = "0 đ";
            this.lblTongBaoTri.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelChart
            // 
            this.panelChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.panelChart.Controls.Add(this.tlpChart);
            this.panelChart.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelChart.Location = new System.Drawing.Point(0, 214);
            this.panelChart.Name = "panelChart";
            this.panelChart.Padding = new System.Windows.Forms.Padding(11, 5, 11, 5);
            this.panelChart.Size = new System.Drawing.Size(1371, 299);
            this.panelChart.TabIndex = 1;
            // 
            // tlpChart
            // 
            this.tlpChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.tlpChart.ColumnCount = 3;
            this.tlpChart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlpChart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tlpChart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlpChart.Controls.Add(this.chartDoanhThu, 0, 0);
            this.tlpChart.Controls.Add(this.chartCongNo, 1, 0);
            this.tlpChart.Controls.Add(this.chartDichVu, 2, 0);
            this.tlpChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpChart.Location = new System.Drawing.Point(11, 5);
            this.tlpChart.Name = "tlpChart";
            this.tlpChart.RowCount = 1;
            this.tlpChart.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpChart.Size = new System.Drawing.Size(1349, 289);
            this.tlpChart.TabIndex = 0;
            // 
            // chartDoanhThu
            // 
            this.chartDoanhThu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            chartArea1.Name = "ChartArea1";
            this.chartDoanhThu.ChartAreas.Add(chartArea1);
            this.chartDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartDoanhThu.Legends.Add(legend1);
            this.chartDoanhThu.Location = new System.Drawing.Point(0, 0);
            this.chartDoanhThu.Margin = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.chartDoanhThu.Name = "chartDoanhThu";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "SeriesDoanhThu";
            this.chartDoanhThu.Series.Add(series1);
            this.chartDoanhThu.Size = new System.Drawing.Size(443, 289);
            this.chartDoanhThu.TabIndex = 0;
            // 
            // chartCongNo
            // 
            this.chartCongNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            chartArea2.Name = "ChartArea2";
            this.chartCongNo.ChartAreas.Add(chartArea2);
            this.chartCongNo.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend2";
            this.chartCongNo.Legends.Add(legend2);
            this.chartCongNo.Location = new System.Drawing.Point(449, 0);
            this.chartCongNo.Margin = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.chartCongNo.Name = "chartCongNo";
            series2.ChartArea = "ChartArea2";
            series2.Legend = "Legend2";
            series2.Name = "SeriesCongNo";
            this.chartCongNo.Series.Add(series2);
            this.chartCongNo.Size = new System.Drawing.Size(443, 289);
            this.chartCongNo.TabIndex = 1;
            // 
            // chartDichVu
            // 
            this.chartDichVu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            chartArea3.Name = "ChartArea3";
            this.chartDichVu.ChartAreas.Add(chartArea3);
            this.chartDichVu.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend3";
            this.chartDichVu.Legends.Add(legend3);
            this.chartDichVu.Location = new System.Drawing.Point(898, 0);
            this.chartDichVu.Margin = new System.Windows.Forms.Padding(0);
            this.chartDichVu.Name = "chartDichVu";
            series3.ChartArea = "ChartArea3";
            series3.Legend = "Legend3";
            series3.Name = "SeriesDichVu";
            this.chartDichVu.Series.Add(series3);
            this.chartDichVu.Size = new System.Drawing.Size(451, 289);
            this.chartDichVu.TabIndex = 2;
            // 
            // panelGrid
            // 
            this.panelGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.panelGrid.Controls.Add(this.dgvBaoCao);
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrid.Location = new System.Drawing.Point(0, 513);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Padding = new System.Windows.Forms.Padding(11, 5, 11, 11);
            this.panelGrid.Size = new System.Drawing.Size(1371, 287);
            this.panelGrid.TabIndex = 0;
            // 
            // dgvBaoCao
            // 
            this.dgvBaoCao.AllowUserToAddRows = false;
            this.dgvBaoCao.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvBaoCao.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBaoCao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBaoCao.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.dgvBaoCao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBaoCao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBaoCao.ColumnHeadersHeight = 38;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBaoCao.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBaoCao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBaoCao.EnableHeadersVisualStyles = false;
            this.dgvBaoCao.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.dgvBaoCao.Location = new System.Drawing.Point(11, 5);
            this.dgvBaoCao.Name = "dgvBaoCao";
            this.dgvBaoCao.ReadOnly = true;
            this.dgvBaoCao.RowHeadersVisible = false;
            this.dgvBaoCao.RowHeadersWidth = 51;
            this.dgvBaoCao.RowTemplate.Height = 34;
            this.dgvBaoCao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBaoCao.Size = new System.Drawing.Size(1349, 271);
            this.dgvBaoCao.TabIndex = 0;
            // 
            // ucBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.panelChart);
            this.Controls.Add(this.panelStats);
            this.Controls.Add(this.panelTop);
            this.Name = "ucBaoCao";
            this.Size = new System.Drawing.Size(1371, 800);
            this.Load += new System.EventHandler(this.ucBaoCao_Load);
            this.panelTop.ResumeLayout(false);
            this.panelStats.ResumeLayout(false);
            this.tlpStats.ResumeLayout(false);
            this.cardCuDan.ResumeLayout(false);
            this.cardCanHo.ResumeLayout(false);
            this.cardDoanhThu.ResumeLayout(false);
            this.cardCongNo.ResumeLayout(false);
            this.cardBaoTri.ResumeLayout(false);
            this.panelChart.ResumeLayout(false);
            this.tlpChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCongNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDichVu)).EndInit();
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).EndInit();
            this.ResumeLayout(false);

        }

        // ── Control declarations ───────────────────────────────────────────────
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelStats;
        private System.Windows.Forms.Panel panelChart;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.TableLayoutPanel tlpStats;
        private System.Windows.Forms.TableLayoutPanel tlpChart;
        private System.Windows.Forms.Panel cardCuDan;
        private System.Windows.Forms.Panel cardCanHo;
        private System.Windows.Forms.Panel cardDoanhThu;
        private System.Windows.Forms.Panel cardCongNo;
        private System.Windows.Forms.Panel cardBaoTri;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFilterThang;
        private System.Windows.Forms.Label lblFilterNam;
        private System.Windows.Forms.ComboBox cboThang;
        private System.Windows.Forms.ComboBox cboNam;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXemReport;
        private System.Windows.Forms.Label lblTitleCuDan;
        private System.Windows.Forms.Label lblTitleCanHo;
        private System.Windows.Forms.Label lblTitleDoanhThu;
        private System.Windows.Forms.Label lblTitleCongNo;
        private System.Windows.Forms.Label lblTitleBaoTri;
        private System.Windows.Forms.Label lblTongCuDan;
        private System.Windows.Forms.Label lblTongCanHo;
        private System.Windows.Forms.Label lblTongDoanhThu;
        private System.Windows.Forms.Label lblTongCongNo;
        private System.Windows.Forms.Label lblTongBaoTri;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhThu;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCongNo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDichVu;
        private System.Windows.Forms.DataGridView dgvBaoCao;
    }
}