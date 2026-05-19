namespace KhuChungCuDatTam.UserControls
{
    partial class ucChamCong
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();

            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlFormCard = new System.Windows.Forms.Panel();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.lblNguoiDung = new System.Windows.Forms.Label();
            this.cboNguoiDung = new System.Windows.Forms.ComboBox();
            this.lblNgay = new System.Windows.Forms.Label();
            this.dtNgay = new System.Windows.Forms.DateTimePicker();
            this.lblGioVao = new System.Windows.Forms.Label();
            this.dtGioVao = new System.Windows.Forms.DateTimePicker();
            this.lblGioRa = new System.Windows.Forms.Label();
            this.dtGioRa = new System.Windows.Forms.DateTimePicker();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.pnlBtnGroup = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlStats = new System.Windows.Forms.Panel();
            this.pnlCardTong = new System.Windows.Forms.Panel();
            this.lblStatTongTitle = new System.Windows.Forms.Label();
            this.lblTongChamCong = new System.Windows.Forms.Label();
            this.pnlCardCoMat = new System.Windows.Forms.Panel();
            this.lblStatCoMatTitle = new System.Windows.Forms.Label();
            this.lblCoMat = new System.Windows.Forms.Label();
            this.pnlCardVangMat = new System.Windows.Forms.Panel();
            this.lblStatVangMatTitle = new System.Windows.Forms.Label();
            this.lblVangMat = new System.Windows.Forms.Label();
            this.pnlGridCard = new System.Windows.Forms.Panel();
            this.pnlSearchBar = new System.Windows.Forms.Panel();
            this.lblSearchIcon = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvChamCong = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNguoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioVao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioRa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblRecordCount = new System.Windows.Forms.Label();

            // ── SuspendLayout ────────────────────────────────────────
            this.pnlMain.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlFormCard.SuspendLayout();
            this.pnlBtnGroup.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlStats.SuspendLayout();
            this.pnlCardTong.SuspendLayout();
            this.pnlCardCoMat.SuspendLayout();
            this.pnlCardVangMat.SuspendLayout();
            this.pnlGridCard.SuspendLayout();
            this.pnlSearchBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamCong)).BeginInit();
            this.SuspendLayout();

            // ── pnlMain ──────────────────────────────────────────────
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.pnlMain.Controls.Add(this.pnlBody);
            this.pnlMain.Controls.Add(this.pnlHeader);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(23, 17, 23, 17);
            this.pnlMain.Size = new System.Drawing.Size(1371, 800);
            this.pnlMain.TabIndex = 0;

            // ── pnlHeader ────────────────────────────────────────────
            this.pnlHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeader.Controls.Add(this.lblSubTitle);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(23, 17);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(5, 0, 0, 11);
            this.pnlHeader.Size = new System.Drawing.Size(1325, 77);
            this.pnlHeader.TabIndex = 1;

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(5, 4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(420, 46);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Quản Lý Chấm Công";

            // lblSubTitle
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblSubTitle.Location = new System.Drawing.Point(9, 49);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(340, 20);
            this.lblSubTitle.TabIndex = 0;
            this.lblSubTitle.Text = "Theo dõi giờ vào / giờ ra và trạng thái nhân viên";

            // ── pnlBody ──────────────────────────────────────────────
            this.pnlBody.BackColor = System.Drawing.Color.Transparent;
            this.pnlBody.Controls.Add(this.pnlRight);
            this.pnlBody.Controls.Add(this.pnlLeft);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(23, 94);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(1325, 689);
            this.pnlBody.TabIndex = 0;

            // ── pnlLeft ──────────────────────────────────────────────
            this.pnlLeft.BackColor = System.Drawing.Color.Transparent;
            this.pnlLeft.Controls.Add(this.pnlFormCard);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Padding = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.pnlLeft.Size = new System.Drawing.Size(366, 689);
            this.pnlLeft.TabIndex = 1;

            // ── pnlFormCard ──────────────────────────────────────────
            this.pnlFormCard.AutoScroll = true;
            this.pnlFormCard.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.pnlFormCard.Controls.Add(this.pnlBtnGroup);
            this.pnlFormCard.Controls.Add(this.cboTrangThai);
            this.pnlFormCard.Controls.Add(this.lblTrangThai);
            this.pnlFormCard.Controls.Add(this.dtGioRa);
            this.pnlFormCard.Controls.Add(this.lblGioRa);
            this.pnlFormCard.Controls.Add(this.dtGioVao);
            this.pnlFormCard.Controls.Add(this.lblGioVao);
            this.pnlFormCard.Controls.Add(this.dtNgay);
            this.pnlFormCard.Controls.Add(this.lblNgay);
            this.pnlFormCard.Controls.Add(this.cboNguoiDung);
            this.pnlFormCard.Controls.Add(this.lblNguoiDung);
            this.pnlFormCard.Controls.Add(this.lblFormTitle);
            this.pnlFormCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormCard.Location = new System.Drawing.Point(0, 0);
            this.pnlFormCard.Name = "pnlFormCard";
            this.pnlFormCard.Padding = new System.Windows.Forms.Padding(25, 19, 25, 19);
            this.pnlFormCard.Size = new System.Drawing.Size(350, 689);
            this.pnlFormCard.TabIndex = 0;

            // lblFormTitle
            this.lblFormTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblFormTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(59, 130, 246);
            this.lblFormTitle.Location = new System.Drawing.Point(25, 19);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(300, 41);
            this.lblFormTitle.TabIndex = 20;
            this.lblFormTitle.Text = "\u23F0  Thông Tin Chấm Công";
            this.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // lblNguoiDung
            this.lblNguoiDung.AutoSize = true;
            this.lblNguoiDung.BackColor = System.Drawing.Color.Transparent;
            this.lblNguoiDung.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblNguoiDung.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblNguoiDung.Location = new System.Drawing.Point(25, 64);
            this.lblNguoiDung.Name = "lblNguoiDung";
            this.lblNguoiDung.Size = new System.Drawing.Size(110, 20);
            this.lblNguoiDung.TabIndex = 19;
            this.lblNguoiDung.Text = "NHÂN VIÊN *";

            // cboNguoiDung
            this.cboNguoiDung.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.cboNguoiDung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNguoiDung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboNguoiDung.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboNguoiDung.ForeColor = System.Drawing.Color.White;
            this.cboNguoiDung.Location = new System.Drawing.Point(25, 85);
            this.cboNguoiDung.Name = "cboNguoiDung";
            this.cboNguoiDung.Size = new System.Drawing.Size(310, 29);
            this.cboNguoiDung.TabIndex = 0;

            // lblNgay
            this.lblNgay.AutoSize = true;
            this.lblNgay.BackColor = System.Drawing.Color.Transparent;
            this.lblNgay.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblNgay.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblNgay.Location = new System.Drawing.Point(25, 132);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(66, 20);
            this.lblNgay.TabIndex = 18;
            this.lblNgay.Text = "NGÀY *";

            // dtNgay
            this.dtNgay.CalendarForeColor = System.Drawing.Color.White;
            this.dtNgay.CalendarMonthBackground = System.Drawing.Color.FromArgb(30, 41, 59);
            this.dtNgay.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgay.Location = new System.Drawing.Point(25, 154);
            this.dtNgay.Name = "dtNgay";
            this.dtNgay.Size = new System.Drawing.Size(310, 29);
            this.dtNgay.TabIndex = 1;

            // lblGioVao
            this.lblGioVao.AutoSize = true;
            this.lblGioVao.BackColor = System.Drawing.Color.Transparent;
            this.lblGioVao.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblGioVao.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblGioVao.Location = new System.Drawing.Point(25, 201);
            this.lblGioVao.Name = "lblGioVao";
            this.lblGioVao.Size = new System.Drawing.Size(73, 20);
            this.lblGioVao.TabIndex = 17;
            this.lblGioVao.Text = "GIỜ VÀO";

            // dtGioVao
            this.dtGioVao.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtGioVao.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtGioVao.Location = new System.Drawing.Point(25, 222);
            this.dtGioVao.Name = "dtGioVao";
            this.dtGioVao.ShowUpDown = true;
            this.dtGioVao.Size = new System.Drawing.Size(310, 29);
            this.dtGioVao.TabIndex = 2;

            // lblGioRa
            this.lblGioRa.AutoSize = true;
            this.lblGioRa.BackColor = System.Drawing.Color.Transparent;
            this.lblGioRa.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblGioRa.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblGioRa.Location = new System.Drawing.Point(25, 269);
            this.lblGioRa.Name = "lblGioRa";
            this.lblGioRa.Size = new System.Drawing.Size(60, 20);
            this.lblGioRa.TabIndex = 16;
            this.lblGioRa.Text = "GIỜ RA";

            // dtGioRa
            this.dtGioRa.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtGioRa.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtGioRa.Location = new System.Drawing.Point(25, 290);
            this.dtGioRa.Name = "dtGioRa";
            this.dtGioRa.ShowUpDown = true;
            this.dtGioRa.Size = new System.Drawing.Size(310, 29);
            this.dtGioRa.TabIndex = 3;

            // lblTrangThai
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.BackColor = System.Drawing.Color.Transparent;
            this.lblTrangThai.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblTrangThai.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblTrangThai.Location = new System.Drawing.Point(25, 337);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(110, 20);
            this.lblTrangThai.TabIndex = 15;
            this.lblTrangThai.Text = "TRẠNG THÁI *";

            // cboTrangThai
            this.cboTrangThai.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTrangThai.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboTrangThai.ForeColor = System.Drawing.Color.White;
            this.cboTrangThai.Location = new System.Drawing.Point(25, 358);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(310, 29);
            this.cboTrangThai.TabIndex = 4;

            // ── pnlBtnGroup ──────────────────────────────────────────
            this.pnlBtnGroup.BackColor = System.Drawing.Color.Transparent;
            this.pnlBtnGroup.Controls.Add(this.btnThem);
            this.pnlBtnGroup.Controls.Add(this.btnSua);
            this.pnlBtnGroup.Controls.Add(this.btnXoa);
            this.pnlBtnGroup.Controls.Add(this.btnLamMoi);
            this.pnlBtnGroup.Location = new System.Drawing.Point(25, 420);
            this.pnlBtnGroup.Name = "pnlBtnGroup";
            this.pnlBtnGroup.Size = new System.Drawing.Size(311, 107);
            this.pnlBtnGroup.TabIndex = 0;

            // btnThem
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(59, 130, 246);
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(0, 0);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(146, 43);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "\u2795  Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            // btnSua
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(165, 0);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(146, 43);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "\u270F  Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

            // btnXoa
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(0, 55);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(146, 43);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "\uD83D\uDDD1  Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            // btnLamMoi
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(165, 55);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(146, 43);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "\uD83D\uDD04  Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);

            // ── pnlRight ─────────────────────────────────────────────
            this.pnlRight.BackColor = System.Drawing.Color.Transparent;
            this.pnlRight.Controls.Add(this.pnlGridCard);
            this.pnlRight.Controls.Add(this.pnlStats);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(366, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(959, 689);
            this.pnlRight.TabIndex = 0;

            // ── pnlStats ─────────────────────────────────────────────
            this.pnlStats.BackColor = System.Drawing.Color.Transparent;
            this.pnlStats.Controls.Add(this.pnlCardTong);
            this.pnlStats.Controls.Add(this.pnlCardCoMat);
            this.pnlStats.Controls.Add(this.pnlCardVangMat);
            this.pnlStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStats.Location = new System.Drawing.Point(0, 0);
            this.pnlStats.Name = "pnlStats";
            this.pnlStats.Padding = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.pnlStats.Size = new System.Drawing.Size(959, 110);
            this.pnlStats.TabIndex = 1;

            // pnlCardTong
            this.pnlCardTong.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.pnlCardTong.Controls.Add(this.lblTongChamCong);
            this.pnlCardTong.Controls.Add(this.lblStatTongTitle);
            this.pnlCardTong.Location = new System.Drawing.Point(0, 0);
            this.pnlCardTong.Name = "pnlCardTong";
            this.pnlCardTong.Size = new System.Drawing.Size(305, 98);
            this.pnlCardTong.TabIndex = 0;

            // lblStatTongTitle
            this.lblStatTongTitle.AutoSize = true;
            this.lblStatTongTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblStatTongTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblStatTongTitle.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblStatTongTitle.Location = new System.Drawing.Point(18, 15);
            this.lblStatTongTitle.Name = "lblStatTongTitle";
            this.lblStatTongTitle.Size = new System.Drawing.Size(150, 20);
            this.lblStatTongTitle.TabIndex = 1;
            this.lblStatTongTitle.Text = "TỔNG CHẤM CÔNG";

            // lblTongChamCong
            this.lblTongChamCong.AutoSize = true;
            this.lblTongChamCong.BackColor = System.Drawing.Color.Transparent;
            this.lblTongChamCong.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTongChamCong.ForeColor = System.Drawing.Color.FromArgb(59, 130, 246);
            this.lblTongChamCong.Location = new System.Drawing.Point(18, 42);
            this.lblTongChamCong.Name = "lblTongChamCong";
            this.lblTongChamCong.Size = new System.Drawing.Size(40, 50);
            this.lblTongChamCong.TabIndex = 0;
            this.lblTongChamCong.Text = "0";

            // pnlCardCoMat
            this.pnlCardCoMat.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.pnlCardCoMat.Controls.Add(this.lblCoMat);
            this.pnlCardCoMat.Controls.Add(this.lblStatCoMatTitle);
            this.pnlCardCoMat.Location = new System.Drawing.Point(321, 0);
            this.pnlCardCoMat.Name = "pnlCardCoMat";
            this.pnlCardCoMat.Size = new System.Drawing.Size(305, 98);
            this.pnlCardCoMat.TabIndex = 1;

            // lblStatCoMatTitle
            this.lblStatCoMatTitle.AutoSize = true;
            this.lblStatCoMatTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblStatCoMatTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblStatCoMatTitle.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblStatCoMatTitle.Location = new System.Drawing.Point(18, 15);
            this.lblStatCoMatTitle.Name = "lblStatCoMatTitle";
            this.lblStatCoMatTitle.Size = new System.Drawing.Size(75, 20);
            this.lblStatCoMatTitle.TabIndex = 1;
            this.lblStatCoMatTitle.Text = "CÓ MẶT";

            // lblCoMat
            this.lblCoMat.AutoSize = true;
            this.lblCoMat.BackColor = System.Drawing.Color.Transparent;
            this.lblCoMat.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblCoMat.ForeColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.lblCoMat.Location = new System.Drawing.Point(18, 42);
            this.lblCoMat.Name = "lblCoMat";
            this.lblCoMat.Size = new System.Drawing.Size(40, 50);
            this.lblCoMat.TabIndex = 0;
            this.lblCoMat.Text = "0";

            // pnlCardVangMat
            this.pnlCardVangMat.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.pnlCardVangMat.Controls.Add(this.lblVangMat);
            this.pnlCardVangMat.Controls.Add(this.lblStatVangMatTitle);
            this.pnlCardVangMat.Location = new System.Drawing.Point(642, 0);
            this.pnlCardVangMat.Name = "pnlCardVangMat";
            this.pnlCardVangMat.Size = new System.Drawing.Size(305, 98);
            this.pnlCardVangMat.TabIndex = 2;

            // lblStatVangMatTitle
            this.lblStatVangMatTitle.AutoSize = true;
            this.lblStatVangMatTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblStatVangMatTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblStatVangMatTitle.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblStatVangMatTitle.Location = new System.Drawing.Point(18, 15);
            this.lblStatVangMatTitle.Name = "lblStatVangMatTitle";
            this.lblStatVangMatTitle.Size = new System.Drawing.Size(95, 20);
            this.lblStatVangMatTitle.TabIndex = 1;
            this.lblStatVangMatTitle.Text = "VẮNG MẶT";

            // lblVangMat
            this.lblVangMat.AutoSize = true;
            this.lblVangMat.BackColor = System.Drawing.Color.Transparent;
            this.lblVangMat.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblVangMat.ForeColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.lblVangMat.Location = new System.Drawing.Point(18, 42);
            this.lblVangMat.Name = "lblVangMat";
            this.lblVangMat.Size = new System.Drawing.Size(40, 50);
            this.lblVangMat.TabIndex = 0;
            this.lblVangMat.Text = "0";

            // ── pnlGridCard ──────────────────────────────────────────
            this.pnlGridCard.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.pnlGridCard.Controls.Add(this.dgvChamCong);
            this.pnlGridCard.Controls.Add(this.lblRecordCount);
            this.pnlGridCard.Controls.Add(this.pnlSearchBar);
            this.pnlGridCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGridCard.Location = new System.Drawing.Point(0, 110);
            this.pnlGridCard.Name = "pnlGridCard";
            this.pnlGridCard.Padding = new System.Windows.Forms.Padding(18, 15, 18, 15);
            this.pnlGridCard.Size = new System.Drawing.Size(959, 579);
            this.pnlGridCard.TabIndex = 0;

            // pnlSearchBar
            this.pnlSearchBar.BackColor = System.Drawing.Color.Transparent;
            this.pnlSearchBar.Controls.Add(this.txtSearch);
            this.pnlSearchBar.Controls.Add(this.lblSearchIcon);
            this.pnlSearchBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearchBar.Location = new System.Drawing.Point(18, 15);
            this.pnlSearchBar.Name = "pnlSearchBar";
            this.pnlSearchBar.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.pnlSearchBar.Size = new System.Drawing.Size(923, 49);
            this.pnlSearchBar.TabIndex = 2;

            // lblSearchIcon
            this.lblSearchIcon.BackColor = System.Drawing.Color.Transparent;
            this.lblSearchIcon.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblSearchIcon.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblSearchIcon.Location = new System.Drawing.Point(0, 6);
            this.lblSearchIcon.Name = "lblSearchIcon";
            this.lblSearchIcon.Size = new System.Drawing.Size(39, 36);
            this.lblSearchIcon.TabIndex = 1;
            this.lblSearchIcon.Text = "\uD83D\uDD0D";
            this.lblSearchIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // txtSearch
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.Location = new System.Drawing.Point(41, 9);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(388, 29);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);

            // ── dgvChamCong ──────────────────────────────────────────
            this.dgvChamCong.AllowUserToAddRows = false;
            this.dgvChamCong.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(20, 30, 50);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(59, 130, 246);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvChamCong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvChamCong.AutoGenerateColumns = false;
            this.dgvChamCong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChamCong.BackgroundColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.dgvChamCong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvChamCong.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.dgvChamCong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvChamCong.ColumnHeadersHeight = 40;
            this.dgvChamCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvChamCong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colId,
                this.colNguoiDung,
                this.colNgay,
                this.colGioVao,
                this.colGioRa,
                this.colTrangThai
            });
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(59, 130, 246);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChamCong.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvChamCong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChamCong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvChamCong.GridColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.dgvChamCong.Location = new System.Drawing.Point(18, 64);
            this.dgvChamCong.MultiSelect = false;
            this.dgvChamCong.Name = "dgvChamCong";
            this.dgvChamCong.ReadOnly = true;
            this.dgvChamCong.RowHeadersVisible = false;
            this.dgvChamCong.RowHeadersWidth = 51;
            this.dgvChamCong.RowTemplate.Height = 36;
            this.dgvChamCong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChamCong.Size = new System.Drawing.Size(923, 489);
            this.dgvChamCong.TabIndex = 0;
            this.dgvChamCong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChamCong_CellClick);

            // colId
            this.colId.FillWeight = 30F;
            this.colId.HeaderText = "ID";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;

            // colNguoiDung
            this.colNguoiDung.FillWeight = 200F;
            this.colNguoiDung.HeaderText = "Nhân Viên";
            this.colNguoiDung.MinimumWidth = 6;
            this.colNguoiDung.Name = "colNguoiDung";
            this.colNguoiDung.ReadOnly = true;

            // colNgay
            this.colNgay.FillWeight = 110F;
            this.colNgay.HeaderText = "Ngày";
            this.colNgay.MinimumWidth = 6;
            this.colNgay.Name = "colNgay";
            this.colNgay.ReadOnly = true;

            // colGioVao
            this.colGioVao.FillWeight = 100F;
            this.colGioVao.HeaderText = "Giờ Vào";
            this.colGioVao.MinimumWidth = 6;
            this.colGioVao.Name = "colGioVao";
            this.colGioVao.ReadOnly = true;

            // colGioRa
            this.colGioRa.FillWeight = 100F;
            this.colGioRa.HeaderText = "Giờ Ra";
            this.colGioRa.MinimumWidth = 6;
            this.colGioRa.Name = "colGioRa";
            this.colGioRa.ReadOnly = true;

            // colTrangThai
            this.colTrangThai.FillWeight = 150F;
            this.colTrangThai.HeaderText = "Trạng Thái";
            this.colTrangThai.MinimumWidth = 6;
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.ReadOnly = true;

            // lblRecordCount
            this.lblRecordCount.BackColor = System.Drawing.Color.Transparent;
            this.lblRecordCount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblRecordCount.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblRecordCount.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblRecordCount.Location = new System.Drawing.Point(18, 548);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(923, 26);
            this.lblRecordCount.TabIndex = 1;
            this.lblRecordCount.Text = "0 bản ghi";
            this.lblRecordCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // ── ucChamCong ───────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.Controls.Add(this.pnlMain);
            this.Name = "ucChamCong";
            this.Size = new System.Drawing.Size(1371, 800);
            this.Load += new System.EventHandler(this.ucChamCong_Load);

            // ── ResumeLayout ─────────────────────────────────────────
            this.pnlBtnGroup.ResumeLayout(false);
            this.pnlFormCard.ResumeLayout(false);
            this.pnlFormCard.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.pnlCardTong.ResumeLayout(false);
            this.pnlCardTong.PerformLayout();
            this.pnlCardCoMat.ResumeLayout(false);
            this.pnlCardCoMat.PerformLayout();
            this.pnlCardVangMat.ResumeLayout(false);
            this.pnlCardVangMat.PerformLayout();
            this.pnlStats.ResumeLayout(false);
            this.pnlSearchBar.ResumeLayout(false);
            this.pnlSearchBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamCong)).EndInit();
            this.pnlGridCard.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        // ── Field declarations ────────────────────────────────────────
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlFormCard;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblNguoiDung;
        private System.Windows.Forms.ComboBox cboNguoiDung;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.DateTimePicker dtNgay;
        private System.Windows.Forms.Label lblGioVao;
        private System.Windows.Forms.DateTimePicker dtGioVao;
        private System.Windows.Forms.Label lblGioRa;
        private System.Windows.Forms.DateTimePicker dtGioRa;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Panel pnlBtnGroup;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlStats;
        private System.Windows.Forms.Panel pnlCardTong;
        private System.Windows.Forms.Label lblStatTongTitle;
        private System.Windows.Forms.Label lblTongChamCong;
        private System.Windows.Forms.Panel pnlCardCoMat;
        private System.Windows.Forms.Label lblStatCoMatTitle;
        private System.Windows.Forms.Label lblCoMat;
        private System.Windows.Forms.Panel pnlCardVangMat;
        private System.Windows.Forms.Label lblStatVangMatTitle;
        private System.Windows.Forms.Label lblVangMat;
        private System.Windows.Forms.Panel pnlGridCard;
        private System.Windows.Forms.Panel pnlSearchBar;
        private System.Windows.Forms.Label lblSearchIcon;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvChamCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNguoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioVao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioRa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.Label lblRecordCount;
    }
}