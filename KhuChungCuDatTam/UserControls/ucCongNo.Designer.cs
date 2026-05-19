namespace KhuChungCuDatTam.UserControls
{
    partial class ucCongNo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.dgvCongNo = new System.Windows.Forms.DataGridView();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearchIcon = new System.Windows.Forms.Label();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.txtSoTienNo = new System.Windows.Forms.TextBox();
            this.lblSoTienNo = new System.Windows.Forms.Label();
            this.dtHanThanhToan = new System.Windows.Forms.DateTimePicker();
            this.lblHanThanhToan = new System.Windows.Forms.Label();
            this.cboHoaDon = new System.Windows.Forms.ComboBox();
            this.lblHoaDon = new System.Windows.Forms.Label();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.pnlCards = new System.Windows.Forms.Panel();
            this.cardQuaHan = new System.Windows.Forms.Panel();
            this.lblQuaHanTitle = new System.Windows.Forms.Label();
            this.lblQuaHan = new System.Windows.Forms.Label();
            this.cardDaThanhToan = new System.Windows.Forms.Panel();
            this.lblDaThanhToanTitle = new System.Windows.Forms.Label();
            this.lblDaThanhToan = new System.Windows.Forms.Label();
            this.cardTongCongNo = new System.Windows.Forms.Panel();
            this.lblTongCongNoTitle = new System.Windows.Forms.Label();
            this.lblTongCongNo = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCongNo)).BeginInit();
            this.pnlSearch.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlCards.SuspendLayout();
            this.cardQuaHan.SuspendLayout();
            this.cardDaThanhToan.SuspendLayout();
            this.cardTongCongNo.SuspendLayout();
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
            this.pnlMain.Size = new System.Drawing.Size(1371, 800);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.pnlContent.Controls.Add(this.pnlRight);
            this.pnlContent.Controls.Add(this.pnlLeft);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 181);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(18, 9, 18, 17);
            this.pnlContent.Size = new System.Drawing.Size(1371, 619);
            this.pnlContent.TabIndex = 0;
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.pnlRight.Controls.Add(this.dgvCongNo);
            this.pnlRight.Controls.Add(this.pnlSearch);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(384, 9);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.pnlRight.Size = new System.Drawing.Size(969, 593);
            this.pnlRight.TabIndex = 0;
            // 
            // dgvCongNo
            // 
            this.dgvCongNo.AllowUserToAddRows = false;
            this.dgvCongNo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.dgvCongNo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCongNo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCongNo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.dgvCongNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCongNo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCongNo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.dgvCongNo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCongNo.ColumnHeadersHeight = 42;
            this.dgvCongNo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCongNo.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCongNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCongNo.EnableHeadersVisualStyles = false;
            this.dgvCongNo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.dgvCongNo.Location = new System.Drawing.Point(9, 53);
            this.dgvCongNo.MultiSelect = false;
            this.dgvCongNo.Name = "dgvCongNo";
            this.dgvCongNo.ReadOnly = true;
            this.dgvCongNo.RowHeadersVisible = false;
            this.dgvCongNo.RowHeadersWidth = 51;
            this.dgvCongNo.RowTemplate.Height = 38;
            this.dgvCongNo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCongNo.Size = new System.Drawing.Size(960, 540);
            this.dgvCongNo.TabIndex = 1;
            this.dgvCongNo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCongNo_CellClick);
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Controls.Add(this.lblSearchIcon);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(9, 0);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(960, 53);
            this.pnlSearch.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.Location = new System.Drawing.Point(114, 13);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(457, 30);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearchIcon
            // 
            this.lblSearchIcon.AutoSize = true;
            this.lblSearchIcon.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSearchIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblSearchIcon.Location = new System.Drawing.Point(18, 15);
            this.lblSearchIcon.Name = "lblSearchIcon";
            this.lblSearchIcon.Size = new System.Drawing.Size(92, 25);
            this.lblSearchIcon.TabIndex = 1;
            this.lblSearchIcon.Text = "Tim kiem:";
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.pnlLeft.Controls.Add(this.pnlForm);
            this.pnlLeft.Controls.Add(this.pnlButtons);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(18, 9);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(366, 593);
            this.pnlLeft.TabIndex = 1;
            // 
            // pnlForm
            // 
            this.pnlForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.pnlForm.Controls.Add(this.txtGhiChu);
            this.pnlForm.Controls.Add(this.lblGhiChu);
            this.pnlForm.Controls.Add(this.cboTrangThai);
            this.pnlForm.Controls.Add(this.lblTrangThai);
            this.pnlForm.Controls.Add(this.txtSoTienNo);
            this.pnlForm.Controls.Add(this.lblSoTienNo);
            this.pnlForm.Controls.Add(this.dtHanThanhToan);
            this.pnlForm.Controls.Add(this.lblHanThanhToan);
            this.pnlForm.Controls.Add(this.cboHoaDon);
            this.pnlForm.Controls.Add(this.lblHoaDon);
            this.pnlForm.Controls.Add(this.lblFormTitle);
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForm.Location = new System.Drawing.Point(0, 0);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(366, 525);
            this.pnlForm.TabIndex = 0;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtGhiChu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGhiChu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtGhiChu.ForeColor = System.Drawing.Color.White;
            this.txtGhiChu.Location = new System.Drawing.Point(18, 337);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGhiChu.Size = new System.Drawing.Size(320, 77);
            this.txtGhiChu.TabIndex = 5;
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblGhiChu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblGhiChu.Location = new System.Drawing.Point(18, 316);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(60, 20);
            this.lblGhiChu.TabIndex = 6;
            this.lblGhiChu.Text = "Ghi Chu";
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTrangThai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboTrangThai.ForeColor = System.Drawing.Color.White;
            this.cboTrangThai.Location = new System.Drawing.Point(18, 273);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(319, 31);
            this.cboTrangThai.TabIndex = 4;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTrangThai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblTrangThai.Location = new System.Drawing.Point(18, 252);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(78, 20);
            this.lblTrangThai.TabIndex = 7;
            this.lblTrangThai.Text = "Trang Thai";
            // 
            // txtSoTienNo
            // 
            this.txtSoTienNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtSoTienNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoTienNo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSoTienNo.ForeColor = System.Drawing.Color.White;
            this.txtSoTienNo.Location = new System.Drawing.Point(18, 209);
            this.txtSoTienNo.Name = "txtSoTienNo";
            this.txtSoTienNo.Size = new System.Drawing.Size(320, 30);
            this.txtSoTienNo.TabIndex = 3;
            // 
            // lblSoTienNo
            // 
            this.lblSoTienNo.AutoSize = true;
            this.lblSoTienNo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSoTienNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblSoTienNo.Location = new System.Drawing.Point(18, 188);
            this.lblSoTienNo.Name = "lblSoTienNo";
            this.lblSoTienNo.Size = new System.Drawing.Size(127, 20);
            this.lblSoTienNo.TabIndex = 8;
            this.lblSoTienNo.Text = "So Tien No (VND)";
            // 
            // dtHanThanhToan
            // 
            this.dtHanThanhToan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtHanThanhToan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtHanThanhToan.Location = new System.Drawing.Point(18, 145);
            this.dtHanThanhToan.Name = "dtHanThanhToan";
            this.dtHanThanhToan.Size = new System.Drawing.Size(319, 30);
            this.dtHanThanhToan.TabIndex = 2;
            // 
            // lblHanThanhToan
            // 
            this.lblHanThanhToan.AutoSize = true;
            this.lblHanThanhToan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHanThanhToan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblHanThanhToan.Location = new System.Drawing.Point(18, 124);
            this.lblHanThanhToan.Name = "lblHanThanhToan";
            this.lblHanThanhToan.Size = new System.Drawing.Size(116, 20);
            this.lblHanThanhToan.TabIndex = 9;
            this.lblHanThanhToan.Text = "Han Thanh Toan";
            // 
            // cboHoaDon
            // 
            this.cboHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.cboHoaDon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboHoaDon.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboHoaDon.ForeColor = System.Drawing.Color.White;
            this.cboHoaDon.Location = new System.Drawing.Point(18, 81);
            this.cboHoaDon.Name = "cboHoaDon";
            this.cboHoaDon.Size = new System.Drawing.Size(319, 31);
            this.cboHoaDon.TabIndex = 1;
            // 
            // lblHoaDon
            // 
            this.lblHoaDon.AutoSize = true;
            this.lblHoaDon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHoaDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblHoaDon.Location = new System.Drawing.Point(18, 60);
            this.lblHoaDon.Name = "lblHoaDon";
            this.lblHoaDon.Size = new System.Drawing.Size(69, 20);
            this.lblHoaDon.TabIndex = 10;
            this.lblHoaDon.Text = "Hoa Don";
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = System.Drawing.Color.White;
            this.lblFormTitle.Location = new System.Drawing.Point(0, 0);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.lblFormTitle.Size = new System.Drawing.Size(366, 47);
            this.lblFormTitle.TabIndex = 11;
            this.lblFormTitle.Text = "Thong Tin Cong No";
            this.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.pnlButtons.Controls.Add(this.btnLamMoi);
            this.pnlButtons.Controls.Add(this.btnXoa);
            this.pnlButtons.Controls.Add(this.btnSua);
            this.pnlButtons.Controls.Add(this.btnThem);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(0, 525);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Padding = new System.Windows.Forms.Padding(18, 13, 18, 13);
            this.pnlButtons.Size = new System.Drawing.Size(366, 68);
            this.pnlButtons.TabIndex = 1;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(235, 13);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(94, 38);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "Lam Moi";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.btnBaoCao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBaoCao.FlatAppearance.BorderSize = 0;
            this.btnBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaoCao.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnBaoCao.ForeColor = System.Drawing.Color.White;
            this.btnBaoCao.Location = new System.Drawing.Point(966, 67);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(103, 38);
            this.btnBaoCao.TabIndex = 4;
            this.btnBaoCao.Text = "Xem Report";
            this.btnBaoCao.UseVisualStyleBackColor = false;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(165, 13);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(64, 38);
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
            this.btnSua.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(94, 13);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(64, 38);
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
            this.btnThem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(18, 13);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(69, 38);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Them";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // pnlCards
            // 
            this.pnlCards.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.pnlCards.Controls.Add(this.cardQuaHan);
            this.pnlCards.Controls.Add(this.btnBaoCao);
            this.pnlCards.Controls.Add(this.cardDaThanhToan);
            this.pnlCards.Controls.Add(this.cardTongCongNo);
            this.pnlCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCards.Location = new System.Drawing.Point(0, 64);
            this.pnlCards.Name = "pnlCards";
            this.pnlCards.Size = new System.Drawing.Size(1371, 117);
            this.pnlCards.TabIndex = 1;
            // 
            // cardQuaHan
            // 
            this.cardQuaHan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.cardQuaHan.Controls.Add(this.lblQuaHanTitle);
            this.cardQuaHan.Controls.Add(this.lblQuaHan);
            this.cardQuaHan.Location = new System.Drawing.Point(649, 11);
            this.cardQuaHan.Name = "cardQuaHan";
            this.cardQuaHan.Size = new System.Drawing.Size(297, 94);
            this.cardQuaHan.TabIndex = 2;
            // 
            // lblQuaHanTitle
            // 
            this.lblQuaHanTitle.AutoSize = true;
            this.lblQuaHanTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblQuaHanTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblQuaHanTitle.Location = new System.Drawing.Point(16, 13);
            this.lblQuaHanTitle.Name = "lblQuaHanTitle";
            this.lblQuaHanTitle.Size = new System.Drawing.Size(76, 20);
            this.lblQuaHanTitle.TabIndex = 0;
            this.lblQuaHanTitle.Text = "QUA HAN";
            // 
            // lblQuaHan
            // 
            this.lblQuaHan.AutoSize = true;
            this.lblQuaHan.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblQuaHan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lblQuaHan.Location = new System.Drawing.Point(14, 36);
            this.lblQuaHan.Name = "lblQuaHan";
            this.lblQuaHan.Size = new System.Drawing.Size(35, 41);
            this.lblQuaHan.TabIndex = 1;
            this.lblQuaHan.Text = "0";
            // 
            // cardDaThanhToan
            // 
            this.cardDaThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.cardDaThanhToan.Controls.Add(this.lblDaThanhToanTitle);
            this.cardDaThanhToan.Controls.Add(this.lblDaThanhToan);
            this.cardDaThanhToan.Location = new System.Drawing.Point(334, 11);
            this.cardDaThanhToan.Name = "cardDaThanhToan";
            this.cardDaThanhToan.Size = new System.Drawing.Size(297, 94);
            this.cardDaThanhToan.TabIndex = 1;
            // 
            // lblDaThanhToanTitle
            // 
            this.lblDaThanhToanTitle.AutoSize = true;
            this.lblDaThanhToanTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDaThanhToanTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblDaThanhToanTitle.Location = new System.Drawing.Point(16, 13);
            this.lblDaThanhToanTitle.Name = "lblDaThanhToanTitle";
            this.lblDaThanhToanTitle.Size = new System.Drawing.Size(128, 20);
            this.lblDaThanhToanTitle.TabIndex = 0;
            this.lblDaThanhToanTitle.Text = "DA THANH TOAN";
            // 
            // lblDaThanhToan
            // 
            this.lblDaThanhToan.AutoSize = true;
            this.lblDaThanhToan.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblDaThanhToan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.lblDaThanhToan.Location = new System.Drawing.Point(14, 36);
            this.lblDaThanhToan.Name = "lblDaThanhToan";
            this.lblDaThanhToan.Size = new System.Drawing.Size(35, 41);
            this.lblDaThanhToan.TabIndex = 1;
            this.lblDaThanhToan.Text = "0";
            // 
            // cardTongCongNo
            // 
            this.cardTongCongNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.cardTongCongNo.Controls.Add(this.lblTongCongNoTitle);
            this.cardTongCongNo.Controls.Add(this.lblTongCongNo);
            this.cardTongCongNo.Location = new System.Drawing.Point(18, 11);
            this.cardTongCongNo.Name = "cardTongCongNo";
            this.cardTongCongNo.Size = new System.Drawing.Size(297, 94);
            this.cardTongCongNo.TabIndex = 0;
            // 
            // lblTongCongNoTitle
            // 
            this.lblTongCongNoTitle.AutoSize = true;
            this.lblTongCongNoTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTongCongNoTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblTongCongNoTitle.Location = new System.Drawing.Point(16, 13);
            this.lblTongCongNoTitle.Name = "lblTongCongNoTitle";
            this.lblTongCongNoTitle.Size = new System.Drawing.Size(119, 20);
            this.lblTongCongNoTitle.TabIndex = 0;
            this.lblTongCongNoTitle.Text = "TONG CONG NO";
            // 
            // lblTongCongNo
            // 
            this.lblTongCongNo.AutoSize = true;
            this.lblTongCongNo.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblTongCongNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.lblTongCongNo.Location = new System.Drawing.Point(14, 36);
            this.lblTongCongNo.Name = "lblTongCongNo";
            this.lblTongCongNo.Size = new System.Drawing.Size(61, 41);
            this.lblTongCongNo.TabIndex = 1;
            this.lblTongCongNo.Text = "0 d";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1371, 64);
            this.pnlHeader.TabIndex = 2;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(23, 13);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(260, 41);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Quản Lý Công Nợ";
            // 
            // ucCongNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.Controls.Add(this.pnlMain);
            this.Name = "ucCongNo";
            this.Size = new System.Drawing.Size(1371, 800);
            this.Load += new System.EventHandler(this.ucCongNo_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCongNo)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.pnlCards.ResumeLayout(false);
            this.cardQuaHan.ResumeLayout(false);
            this.cardQuaHan.PerformLayout();
            this.cardDaThanhToan.ResumeLayout(false);
            this.cardDaThanhToan.PerformLayout();
            this.cardTongCongNo.ResumeLayout(false);
            this.cardTongCongNo.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        // ===== Panels =====
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlCards;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlSearch;

        // ===== Cards =====
        private System.Windows.Forms.Panel cardTongCongNo;
        private System.Windows.Forms.Panel cardDaThanhToan;
        private System.Windows.Forms.Panel cardQuaHan;

        // ===== Labels =====
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblHoaDon;
        private System.Windows.Forms.Label lblHanThanhToan;
        private System.Windows.Forms.Label lblSoTienNo;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.Label lblSearchIcon;
        private System.Windows.Forms.Label lblTongCongNoTitle;
        private System.Windows.Forms.Label lblDaThanhToanTitle;
        private System.Windows.Forms.Label lblQuaHanTitle;
        public System.Windows.Forms.Label lblTongCongNo;
        public System.Windows.Forms.Label lblDaThanhToan;
        public System.Windows.Forms.Label lblQuaHan;

        // ===== ComboBox =====
        public System.Windows.Forms.ComboBox cboHoaDon;
        public System.Windows.Forms.ComboBox cboTrangThai;

        // ===== DateTimePicker =====
        public System.Windows.Forms.DateTimePicker dtHanThanhToan;
        public System.Windows.Forms.DateTimePicker dtNgayPhatSinh;

        // ===== TextBox =====
        public System.Windows.Forms.TextBox txtSoTienNo;
        public System.Windows.Forms.TextBox txtGhiChu;
        public System.Windows.Forms.TextBox txtSearch;

        // ===== Button =====
        public System.Windows.Forms.Button btnThem;
        public System.Windows.Forms.Button btnSua;
        public System.Windows.Forms.Button btnXoa;
        public System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnBaoCao;

        // ===== DataGridView =====
        public System.Windows.Forms.DataGridView dgvCongNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCanHo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCuDan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoTienNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHanThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
    }
}