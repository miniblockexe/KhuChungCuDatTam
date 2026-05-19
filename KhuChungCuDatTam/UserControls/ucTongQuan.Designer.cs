namespace KhuChungCuDatTam.UserControls
{
    partial class ucTongQuan
    {
        private System.ComponentModel.IContainer components = null;

        // ── Root layout ───────────────────────────────────────
        private System.Windows.Forms.Panel pnlRoot;
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Label lblDate;

        // ── Stat cards row ────────────────────────────────────
        private System.Windows.Forms.Panel pnlCards;

        private System.Windows.Forms.Panel cardCuDan;
        private System.Windows.Forms.Panel cardCuDan_Bar;
        private System.Windows.Forms.Label cardCuDan_Icon;
        private System.Windows.Forms.Label cardCuDan_Value;
        private System.Windows.Forms.Label cardCuDan_Label;
        private System.Windows.Forms.Label cardCuDan_Sub;

        private System.Windows.Forms.Panel cardCanHo;
        private System.Windows.Forms.Panel cardCanHo_Bar;
        private System.Windows.Forms.Label cardCanHo_Icon;
        private System.Windows.Forms.Label cardCanHo_Value;
        private System.Windows.Forms.Label cardCanHo_Label;
        private System.Windows.Forms.Label cardCanHo_Sub;

        private System.Windows.Forms.Panel cardDoanhThu;
        private System.Windows.Forms.Panel cardDoanhThu_Bar;
        private System.Windows.Forms.Label cardDoanhThu_Icon;
        private System.Windows.Forms.Label cardDoanhThu_Value;
        private System.Windows.Forms.Label cardDoanhThu_Label;
        private System.Windows.Forms.Label cardDoanhThu_Sub;

        private System.Windows.Forms.Panel cardHoaDon;
        private System.Windows.Forms.Panel cardHoaDon_Bar;
        private System.Windows.Forms.Label cardHoaDon_Icon;
        private System.Windows.Forms.Label cardHoaDon_Value;
        private System.Windows.Forms.Label cardHoaDon_Label;
        private System.Windows.Forms.Label cardHoaDon_Sub;

        private System.Windows.Forms.Panel cardKhieuNai;
        private System.Windows.Forms.Panel cardKhieuNai_Bar;
        private System.Windows.Forms.Label cardKhieuNai_Icon;
        private System.Windows.Forms.Label cardKhieuNai_Value;
        private System.Windows.Forms.Label cardKhieuNai_Label;
        private System.Windows.Forms.Label cardKhieuNai_Sub;

        private System.Windows.Forms.Panel cardPhuongTien;
        private System.Windows.Forms.Panel cardPhuongTien_Bar;
        private System.Windows.Forms.Label cardPhuongTien_Icon;
        private System.Windows.Forms.Label cardPhuongTien_Value;
        private System.Windows.Forms.Label cardPhuongTien_Label;
        private System.Windows.Forms.Label cardPhuongTien_Sub;

        // ── Bottom area: chart left, lists right ───────────────
        private System.Windows.Forms.Panel pnlBottom;

        // Chart panel (left)
        private System.Windows.Forms.Panel pnlChartCard;
        private System.Windows.Forms.Label lblChartTitle;
        private System.Windows.Forms.Panel pnlChartHost;

        // Right column
        private System.Windows.Forms.Panel pnlRight;

        // Recent bills
        private System.Windows.Forms.Panel pnlBillCard;
        private System.Windows.Forms.Label lblBillTitle;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHD_CanHo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHD_ThangNam;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHD_TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHD_TrangThai;

        // Notifications
        private System.Windows.Forms.Panel pnlNotifyCard;
        private System.Windows.Forms.Label lblNotifyTitle;
        private System.Windows.Forms.Panel pnlNotifyList;

        // Timers
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.Timer timerRefresh;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlRoot = new System.Windows.Forms.Panel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlNotifyCard = new System.Windows.Forms.Panel();
            this.pnlNotifyList = new System.Windows.Forms.Panel();
            this.lblNotifyTitle = new System.Windows.Forms.Label();
            this.pnlBillCard = new System.Windows.Forms.Panel();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.colHD_CanHo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHD_ThangNam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHD_TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHD_TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblBillTitle = new System.Windows.Forms.Label();
            this.pnlChartCard = new System.Windows.Forms.Panel();
            this.pnlChartHost = new System.Windows.Forms.Panel();
            this.lblChartTitle = new System.Windows.Forms.Label();
            this.pnlCards = new System.Windows.Forms.Panel();
            this.cardCuDan = new System.Windows.Forms.Panel();
            this.cardCuDan_Sub = new System.Windows.Forms.Label();
            this.cardCuDan_Label = new System.Windows.Forms.Label();
            this.cardCuDan_Value = new System.Windows.Forms.Label();
            this.cardCuDan_Icon = new System.Windows.Forms.Label();
            this.cardCuDan_Bar = new System.Windows.Forms.Panel();
            this.cardCanHo = new System.Windows.Forms.Panel();
            this.cardCanHo_Sub = new System.Windows.Forms.Label();
            this.cardCanHo_Label = new System.Windows.Forms.Label();
            this.cardCanHo_Value = new System.Windows.Forms.Label();
            this.cardCanHo_Icon = new System.Windows.Forms.Label();
            this.cardCanHo_Bar = new System.Windows.Forms.Panel();
            this.cardDoanhThu = new System.Windows.Forms.Panel();
            this.cardDoanhThu_Sub = new System.Windows.Forms.Label();
            this.cardDoanhThu_Label = new System.Windows.Forms.Label();
            this.cardDoanhThu_Value = new System.Windows.Forms.Label();
            this.cardDoanhThu_Icon = new System.Windows.Forms.Label();
            this.cardDoanhThu_Bar = new System.Windows.Forms.Panel();
            this.cardHoaDon = new System.Windows.Forms.Panel();
            this.cardHoaDon_Sub = new System.Windows.Forms.Label();
            this.cardHoaDon_Label = new System.Windows.Forms.Label();
            this.cardHoaDon_Value = new System.Windows.Forms.Label();
            this.cardHoaDon_Icon = new System.Windows.Forms.Label();
            this.cardHoaDon_Bar = new System.Windows.Forms.Panel();
            this.cardKhieuNai = new System.Windows.Forms.Panel();
            this.cardKhieuNai_Sub = new System.Windows.Forms.Label();
            this.cardKhieuNai_Label = new System.Windows.Forms.Label();
            this.cardKhieuNai_Value = new System.Windows.Forms.Label();
            this.cardKhieuNai_Icon = new System.Windows.Forms.Label();
            this.cardKhieuNai_Bar = new System.Windows.Forms.Panel();
            this.cardPhuongTien = new System.Windows.Forms.Panel();
            this.cardPhuongTien_Sub = new System.Windows.Forms.Label();
            this.cardPhuongTien_Label = new System.Windows.Forms.Label();
            this.cardPhuongTien_Value = new System.Windows.Forms.Label();
            this.cardPhuongTien_Icon = new System.Windows.Forms.Label();
            this.cardPhuongTien_Bar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblClock = new System.Windows.Forms.Label();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            this.pnlRoot.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlNotifyCard.SuspendLayout();
            this.pnlBillCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.pnlChartCard.SuspendLayout();
            this.pnlCards.SuspendLayout();
            this.cardCuDan.SuspendLayout();
            this.cardCanHo.SuspendLayout();
            this.cardDoanhThu.SuspendLayout();
            this.cardHoaDon.SuspendLayout();
            this.cardKhieuNai.SuspendLayout();
            this.cardPhuongTien.SuspendLayout();
            this.pnlTopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRoot
            // 
            this.pnlRoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.pnlRoot.Controls.Add(this.pnlBottom);
            this.pnlRoot.Controls.Add(this.pnlCards);
            this.pnlRoot.Controls.Add(this.lblTitle);
            this.pnlRoot.Controls.Add(this.pnlTopBar);
            this.pnlRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRoot.Location = new System.Drawing.Point(0, 0);
            this.pnlRoot.Name = "pnlRoot";
            this.pnlRoot.Padding = new System.Windows.Forms.Padding(20, 16, 20, 16);
            this.pnlRoot.Size = new System.Drawing.Size(1524, 751);
            this.pnlRoot.TabIndex = 0;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.Transparent;
            this.pnlBottom.Controls.Add(this.pnlRight);
            this.pnlBottom.Controls.Add(this.pnlChartCard);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBottom.Location = new System.Drawing.Point(20, 192);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.pnlBottom.Size = new System.Drawing.Size(1484, 543);
            this.pnlBottom.TabIndex = 0;
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.Transparent;
            this.pnlRight.Controls.Add(this.pnlNotifyCard);
            this.pnlRight.Controls.Add(this.pnlBillCard);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(1064, 8);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.pnlRight.Size = new System.Drawing.Size(420, 535);
            this.pnlRight.TabIndex = 0;
            // 
            // pnlNotifyCard
            // 
            this.pnlNotifyCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.pnlNotifyCard.Controls.Add(this.pnlNotifyList);
            this.pnlNotifyCard.Controls.Add(this.lblNotifyTitle);
            this.pnlNotifyCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNotifyCard.Location = new System.Drawing.Point(12, 220);
            this.pnlNotifyCard.Margin = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.pnlNotifyCard.Name = "pnlNotifyCard";
            this.pnlNotifyCard.Padding = new System.Windows.Forms.Padding(14, 10, 14, 10);
            this.pnlNotifyCard.Size = new System.Drawing.Size(408, 315);
            this.pnlNotifyCard.TabIndex = 0;
            // 
            // pnlNotifyList
            // 
            this.pnlNotifyList.AutoScroll = true;
            this.pnlNotifyList.BackColor = System.Drawing.Color.Transparent;
            this.pnlNotifyList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNotifyList.Location = new System.Drawing.Point(14, 40);
            this.pnlNotifyList.Name = "pnlNotifyList";
            this.pnlNotifyList.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.pnlNotifyList.Size = new System.Drawing.Size(380, 265);
            this.pnlNotifyList.TabIndex = 0;
            // 
            // lblNotifyTitle
            // 
            this.lblNotifyTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblNotifyTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNotifyTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblNotifyTitle.ForeColor = System.Drawing.Color.White;
            this.lblNotifyTitle.Location = new System.Drawing.Point(14, 10);
            this.lblNotifyTitle.Name = "lblNotifyTitle";
            this.lblNotifyTitle.Size = new System.Drawing.Size(380, 30);
            this.lblNotifyTitle.TabIndex = 1;
            this.lblNotifyTitle.Text = "🔔  Thông Báo Mới";
            // 
            // pnlBillCard
            // 
            this.pnlBillCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.pnlBillCard.Controls.Add(this.dgvHoaDon);
            this.pnlBillCard.Controls.Add(this.lblBillTitle);
            this.pnlBillCard.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBillCard.Location = new System.Drawing.Point(12, 0);
            this.pnlBillCard.Name = "pnlBillCard";
            this.pnlBillCard.Padding = new System.Windows.Forms.Padding(14, 10, 14, 10);
            this.pnlBillCard.Size = new System.Drawing.Size(408, 220);
            this.pnlBillCard.TabIndex = 1;
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AllowUserToAddRows = false;
            this.dgvHoaDon.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(33)))), ((int)(((byte)(50)))));
            this.dgvHoaDon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDon.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.dgvHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHoaDon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHoaDon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHoaDon.ColumnHeadersHeight = 30;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colHD_CanHo,
            this.colHD_ThangNam,
            this.colHD_TongTien,
            this.colHD_TrangThai});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHoaDon.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHoaDon.EnableHeadersVisualStyles = false;
            this.dgvHoaDon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvHoaDon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.dgvHoaDon.Location = new System.Drawing.Point(14, 40);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.ReadOnly = true;
            this.dgvHoaDon.RowHeadersVisible = false;
            this.dgvHoaDon.RowHeadersWidth = 51;
            this.dgvHoaDon.RowTemplate.Height = 26;
            this.dgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDon.Size = new System.Drawing.Size(380, 170);
            this.dgvHoaDon.TabIndex = 0;
            // 
            // colHD_CanHo
            // 
            this.colHD_CanHo.HeaderText = "Căn Hộ";
            this.colHD_CanHo.MinimumWidth = 6;
            this.colHD_CanHo.Name = "colHD_CanHo";
            this.colHD_CanHo.ReadOnly = true;
            // 
            // colHD_ThangNam
            // 
            this.colHD_ThangNam.HeaderText = "Tháng";
            this.colHD_ThangNam.MinimumWidth = 6;
            this.colHD_ThangNam.Name = "colHD_ThangNam";
            this.colHD_ThangNam.ReadOnly = true;
            // 
            // colHD_TongTien
            // 
            this.colHD_TongTien.HeaderText = "Tổng Tiền";
            this.colHD_TongTien.MinimumWidth = 6;
            this.colHD_TongTien.Name = "colHD_TongTien";
            this.colHD_TongTien.ReadOnly = true;
            // 
            // colHD_TrangThai
            // 
            this.colHD_TrangThai.HeaderText = "Trạng Thái";
            this.colHD_TrangThai.MinimumWidth = 6;
            this.colHD_TrangThai.Name = "colHD_TrangThai";
            this.colHD_TrangThai.ReadOnly = true;
            // 
            // lblBillTitle
            // 
            this.lblBillTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblBillTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBillTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblBillTitle.ForeColor = System.Drawing.Color.White;
            this.lblBillTitle.Location = new System.Drawing.Point(14, 10);
            this.lblBillTitle.Name = "lblBillTitle";
            this.lblBillTitle.Size = new System.Drawing.Size(380, 30);
            this.lblBillTitle.TabIndex = 1;
            this.lblBillTitle.Text = "🧾  Hóa Đơn Gần Đây";
            // 
            // pnlChartCard
            // 
            this.pnlChartCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.pnlChartCard.Controls.Add(this.pnlChartHost);
            this.pnlChartCard.Controls.Add(this.lblChartTitle);
            this.pnlChartCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChartCard.Location = new System.Drawing.Point(0, 8);
            this.pnlChartCard.Name = "pnlChartCard";
            this.pnlChartCard.Padding = new System.Windows.Forms.Padding(16, 12, 16, 12);
            this.pnlChartCard.Size = new System.Drawing.Size(1484, 535);
            this.pnlChartCard.TabIndex = 1;
            // 
            // pnlChartHost
            // 
            this.pnlChartHost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.pnlChartHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChartHost.Location = new System.Drawing.Point(16, 44);
            this.pnlChartHost.Name = "pnlChartHost";
            this.pnlChartHost.Size = new System.Drawing.Size(1452, 479);
            this.pnlChartHost.TabIndex = 0;
            // 
            // lblChartTitle
            // 
            this.lblChartTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblChartTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblChartTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblChartTitle.ForeColor = System.Drawing.Color.White;
            this.lblChartTitle.Location = new System.Drawing.Point(16, 12);
            this.lblChartTitle.Name = "lblChartTitle";
            this.lblChartTitle.Size = new System.Drawing.Size(1452, 32);
            this.lblChartTitle.TabIndex = 1;
            this.lblChartTitle.Text = "📈  Doanh Thu 6 Tháng Gần Nhất";
            // 
            // pnlCards
            // 
            this.pnlCards.BackColor = System.Drawing.Color.Transparent;
            this.pnlCards.Controls.Add(this.cardCuDan);
            this.pnlCards.Controls.Add(this.cardCanHo);
            this.pnlCards.Controls.Add(this.cardDoanhThu);
            this.pnlCards.Controls.Add(this.cardHoaDon);
            this.pnlCards.Controls.Add(this.cardKhieuNai);
            this.pnlCards.Controls.Add(this.cardPhuongTien);
            this.pnlCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCards.Location = new System.Drawing.Point(20, 76);
            this.pnlCards.Name = "pnlCards";
            this.pnlCards.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.pnlCards.Size = new System.Drawing.Size(1484, 116);
            this.pnlCards.TabIndex = 1;
            // 
            // cardCuDan
            // 
            this.cardCuDan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.cardCuDan.Controls.Add(this.cardCuDan_Sub);
            this.cardCuDan.Controls.Add(this.cardCuDan_Label);
            this.cardCuDan.Controls.Add(this.cardCuDan_Value);
            this.cardCuDan.Controls.Add(this.cardCuDan_Icon);
            this.cardCuDan.Controls.Add(this.cardCuDan_Bar);
            this.cardCuDan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cardCuDan.Location = new System.Drawing.Point(0, 8);
            this.cardCuDan.Name = "cardCuDan";
            this.cardCuDan.Size = new System.Drawing.Size(186, 100);
            this.cardCuDan.TabIndex = 0;
            // 
            // cardCuDan_Sub
            // 
            this.cardCuDan_Sub.AutoSize = true;
            this.cardCuDan_Sub.BackColor = System.Drawing.Color.Transparent;
            this.cardCuDan_Sub.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.cardCuDan_Sub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.cardCuDan_Sub.Location = new System.Drawing.Point(12, 78);
            this.cardCuDan_Sub.Name = "cardCuDan_Sub";
            this.cardCuDan_Sub.Size = new System.Drawing.Size(76, 17);
            this.cardCuDan_Sub.TabIndex = 0;
            this.cardCuDan_Sub.Text = "đang cư trú";
            // 
            // cardCuDan_Label
            // 
            this.cardCuDan_Label.AutoSize = true;
            this.cardCuDan_Label.BackColor = System.Drawing.Color.Transparent;
            this.cardCuDan_Label.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.cardCuDan_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.cardCuDan_Label.Location = new System.Drawing.Point(12, 62);
            this.cardCuDan_Label.Name = "cardCuDan_Label";
            this.cardCuDan_Label.Size = new System.Drawing.Size(100, 20);
            this.cardCuDan_Label.TabIndex = 1;
            this.cardCuDan_Label.Text = "Tổng Cư Dân";
            // 
            // cardCuDan_Value
            // 
            this.cardCuDan_Value.BackColor = System.Drawing.Color.Transparent;
            this.cardCuDan_Value.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.cardCuDan_Value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.cardCuDan_Value.Location = new System.Drawing.Point(72, 10);
            this.cardCuDan_Value.Name = "cardCuDan_Value";
            this.cardCuDan_Value.Size = new System.Drawing.Size(118, 52);
            this.cardCuDan_Value.TabIndex = 2;
            this.cardCuDan_Value.Text = "—";
            // 
            // cardCuDan_Icon
            // 
            this.cardCuDan_Icon.AutoSize = true;
            this.cardCuDan_Icon.BackColor = System.Drawing.Color.Transparent;
            this.cardCuDan_Icon.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.cardCuDan_Icon.Location = new System.Drawing.Point(12, 12);
            this.cardCuDan_Icon.Name = "cardCuDan_Icon";
            this.cardCuDan_Icon.Size = new System.Drawing.Size(67, 46);
            this.cardCuDan_Icon.TabIndex = 3;
            this.cardCuDan_Icon.Text = "👥";
            // 
            // cardCuDan_Bar
            // 
            this.cardCuDan_Bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.cardCuDan_Bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.cardCuDan_Bar.Location = new System.Drawing.Point(0, 0);
            this.cardCuDan_Bar.Name = "cardCuDan_Bar";
            this.cardCuDan_Bar.Size = new System.Drawing.Size(186, 3);
            this.cardCuDan_Bar.TabIndex = 4;
            // 
            // cardCanHo
            // 
            this.cardCanHo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.cardCanHo.Controls.Add(this.cardCanHo_Sub);
            this.cardCanHo.Controls.Add(this.cardCanHo_Label);
            this.cardCanHo.Controls.Add(this.cardCanHo_Value);
            this.cardCanHo.Controls.Add(this.cardCanHo_Icon);
            this.cardCanHo.Controls.Add(this.cardCanHo_Bar);
            this.cardCanHo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cardCanHo.Location = new System.Drawing.Point(196, 8);
            this.cardCanHo.Name = "cardCanHo";
            this.cardCanHo.Size = new System.Drawing.Size(186, 100);
            this.cardCanHo.TabIndex = 1;
            // 
            // cardCanHo_Sub
            // 
            this.cardCanHo_Sub.AutoSize = true;
            this.cardCanHo_Sub.BackColor = System.Drawing.Color.Transparent;
            this.cardCanHo_Sub.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.cardCanHo_Sub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.cardCanHo_Sub.Location = new System.Drawing.Point(12, 78);
            this.cardCanHo_Sub.Name = "cardCanHo_Sub";
            this.cardCanHo_Sub.Size = new System.Drawing.Size(96, 17);
            this.cardCanHo_Sub.TabIndex = 0;
            this.cardCanHo_Sub.Text = "trong hệ thống";
            // 
            // cardCanHo_Label
            // 
            this.cardCanHo_Label.AutoSize = true;
            this.cardCanHo_Label.BackColor = System.Drawing.Color.Transparent;
            this.cardCanHo_Label.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.cardCanHo_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.cardCanHo_Label.Location = new System.Drawing.Point(12, 62);
            this.cardCanHo_Label.Name = "cardCanHo_Label";
            this.cardCanHo_Label.Size = new System.Drawing.Size(99, 20);
            this.cardCanHo_Label.TabIndex = 1;
            this.cardCanHo_Label.Text = "Tổng Căn Hộ";
            // 
            // cardCanHo_Value
            // 
            this.cardCanHo_Value.BackColor = System.Drawing.Color.Transparent;
            this.cardCanHo_Value.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.cardCanHo_Value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.cardCanHo_Value.Location = new System.Drawing.Point(68, 12);
            this.cardCanHo_Value.Name = "cardCanHo_Value";
            this.cardCanHo_Value.Size = new System.Drawing.Size(118, 52);
            this.cardCanHo_Value.TabIndex = 2;
            this.cardCanHo_Value.Text = "—";
            // 
            // cardCanHo_Icon
            // 
            this.cardCanHo_Icon.AutoSize = true;
            this.cardCanHo_Icon.BackColor = System.Drawing.Color.Transparent;
            this.cardCanHo_Icon.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.cardCanHo_Icon.Location = new System.Drawing.Point(12, 12);
            this.cardCanHo_Icon.Name = "cardCanHo_Icon";
            this.cardCanHo_Icon.Size = new System.Drawing.Size(67, 46);
            this.cardCanHo_Icon.TabIndex = 3;
            this.cardCanHo_Icon.Text = "🏢";
            // 
            // cardCanHo_Bar
            // 
            this.cardCanHo_Bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.cardCanHo_Bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.cardCanHo_Bar.Location = new System.Drawing.Point(0, 0);
            this.cardCanHo_Bar.Name = "cardCanHo_Bar";
            this.cardCanHo_Bar.Size = new System.Drawing.Size(186, 3);
            this.cardCanHo_Bar.TabIndex = 4;
            // 
            // cardDoanhThu
            // 
            this.cardDoanhThu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.cardDoanhThu.Controls.Add(this.cardDoanhThu_Sub);
            this.cardDoanhThu.Controls.Add(this.cardDoanhThu_Label);
            this.cardDoanhThu.Controls.Add(this.cardDoanhThu_Value);
            this.cardDoanhThu.Controls.Add(this.cardDoanhThu_Icon);
            this.cardDoanhThu.Controls.Add(this.cardDoanhThu_Bar);
            this.cardDoanhThu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cardDoanhThu.Location = new System.Drawing.Point(392, 8);
            this.cardDoanhThu.Name = "cardDoanhThu";
            this.cardDoanhThu.Size = new System.Drawing.Size(186, 100);
            this.cardDoanhThu.TabIndex = 2;
            // 
            // cardDoanhThu_Sub
            // 
            this.cardDoanhThu_Sub.AutoSize = true;
            this.cardDoanhThu_Sub.BackColor = System.Drawing.Color.Transparent;
            this.cardDoanhThu_Sub.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.cardDoanhThu_Sub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.cardDoanhThu_Sub.Location = new System.Drawing.Point(12, 78);
            this.cardDoanhThu_Sub.Name = "cardDoanhThu_Sub";
            this.cardDoanhThu_Sub.Size = new System.Drawing.Size(87, 17);
            this.cardDoanhThu_Sub.TabIndex = 0;
            this.cardDoanhThu_Sub.Text = "tháng hiện tại";
            // 
            // cardDoanhThu_Label
            // 
            this.cardDoanhThu_Label.AutoSize = true;
            this.cardDoanhThu_Label.BackColor = System.Drawing.Color.Transparent;
            this.cardDoanhThu_Label.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.cardDoanhThu_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.cardDoanhThu_Label.Location = new System.Drawing.Point(12, 62);
            this.cardDoanhThu_Label.Name = "cardDoanhThu_Label";
            this.cardDoanhThu_Label.Size = new System.Drawing.Size(134, 20);
            this.cardDoanhThu_Label.TabIndex = 1;
            this.cardDoanhThu_Label.Text = "Doanh Thu Tháng";
            // 
            // cardDoanhThu_Value
            // 
            this.cardDoanhThu_Value.BackColor = System.Drawing.Color.Transparent;
            this.cardDoanhThu_Value.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.cardDoanhThu_Value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(184)))), ((int)(((byte)(166)))));
            this.cardDoanhThu_Value.Location = new System.Drawing.Point(66, 16);
            this.cardDoanhThu_Value.Name = "cardDoanhThu_Value";
            this.cardDoanhThu_Value.Size = new System.Drawing.Size(124, 48);
            this.cardDoanhThu_Value.TabIndex = 2;
            this.cardDoanhThu_Value.Text = "—";
            // 
            // cardDoanhThu_Icon
            // 
            this.cardDoanhThu_Icon.AutoSize = true;
            this.cardDoanhThu_Icon.BackColor = System.Drawing.Color.Transparent;
            this.cardDoanhThu_Icon.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.cardDoanhThu_Icon.Location = new System.Drawing.Point(12, 12);
            this.cardDoanhThu_Icon.Name = "cardDoanhThu_Icon";
            this.cardDoanhThu_Icon.Size = new System.Drawing.Size(67, 46);
            this.cardDoanhThu_Icon.TabIndex = 3;
            this.cardDoanhThu_Icon.Text = "💰";
            // 
            // cardDoanhThu_Bar
            // 
            this.cardDoanhThu_Bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(184)))), ((int)(((byte)(166)))));
            this.cardDoanhThu_Bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.cardDoanhThu_Bar.Location = new System.Drawing.Point(0, 0);
            this.cardDoanhThu_Bar.Name = "cardDoanhThu_Bar";
            this.cardDoanhThu_Bar.Size = new System.Drawing.Size(186, 3);
            this.cardDoanhThu_Bar.TabIndex = 4;
            // 
            // cardHoaDon
            // 
            this.cardHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.cardHoaDon.Controls.Add(this.cardHoaDon_Sub);
            this.cardHoaDon.Controls.Add(this.cardHoaDon_Label);
            this.cardHoaDon.Controls.Add(this.cardHoaDon_Value);
            this.cardHoaDon.Controls.Add(this.cardHoaDon_Icon);
            this.cardHoaDon.Controls.Add(this.cardHoaDon_Bar);
            this.cardHoaDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cardHoaDon.Location = new System.Drawing.Point(588, 8);
            this.cardHoaDon.Name = "cardHoaDon";
            this.cardHoaDon.Size = new System.Drawing.Size(186, 100);
            this.cardHoaDon.TabIndex = 3;
            // 
            // cardHoaDon_Sub
            // 
            this.cardHoaDon_Sub.AutoSize = true;
            this.cardHoaDon_Sub.BackColor = System.Drawing.Color.Transparent;
            this.cardHoaDon_Sub.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.cardHoaDon_Sub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.cardHoaDon_Sub.Location = new System.Drawing.Point(12, 78);
            this.cardHoaDon_Sub.Name = "cardHoaDon_Sub";
            this.cardHoaDon_Sub.Size = new System.Drawing.Size(102, 17);
            this.cardHoaDon_Sub.TabIndex = 0;
            this.cardHoaDon_Sub.Text = "chưa thanh toán";
            // 
            // cardHoaDon_Label
            // 
            this.cardHoaDon_Label.AutoSize = true;
            this.cardHoaDon_Label.BackColor = System.Drawing.Color.Transparent;
            this.cardHoaDon_Label.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.cardHoaDon_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.cardHoaDon_Label.Location = new System.Drawing.Point(12, 62);
            this.cardHoaDon_Label.Name = "cardHoaDon_Label";
            this.cardHoaDon_Label.Size = new System.Drawing.Size(123, 20);
            this.cardHoaDon_Label.TabIndex = 1;
            this.cardHoaDon_Label.Text = "Hóa Đơn Chờ TT";
            // 
            // cardHoaDon_Value
            // 
            this.cardHoaDon_Value.BackColor = System.Drawing.Color.Transparent;
            this.cardHoaDon_Value.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.cardHoaDon_Value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.cardHoaDon_Value.Location = new System.Drawing.Point(68, 10);
            this.cardHoaDon_Value.Name = "cardHoaDon_Value";
            this.cardHoaDon_Value.Size = new System.Drawing.Size(118, 52);
            this.cardHoaDon_Value.TabIndex = 2;
            this.cardHoaDon_Value.Text = "—";
            // 
            // cardHoaDon_Icon
            // 
            this.cardHoaDon_Icon.AutoSize = true;
            this.cardHoaDon_Icon.BackColor = System.Drawing.Color.Transparent;
            this.cardHoaDon_Icon.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.cardHoaDon_Icon.Location = new System.Drawing.Point(12, 12);
            this.cardHoaDon_Icon.Name = "cardHoaDon_Icon";
            this.cardHoaDon_Icon.Size = new System.Drawing.Size(67, 46);
            this.cardHoaDon_Icon.TabIndex = 3;
            this.cardHoaDon_Icon.Text = "💳";
            // 
            // cardHoaDon_Bar
            // 
            this.cardHoaDon_Bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.cardHoaDon_Bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.cardHoaDon_Bar.Location = new System.Drawing.Point(0, 0);
            this.cardHoaDon_Bar.Name = "cardHoaDon_Bar";
            this.cardHoaDon_Bar.Size = new System.Drawing.Size(186, 3);
            this.cardHoaDon_Bar.TabIndex = 4;
            // 
            // cardKhieuNai
            // 
            this.cardKhieuNai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.cardKhieuNai.Controls.Add(this.cardKhieuNai_Sub);
            this.cardKhieuNai.Controls.Add(this.cardKhieuNai_Label);
            this.cardKhieuNai.Controls.Add(this.cardKhieuNai_Value);
            this.cardKhieuNai.Controls.Add(this.cardKhieuNai_Icon);
            this.cardKhieuNai.Controls.Add(this.cardKhieuNai_Bar);
            this.cardKhieuNai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cardKhieuNai.Location = new System.Drawing.Point(784, 8);
            this.cardKhieuNai.Name = "cardKhieuNai";
            this.cardKhieuNai.Size = new System.Drawing.Size(186, 100);
            this.cardKhieuNai.TabIndex = 4;
            // 
            // cardKhieuNai_Sub
            // 
            this.cardKhieuNai_Sub.AutoSize = true;
            this.cardKhieuNai_Sub.BackColor = System.Drawing.Color.Transparent;
            this.cardKhieuNai_Sub.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.cardKhieuNai_Sub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.cardKhieuNai_Sub.Location = new System.Drawing.Point(12, 78);
            this.cardKhieuNai_Sub.Name = "cardKhieuNai_Sub";
            this.cardKhieuNai_Sub.Size = new System.Drawing.Size(59, 17);
            this.cardKhieuNai_Sub.TabIndex = 0;
            this.cardKhieuNai_Sub.Text = "cần xử lý";
            // 
            // cardKhieuNai_Label
            // 
            this.cardKhieuNai_Label.AutoSize = true;
            this.cardKhieuNai_Label.BackColor = System.Drawing.Color.Transparent;
            this.cardKhieuNai_Label.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.cardKhieuNai_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.cardKhieuNai_Label.Location = new System.Drawing.Point(12, 62);
            this.cardKhieuNai_Label.Name = "cardKhieuNai_Label";
            this.cardKhieuNai_Label.Size = new System.Drawing.Size(117, 20);
            this.cardKhieuNai_Label.TabIndex = 1;
            this.cardKhieuNai_Label.Text = "Tổng Khiếu Nại";
            // 
            // cardKhieuNai_Value
            // 
            this.cardKhieuNai_Value.BackColor = System.Drawing.Color.Transparent;
            this.cardKhieuNai_Value.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.cardKhieuNai_Value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.cardKhieuNai_Value.Location = new System.Drawing.Point(68, 10);
            this.cardKhieuNai_Value.Name = "cardKhieuNai_Value";
            this.cardKhieuNai_Value.Size = new System.Drawing.Size(118, 52);
            this.cardKhieuNai_Value.TabIndex = 2;
            this.cardKhieuNai_Value.Text = "—";
            // 
            // cardKhieuNai_Icon
            // 
            this.cardKhieuNai_Icon.AutoSize = true;
            this.cardKhieuNai_Icon.BackColor = System.Drawing.Color.Transparent;
            this.cardKhieuNai_Icon.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.cardKhieuNai_Icon.Location = new System.Drawing.Point(12, 12);
            this.cardKhieuNai_Icon.Name = "cardKhieuNai_Icon";
            this.cardKhieuNai_Icon.Size = new System.Drawing.Size(67, 46);
            this.cardKhieuNai_Icon.TabIndex = 3;
            this.cardKhieuNai_Icon.Text = "💬";
            // 
            // cardKhieuNai_Bar
            // 
            this.cardKhieuNai_Bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.cardKhieuNai_Bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.cardKhieuNai_Bar.Location = new System.Drawing.Point(0, 0);
            this.cardKhieuNai_Bar.Name = "cardKhieuNai_Bar";
            this.cardKhieuNai_Bar.Size = new System.Drawing.Size(186, 3);
            this.cardKhieuNai_Bar.TabIndex = 4;
            // 
            // cardPhuongTien
            // 
            this.cardPhuongTien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.cardPhuongTien.Controls.Add(this.cardPhuongTien_Sub);
            this.cardPhuongTien.Controls.Add(this.cardPhuongTien_Label);
            this.cardPhuongTien.Controls.Add(this.cardPhuongTien_Value);
            this.cardPhuongTien.Controls.Add(this.cardPhuongTien_Icon);
            this.cardPhuongTien.Controls.Add(this.cardPhuongTien_Bar);
            this.cardPhuongTien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cardPhuongTien.Location = new System.Drawing.Point(980, 8);
            this.cardPhuongTien.Name = "cardPhuongTien";
            this.cardPhuongTien.Size = new System.Drawing.Size(186, 100);
            this.cardPhuongTien.TabIndex = 5;
            // 
            // cardPhuongTien_Sub
            // 
            this.cardPhuongTien_Sub.AutoSize = true;
            this.cardPhuongTien_Sub.BackColor = System.Drawing.Color.Transparent;
            this.cardPhuongTien_Sub.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.cardPhuongTien_Sub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.cardPhuongTien_Sub.Location = new System.Drawing.Point(12, 78);
            this.cardPhuongTien_Sub.Name = "cardPhuongTien_Sub";
            this.cardPhuongTien_Sub.Size = new System.Drawing.Size(73, 17);
            this.cardPhuongTien_Sub.TabIndex = 0;
            this.cardPhuongTien_Sub.Text = "đã đăng ký";
            // 
            // cardPhuongTien_Label
            // 
            this.cardPhuongTien_Label.AutoSize = true;
            this.cardPhuongTien_Label.BackColor = System.Drawing.Color.Transparent;
            this.cardPhuongTien_Label.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.cardPhuongTien_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.cardPhuongTien_Label.Location = new System.Drawing.Point(12, 62);
            this.cardPhuongTien_Label.Name = "cardPhuongTien_Label";
            this.cardPhuongTien_Label.Size = new System.Drawing.Size(98, 20);
            this.cardPhuongTien_Label.TabIndex = 1;
            this.cardPhuongTien_Label.Text = "Phương Tiện";
            // 
            // cardPhuongTien_Value
            // 
            this.cardPhuongTien_Value.BackColor = System.Drawing.Color.Transparent;
            this.cardPhuongTien_Value.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.cardPhuongTien_Value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(85)))), ((int)(((byte)(247)))));
            this.cardPhuongTien_Value.Location = new System.Drawing.Point(65, 10);
            this.cardPhuongTien_Value.Name = "cardPhuongTien_Value";
            this.cardPhuongTien_Value.Size = new System.Drawing.Size(118, 52);
            this.cardPhuongTien_Value.TabIndex = 2;
            this.cardPhuongTien_Value.Text = "—";
            // 
            // cardPhuongTien_Icon
            // 
            this.cardPhuongTien_Icon.AutoSize = true;
            this.cardPhuongTien_Icon.BackColor = System.Drawing.Color.Transparent;
            this.cardPhuongTien_Icon.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.cardPhuongTien_Icon.Location = new System.Drawing.Point(12, 12);
            this.cardPhuongTien_Icon.Name = "cardPhuongTien_Icon";
            this.cardPhuongTien_Icon.Size = new System.Drawing.Size(67, 46);
            this.cardPhuongTien_Icon.TabIndex = 3;
            this.cardPhuongTien_Icon.Text = "🚗";
            // 
            // cardPhuongTien_Bar
            // 
            this.cardPhuongTien_Bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(85)))), ((int)(((byte)(247)))));
            this.cardPhuongTien_Bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.cardPhuongTien_Bar.Location = new System.Drawing.Point(0, 0);
            this.cardPhuongTien_Bar.Name = "cardPhuongTien_Bar";
            this.cardPhuongTien_Bar.Size = new System.Drawing.Size(186, 3);
            this.cardPhuongTien_Bar.TabIndex = 4;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(19, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(320, 41);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Tổng Quan Hệ Thống";
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.Transparent;
            this.pnlTopBar.Controls.Add(this.lblDate);
            this.pnlTopBar.Controls.Add(this.lblClock);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(20, 16);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(1484, 60);
            this.pnlTopBar.TabIndex = 2;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblDate.Location = new System.Drawing.Point(2, 40);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 20);
            this.lblDate.TabIndex = 0;
            // 
            // lblClock
            // 
            this.lblClock.BackColor = System.Drawing.Color.Transparent;
            this.lblClock.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblClock.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblClock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.lblClock.Location = new System.Drawing.Point(1324, 0);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(160, 60);
            this.lblClock.TabIndex = 1;
            this.lblClock.Text = "00:00:00";
            this.lblClock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timerClock
            // 
            this.timerClock.Interval = 1000;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // timerRefresh
            // 
            this.timerRefresh.Interval = 300000;
            this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick);
            // 
            // ucTongQuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.Controls.Add(this.pnlRoot);
            this.Name = "ucTongQuan";
            this.Size = new System.Drawing.Size(1524, 751);
            this.Load += new System.EventHandler(this.ucTongQuan_Load);
            this.Resize += new System.EventHandler(this.ucTongQuan_Resize);
            this.pnlRoot.ResumeLayout(false);
            this.pnlRoot.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.pnlNotifyCard.ResumeLayout(false);
            this.pnlBillCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.pnlChartCard.ResumeLayout(false);
            this.pnlCards.ResumeLayout(false);
            this.cardCuDan.ResumeLayout(false);
            this.cardCuDan.PerformLayout();
            this.cardCanHo.ResumeLayout(false);
            this.cardCanHo.PerformLayout();
            this.cardDoanhThu.ResumeLayout(false);
            this.cardDoanhThu.PerformLayout();
            this.cardHoaDon.ResumeLayout(false);
            this.cardHoaDon.PerformLayout();
            this.cardKhieuNai.ResumeLayout(false);
            this.cardKhieuNai.PerformLayout();
            this.cardPhuongTien.ResumeLayout(false);
            this.cardPhuongTien.PerformLayout();
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}