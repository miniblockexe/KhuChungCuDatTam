namespace KhuChungCuDatTam.UserControls
{
    partial class ucCanHo
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
            // ── Khởi tạo cell-style objects ───────────────────────────────
            System.Windows.Forms.DataGridViewCellStyle headerStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle rowStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle altRowStyle = new System.Windows.Forms.DataGridViewCellStyle();

            // ── Khởi tạo tất cả control ───────────────────────────────────
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlFormCard = new System.Windows.Forms.Panel();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.lblSoCanHo = new System.Windows.Forms.Label();
            this.txtMaCan = new System.Windows.Forms.TextBox();
            this.lblTang = new System.Windows.Forms.Label();
            this.txtTang = new System.Windows.Forms.TextBox();
            this.lblDienTich = new System.Windows.Forms.Label();
            this.txtDienTich = new System.Windows.Forms.TextBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.lblToaNha = new System.Windows.Forms.Label();
            this.cboToaNha = new System.Windows.Forms.ComboBox();
            this.pnlBtnGroup = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlGridCard = new System.Windows.Forms.Panel();
            this.pnlSearchBar = new System.Windows.Forms.Panel();
            this.lblSearchIcon = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.dgvCanHo = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoCanHo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDienTich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colToaNha = new System.Windows.Forms.DataGridViewTextBoxColumn();

            // Suspend layout trong khi thiết lập
            this.pnlMain.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlFormCard.SuspendLayout();
            this.pnlBtnGroup.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlGridCard.SuspendLayout();
            this.pnlSearchBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCanHo)).BeginInit();
            this.SuspendLayout();

            // ────────────────────────────────────────────────────────────────
            //  SHARED COLORS / FONTS  (biến cục bộ, không phải method)
            // ────────────────────────────────────────────────────────────────
            System.Drawing.Color clrBg = System.Drawing.Color.FromArgb(15, 23, 42);
            System.Drawing.Color clrCard = System.Drawing.Color.FromArgb(30, 41, 59);
            System.Drawing.Color clrMuted = System.Drawing.Color.FromArgb(100, 116, 139);
            System.Drawing.Color clrLabelFg = System.Drawing.Color.FromArgb(148, 163, 184);
            System.Drawing.Color clrPrimary = System.Drawing.Color.FromArgb(59, 130, 246);
            System.Drawing.Color clrWhite = System.Drawing.Color.White;

            System.Drawing.Font fontLabel = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fontInput = new System.Drawing.Font("Segoe UI", 9.5F);
            System.Drawing.Font fontBtn = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);

            // ════════════════════════════════════════════════════════════════
            //  pnlMain
            // ════════════════════════════════════════════════════════════════
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.BackColor = clrBg;
            this.pnlMain.Padding = new System.Windows.Forms.Padding(20, 16, 20, 16);
            this.pnlMain.Controls.Add(this.pnlBody);
            this.pnlMain.Controls.Add(this.pnlHeader);

            // ════════════════════════════════════════════════════════════════
            //  pnlHeader
            // ════════════════════════════════════════════════════════════════
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 72;
            this.pnlHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(4, 0, 0, 10);
            this.pnlHeader.Controls.Add(this.lblSubTitle);
            this.pnlHeader.Controls.Add(this.lblTitle);

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(4, 4);
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = clrWhite;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Text = "Quản Lý Căn Hộ";

            // lblSubTitle
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Location = new System.Drawing.Point(8, 46);
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubTitle.ForeColor = clrMuted;
            this.lblSubTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSubTitle.Text = "Quản lý thông tin căn hộ trong khu chung cư";

            // ════════════════════════════════════════════════════════════════
            //  pnlBody
            // ════════════════════════════════════════════════════════════════
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.BackColor = System.Drawing.Color.Transparent;
            this.pnlBody.Controls.Add(this.pnlRight);
            this.pnlBody.Controls.Add(this.pnlLeft);

            // ════════════════════════════════════════════════════════════════
            //  pnlLeft  (form nhập liệu)
            // ════════════════════════════════════════════════════════════════
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Width = 312;
            this.pnlLeft.BackColor = System.Drawing.Color.Transparent;
            this.pnlLeft.Padding = new System.Windows.Forms.Padding(0, 0, 14, 0);
            this.pnlLeft.Controls.Add(this.pnlFormCard);

            // ── pnlFormCard ───────────────────────────────────────────────
            this.pnlFormCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormCard.BackColor = clrCard;
            this.pnlFormCard.Padding = new System.Windows.Forms.Padding(22, 18, 22, 18);
            this.pnlFormCard.Controls.Add(this.pnlBtnGroup);
            this.pnlFormCard.Controls.Add(this.cboToaNha);
            this.pnlFormCard.Controls.Add(this.lblToaNha);
            this.pnlFormCard.Controls.Add(this.cboTrangThai);
            this.pnlFormCard.Controls.Add(this.lblTrangThai);
            this.pnlFormCard.Controls.Add(this.txtDienTich);
            this.pnlFormCard.Controls.Add(this.lblDienTich);
            this.pnlFormCard.Controls.Add(this.txtTang);
            this.pnlFormCard.Controls.Add(this.lblTang);
            this.pnlFormCard.Controls.Add(this.txtMaCan);
            this.pnlFormCard.Controls.Add(this.lblSoCanHo);
            this.pnlFormCard.Controls.Add(this.lblFormTitle);

            // lblFormTitle
            this.lblFormTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFormTitle.Height = 38;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = clrPrimary;
            this.lblFormTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblFormTitle.Text = "✏  Thông Tin Căn Hộ";
            this.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // lblSoCanHo
            this.lblSoCanHo.AutoSize = true;
            this.lblSoCanHo.Location = new System.Drawing.Point(22, 58);
            this.lblSoCanHo.Font = fontLabel;
            this.lblSoCanHo.ForeColor = clrLabelFg;
            this.lblSoCanHo.BackColor = System.Drawing.Color.Transparent;
            this.lblSoCanHo.Text = "SỐ CĂN HỘ";

            // txtMaCan
            this.txtMaCan.Location = new System.Drawing.Point(22, 78);
            this.txtMaCan.Size = new System.Drawing.Size(262, 30);
            this.txtMaCan.Font = fontInput;
            this.txtMaCan.BackColor = clrBg;
            this.txtMaCan.ForeColor = clrWhite;
            this.txtMaCan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaCan.Name = "txtMaCan";

            // lblTang
            this.lblTang.AutoSize = true;
            this.lblTang.Location = new System.Drawing.Point(22, 122);
            this.lblTang.Font = fontLabel;
            this.lblTang.ForeColor = clrLabelFg;
            this.lblTang.BackColor = System.Drawing.Color.Transparent;
            this.lblTang.Text = "TẦNG";

            // txtTang
            this.txtTang.Location = new System.Drawing.Point(22, 142);
            this.txtTang.Size = new System.Drawing.Size(262, 30);
            this.txtTang.Font = fontInput;
            this.txtTang.BackColor = clrBg;
            this.txtTang.ForeColor = clrWhite;
            this.txtTang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTang.Name = "txtTang";

            // lblDienTich
            this.lblDienTich.AutoSize = true;
            this.lblDienTich.Location = new System.Drawing.Point(22, 186);
            this.lblDienTich.Font = fontLabel;
            this.lblDienTich.ForeColor = clrLabelFg;
            this.lblDienTich.BackColor = System.Drawing.Color.Transparent;
            this.lblDienTich.Text = "DIỆN TÍCH (m²)";

            // txtDienTich
            this.txtDienTich.Location = new System.Drawing.Point(22, 206);
            this.txtDienTich.Size = new System.Drawing.Size(262, 30);
            this.txtDienTich.Font = fontInput;
            this.txtDienTich.BackColor = clrBg;
            this.txtDienTich.ForeColor = clrWhite;
            this.txtDienTich.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDienTich.Name = "txtDienTich";

            // lblTrangThai
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Location = new System.Drawing.Point(22, 250);
            this.lblTrangThai.Font = fontLabel;
            this.lblTrangThai.ForeColor = clrLabelFg;
            this.lblTrangThai.BackColor = System.Drawing.Color.Transparent;
            this.lblTrangThai.Text = "TRẠNG THÁI";

            // cboTrangThai
            this.cboTrangThai.Location = new System.Drawing.Point(22, 270);
            this.cboTrangThai.Size = new System.Drawing.Size(262, 30);
            this.cboTrangThai.Font = fontInput;
            this.cboTrangThai.BackColor = clrBg;
            this.cboTrangThai.ForeColor = clrWhite;
            this.cboTrangThai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Items.AddRange(new object[] { "da_o", "da_cho_thue", "trong" });

            // lblToaNha
            this.lblToaNha.AutoSize = true;
            this.lblToaNha.Location = new System.Drawing.Point(22, 314);
            this.lblToaNha.Font = fontLabel;
            this.lblToaNha.ForeColor = clrLabelFg;
            this.lblToaNha.BackColor = System.Drawing.Color.Transparent;
            this.lblToaNha.Text = "TÒA NHÀ";

            // cboToaNha
            this.cboToaNha.Location = new System.Drawing.Point(22, 334);
            this.cboToaNha.Size = new System.Drawing.Size(262, 30);
            this.cboToaNha.Font = fontInput;
            this.cboToaNha.BackColor = clrBg;
            this.cboToaNha.ForeColor = clrWhite;
            this.cboToaNha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboToaNha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboToaNha.Name = "cboToaNha";

            // ── pnlBtnGroup ───────────────────────────────────────────────
            this.pnlBtnGroup.Location = new System.Drawing.Point(22, 382);
            this.pnlBtnGroup.Size = new System.Drawing.Size(262, 100);
            this.pnlBtnGroup.BackColor = System.Drawing.Color.Transparent;
            this.pnlBtnGroup.Controls.Add(this.btnThem);
            this.pnlBtnGroup.Controls.Add(this.btnSua);
            this.pnlBtnGroup.Controls.Add(this.btnXoa);
            this.pnlBtnGroup.Controls.Add(this.btnLamMoi);

            // btnThem
            this.btnThem.Location = new System.Drawing.Point(0, 0);
            this.btnThem.Size = new System.Drawing.Size(124, 40);
            this.btnThem.Font = fontBtn;
            this.btnThem.BackColor = clrPrimary;
            this.btnThem.ForeColor = clrWhite;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.Text = "➕  Thêm";
            this.btnThem.Name = "btnThem";
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            // btnSua
            this.btnSua.Location = new System.Drawing.Point(138, 0);
            this.btnSua.Size = new System.Drawing.Size(124, 40);
            this.btnSua.Font = fontBtn;
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.btnSua.ForeColor = clrWhite;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.Text = "✏  Sửa";
            this.btnSua.Name = "btnSua";
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

            // btnXoa
            this.btnXoa.Location = new System.Drawing.Point(0, 52);
            this.btnXoa.Size = new System.Drawing.Size(124, 40);
            this.btnXoa.Font = fontBtn;
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.btnXoa.ForeColor = clrWhite;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.Text = "🗑  Xóa";
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            // btnLamMoi
            this.btnLamMoi.Location = new System.Drawing.Point(138, 52);
            this.btnLamMoi.Size = new System.Drawing.Size(124, 40);
            this.btnLamMoi.Font = fontBtn;
            this.btnLamMoi.BackColor = clrMuted;
            this.btnLamMoi.ForeColor = clrWhite;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.Text = "🔄  Làm Mới";
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);

            // ════════════════════════════════════════════════════════════════
            //  pnlRight  (grid)
            // ════════════════════════════════════════════════════════════════
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.BackColor = System.Drawing.Color.Transparent;
            this.pnlRight.Controls.Add(this.pnlGridCard);

            // ── pnlGridCard ───────────────────────────────────────────────
            this.pnlGridCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGridCard.BackColor = clrCard;
            this.pnlGridCard.Padding = new System.Windows.Forms.Padding(16, 14, 16, 14);
            this.pnlGridCard.Controls.Add(this.dgvCanHo);
            this.pnlGridCard.Controls.Add(this.lblRecordCount);
            this.pnlGridCard.Controls.Add(this.pnlSearchBar);

            // ── pnlSearchBar ──────────────────────────────────────────────
            this.pnlSearchBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearchBar.Height = 46;
            this.pnlSearchBar.BackColor = System.Drawing.Color.Transparent;
            this.pnlSearchBar.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.pnlSearchBar.Controls.Add(this.txtSearch);
            this.pnlSearchBar.Controls.Add(this.lblSearchIcon);

            // lblSearchIcon
            this.lblSearchIcon.AutoSize = false;
            this.lblSearchIcon.Location = new System.Drawing.Point(0, 6);
            this.lblSearchIcon.Size = new System.Drawing.Size(34, 34);
            this.lblSearchIcon.Text = "🔍";
            this.lblSearchIcon.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblSearchIcon.ForeColor = clrMuted;
            this.lblSearchIcon.BackColor = System.Drawing.Color.Transparent;
            this.lblSearchIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // txtSearch
            this.txtSearch.Location = new System.Drawing.Point(36, 8);
            this.txtSearch.Size = new System.Drawing.Size(320, 30);
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtSearch.BackColor = clrBg;
            this.txtSearch.ForeColor = clrWhite;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);

            // ── lblRecordCount ────────────────────────────────────────────
            this.lblRecordCount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblRecordCount.Height = 24;
            this.lblRecordCount.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblRecordCount.ForeColor = clrMuted;
            this.lblRecordCount.BackColor = System.Drawing.Color.Transparent;
            this.lblRecordCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblRecordCount.Text = "0 căn hộ";

            // ════════════════════════════════════════════════════════════════
            //  dgvCanHo
            // ════════════════════════════════════════════════════════════════
            this.dgvCanHo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCanHo.BackgroundColor = clrBg;
            this.dgvCanHo.GridColor = clrCard;
            this.dgvCanHo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCanHo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCanHo.RowHeadersVisible = false;
            this.dgvCanHo.AllowUserToAddRows = false;
            this.dgvCanHo.AllowUserToDeleteRows = false;
            this.dgvCanHo.ReadOnly = true;
            this.dgvCanHo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCanHo.MultiSelect = false;
            this.dgvCanHo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCanHo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCanHo.ColumnHeadersHeight = 40;
            this.dgvCanHo.RowTemplate.Height = 36;
            this.dgvCanHo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvCanHo.Name = "dgvCanHo";

            // Header style
            headerStyle.BackColor = clrBg;
            headerStyle.ForeColor = clrLabelFg;
            headerStyle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            headerStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvCanHo.ColumnHeadersDefaultCellStyle = headerStyle;

            // Row style
            rowStyle.BackColor = clrBg;
            rowStyle.ForeColor = clrWhite;
            rowStyle.SelectionBackColor = clrPrimary;
            rowStyle.SelectionForeColor = clrWhite;
            this.dgvCanHo.DefaultCellStyle = rowStyle;

            // Alt row style
            altRowStyle.BackColor = System.Drawing.Color.FromArgb(20, 30, 50);
            altRowStyle.ForeColor = clrWhite;
            altRowStyle.SelectionBackColor = clrPrimary;
            altRowStyle.SelectionForeColor = clrWhite;
            this.dgvCanHo.AlternatingRowsDefaultCellStyle = altRowStyle;

            // ── Columns ───────────────────────────────────────────────────
            // colId (ẩn – dùng để lưu khóa chính)
            this.colId.Name = "colId";
            this.colId.HeaderText = "ID";
            this.colId.DataPropertyName = "id";
            this.colId.FillWeight = 40;
            this.colId.Visible = false;

            // colSoCanHo
            this.colSoCanHo.Name = "colSoCanHo";
            this.colSoCanHo.HeaderText = "Số Căn Hộ";
            this.colSoCanHo.DataPropertyName = "so_can_ho";
            this.colSoCanHo.FillWeight = 120;

            // colTang
            this.colTang.Name = "colTang";
            this.colTang.HeaderText = "Tầng";
            this.colTang.DataPropertyName = "tang";
            this.colTang.FillWeight = 60;

            // colDienTich
            this.colDienTich.Name = "colDienTich";
            this.colDienTich.HeaderText = "Diện Tích (m²)";
            this.colDienTich.DataPropertyName = "dien_tich";
            this.colDienTich.FillWeight = 100;

            // colTrangThai
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.HeaderText = "Trạng Thái";
            this.colTrangThai.DataPropertyName = "trang_thai";
            this.colTrangThai.FillWeight = 100;

            // colToaNha
            this.colToaNha.Name = "colToaNha";
            this.colToaNha.HeaderText = "Tòa Nhà";
            this.colToaNha.DataPropertyName = "ten_toa";
            this.colToaNha.FillWeight = 120;

            this.dgvCanHo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
            {
                this.colId,
                this.colSoCanHo,
                this.colTang,
                this.colDienTich,
                this.colTrangThai,
                this.colToaNha
            });

            this.dgvCanHo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCanHo_CellClick);

            // ════════════════════════════════════════════════════════════════
            //  UserControl root
            // ════════════════════════════════════════════════════════════════
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = clrBg;
            this.Controls.Add(this.pnlMain);
            this.Name = "ucCanHo";
            this.Size = new System.Drawing.Size(1100, 700);
            this.Load += new System.EventHandler(this.ucCanHo_Load);

            // Resume layout
            this.pnlSearchBar.ResumeLayout(false);
            this.pnlSearchBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCanHo)).EndInit();
            this.pnlGridCard.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.pnlBtnGroup.ResumeLayout(false);
            this.pnlFormCard.ResumeLayout(false);
            this.pnlFormCard.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        // ── Field declarations ────────────────────────────────────────────
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlFormCard;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblSoCanHo;
        private System.Windows.Forms.TextBox txtMaCan;
        private System.Windows.Forms.Label lblTang;
        private System.Windows.Forms.TextBox txtTang;
        private System.Windows.Forms.Label lblDienTich;
        private System.Windows.Forms.TextBox txtDienTich;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Label lblToaNha;
        private System.Windows.Forms.ComboBox cboToaNha;
        private System.Windows.Forms.Panel pnlBtnGroup;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlGridCard;
        private System.Windows.Forms.Panel pnlSearchBar;
        private System.Windows.Forms.Label lblSearchIcon;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.DataGridView dgvCanHo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoCanHo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDienTich;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colToaNha;
    }
}