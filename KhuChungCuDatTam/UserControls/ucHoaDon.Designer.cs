namespace KhuChungCuDatTam.UserControls
{
    partial class ucHoaDon
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
            System.Windows.Forms.DataGridViewCellStyle cellStyleAlt = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle cellStyleHeader = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle cellStyleRow = new System.Windows.Forms.DataGridViewCellStyle();

            this.panelTop = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();

            this.panelStats = new System.Windows.Forms.Panel();
            this.panelCardTong = new System.Windows.Forms.Panel();
            this.lblTongHoaDon = new System.Windows.Forms.Label();
            this.lblTongHoaDonVal = new System.Windows.Forms.Label();
            this.panelCardDaThanhToan = new System.Windows.Forms.Panel();
            this.lblDaThanhToan = new System.Windows.Forms.Label();
            this.lblDaThanhToanVal = new System.Windows.Forms.Label();
            this.panelCardChuaThanhToan = new System.Windows.Forms.Panel();
            this.lblChuaThanhToan = new System.Windows.Forms.Label();
            this.lblChuaThanhToanVal = new System.Windows.Forms.Label();
            this.panelCardQuaHan = new System.Windows.Forms.Panel();
            this.lblQuaHan = new System.Windows.Forms.Label();
            this.lblQuaHanVal = new System.Windows.Forms.Label();

            this.panelMain = new System.Windows.Forms.Panel();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCanHo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCuDan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThangNam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTienDien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTienNuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhiGuiXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhiDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhiKhac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayTao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.panelForm = new System.Windows.Forms.Panel();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.lblCanHo = new System.Windows.Forms.Label();
            this.cboCanHo = new System.Windows.Forms.ComboBox();
            this.lblThangNam = new System.Windows.Forms.Label();
            this.dtThangNam = new System.Windows.Forms.DateTimePicker();
            this.lblTienDien = new System.Windows.Forms.Label();
            this.txtTienDien = new System.Windows.Forms.TextBox();
            this.lblTienNuoc = new System.Windows.Forms.Label();
            this.txtTienNuoc = new System.Windows.Forms.TextBox();
            this.lblTienGuiXe = new System.Windows.Forms.Label();
            this.txtPhiGuiXe = new System.Windows.Forms.TextBox();
            this.lblTienBaoTri = new System.Windows.Forms.Label();
            this.txtPhiDichVu = new System.Windows.Forms.TextBox();
            this.lblTienPhiKhac = new System.Windows.Forms.Label();
            this.txtTienPhiKhac = new System.Windows.Forms.TextBox();
            this.btnTinhTong = new System.Windows.Forms.Button();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.lblNgayTao = new System.Windows.Forms.Label();
            this.dtNgayTao = new System.Windows.Forms.DateTimePicker();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();

            // ── Suspend ──────────────────────────────────────────────────────────
            this.panelTop.SuspendLayout();
            this.panelStats.SuspendLayout();
            this.panelCardTong.SuspendLayout();
            this.panelCardDaThanhToan.SuspendLayout();
            this.panelCardChuaThanhToan.SuspendLayout();
            this.panelCardQuaHan.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.panelForm.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();

            // ════════════════════════════════════════════════════════════════════
            // panelTop  (height 70)
            // ════════════════════════════════════════════════════════════════════
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1280, 70);
            this.panelTop.TabIndex = 2;
            this.panelTop.Controls.Add(this.txtSearch);
            this.panelTop.Controls.Add(this.lblTitle);

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(23, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Quản Lý Hóa Đơn";

            // txtSearch
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.txtSearch.Location = new System.Drawing.Point(880, 22);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(360, 30);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Text = "🔍  Tìm kiếm hóa đơn...";

            // ════════════════════════════════════════════════════════════════════
            // panelStats  (height 110)
            // ════════════════════════════════════════════════════════════════════
            this.panelStats.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.panelStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStats.Location = new System.Drawing.Point(0, 70);
            this.panelStats.Name = "panelStats";
            this.panelStats.Size = new System.Drawing.Size(1280, 110);
            this.panelStats.TabIndex = 1;
            this.panelStats.Controls.Add(this.panelCardQuaHan);
            this.panelStats.Controls.Add(this.panelCardChuaThanhToan);
            this.panelStats.Controls.Add(this.panelCardDaThanhToan);
            this.panelStats.Controls.Add(this.panelCardTong);

            // ── Card: Tổng hóa đơn ──────────────────────────────────────────────
            this.panelCardTong.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.panelCardTong.Location = new System.Drawing.Point(20, 12);
            this.panelCardTong.Name = "panelCardTong";
            this.panelCardTong.Size = new System.Drawing.Size(270, 80);
            this.panelCardTong.TabIndex = 3;
            this.panelCardTong.Controls.Add(this.lblTongHoaDon);
            this.panelCardTong.Controls.Add(this.lblTongHoaDonVal);

            this.lblTongHoaDon.AutoSize = true;
            this.lblTongHoaDon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTongHoaDon.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblTongHoaDon.Location = new System.Drawing.Point(14, 12);
            this.lblTongHoaDon.Name = "lblTongHoaDon";
            this.lblTongHoaDon.TabIndex = 1;
            this.lblTongHoaDon.Text = "TỔNG HÓA ĐƠN";

            this.lblTongHoaDonVal.AutoSize = true;
            this.lblTongHoaDonVal.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTongHoaDonVal.ForeColor = System.Drawing.Color.FromArgb(59, 130, 246);
            this.lblTongHoaDonVal.Location = new System.Drawing.Point(9, 30);
            this.lblTongHoaDonVal.Name = "lblTongHoaDonVal";
            this.lblTongHoaDonVal.TabIndex = 0;
            this.lblTongHoaDonVal.Text = "0";

            // ── Card: Đã thanh toán ──────────────────────────────────────────────
            this.panelCardDaThanhToan.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.panelCardDaThanhToan.Location = new System.Drawing.Point(310, 12);
            this.panelCardDaThanhToan.Name = "panelCardDaThanhToan";
            this.panelCardDaThanhToan.Size = new System.Drawing.Size(270, 80);
            this.panelCardDaThanhToan.TabIndex = 2;
            this.panelCardDaThanhToan.Controls.Add(this.lblDaThanhToan);
            this.panelCardDaThanhToan.Controls.Add(this.lblDaThanhToanVal);

            this.lblDaThanhToan.AutoSize = true;
            this.lblDaThanhToan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDaThanhToan.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblDaThanhToan.Location = new System.Drawing.Point(14, 12);
            this.lblDaThanhToan.Name = "lblDaThanhToan";
            this.lblDaThanhToan.TabIndex = 1;
            this.lblDaThanhToan.Text = "ĐÃ THANH TOÁN";

            this.lblDaThanhToanVal.AutoSize = true;
            this.lblDaThanhToanVal.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblDaThanhToanVal.ForeColor = System.Drawing.Color.FromArgb(34, 197, 94);
            this.lblDaThanhToanVal.Location = new System.Drawing.Point(9, 30);
            this.lblDaThanhToanVal.Name = "lblDaThanhToanVal";
            this.lblDaThanhToanVal.TabIndex = 0;
            this.lblDaThanhToanVal.Text = "0";

            // ── Card: Chưa thanh toán ────────────────────────────────────────────
            this.panelCardChuaThanhToan.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.panelCardChuaThanhToan.Location = new System.Drawing.Point(600, 12);
            this.panelCardChuaThanhToan.Name = "panelCardChuaThanhToan";
            this.panelCardChuaThanhToan.Size = new System.Drawing.Size(270, 80);
            this.panelCardChuaThanhToan.TabIndex = 1;
            this.panelCardChuaThanhToan.Controls.Add(this.lblChuaThanhToan);
            this.panelCardChuaThanhToan.Controls.Add(this.lblChuaThanhToanVal);

            this.lblChuaThanhToan.AutoSize = true;
            this.lblChuaThanhToan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblChuaThanhToan.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblChuaThanhToan.Location = new System.Drawing.Point(14, 12);
            this.lblChuaThanhToan.Name = "lblChuaThanhToan";
            this.lblChuaThanhToan.TabIndex = 1;
            this.lblChuaThanhToan.Text = "CHƯA THANH TOÁN";

            this.lblChuaThanhToanVal.AutoSize = true;
            this.lblChuaThanhToanVal.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblChuaThanhToanVal.ForeColor = System.Drawing.Color.FromArgb(251, 191, 36);
            this.lblChuaThanhToanVal.Location = new System.Drawing.Point(9, 30);
            this.lblChuaThanhToanVal.Name = "lblChuaThanhToanVal";
            this.lblChuaThanhToanVal.TabIndex = 0;
            this.lblChuaThanhToanVal.Text = "0";

            // ── Card: Quá hạn ───────────────────────────────────────────────────
            this.panelCardQuaHan.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.panelCardQuaHan.Location = new System.Drawing.Point(890, 12);
            this.panelCardQuaHan.Name = "panelCardQuaHan";
            this.panelCardQuaHan.Size = new System.Drawing.Size(270, 80);
            this.panelCardQuaHan.TabIndex = 0;
            this.panelCardQuaHan.Controls.Add(this.lblQuaHan);
            this.panelCardQuaHan.Controls.Add(this.lblQuaHanVal);

            this.lblQuaHan.AutoSize = true;
            this.lblQuaHan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblQuaHan.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblQuaHan.Location = new System.Drawing.Point(14, 12);
            this.lblQuaHan.Name = "lblQuaHan";
            this.lblQuaHan.TabIndex = 1;
            this.lblQuaHan.Text = "QUÁ HẠN";

            this.lblQuaHanVal.AutoSize = true;
            this.lblQuaHanVal.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblQuaHanVal.ForeColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.lblQuaHanVal.Location = new System.Drawing.Point(9, 30);
            this.lblQuaHanVal.Name = "lblQuaHanVal";
            this.lblQuaHanVal.TabIndex = 0;
            this.lblQuaHanVal.Text = "0";

            // ════════════════════════════════════════════════════════════════════
            // panelMain  (Fill)
            // ════════════════════════════════════════════════════════════════════
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 180);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(10, 8, 10, 10);
            this.panelMain.Size = new System.Drawing.Size(1280, 620);
            this.panelMain.TabIndex = 0;
            this.panelMain.Controls.Add(this.panelGrid);
            this.panelMain.Controls.Add(this.panelForm);

            // ════════════════════════════════════════════════════════════════════
            // panelGrid  (Fill)
            // ════════════════════════════════════════════════════════════════════
            this.panelGrid.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrid.Location = new System.Drawing.Point(385, 8);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Padding = new System.Windows.Forms.Padding(8);
            this.panelGrid.Size = new System.Drawing.Size(885, 602);
            this.panelGrid.TabIndex = 0;
            this.panelGrid.Controls.Add(this.dgvHoaDon);

            // ── DataGridView ─────────────────────────────────────────────────────
            cellStyleAlt.BackColor = System.Drawing.Color.FromArgb(22, 33, 51);

            cellStyleHeader.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            cellStyleHeader.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            cellStyleHeader.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            cellStyleHeader.SelectionBackColor = System.Drawing.Color.FromArgb(15, 23, 42);

            cellStyleRow.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            cellStyleRow.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            cellStyleRow.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            cellStyleRow.ForeColor = System.Drawing.Color.White;
            cellStyleRow.SelectionBackColor = System.Drawing.Color.FromArgb(59, 130, 246);
            cellStyleRow.SelectionForeColor = System.Drawing.Color.White;
            cellStyleRow.WrapMode = System.Windows.Forms.DataGridViewTriState.False;

            this.dgvHoaDon.AllowUserToAddRows = false;
            this.dgvHoaDon.AllowUserToDeleteRows = false;
            this.dgvHoaDon.AlternatingRowsDefaultCellStyle = cellStyleAlt;
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDon.BackgroundColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.dgvHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHoaDon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHoaDon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvHoaDon.ColumnHeadersDefaultCellStyle = cellStyleHeader;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.DefaultCellStyle = cellStyleRow;
            this.dgvHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHoaDon.GridColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.dgvHoaDon.Location = new System.Drawing.Point(8, 8);
            this.dgvHoaDon.MultiSelect = false;
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.ReadOnly = true;
            this.dgvHoaDon.RowHeadersVisible = false;
            this.dgvHoaDon.RowHeadersWidth = 51;
            this.dgvHoaDon.RowTemplate.Height = 36;
            this.dgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDon.Size = new System.Drawing.Size(869, 586);
            this.dgvHoaDon.TabIndex = 0;

            // Columns
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "ID";
            this.colId.MinimumWidth = 50;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;

            this.colCanHo.DataPropertyName = "CanHo";
            this.colCanHo.HeaderText = "Căn Hộ";
            this.colCanHo.MinimumWidth = 80;
            this.colCanHo.Name = "colCanHo";
            this.colCanHo.ReadOnly = true;

            this.colCuDan.DataPropertyName = "CuDan";
            this.colCuDan.HeaderText = "Cư Dân";
            this.colCuDan.MinimumWidth = 160;
            this.colCuDan.Name = "colCuDan";
            this.colCuDan.ReadOnly = true;

            this.colThangNam.DataPropertyName = "ThangNam";
            this.colThangNam.HeaderText = "Tháng/Năm";
            this.colThangNam.MinimumWidth = 90;
            this.colThangNam.Name = "colThangNam";
            this.colThangNam.ReadOnly = true;

            this.colTienDien.DataPropertyName = "TienDien";
            this.colTienDien.HeaderText = "Tiền Điện";
            this.colTienDien.MinimumWidth = 100;
            this.colTienDien.Name = "colTienDien";
            this.colTienDien.ReadOnly = true;

            this.colTienNuoc.DataPropertyName = "TienNuoc";
            this.colTienNuoc.HeaderText = "Tiền Nước";
            this.colTienNuoc.MinimumWidth = 100;
            this.colTienNuoc.Name = "colTienNuoc";
            this.colTienNuoc.ReadOnly = true;

            this.colPhiGuiXe.DataPropertyName = "PhiGuiXe";
            this.colPhiGuiXe.HeaderText = "Phí Gửi Xe";
            this.colPhiGuiXe.MinimumWidth = 100;
            this.colPhiGuiXe.Name = "colPhiGuiXe";
            this.colPhiGuiXe.ReadOnly = true;

            this.colPhiDichVu.DataPropertyName = "PhiDichVu";
            this.colPhiDichVu.HeaderText = "Phí DV/BT";
            this.colPhiDichVu.MinimumWidth = 100;
            this.colPhiDichVu.Name = "colPhiDichVu";
            this.colPhiDichVu.ReadOnly = true;

            this.colPhiKhac.DataPropertyName = "PhiKhac";
            this.colPhiKhac.HeaderText = "Phí Khác";
            this.colPhiKhac.MinimumWidth = 90;
            this.colPhiKhac.Name = "colPhiKhac";
            this.colPhiKhac.ReadOnly = true;

            this.colTongTien.DataPropertyName = "TongTien";
            this.colTongTien.HeaderText = "Tổng Tiền";
            this.colTongTien.MinimumWidth = 120;
            this.colTongTien.Name = "colTongTien";
            this.colTongTien.ReadOnly = true;

            this.colNgayTao.DataPropertyName = "NgayTao";
            this.colNgayTao.HeaderText = "Ngày Tạo";
            this.colNgayTao.MinimumWidth = 90;
            this.colNgayTao.Name = "colNgayTao";
            this.colNgayTao.ReadOnly = true;

            this.colTrangThai.DataPropertyName = "TrangThai";
            this.colTrangThai.HeaderText = "Trạng Thái";
            this.colTrangThai.MinimumWidth = 120;
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.ReadOnly = true;

            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colId, this.colCanHo, this.colCuDan, this.colThangNam,
                this.colTienDien, this.colTienNuoc, this.colPhiGuiXe, this.colPhiDichVu,
                this.colPhiKhac, this.colTongTien, this.colNgayTao, this.colTrangThai
            });

            // ════════════════════════════════════════════════════════════════════
            // panelForm  (Left, width 375)
            // ════════════════════════════════════════════════════════════════════
            this.panelForm.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelForm.Location = new System.Drawing.Point(10, 8);
            this.panelForm.Name = "panelForm";
            this.panelForm.Padding = new System.Windows.Forms.Padding(16, 10, 16, 10);
            this.panelForm.Size = new System.Drawing.Size(375, 602);
            this.panelForm.TabIndex = 1;

            // ── lblFormTitle ─────────────────────────────────────────────────────
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = System.Drawing.Color.White;
            this.lblFormTitle.Location = new System.Drawing.Point(5, 10);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(340, 28);
            this.lblFormTitle.TabIndex = 22;
            this.lblFormTitle.Text = "Thông Tin Hóa Đơn";

            // ── Căn Hộ ───────────────────────────────────────────────────────────
            this.lblCanHo.AutoSize = true;
            this.lblCanHo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCanHo.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblCanHo.Location = new System.Drawing.Point(13, 46);
            this.lblCanHo.Name = "lblCanHo";
            this.lblCanHo.TabIndex = 21;
            this.lblCanHo.Text = "Căn Hộ";

            this.cboCanHo.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.cboCanHo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCanHo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCanHo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboCanHo.ForeColor = System.Drawing.Color.White;
            this.cboCanHo.Location = new System.Drawing.Point(16, 66);
            this.cboCanHo.Name = "cboCanHo";
            this.cboCanHo.Size = new System.Drawing.Size(336, 31);
            this.cboCanHo.TabIndex = 20;

            // ── Tháng / Năm ──────────────────────────────────────────────────────
            this.lblThangNam.AutoSize = true;
            this.lblThangNam.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblThangNam.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblThangNam.Location = new System.Drawing.Point(13, 105);
            this.lblThangNam.Name = "lblThangNam";
            this.lblThangNam.TabIndex = 19;
            this.lblThangNam.Text = "Tháng / Năm";

            this.dtThangNam.CustomFormat = "MM/yyyy";
            this.dtThangNam.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtThangNam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtThangNam.Location = new System.Drawing.Point(16, 125);
            this.dtThangNam.Name = "dtThangNam";
            this.dtThangNam.Size = new System.Drawing.Size(336, 30);
            this.dtThangNam.TabIndex = 18;

            // ── Tiền Điện ────────────────────────────────────────────────────────
            this.lblTienDien.AutoSize = true;
            this.lblTienDien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTienDien.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblTienDien.Location = new System.Drawing.Point(16, 163);
            this.lblTienDien.Name = "lblTienDien";
            this.lblTienDien.TabIndex = 17;
            this.lblTienDien.Text = "Tiền Điện (VNĐ)";

            this.txtTienDien.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.txtTienDien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTienDien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTienDien.ForeColor = System.Drawing.Color.White;
            this.txtTienDien.Location = new System.Drawing.Point(16, 183);
            this.txtTienDien.Name = "txtTienDien";
            this.txtTienDien.Size = new System.Drawing.Size(336, 30);
            this.txtTienDien.TabIndex = 16;
            this.txtTienDien.Text = "0";

            // ── Tiền Nước ────────────────────────────────────────────────────────
            this.lblTienNuoc.AutoSize = true;
            this.lblTienNuoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTienNuoc.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblTienNuoc.Location = new System.Drawing.Point(16, 220);
            this.lblTienNuoc.Name = "lblTienNuoc";
            this.lblTienNuoc.TabIndex = 15;
            this.lblTienNuoc.Text = "Tiền Nước (VNĐ)";

            this.txtTienNuoc.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.txtTienNuoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTienNuoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTienNuoc.ForeColor = System.Drawing.Color.White;
            this.txtTienNuoc.Location = new System.Drawing.Point(16, 240);
            this.txtTienNuoc.Name = "txtTienNuoc";
            this.txtTienNuoc.Size = new System.Drawing.Size(336, 30);
            this.txtTienNuoc.TabIndex = 14;
            this.txtTienNuoc.Text = "0";

            // ── Phí Gửi Xe ──────────────────────────────────────────────────────
            this.lblTienGuiXe.AutoSize = true;
            this.lblTienGuiXe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTienGuiXe.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblTienGuiXe.Location = new System.Drawing.Point(16, 277);
            this.lblTienGuiXe.Name = "lblTienGuiXe";
            this.lblTienGuiXe.TabIndex = 13;
            this.lblTienGuiXe.Text = "Phí Gửi Xe (VNĐ)";

            this.txtPhiGuiXe.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.txtPhiGuiXe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhiGuiXe.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPhiGuiXe.ForeColor = System.Drawing.Color.White;
            this.txtPhiGuiXe.Location = new System.Drawing.Point(16, 297);
            this.txtPhiGuiXe.Name = "txtPhiGuiXe";
            this.txtPhiGuiXe.Size = new System.Drawing.Size(336, 30);
            this.txtPhiGuiXe.TabIndex = 12;
            this.txtPhiGuiXe.Text = "0";

            // ── Phí Dịch Vụ / Bảo Trì ───────────────────────────────────────────
            this.lblTienBaoTri.AutoSize = true;
            this.lblTienBaoTri.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTienBaoTri.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblTienBaoTri.Location = new System.Drawing.Point(16, 334);
            this.lblTienBaoTri.Name = "lblTienBaoTri";
            this.lblTienBaoTri.TabIndex = 11;
            this.lblTienBaoTri.Text = "Phí Dịch Vụ / Bảo Trì (VNĐ)";

            this.txtPhiDichVu.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.txtPhiDichVu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhiDichVu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPhiDichVu.ForeColor = System.Drawing.Color.White;
            this.txtPhiDichVu.Location = new System.Drawing.Point(16, 354);
            this.txtPhiDichVu.Name = "txtPhiDichVu";
            this.txtPhiDichVu.Size = new System.Drawing.Size(336, 30);
            this.txtPhiDichVu.TabIndex = 10;
            this.txtPhiDichVu.Text = "0";

            // ── Phí Khác ────────────────────────────────────────────────────────
            this.lblTienPhiKhac.AutoSize = true;
            this.lblTienPhiKhac.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTienPhiKhac.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblTienPhiKhac.Location = new System.Drawing.Point(16, 391);
            this.lblTienPhiKhac.Name = "lblTienPhiKhac";
            this.lblTienPhiKhac.TabIndex = 9;
            this.lblTienPhiKhac.Text = "Phí Khác (VNĐ)";

            this.txtTienPhiKhac.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.txtTienPhiKhac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTienPhiKhac.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTienPhiKhac.ForeColor = System.Drawing.Color.White;
            this.txtTienPhiKhac.Location = new System.Drawing.Point(16, 411);
            this.txtTienPhiKhac.Name = "txtTienPhiKhac";
            this.txtTienPhiKhac.Size = new System.Drawing.Size(336, 30);
            this.txtTienPhiKhac.TabIndex = 8;
            this.txtTienPhiKhac.Text = "0";

            // ── Tính Tổng Tiền (button) ───────────────────────────────────────────
            this.btnTinhTong.BackColor = System.Drawing.Color.FromArgb(59, 130, 246);
            this.btnTinhTong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTinhTong.FlatAppearance.BorderSize = 0;
            this.btnTinhTong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTinhTong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTinhTong.ForeColor = System.Drawing.Color.White;
            this.btnTinhTong.Location = new System.Drawing.Point(16, 448);
            this.btnTinhTong.Name = "btnTinhTong";
            this.btnTinhTong.Size = new System.Drawing.Size(336, 30);
            this.btnTinhTong.TabIndex = 7;
            this.btnTinhTong.Text = "Tính Tổng Tiền";
            this.btnTinhTong.UseVisualStyleBackColor = false;

            // ── Tổng Tiền ────────────────────────────────────────────────────────
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTongTien.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblTongTien.Location = new System.Drawing.Point(12, 484);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.TabIndex = 6;
            this.lblTongTien.Text = "Tổng Tiền (VNĐ)";

            this.txtTongTien.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.txtTongTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTongTien.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.txtTongTien.ForeColor = System.Drawing.Color.FromArgb(59, 130, 246);
            this.txtTongTien.Location = new System.Drawing.Point(16, 502);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(336, 32);
            this.txtTongTien.TabIndex = 5;
            this.txtTongTien.Text = "0";

            // ── Ngày Tạo ─────────────────────────────────────────────────────────
            this.lblNgayTao.AutoSize = true;
            this.lblNgayTao.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNgayTao.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblNgayTao.Location = new System.Drawing.Point(13, 540);
            this.lblNgayTao.Name = "lblNgayTao";
            this.lblNgayTao.TabIndex = 4;
            this.lblNgayTao.Text = "Ngày Tạo";

            this.dtNgayTao.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtNgayTao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayTao.Location = new System.Drawing.Point(16, 558);
            this.dtNgayTao.Name = "dtNgayTao";
            this.dtNgayTao.Size = new System.Drawing.Size(336, 30);
            this.dtNgayTao.TabIndex = 3;

            // ── Trạng Thái ───────────────────────────────────────────────────────
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTrangThai.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblTrangThai.Location = new System.Drawing.Point(13, 595);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.TabIndex = 2;
            this.lblTrangThai.Text = "Trạng Thái";

            this.cboTrangThai.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTrangThai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboTrangThai.ForeColor = System.Drawing.Color.White;
            this.cboTrangThai.Items.AddRange(new object[] { "Chưa thanh toán", "Đã thanh toán", "Quá hạn" });
            this.cboTrangThai.Location = new System.Drawing.Point(16, 613);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(336, 31);
            this.cboTrangThai.TabIndex = 1;

            // ── panelButtons ─────────────────────────────────────────────────────
            // FIX: đặt trong panelForm nhưng dùng Anchor để nằm sát đáy
            this.panelButtons.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.panelButtons.Location = new System.Drawing.Point(16, 652);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(336, 44);
            this.panelButtons.TabIndex = 0;
            this.panelButtons.Controls.Add(this.btnThem);
            this.panelButtons.Controls.Add(this.btnSua);
            this.panelButtons.Controls.Add(this.btnXoa);
            this.panelButtons.Controls.Add(this.btnLamMoi);

            // btnThem
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(59, 130, 246);
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(0, 6);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(76, 32);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;

            // btnSua
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(234, 179, 8);
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(82, 6);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(76, 32);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;

            // btnXoa
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(164, 6);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(76, 32);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;

            // btnLamMoi
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(246, 6);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(90, 32);
            this.btnLamMoi.TabIndex = 0;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;

            // ── Add controls to panelForm ─────────────────────────────────────────
            this.panelForm.Controls.Add(this.lblFormTitle);
            this.panelForm.Controls.Add(this.lblCanHo);
            this.panelForm.Controls.Add(this.cboCanHo);
            this.panelForm.Controls.Add(this.lblThangNam);
            this.panelForm.Controls.Add(this.dtThangNam);
            this.panelForm.Controls.Add(this.lblTienDien);
            this.panelForm.Controls.Add(this.txtTienDien);
            this.panelForm.Controls.Add(this.lblTienNuoc);
            this.panelForm.Controls.Add(this.txtTienNuoc);
            this.panelForm.Controls.Add(this.lblTienGuiXe);
            this.panelForm.Controls.Add(this.txtPhiGuiXe);
            this.panelForm.Controls.Add(this.lblTienBaoTri);
            this.panelForm.Controls.Add(this.txtPhiDichVu);
            this.panelForm.Controls.Add(this.lblTienPhiKhac);
            this.panelForm.Controls.Add(this.txtTienPhiKhac);
            this.panelForm.Controls.Add(this.btnTinhTong);
            this.panelForm.Controls.Add(this.lblTongTien);
            this.panelForm.Controls.Add(this.txtTongTien);
            this.panelForm.Controls.Add(this.lblNgayTao);
            this.panelForm.Controls.Add(this.dtNgayTao);
            this.panelForm.Controls.Add(this.lblTrangThai);
            this.panelForm.Controls.Add(this.cboTrangThai);
            this.panelForm.Controls.Add(this.panelButtons);

            // ── panelForm cần đủ cao để chứa hết controls + buttons ──────────────
            // panelButtons.Y=652 + height=44 + padding=10 → AutoScroll hoặc tăng height
            this.panelForm.AutoScroll = true;

            // ════════════════════════════════════════════════════════════════════
            // ucHoaDon (UserControl root)
            // ════════════════════════════════════════════════════════════════════
            this.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelStats);
            this.Controls.Add(this.panelTop);
            this.Name = "ucHoaDon";
            this.Size = new System.Drawing.Size(1280, 800);

            // ── Resume ───────────────────────────────────────────────────────────
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelStats.ResumeLayout(false);
            this.panelCardTong.ResumeLayout(false);
            this.panelCardTong.PerformLayout();
            this.panelCardDaThanhToan.ResumeLayout(false);
            this.panelCardDaThanhToan.PerformLayout();
            this.panelCardChuaThanhToan.ResumeLayout(false);
            this.panelCardChuaThanhToan.PerformLayout();
            this.panelCardQuaHan.ResumeLayout(false);
            this.panelCardQuaHan.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        // ── Field declarations ────────────────────────────────────────────────
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panelStats;
        private System.Windows.Forms.Panel panelCardTong;
        private System.Windows.Forms.Label lblTongHoaDon;
        private System.Windows.Forms.Label lblTongHoaDonVal;
        private System.Windows.Forms.Panel panelCardDaThanhToan;
        private System.Windows.Forms.Label lblDaThanhToan;
        private System.Windows.Forms.Label lblDaThanhToanVal;
        private System.Windows.Forms.Panel panelCardChuaThanhToan;
        private System.Windows.Forms.Label lblChuaThanhToan;
        private System.Windows.Forms.Label lblChuaThanhToanVal;
        private System.Windows.Forms.Panel panelCardQuaHan;
        private System.Windows.Forms.Label lblQuaHan;
        private System.Windows.Forms.Label lblQuaHanVal;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCanHo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCuDan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThangNam;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTienDien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTienNuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhiGuiXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhiDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhiKhac;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayTao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblCanHo;
        private System.Windows.Forms.ComboBox cboCanHo;
        private System.Windows.Forms.Label lblThangNam;
        private System.Windows.Forms.DateTimePicker dtThangNam;
        private System.Windows.Forms.Label lblTienDien;
        private System.Windows.Forms.TextBox txtTienDien;
        private System.Windows.Forms.Label lblTienNuoc;
        private System.Windows.Forms.TextBox txtTienNuoc;
        private System.Windows.Forms.Label lblTienGuiXe;
        private System.Windows.Forms.TextBox txtPhiGuiXe;
        private System.Windows.Forms.Label lblTienBaoTri;
        private System.Windows.Forms.TextBox txtPhiDichVu;
        private System.Windows.Forms.Label lblTienPhiKhac;
        private System.Windows.Forms.TextBox txtTienPhiKhac;
        private System.Windows.Forms.Button btnTinhTong;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label lblNgayTao;
        private System.Windows.Forms.DateTimePicker dtNgayTao;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
    }
}