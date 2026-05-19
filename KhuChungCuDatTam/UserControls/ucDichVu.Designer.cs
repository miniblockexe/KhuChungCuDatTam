namespace KhuChungCuDatTam.UserControls
{
    partial class ucDichVu
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
            this.components = new System.ComponentModel.Container();

            // ── Khai báo tất cả controls ──────────────────
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();

            this.pnlCards = new System.Windows.Forms.Panel();

            this.pnlCardTong = new System.Windows.Forms.Panel();
            this.lblCardTongIcon = new System.Windows.Forms.Label();
            this.lblCardTongTitle = new System.Windows.Forms.Label();
            this.lblTongDichVu = new System.Windows.Forms.Label();

            this.pnlCardHD = new System.Windows.Forms.Panel();
            this.lblCardHDIcon = new System.Windows.Forms.Label();
            this.lblCardHDTitle = new System.Windows.Forms.Label();
            this.lblDangHoatDong = new System.Windows.Forms.Label();

            this.pnlCardTN = new System.Windows.Forms.Panel();
            this.lblCardTNIcon = new System.Windows.Forms.Label();
            this.lblCardTNTitle = new System.Windows.Forms.Label();
            this.lblTamNgung = new System.Windows.Forms.Label();

            this.pnlSearch = new System.Windows.Forms.Panel();
            this.lblSearchIcon = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();

            this.pnlBody = new System.Windows.Forms.Panel();

            this.pnlForm = new System.Windows.Forms.Panel();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.lblTenDichVu = new System.Windows.Forms.Label();
            this.txtTenDichVu = new System.Windows.Forms.TextBox();
            this.lblLoaiDichVu = new System.Windows.Forms.Label();
            this.cboLoaiDichVu = new System.Windows.Forms.ComboBox();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.txtMoTa = new System.Windows.Forms.TextBox();

            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();

            this.pnlGrid = new System.Windows.Forms.Panel();
            this.lblGridTitle = new System.Windows.Forms.Label();
            this.dgvDichVu = new System.Windows.Forms.DataGridView();

            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoaiDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();

            // ── Suspend ───────────────────────────────────
            this.pnlMain.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlCards.SuspendLayout();
            this.pnlCardTong.SuspendLayout();
            this.pnlCardHD.SuspendLayout();
            this.pnlCardTN.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).BeginInit();
            this.SuspendLayout();

            // ══════════════════════════════════════════════
            //  pnlMain
            // ══════════════════════════════════════════════
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Padding = new System.Windows.Forms.Padding(20, 16, 20, 16);
            this.pnlMain.Controls.Add(this.pnlBody);
            this.pnlMain.Controls.Add(this.pnlSearch);
            this.pnlMain.Controls.Add(this.pnlCards);
            this.pnlMain.Controls.Add(this.pnlHeader);

            // ══════════════════════════════════════════════
            //  pnlHeader
            // ══════════════════════════════════════════════
            this.pnlHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 68;
            this.pnlHeader.Controls.Add(this.lblSubTitle);
            this.pnlHeader.Controls.Add(this.lblTitle);

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Text = "Quản Lý Dịch Vụ";

            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblSubTitle.Location = new System.Drawing.Point(2, 40);
            this.lblSubTitle.Text = "Quản lý danh sách dịch vụ chung cư";

            // ══════════════════════════════════════════════
            //  pnlCards
            // ══════════════════════════════════════════════
            this.pnlCards.BackColor = System.Drawing.Color.Transparent;
            this.pnlCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCards.Height = 100;
            this.pnlCards.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.pnlCards.Controls.Add(this.pnlCardTN);
            this.pnlCards.Controls.Add(this.pnlCardHD);
            this.pnlCards.Controls.Add(this.pnlCardTong);

            // ── Card: Tổng ────────────────────────────────
            this.pnlCardTong.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.pnlCardTong.Location = new System.Drawing.Point(0, 6);
            this.pnlCardTong.Size = new System.Drawing.Size(200, 82);
            this.pnlCardTong.Controls.Add(this.lblTongDichVu);
            this.pnlCardTong.Controls.Add(this.lblCardTongTitle);
            this.pnlCardTong.Controls.Add(this.lblCardTongIcon);

            this.lblCardTongIcon.AutoSize = true;
            this.lblCardTongIcon.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblCardTongIcon.ForeColor = System.Drawing.Color.FromArgb(59, 130, 246);
            this.lblCardTongIcon.Location = new System.Drawing.Point(10, 16);
            this.lblCardTongIcon.Text = "●";

            this.lblCardTongTitle.AutoSize = true;
            this.lblCardTongTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblCardTongTitle.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblCardTongTitle.Location = new System.Drawing.Point(44, 12);
            this.lblCardTongTitle.Text = "Tổng Dịch Vụ";

            this.lblTongDichVu.AutoSize = true;
            this.lblTongDichVu.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTongDichVu.ForeColor = System.Drawing.Color.White;
            this.lblTongDichVu.Location = new System.Drawing.Point(42, 32);
            this.lblTongDichVu.Text = "0";

            // ── Card: Hoạt Động ───────────────────────────
            this.pnlCardHD.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.pnlCardHD.Location = new System.Drawing.Point(210, 6);
            this.pnlCardHD.Size = new System.Drawing.Size(200, 82);
            this.pnlCardHD.Controls.Add(this.lblDangHoatDong);
            this.pnlCardHD.Controls.Add(this.lblCardHDTitle);
            this.pnlCardHD.Controls.Add(this.lblCardHDIcon);

            this.lblCardHDIcon.AutoSize = true;
            this.lblCardHDIcon.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblCardHDIcon.ForeColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.lblCardHDIcon.Location = new System.Drawing.Point(10, 16);
            this.lblCardHDIcon.Text = "●";

            this.lblCardHDTitle.AutoSize = true;
            this.lblCardHDTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblCardHDTitle.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblCardHDTitle.Location = new System.Drawing.Point(44, 12);
            this.lblCardHDTitle.Text = "Đang Hoạt Động";

            this.lblDangHoatDong.AutoSize = true;
            this.lblDangHoatDong.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblDangHoatDong.ForeColor = System.Drawing.Color.White;
            this.lblDangHoatDong.Location = new System.Drawing.Point(42, 32);
            this.lblDangHoatDong.Text = "0";

            // ── Card: Tạm Ngưng ───────────────────────────
            this.pnlCardTN.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.pnlCardTN.Location = new System.Drawing.Point(420, 6);
            this.pnlCardTN.Size = new System.Drawing.Size(200, 82);
            this.pnlCardTN.Controls.Add(this.lblTamNgung);
            this.pnlCardTN.Controls.Add(this.lblCardTNTitle);
            this.pnlCardTN.Controls.Add(this.lblCardTNIcon);

            this.lblCardTNIcon.AutoSize = true;
            this.lblCardTNIcon.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblCardTNIcon.ForeColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.lblCardTNIcon.Location = new System.Drawing.Point(10, 16);
            this.lblCardTNIcon.Text = "●";

            this.lblCardTNTitle.AutoSize = true;
            this.lblCardTNTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblCardTNTitle.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblCardTNTitle.Location = new System.Drawing.Point(44, 12);
            this.lblCardTNTitle.Text = "Tạm Ngưng";

            this.lblTamNgung.AutoSize = true;
            this.lblTamNgung.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTamNgung.ForeColor = System.Drawing.Color.White;
            this.lblTamNgung.Location = new System.Drawing.Point(42, 32);
            this.lblTamNgung.Text = "0";

            // ══════════════════════════════════════════════
            //  pnlSearch
            // ══════════════════════════════════════════════
            this.pnlSearch.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Height = 46;
            this.pnlSearch.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Controls.Add(this.lblSearchIcon);

            this.lblSearchIcon.AutoSize = true;
            this.lblSearchIcon.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSearchIcon.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblSearchIcon.Location = new System.Drawing.Point(12, 11);
            this.lblSearchIcon.Text = "🔍";

            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.Location = new System.Drawing.Point(38, 12);
            this.txtSearch.Size = new System.Drawing.Size(400, 23);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);

            // ══════════════════════════════════════════════
            //  pnlBody
            // ══════════════════════════════════════════════
            this.pnlBody.BackColor = System.Drawing.Color.Transparent;
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.pnlBody.Controls.Add(this.pnlGrid);
            this.pnlBody.Controls.Add(this.pnlForm);

            // ══════════════════════════════════════════════
            //  pnlForm (bên trái – 300px)
            // ══════════════════════════════════════════════
            this.pnlForm.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlForm.Width = 300;
            this.pnlForm.Padding = new System.Windows.Forms.Padding(14, 10, 14, 10);
            // Add theo thứ tự ngược (Dock=Top stack từ dưới lên)
            this.pnlForm.Controls.Add(this.pnlButtons);
            this.pnlForm.Controls.Add(this.txtMoTa);
            this.pnlForm.Controls.Add(this.lblMoTa);
            this.pnlForm.Controls.Add(this.cboTrangThai);
            this.pnlForm.Controls.Add(this.lblTrangThai);
            this.pnlForm.Controls.Add(this.txtDonGia);
            this.pnlForm.Controls.Add(this.lblDonGia);
            this.pnlForm.Controls.Add(this.cboLoaiDichVu);
            this.pnlForm.Controls.Add(this.lblLoaiDichVu);
            this.pnlForm.Controls.Add(this.txtTenDichVu);
            this.pnlForm.Controls.Add(this.lblTenDichVu);
            this.pnlForm.Controls.Add(this.lblFormTitle);

            // lblFormTitle
            this.lblFormTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = System.Drawing.Color.White;
            this.lblFormTitle.Height = 38;
            this.lblFormTitle.Text = "Thông Tin Dịch Vụ";
            this.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // lblTenDichVu
            this.lblTenDichVu.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTenDichVu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTenDichVu.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblTenDichVu.Height = 22;
            this.lblTenDichVu.Text = "Tên Dịch Vụ *";

            // txtTenDichVu
            this.txtTenDichVu.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.txtTenDichVu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenDichVu.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTenDichVu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTenDichVu.ForeColor = System.Drawing.Color.White;
            this.txtTenDichVu.Height = 30;

            // lblLoaiDichVu
            this.lblLoaiDichVu.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLoaiDichVu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLoaiDichVu.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblLoaiDichVu.Height = 22;
            this.lblLoaiDichVu.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblLoaiDichVu.Text = "Loại Dịch Vụ *";

            // cboLoaiDichVu
            this.cboLoaiDichVu.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.cboLoaiDichVu.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboLoaiDichVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiDichVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboLoaiDichVu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboLoaiDichVu.ForeColor = System.Drawing.Color.White;

            // lblDonGia
            this.lblDonGia.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDonGia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDonGia.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblDonGia.Height = 22;
            this.lblDonGia.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblDonGia.Text = "Đơn Giá (VNĐ) *";

            // txtDonGia
            this.txtDonGia.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.txtDonGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDonGia.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDonGia.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDonGia.ForeColor = System.Drawing.Color.White;
            this.txtDonGia.Height = 30;
            this.txtDonGia.Leave += new System.EventHandler(this.txtDonGia_Leave);
            this.txtDonGia.Enter += new System.EventHandler(this.txtDonGia_Enter);

            // lblTrangThai
            this.lblTrangThai.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTrangThai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTrangThai.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblTrangThai.Height = 22;
            this.lblTrangThai.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblTrangThai.Text = "Trạng Thái *";

            // cboTrangThai
            this.cboTrangThai.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.cboTrangThai.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTrangThai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboTrangThai.ForeColor = System.Drawing.Color.White;

            // lblMoTa
            this.lblMoTa.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMoTa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMoTa.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblMoTa.Height = 22;
            this.lblMoTa.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblMoTa.Text = "Mô Tả";

            // txtMoTa
            this.txtMoTa.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.txtMoTa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMoTa.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtMoTa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMoTa.ForeColor = System.Drawing.Color.White;
            this.txtMoTa.Height = 70;
            this.txtMoTa.Multiline = true;
            this.txtMoTa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;

            // ── pnlButtons ────────────────────────────────
            this.pnlButtons.BackColor = System.Drawing.Color.Transparent;
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlButtons.Height = 44;
            this.pnlButtons.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.pnlButtons.Controls.Add(this.btnLamMoi);
            this.pnlButtons.Controls.Add(this.btnXoa);
            this.pnlButtons.Controls.Add(this.btnSua);
            this.pnlButtons.Controls.Add(this.btnThem);

            // btnThem
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(59, 130, 246);
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(0, 8);
            this.btnThem.Size = new System.Drawing.Size(60, 30);
            this.btnThem.Text = "+ Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            // btnSua
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(245, 158, 11);
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(64, 8);
            this.btnSua.Size = new System.Drawing.Size(56, 30);
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

            // btnXoa
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(124, 8);
            this.btnXoa.Size = new System.Drawing.Size(56, 30);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            // btnLamMoi
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(184, 8);
            this.btnLamMoi.Size = new System.Drawing.Size(72, 30);
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);

            // ══════════════════════════════════════════════
            //  pnlGrid (bên phải – Fill)
            // ══════════════════════════════════════════════
            this.pnlGrid.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Padding = new System.Windows.Forms.Padding(14, 10, 14, 14);
            this.pnlGrid.Controls.Add(this.dgvDichVu);
            this.pnlGrid.Controls.Add(this.lblGridTitle);

            this.lblGridTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblGridTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblGridTitle.ForeColor = System.Drawing.Color.White;
            this.lblGridTitle.Height = 38;
            this.lblGridTitle.Text = "Danh Sách Dịch Vụ";
            this.lblGridTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // ══════════════════════════════════════════════
            //  dgvDichVu
            // ══════════════════════════════════════════════
            this.dgvDichVu.AllowUserToAddRows = false;
            this.dgvDichVu.AllowUserToDeleteRows = false;
            this.dgvDichVu.AutoGenerateColumns = false;
            this.dgvDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDichVu.BackgroundColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.dgvDichVu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDichVu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDichVu.ColumnHeadersHeight = 38;
            this.dgvDichVu.EnableHeadersVisualStyles = false;
            this.dgvDichVu.GridColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.dgvDichVu.MultiSelect = false;
            this.dgvDichVu.ReadOnly = true;
            this.dgvDichVu.RowHeadersVisible = false;
            this.dgvDichVu.RowTemplate.Height = 36;
            this.dgvDichVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDichVu.Dock = System.Windows.Forms.DockStyle.Fill;

            // DefaultCellStyle
            this.dgvDichVu.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.dgvDichVu.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDichVu.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(59, 130, 246);
            this.dgvDichVu.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDichVu.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dgvDichVu.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);

            // AlternatingRowStyle
            this.dgvDichVu.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(20, 30, 48);

            // ColumnHeaderStyle
            this.dgvDichVu.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.dgvDichVu.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.dgvDichVu.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvDichVu.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(30, 41, 59);

            // ── Columns ───────────────────────────────────
            // colId (ẩn)
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            this.colId.Visible = false;

            // colTenDichVu
            this.colTenDichVu.DataPropertyName = "TenDichVu";
            this.colTenDichVu.HeaderText = "Tên Dịch Vụ";
            this.colTenDichVu.Name = "colTenDichVu";
            this.colTenDichVu.FillWeight = 28;

            // colLoaiDichVu
            this.colLoaiDichVu.DataPropertyName = "LoaiDichVu";
            this.colLoaiDichVu.HeaderText = "Loại";
            this.colLoaiDichVu.Name = "colLoaiDichVu";
            this.colLoaiDichVu.FillWeight = 15;

            // colDonGia
            this.colDonGia.DataPropertyName = "DonGia";
            this.colDonGia.HeaderText = "Đơn Giá (VNĐ)";
            this.colDonGia.Name = "colDonGia";
            this.colDonGia.FillWeight = 18;
            this.colDonGia.DefaultCellStyle.Format = "N0";
            this.colDonGia.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;

            // colMoTa
            this.colMoTa.DataPropertyName = "MoTa";
            this.colMoTa.HeaderText = "Mô Tả";
            this.colMoTa.Name = "colMoTa";
            this.colMoTa.FillWeight = 27;

            // colTrangThai
            this.colTrangThai.DataPropertyName = "TrangThai";
            this.colTrangThai.HeaderText = "Trạng Thái";
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.FillWeight = 12;
            this.colTrangThai.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;

            this.dgvDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
            {
                this.colId,
                this.colTenDichVu,
                this.colLoaiDichVu,
                this.colDonGia,
                this.colMoTa,
                this.colTrangThai
            });

            this.dgvDichVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDichVu_CellClick);

            // ══════════════════════════════════════════════
            //  ucDichVu root
            // ══════════════════════════════════════════════
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.Size = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.pnlMain);
            this.Load += new System.EventHandler(this.ucDichVu_Load);

            // ── Resume ────────────────────────────────────
            this.pnlButtons.ResumeLayout(false);
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.pnlGrid.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.pnlCardTong.ResumeLayout(false);
            this.pnlCardTong.PerformLayout();
            this.pnlCardHD.ResumeLayout(false);
            this.pnlCardHD.PerformLayout();
            this.pnlCardTN.ResumeLayout(false);
            this.pnlCardTN.PerformLayout();
            this.pnlCards.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        // ── Field declarations ────────────────────────────
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;

        private System.Windows.Forms.Panel pnlCards;
        private System.Windows.Forms.Panel pnlCardTong;
        private System.Windows.Forms.Label lblCardTongIcon;
        private System.Windows.Forms.Label lblCardTongTitle;
        private System.Windows.Forms.Label lblTongDichVu;

        private System.Windows.Forms.Panel pnlCardHD;
        private System.Windows.Forms.Label lblCardHDIcon;
        private System.Windows.Forms.Label lblCardHDTitle;
        private System.Windows.Forms.Label lblDangHoatDong;

        private System.Windows.Forms.Panel pnlCardTN;
        private System.Windows.Forms.Label lblCardTNIcon;
        private System.Windows.Forms.Label lblCardTNTitle;
        private System.Windows.Forms.Label lblTamNgung;

        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Label lblSearchIcon;
        private System.Windows.Forms.TextBox txtSearch;

        private System.Windows.Forms.Panel pnlBody;

        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblTenDichVu;
        private System.Windows.Forms.TextBox txtTenDichVu;
        private System.Windows.Forms.Label lblLoaiDichVu;
        private System.Windows.Forms.ComboBox cboLoaiDichVu;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.TextBox txtMoTa;

        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;

        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.Label lblGridTitle;
        private System.Windows.Forms.DataGridView dgvDichVu;

        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoaiDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMoTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
    }
}