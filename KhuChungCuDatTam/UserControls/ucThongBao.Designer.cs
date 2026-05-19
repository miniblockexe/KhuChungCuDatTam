namespace KhuChungCuDatTam.UserControls
{
    partial class ucThongBao
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.dgvThongBao = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTieuDe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDoiTuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayGui = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pnlSpacer = new System.Windows.Forms.Panel();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.btnGuiThongBao = new System.Windows.Forms.Button();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.lblNoiDung = new System.Windows.Forms.Label();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.dtNgayTao = new System.Windows.Forms.DateTimePicker();
            this.lblNgayTao = new System.Windows.Forms.Label();
            this.cboDoiTuongGui = new System.Windows.Forms.ComboBox();
            this.lblDoiTuong = new System.Windows.Forms.Label();
            this.cboLoaiThongBao = new System.Windows.Forms.ComboBox();
            this.lblLoai = new System.Windows.Forms.Label();
            this.txtTieuDe = new System.Windows.Forms.TextBox();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.pnlCards = new System.Windows.Forms.Panel();
            this.pnlCardTong = new System.Windows.Forms.Panel();
            this.lblTitleTong = new System.Windows.Forms.Label();
            this.lblTongThongBao = new System.Windows.Forms.Label();
            this.pnlCardDaGui = new System.Windows.Forms.Panel();
            this.lblTitleDaGui = new System.Windows.Forms.Label();
            this.lblDaGui = new System.Windows.Forms.Label();
            this.pnlCardNhap = new System.Windows.Forms.Panel();
            this.lblTitleNhap = new System.Windows.Forms.Label();
            this.lblNhap = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblSubHeader = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongBao)).BeginInit();
            this.pnlSearch.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlCards.SuspendLayout();
            this.pnlCardTong.SuspendLayout();
            this.pnlCardDaGui.SuspendLayout();
            this.pnlCardNhap.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.pnlMain.Controls.Add(this.pnlContent);
            this.pnlMain.Controls.Add(this.pnlCards);
            this.pnlMain.Controls.Add(this.pnlHeader);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(18, 17, 18, 17);
            this.pnlMain.Size = new System.Drawing.Size(1257, 747);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.pnlContent.Controls.Add(this.pnlGrid);
            this.pnlContent.Controls.Add(this.pnlSpacer);
            this.pnlContent.Controls.Add(this.pnlForm);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(18, 199);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1221, 531);
            this.pnlContent.TabIndex = 0;
            // 
            // pnlGrid
            // 
            this.pnlGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.pnlGrid.Controls.Add(this.dgvThongBao);
            this.pnlGrid.Controls.Add(this.pnlSearch);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(377, 0);
            this.pnlGrid.Margin = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Padding = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.pnlGrid.Size = new System.Drawing.Size(844, 531);
            this.pnlGrid.TabIndex = 0;
            // 
            // dgvThongBao
            // 
            this.dgvThongBao.AllowUserToAddRows = false;
            this.dgvThongBao.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvThongBao.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvThongBao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongBao.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.dgvThongBao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvThongBao.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThongBao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvThongBao.ColumnHeadersHeight = 36;
            this.dgvThongBao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvThongBao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colTieuDe,
            this.colLoai,
            this.colDoiTuong,
            this.colNgayGui,
            this.colTrangThai});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvThongBao.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvThongBao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThongBao.EnableHeadersVisualStyles = false;
            this.dgvThongBao.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.dgvThongBao.Location = new System.Drawing.Point(14, 60);
            this.dgvThongBao.MultiSelect = false;
            this.dgvThongBao.Name = "dgvThongBao";
            this.dgvThongBao.ReadOnly = true;
            this.dgvThongBao.RowHeadersVisible = false;
            this.dgvThongBao.RowHeadersWidth = 51;
            this.dgvThongBao.RowTemplate.Height = 36;
            this.dgvThongBao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThongBao.Size = new System.Drawing.Size(816, 458);
            this.dgvThongBao.TabIndex = 0;
            this.dgvThongBao.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongBao_CellClick);
            // 
            // colId
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colId.DefaultCellStyle = dataGridViewCellStyle3;
            this.colId.FillWeight = 5F;
            this.colId.HeaderText = "ID";
            this.colId.MinimumWidth = 40;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colTieuDe
            // 
            this.colTieuDe.FillWeight = 30F;
            this.colTieuDe.HeaderText = "Tiêu Đề";
            this.colTieuDe.MinimumWidth = 120;
            this.colTieuDe.Name = "colTieuDe";
            this.colTieuDe.ReadOnly = true;
            // 
            // colLoai
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colLoai.DefaultCellStyle = dataGridViewCellStyle4;
            this.colLoai.FillWeight = 15F;
            this.colLoai.HeaderText = "Loại";
            this.colLoai.MinimumWidth = 80;
            this.colLoai.Name = "colLoai";
            this.colLoai.ReadOnly = true;
            // 
            // colDoiTuong
            // 
            this.colDoiTuong.FillWeight = 18F;
            this.colDoiTuong.HeaderText = "Đối Tượng";
            this.colDoiTuong.MinimumWidth = 90;
            this.colDoiTuong.Name = "colDoiTuong";
            this.colDoiTuong.ReadOnly = true;
            // 
            // colNgayGui
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colNgayGui.DefaultCellStyle = dataGridViewCellStyle5;
            this.colNgayGui.FillWeight = 18F;
            this.colNgayGui.HeaderText = "Ngày Gửi";
            this.colNgayGui.MinimumWidth = 120;
            this.colNgayGui.Name = "colNgayGui";
            this.colNgayGui.ReadOnly = true;
            // 
            // colTrangThai
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colTrangThai.DefaultCellStyle = dataGridViewCellStyle6;
            this.colTrangThai.FillWeight = 14F;
            this.colTrangThai.HeaderText = "Trạng Thái";
            this.colTrangThai.MinimumWidth = 80;
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.ReadOnly = true;
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.pnlSearch.Controls.Add(this.lblSearch);
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(14, 13);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(816, 47);
            this.pnlSearch.TabIndex = 1;
            // 
            // lblSearch
            // 
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblSearch.Location = new System.Drawing.Point(0, 7);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(27, 32);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "🔍";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.Location = new System.Drawing.Point(32, 7);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(297, 27);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // pnlSpacer
            // 
            this.pnlSpacer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.pnlSpacer.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSpacer.Location = new System.Drawing.Point(366, 0);
            this.pnlSpacer.Name = "pnlSpacer";
            this.pnlSpacer.Size = new System.Drawing.Size(11, 531);
            this.pnlSpacer.TabIndex = 1;
            // 
            // pnlForm
            // 
            this.pnlForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.pnlForm.Controls.Add(this.btnGuiThongBao);
            this.pnlForm.Controls.Add(this.pnlButtons);
            this.pnlForm.Controls.Add(this.txtNoiDung);
            this.pnlForm.Controls.Add(this.lblNoiDung);
            this.pnlForm.Controls.Add(this.cboTrangThai);
            this.pnlForm.Controls.Add(this.lblTrangThai);
            this.pnlForm.Controls.Add(this.dtNgayTao);
            this.pnlForm.Controls.Add(this.lblNgayTao);
            this.pnlForm.Controls.Add(this.cboDoiTuongGui);
            this.pnlForm.Controls.Add(this.lblDoiTuong);
            this.pnlForm.Controls.Add(this.cboLoaiThongBao);
            this.pnlForm.Controls.Add(this.lblLoai);
            this.pnlForm.Controls.Add(this.txtTieuDe);
            this.pnlForm.Controls.Add(this.lblTieuDe);
            this.pnlForm.Controls.Add(this.lblFormTitle);
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlForm.Location = new System.Drawing.Point(0, 0);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Padding = new System.Windows.Forms.Padding(18, 17, 18, 17);
            this.pnlForm.Size = new System.Drawing.Size(366, 531);
            this.pnlForm.TabIndex = 2;
            // 
            // btnGuiThongBao
            // 
            this.btnGuiThongBao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.btnGuiThongBao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuiThongBao.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnGuiThongBao.Enabled = false;
            this.btnGuiThongBao.FlatAppearance.BorderSize = 0;
            this.btnGuiThongBao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuiThongBao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnGuiThongBao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnGuiThongBao.Location = new System.Drawing.Point(18, 471);
            this.btnGuiThongBao.Name = "btnGuiThongBao";
            this.btnGuiThongBao.Size = new System.Drawing.Size(330, 43);
            this.btnGuiThongBao.TabIndex = 0;
            this.btnGuiThongBao.Text = "📤  Gửi Thông Báo Đến Cư Dân";
            this.btnGuiThongBao.UseVisualStyleBackColor = false;
            this.btnGuiThongBao.Click += new System.EventHandler(this.btnGuiThongBao_Click);
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.pnlButtons.Controls.Add(this.btnThem);
            this.pnlButtons.Controls.Add(this.btnSua);
            this.pnlButtons.Controls.Add(this.btnXoa);
            this.pnlButtons.Controls.Add(this.btnLamMoi);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlButtons.Location = new System.Drawing.Point(18, 436);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(330, 45);
            this.pnlButtons.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(0, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(91, 36);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "➕ Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(179)))), ((int)(((byte)(8)))));
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.Enabled = false;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnSua.Location = new System.Drawing.Point(96, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(85, 36);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "✏ Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Enabled = false;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(185, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(85, 36);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "🗑 Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(274, 4);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(46, 36);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "🔄";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtNoiDung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNoiDung.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtNoiDung.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNoiDung.ForeColor = System.Drawing.Color.White;
            this.txtNoiDung.Location = new System.Drawing.Point(18, 340);
            this.txtNoiDung.Multiline = true;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNoiDung.Size = new System.Drawing.Size(330, 96);
            this.txtNoiDung.TabIndex = 2;
            // 
            // lblNoiDung
            // 
            this.lblNoiDung.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNoiDung.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNoiDung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblNoiDung.Location = new System.Drawing.Point(18, 314);
            this.lblNoiDung.Name = "lblNoiDung";
            this.lblNoiDung.Size = new System.Drawing.Size(330, 26);
            this.lblNoiDung.TabIndex = 3;
            this.lblNoiDung.Text = "Nội Dung *";
            this.lblNoiDung.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.cboTrangThai.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTrangThai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboTrangThai.ForeColor = System.Drawing.Color.White;
            this.cboTrangThai.Location = new System.Drawing.Point(18, 286);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(330, 28);
            this.cboTrangThai.TabIndex = 4;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTrangThai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTrangThai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblTrangThai.Location = new System.Drawing.Point(18, 260);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(330, 26);
            this.lblTrangThai.TabIndex = 5;
            this.lblTrangThai.Text = "Trạng Thái";
            this.lblTrangThai.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // dtNgayTao
            // 
            this.dtNgayTao.CalendarForeColor = System.Drawing.Color.White;
            this.dtNgayTao.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.dtNgayTao.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.dtNgayTao.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dtNgayTao.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtNgayTao.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtNgayTao.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtNgayTao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayTao.Location = new System.Drawing.Point(18, 233);
            this.dtNgayTao.Name = "dtNgayTao";
            this.dtNgayTao.Size = new System.Drawing.Size(330, 27);
            this.dtNgayTao.TabIndex = 6;
            this.dtNgayTao.Value = new System.DateTime(2026, 5, 14, 10, 49, 18, 478);
            // 
            // lblNgayTao
            // 
            this.lblNgayTao.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNgayTao.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNgayTao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblNgayTao.Location = new System.Drawing.Point(18, 207);
            this.lblNgayTao.Name = "lblNgayTao";
            this.lblNgayTao.Size = new System.Drawing.Size(330, 26);
            this.lblNgayTao.TabIndex = 7;
            this.lblNgayTao.Text = "Ngày Tạo";
            this.lblNgayTao.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cboDoiTuongGui
            // 
            this.cboDoiTuongGui.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.cboDoiTuongGui.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboDoiTuongGui.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDoiTuongGui.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboDoiTuongGui.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboDoiTuongGui.ForeColor = System.Drawing.Color.White;
            this.cboDoiTuongGui.Location = new System.Drawing.Point(18, 179);
            this.cboDoiTuongGui.Name = "cboDoiTuongGui";
            this.cboDoiTuongGui.Size = new System.Drawing.Size(330, 28);
            this.cboDoiTuongGui.TabIndex = 8;
            // 
            // lblDoiTuong
            // 
            this.lblDoiTuong.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDoiTuong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDoiTuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblDoiTuong.Location = new System.Drawing.Point(18, 153);
            this.lblDoiTuong.Name = "lblDoiTuong";
            this.lblDoiTuong.Size = new System.Drawing.Size(330, 26);
            this.lblDoiTuong.TabIndex = 9;
            this.lblDoiTuong.Text = "Đối Tượng Gửi *";
            this.lblDoiTuong.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cboLoaiThongBao
            // 
            this.cboLoaiThongBao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.cboLoaiThongBao.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboLoaiThongBao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiThongBao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboLoaiThongBao.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboLoaiThongBao.ForeColor = System.Drawing.Color.White;
            this.cboLoaiThongBao.Location = new System.Drawing.Point(18, 125);
            this.cboLoaiThongBao.Name = "cboLoaiThongBao";
            this.cboLoaiThongBao.Size = new System.Drawing.Size(330, 28);
            this.cboLoaiThongBao.TabIndex = 10;
            // 
            // lblLoai
            // 
            this.lblLoai.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLoai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblLoai.Location = new System.Drawing.Point(18, 99);
            this.lblLoai.Name = "lblLoai";
            this.lblLoai.Size = new System.Drawing.Size(330, 26);
            this.lblLoai.TabIndex = 11;
            this.lblLoai.Text = "Loại Thông Báo *";
            this.lblLoai.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtTieuDe
            // 
            this.txtTieuDe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtTieuDe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTieuDe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTieuDe.ForeColor = System.Drawing.Color.White;
            this.txtTieuDe.Location = new System.Drawing.Point(18, 72);
            this.txtTieuDe.Name = "txtTieuDe";
            this.txtTieuDe.Size = new System.Drawing.Size(330, 27);
            this.txtTieuDe.TabIndex = 12;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblTieuDe.Location = new System.Drawing.Point(18, 49);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(330, 23);
            this.lblTieuDe.TabIndex = 13;
            this.lblTieuDe.Text = "Tiêu Đề *";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = System.Drawing.Color.White;
            this.lblFormTitle.Location = new System.Drawing.Point(18, 17);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(330, 32);
            this.lblFormTitle.TabIndex = 14;
            this.lblFormTitle.Text = "Nhập Thông Tin";
            this.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlCards
            // 
            this.pnlCards.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.pnlCards.Controls.Add(this.pnlCardTong);
            this.pnlCards.Controls.Add(this.pnlCardDaGui);
            this.pnlCards.Controls.Add(this.pnlCardNhap);
            this.pnlCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCards.Location = new System.Drawing.Point(18, 92);
            this.pnlCards.Name = "pnlCards";
            this.pnlCards.Padding = new System.Windows.Forms.Padding(0, 4, 0, 9);
            this.pnlCards.Size = new System.Drawing.Size(1221, 107);
            this.pnlCards.TabIndex = 1;
            // 
            // pnlCardTong
            // 
            this.pnlCardTong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.pnlCardTong.Controls.Add(this.lblTitleTong);
            this.pnlCardTong.Controls.Add(this.lblTongThongBao);
            this.pnlCardTong.Location = new System.Drawing.Point(0, 4);
            this.pnlCardTong.Name = "pnlCardTong";
            this.pnlCardTong.Padding = new System.Windows.Forms.Padding(16, 11, 16, 11);
            this.pnlCardTong.Size = new System.Drawing.Size(206, 90);
            this.pnlCardTong.TabIndex = 0;
            // 
            // lblTitleTong
            // 
            this.lblTitleTong.AutoSize = true;
            this.lblTitleTong.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblTitleTong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblTitleTong.Location = new System.Drawing.Point(16, 11);
            this.lblTitleTong.Name = "lblTitleTong";
            this.lblTitleTong.Size = new System.Drawing.Size(131, 19);
            this.lblTitleTong.TabIndex = 0;
            this.lblTitleTong.Text = "TỔNG THÔNG BÁO";
            // 
            // lblTongThongBao
            // 
            this.lblTongThongBao.AutoSize = true;
            this.lblTongThongBao.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTongThongBao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.lblTongThongBao.Location = new System.Drawing.Point(16, 32);
            this.lblTongThongBao.Name = "lblTongThongBao";
            this.lblTongThongBao.Size = new System.Drawing.Size(43, 50);
            this.lblTongThongBao.TabIndex = 1;
            this.lblTongThongBao.Text = "0";
            // 
            // pnlCardDaGui
            // 
            this.pnlCardDaGui.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.pnlCardDaGui.Controls.Add(this.lblTitleDaGui);
            this.pnlCardDaGui.Controls.Add(this.lblDaGui);
            this.pnlCardDaGui.Location = new System.Drawing.Point(219, 4);
            this.pnlCardDaGui.Name = "pnlCardDaGui";
            this.pnlCardDaGui.Padding = new System.Windows.Forms.Padding(16, 11, 16, 11);
            this.pnlCardDaGui.Size = new System.Drawing.Size(206, 90);
            this.pnlCardDaGui.TabIndex = 1;
            // 
            // lblTitleDaGui
            // 
            this.lblTitleDaGui.AutoSize = true;
            this.lblTitleDaGui.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblTitleDaGui.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblTitleDaGui.Location = new System.Drawing.Point(16, 11);
            this.lblTitleDaGui.Name = "lblTitleDaGui";
            this.lblTitleDaGui.Size = new System.Drawing.Size(56, 19);
            this.lblTitleDaGui.TabIndex = 0;
            this.lblTitleDaGui.Text = "ĐÃ GỬI";
            // 
            // lblDaGui
            // 
            this.lblDaGui.AutoSize = true;
            this.lblDaGui.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblDaGui.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.lblDaGui.Location = new System.Drawing.Point(16, 32);
            this.lblDaGui.Name = "lblDaGui";
            this.lblDaGui.Size = new System.Drawing.Size(43, 50);
            this.lblDaGui.TabIndex = 1;
            this.lblDaGui.Text = "0";
            // 
            // pnlCardNhap
            // 
            this.pnlCardNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.pnlCardNhap.Controls.Add(this.lblTitleNhap);
            this.pnlCardNhap.Controls.Add(this.lblNhap);
            this.pnlCardNhap.Location = new System.Drawing.Point(439, 4);
            this.pnlCardNhap.Name = "pnlCardNhap";
            this.pnlCardNhap.Padding = new System.Windows.Forms.Padding(16, 11, 16, 11);
            this.pnlCardNhap.Size = new System.Drawing.Size(206, 90);
            this.pnlCardNhap.TabIndex = 2;
            // 
            // lblTitleNhap
            // 
            this.lblTitleNhap.AutoSize = true;
            this.lblTitleNhap.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblTitleNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblTitleNhap.Location = new System.Drawing.Point(16, 11);
            this.lblTitleNhap.Name = "lblTitleNhap";
            this.lblTitleNhap.Size = new System.Drawing.Size(46, 19);
            this.lblTitleNhap.TabIndex = 0;
            this.lblTitleNhap.Text = "NHÁP";
            // 
            // lblNhap
            // 
            this.lblNhap.AutoSize = true;
            this.lblNhap.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(179)))), ((int)(((byte)(8)))));
            this.lblNhap.Location = new System.Drawing.Point(16, 32);
            this.lblNhap.Name = "lblNhap";
            this.lblNhap.Size = new System.Drawing.Size(43, 50);
            this.lblNhap.TabIndex = 1;
            this.lblNhap.Text = "0";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Controls.Add(this.lblSubHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(18, 17);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(5, 0, 5, 9);
            this.pnlHeader.Size = new System.Drawing.Size(1221, 75);
            this.pnlHeader.TabIndex = 2;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(5, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(213, 30);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Quản Lý Thông Báo";
            // 
            // lblSubHeader
            // 
            this.lblSubHeader.AutoSize = true;
            this.lblSubHeader.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSubHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblSubHeader.Location = new System.Drawing.Point(7, 41);
            this.lblSubHeader.Name = "lblSubHeader";
            this.lblSubHeader.Size = new System.Drawing.Size(337, 19);
            this.lblSubHeader.TabIndex = 1;
            this.lblSubHeader.Text = "Tạo và gửi thông báo đến cư dân trong khu chung cư";
            // 
            // ucThongBao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.Controls.Add(this.pnlMain);
            this.Name = "ucThongBao";
            this.Size = new System.Drawing.Size(1257, 747);
            this.Load += new System.EventHandler(this.ucThongBao_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongBao)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.pnlCards.ResumeLayout(false);
            this.pnlCardTong.ResumeLayout(false);
            this.pnlCardTong.PerformLayout();
            this.pnlCardDaGui.ResumeLayout(false);
            this.pnlCardDaGui.PerformLayout();
            this.pnlCardNhap.ResumeLayout(false);
            this.pnlCardNhap.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        // ── Field declarations ────────────────────────────────────────────────
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblSubHeader;

        private System.Windows.Forms.Panel pnlCards;
        private System.Windows.Forms.Panel pnlCardTong;
        private System.Windows.Forms.Label lblTitleTong;
        private System.Windows.Forms.Label lblTongThongBao;
        private System.Windows.Forms.Panel pnlCardDaGui;
        private System.Windows.Forms.Label lblTitleDaGui;
        private System.Windows.Forms.Label lblDaGui;
        private System.Windows.Forms.Panel pnlCardNhap;
        private System.Windows.Forms.Label lblTitleNhap;
        private System.Windows.Forms.Label lblNhap;

        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.TextBox txtTieuDe;
        private System.Windows.Forms.Label lblLoai;
        private System.Windows.Forms.ComboBox cboLoaiThongBao;
        private System.Windows.Forms.Label lblDoiTuong;
        private System.Windows.Forms.ComboBox cboDoiTuongGui;
        private System.Windows.Forms.Label lblNgayTao;
        private System.Windows.Forms.DateTimePicker dtNgayTao;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Label lblNoiDung;
        private System.Windows.Forms.TextBox txtNoiDung;

        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnGuiThongBao;

        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvThongBao;

        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTieuDe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDoiTuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayGui;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.Panel pnlSpacer;
    }
}