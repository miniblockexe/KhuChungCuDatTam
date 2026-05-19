namespace KhuChungCuDatTam.UserControls
{
    partial class ucAuditLog
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.dgvAuditLog = new System.Windows.Forms.DataGridView();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnLoc = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.dtDenNgay = new System.Windows.Forms.DateTimePicker();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.dtTuNgay = new System.Windows.Forms.DateTimePicker();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.cboModule = new System.Windows.Forms.ComboBox();
            this.lblModuleFilter = new System.Windows.Forms.Label();
            this.cboNguoiDung = new System.Windows.Forms.ComboBox();
            this.lblNguoiDungFilter = new System.Windows.Forms.Label();
            this.lblFilterTitle = new System.Windows.Forms.Label();
            this.panelCards = new System.Windows.Forms.Panel();
            this.cardNguoiDung = new System.Windows.Forms.Panel();
            this.lblNguoiDungIcon = new System.Windows.Forms.Label();
            this.lblNguoiDungHoatDong = new System.Windows.Forms.Label();
            this.lblNguoiDungTitle = new System.Windows.Forms.Label();
            this.cardHomNay = new System.Windows.Forms.Panel();
            this.lblHomNayIcon = new System.Windows.Forms.Label();
            this.lblHomNay = new System.Windows.Forms.Label();
            this.lblHomNayTitle = new System.Windows.Forms.Label();
            this.cardTongLog = new System.Windows.Forms.Panel();
            this.lblTongLogIcon = new System.Windows.Forms.Label();
            this.lblTongLog = new System.Windows.Forms.Label();
            this.lblTongLogTitle = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditLog)).BeginInit();
            this.panelFilter.SuspendLayout();
            this.panelCards.SuspendLayout();
            this.cardNguoiDung.SuspendLayout();
            this.cardHomNay.SuspendLayout();
            this.cardTongLog.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.panelMain.Controls.Add(this.panelGrid);
            this.panelMain.Controls.Add(this.panelFilter);
            this.panelMain.Controls.Add(this.panelCards);
            this.panelMain.Controls.Add(this.panelHeader);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(23, 21, 23, 21);
            this.panelMain.Size = new System.Drawing.Size(1371, 800);
            this.panelMain.TabIndex = 0;
            // 
            // panelGrid
            // 
            this.panelGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.panelGrid.Controls.Add(this.dgvAuditLog);
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrid.Location = new System.Drawing.Point(23, 331);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Padding = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.panelGrid.Size = new System.Drawing.Size(1325, 448);
            this.panelGrid.TabIndex = 3;
            // 
            // dgvAuditLog
            // 
            this.dgvAuditLog.AllowUserToAddRows = false;
            this.dgvAuditLog.AllowUserToDeleteRows = false;
            this.dgvAuditLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAuditLog.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.dgvAuditLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAuditLog.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAuditLog.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.dgvAuditLog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAuditLog.ColumnHeadersHeight = 38;
            this.dgvAuditLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAuditLog.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAuditLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAuditLog.EnableHeadersVisualStyles = false;
            this.dgvAuditLog.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.dgvAuditLog.Location = new System.Drawing.Point(14, 13);
            this.dgvAuditLog.MultiSelect = false;
            this.dgvAuditLog.Name = "dgvAuditLog";
            this.dgvAuditLog.ReadOnly = true;
            this.dgvAuditLog.RowHeadersVisible = false;
            this.dgvAuditLog.RowHeadersWidth = 51;
            this.dgvAuditLog.RowTemplate.Height = 36;
            this.dgvAuditLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAuditLog.Size = new System.Drawing.Size(1297, 422);
            this.dgvAuditLog.TabIndex = 0;
            // 
            // panelFilter
            // 
            this.panelFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.panelFilter.Controls.Add(this.btnXuatExcel);
            this.panelFilter.Controls.Add(this.btnLamMoi);
            this.panelFilter.Controls.Add(this.btnLoc);
            this.panelFilter.Controls.Add(this.txtSearch);
            this.panelFilter.Controls.Add(this.lblSearch);
            this.panelFilter.Controls.Add(this.dtDenNgay);
            this.panelFilter.Controls.Add(this.lblDenNgay);
            this.panelFilter.Controls.Add(this.dtTuNgay);
            this.panelFilter.Controls.Add(this.lblTuNgay);
            this.panelFilter.Controls.Add(this.cboModule);
            this.panelFilter.Controls.Add(this.lblModuleFilter);
            this.panelFilter.Controls.Add(this.cboNguoiDung);
            this.panelFilter.Controls.Add(this.lblNguoiDungFilter);
            this.panelFilter.Controls.Add(this.lblFilterTitle);
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilter.Location = new System.Drawing.Point(23, 192);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Padding = new System.Windows.Forms.Padding(18, 13, 18, 13);
            this.panelFilter.Size = new System.Drawing.Size(1325, 139);
            this.panelFilter.TabIndex = 2;
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.btnXuatExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXuatExcel.FlatAppearance.BorderSize = 0;
            this.btnXuatExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatExcel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXuatExcel.ForeColor = System.Drawing.Color.White;
            this.btnXuatExcel.Location = new System.Drawing.Point(1248, 53);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(59, 32);
            this.btnXuatExcel.TabIndex = 13;
            this.btnXuatExcel.Text = "📥";
            this.btnXuatExcel.UseVisualStyleBackColor = false;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(1134, 53);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(103, 32);
            this.btnLamMoi.TabIndex = 12;
            this.btnLamMoi.Text = "↺  Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // btnLoc
            // 
            this.btnLoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnLoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoc.FlatAppearance.BorderSize = 0;
            this.btnLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLoc.ForeColor = System.Drawing.Color.White;
            this.btnLoc.Location = new System.Drawing.Point(1019, 53);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(103, 32);
            this.btnLoc.TabIndex = 11;
            this.btnLoc.Text = "🔍  Lọc";
            this.btnLoc.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.Location = new System.Drawing.Point(773, 58);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(228, 27);
            this.txtSearch.TabIndex = 10;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblSearch.Location = new System.Drawing.Point(773, 38);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(70, 20);
            this.lblSearch.TabIndex = 9;
            this.lblSearch.Text = "Tìm kiếm";
            // 
            // dtDenNgay
            // 
            this.dtDenNgay.CalendarForeColor = System.Drawing.Color.White;
            this.dtDenNgay.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.dtDenNgay.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.dtDenNgay.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dtDenNgay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDenNgay.Location = new System.Drawing.Point(608, 58);
            this.dtDenNgay.Name = "dtDenNgay";
            this.dtDenNgay.Size = new System.Drawing.Size(148, 27);
            this.dtDenNgay.TabIndex = 8;
            // 
            // lblDenNgay
            // 
            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblDenNgay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblDenNgay.Location = new System.Drawing.Point(608, 38);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(72, 20);
            this.lblDenNgay.TabIndex = 7;
            this.lblDenNgay.Text = "Đến ngày";
            // 
            // dtTuNgay
            // 
            this.dtTuNgay.CalendarForeColor = System.Drawing.Color.White;
            this.dtTuNgay.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.dtTuNgay.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.dtTuNgay.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dtTuNgay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTuNgay.Location = new System.Drawing.Point(443, 58);
            this.dtTuNgay.Name = "dtTuNgay";
            this.dtTuNgay.Size = new System.Drawing.Size(148, 27);
            this.dtTuNgay.TabIndex = 6;
            // 
            // lblTuNgay
            // 
            this.lblTuNgay.AutoSize = true;
            this.lblTuNgay.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblTuNgay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblTuNgay.Location = new System.Drawing.Point(443, 38);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(62, 20);
            this.lblTuNgay.TabIndex = 5;
            this.lblTuNgay.Text = "Từ ngày";
            // 
            // cboModule
            // 
            this.cboModule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.cboModule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboModule.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboModule.ForeColor = System.Drawing.Color.White;
            this.cboModule.Location = new System.Drawing.Point(242, 58);
            this.cboModule.Name = "cboModule";
            this.cboModule.Size = new System.Drawing.Size(182, 28);
            this.cboModule.TabIndex = 4;
            // 
            // lblModuleFilter
            // 
            this.lblModuleFilter.AutoSize = true;
            this.lblModuleFilter.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblModuleFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblModuleFilter.Location = new System.Drawing.Point(242, 38);
            this.lblModuleFilter.Name = "lblModuleFilter";
            this.lblModuleFilter.Size = new System.Drawing.Size(108, 20);
            this.lblModuleFilter.TabIndex = 3;
            this.lblModuleFilter.Text = "Bảng / Module";
            // 
            // cboNguoiDung
            // 
            this.cboNguoiDung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.cboNguoiDung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNguoiDung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboNguoiDung.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboNguoiDung.ForeColor = System.Drawing.Color.White;
            this.cboNguoiDung.Location = new System.Drawing.Point(18, 58);
            this.cboNguoiDung.Name = "cboNguoiDung";
            this.cboNguoiDung.Size = new System.Drawing.Size(205, 28);
            this.cboNguoiDung.TabIndex = 2;
            // 
            // lblNguoiDungFilter
            // 
            this.lblNguoiDungFilter.AutoSize = true;
            this.lblNguoiDungFilter.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblNguoiDungFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblNguoiDungFilter.Location = new System.Drawing.Point(18, 38);
            this.lblNguoiDungFilter.Name = "lblNguoiDungFilter";
            this.lblNguoiDungFilter.Size = new System.Drawing.Size(89, 20);
            this.lblNguoiDungFilter.TabIndex = 1;
            this.lblNguoiDungFilter.Text = "Người dùng";
            // 
            // lblFilterTitle
            // 
            this.lblFilterTitle.AutoSize = true;
            this.lblFilterTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFilterTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.lblFilterTitle.Location = new System.Drawing.Point(18, 13);
            this.lblFilterTitle.Name = "lblFilterTitle";
            this.lblFilterTitle.Size = new System.Drawing.Size(125, 20);
            this.lblFilterTitle.TabIndex = 0;
            this.lblFilterTitle.Text = "BỘ LỌC DỮ LIỆU";
            // 
            // panelCards
            // 
            this.panelCards.BackColor = System.Drawing.Color.Transparent;
            this.panelCards.Controls.Add(this.cardNguoiDung);
            this.panelCards.Controls.Add(this.cardHomNay);
            this.panelCards.Controls.Add(this.cardTongLog);
            this.panelCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCards.Location = new System.Drawing.Point(23, 85);
            this.panelCards.Name = "panelCards";
            this.panelCards.Size = new System.Drawing.Size(1325, 107);
            this.panelCards.TabIndex = 1;
            // 
            // cardNguoiDung
            // 
            this.cardNguoiDung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.cardNguoiDung.Controls.Add(this.lblNguoiDungIcon);
            this.cardNguoiDung.Controls.Add(this.lblNguoiDungHoatDong);
            this.cardNguoiDung.Controls.Add(this.lblNguoiDungTitle);
            this.cardNguoiDung.Location = new System.Drawing.Point(585, 0);
            this.cardNguoiDung.Name = "cardNguoiDung";
            this.cardNguoiDung.Padding = new System.Windows.Forms.Padding(18, 13, 18, 13);
            this.cardNguoiDung.Size = new System.Drawing.Size(274, 96);
            this.cardNguoiDung.TabIndex = 2;
            // 
            // lblNguoiDungIcon
            // 
            this.lblNguoiDungIcon.AutoSize = true;
            this.lblNguoiDungIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 20F);
            this.lblNguoiDungIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(85)))), ((int)(((byte)(247)))));
            this.lblNguoiDungIcon.Location = new System.Drawing.Point(206, 19);
            this.lblNguoiDungIcon.Name = "lblNguoiDungIcon";
            this.lblNguoiDungIcon.Size = new System.Drawing.Size(67, 46);
            this.lblNguoiDungIcon.TabIndex = 2;
            this.lblNguoiDungIcon.Text = "👥";
            // 
            // lblNguoiDungHoatDong
            // 
            this.lblNguoiDungHoatDong.AutoSize = true;
            this.lblNguoiDungHoatDong.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblNguoiDungHoatDong.ForeColor = System.Drawing.Color.White;
            this.lblNguoiDungHoatDong.Location = new System.Drawing.Point(14, 33);
            this.lblNguoiDungHoatDong.Name = "lblNguoiDungHoatDong";
            this.lblNguoiDungHoatDong.Size = new System.Drawing.Size(43, 50);
            this.lblNguoiDungHoatDong.TabIndex = 1;
            this.lblNguoiDungHoatDong.Text = "0";
            // 
            // lblNguoiDungTitle
            // 
            this.lblNguoiDungTitle.AutoSize = true;
            this.lblNguoiDungTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblNguoiDungTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblNguoiDungTitle.Location = new System.Drawing.Point(18, 15);
            this.lblNguoiDungTitle.Name = "lblNguoiDungTitle";
            this.lblNguoiDungTitle.Size = new System.Drawing.Size(169, 20);
            this.lblNguoiDungTitle.TabIndex = 0;
            this.lblNguoiDungTitle.Text = "Người Dùng Hoạt Động";
            // 
            // cardHomNay
            // 
            this.cardHomNay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.cardHomNay.Controls.Add(this.lblHomNayIcon);
            this.cardHomNay.Controls.Add(this.lblHomNay);
            this.cardHomNay.Controls.Add(this.lblHomNayTitle);
            this.cardHomNay.Location = new System.Drawing.Point(293, 0);
            this.cardHomNay.Name = "cardHomNay";
            this.cardHomNay.Padding = new System.Windows.Forms.Padding(18, 13, 18, 13);
            this.cardHomNay.Size = new System.Drawing.Size(274, 96);
            this.cardHomNay.TabIndex = 1;
            // 
            // lblHomNayIcon
            // 
            this.lblHomNayIcon.AutoSize = true;
            this.lblHomNayIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 20F);
            this.lblHomNayIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.lblHomNayIcon.Location = new System.Drawing.Point(206, 19);
            this.lblHomNayIcon.Name = "lblHomNayIcon";
            this.lblHomNayIcon.Size = new System.Drawing.Size(67, 46);
            this.lblHomNayIcon.TabIndex = 2;
            this.lblHomNayIcon.Text = "📅";
            // 
            // lblHomNay
            // 
            this.lblHomNay.AutoSize = true;
            this.lblHomNay.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblHomNay.ForeColor = System.Drawing.Color.White;
            this.lblHomNay.Location = new System.Drawing.Point(14, 33);
            this.lblHomNay.Name = "lblHomNay";
            this.lblHomNay.Size = new System.Drawing.Size(43, 50);
            this.lblHomNay.TabIndex = 1;
            this.lblHomNay.Text = "0";
            // 
            // lblHomNayTitle
            // 
            this.lblHomNayTitle.AutoSize = true;
            this.lblHomNayTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblHomNayTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblHomNayTitle.Location = new System.Drawing.Point(18, 15);
            this.lblHomNayTitle.Name = "lblHomNayTitle";
            this.lblHomNayTitle.Size = new System.Drawing.Size(72, 20);
            this.lblHomNayTitle.TabIndex = 0;
            this.lblHomNayTitle.Text = "Hôm Nay";
            // 
            // cardTongLog
            // 
            this.cardTongLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.cardTongLog.Controls.Add(this.lblTongLogIcon);
            this.cardTongLog.Controls.Add(this.lblTongLog);
            this.cardTongLog.Controls.Add(this.lblTongLogTitle);
            this.cardTongLog.Location = new System.Drawing.Point(0, 0);
            this.cardTongLog.Name = "cardTongLog";
            this.cardTongLog.Padding = new System.Windows.Forms.Padding(18, 13, 18, 13);
            this.cardTongLog.Size = new System.Drawing.Size(274, 96);
            this.cardTongLog.TabIndex = 0;
            // 
            // lblTongLogIcon
            // 
            this.lblTongLogIcon.AutoSize = true;
            this.lblTongLogIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 20F);
            this.lblTongLogIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.lblTongLogIcon.Location = new System.Drawing.Point(206, 19);
            this.lblTongLogIcon.Name = "lblTongLogIcon";
            this.lblTongLogIcon.Size = new System.Drawing.Size(67, 46);
            this.lblTongLogIcon.TabIndex = 2;
            this.lblTongLogIcon.Text = "📋";
            // 
            // lblTongLog
            // 
            this.lblTongLog.AutoSize = true;
            this.lblTongLog.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTongLog.ForeColor = System.Drawing.Color.White;
            this.lblTongLog.Location = new System.Drawing.Point(13, 35);
            this.lblTongLog.Name = "lblTongLog";
            this.lblTongLog.Size = new System.Drawing.Size(43, 50);
            this.lblTongLog.TabIndex = 1;
            this.lblTongLog.Text = "0";
            // 
            // lblTongLogTitle
            // 
            this.lblTongLogTitle.AutoSize = true;
            this.lblTongLogTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblTongLogTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblTongLogTitle.Location = new System.Drawing.Point(18, 15);
            this.lblTongLogTitle.Name = "lblTongLogTitle";
            this.lblTongLogTitle.Size = new System.Drawing.Size(72, 20);
            this.lblTongLogTitle.TabIndex = 0;
            this.lblTongLogTitle.Text = "Tổng Log";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Transparent;
            this.panelHeader.Controls.Add(this.lblSubTitle);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(23, 21);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1325, 64);
            this.panelHeader.TabIndex = 0;
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblSubTitle.Location = new System.Drawing.Point(5, 41);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(175, 20);
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "Lịch sử thao tác hệ thống";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(215, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "🔍  Audit Log";
            // 
            // ucAuditLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.Controls.Add(this.panelMain);
            this.Name = "ucAuditLog";
            this.Size = new System.Drawing.Size(1371, 800);
            this.panelMain.ResumeLayout(false);
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditLog)).EndInit();
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            this.panelCards.ResumeLayout(false);
            this.cardNguoiDung.ResumeLayout(false);
            this.cardNguoiDung.PerformLayout();
            this.cardHomNay.ResumeLayout(false);
            this.cardHomNay.PerformLayout();
            this.cardTongLog.ResumeLayout(false);
            this.cardTongLog.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        // ── Panels ───────────────────────────────────────────────
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelCards;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.Panel panelGrid;

        // ── Header Labels ────────────────────────────────────────
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;

        // ── Cards ────────────────────────────────────────────────
        private System.Windows.Forms.Panel cardTongLog;
        private System.Windows.Forms.Label lblTongLogTitle;
        private System.Windows.Forms.Label lblTongLog;
        private System.Windows.Forms.Label lblTongLogIcon;

        private System.Windows.Forms.Panel cardHomNay;
        private System.Windows.Forms.Label lblHomNayTitle;
        private System.Windows.Forms.Label lblHomNay;
        private System.Windows.Forms.Label lblHomNayIcon;

        private System.Windows.Forms.Panel cardNguoiDung;
        private System.Windows.Forms.Label lblNguoiDungTitle;
        private System.Windows.Forms.Label lblNguoiDungHoatDong;
        private System.Windows.Forms.Label lblNguoiDungIcon;

        // ── Filter Controls ──────────────────────────────────────
        private System.Windows.Forms.Label lblFilterTitle;
        private System.Windows.Forms.Label lblNguoiDungFilter;
        private System.Windows.Forms.ComboBox cboNguoiDung;
        private System.Windows.Forms.Label lblModuleFilter;
        private System.Windows.Forms.ComboBox cboModule;
        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.DateTimePicker dtTuNgay;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.DateTimePicker dtDenNgay;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXuatExcel;

        // ── Grid ─────────────────────────────────────────────────
        private System.Windows.Forms.DataGridView dgvAuditLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNguoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHanhDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBanGhiId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMoTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThoiGian;
    }
}