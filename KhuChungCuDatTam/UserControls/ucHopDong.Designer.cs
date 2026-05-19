namespace KhuChungCuDatTam.UserControls
{
    partial class ucHopDong
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
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.dgvHopDong = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCuDanId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCanHoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCuDan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCanHo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoaiHopDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaTri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTienDatCoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.lblCuDan = new System.Windows.Forms.Label();
            this.cboCuDan = new System.Windows.Forms.ComboBox();
            this.lblCanHo = new System.Windows.Forms.Label();
            this.cboCanHo = new System.Windows.Forms.ComboBox();
            this.lblLoai = new System.Windows.Forms.Label();
            this.cboLoaiHopDong = new System.Windows.Forms.ComboBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.lblBatDau = new System.Windows.Forms.Label();
            this.dtNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.lblKetThuc = new System.Windows.Forms.Label();
            this.dtNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.lblGiaTri = new System.Windows.Forms.Label();
            this.txtGiaTri = new System.Windows.Forms.TextBox();
            this.lblDatCoc = new System.Windows.Forms.Label();
            this.txtTienDatCoc = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHopDong)).BeginInit();
            this.pnlSearch.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.pnlMain.Controls.Add(this.pnlBody);
            this.pnlMain.Controls.Add(this.pnlHeader);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1257, 747);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.pnlBody.Controls.Add(this.pnlRight);
            this.pnlBody.Controls.Add(this.pnlForm);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 68);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Padding = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.pnlBody.Size = new System.Drawing.Size(1257, 679);
            this.pnlBody.TabIndex = 1;
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.pnlRight.Controls.Add(this.dgvHopDong);
            this.pnlRight.Controls.Add(this.pnlSearch);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(368, 13);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.pnlRight.Size = new System.Drawing.Size(875, 653);
            this.pnlRight.TabIndex = 1;
            // 
            // dgvHopDong
            // 
            this.dgvHopDong.AllowUserToAddRows = false;
            this.dgvHopDong.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dgvHopDong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHopDong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHopDong.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.dgvHopDong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHopDong.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHopDong.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHopDong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHopDong.ColumnHeadersHeight = 40;
            this.dgvHopDong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colCuDanId,
            this.colCanHoId,
            this.colCuDan,
            this.colCanHo,
            this.colLoaiHopDong,
            this.colNgayBatDau,
            this.colNgayKetThuc,
            this.colGiaTri,
            this.colTienDatCoc,
            this.colTrangThai});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHopDong.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHopDong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHopDong.EnableHeadersVisualStyles = false;
            this.dgvHopDong.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dgvHopDong.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(80)))));
            this.dgvHopDong.Location = new System.Drawing.Point(14, 49);
            this.dgvHopDong.Name = "dgvHopDong";
            this.dgvHopDong.ReadOnly = true;
            this.dgvHopDong.RowHeadersVisible = false;
            this.dgvHopDong.RowHeadersWidth = 51;
            this.dgvHopDong.RowTemplate.Height = 38;
            this.dgvHopDong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHopDong.Size = new System.Drawing.Size(861, 604);
            this.dgvHopDong.TabIndex = 1;
            this.dgvHopDong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHopDong_CellClick);
            // 
            // colId
            // 
            this.colId.FillWeight = 30F;
            this.colId.HeaderText = "ID";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colId.Visible = false;
            // 
            // colCuDanId
            // 
            this.colCuDanId.FillWeight = 30F;
            this.colCuDanId.HeaderText = "CuDanId";
            this.colCuDanId.MinimumWidth = 6;
            this.colCuDanId.Name = "colCuDanId";
            this.colCuDanId.ReadOnly = true;
            this.colCuDanId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colCuDanId.Visible = false;
            // 
            // colCanHoId
            // 
            this.colCanHoId.FillWeight = 30F;
            this.colCanHoId.HeaderText = "CanHoId";
            this.colCanHoId.MinimumWidth = 6;
            this.colCanHoId.Name = "colCanHoId";
            this.colCanHoId.ReadOnly = true;
            this.colCanHoId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colCanHoId.Visible = false;
            // 
            // colCuDan
            // 
            this.colCuDan.FillWeight = 20F;
            this.colCuDan.HeaderText = "Cu Dan";
            this.colCuDan.MinimumWidth = 6;
            this.colCuDan.Name = "colCuDan";
            this.colCuDan.ReadOnly = true;
            this.colCuDan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colCanHo
            // 
            this.colCanHo.FillWeight = 10F;
            this.colCanHo.HeaderText = "Can Ho";
            this.colCanHo.MinimumWidth = 6;
            this.colCanHo.Name = "colCanHo";
            this.colCanHo.ReadOnly = true;
            this.colCanHo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colLoaiHopDong
            // 
            this.colLoaiHopDong.FillWeight = 12F;
            this.colLoaiHopDong.HeaderText = "Loai HD";
            this.colLoaiHopDong.MinimumWidth = 6;
            this.colLoaiHopDong.Name = "colLoaiHopDong";
            this.colLoaiHopDong.ReadOnly = true;
            this.colLoaiHopDong.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colNgayBatDau
            // 
            this.colNgayBatDau.FillWeight = 12F;
            this.colNgayBatDau.HeaderText = "Ngay Bat Dau";
            this.colNgayBatDau.MinimumWidth = 6;
            this.colNgayBatDau.Name = "colNgayBatDau";
            this.colNgayBatDau.ReadOnly = true;
            this.colNgayBatDau.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colNgayKetThuc
            // 
            this.colNgayKetThuc.FillWeight = 12F;
            this.colNgayKetThuc.HeaderText = "Ngay Ket Thuc";
            this.colNgayKetThuc.MinimumWidth = 6;
            this.colNgayKetThuc.Name = "colNgayKetThuc";
            this.colNgayKetThuc.ReadOnly = true;
            this.colNgayKetThuc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colGiaTri
            // 
            this.colGiaTri.FillWeight = 14F;
            this.colGiaTri.HeaderText = "Gia Tri (d)";
            this.colGiaTri.MinimumWidth = 6;
            this.colGiaTri.Name = "colGiaTri";
            this.colGiaTri.ReadOnly = true;
            this.colGiaTri.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colTienDatCoc
            // 
            this.colTienDatCoc.FillWeight = 12F;
            this.colTienDatCoc.HeaderText = "Dat Coc (d)";
            this.colTienDatCoc.MinimumWidth = 6;
            this.colTienDatCoc.Name = "colTienDatCoc";
            this.colTienDatCoc.ReadOnly = true;
            this.colTienDatCoc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colTrangThai
            // 
            this.colTrangThai.FillWeight = 12F;
            this.colTrangThai.HeaderText = "Trang Thai";
            this.colTrangThai.MinimumWidth = 6;
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.ReadOnly = true;
            this.colTrangThai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(54)))));
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Controls.Add(this.lblSearch);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(14, 0);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Padding = new System.Windows.Forms.Padding(9);
            this.pnlSearch.Size = new System.Drawing.Size(861, 49);
            this.pnlSearch.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.txtSearch.Location = new System.Drawing.Point(41, 9);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(811, 22);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblSearch.Location = new System.Drawing.Point(9, 9);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(32, 31);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "?";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlForm
            // 
            this.pnlForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(54)))));
            this.pnlForm.Controls.Add(this.lblCuDan);
            this.pnlForm.Controls.Add(this.cboCuDan);
            this.pnlForm.Controls.Add(this.lblCanHo);
            this.pnlForm.Controls.Add(this.cboCanHo);
            this.pnlForm.Controls.Add(this.lblLoai);
            this.pnlForm.Controls.Add(this.cboLoaiHopDong);
            this.pnlForm.Controls.Add(this.lblTrangThai);
            this.pnlForm.Controls.Add(this.cboTrangThai);
            this.pnlForm.Controls.Add(this.lblBatDau);
            this.pnlForm.Controls.Add(this.dtNgayBatDau);
            this.pnlForm.Controls.Add(this.lblKetThuc);
            this.pnlForm.Controls.Add(this.dtNgayKetThuc);
            this.pnlForm.Controls.Add(this.lblGiaTri);
            this.pnlForm.Controls.Add(this.txtGiaTri);
            this.pnlForm.Controls.Add(this.lblDatCoc);
            this.pnlForm.Controls.Add(this.txtTienDatCoc);
            this.pnlForm.Controls.Add(this.btnThem);
            this.pnlForm.Controls.Add(this.btnSua);
            this.pnlForm.Controls.Add(this.btnXoa);
            this.pnlForm.Controls.Add(this.btnLamMoi);
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlForm.Location = new System.Drawing.Point(14, 13);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(354, 653);
            this.pnlForm.TabIndex = 0;
            // 
            // lblCuDan
            // 
            this.lblCuDan.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblCuDan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblCuDan.Location = new System.Drawing.Point(21, 15);
            this.lblCuDan.Name = "lblCuDan";
            this.lblCuDan.Size = new System.Drawing.Size(313, 21);
            this.lblCuDan.TabIndex = 0;
            this.lblCuDan.Text = "Cu dan *";
            // 
            // cboCuDan
            // 
            this.cboCuDan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.cboCuDan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCuDan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCuDan.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboCuDan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.cboCuDan.Location = new System.Drawing.Point(21, 38);
            this.cboCuDan.Name = "cboCuDan";
            this.cboCuDan.Size = new System.Drawing.Size(313, 29);
            this.cboCuDan.TabIndex = 1;
            // 
            // lblCanHo
            // 
            this.lblCanHo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblCanHo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblCanHo.Location = new System.Drawing.Point(21, 79);
            this.lblCanHo.Name = "lblCanHo";
            this.lblCanHo.Size = new System.Drawing.Size(313, 21);
            this.lblCanHo.TabIndex = 2;
            this.lblCanHo.Text = "Can ho *";
            // 
            // cboCanHo
            // 
            this.cboCanHo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.cboCanHo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCanHo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCanHo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboCanHo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.cboCanHo.Location = new System.Drawing.Point(21, 102);
            this.cboCanHo.Name = "cboCanHo";
            this.cboCanHo.Size = new System.Drawing.Size(313, 29);
            this.cboCanHo.TabIndex = 3;
            // 
            // lblLoai
            // 
            this.lblLoai.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblLoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblLoai.Location = new System.Drawing.Point(21, 143);
            this.lblLoai.Name = "lblLoai";
            this.lblLoai.Size = new System.Drawing.Size(313, 21);
            this.lblLoai.TabIndex = 4;
            this.lblLoai.Text = "Loai hop dong *";
            // 
            // cboLoaiHopDong
            // 
            this.cboLoaiHopDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.cboLoaiHopDong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiHopDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboLoaiHopDong.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboLoaiHopDong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.cboLoaiHopDong.Location = new System.Drawing.Point(21, 166);
            this.cboLoaiHopDong.Name = "cboLoaiHopDong";
            this.cboLoaiHopDong.Size = new System.Drawing.Size(313, 29);
            this.cboLoaiHopDong.TabIndex = 5;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTrangThai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblTrangThai.Location = new System.Drawing.Point(21, 207);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(313, 21);
            this.lblTrangThai.TabIndex = 6;
            this.lblTrangThai.Text = "Trang thai *";
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTrangThai.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboTrangThai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.cboTrangThai.Location = new System.Drawing.Point(21, 230);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(313, 29);
            this.cboTrangThai.TabIndex = 7;
            // 
            // lblBatDau
            // 
            this.lblBatDau.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblBatDau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblBatDau.Location = new System.Drawing.Point(21, 271);
            this.lblBatDau.Name = "lblBatDau";
            this.lblBatDau.Size = new System.Drawing.Size(313, 21);
            this.lblBatDau.TabIndex = 8;
            this.lblBatDau.Text = "Ngay bat dau";
            // 
            // dtNgayBatDau
            // 
            this.dtNgayBatDau.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dtNgayBatDau.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.dtNgayBatDau.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayBatDau.Location = new System.Drawing.Point(21, 294);
            this.dtNgayBatDau.Name = "dtNgayBatDau";
            this.dtNgayBatDau.Size = new System.Drawing.Size(313, 29);
            this.dtNgayBatDau.TabIndex = 9;
            // 
            // lblKetThuc
            // 
            this.lblKetThuc.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblKetThuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblKetThuc.Location = new System.Drawing.Point(21, 335);
            this.lblKetThuc.Name = "lblKetThuc";
            this.lblKetThuc.Size = new System.Drawing.Size(313, 21);
            this.lblKetThuc.TabIndex = 10;
            this.lblKetThuc.Text = "Ngay ket thuc";
            // 
            // dtNgayKetThuc
            // 
            this.dtNgayKetThuc.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dtNgayKetThuc.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.dtNgayKetThuc.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayKetThuc.Location = new System.Drawing.Point(21, 358);
            this.dtNgayKetThuc.Name = "dtNgayKetThuc";
            this.dtNgayKetThuc.Size = new System.Drawing.Size(313, 29);
            this.dtNgayKetThuc.TabIndex = 11;
            // 
            // lblGiaTri
            // 
            this.lblGiaTri.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblGiaTri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblGiaTri.Location = new System.Drawing.Point(21, 399);
            this.lblGiaTri.Name = "lblGiaTri";
            this.lblGiaTri.Size = new System.Drawing.Size(313, 21);
            this.lblGiaTri.TabIndex = 12;
            this.lblGiaTri.Text = "Gia tri hop dong";
            // 
            // txtGiaTri
            // 
            this.txtGiaTri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.txtGiaTri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGiaTri.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtGiaTri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.txtGiaTri.Location = new System.Drawing.Point(21, 422);
            this.txtGiaTri.Name = "txtGiaTri";
            this.txtGiaTri.Size = new System.Drawing.Size(313, 29);
            this.txtGiaTri.TabIndex = 13;
            // 
            // lblDatCoc
            // 
            this.lblDatCoc.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblDatCoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblDatCoc.Location = new System.Drawing.Point(21, 463);
            this.lblDatCoc.Name = "lblDatCoc";
            this.lblDatCoc.Size = new System.Drawing.Size(313, 21);
            this.lblDatCoc.TabIndex = 14;
            this.lblDatCoc.Text = "Tien dat coc *";
            // 
            // txtTienDatCoc
            // 
            this.txtTienDatCoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.txtTienDatCoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTienDatCoc.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtTienDatCoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.txtTienDatCoc.Location = new System.Drawing.Point(21, 486);
            this.txtTienDatCoc.Name = "txtTienDatCoc";
            this.txtTienDatCoc.Size = new System.Drawing.Size(313, 29);
            this.txtTienDatCoc.TabIndex = 15;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(102)))), ((int)(((byte)(241)))));
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(21, 531);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(149, 38);
            this.btnThem.TabIndex = 16;
            this.btnThem.Text = "+ Them";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(185, 531);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(149, 38);
            this.btnSua.TabIndex = 17;
            this.btnSua.Text = "Sua";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(21, 578);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(149, 38);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "Xoa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(185, 578);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(149, 38);
            this.btnLamMoi.TabIndex = 19;
            this.btnLamMoi.Text = "Lam moi";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(35)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.pnlHeader.Size = new System.Drawing.Size(1257, 68);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.lblTitle.Location = new System.Drawing.Point(27, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1230, 68);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Quản Lý Hợp Đồng";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ucHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.Controls.Add(this.pnlMain);
            this.Name = "ucHopDong";
            this.Size = new System.Drawing.Size(1257, 747);
            this.pnlMain.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHopDong)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlSearch;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCuDan;
        private System.Windows.Forms.Label lblCanHo;
        private System.Windows.Forms.Label lblLoai;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Label lblBatDau;
        private System.Windows.Forms.Label lblKetThuc;
        private System.Windows.Forms.Label lblGiaTri;
        private System.Windows.Forms.Label lblDatCoc;
        private System.Windows.Forms.Label lblSearch;

        private System.Windows.Forms.ComboBox cboCuDan;
        private System.Windows.Forms.ComboBox cboCanHo;
        private System.Windows.Forms.ComboBox cboLoaiHopDong;
        private System.Windows.Forms.ComboBox cboTrangThai;

        private System.Windows.Forms.DateTimePicker dtNgayBatDau;
        private System.Windows.Forms.DateTimePicker dtNgayKetThuc;

        private System.Windows.Forms.TextBox txtGiaTri;
        private System.Windows.Forms.TextBox txtTienDatCoc;
        private System.Windows.Forms.TextBox txtSearch;

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;

        private System.Windows.Forms.DataGridView dgvHopDong;

        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCuDanId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCanHoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCuDan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCanHo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoaiHopDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaTri;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTienDatCoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
    }
}