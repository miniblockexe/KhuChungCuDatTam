namespace KhuChungCuDatTam
{
    partial class frmMain
    {
        private System.ComponentModel.IContainer components = null;

        // ── Sidebar ───────────────────────────────────────────
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlSidebarHeader;
        private System.Windows.Forms.Panel pnlLogoBox;
        private System.Windows.Forms.Label lblLogoChar;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Label lblAppTagline;
        private System.Windows.Forms.Panel pnlNavArea;
        private System.Windows.Forms.Label lblNavSection;

        // Nav rows: wrapper / accent strip / button
        private System.Windows.Forms.Panel pnlNavTQ; private System.Windows.Forms.Panel pnlAccTQ; private System.Windows.Forms.Button btnTQ;
        private System.Windows.Forms.Panel pnlNavCD; private System.Windows.Forms.Panel pnlAccCD; private System.Windows.Forms.Button btnCD;
        private System.Windows.Forms.Panel pnlNavCH; private System.Windows.Forms.Panel pnlAccCH; private System.Windows.Forms.Button btnCH;
        private System.Windows.Forms.Panel pnlNavHD; private System.Windows.Forms.Panel pnlAccHD; private System.Windows.Forms.Button btnHD;
        private System.Windows.Forms.Panel pnlNavHC; private System.Windows.Forms.Panel pnlAccHC; private System.Windows.Forms.Button btnHC;
        private System.Windows.Forms.Panel pnlNavTT; private System.Windows.Forms.Panel pnlAccTT; private System.Windows.Forms.Button btnTT;
        private System.Windows.Forms.Panel pnlNavCN; private System.Windows.Forms.Panel pnlAccCN; private System.Windows.Forms.Button btnCN;
        private System.Windows.Forms.Panel pnlNavDV; private System.Windows.Forms.Panel pnlAccDV; private System.Windows.Forms.Button btnDV;
        private System.Windows.Forms.Panel pnlNavBT; private System.Windows.Forms.Panel pnlAccBT; private System.Windows.Forms.Button btnBT;
        private System.Windows.Forms.Panel pnlNavCC; private System.Windows.Forms.Panel pnlAccCC; private System.Windows.Forms.Button btnCC;
        private System.Windows.Forms.Panel pnlNavBL; private System.Windows.Forms.Panel pnlAccBL; private System.Windows.Forms.Button btnBL;
        private System.Windows.Forms.Panel pnlNavKN; private System.Windows.Forms.Panel pnlAccKN; private System.Windows.Forms.Button btnKN;
        private System.Windows.Forms.Panel pnlNavTB; private System.Windows.Forms.Panel pnlAccTB; private System.Windows.Forms.Button btnTB;
        private System.Windows.Forms.Panel pnlNavPQ; private System.Windows.Forms.Panel pnlAccPQ; private System.Windows.Forms.Button btnPQ;
        private System.Windows.Forms.Panel pnlNavBC; private System.Windows.Forms.Panel pnlAccBC; private System.Windows.Forms.Button btnBC;
        private System.Windows.Forms.Panel pnlNavPT;
        private System.Windows.Forms.Panel pnlAccPT;
        private System.Windows.Forms.Button btnPT;

        private System.Windows.Forms.Panel pnlNavDKDV;
        private System.Windows.Forms.Panel pnlAccDKDV;
        private System.Windows.Forms.Button btnDKDV;

        private System.Windows.Forms.Panel pnlNavND;
        private System.Windows.Forms.Panel pnlAccND;
        private System.Windows.Forms.Button btnND;

        private System.Windows.Forms.Panel pnlNavAL;
        private System.Windows.Forms.Panel pnlAccAL;
        private System.Windows.Forms.Button btnAL;

        private System.Windows.Forms.Panel pnlSidebarFooter;
        private System.Windows.Forms.Panel pnlNavDX; private System.Windows.Forms.Panel pnlAccDX; private System.Windows.Forms.Button btnDX;
        private System.Windows.Forms.Label lblVersion;

        // ── Workspace ─────────────────────────────────────────
        private System.Windows.Forms.Panel pnlWorkspace;

        // Header
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Label lblBreadcrumb;
        private System.Windows.Forms.Panel pnlHeaderRight;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Panel pnlHDivider;
        private System.Windows.Forms.Panel pnlWinCtrl;
        private System.Windows.Forms.Button btnWinMin;
        private System.Windows.Forms.Button btnWinMax;
        private System.Windows.Forms.Button btnWinClose;

        // Content
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Timer timerClock;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.pnlNavArea = new System.Windows.Forms.Panel();
            this.pnlNavBC = new System.Windows.Forms.Panel();
            this.btnBC = new System.Windows.Forms.Button();
            this.pnlAccBC = new System.Windows.Forms.Panel();
            this.pnlNavPQ = new System.Windows.Forms.Panel();
            this.btnPQ = new System.Windows.Forms.Button();
            this.pnlAccPQ = new System.Windows.Forms.Panel();
            this.pnlNavTB = new System.Windows.Forms.Panel();
            this.btnTB = new System.Windows.Forms.Button();
            this.pnlAccTB = new System.Windows.Forms.Panel();
            this.pnlNavKN = new System.Windows.Forms.Panel();
            this.btnKN = new System.Windows.Forms.Button();
            this.pnlAccKN = new System.Windows.Forms.Panel();
            this.pnlNavBT = new System.Windows.Forms.Panel();
            this.pnlNavCC = new System.Windows.Forms.Panel();
            this.pnlAccCC = new System.Windows.Forms.Panel();
            this.btnCC = new System.Windows.Forms.Button();
            this.pnlNavBL = new System.Windows.Forms.Panel();
            this.pnlAccBL = new System.Windows.Forms.Panel();
            this.btnBL = new System.Windows.Forms.Button();
            this.btnBT = new System.Windows.Forms.Button();
            this.pnlAccBT = new System.Windows.Forms.Panel();
            this.pnlNavDV = new System.Windows.Forms.Panel();
            this.btnDV = new System.Windows.Forms.Button();
            this.pnlAccDV = new System.Windows.Forms.Panel();
            this.pnlNavCN = new System.Windows.Forms.Panel();
            this.btnCN = new System.Windows.Forms.Button();
            this.pnlAccCN = new System.Windows.Forms.Panel();
            this.pnlNavTT = new System.Windows.Forms.Panel();
            this.btnTT = new System.Windows.Forms.Button();
            this.pnlAccTT = new System.Windows.Forms.Panel();
            this.pnlNavHC = new System.Windows.Forms.Panel();
            this.btnHC = new System.Windows.Forms.Button();
            this.pnlAccHC = new System.Windows.Forms.Panel();
            this.pnlNavHD = new System.Windows.Forms.Panel();
            this.btnHD = new System.Windows.Forms.Button();
            this.pnlAccHD = new System.Windows.Forms.Panel();
            this.pnlNavCH = new System.Windows.Forms.Panel();
            this.btnCH = new System.Windows.Forms.Button();
            this.pnlAccCH = new System.Windows.Forms.Panel();
            this.pnlNavCD = new System.Windows.Forms.Panel();
            this.btnCD = new System.Windows.Forms.Button();
            this.pnlAccCD = new System.Windows.Forms.Panel();
            this.pnlNavTQ = new System.Windows.Forms.Panel();
            this.btnTQ = new System.Windows.Forms.Button();
            this.pnlAccTQ = new System.Windows.Forms.Panel();
            this.pnlNavPT = new System.Windows.Forms.Panel();
            this.pnlAccPT = new System.Windows.Forms.Panel();
            this.btnPT = new System.Windows.Forms.Button();

            this.pnlNavDKDV = new System.Windows.Forms.Panel();
            this.pnlAccDKDV = new System.Windows.Forms.Panel();
            this.btnDKDV = new System.Windows.Forms.Button();

            this.pnlNavND = new System.Windows.Forms.Panel();
            this.pnlAccND = new System.Windows.Forms.Panel();
            this.btnND = new System.Windows.Forms.Button();

            this.pnlNavAL = new System.Windows.Forms.Panel();
            this.pnlAccAL = new System.Windows.Forms.Panel();
            this.btnAL = new System.Windows.Forms.Button();


            this.lblNavSection = new System.Windows.Forms.Label();
            this.pnlSidebarHeader = new System.Windows.Forms.Panel();
            this.pnlLogoBox = new System.Windows.Forms.Panel();
            this.lblLogoChar = new System.Windows.Forms.Label();
            this.lblAppName = new System.Windows.Forms.Label();
            this.lblAppTagline = new System.Windows.Forms.Label();
            this.pnlSidebarFooter = new System.Windows.Forms.Panel();
            this.pnlNavDX = new System.Windows.Forms.Panel();
            this.btnDX = new System.Windows.Forms.Button();
            this.pnlAccDX = new System.Windows.Forms.Panel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.pnlWorkspace = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.lblBreadcrumb = new System.Windows.Forms.Label();
            this.pnlHeaderRight = new System.Windows.Forms.Panel();
            this.pnlWinCtrl = new System.Windows.Forms.Panel();
            this.btnWinClose = new System.Windows.Forms.Button();
            this.btnWinMax = new System.Windows.Forms.Button();
            this.btnWinMin = new System.Windows.Forms.Button();
            this.pnlHDivider = new System.Windows.Forms.Panel();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.lblAvatarRole = new System.Windows.Forms.Label();
            this.lblAvatarName = new System.Windows.Forms.Label();
            this.pnlAvatarCircle = new System.Windows.Forms.Panel();
            this.pnlAvatarWrap = new System.Windows.Forms.Panel();
            this.pnlSidebar.SuspendLayout();
            this.pnlNavArea.SuspendLayout();
            this.pnlNavBC.SuspendLayout();
            this.pnlNavPQ.SuspendLayout();
            this.pnlNavTB.SuspendLayout();
            this.pnlNavKN.SuspendLayout();
            this.pnlNavBT.SuspendLayout();
            this.pnlNavCC.SuspendLayout();
            this.pnlNavDV.SuspendLayout();
            this.pnlNavCN.SuspendLayout();
            this.pnlNavTT.SuspendLayout();
            this.pnlNavHC.SuspendLayout();
            this.pnlNavHD.SuspendLayout();
            this.pnlNavCH.SuspendLayout();
            this.pnlNavCD.SuspendLayout();
            this.pnlNavTQ.SuspendLayout();
            this.pnlSidebarHeader.SuspendLayout();
            this.pnlLogoBox.SuspendLayout();
            this.pnlSidebarFooter.SuspendLayout();
            this.pnlNavDX.SuspendLayout();
            this.pnlWorkspace.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlHeaderRight.SuspendLayout();
            this.pnlWinCtrl.SuspendLayout();
            this.pnlAvatarWrap.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.pnlSidebar.Controls.Add(this.pnlNavArea);
            this.pnlSidebar.Controls.Add(this.pnlSidebarHeader);
            this.pnlSidebar.Controls.Add(this.pnlSidebarFooter);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(240, 820);
            this.pnlSidebar.TabIndex = 1;
            // 
            // pnlNavArea
            // 
            this.pnlNavArea.AutoScroll = true;
            this.pnlNavArea.BackColor = System.Drawing.Color.Transparent;
            this.pnlNavArea.Controls.Add(this.pnlNavAL);   
            this.pnlNavArea.Controls.Add(this.pnlNavPQ);
            this.pnlNavArea.Controls.Add(this.pnlNavND);
            this.pnlNavArea.Controls.Add(this.pnlNavBC);
            this.pnlNavArea.Controls.Add(this.pnlNavTB);
            this.pnlNavArea.Controls.Add(this.pnlNavKN);
            this.pnlNavArea.Controls.Add(this.pnlNavCC);
            this.pnlNavArea.Controls.Add(this.pnlNavBL);
            this.pnlNavArea.Controls.Add(this.pnlNavBT);
            this.pnlNavArea.Controls.Add(this.pnlNavDKDV);
            this.pnlNavArea.Controls.Add(this.pnlNavDV);
            this.pnlNavArea.Controls.Add(this.pnlNavCN);
            this.pnlNavArea.Controls.Add(this.pnlNavTT);
            this.pnlNavArea.Controls.Add(this.pnlNavHC);
            this.pnlNavArea.Controls.Add(this.pnlNavHD);
            this.pnlNavArea.Controls.Add(this.pnlNavPT);
            this.pnlNavArea.Controls.Add(this.pnlNavCH);
            this.pnlNavArea.Controls.Add(this.pnlNavCD);
            this.pnlNavArea.Controls.Add(this.pnlNavTQ);
            this.pnlNavArea.Controls.Add(this.lblNavSection);
            this.pnlNavArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNavArea.Location = new System.Drawing.Point(0, 72);
            this.pnlNavArea.Name = "pnlNavArea";
            this.pnlNavArea.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.pnlNavArea.Size = new System.Drawing.Size(240, 652);
            this.pnlNavArea.TabIndex = 0;
            // 
            // pnlNavBC
            // 
            this.pnlNavBC.BackColor = System.Drawing.Color.Transparent;
            this.pnlNavBC.Controls.Add(this.btnBC);
            this.pnlNavBC.Controls.Add(this.pnlAccBC);
            this.pnlNavBC.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNavBC.Location = new System.Drawing.Point(0, 588);
            this.pnlNavBC.Name = "pnlNavBC";
            this.pnlNavBC.Size = new System.Drawing.Size(240, 46);
            this.pnlNavBC.TabIndex = 0;
            // 
            // btnBC
            // 
            this.btnBC.BackColor = System.Drawing.Color.Transparent;
            this.btnBC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBC.FlatAppearance.BorderSize = 0;
            this.btnBC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnBC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBC.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnBC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.btnBC.Location = new System.Drawing.Point(4, 0);
            this.btnBC.Name = "btnBC";
            this.btnBC.Size = new System.Drawing.Size(236, 46);
            this.btnBC.TabIndex = 0;
            this.btnBC.TabStop = false;
            this.btnBC.Text = "    📈   Báo Cáo";
            this.btnBC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBC.UseVisualStyleBackColor = false;
            this.btnBC.Click += new System.EventHandler(this.btnBC_Click);
            // 
            // pnlAccBC
            // 
            this.pnlAccBC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.pnlAccBC.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAccBC.Location = new System.Drawing.Point(0, 0);
            this.pnlAccBC.Name = "pnlAccBC";
            this.pnlAccBC.Size = new System.Drawing.Size(4, 46);
            this.pnlAccBC.TabIndex = 1;
            // 
            // pnlNavPQ
            // 
            this.pnlNavPQ.BackColor = System.Drawing.Color.Transparent;
            this.pnlNavPQ.Controls.Add(this.btnPQ);
            this.pnlNavPQ.Controls.Add(this.pnlAccPQ);
            this.pnlNavPQ.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNavPQ.Location = new System.Drawing.Point(0, 542);
            this.pnlNavPQ.Name = "pnlNavPQ";
            this.pnlNavPQ.Size = new System.Drawing.Size(240, 46);
            this.pnlNavPQ.TabIndex = 1;
            // 
            // btnPQ
            // 
            this.btnPQ.BackColor = System.Drawing.Color.Transparent;
            this.btnPQ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPQ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPQ.FlatAppearance.BorderSize = 0;
            this.btnPQ.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnPQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPQ.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnPQ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.btnPQ.Location = new System.Drawing.Point(4, 0);
            this.btnPQ.Name = "btnPQ";
            this.btnPQ.Size = new System.Drawing.Size(236, 46);
            this.btnPQ.TabIndex = 0;
            this.btnPQ.TabStop = false;
            this.btnPQ.Text = "    🔑   Phân Quyền";
            this.btnPQ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPQ.UseVisualStyleBackColor = false;
            this.btnPQ.Click += new System.EventHandler(this.btnPQ_Click);
            // 
            // pnlAccPQ
            // 
            this.pnlAccPQ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.pnlAccPQ.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAccPQ.Location = new System.Drawing.Point(0, 0);
            this.pnlAccPQ.Name = "pnlAccPQ";
            this.pnlAccPQ.Size = new System.Drawing.Size(4, 46);
            this.pnlAccPQ.TabIndex = 1;
            // 
            // pnlNavTB
            // 
            this.pnlNavTB.BackColor = System.Drawing.Color.Transparent;
            this.pnlNavTB.Controls.Add(this.btnTB);
            this.pnlNavTB.Controls.Add(this.pnlAccTB);
            this.pnlNavTB.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNavTB.Location = new System.Drawing.Point(0, 496);
            this.pnlNavTB.Name = "pnlNavTB";
            this.pnlNavTB.Size = new System.Drawing.Size(240, 46);
            this.pnlNavTB.TabIndex = 2;
            // 
            // btnTB
            // 
            this.btnTB.BackColor = System.Drawing.Color.Transparent;
            this.btnTB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTB.FlatAppearance.BorderSize = 0;
            this.btnTB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnTB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTB.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.btnTB.Location = new System.Drawing.Point(4, 0);
            this.btnTB.Name = "btnTB";
            this.btnTB.Size = new System.Drawing.Size(236, 46);
            this.btnTB.TabIndex = 0;
            this.btnTB.TabStop = false;
            this.btnTB.Text = "    🔔   Thông Báo";
            this.btnTB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTB.UseVisualStyleBackColor = false;
            this.btnTB.Click += new System.EventHandler(this.btnTB_Click);
            // 
            // pnlAccTB
            // 
            this.pnlAccTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.pnlAccTB.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAccTB.Location = new System.Drawing.Point(0, 0);
            this.pnlAccTB.Name = "pnlAccTB";
            this.pnlAccTB.Size = new System.Drawing.Size(4, 46);
            this.pnlAccTB.TabIndex = 1;
            // 
            // pnlNavKN
            // 
            this.pnlNavKN.BackColor = System.Drawing.Color.Transparent;
            this.pnlNavKN.Controls.Add(this.btnKN);
            this.pnlNavKN.Controls.Add(this.pnlAccKN);
            this.pnlNavKN.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNavKN.Location = new System.Drawing.Point(0, 450);
            this.pnlNavKN.Name = "pnlNavKN";
            this.pnlNavKN.Size = new System.Drawing.Size(240, 46);
            this.pnlNavKN.TabIndex = 3;
            // 
            // btnKN
            // 
            this.btnKN.BackColor = System.Drawing.Color.Transparent;
            this.btnKN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnKN.FlatAppearance.BorderSize = 0;
            this.btnKN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnKN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKN.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnKN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.btnKN.Location = new System.Drawing.Point(4, 0);
            this.btnKN.Name = "btnKN";
            this.btnKN.Size = new System.Drawing.Size(236, 46);
            this.btnKN.TabIndex = 0;
            this.btnKN.TabStop = false;
            this.btnKN.Text = "    💬   Khiếu Nại";
            this.btnKN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKN.UseVisualStyleBackColor = false;
            this.btnKN.Click += new System.EventHandler(this.btnKN_Click);
            // 
            // pnlAccKN
            // 
            this.pnlAccKN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.pnlAccKN.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAccKN.Location = new System.Drawing.Point(0, 0);
            this.pnlAccKN.Name = "pnlAccKN";
            this.pnlAccKN.Size = new System.Drawing.Size(4, 46);
            this.pnlAccKN.TabIndex = 1;
            // 
            // pnlNavBT
            // 
            this.pnlNavBT.BackColor = System.Drawing.Color.Transparent;
            this.pnlNavBT.Controls.Add(this.btnBT);
            this.pnlNavBT.Controls.Add(this.pnlAccBT);
            this.pnlNavBT.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNavBT.Location = new System.Drawing.Point(0, 404);
            this.pnlNavBT.Name = "pnlNavBT";
            this.pnlNavBT.Size = new System.Drawing.Size(240, 46);
            this.pnlNavBT.TabIndex = 4;
            // 
            // btnBT
            // 
            this.btnBT.BackColor = System.Drawing.Color.Transparent;
            this.btnBT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBT.FlatAppearance.BorderSize = 0;
            this.btnBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBT.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnBT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.btnBT.Location = new System.Drawing.Point(4, 0);
            this.btnBT.Name = "btnBT";
            this.btnBT.Size = new System.Drawing.Size(236, 46);
            this.btnBT.TabIndex = 0;
            this.btnBT.TabStop = false;
            this.btnBT.Text = "    🔧   Bảo Trì";
            this.btnBT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBT.UseVisualStyleBackColor = false;
            this.btnBT.Click += new System.EventHandler(this.btnBT_Click);
            // 
            // pnlAccBT
            // 
            this.pnlAccBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.pnlAccBT.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAccBT.Location = new System.Drawing.Point(0, 0);
            this.pnlAccBT.Name = "pnlAccBT";
            this.pnlAccBT.Size = new System.Drawing.Size(4, 46);
            this.pnlAccBT.TabIndex = 1;
            // ── pnlNavCC ─────────────────────────────────────────────
            this.pnlNavCC.BackColor = System.Drawing.Color.Transparent;
            this.pnlNavCC.Controls.Add(this.btnCC);
            this.pnlNavCC.Controls.Add(this.pnlAccCC);
            this.pnlNavCC.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNavCC.Name = "pnlNavCC";
            this.pnlNavCC.Size = new System.Drawing.Size(240, 46);

            this.btnCC.BackColor = System.Drawing.Color.Transparent;
            this.btnCC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCC.FlatAppearance.BorderSize = 0;
            this.btnCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCC.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnCC.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.btnCC.Name = "btnCC";
            this.btnCC.TabStop = false;
            this.btnCC.Text = "    🕐   Chấm Công";
            this.btnCC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCC.UseVisualStyleBackColor = false;
            this.btnCC.Click += new System.EventHandler(this.btnCC_Click);

            this.pnlAccCC.BackColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.pnlAccCC.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAccCC.Name = "pnlAccCC";
            this.pnlAccCC.Size = new System.Drawing.Size(4, 46);
            // ── pnlNavBL ─────────────────────────────────────────────
            this.pnlNavBL.BackColor = System.Drawing.Color.Transparent;
            this.pnlNavBL.Controls.Add(this.btnBL);
            this.pnlNavBL.Controls.Add(this.pnlAccBL);
            this.pnlNavBL.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNavBL.Name = "pnlNavBL";
            this.pnlNavBL.Size = new System.Drawing.Size(240, 46);

            this.btnBL.BackColor = System.Drawing.Color.Transparent;
            this.btnBL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBL.FlatAppearance.BorderSize = 0;
            this.btnBL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBL.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnBL.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.btnBL.Name = "btnBL";
            this.btnBL.TabStop = false;
            this.btnBL.Text = "    💵   Bảng Lương";
            this.btnBL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBL.UseVisualStyleBackColor = false;
            this.btnBL.Click += new System.EventHandler(this.btnBL_Click);

            this.pnlAccBL.BackColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.pnlAccBL.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAccBL.Name = "pnlAccBL";
            this.pnlAccBL.Size = new System.Drawing.Size(4, 46);
            // 
            // pnlNavDV
            // 
            this.pnlNavDV.BackColor = System.Drawing.Color.Transparent;
            this.pnlNavDV.Controls.Add(this.btnDV);
            this.pnlNavDV.Controls.Add(this.pnlAccDV);
            this.pnlNavDV.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNavDV.Location = new System.Drawing.Point(0, 358);
            this.pnlNavDV.Name = "pnlNavDV";
            this.pnlNavDV.Size = new System.Drawing.Size(240, 46);
            this.pnlNavDV.TabIndex = 5;
            // 
            // btnDV
            // 
            this.btnDV.BackColor = System.Drawing.Color.Transparent;
            this.btnDV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDV.FlatAppearance.BorderSize = 0;
            this.btnDV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDV.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnDV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.btnDV.Location = new System.Drawing.Point(4, 0);
            this.btnDV.Name = "btnDV";
            this.btnDV.Size = new System.Drawing.Size(236, 46);
            this.btnDV.TabIndex = 0;
            this.btnDV.TabStop = false;
            this.btnDV.Text = "    ⚙   Dịch Vụ";
            this.btnDV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDV.UseVisualStyleBackColor = false;
            this.btnDV.Click += new System.EventHandler(this.btnDV_Click);
            // 
            // pnlAccDV
            // 
            this.pnlAccDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.pnlAccDV.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAccDV.Location = new System.Drawing.Point(0, 0);
            this.pnlAccDV.Name = "pnlAccDV";
            this.pnlAccDV.Size = new System.Drawing.Size(4, 46);
            this.pnlAccDV.TabIndex = 1;
            // 
            // pnlNavCN
            // 
            this.pnlNavCN.BackColor = System.Drawing.Color.Transparent;
            this.pnlNavCN.Controls.Add(this.btnCN);
            this.pnlNavCN.Controls.Add(this.pnlAccCN);
            this.pnlNavCN.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNavCN.Location = new System.Drawing.Point(0, 312);
            this.pnlNavCN.Name = "pnlNavCN";
            this.pnlNavCN.Size = new System.Drawing.Size(240, 46);
            this.pnlNavCN.TabIndex = 6;
            // 
            // btnCN
            // 
            this.btnCN.BackColor = System.Drawing.Color.Transparent;
            this.btnCN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCN.FlatAppearance.BorderSize = 0;
            this.btnCN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnCN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCN.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnCN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.btnCN.Location = new System.Drawing.Point(4, 0);
            this.btnCN.Name = "btnCN";
            this.btnCN.Size = new System.Drawing.Size(236, 46);
            this.btnCN.TabIndex = 0;
            this.btnCN.TabStop = false;
            this.btnCN.Text = "    📊   Công Nợ";
            this.btnCN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCN.UseVisualStyleBackColor = false;
            this.btnCN.Click += new System.EventHandler(this.btnCN_Click);
            // 
            // pnlAccCN
            // 
            this.pnlAccCN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.pnlAccCN.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAccCN.Location = new System.Drawing.Point(0, 0);
            this.pnlAccCN.Name = "pnlAccCN";
            this.pnlAccCN.Size = new System.Drawing.Size(4, 46);
            this.pnlAccCN.TabIndex = 1;
            // 
            // pnlNavTT
            // 
            this.pnlNavTT.BackColor = System.Drawing.Color.Transparent;
            this.pnlNavTT.Controls.Add(this.btnTT);
            this.pnlNavTT.Controls.Add(this.pnlAccTT);
            this.pnlNavTT.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNavTT.Location = new System.Drawing.Point(0, 266);
            this.pnlNavTT.Name = "pnlNavTT";
            this.pnlNavTT.Size = new System.Drawing.Size(240, 46);
            this.pnlNavTT.TabIndex = 7;
            // 
            // btnTT
            // 
            this.btnTT.BackColor = System.Drawing.Color.Transparent;
            this.btnTT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTT.FlatAppearance.BorderSize = 0;
            this.btnTT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnTT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTT.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnTT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.btnTT.Location = new System.Drawing.Point(4, 0);
            this.btnTT.Name = "btnTT";
            this.btnTT.Size = new System.Drawing.Size(236, 46);
            this.btnTT.TabIndex = 0;
            this.btnTT.TabStop = false;
            this.btnTT.Text = "    💰   Thanh Toán";
            this.btnTT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTT.UseVisualStyleBackColor = false;
            this.btnTT.Click += new System.EventHandler(this.btnTT_Click);
            // 
            // pnlAccTT
            // 
            this.pnlAccTT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.pnlAccTT.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAccTT.Location = new System.Drawing.Point(0, 0);
            this.pnlAccTT.Name = "pnlAccTT";
            this.pnlAccTT.Size = new System.Drawing.Size(4, 46);
            this.pnlAccTT.TabIndex = 1;

            // 
            // pnlNavHC
            // 
            this.pnlNavHC.BackColor = System.Drawing.Color.Transparent;
            this.pnlNavHC.Controls.Add(this.btnHC);
            this.pnlNavHC.Controls.Add(this.pnlAccHC);
            this.pnlNavHC.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNavHC.Location = new System.Drawing.Point(0, 220);
            this.pnlNavHC.Name = "pnlNavHC";
            this.pnlNavHC.Size = new System.Drawing.Size(240, 46);
            this.pnlNavHC.TabIndex = 8;
            // 
            // btnHC
            // 
            this.btnHC.BackColor = System.Drawing.Color.Transparent;
            this.btnHC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHC.FlatAppearance.BorderSize = 0;
            this.btnHC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnHC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHC.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnHC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.btnHC.Location = new System.Drawing.Point(4, 0);
            this.btnHC.Name = "btnHC";
            this.btnHC.Size = new System.Drawing.Size(236, 46);
            this.btnHC.TabIndex = 0;
            this.btnHC.TabStop = false;
            this.btnHC.Text = "    💳   Hóa Đơn";
            this.btnHC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHC.UseVisualStyleBackColor = false;
            this.btnHC.Click += new System.EventHandler(this.btnHC_Click);

            // ── pnlNavPT ─────────────────────────────────────────────
            this.pnlNavPT.BackColor = System.Drawing.Color.Transparent;
            this.pnlNavPT.Controls.Add(this.btnPT);
            this.pnlNavPT.Controls.Add(this.pnlAccPT);
            this.pnlNavPT.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNavPT.Name = "pnlNavPT";
            this.pnlNavPT.Size = new System.Drawing.Size(240, 46);

            this.btnPT.BackColor = System.Drawing.Color.Transparent;
            this.btnPT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPT.FlatAppearance.BorderSize = 0;
            this.btnPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPT.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnPT.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.btnPT.Name = "btnPT";
            this.btnPT.TabStop = false;
            this.btnPT.Text = "    🚗   Phương Tiện";
            this.btnPT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPT.UseVisualStyleBackColor = false;
            this.btnPT.Click += new System.EventHandler(this.btnPT_Click);

            this.pnlAccPT.BackColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.pnlAccPT.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAccPT.Name = "pnlAccPT";
            this.pnlAccPT.Size = new System.Drawing.Size(4, 46);

            // ── pnlNavDKDV ───────────────────────────────────────────
            this.pnlNavDKDV.BackColor = System.Drawing.Color.Transparent;
            this.pnlNavDKDV.Controls.Add(this.btnDKDV);
            this.pnlNavDKDV.Controls.Add(this.pnlAccDKDV);
            this.pnlNavDKDV.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNavDKDV.Name = "pnlNavDKDV";
            this.pnlNavDKDV.Size = new System.Drawing.Size(240, 46);

            this.btnDKDV.BackColor = System.Drawing.Color.Transparent;
            this.btnDKDV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDKDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDKDV.FlatAppearance.BorderSize = 0;
            this.btnDKDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDKDV.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnDKDV.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.btnDKDV.Name = "btnDKDV";
            this.btnDKDV.TabStop = false;
            this.btnDKDV.Text = "    📋   Đăng Ký DV";
            this.btnDKDV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDKDV.UseVisualStyleBackColor = false;
            this.btnDKDV.Click += new System.EventHandler(this.btnDKDV_Click);

            this.pnlAccDKDV.BackColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.pnlAccDKDV.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAccDKDV.Name = "pnlAccDKDV";
            this.pnlAccDKDV.Size = new System.Drawing.Size(4, 46);

            // ── pnlNavND ─────────────────────────────────────────────
            this.pnlNavND.BackColor = System.Drawing.Color.Transparent;
            this.pnlNavND.Controls.Add(this.btnND);
            this.pnlNavND.Controls.Add(this.pnlAccND);
            this.pnlNavND.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNavND.Name = "pnlNavND";
            this.pnlNavND.Size = new System.Drawing.Size(240, 46);

            this.btnND.BackColor = System.Drawing.Color.Transparent;
            this.btnND.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnND.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnND.FlatAppearance.BorderSize = 0;
            this.btnND.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnND.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnND.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.btnND.Name = "btnND";
            this.btnND.TabStop = false;
            this.btnND.Text = "    👤   Người Dùng";
            this.btnND.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnND.UseVisualStyleBackColor = false;
            this.btnND.Click += new System.EventHandler(this.btnND_Click);

            this.pnlAccND.BackColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.pnlAccND.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAccND.Name = "pnlAccND";
            this.pnlAccND.Size = new System.Drawing.Size(4, 46);

            // ── pnlNavAL ─────────────────────────────────────────────
            this.pnlNavAL.BackColor = System.Drawing.Color.Transparent;
            this.pnlNavAL.Controls.Add(this.btnAL);
            this.pnlNavAL.Controls.Add(this.pnlAccAL);
            this.pnlNavAL.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNavAL.Name = "pnlNavAL";
            this.pnlNavAL.Size = new System.Drawing.Size(240, 46);

            this.btnAL.BackColor = System.Drawing.Color.Transparent;
            this.btnAL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAL.FlatAppearance.BorderSize = 0;
            this.btnAL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAL.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnAL.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.btnAL.Name = "btnAL";
            this.btnAL.TabStop = false;
            this.btnAL.Text = "    🗒   Audit Log";
            this.btnAL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAL.UseVisualStyleBackColor = false;
            this.btnAL.Click += new System.EventHandler(this.btnAL_Click);

            this.pnlAccAL.BackColor = System.Drawing.Color.FromArgb(17, 24, 39);
            this.pnlAccAL.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAccAL.Name = "pnlAccAL";
            this.pnlAccAL.Size = new System.Drawing.Size(4, 46);
            // 
            // pnlAccHC
            // 
            this.pnlAccHC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.pnlAccHC.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAccHC.Location = new System.Drawing.Point(0, 0);
            this.pnlAccHC.Name = "pnlAccHC";
            this.pnlAccHC.Size = new System.Drawing.Size(4, 46);
            this.pnlAccHC.TabIndex = 1;
            // 
            // pnlNavHD
            // 
            this.pnlNavHD.BackColor = System.Drawing.Color.Transparent;
            this.pnlNavHD.Controls.Add(this.btnHD);
            this.pnlNavHD.Controls.Add(this.pnlAccHD);
            this.pnlNavHD.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNavHD.Location = new System.Drawing.Point(0, 174);
            this.pnlNavHD.Name = "pnlNavHD";
            this.pnlNavHD.Size = new System.Drawing.Size(240, 46);
            this.pnlNavHD.TabIndex = 9;
            // 
            // btnHD
            // 
            this.btnHD.BackColor = System.Drawing.Color.Transparent;
            this.btnHD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHD.FlatAppearance.BorderSize = 0;
            this.btnHD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHD.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnHD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.btnHD.Location = new System.Drawing.Point(4, 0);
            this.btnHD.Name = "btnHD";
            this.btnHD.Size = new System.Drawing.Size(236, 46);
            this.btnHD.TabIndex = 0;
            this.btnHD.TabStop = false;
            this.btnHD.Text = "    📄   Hợp Đồng";
            this.btnHD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHD.UseVisualStyleBackColor = false;
            this.btnHD.Click += new System.EventHandler(this.btnHD_Click);
            // 
            // pnlAccHD
            // 
            this.pnlAccHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.pnlAccHD.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAccHD.Location = new System.Drawing.Point(0, 0);
            this.pnlAccHD.Name = "pnlAccHD";
            this.pnlAccHD.Size = new System.Drawing.Size(4, 46);
            this.pnlAccHD.TabIndex = 1;
            // 
            // pnlNavCH
            // 
            this.pnlNavCH.BackColor = System.Drawing.Color.Transparent;
            this.pnlNavCH.Controls.Add(this.btnCH);
            this.pnlNavCH.Controls.Add(this.pnlAccCH);
            this.pnlNavCH.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNavCH.Location = new System.Drawing.Point(0, 128);
            this.pnlNavCH.Name = "pnlNavCH";
            this.pnlNavCH.Size = new System.Drawing.Size(240, 46);
            this.pnlNavCH.TabIndex = 10;
            // 
            // btnCH
            // 
            this.btnCH.BackColor = System.Drawing.Color.Transparent;
            this.btnCH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCH.FlatAppearance.BorderSize = 0;
            this.btnCH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnCH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCH.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnCH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.btnCH.Location = new System.Drawing.Point(4, 0);
            this.btnCH.Name = "btnCH";
            this.btnCH.Size = new System.Drawing.Size(236, 46);
            this.btnCH.TabIndex = 0;
            this.btnCH.TabStop = false;
            this.btnCH.Text = "    🏢   Căn Hộ";
            this.btnCH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCH.UseVisualStyleBackColor = false;
            this.btnCH.Click += new System.EventHandler(this.btnCH_Click);
            // 
            // pnlAccCH
            // 
            this.pnlAccCH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.pnlAccCH.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAccCH.Location = new System.Drawing.Point(0, 0);
            this.pnlAccCH.Name = "pnlAccCH";
            this.pnlAccCH.Size = new System.Drawing.Size(4, 46);
            this.pnlAccCH.TabIndex = 1;
            // 
            // pnlNavCD
            // 
            this.pnlNavCD.BackColor = System.Drawing.Color.Transparent;
            this.pnlNavCD.Controls.Add(this.btnCD);
            this.pnlNavCD.Controls.Add(this.pnlAccCD);
            this.pnlNavCD.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNavCD.Location = new System.Drawing.Point(0, 82);
            this.pnlNavCD.Name = "pnlNavCD";
            this.pnlNavCD.Size = new System.Drawing.Size(240, 46);
            this.pnlNavCD.TabIndex = 11;
            // 
            // btnCD
            // 
            this.btnCD.BackColor = System.Drawing.Color.Transparent;
            this.btnCD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCD.FlatAppearance.BorderSize = 0;
            this.btnCD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnCD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCD.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnCD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.btnCD.Location = new System.Drawing.Point(4, 0);
            this.btnCD.Name = "btnCD";
            this.btnCD.Size = new System.Drawing.Size(236, 46);
            this.btnCD.TabIndex = 0;
            this.btnCD.TabStop = false;
            this.btnCD.Text = "    👥   Cư Dân";
            this.btnCD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCD.UseVisualStyleBackColor = false;
            this.btnCD.Click += new System.EventHandler(this.btnCD_Click);
            // 
            // pnlAccCD
            // 
            this.pnlAccCD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.pnlAccCD.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAccCD.Location = new System.Drawing.Point(0, 0);
            this.pnlAccCD.Name = "pnlAccCD";
            this.pnlAccCD.Size = new System.Drawing.Size(4, 46);
            this.pnlAccCD.TabIndex = 1;
            // 
            // pnlNavTQ
            // 
            this.pnlNavTQ.BackColor = System.Drawing.Color.Transparent;
            this.pnlNavTQ.Controls.Add(this.btnTQ);
            this.pnlNavTQ.Controls.Add(this.pnlAccTQ);
            this.pnlNavTQ.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNavTQ.Location = new System.Drawing.Point(0, 36);
            this.pnlNavTQ.Name = "pnlNavTQ";
            this.pnlNavTQ.Size = new System.Drawing.Size(240, 46);
            this.pnlNavTQ.TabIndex = 12;
            // 
            // btnTQ
            // 
            this.btnTQ.BackColor = System.Drawing.Color.Transparent;
            this.btnTQ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTQ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTQ.FlatAppearance.BorderSize = 0;
            this.btnTQ.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnTQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTQ.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnTQ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.btnTQ.Location = new System.Drawing.Point(4, 0);
            this.btnTQ.Name = "btnTQ";
            this.btnTQ.Size = new System.Drawing.Size(236, 46);
            this.btnTQ.TabIndex = 0;
            this.btnTQ.TabStop = false;
            this.btnTQ.Text = "    ⬡   Tổng Quan";
            this.btnTQ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTQ.UseVisualStyleBackColor = false;
            this.btnTQ.Click += new System.EventHandler(this.btnTQ_Click);
            // 
            // pnlAccTQ
            // 
            this.pnlAccTQ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.pnlAccTQ.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAccTQ.Location = new System.Drawing.Point(0, 0);
            this.pnlAccTQ.Name = "pnlAccTQ";
            this.pnlAccTQ.Size = new System.Drawing.Size(4, 46);
            this.pnlAccTQ.TabIndex = 1;
            // 
            // lblNavSection
            // 
            this.lblNavSection.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNavSection.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblNavSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblNavSection.Location = new System.Drawing.Point(0, 4);
            this.lblNavSection.Name = "lblNavSection";
            this.lblNavSection.Padding = new System.Windows.Forms.Padding(20, 0, 0, 4);
            this.lblNavSection.Size = new System.Drawing.Size(240, 32);
            this.lblNavSection.TabIndex = 13;
            this.lblNavSection.Text = "  MENU CHÍNH";
            this.lblNavSection.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // pnlSidebarHeader
            // 
            this.pnlSidebarHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(16)))), ((int)(((byte)(28)))));
            this.pnlSidebarHeader.Controls.Add(this.pnlLogoBox);
            this.pnlSidebarHeader.Controls.Add(this.lblAppName);
            this.pnlSidebarHeader.Controls.Add(this.lblAppTagline);
            this.pnlSidebarHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSidebarHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebarHeader.Name = "pnlSidebarHeader";
            this.pnlSidebarHeader.Size = new System.Drawing.Size(240, 72);
            this.pnlSidebarHeader.TabIndex = 1;
            // 
            // pnlLogoBox
            // 
            this.pnlLogoBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.pnlLogoBox.Controls.Add(this.lblLogoChar);
            this.pnlLogoBox.Location = new System.Drawing.Point(18, 18);
            this.pnlLogoBox.Name = "pnlLogoBox";
            this.pnlLogoBox.Size = new System.Drawing.Size(36, 36);
            this.pnlLogoBox.TabIndex = 0;
            // 
            // lblLogoChar
            // 
            this.lblLogoChar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLogoChar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblLogoChar.ForeColor = System.Drawing.Color.White;
            this.lblLogoChar.Location = new System.Drawing.Point(0, 0);
            this.lblLogoChar.Name = "lblLogoChar";
            this.lblLogoChar.Size = new System.Drawing.Size(36, 36);
            this.lblLogoChar.TabIndex = 0;
            this.lblLogoChar.Text = "CC";
            this.lblLogoChar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblAppName.ForeColor = System.Drawing.Color.White;
            this.lblAppName.Location = new System.Drawing.Point(62, 16);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(85, 28);
            this.lblAppName.TabIndex = 1;
            this.lblAppName.Text = "DatTam";
            // 
            // lblAppTagline
            // 
            this.lblAppTagline.AutoSize = true;
            this.lblAppTagline.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblAppTagline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblAppTagline.Location = new System.Drawing.Point(62, 38);
            this.lblAppTagline.Name = "lblAppTagline";
            this.lblAppTagline.Size = new System.Drawing.Size(117, 19);
            this.lblAppTagline.TabIndex = 2;
            this.lblAppTagline.Text = "Quản lý chung cư";
            // 
            // pnlSidebarFooter
            // 
            this.pnlSidebarFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(16)))), ((int)(((byte)(28)))));
            this.pnlSidebarFooter.Controls.Add(this.pnlNavDX);
            this.pnlSidebarFooter.Controls.Add(this.lblVersion);
            this.pnlSidebarFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSidebarFooter.Location = new System.Drawing.Point(0, 724);
            this.pnlSidebarFooter.Name = "pnlSidebarFooter";
            this.pnlSidebarFooter.Size = new System.Drawing.Size(240, 96);
            this.pnlSidebarFooter.TabIndex = 2;
            // 
            // pnlNavDX
            // 
            this.pnlNavDX.BackColor = System.Drawing.Color.Transparent;
            this.pnlNavDX.Controls.Add(this.btnDX);
            this.pnlNavDX.Controls.Add(this.pnlAccDX);
            this.pnlNavDX.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNavDX.Location = new System.Drawing.Point(0, 0);
            this.pnlNavDX.Name = "pnlNavDX";
            this.pnlNavDX.Size = new System.Drawing.Size(240, 46);
            this.pnlNavDX.TabIndex = 0;
            // 
            // btnDX
            // 
            this.btnDX.BackColor = System.Drawing.Color.Transparent;
            this.btnDX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDX.FlatAppearance.BorderSize = 0;
            this.btnDX.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnDX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDX.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnDX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.btnDX.Location = new System.Drawing.Point(4, 0);
            this.btnDX.Name = "btnDX";
            this.btnDX.Size = new System.Drawing.Size(236, 46);
            this.btnDX.TabIndex = 0;
            this.btnDX.TabStop = false;
            this.btnDX.Text = "    ⏻   Đăng Xuất";
            this.btnDX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDX.UseVisualStyleBackColor = false;
            this.btnDX.Click += new System.EventHandler(this.btnDX_Click);
            // 
            // pnlAccDX
            // 
            this.pnlAccDX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(16)))), ((int)(((byte)(28)))));
            this.pnlAccDX.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAccDX.Location = new System.Drawing.Point(0, 0);
            this.pnlAccDX.Name = "pnlAccDX";
            this.pnlAccDX.Size = new System.Drawing.Size(4, 46);
            this.pnlAccDX.TabIndex = 1;
            // 
            // lblVersion
            // 
            this.lblVersion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblVersion.Location = new System.Drawing.Point(0, 70);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(240, 26);
            this.lblVersion.TabIndex = 1;
            this.lblVersion.Text = "  v1.0.0  •  © 2025 DatTam";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlWorkspace
            // 
            this.pnlWorkspace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.pnlWorkspace.Controls.Add(this.pnlContent);
            this.pnlWorkspace.Controls.Add(this.pnlHeader);
            this.pnlWorkspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlWorkspace.Location = new System.Drawing.Point(240, 0);
            this.pnlWorkspace.Name = "pnlWorkspace";
            this.pnlWorkspace.Size = new System.Drawing.Size(1120, 820);
            this.pnlWorkspace.TabIndex = 0;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 64);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(24, 20, 24, 20);
            this.pnlContent.Size = new System.Drawing.Size(1120, 756);
            this.pnlContent.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.pnlHeader.Controls.Add(this.lblPageTitle);
            this.pnlHeader.Controls.Add(this.lblBreadcrumb);
            this.pnlHeader.Controls.Add(this.pnlHeaderRight);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1120, 64);
            this.pnlHeader.TabIndex = 1;
            this.pnlHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHeader_Paint);
            this.pnlHeader.DoubleClick += new System.EventHandler(this.pnlHeader_DoubleClick);
            this.pnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseDown);
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.ForeColor = System.Drawing.Color.White;
            this.lblPageTitle.Location = new System.Drawing.Point(24, 9);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(141, 32);
            this.lblPageTitle.TabIndex = 0;
            this.lblPageTitle.Text = "Tổng Quan";
            // 
            // lblBreadcrumb
            // 
            this.lblBreadcrumb.AutoSize = true;
            this.lblBreadcrumb.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblBreadcrumb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblBreadcrumb.Location = new System.Drawing.Point(26, 40);
            this.lblBreadcrumb.Name = "lblBreadcrumb";
            this.lblBreadcrumb.Size = new System.Drawing.Size(166, 19);
            this.lblBreadcrumb.TabIndex = 1;
            this.lblBreadcrumb.Text = "Dashboard  /  Tổng Quan";
            // 
            // pnlHeaderRight
            // 
            this.pnlHeaderRight.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeaderRight.Controls.Add(this.lblDateTime);    
            this.pnlHeaderRight.Controls.Add(this.pnlAvatarWrap); 
            this.pnlHeaderRight.Controls.Add(this.pnlHDivider);   
            this.pnlHeaderRight.Controls.Add(this.pnlWinCtrl);
            this.pnlHeaderRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlHeaderRight.Location = new System.Drawing.Point(560, 0);
            this.pnlHeaderRight.Name = "pnlHeaderRight";
            this.pnlHeaderRight.Size = new System.Drawing.Size(560, 64);
            this.pnlHeaderRight.TabIndex = 2;
            // 
            // pnlWinCtrl
            // 
            this.pnlWinCtrl.BackColor = System.Drawing.Color.Transparent;
            this.pnlWinCtrl.Controls.Add(this.btnWinClose);
            this.pnlWinCtrl.Controls.Add(this.btnWinMax);
            this.pnlWinCtrl.Controls.Add(this.btnWinMin);
            this.pnlWinCtrl.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlWinCtrl.Location = new System.Drawing.Point(251, 0);
            this.pnlWinCtrl.Name = "pnlWinCtrl";
            this.pnlWinCtrl.Size = new System.Drawing.Size(108, 74);
            this.pnlWinCtrl.TabIndex = 0;
            // 
            // btnWinClose
            // 
            this.btnWinClose.BackColor = System.Drawing.Color.Transparent;
            this.btnWinClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWinClose.FlatAppearance.BorderSize = 0;
            this.btnWinClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnWinClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWinClose.Font = new System.Drawing.Font("Segoe UI Symbol", 9F);
            this.btnWinClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnWinClose.Location = new System.Drawing.Point(72, 0);
            this.btnWinClose.Name = "btnWinClose";
            this.btnWinClose.Size = new System.Drawing.Size(36, 64);
            this.btnWinClose.TabIndex = 0;
            this.btnWinClose.TabStop = false;
            this.btnWinClose.Text = "✕";
            this.btnWinClose.UseVisualStyleBackColor = false;
            this.btnWinClose.Click += new System.EventHandler(this.btnWinClose_Click);
            // 
            // btnWinMax
            // 
            this.btnWinMax.BackColor = System.Drawing.Color.Transparent;
            this.btnWinMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWinMax.FlatAppearance.BorderSize = 0;
            this.btnWinMax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnWinMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWinMax.Font = new System.Drawing.Font("Segoe UI Symbol", 9F);
            this.btnWinMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnWinMax.Location = new System.Drawing.Point(36, 0);
            this.btnWinMax.Name = "btnWinMax";
            this.btnWinMax.Size = new System.Drawing.Size(36, 64);
            this.btnWinMax.TabIndex = 1;
            this.btnWinMax.TabStop = false;
            this.btnWinMax.Text = "□";
            this.btnWinMax.UseVisualStyleBackColor = false;
            this.btnWinMax.Click += new System.EventHandler(this.btnWinMax_Click);
            // 
            // btnWinMin
            // 
            this.btnWinMin.BackColor = System.Drawing.Color.Transparent;
            this.btnWinMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWinMin.FlatAppearance.BorderSize = 0;
            this.btnWinMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btnWinMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWinMin.Font = new System.Drawing.Font("Segoe UI Symbol", 9F);
            this.btnWinMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnWinMin.Location = new System.Drawing.Point(0, 0);
            this.btnWinMin.Name = "btnWinMin";
            this.btnWinMin.Size = new System.Drawing.Size(36, 64);
            this.btnWinMin.TabIndex = 2;
            this.btnWinMin.TabStop = false;
            this.btnWinMin.Text = "─";
            this.btnWinMin.UseVisualStyleBackColor = false;
            this.btnWinMin.Click += new System.EventHandler(this.btnWinMin_Click);
            // 
            // pnlHDivider
            // 
            this.pnlHDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.pnlHDivider.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlHDivider.Location = new System.Drawing.Point(359, 0);
            this.pnlHDivider.Name = "pnlHDivider";
            this.pnlHDivider.Size = new System.Drawing.Size(1, 64);
            this.pnlHDivider.TabIndex = 1;
            // 
            // lblDateTime
            // 
            this.lblDateTime.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDateTime.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblDateTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblDateTime.Location = new System.Drawing.Point(0, 0);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(240, 64);
            this.lblDateTime.TabIndex = 3;
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerClock
            // 
            this.timerClock.Enabled = true;
            this.timerClock.Interval = 1000;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // lblAvatarRole
            // 
            this.lblAvatarRole.AutoSize = true;
            this.lblAvatarRole.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblAvatarRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblAvatarRole.Location = new System.Drawing.Point(64, 33);
            this.lblAvatarRole.Name = "lblAvatarRole";
            this.lblAvatarRole.Size = new System.Drawing.Size(49, 19);
            this.lblAvatarRole.TabIndex = 2;
            this.lblAvatarRole.Text = "Admin";
            // 
            // lblAvatarName
            // 
            this.lblAvatarName.AutoEllipsis = true;
            this.lblAvatarName.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblAvatarName.ForeColor = System.Drawing.Color.White;
            this.lblAvatarName.Location = new System.Drawing.Point(64, 12);
            this.lblAvatarName.Name = "lblAvatarName";
            this.lblAvatarName.Size = new System.Drawing.Size(128, 18);
            this.lblAvatarName.TabIndex = 1;
            this.lblAvatarName.Text = "Quản Trị Viên";
            // 
            // pnlAvatarCircle
            // 
            this.pnlAvatarCircle.BackColor = System.Drawing.Color.Transparent;
            this.pnlAvatarCircle.Location = new System.Drawing.Point(16, 12);
            this.pnlAvatarCircle.Name = "pnlAvatarCircle";
            this.pnlAvatarCircle.Size = new System.Drawing.Size(40, 40);
            this.pnlAvatarCircle.TabIndex = 0;
            this.pnlAvatarCircle.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAvatarCircle_Paint);
            // 
            // pnlAvatarWrap
            // 
            this.pnlAvatarWrap.BackColor = System.Drawing.Color.Transparent;
            this.pnlAvatarWrap.Controls.Add(this.pnlAvatarCircle);
            this.pnlAvatarWrap.Controls.Add(this.lblAvatarName);
            this.pnlAvatarWrap.Controls.Add(this.lblAvatarRole);
            this.pnlAvatarWrap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlAvatarWrap.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlAvatarWrap.Location = new System.Drawing.Point(360, 0);
            this.pnlAvatarWrap.Name = "pnlAvatarWrap";
            this.pnlAvatarWrap.Size = new System.Drawing.Size(210, 64);
            this.pnlAvatarWrap.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1360, 820);
            this.Controls.Add(this.pnlWorkspace);
            this.Controls.Add(this.pnlSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1060, 640);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khu Chung Cư DatTam";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlNavArea.ResumeLayout(false);
            this.pnlNavBC.ResumeLayout(false);
            this.pnlNavPQ.ResumeLayout(false);
            this.pnlNavTB.ResumeLayout(false);
            this.pnlNavKN.ResumeLayout(false);
            this.pnlNavBT.ResumeLayout(false);
            this.pnlNavCC.ResumeLayout(false);
            this.pnlNavDV.ResumeLayout(false);
            this.pnlNavCN.ResumeLayout(false);
            this.pnlNavTT.ResumeLayout(false);
            this.pnlNavHC.ResumeLayout(false);
            this.pnlNavHD.ResumeLayout(false);
            this.pnlNavCH.ResumeLayout(false);
            this.pnlNavCD.ResumeLayout(false);
            this.pnlNavTQ.ResumeLayout(false);
            this.pnlSidebarHeader.ResumeLayout(false);
            this.pnlSidebarHeader.PerformLayout();
            this.pnlLogoBox.ResumeLayout(false);
            this.pnlSidebarFooter.ResumeLayout(false);
            this.pnlNavDX.ResumeLayout(false);
            this.pnlWorkspace.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlHeaderRight.ResumeLayout(false);
            this.pnlWinCtrl.ResumeLayout(false);
            this.pnlAvatarWrap.ResumeLayout(false);
            this.pnlAvatarWrap.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlAvatarWrap;
        private System.Windows.Forms.Panel pnlAvatarCircle;
        private System.Windows.Forms.Label lblAvatarName;
        private System.Windows.Forms.Label lblAvatarRole;
    }
}