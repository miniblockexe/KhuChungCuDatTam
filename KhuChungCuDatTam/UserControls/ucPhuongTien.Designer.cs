namespace KhuChungCuDatTam.UserControls
{
    partial class ucPhuongTien
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
            this.pnlCards = new System.Windows.Forms.Panel();
            this.cardTong = new System.Windows.Forms.Panel();
            this.lblTongXeTitle = new System.Windows.Forms.Label();
            this.lblTongXe = new System.Windows.Forms.Label();
            this.cardXeMay = new System.Windows.Forms.Panel();
            this.lblXeMayTitle = new System.Windows.Forms.Label();
            this.lblXeMay = new System.Windows.Forms.Label();
            this.cardOTo = new System.Windows.Forms.Panel();
            this.lblOToTitle = new System.Windows.Forms.Label();
            this.lblOTo = new System.Windows.Forms.Label();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.dgvPhuongTien = new System.Windows.Forms.DataGridView();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.lblCuDan = new System.Windows.Forms.Label();
            this.cboCuDan = new System.Windows.Forms.ComboBox();
            this.lblBienSo = new System.Windows.Forms.Label();
            this.txtBienSo = new System.Windows.Forms.TextBox();
            this.lblLoaiXe = new System.Windows.Forms.Label();
            this.cboLoaiXe = new System.Windows.Forms.ComboBox();
            this.lblPhiGuiXe = new System.Windows.Forms.Label();
            this.txtPhiGuiXe = new System.Windows.Forms.TextBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlCards.SuspendLayout();
            this.cardTong.SuspendLayout();
            this.cardXeMay.SuspendLayout();
            this.cardOTo.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhuongTien)).BeginInit();
            this.pnlForm.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlMain.Controls.Add(this.pnlCards);
            this.pnlMain.Controls.Add(this.pnlSearch);
            this.pnlMain.Controls.Add(this.pnlContent);
            this.pnlMain.Location = new System.Drawing.Point(10, 60);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1080, 630);
            this.pnlMain.TabIndex = 1;
            // 
            // pnlCards
            // 
            this.pnlCards.BackColor = System.Drawing.Color.Transparent;
            this.pnlCards.Controls.Add(this.cardTong);
            this.pnlCards.Controls.Add(this.cardXeMay);
            this.pnlCards.Controls.Add(this.cardOTo);
            this.pnlCards.Location = new System.Drawing.Point(0, 0);
            this.pnlCards.Name = "pnlCards";
            this.pnlCards.Size = new System.Drawing.Size(1080, 100);
            this.pnlCards.TabIndex = 0;
            // 
            // cardTong
            // 
            this.cardTong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.cardTong.Controls.Add(this.lblTongXeTitle);
            this.cardTong.Controls.Add(this.lblTongXe);
            this.cardTong.Location = new System.Drawing.Point(0, 5);
            this.cardTong.Name = "cardTong";
            this.cardTong.Size = new System.Drawing.Size(230, 85);
            this.cardTong.TabIndex = 0;
            // 
            // lblTongXeTitle
            // 
            this.lblTongXeTitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblTongXeTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblTongXeTitle.Location = new System.Drawing.Point(15, 15);
            this.lblTongXeTitle.Name = "lblTongXeTitle";
            this.lblTongXeTitle.Size = new System.Drawing.Size(200, 20);
            this.lblTongXeTitle.TabIndex = 0;
            this.lblTongXeTitle.Text = "TỔNG PHƯƠNG TIỆN";
            // 
            // lblTongXe
            // 
            this.lblTongXe.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTongXe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.lblTongXe.Location = new System.Drawing.Point(15, 35);
            this.lblTongXe.Name = "lblTongXe";
            this.lblTongXe.Size = new System.Drawing.Size(200, 50);
            this.lblTongXe.TabIndex = 1;
            this.lblTongXe.Text = "0";
            // 
            // cardXeMay
            // 
            this.cardXeMay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.cardXeMay.Controls.Add(this.lblXeMayTitle);
            this.cardXeMay.Controls.Add(this.lblXeMay);
            this.cardXeMay.Location = new System.Drawing.Point(245, 5);
            this.cardXeMay.Name = "cardXeMay";
            this.cardXeMay.Size = new System.Drawing.Size(230, 85);
            this.cardXeMay.TabIndex = 1;
            // 
            // lblXeMayTitle
            // 
            this.lblXeMayTitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblXeMayTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblXeMayTitle.Location = new System.Drawing.Point(15, 15);
            this.lblXeMayTitle.Name = "lblXeMayTitle";
            this.lblXeMayTitle.Size = new System.Drawing.Size(200, 20);
            this.lblXeMayTitle.TabIndex = 0;
            this.lblXeMayTitle.Text = "XE MÁY";
            // 
            // lblXeMay
            // 
            this.lblXeMay.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblXeMay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.lblXeMay.Location = new System.Drawing.Point(15, 35);
            this.lblXeMay.Name = "lblXeMay";
            this.lblXeMay.Size = new System.Drawing.Size(200, 50);
            this.lblXeMay.TabIndex = 1;
            this.lblXeMay.Text = "0";
            // 
            // cardOTo
            // 
            this.cardOTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.cardOTo.Controls.Add(this.lblOToTitle);
            this.cardOTo.Controls.Add(this.lblOTo);
            this.cardOTo.Location = new System.Drawing.Point(490, 5);
            this.cardOTo.Name = "cardOTo";
            this.cardOTo.Size = new System.Drawing.Size(230, 85);
            this.cardOTo.TabIndex = 2;
            // 
            // lblOToTitle
            // 
            this.lblOToTitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblOToTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblOToTitle.Location = new System.Drawing.Point(15, 15);
            this.lblOToTitle.Name = "lblOToTitle";
            this.lblOToTitle.Size = new System.Drawing.Size(200, 20);
            this.lblOToTitle.TabIndex = 0;
            this.lblOToTitle.Text = "Ô TÔ";
            // 
            // lblOTo
            // 
            this.lblOTo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblOTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.lblOTo.Location = new System.Drawing.Point(15, 35);
            this.lblOTo.Name = "lblOTo";
            this.lblOTo.Size = new System.Drawing.Size(200, 50);
            this.lblOTo.TabIndex = 1;
            this.lblOTo.Text = "0";
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.Transparent;
            this.pnlSearch.Controls.Add(this.lblSearch);
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Location = new System.Drawing.Point(0, 110);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(1080, 45);
            this.pnlSearch.TabIndex = 1;
            // 
            // lblSearch
            // 
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblSearch.Location = new System.Drawing.Point(0, 8);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(30, 28);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "🔍";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.Location = new System.Drawing.Point(35, 8);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(400, 30);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.Transparent;
            this.pnlContent.Controls.Add(this.dgvPhuongTien);
            this.pnlContent.Controls.Add(this.pnlForm);
            this.pnlContent.Location = new System.Drawing.Point(0, 165);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1080, 460);
            this.pnlContent.TabIndex = 2;
            // 
            // dgvPhuongTien
            // 
            this.dgvPhuongTien.AllowUserToAddRows = false;
            this.dgvPhuongTien.AllowUserToDeleteRows = false;
            this.dgvPhuongTien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhuongTien.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.dgvPhuongTien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPhuongTien.ColumnHeadersHeight = 29;
            this.dgvPhuongTien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.dgvPhuongTien.Location = new System.Drawing.Point(0, 0);
            this.dgvPhuongTien.MultiSelect = false;
            this.dgvPhuongTien.Name = "dgvPhuongTien";
            this.dgvPhuongTien.ReadOnly = true;
            this.dgvPhuongTien.RowHeadersVisible = false;
            this.dgvPhuongTien.RowHeadersWidth = 51;
            this.dgvPhuongTien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhuongTien.Size = new System.Drawing.Size(710, 460);
            this.dgvPhuongTien.TabIndex = 0;
            this.dgvPhuongTien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhuongTien_CellClick);
            // 
            // pnlForm
            // 
            this.pnlForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.pnlForm.Controls.Add(this.lblFormTitle);
            this.pnlForm.Controls.Add(this.lblCuDan);
            this.pnlForm.Controls.Add(this.cboCuDan);
            this.pnlForm.Controls.Add(this.lblBienSo);
            this.pnlForm.Controls.Add(this.txtBienSo);
            this.pnlForm.Controls.Add(this.lblLoaiXe);
            this.pnlForm.Controls.Add(this.cboLoaiXe);
            this.pnlForm.Controls.Add(this.lblPhiGuiXe);
            this.pnlForm.Controls.Add(this.txtPhiGuiXe);
            this.pnlForm.Controls.Add(this.lblTrangThai);
            this.pnlForm.Controls.Add(this.cboTrangThai);
            this.pnlForm.Controls.Add(this.pnlButtons);
            this.pnlForm.Location = new System.Drawing.Point(720, 0);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(360, 460);
            this.pnlForm.TabIndex = 1;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.lblFormTitle.Location = new System.Drawing.Point(15, 15);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(330, 25);
            this.lblFormTitle.TabIndex = 0;
            this.lblFormTitle.Text = "THÔNG TIN PHƯƠNG TIỆN";
            // 
            // lblCuDan
            // 
            this.lblCuDan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCuDan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblCuDan.Location = new System.Drawing.Point(15, 55);
            this.lblCuDan.Name = "lblCuDan";
            this.lblCuDan.Size = new System.Drawing.Size(330, 20);
            this.lblCuDan.TabIndex = 1;
            this.lblCuDan.Text = "Cư Dân *";
            // 
            // cboCuDan
            // 
            this.cboCuDan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.cboCuDan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCuDan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCuDan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboCuDan.ForeColor = System.Drawing.Color.White;
            this.cboCuDan.Location = new System.Drawing.Point(15, 78);
            this.cboCuDan.Name = "cboCuDan";
            this.cboCuDan.Size = new System.Drawing.Size(330, 28);
            this.cboCuDan.TabIndex = 2;
            // 
            // lblBienSo
            // 
            this.lblBienSo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBienSo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblBienSo.Location = new System.Drawing.Point(15, 118);
            this.lblBienSo.Name = "lblBienSo";
            this.lblBienSo.Size = new System.Drawing.Size(330, 20);
            this.lblBienSo.TabIndex = 3;
            this.lblBienSo.Text = "Biển Số *";
            // 
            // txtBienSo
            // 
            this.txtBienSo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtBienSo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBienSo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBienSo.ForeColor = System.Drawing.Color.White;
            this.txtBienSo.Location = new System.Drawing.Point(15, 141);
            this.txtBienSo.Name = "txtBienSo";
            this.txtBienSo.Size = new System.Drawing.Size(330, 27);
            this.txtBienSo.TabIndex = 4;
            // 
            // lblLoaiXe
            // 
            this.lblLoaiXe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLoaiXe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblLoaiXe.Location = new System.Drawing.Point(15, 181);
            this.lblLoaiXe.Name = "lblLoaiXe";
            this.lblLoaiXe.Size = new System.Drawing.Size(330, 20);
            this.lblLoaiXe.TabIndex = 5;
            this.lblLoaiXe.Text = "Loại Xe *";
            // 
            // cboLoaiXe
            // 
            this.cboLoaiXe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.cboLoaiXe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiXe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboLoaiXe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboLoaiXe.ForeColor = System.Drawing.Color.White;
       
            this.cboLoaiXe.Location = new System.Drawing.Point(15, 204);
            this.cboLoaiXe.Name = "cboLoaiXe";
            this.cboLoaiXe.Size = new System.Drawing.Size(330, 28);
            this.cboLoaiXe.TabIndex = 6;
            // 
            // lblPhiGuiXe
            // 
            this.lblPhiGuiXe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPhiGuiXe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblPhiGuiXe.Location = new System.Drawing.Point(15, 244);
            this.lblPhiGuiXe.Name = "lblPhiGuiXe";
            this.lblPhiGuiXe.Size = new System.Drawing.Size(330, 20);
            this.lblPhiGuiXe.TabIndex = 7;
            this.lblPhiGuiXe.Text = "Phí Gửi/Tháng (VNĐ) *";
            // 
            // txtPhiGuiXe
            // 
            this.txtPhiGuiXe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtPhiGuiXe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhiGuiXe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPhiGuiXe.ForeColor = System.Drawing.Color.White;
            this.txtPhiGuiXe.Location = new System.Drawing.Point(15, 267);
            this.txtPhiGuiXe.Name = "txtPhiGuiXe";
            this.txtPhiGuiXe.Size = new System.Drawing.Size(330, 27);
            this.txtPhiGuiXe.TabIndex = 8;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTrangThai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblTrangThai.Location = new System.Drawing.Point(15, 307);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(330, 20);
            this.lblTrangThai.TabIndex = 9;
            this.lblTrangThai.Text = "Trạng Thái *";
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTrangThai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboTrangThai.ForeColor = System.Drawing.Color.White;
          
            this.cboTrangThai.Location = new System.Drawing.Point(15, 330);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(330, 28);
            this.cboTrangThai.TabIndex = 10;
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.Transparent;
            this.pnlButtons.Controls.Add(this.btnThem);
            this.pnlButtons.Controls.Add(this.btnSua);
            this.pnlButtons.Controls.Add(this.btnXoa);
            this.pnlButtons.Controls.Add(this.btnLamMoi);
            this.pnlButtons.Location = new System.Drawing.Point(15, 375);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(330, 70);
            this.pnlButtons.TabIndex = 11;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(0, 0);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 32);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "＋ Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(83, 0);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 32);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "✎ Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(166, 0);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 32);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "✕ Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(0, 38);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 32);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "↺ Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(500, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Quản Lý Phương Tiện";
            // 
            // ucPhuongTien
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlMain);
            this.Name = "ucPhuongTien";
            this.Size = new System.Drawing.Size(1100, 700);
            this.Load += new System.EventHandler(this.ucPhuongTien_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlCards.ResumeLayout(false);
            this.cardTong.ResumeLayout(false);
            this.cardXeMay.ResumeLayout(false);
            this.cardOTo.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhuongTien)).EndInit();
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        // ===== Control declarations =====
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlCards;
        private System.Windows.Forms.Panel cardTong;
        private System.Windows.Forms.Label lblTongXeTitle;
        private System.Windows.Forms.Label lblTongXe;
        private System.Windows.Forms.Panel cardXeMay;
        private System.Windows.Forms.Label lblXeMayTitle;
        private System.Windows.Forms.Label lblXeMay;
        private System.Windows.Forms.Panel cardOTo;
        private System.Windows.Forms.Label lblOToTitle;
        private System.Windows.Forms.Label lblOTo;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.DataGridView dgvPhuongTien;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblCuDan;
        private System.Windows.Forms.ComboBox cboCuDan;
        private System.Windows.Forms.Label lblBienSo;
        private System.Windows.Forms.TextBox txtBienSo;
        private System.Windows.Forms.Label lblLoaiXe;
        private System.Windows.Forms.ComboBox cboLoaiXe;
        private System.Windows.Forms.Label lblPhiGuiXe;
        private System.Windows.Forms.TextBox txtPhiGuiXe;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Label lblTitle;
    }
}