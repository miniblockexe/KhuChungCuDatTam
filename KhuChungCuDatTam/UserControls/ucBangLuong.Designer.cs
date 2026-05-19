namespace KhuChungCuDatTam.UserControls
{
    partial class ucBangLuong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.dgvBangLuong = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNguoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThangNam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLuongCoBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKhauTru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTongLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTinhLuong = new System.Windows.Forms.Button();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.txtTongLuong = new System.Windows.Forms.TextBox();
            this.lblTongLuong = new System.Windows.Forms.Label();
            this.txtKhauTru = new System.Windows.Forms.TextBox();
            this.lblKhauTru = new System.Windows.Forms.Label();
            this.txtThuong = new System.Windows.Forms.TextBox();
            this.lblThuong = new System.Windows.Forms.Label();
            this.txtLuongCoBan = new System.Windows.Forms.TextBox();
            this.lblLuongCoBan = new System.Windows.Forms.Label();
            this.dtThangNam = new System.Windows.Forms.DateTimePicker();
            this.lblThangNam = new System.Windows.Forms.Label();
            this.cboNguoiDung = new System.Windows.Forms.ComboBox();
            this.lblNguoiDung = new System.Windows.Forms.Label();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.pnlStats = new System.Windows.Forms.Panel();
            this.cardTongLL = new System.Windows.Forms.Panel();
            this.lblTongLuongThucLinh = new System.Windows.Forms.Label();
            this.lblTongLLTitle = new System.Windows.Forms.Label();
            this.cardTongNV = new System.Windows.Forms.Panel();
            this.lblTongNhanVien = new System.Windows.Forms.Label();
            this.lblTongNVTitle = new System.Windows.Forms.Label();
            this.cardTongBL = new System.Windows.Forms.Panel();
            this.lblTongBangLuong = new System.Windows.Forms.Label();
            this.lblTongBLTitle = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangLuong)).BeginInit();
            this.pnlSearch.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlStats.SuspendLayout();
            this.cardTongLL.SuspendLayout();
            this.cardTongNV.SuspendLayout();
            this.cardTongBL.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.pnlMain.Controls.Add(this.pnlContent);
            this.pnlMain.Controls.Add(this.pnlStats);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(11);
            this.pnlMain.Size = new System.Drawing.Size(1257, 704);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.pnlContent.Controls.Add(this.pnlGrid);
            this.pnlContent.Controls.Add(this.pnlForm);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(11, 118);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1235, 575);
            this.pnlContent.TabIndex = 1;
            // 
            // pnlGrid
            // 
            this.pnlGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.pnlGrid.Controls.Add(this.dgvBangLuong);
            this.pnlGrid.Controls.Add(this.pnlSearch);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 0);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Padding = new System.Windows.Forms.Padding(9);
            this.pnlGrid.Size = new System.Drawing.Size(899, 575);
            this.pnlGrid.TabIndex = 0;
            // 
            // dgvBangLuong
            // 
            this.dgvBangLuong.AllowUserToAddRows = false;
            this.dgvBangLuong.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgvBangLuong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBangLuong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBangLuong.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.dgvBangLuong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBangLuong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBangLuong.ColumnHeadersHeight = 36;
            this.dgvBangLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBangLuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colNguoiDung,
            this.colThangNam,
            this.colLuongCoBan,
            this.colThuong,
            this.colKhauTru,
            this.colTongLuong,
            this.colTrangThai});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBangLuong.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvBangLuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBangLuong.EnableHeadersVisualStyles = false;
            this.dgvBangLuong.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.dgvBangLuong.Location = new System.Drawing.Point(9, 50);
            this.dgvBangLuong.MultiSelect = false;
            this.dgvBangLuong.Name = "dgvBangLuong";
            this.dgvBangLuong.ReadOnly = true;
            this.dgvBangLuong.RowHeadersVisible = false;
            this.dgvBangLuong.RowHeadersWidth = 51;
            this.dgvBangLuong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBangLuong.Size = new System.Drawing.Size(881, 516);
            this.dgvBangLuong.TabIndex = 1;
            this.dgvBangLuong.SelectionChanged += new System.EventHandler(this.dgvBangLuong_SelectionChanged);
            // 
            // colId
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colId.DefaultCellStyle = dataGridViewCellStyle3;
            this.colId.FillWeight = 5F;
            this.colId.HeaderText = "ID";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colNguoiDung
            // 
            this.colNguoiDung.FillWeight = 20F;
            this.colNguoiDung.HeaderText = "Nhân viên";
            this.colNguoiDung.MinimumWidth = 6;
            this.colNguoiDung.Name = "colNguoiDung";
            this.colNguoiDung.ReadOnly = true;
            // 
            // colThangNam
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colThangNam.DefaultCellStyle = dataGridViewCellStyle4;
            this.colThangNam.FillWeight = 10F;
            this.colThangNam.HeaderText = "Tháng/Năm";
            this.colThangNam.MinimumWidth = 6;
            this.colThangNam.Name = "colThangNam";
            this.colThangNam.ReadOnly = true;
            // 
            // colLuongCoBan
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colLuongCoBan.DefaultCellStyle = dataGridViewCellStyle5;
            this.colLuongCoBan.FillWeight = 14F;
            this.colLuongCoBan.HeaderText = "Lương cơ bản";
            this.colLuongCoBan.MinimumWidth = 6;
            this.colLuongCoBan.Name = "colLuongCoBan";
            this.colLuongCoBan.ReadOnly = true;
            // 
            // colThuong
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colThuong.DefaultCellStyle = dataGridViewCellStyle6;
            this.colThuong.FillWeight = 11F;
            this.colThuong.HeaderText = "Thưởng";
            this.colThuong.MinimumWidth = 6;
            this.colThuong.Name = "colThuong";
            this.colThuong.ReadOnly = true;
            // 
            // colKhauTru
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colKhauTru.DefaultCellStyle = dataGridViewCellStyle7;
            this.colKhauTru.FillWeight = 11F;
            this.colKhauTru.HeaderText = "Khấu trừ";
            this.colKhauTru.MinimumWidth = 6;
            this.colKhauTru.Name = "colKhauTru";
            this.colKhauTru.ReadOnly = true;
            // 
            // colTongLuong
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.colTongLuong.DefaultCellStyle = dataGridViewCellStyle8;
            this.colTongLuong.FillWeight = 15F;
            this.colTongLuong.HeaderText = "Tổng lương";
            this.colTongLuong.MinimumWidth = 6;
            this.colTongLuong.Name = "colTongLuong";
            this.colTongLuong.ReadOnly = true;
            // 
            // colTrangThai
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colTrangThai.DefaultCellStyle = dataGridViewCellStyle9;
            this.colTrangThai.FillWeight = 14F;
            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.MinimumWidth = 6;
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.ReadOnly = true;
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(9, 9);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(881, 41);
            this.pnlSearch.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.Location = new System.Drawing.Point(0, 0);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(881, 27);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // pnlForm
            // 
            this.pnlForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.pnlForm.Controls.Add(this.pnlButtons);
            this.pnlForm.Controls.Add(this.cboTrangThai);
            this.pnlForm.Controls.Add(this.lblTrangThai);
            this.pnlForm.Controls.Add(this.txtTongLuong);
            this.pnlForm.Controls.Add(this.lblTongLuong);
            this.pnlForm.Controls.Add(this.txtKhauTru);
            this.pnlForm.Controls.Add(this.lblKhauTru);
            this.pnlForm.Controls.Add(this.txtThuong);
            this.pnlForm.Controls.Add(this.lblThuong);
            this.pnlForm.Controls.Add(this.txtLuongCoBan);
            this.pnlForm.Controls.Add(this.lblLuongCoBan);
            this.pnlForm.Controls.Add(this.dtThangNam);
            this.pnlForm.Controls.Add(this.lblThangNam);
            this.pnlForm.Controls.Add(this.cboNguoiDung);
            this.pnlForm.Controls.Add(this.lblNguoiDung);
            this.pnlForm.Controls.Add(this.lblFormTitle);
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlForm.Location = new System.Drawing.Point(899, 0);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(336, 575);
            this.pnlForm.TabIndex = 1;
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.pnlButtons.Controls.Add(this.btnLamMoi);
            this.pnlButtons.Controls.Add(this.btnXoa);
            this.pnlButtons.Controls.Add(this.btnSua);
            this.pnlButtons.Controls.Add(this.btnThem);
            this.pnlButtons.Controls.Add(this.btnTinhLuong);
            this.pnlButtons.Location = new System.Drawing.Point(16, 444);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(295, 128);
            this.pnlButtons.TabIndex = 7;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(153, 85);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(142, 34);
            this.btnLamMoi.TabIndex = 4;
            this.btnLamMoi.Text = "↺  Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Enabled = false;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(0, 85);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(142, 34);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "🗑  Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.Enabled = false;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(153, 43);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(142, 34);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "✏  Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(0, 43);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(142, 34);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "＋ Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnTinhLuong
            // 
            this.btnTinhLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(58)))), ((int)(((byte)(237)))));
            this.btnTinhLuong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTinhLuong.FlatAppearance.BorderSize = 0;
            this.btnTinhLuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTinhLuong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTinhLuong.ForeColor = System.Drawing.Color.White;
            this.btnTinhLuong.Location = new System.Drawing.Point(0, 0);
            this.btnTinhLuong.Name = "btnTinhLuong";
            this.btnTinhLuong.Size = new System.Drawing.Size(295, 34);
            this.btnTinhLuong.TabIndex = 0;
            this.btnTinhLuong.Text = "⚡  Tính lương tự động";
            this.btnTinhLuong.UseVisualStyleBackColor = false;
            this.btnTinhLuong.Click += new System.EventHandler(this.btnTinhLuong_Click);
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTrangThai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboTrangThai.ForeColor = System.Drawing.Color.White;
            this.cboTrangThai.Location = new System.Drawing.Point(16, 405);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(294, 28);
            this.cboTrangThai.TabIndex = 6;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTrangThai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblTrangThai.Location = new System.Drawing.Point(16, 386);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(85, 20);
            this.lblTrangThai.TabIndex = 8;
            this.lblTrangThai.Text = "Trạng thái *";
            // 
            // txtTongLuong
            // 
            this.txtTongLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.txtTongLuong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTongLuong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtTongLuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.txtTongLuong.Location = new System.Drawing.Point(16, 350);
            this.txtTongLuong.Name = "txtTongLuong";
            this.txtTongLuong.ReadOnly = true;
            this.txtTongLuong.Size = new System.Drawing.Size(295, 27);
            this.txtTongLuong.TabIndex = 5;
            this.txtTongLuong.Text = "0";
            // 
            // lblTongLuong
            // 
            this.lblTongLuong.AutoSize = true;
            this.lblTongLuong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTongLuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblTongLuong.Location = new System.Drawing.Point(16, 331);
            this.lblTongLuong.Name = "lblTongLuong";
            this.lblTongLuong.Size = new System.Drawing.Size(86, 20);
            this.lblTongLuong.TabIndex = 9;
            this.lblTongLuong.Text = "Tổng lương";
            // 
            // txtKhauTru
            // 
            this.txtKhauTru.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtKhauTru.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKhauTru.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtKhauTru.ForeColor = System.Drawing.Color.White;
            this.txtKhauTru.Location = new System.Drawing.Point(16, 294);
            this.txtKhauTru.Name = "txtKhauTru";
            this.txtKhauTru.Size = new System.Drawing.Size(295, 27);
            this.txtKhauTru.TabIndex = 4;
            this.txtKhauTru.Text = "0";
            this.txtKhauTru.Leave += new System.EventHandler(this.txtLuong_Leave);
            // 
            // lblKhauTru
            // 
            this.lblKhauTru.AutoSize = true;
            this.lblKhauTru.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblKhauTru.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblKhauTru.Location = new System.Drawing.Point(16, 275);
            this.lblKhauTru.Name = "lblKhauTru";
            this.lblKhauTru.Size = new System.Drawing.Size(65, 20);
            this.lblKhauTru.TabIndex = 10;
            this.lblKhauTru.Text = "Khấu trừ";
            // 
            // txtThuong
            // 
            this.txtThuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtThuong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtThuong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtThuong.ForeColor = System.Drawing.Color.White;
            this.txtThuong.Location = new System.Drawing.Point(16, 239);
            this.txtThuong.Name = "txtThuong";
            this.txtThuong.Size = new System.Drawing.Size(295, 27);
            this.txtThuong.TabIndex = 3;
            this.txtThuong.Text = "0";
            this.txtThuong.Leave += new System.EventHandler(this.txtLuong_Leave);
            // 
            // lblThuong
            // 
            this.lblThuong.AutoSize = true;
            this.lblThuong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblThuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblThuong.Location = new System.Drawing.Point(16, 220);
            this.lblThuong.Name = "lblThuong";
            this.lblThuong.Size = new System.Drawing.Size(60, 20);
            this.lblThuong.TabIndex = 11;
            this.lblThuong.Text = "Thưởng";
            // 
            // txtLuongCoBan
            // 
            this.txtLuongCoBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtLuongCoBan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLuongCoBan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLuongCoBan.ForeColor = System.Drawing.Color.White;
            this.txtLuongCoBan.Location = new System.Drawing.Point(16, 183);
            this.txtLuongCoBan.Name = "txtLuongCoBan";
            this.txtLuongCoBan.Size = new System.Drawing.Size(295, 27);
            this.txtLuongCoBan.TabIndex = 2;
            this.txtLuongCoBan.Text = "0";
            this.txtLuongCoBan.Leave += new System.EventHandler(this.txtLuong_Leave);
            // 
            // lblLuongCoBan
            // 
            this.lblLuongCoBan.AutoSize = true;
            this.lblLuongCoBan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLuongCoBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblLuongCoBan.Location = new System.Drawing.Point(16, 164);
            this.lblLuongCoBan.Name = "lblLuongCoBan";
            this.lblLuongCoBan.Size = new System.Drawing.Size(110, 20);
            this.lblLuongCoBan.TabIndex = 12;
            this.lblLuongCoBan.Text = "Lương cơ bản *";
            // 
            // dtThangNam
            // 
            this.dtThangNam.CalendarForeColor = System.Drawing.Color.White;
            this.dtThangNam.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.dtThangNam.CustomFormat = "MM/yyyy";
            this.dtThangNam.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtThangNam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtThangNam.Location = new System.Drawing.Point(16, 128);
            this.dtThangNam.Name = "dtThangNam";
            this.dtThangNam.ShowUpDown = true;
            this.dtThangNam.Size = new System.Drawing.Size(294, 27);
            this.dtThangNam.TabIndex = 1;
            // 
            // lblThangNam
            // 
            this.lblThangNam.AutoSize = true;
            this.lblThangNam.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblThangNam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblThangNam.Location = new System.Drawing.Point(16, 109);
            this.lblThangNam.Name = "lblThangNam";
            this.lblThangNam.Size = new System.Drawing.Size(98, 20);
            this.lblThangNam.TabIndex = 13;
            this.lblThangNam.Text = "Tháng/Năm *";
            // 
            // cboNguoiDung
            // 
            this.cboNguoiDung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.cboNguoiDung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNguoiDung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboNguoiDung.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboNguoiDung.ForeColor = System.Drawing.Color.White;
            this.cboNguoiDung.Location = new System.Drawing.Point(16, 73);
            this.cboNguoiDung.Name = "cboNguoiDung";
            this.cboNguoiDung.Size = new System.Drawing.Size(294, 28);
            this.cboNguoiDung.TabIndex = 0;
            // 
            // lblNguoiDung
            // 
            this.lblNguoiDung.AutoSize = true;
            this.lblNguoiDung.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNguoiDung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblNguoiDung.Location = new System.Drawing.Point(16, 53);
            this.lblNguoiDung.Name = "lblNguoiDung";
            this.lblNguoiDung.Size = new System.Drawing.Size(85, 20);
            this.lblNguoiDung.TabIndex = 14;
            this.lblNguoiDung.Text = "Nhân viên *";
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.lblFormTitle.Location = new System.Drawing.Point(0, 0);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(336, 41);
            this.lblFormTitle.TabIndex = 15;
            this.lblFormTitle.Text = "  Thông tin bảng lương";
            this.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlStats
            // 
            this.pnlStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.pnlStats.Controls.Add(this.cardTongLL);
            this.pnlStats.Controls.Add(this.cardTongNV);
            this.pnlStats.Controls.Add(this.cardTongBL);
            this.pnlStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStats.Location = new System.Drawing.Point(11, 11);
            this.pnlStats.Name = "pnlStats";
            this.pnlStats.Size = new System.Drawing.Size(1235, 107);
            this.pnlStats.TabIndex = 0;
            // 
            // cardTongLL
            // 
            this.cardTongLL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.cardTongLL.Controls.Add(this.lblTongLuongThucLinh);
            this.cardTongLL.Controls.Add(this.lblTongLLTitle);
            this.cardTongLL.Location = new System.Drawing.Point(457, 0);
            this.cardTongLL.Name = "cardTongLL";
            this.cardTongLL.Size = new System.Drawing.Size(343, 87);
            this.cardTongLL.TabIndex = 2;
            // 
            // lblTongLuongThucLinh
            // 
            this.lblTongLuongThucLinh.AutoSize = true;
            this.lblTongLuongThucLinh.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTongLuongThucLinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.lblTongLuongThucLinh.Location = new System.Drawing.Point(16, 36);
            this.lblTongLuongThucLinh.Name = "lblTongLuongThucLinh";
            this.lblTongLuongThucLinh.Size = new System.Drawing.Size(51, 32);
            this.lblTongLuongThucLinh.TabIndex = 0;
            this.lblTongLuongThucLinh.Text = "0 ₫";
            // 
            // lblTongLLTitle
            // 
            this.lblTongLLTitle.AutoSize = true;
            this.lblTongLLTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTongLLTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblTongLLTitle.Location = new System.Drawing.Point(16, 11);
            this.lblTongLLTitle.Name = "lblTongLLTitle";
            this.lblTongLLTitle.Size = new System.Drawing.Size(147, 20);
            this.lblTongLLTitle.TabIndex = 1;
            this.lblTongLLTitle.Text = "Tổng lương thực lĩnh";
            // 
            // cardTongNV
            // 
            this.cardTongNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.cardTongNV.Controls.Add(this.lblTongNhanVien);
            this.cardTongNV.Controls.Add(this.lblTongNVTitle);
            this.cardTongNV.Location = new System.Drawing.Point(229, 0);
            this.cardTongNV.Name = "cardTongNV";
            this.cardTongNV.Size = new System.Drawing.Size(217, 87);
            this.cardTongNV.TabIndex = 1;
            // 
            // lblTongNhanVien
            // 
            this.lblTongNhanVien.AutoSize = true;
            this.lblTongNhanVien.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTongNhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.lblTongNhanVien.Location = new System.Drawing.Point(16, 36);
            this.lblTongNhanVien.Name = "lblTongNhanVien";
            this.lblTongNhanVien.Size = new System.Drawing.Size(35, 41);
            this.lblTongNhanVien.TabIndex = 0;
            this.lblTongNhanVien.Text = "0";
            // 
            // lblTongNVTitle
            // 
            this.lblTongNVTitle.AutoSize = true;
            this.lblTongNVTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTongNVTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblTongNVTitle.Location = new System.Drawing.Point(16, 11);
            this.lblTongNVTitle.Name = "lblTongNVTitle";
            this.lblTongNVTitle.Size = new System.Drawing.Size(75, 20);
            this.lblTongNVTitle.TabIndex = 1;
            this.lblTongNVTitle.Text = "Nhân viên";
            // 
            // cardTongBL
            // 
            this.cardTongBL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.cardTongBL.Controls.Add(this.lblTongBangLuong);
            this.cardTongBL.Controls.Add(this.lblTongBLTitle);
            this.cardTongBL.Location = new System.Drawing.Point(0, 0);
            this.cardTongBL.Name = "cardTongBL";
            this.cardTongBL.Size = new System.Drawing.Size(217, 87);
            this.cardTongBL.TabIndex = 0;
            // 
            // lblTongBangLuong
            // 
            this.lblTongBangLuong.AutoSize = true;
            this.lblTongBangLuong.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTongBangLuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.lblTongBangLuong.Location = new System.Drawing.Point(16, 36);
            this.lblTongBangLuong.Name = "lblTongBangLuong";
            this.lblTongBangLuong.Size = new System.Drawing.Size(35, 41);
            this.lblTongBangLuong.TabIndex = 0;
            this.lblTongBangLuong.Text = "0";
            // 
            // lblTongBLTitle
            // 
            this.lblTongBLTitle.AutoSize = true;
            this.lblTongBLTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTongBLTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblTongBLTitle.Location = new System.Drawing.Point(16, 11);
            this.lblTongBLTitle.Name = "lblTongBLTitle";
            this.lblTongBLTitle.Size = new System.Drawing.Size(124, 20);
            this.lblTongBLTitle.TabIndex = 1;
            this.lblTongBLTitle.Text = "Tổng bảng lương";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblSearch.Location = new System.Drawing.Point(4, 11);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(100, 23);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "🔍";
            // 
            // ucBangLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.Controls.Add(this.pnlMain);
            this.Name = "ucBangLuong";
            this.Size = new System.Drawing.Size(1257, 704);
            this.Load += new System.EventHandler(this.ucBangLuong_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangLuong)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.pnlStats.ResumeLayout(false);
            this.cardTongLL.ResumeLayout(false);
            this.cardTongLL.PerformLayout();
            this.cardTongNV.ResumeLayout(false);
            this.cardTongNV.PerformLayout();
            this.cardTongBL.ResumeLayout(false);
            this.cardTongBL.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        // ── Khai báo fields ───────────────────────────────────────────────
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlStats;
        private System.Windows.Forms.Panel cardTongBL;
        private System.Windows.Forms.Label lblTongBLTitle;
        private System.Windows.Forms.Label lblTongBangLuong;
        private System.Windows.Forms.Panel cardTongNV;
        private System.Windows.Forms.Label lblTongNVTitle;
        private System.Windows.Forms.Label lblTongNhanVien;
        private System.Windows.Forms.Panel cardTongLL;
        private System.Windows.Forms.Label lblTongLLTitle;
        private System.Windows.Forms.Label lblTongLuongThucLinh;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvBangLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNguoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThangNam;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLuongCoBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKhauTru;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTongLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblNguoiDung;
        private System.Windows.Forms.ComboBox cboNguoiDung;
        private System.Windows.Forms.Label lblThangNam;
        private System.Windows.Forms.DateTimePicker dtThangNam;
        private System.Windows.Forms.Label lblLuongCoBan;
        private System.Windows.Forms.TextBox txtLuongCoBan;
        private System.Windows.Forms.Label lblThuong;
        private System.Windows.Forms.TextBox txtThuong;
        private System.Windows.Forms.Label lblKhauTru;
        private System.Windows.Forms.TextBox txtKhauTru;
        private System.Windows.Forms.Label lblTongLuong;
        private System.Windows.Forms.TextBox txtTongLuong;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnTinhLuong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
    }
}