namespace KhuChungCuDatTam.UserControls
{
    partial class ucDangKyDichVu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.dgvDangKyDichVu = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCanHo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayDangKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayHuy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.txtGiaDichVu = new System.Windows.Forms.TextBox();
            this.lblGiaDichVu = new System.Windows.Forms.Label();
            this.dtNgayHetHan = new System.Windows.Forms.DateTimePicker();
            this.lblNgayHetHan = new System.Windows.Forms.Label();
            this.dtNgayDangKy = new System.Windows.Forms.DateTimePicker();
            this.lblNgayDangKy = new System.Windows.Forms.Label();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.cboDichVu = new System.Windows.Forms.ComboBox();
            this.lblDichVu = new System.Windows.Forms.Label();
            this.cboCanHo = new System.Windows.Forms.ComboBox();
            this.lblCanHo = new System.Windows.Forms.Label();
            this.pnlCards = new System.Windows.Forms.Panel();
            this.cardHetHan = new System.Windows.Forms.Panel();
            this.lblHetHan = new System.Windows.Forms.Label();
            this.lblCardHetTitle = new System.Windows.Forms.Label();
            this.cardHoatDong = new System.Windows.Forms.Panel();
            this.lblDangHoatDong = new System.Windows.Forms.Label();
            this.lblCardHoatTitle = new System.Windows.Forms.Label();
            this.cardTong = new System.Windows.Forms.Panel();
            this.lblTongDangKy = new System.Windows.Forms.Label();
            this.lblCardTongTitle = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDangKyDichVu)).BeginInit();
            this.pnlForm.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlCards.SuspendLayout();
            this.cardHetHan.SuspendLayout();
            this.cardHoatDong.SuspendLayout();
            this.cardTong.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.pnlMain.Controls.Add(this.pnlContent);
            this.pnlMain.Controls.Add(this.pnlCards);
            this.pnlMain.Controls.Add(this.pnlTop);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(18, 17, 18, 17);
            this.pnlMain.Size = new System.Drawing.Size(1143, 683);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.pnlContent.Controls.Add(this.dgvDangKyDichVu);
            this.pnlContent.Controls.Add(this.pnlForm);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(18, 188);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1107, 478);
            this.pnlContent.TabIndex = 2;
            // 
            // dgvDangKyDichVu
            // 
            this.dgvDangKyDichVu.AllowUserToAddRows = false;
            this.dgvDangKyDichVu.AllowUserToDeleteRows = false;
            this.dgvDangKyDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDangKyDichVu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.dgvDangKyDichVu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDangKyDichVu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(6, 0, 4, 0);
            this.dgvDangKyDichVu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDangKyDichVu.ColumnHeadersHeight = 36;
            this.dgvDangKyDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDangKyDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colCanHo,
            this.colDichVu,
            this.colNgayDangKy,
            this.colNgayHuy,
            this.colGia,
            this.colTrangThai});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDangKyDichVu.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDangKyDichVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDangKyDichVu.EnableHeadersVisualStyles = false;
            this.dgvDangKyDichVu.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dgvDangKyDichVu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.dgvDangKyDichVu.Location = new System.Drawing.Point(0, 0);
            this.dgvDangKyDichVu.MultiSelect = false;
            this.dgvDangKyDichVu.Name = "dgvDangKyDichVu";
            this.dgvDangKyDichVu.ReadOnly = true;
            this.dgvDangKyDichVu.RowHeadersVisible = false;
            this.dgvDangKyDichVu.RowHeadersWidth = 51;
            this.dgvDangKyDichVu.RowTemplate.Height = 32;
            this.dgvDangKyDichVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDangKyDichVu.Size = new System.Drawing.Size(764, 478);
            this.dgvDangKyDichVu.TabIndex = 0;
            this.dgvDangKyDichVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDangKyDichVu_CellClick);
            // 
            // colId
            // 
            this.colId.FillWeight = 40F;
            this.colId.HeaderText = "ID";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // colCanHo
            // 
            this.colCanHo.HeaderText = "CAN HO";
            this.colCanHo.MinimumWidth = 6;
            this.colCanHo.Name = "colCanHo";
            this.colCanHo.ReadOnly = true;
            // 
            // colDichVu
            // 
            this.colDichVu.FillWeight = 160F;
            this.colDichVu.HeaderText = "DICH VU";
            this.colDichVu.MinimumWidth = 6;
            this.colDichVu.Name = "colDichVu";
            this.colDichVu.ReadOnly = true;
            // 
            // colNgayDangKy
            // 
            this.colNgayDangKy.FillWeight = 110F;
            this.colNgayDangKy.HeaderText = "NGAY DANG KY";
            this.colNgayDangKy.MinimumWidth = 6;
            this.colNgayDangKy.Name = "colNgayDangKy";
            this.colNgayDangKy.ReadOnly = true;
            // 
            // colNgayHuy
            // 
            this.colNgayHuy.FillWeight = 110F;
            this.colNgayHuy.HeaderText = "NGAY HUY";
            this.colNgayHuy.MinimumWidth = 6;
            this.colNgayHuy.Name = "colNgayHuy";
            this.colNgayHuy.ReadOnly = true;
            // 
            // colGia
            // 
            this.colGia.FillWeight = 110F;
            this.colGia.HeaderText = "GIA DICH VU";
            this.colGia.MinimumWidth = 6;
            this.colGia.Name = "colGia";
            this.colGia.ReadOnly = true;
            // 
            // colTrangThai
            // 
            this.colTrangThai.HeaderText = "TRANG THAI";
            this.colTrangThai.MinimumWidth = 6;
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.ReadOnly = true;
            // 
            // pnlForm
            // 
            this.pnlForm.AutoScroll = true;
            this.pnlForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.pnlForm.Controls.Add(this.pnlButtons);
            this.pnlForm.Controls.Add(this.txtGhiChu);
            this.pnlForm.Controls.Add(this.lblGhiChu);
            this.pnlForm.Controls.Add(this.txtGiaDichVu);
            this.pnlForm.Controls.Add(this.lblGiaDichVu);
            this.pnlForm.Controls.Add(this.dtNgayHetHan);
            this.pnlForm.Controls.Add(this.lblNgayHetHan);
            this.pnlForm.Controls.Add(this.dtNgayDangKy);
            this.pnlForm.Controls.Add(this.lblNgayDangKy);
            this.pnlForm.Controls.Add(this.cboTrangThai);
            this.pnlForm.Controls.Add(this.lblTrangThai);
            this.pnlForm.Controls.Add(this.cboDichVu);
            this.pnlForm.Controls.Add(this.lblDichVu);
            this.pnlForm.Controls.Add(this.cboCanHo);
            this.pnlForm.Controls.Add(this.lblCanHo);
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlForm.Location = new System.Drawing.Point(764, 0);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Padding = new System.Windows.Forms.Padding(16, 13, 16, 13);
            this.pnlForm.Size = new System.Drawing.Size(343, 478);
            this.pnlForm.TabIndex = 1;
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.pnlButtons.Controls.Add(this.btnLamMoi);
            this.pnlButtons.Controls.Add(this.btnXoa);
            this.pnlButtons.Controls.Add(this.btnSua);
            this.pnlButtons.Controls.Add(this.btnThem);
            this.pnlButtons.Location = new System.Drawing.Point(16, 480);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(311, 43);
            this.pnlButtons.TabIndex = 14;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(233, 2);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(73, 38);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "Lam Moi";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(155, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(73, 38);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xoa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(78, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(73, 38);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sua";
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
            this.btnThem.Location = new System.Drawing.Point(0, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(73, 38);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "+ Them";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtGhiChu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGhiChu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtGhiChu.ForeColor = System.Drawing.Color.White;
            this.txtGhiChu.Location = new System.Drawing.Point(16, 405);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGhiChu.Size = new System.Drawing.Size(311, 64);
            this.txtGhiChu.TabIndex = 13;
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblGhiChu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblGhiChu.Location = new System.Drawing.Point(16, 384);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(311, 19);
            this.lblGhiChu.TabIndex = 12;
            this.lblGhiChu.Text = "GHI CHU";
            this.lblGhiChu.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtGiaDichVu
            // 
            this.txtGiaDichVu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtGiaDichVu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGiaDichVu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtGiaDichVu.ForeColor = System.Drawing.Color.White;
            this.txtGiaDichVu.Location = new System.Drawing.Point(16, 343);
            this.txtGiaDichVu.Name = "txtGiaDichVu";
            this.txtGiaDichVu.ReadOnly = true;
            this.txtGiaDichVu.Size = new System.Drawing.Size(311, 30);
            this.txtGiaDichVu.TabIndex = 11;
            // 
            // lblGiaDichVu
            // 
            this.lblGiaDichVu.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblGiaDichVu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblGiaDichVu.Location = new System.Drawing.Point(16, 322);
            this.lblGiaDichVu.Name = "lblGiaDichVu";
            this.lblGiaDichVu.Size = new System.Drawing.Size(311, 19);
            this.lblGiaDichVu.TabIndex = 10;
            this.lblGiaDichVu.Text = "GIA DICH VU (d)";
            this.lblGiaDichVu.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // dtNgayHetHan
            // 
            this.dtNgayHetHan.CalendarForeColor = System.Drawing.Color.White;
            this.dtNgayHetHan.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.dtNgayHetHan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtNgayHetHan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayHetHan.Location = new System.Drawing.Point(16, 282);
            this.dtNgayHetHan.Name = "dtNgayHetHan";
            this.dtNgayHetHan.Size = new System.Drawing.Size(310, 30);
            this.dtNgayHetHan.TabIndex = 9;
            // 
            // lblNgayHetHan
            // 
            this.lblNgayHetHan.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblNgayHetHan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblNgayHetHan.Location = new System.Drawing.Point(16, 260);
            this.lblNgayHetHan.Name = "lblNgayHetHan";
            this.lblNgayHetHan.Size = new System.Drawing.Size(311, 19);
            this.lblNgayHetHan.TabIndex = 8;
            this.lblNgayHetHan.Text = "NGAY HUY (neu co)";
            this.lblNgayHetHan.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // dtNgayDangKy
            // 
            this.dtNgayDangKy.CalendarForeColor = System.Drawing.Color.White;
            this.dtNgayDangKy.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.dtNgayDangKy.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtNgayDangKy.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayDangKy.Location = new System.Drawing.Point(16, 220);
            this.dtNgayDangKy.Name = "dtNgayDangKy";
            this.dtNgayDangKy.Size = new System.Drawing.Size(310, 30);
            this.dtNgayDangKy.TabIndex = 7;
            // 
            // lblNgayDangKy
            // 
            this.lblNgayDangKy.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblNgayDangKy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblNgayDangKy.Location = new System.Drawing.Point(16, 198);
            this.lblNgayDangKy.Name = "lblNgayDangKy";
            this.lblNgayDangKy.Size = new System.Drawing.Size(311, 19);
            this.lblNgayDangKy.TabIndex = 6;
            this.lblNgayDangKy.Text = "NGAY DANG KY";
            this.lblNgayDangKy.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTrangThai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboTrangThai.ForeColor = System.Drawing.Color.White;
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Items.AddRange(new object[] {
            "Hoat dong",
            "Het han",
            "Da huy"});
            this.cboTrangThai.Location = new System.Drawing.Point(16, 158);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(310, 31);
            this.cboTrangThai.TabIndex = 5;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblTrangThai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblTrangThai.Location = new System.Drawing.Point(16, 137);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(311, 19);
            this.lblTrangThai.TabIndex = 4;
            this.lblTrangThai.Text = "TRANG THAI";
            this.lblTrangThai.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cboDichVu
            // 
            this.cboDichVu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.cboDichVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDichVu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboDichVu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboDichVu.ForeColor = System.Drawing.Color.White;
            this.cboDichVu.FormattingEnabled = true;
            this.cboDichVu.Location = new System.Drawing.Point(16, 96);
            this.cboDichVu.Name = "cboDichVu";
            this.cboDichVu.Size = new System.Drawing.Size(310, 31);
            this.cboDichVu.TabIndex = 3;
            this.cboDichVu.SelectedIndexChanged += new System.EventHandler(this.cboDichVu_SelectedIndexChanged);
            // 
            // lblDichVu
            // 
            this.lblDichVu.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblDichVu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblDichVu.Location = new System.Drawing.Point(16, 75);
            this.lblDichVu.Name = "lblDichVu";
            this.lblDichVu.Size = new System.Drawing.Size(311, 19);
            this.lblDichVu.TabIndex = 2;
            this.lblDichVu.Text = "DICH VU";
            this.lblDichVu.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cboCanHo
            // 
            this.cboCanHo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.cboCanHo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCanHo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCanHo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboCanHo.ForeColor = System.Drawing.Color.White;
            this.cboCanHo.FormattingEnabled = true;
            this.cboCanHo.Location = new System.Drawing.Point(16, 34);
            this.cboCanHo.Name = "cboCanHo";
            this.cboCanHo.Size = new System.Drawing.Size(310, 31);
            this.cboCanHo.TabIndex = 1;
            // 
            // lblCanHo
            // 
            this.lblCanHo.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblCanHo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblCanHo.Location = new System.Drawing.Point(16, 13);
            this.lblCanHo.Name = "lblCanHo";
            this.lblCanHo.Size = new System.Drawing.Size(311, 19);
            this.lblCanHo.TabIndex = 0;
            this.lblCanHo.Text = "CAN HO";
            this.lblCanHo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // pnlCards
            // 
            this.pnlCards.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.pnlCards.Controls.Add(this.cardHetHan);
            this.pnlCards.Controls.Add(this.cardHoatDong);
            this.pnlCards.Controls.Add(this.cardTong);
            this.pnlCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCards.Location = new System.Drawing.Point(18, 81);
            this.pnlCards.Name = "pnlCards";
            this.pnlCards.Padding = new System.Windows.Forms.Padding(0, 0, 0, 9);
            this.pnlCards.Size = new System.Drawing.Size(1107, 107);
            this.pnlCards.TabIndex = 1;
            // 
            // cardHetHan
            // 
            this.cardHetHan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.cardHetHan.Controls.Add(this.lblHetHan);
            this.cardHetHan.Controls.Add(this.lblCardHetTitle);
            this.cardHetHan.Location = new System.Drawing.Point(439, 0);
            this.cardHetHan.Name = "cardHetHan";
            this.cardHetHan.Padding = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.cardHetHan.Size = new System.Drawing.Size(206, 90);
            this.cardHetHan.TabIndex = 2;
            // 
            // lblHetHan
            // 
            this.lblHetHan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHetHan.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblHetHan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lblHetHan.Location = new System.Drawing.Point(14, 36);
            this.lblHetHan.Name = "lblHetHan";
            this.lblHetHan.Size = new System.Drawing.Size(178, 41);
            this.lblHetHan.TabIndex = 1;
            this.lblHetHan.Text = "0";
            this.lblHetHan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCardHetTitle
            // 
            this.lblCardHetTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCardHetTitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblCardHetTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblCardHetTitle.Location = new System.Drawing.Point(14, 13);
            this.lblCardHetTitle.Name = "lblCardHetTitle";
            this.lblCardHetTitle.Size = new System.Drawing.Size(178, 23);
            this.lblCardHetTitle.TabIndex = 0;
            this.lblCardHetTitle.Text = "HET HAN / DA HUY";
            this.lblCardHetTitle.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cardHoatDong
            // 
            this.cardHoatDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.cardHoatDong.Controls.Add(this.lblDangHoatDong);
            this.cardHoatDong.Controls.Add(this.lblCardHoatTitle);
            this.cardHoatDong.Location = new System.Drawing.Point(219, 0);
            this.cardHoatDong.Name = "cardHoatDong";
            this.cardHoatDong.Padding = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.cardHoatDong.Size = new System.Drawing.Size(206, 90);
            this.cardHoatDong.TabIndex = 1;
            // 
            // lblDangHoatDong
            // 
            this.lblDangHoatDong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDangHoatDong.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblDangHoatDong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.lblDangHoatDong.Location = new System.Drawing.Point(14, 36);
            this.lblDangHoatDong.Name = "lblDangHoatDong";
            this.lblDangHoatDong.Size = new System.Drawing.Size(178, 41);
            this.lblDangHoatDong.TabIndex = 1;
            this.lblDangHoatDong.Text = "0";
            this.lblDangHoatDong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCardHoatTitle
            // 
            this.lblCardHoatTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCardHoatTitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblCardHoatTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblCardHoatTitle.Location = new System.Drawing.Point(14, 13);
            this.lblCardHoatTitle.Name = "lblCardHoatTitle";
            this.lblCardHoatTitle.Size = new System.Drawing.Size(178, 23);
            this.lblCardHoatTitle.TabIndex = 0;
            this.lblCardHoatTitle.Text = "ĐANG HOẠT ĐỘNG";
            this.lblCardHoatTitle.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cardTong
            // 
            this.cardTong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.cardTong.Controls.Add(this.lblTongDangKy);
            this.cardTong.Controls.Add(this.lblCardTongTitle);
            this.cardTong.Location = new System.Drawing.Point(0, 0);
            this.cardTong.Name = "cardTong";
            this.cardTong.Padding = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.cardTong.Size = new System.Drawing.Size(206, 90);
            this.cardTong.TabIndex = 0;
            // 
            // lblTongDangKy
            // 
            this.lblTongDangKy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTongDangKy.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTongDangKy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.lblTongDangKy.Location = new System.Drawing.Point(14, 36);
            this.lblTongDangKy.Name = "lblTongDangKy";
            this.lblTongDangKy.Size = new System.Drawing.Size(178, 41);
            this.lblTongDangKy.TabIndex = 1;
            this.lblTongDangKy.Text = "0";
            this.lblTongDangKy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCardTongTitle
            // 
            this.lblCardTongTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCardTongTitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblCardTongTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblCardTongTitle.Location = new System.Drawing.Point(14, 13);
            this.lblCardTongTitle.Name = "lblCardTongTitle";
            this.lblCardTongTitle.Size = new System.Drawing.Size(178, 23);
            this.lblCardTongTitle.TabIndex = 0;
            this.lblCardTongTitle.Text = "TỔNG ĐĂNG KÝ";
            this.lblCardTongTitle.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.pnlTop.Controls.Add(this.txtSearch);
            this.pnlTop.Controls.Add(this.lblSearch);
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(18, 17);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1107, 64);
            this.pnlTop.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.Location = new System.Drawing.Point(536, 20);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(297, 30);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblSearch.Location = new System.Drawing.Point(469, 14);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(79, 36);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Tìm:";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(457, 64);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ ĐĂNG KÝ DỊCH VỤ";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ucDangKyDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.Controls.Add(this.pnlMain);
            this.Name = "ucDangKyDichVu";
            this.Size = new System.Drawing.Size(1143, 683);
            this.Load += new System.EventHandler(this.ucDangKyDichVu_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDangKyDichVu)).EndInit();
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.pnlCards.ResumeLayout(false);
            this.cardHetHan.ResumeLayout(false);
            this.cardHoatDong.ResumeLayout(false);
            this.cardTong.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        // ── Field declarations ─────────────────────────────────────────
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel pnlCards;
        private System.Windows.Forms.Panel cardTong;
        private System.Windows.Forms.Label lblCardTongTitle;
        private System.Windows.Forms.Label lblTongDangKy;
        private System.Windows.Forms.Panel cardHoatDong;
        private System.Windows.Forms.Label lblCardHoatTitle;
        private System.Windows.Forms.Label lblDangHoatDong;
        private System.Windows.Forms.Panel cardHetHan;
        private System.Windows.Forms.Label lblCardHetTitle;
        private System.Windows.Forms.Label lblHetHan;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.DataGridView dgvDangKyDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCanHo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayDangKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayHuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Label lblCanHo;
        private System.Windows.Forms.ComboBox cboCanHo;
        private System.Windows.Forms.Label lblDichVu;
        private System.Windows.Forms.ComboBox cboDichVu;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Label lblNgayDangKy;
        private System.Windows.Forms.DateTimePicker dtNgayDangKy;
        private System.Windows.Forms.Label lblNgayHetHan;
        private System.Windows.Forms.DateTimePicker dtNgayHetHan;
        private System.Windows.Forms.Label lblGiaDichVu;
        private System.Windows.Forms.TextBox txtGiaDichVu;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
    }
}