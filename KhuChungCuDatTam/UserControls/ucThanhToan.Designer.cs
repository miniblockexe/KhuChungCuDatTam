namespace KhuChungCuDatTam.UserControls
{
    partial class ucThanhToan
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.pnlCards = new System.Windows.Forms.Panel();
            this.cardTongThu = new System.Windows.Forms.Panel();
            this.lblTongThuIcon = new System.Windows.Forms.Label();
            this.lblTongThuTitle = new System.Windows.Forms.Label();
            this.lblTongThuValue = new System.Windows.Forms.Label();
            this.cardSoLuong = new System.Windows.Forms.Panel();
            this.lblSoLuongIcon = new System.Windows.Forms.Label();
            this.lblSoLuongTitle = new System.Windows.Forms.Label();
            this.lblSoLuongValue = new System.Windows.Forms.Label();
            this.cardHomNay = new System.Windows.Forms.Panel();
            this.lblHomNayIcon = new System.Windows.Forms.Label();
            this.lblHomNayTitle = new System.Windows.Forms.Label();
            this.lblHomNayValue = new System.Windows.Forms.Label();
            this.cardThangNay = new System.Windows.Forms.Panel();
            this.lblThangNayIcon = new System.Windows.Forms.Label();
            this.lblThangNayTitle = new System.Windows.Forms.Label();
            this.lblThangNayValue = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.lblHoaDon = new System.Windows.Forms.Label();
            this.cboHoaDon = new System.Windows.Forms.ComboBox();
            this.lblCanHo = new System.Windows.Forms.Label();
            this.txtCanHo = new System.Windows.Forms.TextBox();
            this.lblCuDan = new System.Windows.Forms.Label();
            this.txtCuDan = new System.Windows.Forms.TextBox();
            this.lblSoTien = new System.Windows.Forms.Label();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.lblNgayThanhToan = new System.Windows.Forms.Label();
            this.dtNgayThanhToan = new System.Windows.Forms.DateTimePicker();
            this.lblPhuongThuc = new System.Windows.Forms.Label();
            this.cboPhuongThuc = new System.Windows.Forms.ComboBox();
            this.lblMaPhieuThu = new System.Windows.Forms.Label();
            this.txtMaPhieuThu = new System.Windows.Forms.TextBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.lblGridTitle = new System.Windows.Forms.Label();
            this.pnlSearchBar = new System.Windows.Forms.Panel();
            this.lblSearchIcon = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvThanhToan = new System.Windows.Forms.DataGridView();

            this.pnlMain.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlCards.SuspendLayout();
            this.cardTongThu.SuspendLayout();
            this.cardSoLuong.SuspendLayout();
            this.cardHomNay.SuspendLayout();
            this.cardThangNay.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlSearchBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhToan)).BeginInit();
            this.SuspendLayout();

            // =============================================================
            // pnlMain
            // =============================================================
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(20);
            this.pnlMain.Size = new System.Drawing.Size(1200, 750);
            this.pnlMain.TabIndex = 0;
            this.pnlMain.Controls.Add(this.pnlContent);
            this.pnlMain.Controls.Add(this.pnlCards);
            this.pnlMain.Controls.Add(this.pnlHeader);

            // =============================================================
            // pnlHeader
            // =============================================================
            this.pnlHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(20, 20);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1160, 70);
            this.pnlHeader.TabIndex = 0;
            this.pnlHeader.Controls.Add(this.lblSubTitle);
            this.pnlHeader.Controls.Add(this.lblTitle);

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Quan Ly Thanh Toan";

            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblSubTitle.Location = new System.Drawing.Point(2, 46);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "Quan ly thanh toan hoa don cu dan chung cu";

            // =============================================================
            // pnlCards
            // =============================================================
            this.pnlCards.BackColor = System.Drawing.Color.Transparent;
            this.pnlCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCards.Location = new System.Drawing.Point(20, 90);
            this.pnlCards.Name = "pnlCards";
            this.pnlCards.Size = new System.Drawing.Size(1160, 100);
            this.pnlCards.TabIndex = 1;
            this.pnlCards.Controls.Add(this.cardThangNay);
            this.pnlCards.Controls.Add(this.cardHomNay);
            this.pnlCards.Controls.Add(this.cardSoLuong);
            this.pnlCards.Controls.Add(this.cardTongThu);

            // ---- cardTongThu ----
            this.cardTongThu.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.cardTongThu.Location = new System.Drawing.Point(0, 0);
            this.cardTongThu.Name = "cardTongThu";
            this.cardTongThu.Size = new System.Drawing.Size(210, 90);
            this.cardTongThu.TabIndex = 0;
            this.cardTongThu.Controls.Add(this.lblTongThuValue);
            this.cardTongThu.Controls.Add(this.lblTongThuTitle);
            this.cardTongThu.Controls.Add(this.lblTongThuIcon);

            this.lblTongThuIcon.AutoSize = true;
            this.lblTongThuIcon.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTongThuIcon.ForeColor = System.Drawing.Color.FromArgb(59, 130, 246);
            this.lblTongThuIcon.Location = new System.Drawing.Point(12, 12);
            this.lblTongThuIcon.Name = "lblTongThuIcon";
            this.lblTongThuIcon.TabIndex = 0;
            this.lblTongThuIcon.Text = "$";

            this.lblTongThuTitle.AutoSize = true;
            this.lblTongThuTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblTongThuTitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblTongThuTitle.Location = new System.Drawing.Point(48, 14);
            this.lblTongThuTitle.Name = "lblTongThuTitle";
            this.lblTongThuTitle.TabIndex = 1;
            this.lblTongThuTitle.Text = "Tong Thu";

            this.lblTongThuValue.AutoSize = false;
            this.lblTongThuValue.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTongThuValue.ForeColor = System.Drawing.Color.White;
            this.lblTongThuValue.Location = new System.Drawing.Point(48, 36);
            this.lblTongThuValue.Name = "lblTongThuValue";
            this.lblTongThuValue.Size = new System.Drawing.Size(150, 26);
            this.lblTongThuValue.TabIndex = 2;
            this.lblTongThuValue.Text = "0 d";

            // ---- cardSoLuong ----
            this.cardSoLuong.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.cardSoLuong.Location = new System.Drawing.Point(220, 0);
            this.cardSoLuong.Name = "cardSoLuong";
            this.cardSoLuong.Size = new System.Drawing.Size(210, 90);
            this.cardSoLuong.TabIndex = 1;
            this.cardSoLuong.Controls.Add(this.lblSoLuongValue);
            this.cardSoLuong.Controls.Add(this.lblSoLuongTitle);
            this.cardSoLuong.Controls.Add(this.lblSoLuongIcon);

            this.lblSoLuongIcon.AutoSize = true;
            this.lblSoLuongIcon.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblSoLuongIcon.ForeColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.lblSoLuongIcon.Location = new System.Drawing.Point(12, 12);
            this.lblSoLuongIcon.Name = "lblSoLuongIcon";
            this.lblSoLuongIcon.TabIndex = 0;
            this.lblSoLuongIcon.Text = "#";

            this.lblSoLuongTitle.AutoSize = true;
            this.lblSoLuongTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSoLuongTitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblSoLuongTitle.Location = new System.Drawing.Point(48, 14);
            this.lblSoLuongTitle.Name = "lblSoLuongTitle";
            this.lblSoLuongTitle.TabIndex = 1;
            this.lblSoLuongTitle.Text = "So Giao Dich";

            this.lblSoLuongValue.AutoSize = false;
            this.lblSoLuongValue.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblSoLuongValue.ForeColor = System.Drawing.Color.White;
            this.lblSoLuongValue.Location = new System.Drawing.Point(48, 36);
            this.lblSoLuongValue.Name = "lblSoLuongValue";
            this.lblSoLuongValue.Size = new System.Drawing.Size(150, 26);
            this.lblSoLuongValue.TabIndex = 2;
            this.lblSoLuongValue.Text = "0";

            // ---- cardHomNay ----
            this.cardHomNay.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.cardHomNay.Location = new System.Drawing.Point(440, 0);
            this.cardHomNay.Name = "cardHomNay";
            this.cardHomNay.Size = new System.Drawing.Size(210, 90);
            this.cardHomNay.TabIndex = 2;
            this.cardHomNay.Controls.Add(this.lblHomNayValue);
            this.cardHomNay.Controls.Add(this.lblHomNayTitle);
            this.cardHomNay.Controls.Add(this.lblHomNayIcon);

            this.lblHomNayIcon.AutoSize = true;
            this.lblHomNayIcon.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblHomNayIcon.ForeColor = System.Drawing.Color.FromArgb(245, 158, 11);
            this.lblHomNayIcon.Location = new System.Drawing.Point(12, 12);
            this.lblHomNayIcon.Name = "lblHomNayIcon";
            this.lblHomNayIcon.TabIndex = 0;
            this.lblHomNayIcon.Text = "*";

            this.lblHomNayTitle.AutoSize = true;
            this.lblHomNayTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblHomNayTitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblHomNayTitle.Location = new System.Drawing.Point(48, 14);
            this.lblHomNayTitle.Name = "lblHomNayTitle";
            this.lblHomNayTitle.TabIndex = 1;
            this.lblHomNayTitle.Text = "Thu Hom Nay";

            this.lblHomNayValue.AutoSize = false;
            this.lblHomNayValue.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblHomNayValue.ForeColor = System.Drawing.Color.White;
            this.lblHomNayValue.Location = new System.Drawing.Point(48, 36);
            this.lblHomNayValue.Name = "lblHomNayValue";
            this.lblHomNayValue.Size = new System.Drawing.Size(150, 26);
            this.lblHomNayValue.TabIndex = 2;
            this.lblHomNayValue.Text = "0 d";

            // ---- cardThangNay ----
            this.cardThangNay.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.cardThangNay.Location = new System.Drawing.Point(660, 0);
            this.cardThangNay.Name = "cardThangNay";
            this.cardThangNay.Size = new System.Drawing.Size(210, 90);
            this.cardThangNay.TabIndex = 3;
            this.cardThangNay.Controls.Add(this.lblThangNayValue);
            this.cardThangNay.Controls.Add(this.lblThangNayTitle);
            this.cardThangNay.Controls.Add(this.lblThangNayIcon);

            this.lblThangNayIcon.AutoSize = true;
            this.lblThangNayIcon.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblThangNayIcon.ForeColor = System.Drawing.Color.FromArgb(139, 92, 246);
            this.lblThangNayIcon.Location = new System.Drawing.Point(12, 12);
            this.lblThangNayIcon.Name = "lblThangNayIcon";
            this.lblThangNayIcon.TabIndex = 0;
            this.lblThangNayIcon.Text = "%";

            this.lblThangNayTitle.AutoSize = true;
            this.lblThangNayTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblThangNayTitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblThangNayTitle.Location = new System.Drawing.Point(48, 14);
            this.lblThangNayTitle.Name = "lblThangNayTitle";
            this.lblThangNayTitle.TabIndex = 1;
            this.lblThangNayTitle.Text = "Thu Thang Nay";

            this.lblThangNayValue.AutoSize = false;
            this.lblThangNayValue.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblThangNayValue.ForeColor = System.Drawing.Color.White;
            this.lblThangNayValue.Location = new System.Drawing.Point(48, 36);
            this.lblThangNayValue.Name = "lblThangNayValue";
            this.lblThangNayValue.Size = new System.Drawing.Size(150, 26);
            this.lblThangNayValue.TabIndex = 2;
            this.lblThangNayValue.Text = "0 d";

            // =============================================================
            // pnlContent
            // =============================================================
            this.pnlContent.BackColor = System.Drawing.Color.Transparent;
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(20, 210);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1160, 520);
            this.pnlContent.TabIndex = 2;
            this.pnlContent.Controls.Add(this.pnlRight);
            this.pnlContent.Controls.Add(this.pnlLeft);

            // =============================================================
            // pnlLeft
            // =============================================================
            this.pnlLeft.BackColor = System.Drawing.Color.Transparent;
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.pnlLeft.Size = new System.Drawing.Size(320, 520);
            this.pnlLeft.TabIndex = 0;
            this.pnlLeft.Controls.Add(this.pnlForm);

            // =============================================================
            // pnlForm
            // =============================================================
            this.pnlForm.AutoScroll = true;
            this.pnlForm.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForm.Location = new System.Drawing.Point(0, 0);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(308, 520);
            this.pnlForm.TabIndex = 0;
            this.pnlForm.Controls.Add(this.pnlButtons);
            this.pnlForm.Controls.Add(this.cboTrangThai);
            this.pnlForm.Controls.Add(this.lblTrangThai);
            this.pnlForm.Controls.Add(this.txtGhiChu);
            this.pnlForm.Controls.Add(this.lblGhiChu);
            this.pnlForm.Controls.Add(this.txtMaPhieuThu);
            this.pnlForm.Controls.Add(this.lblMaPhieuThu);
            this.pnlForm.Controls.Add(this.cboPhuongThuc);
            this.pnlForm.Controls.Add(this.lblPhuongThuc);
            this.pnlForm.Controls.Add(this.dtNgayThanhToan);
            this.pnlForm.Controls.Add(this.lblNgayThanhToan);
            this.pnlForm.Controls.Add(this.txtSoTien);
            this.pnlForm.Controls.Add(this.lblSoTien);
            this.pnlForm.Controls.Add(this.txtCuDan);
            this.pnlForm.Controls.Add(this.lblCuDan);
            this.pnlForm.Controls.Add(this.txtCanHo);
            this.pnlForm.Controls.Add(this.lblCanHo);
            this.pnlForm.Controls.Add(this.cboHoaDon);
            this.pnlForm.Controls.Add(this.lblHoaDon);
            this.pnlForm.Controls.Add(this.lblFormTitle);

            // ---- lblFormTitle ----
            this.lblFormTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = System.Drawing.Color.White;
            this.lblFormTitle.Location = new System.Drawing.Point(0, 0);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(308, 36);
            this.lblFormTitle.TabIndex = 0;
            this.lblFormTitle.Text = "  Thong Tin Thanh Toan";
            this.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // ---- lblHoaDon ----
            this.lblHoaDon.AutoSize = true;
            this.lblHoaDon.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblHoaDon.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblHoaDon.Location = new System.Drawing.Point(12, 42);
            this.lblHoaDon.Name = "lblHoaDon";
            this.lblHoaDon.TabIndex = 1;
            this.lblHoaDon.Text = "Hoa Don *";

            // ---- cboHoaDon ----
            this.cboHoaDon.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.cboHoaDon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboHoaDon.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboHoaDon.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.cboHoaDon.Location = new System.Drawing.Point(12, 60);
            this.cboHoaDon.Name = "cboHoaDon";
            this.cboHoaDon.Size = new System.Drawing.Size(280, 24);
            this.cboHoaDon.TabIndex = 2;

            // ---- lblCanHo ----
            this.lblCanHo.AutoSize = true;
            this.lblCanHo.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblCanHo.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblCanHo.Location = new System.Drawing.Point(12, 96);
            this.lblCanHo.Name = "lblCanHo";
            this.lblCanHo.TabIndex = 3;
            this.lblCanHo.Text = "Can Ho";

            // ---- txtCanHo ----
            this.txtCanHo.BackColor = System.Drawing.Color.FromArgb(22, 33, 50);
            this.txtCanHo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCanHo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtCanHo.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.txtCanHo.Location = new System.Drawing.Point(12, 114);
            this.txtCanHo.Name = "txtCanHo";
            this.txtCanHo.ReadOnly = true;
            this.txtCanHo.Size = new System.Drawing.Size(280, 23);
            this.txtCanHo.TabIndex = 4;

            // ---- lblCuDan ----
            this.lblCuDan.AutoSize = true;
            this.lblCuDan.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblCuDan.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblCuDan.Location = new System.Drawing.Point(12, 149);
            this.lblCuDan.Name = "lblCuDan";
            this.lblCuDan.TabIndex = 5;
            this.lblCuDan.Text = "Cu Dan";

            // ---- txtCuDan ----
            this.txtCuDan.BackColor = System.Drawing.Color.FromArgb(22, 33, 50);
            this.txtCuDan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCuDan.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtCuDan.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.txtCuDan.Location = new System.Drawing.Point(12, 167);
            this.txtCuDan.Name = "txtCuDan";
            this.txtCuDan.ReadOnly = true;
            this.txtCuDan.Size = new System.Drawing.Size(280, 23);
            this.txtCuDan.TabIndex = 6;

            // ---- lblSoTien ----
            this.lblSoTien.AutoSize = true;
            this.lblSoTien.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSoTien.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblSoTien.Location = new System.Drawing.Point(12, 202);
            this.lblSoTien.Name = "lblSoTien";
            this.lblSoTien.TabIndex = 7;
            this.lblSoTien.Text = "So Tien *";

            // ---- txtSoTien ----
            this.txtSoTien.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.txtSoTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoTien.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtSoTien.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.txtSoTien.Location = new System.Drawing.Point(12, 220);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(280, 23);
            this.txtSoTien.TabIndex = 8;

            // ---- lblNgayThanhToan ----
            this.lblNgayThanhToan.AutoSize = true;
            this.lblNgayThanhToan.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblNgayThanhToan.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblNgayThanhToan.Location = new System.Drawing.Point(12, 255);
            this.lblNgayThanhToan.Name = "lblNgayThanhToan";
            this.lblNgayThanhToan.TabIndex = 9;
            this.lblNgayThanhToan.Text = "Ngay Thanh Toan *";

            // ---- dtNgayThanhToan ----
            this.dtNgayThanhToan.BackColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.dtNgayThanhToan.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtNgayThanhToan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayThanhToan.ForeColor = System.Drawing.Color.White;
            this.dtNgayThanhToan.Location = new System.Drawing.Point(12, 273);
            this.dtNgayThanhToan.Name = "dtNgayThanhToan";
            this.dtNgayThanhToan.Size = new System.Drawing.Size(280, 23);
            this.dtNgayThanhToan.TabIndex = 10;

            // ---- lblPhuongThuc ----
            this.lblPhuongThuc.AutoSize = true;
            this.lblPhuongThuc.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblPhuongThuc.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblPhuongThuc.Location = new System.Drawing.Point(12, 308);
            this.lblPhuongThuc.Name = "lblPhuongThuc";
            this.lblPhuongThuc.TabIndex = 11;
            this.lblPhuongThuc.Text = "Phuong Thuc *";

            // ---- cboPhuongThuc ----
            this.cboPhuongThuc.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.cboPhuongThuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhuongThuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboPhuongThuc.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboPhuongThuc.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.cboPhuongThuc.Items.AddRange(new object[] {
                "Tien mat",
                "Chuyen khoan",
                "Momo",
                "ZaloPay"});
            this.cboPhuongThuc.Location = new System.Drawing.Point(12, 326);
            this.cboPhuongThuc.Name = "cboPhuongThuc";
            this.cboPhuongThuc.Size = new System.Drawing.Size(280, 24);
            this.cboPhuongThuc.TabIndex = 12;

            // ---- lblMaPhieuThu ----
            this.lblMaPhieuThu.AutoSize = true;
            this.lblMaPhieuThu.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblMaPhieuThu.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblMaPhieuThu.Location = new System.Drawing.Point(12, 362);
            this.lblMaPhieuThu.Name = "lblMaPhieuThu";
            this.lblMaPhieuThu.TabIndex = 13;
            this.lblMaPhieuThu.Text = "Ma Phieu Thu";

            // ---- txtMaPhieuThu ----
            this.txtMaPhieuThu.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.txtMaPhieuThu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaPhieuThu.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtMaPhieuThu.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.txtMaPhieuThu.Location = new System.Drawing.Point(12, 380);
            this.txtMaPhieuThu.Name = "txtMaPhieuThu";
            this.txtMaPhieuThu.Size = new System.Drawing.Size(280, 23);
            this.txtMaPhieuThu.TabIndex = 14;

            // ---- lblGhiChu ----
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblGhiChu.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblGhiChu.Location = new System.Drawing.Point(12, 415);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.TabIndex = 15;
            this.lblGhiChu.Text = "Ghi Chu";

            // ---- txtGhiChu ----
            this.txtGhiChu.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.txtGhiChu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGhiChu.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtGhiChu.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.txtGhiChu.Location = new System.Drawing.Point(12, 433);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(280, 52);
            this.txtGhiChu.TabIndex = 16;

            // ---- lblTrangThai ----
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblTrangThai.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblTrangThai.Location = new System.Drawing.Point(12, 497);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.TabIndex = 17;
            this.lblTrangThai.Text = "Trang Thai";

            // ---- cboTrangThai ----
            this.cboTrangThai.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTrangThai.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboTrangThai.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.cboTrangThai.Items.AddRange(new object[] {
                "Thanh cong",
                "Dang xu ly",
                "That bai"});
            this.cboTrangThai.Location = new System.Drawing.Point(12, 515);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(280, 24);
            this.cboTrangThai.TabIndex = 18;

            // ---- pnlButtons ----
            this.pnlButtons.BackColor = System.Drawing.Color.Transparent;
            this.pnlButtons.Location = new System.Drawing.Point(12, 552);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(280, 80);
            this.pnlButtons.TabIndex = 19;
            this.pnlButtons.Controls.Add(this.btnLamMoi);
            this.pnlButtons.Controls.Add(this.btnXoa);
            this.pnlButtons.Controls.Add(this.btnSua);
            this.pnlButtons.Controls.Add(this.btnThem);

            // ---- btnThem ----
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(59, 130, 246);
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(0, 0);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(132, 34);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "+ Them";
            this.btnThem.UseVisualStyleBackColor = false;

            // ---- btnSua ----
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(144, 0);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(132, 34);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sua";
            this.btnSua.UseVisualStyleBackColor = false;

            // ---- btnXoa ----
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(0, 42);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(132, 34);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xoa";
            this.btnXoa.UseVisualStyleBackColor = false;

            // ---- btnLamMoi ----
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(144, 42);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(132, 34);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "Lam Moi";
            this.btnLamMoi.UseVisualStyleBackColor = false;

            // =============================================================
            // pnlRight
            // =============================================================
            this.pnlRight.BackColor = System.Drawing.Color.Transparent;
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(320, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(840, 520);
            this.pnlRight.TabIndex = 1;
            this.pnlRight.Controls.Add(this.dgvThanhToan);
            this.pnlRight.Controls.Add(this.pnlSearchBar);
            this.pnlRight.Controls.Add(this.lblGridTitle);

            // ---- lblGridTitle ----
            this.lblGridTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblGridTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblGridTitle.ForeColor = System.Drawing.Color.White;
            this.lblGridTitle.Location = new System.Drawing.Point(0, 0);
            this.lblGridTitle.Name = "lblGridTitle";
            this.lblGridTitle.Size = new System.Drawing.Size(840, 36);
            this.lblGridTitle.TabIndex = 0;
            this.lblGridTitle.Text = "  Danh Sach Thanh Toan";
            this.lblGridTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // ---- pnlSearchBar ----
            this.pnlSearchBar.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.pnlSearchBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearchBar.Location = new System.Drawing.Point(0, 36);
            this.pnlSearchBar.Name = "pnlSearchBar";
            this.pnlSearchBar.Size = new System.Drawing.Size(840, 40);
            this.pnlSearchBar.TabIndex = 1;
            this.pnlSearchBar.Controls.Add(this.txtSearch);
            this.pnlSearchBar.Controls.Add(this.lblSearchIcon);

            // ---- lblSearchIcon ----
            this.lblSearchIcon.AutoSize = true;
            this.lblSearchIcon.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSearchIcon.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblSearchIcon.Location = new System.Drawing.Point(8, 11);
            this.lblSearchIcon.Name = "lblSearchIcon";
            this.lblSearchIcon.TabIndex = 0;
            this.lblSearchIcon.Text = "S:";

            // ---- txtSearch ----
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.txtSearch.Location = new System.Drawing.Point(32, 11);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(500, 20);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.Text = "Tim kiem...";

            // =============================================================
            // dgvThanhToan
            // =============================================================
            this.dgvThanhToan.AllowUserToAddRows = false;
            this.dgvThanhToan.AllowUserToDeleteRows = false;
            this.dgvThanhToan.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(22, 33, 50);
            this.dgvThanhToan.AlternatingRowsDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.dgvThanhToan.AlternatingRowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(59, 130, 246);
            this.dgvThanhToan.AlternatingRowsDefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvThanhToan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThanhToan.BackgroundColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.dgvThanhToan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvThanhToan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvThanhToan.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.dgvThanhToan.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvThanhToan.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.dgvThanhToan.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.dgvThanhToan.ColumnHeadersDefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.dgvThanhToan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThanhToan.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.dgvThanhToan.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.dgvThanhToan.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(59, 130, 246);
            this.dgvThanhToan.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvThanhToan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThanhToan.EnableHeadersVisualStyles = false;
            this.dgvThanhToan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvThanhToan.GridColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.dgvThanhToan.Location = new System.Drawing.Point(0, 76);
            this.dgvThanhToan.MultiSelect = false;
            this.dgvThanhToan.Name = "dgvThanhToan";
            this.dgvThanhToan.ReadOnly = true;
            this.dgvThanhToan.RowHeadersVisible = false;
            this.dgvThanhToan.RowTemplate.Height = 36;
            this.dgvThanhToan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThanhToan.Size = new System.Drawing.Size(840, 444);
            this.dgvThanhToan.TabIndex = 2;

            // =============================================================
            // ucThanhToan
            // =============================================================
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "ucThanhToan";
            this.Size = new System.Drawing.Size(1200, 750);

            this.pnlMain.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlCards.ResumeLayout(false);
            this.cardTongThu.ResumeLayout(false);
            this.cardTongThu.PerformLayout();
            this.cardSoLuong.ResumeLayout(false);
            this.cardSoLuong.PerformLayout();
            this.cardHomNay.ResumeLayout(false);
            this.cardHomNay.PerformLayout();
            this.cardThangNay.ResumeLayout(false);
            this.cardThangNay.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            this.pnlSearchBar.ResumeLayout(false);
            this.pnlSearchBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhToan)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        // ── Control declarations ──────────────────────────────────────
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Panel pnlCards;
        private System.Windows.Forms.Panel cardTongThu;
        private System.Windows.Forms.Label lblTongThuIcon;
        private System.Windows.Forms.Label lblTongThuTitle;
        private System.Windows.Forms.Label lblTongThuValue;
        private System.Windows.Forms.Panel cardSoLuong;
        private System.Windows.Forms.Label lblSoLuongIcon;
        private System.Windows.Forms.Label lblSoLuongTitle;
        private System.Windows.Forms.Label lblSoLuongValue;
        private System.Windows.Forms.Panel cardHomNay;
        private System.Windows.Forms.Label lblHomNayIcon;
        private System.Windows.Forms.Label lblHomNayTitle;
        private System.Windows.Forms.Label lblHomNayValue;
        private System.Windows.Forms.Panel cardThangNay;
        private System.Windows.Forms.Label lblThangNayIcon;
        private System.Windows.Forms.Label lblThangNayTitle;
        private System.Windows.Forms.Label lblThangNayValue;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblHoaDon;
        public System.Windows.Forms.ComboBox cboHoaDon;
        private System.Windows.Forms.Label lblCanHo;
        private System.Windows.Forms.TextBox txtCanHo;
        private System.Windows.Forms.Label lblCuDan;
        private System.Windows.Forms.TextBox txtCuDan;
        private System.Windows.Forms.Label lblSoTien;
        public System.Windows.Forms.TextBox txtSoTien;
        private System.Windows.Forms.Label lblNgayThanhToan;
        public System.Windows.Forms.DateTimePicker dtNgayThanhToan;
        private System.Windows.Forms.Label lblPhuongThuc;
        public System.Windows.Forms.ComboBox cboPhuongThuc;
        private System.Windows.Forms.Label lblMaPhieuThu;
        public System.Windows.Forms.TextBox txtMaPhieuThu;
        private System.Windows.Forms.Label lblGhiChu;
        public System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label lblTrangThai;
        public System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Panel pnlButtons;
        public System.Windows.Forms.Button btnThem;
        public System.Windows.Forms.Button btnSua;
        public System.Windows.Forms.Button btnXoa;
        public System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label lblGridTitle;
        private System.Windows.Forms.Panel pnlSearchBar;
        private System.Windows.Forms.Label lblSearchIcon;
        public System.Windows.Forms.TextBox txtSearch;
        public System.Windows.Forms.DataGridView dgvThanhToan;
    }
}