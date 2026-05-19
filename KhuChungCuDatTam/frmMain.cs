using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using KhuChungCuDatTam.Helpers;
using KhuChungCuDatTam.UserControls;

namespace KhuChungCuDatTam
{
    public partial class frmMain : Form
    {
        private Color CLR_BG => AppTheme.Current.Background;
        private Color CLR_SIDEBAR => AppTheme.Current.Sidebar;
        private Color CLR_CARD => AppTheme.Current.Card;
        private Color CLR_PRIMARY => AppTheme.Current.Primary;
        private Color CLR_MUTED => AppTheme.Current.TextMuted;

        private struct NavItem { public Panel Accent; public Button Btn; }
        private List<NavItem> _navItems;
        private NavItem _activeItem;

        private Button _btnThemeToggle;
        private UserControl _currentUC;

        [DllImport("user32.dll")] private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")] private static extern bool ReleaseCapture();
        [DllImport("Gdi32.dll")] private static extern IntPtr CreateRoundRectRgn(int nL, int nT, int nR, int nB, int nW, int nH);

        protected override CreateParams CreateParams
        {
            get { var cp = base.CreateParams; cp.ClassStyle |= 0x20000; return cp; }
        }

        public frmMain()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint, true);
            this.WindowState = FormWindowState.Maximized;
            CreateThemeToggleButton();
        }

        private void CreateThemeToggleButton()
        {
            _btnThemeToggle = new Button
            {
                Text = "🌙  Dark",
                Font = new Font("Segoe UI", 8.5F, FontStyle.Bold),
                Size = new Size(95, 32),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                TabStop = false,
                BackColor = Color.FromArgb(30, 41, 59),
                ForeColor = Color.White,
                Dock = DockStyle.None,
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
            };
            _btnThemeToggle.FlatAppearance.BorderSize = 1;
            _btnThemeToggle.FlatAppearance.BorderColor = Color.FromArgb(59, 130, 246);
            _btnThemeToggle.FlatAppearance.MouseOverBackColor = Color.FromArgb(59, 130, 246);
            _btnThemeToggle.Click += BtnThemeToggle_Click;

            pnlHeader.Controls.Add(_btnThemeToggle);
            _btnThemeToggle.BringToFront();
            PositionThemeToggle();
        }

        private void PositionThemeToggle()
        {
            if (_btnThemeToggle == null) return;
            int x = pnlHeaderRight.Left - _btnThemeToggle.Width - 10;
            int y = (pnlHeader.Height - _btnThemeToggle.Height) / 2;
            _btnThemeToggle.Location = new Point(x, y);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Index map:
            // [0] TQ  [1] CD  [2] CH  [3] PT  [4] HD
            // [5] HC  [6] TT  [7] CN  [8] DV  [9] DKDV
            // [10] BT [11] KN [12] TB [13] BC
            // [14] ND [15] PQ [16] AL
            _navItems = new List<NavItem>
            {
                new NavItem { Accent = pnlAccTQ,   Btn = btnTQ   },  // [0]  Tổng Quan
                new NavItem { Accent = pnlAccCD,   Btn = btnCD   },  // [1]  Cư Dân
                new NavItem { Accent = pnlAccCH,   Btn = btnCH   },  // [2]  Căn Hộ
                new NavItem { Accent = pnlAccPT,   Btn = btnPT   },  // [3]  Phương Tiện
                new NavItem { Accent = pnlAccHD,   Btn = btnHD   },  // [4]  Hợp Đồng
                new NavItem { Accent = pnlAccHC,   Btn = btnHC   },  // [5]  Hóa Đơn
                new NavItem { Accent = pnlAccTT,   Btn = btnTT   },  // [6]  Thanh Toán
                new NavItem { Accent = pnlAccCN,   Btn = btnCN   },  // [7]  Công Nợ
                new NavItem { Accent = pnlAccDV,   Btn = btnDV   },  // [8]  Dịch Vụ
                new NavItem { Accent = pnlAccDKDV, Btn = btnDKDV },  // [9]  Đăng Ký DV
                new NavItem { Accent = pnlAccBT,   Btn = btnBT   },  // [10] Bảo Trì
                new NavItem { Accent = pnlAccCC,   Btn = btnCC   },  // [11] Chấm Công
                new NavItem { Accent = pnlAccBL,   Btn = btnBL   },  // [12] Bảng Lương 
                new NavItem { Accent = pnlAccKN,   Btn = btnKN   },  // [13] Khiếu Nại
                new NavItem { Accent = pnlAccTB,   Btn = btnTB   },  // [14] Thông Báo
                new NavItem { Accent = pnlAccBC,   Btn = btnBC   },  // [15] Báo Cáo
                new NavItem { Accent = pnlAccND,   Btn = btnND   },  // [16] Người Dùng
                new NavItem { Accent = pnlAccPQ,   Btn = btnPQ   },  // [17] Phân Quyền
                new NavItem { Accent = pnlAccAL,   Btn = btnAL   },  // [18] Audit Log
            };

            foreach (var item in _navItems)
                HookNavHover(item);

            AppTheme.ThemeChanged += OnThemeChanged;
            ApplyThemeToForm();
            ApplyRoundedCorners();
            RefreshUserInfo();
            ApDungPhanQuyen();
            timerClock_Tick(null, EventArgs.Empty);

            btnTQ.PerformClick();
        }

        private void ApDungPhanQuyen()
        {
            if (SessionManager.IsAdmin) return;

            pnlNavCD.Visible = PermissionHelper.CoQuanLyCuDan;
            pnlNavCH.Visible = PermissionHelper.CoQuanLyCanHo;
            pnlNavPT.Visible = PermissionHelper.CoQuanLyPhuongTien;
            pnlNavHD.Visible = PermissionHelper.CoQuanLyCuDan;      // Hợp đồng ~ quản lý cư dân
            pnlNavHC.Visible = PermissionHelper.CoQuanLyHoaDon;
            pnlNavTT.Visible = PermissionHelper.CoQuanLyThanhToan;
            pnlNavCN.Visible = PermissionHelper.CoQuanLyHoaDon;     // Công nợ ~ hóa đơn
            pnlNavDV.Visible = PermissionHelper.CoQuanLyDichVu;
            pnlNavDKDV.Visible = PermissionHelper.CoQuanLyDichVu;
            pnlNavBT.Visible = PermissionHelper.CoQuanLyBaoTri;
            pnlNavKN.Visible = PermissionHelper.CoQuanLyCuDan;      // Khiếu nại ~ cư dân
            pnlNavTB.Visible = PermissionHelper.CoGuiThongBao;
            pnlNavBC.Visible = PermissionHelper.CoXemBaoCao;
            pnlNavCC.Visible = PermissionHelper.CoQuanLyChamCong;
            pnlNavBL.Visible = PermissionHelper.CoQuanLyBangLuong;
            pnlNavND.Visible = false;                                // Chỉ Admin
            pnlNavPQ.Visible = false;                               
            pnlNavAL.Visible = false;
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            ApplyRoundedCorners();
            PositionThemeToggle();
            btnWinMax.Text = WindowState == FormWindowState.Maximized ? "❐" : "□";
            pnlHeaderRight.Width = Math.Max(560, pnlHeader.Width / 2);
        }

        private void OnThemeChanged(object sender, EventArgs e)
        {
            UpdateToggleButtonLabel();
            ApplyThemeToForm();
            if (_currentUC != null) ThemeManager.Apply(_currentUC);
            if (_activeItem.Btn != null) HighlightActiveNav(_activeItem);
        }

        private void ApplyThemeToForm()
        {
            ThemeManager.Apply(this);
            pnlSidebarHeader.BackColor = AppTheme.IsDark
                ? Color.FromArgb(10, 16, 28) : Color.FromArgb(248, 250, 252);
            pnlSidebarFooter.BackColor = AppTheme.IsDark
                ? Color.FromArgb(10, 16, 28) : Color.FromArgb(241, 245, 249);

            foreach (var item in _navItems)
            {
                bool isActive = _activeItem.Btn != null && item.Btn == _activeItem.Btn;
                item.Accent.BackColor = isActive
                    ? AppTheme.Current.Primary
                    : AppTheme.Current.Sidebar;
            }
            UpdateToggleButtonLabel();
            Invalidate(true);
        }

        private void HighlightActiveNav(NavItem target)
        {
            target.Accent.BackColor = AppTheme.Current.Primary;
            target.Btn.BackColor = AppTheme.Current.Card;
            target.Btn.ForeColor = AppTheme.Current.TextPrimary;
            target.Btn.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
        }

        private void UpdateToggleButtonLabel()
        {
            if (_btnThemeToggle == null) return;
            if (AppTheme.IsDark)
            {
                _btnThemeToggle.Text = "🌙  Dark";
                _btnThemeToggle.BackColor = Color.FromArgb(30, 41, 59);
                _btnThemeToggle.ForeColor = Color.White;
                _btnThemeToggle.FlatAppearance.BorderColor = Color.FromArgb(59, 130, 246);
            }
            else
            {
                _btnThemeToggle.Text = "☀️  Light";
                _btnThemeToggle.BackColor = Color.FromArgb(248, 250, 252);
                _btnThemeToggle.ForeColor = Color.FromArgb(15, 23, 42);
                _btnThemeToggle.FlatAppearance.BorderColor = Color.FromArgb(226, 232, 240);
            }
        }

        private void BtnThemeToggle_Click(object sender, EventArgs e) => AppTheme.Toggle();

        private void ApplyRoundedCorners()
        {
            if (WindowState == FormWindowState.Normal)
                Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 12, 12));
            else
                Region = null;
        }

        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && WindowState != FormWindowState.Maximized)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }

        private void pnlHeader_DoubleClick(object sender, EventArgs e) => btnWinMax.PerformClick();

        protected override void WndProc(ref Message m)
        {
            const int WM_NCHITTEST = 0x84;
            const int HTLEFT = 10, HTRIGHT = 11, HTTOP = 12,
                      HTTOPLEFT = 13, HTTOPRIGHT = 14,
                      HTBOTTOM = 15, HTBOTTOMLEFT = 16, HTBOTTOMRIGHT = 17;
            const int GRIP = 8;

            if (m.Msg == WM_NCHITTEST && WindowState == FormWindowState.Normal)
            {
                var pt = PointToClient(new Point(
                    (int)(m.LParam.ToInt64() & 0xFFFF),
                    (int)(m.LParam.ToInt64() >> 16)));

                bool L = pt.X < GRIP, R = pt.X > Width - GRIP,
                     T = pt.Y < GRIP, B = pt.Y > Height - GRIP;

                if (T && L) { m.Result = (IntPtr)HTTOPLEFT; return; }
                if (T && R) { m.Result = (IntPtr)HTTOPRIGHT; return; }
                if (B && L) { m.Result = (IntPtr)HTBOTTOMLEFT; return; }
                if (B && R) { m.Result = (IntPtr)HTBOTTOMRIGHT; return; }
                if (L) { m.Result = (IntPtr)HTLEFT; return; }
                if (R) { m.Result = (IntPtr)HTRIGHT; return; }
                if (T) { m.Result = (IntPtr)HTTOP; return; }
                if (B) { m.Result = (IntPtr)HTBOTTOM; return; }
            }
            base.WndProc(ref m);
        }

        private void btnWinMin_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

        private void btnWinMax_Click(object sender, EventArgs e)
        {
            WindowState = WindowState == FormWindowState.Maximized
                ? FormWindowState.Normal : FormWindowState.Maximized;
        }

        private void btnWinClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void timerClock_Tick(object sender, EventArgs e)
            => lblDateTime.Text = DateTime.Now.ToString("ddd, dd/MM/yyyy   HH:mm:ss");

        private void RefreshUserInfo()
        {
            lblAvatarName.Text = SessionManager.HoTen ?? "Quản Trị Viên";
            lblAvatarRole.Text = SessionManager.TenVaiTro ?? "Admin";
            pnlAvatarCircle.Invalidate();
        }

        private void pnlAvatarCircle_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;

            int size = Math.Min(pnlAvatarCircle.Width, pnlAvatarCircle.Height);
            var rect = new Rectangle(0, 0, size - 1, size - 1);
            g.SetClip(new Rectangle(0, 0, pnlAvatarCircle.Width, pnlAvatarCircle.Height));

            using (var brush = new LinearGradientBrush(rect,
                Color.FromArgb(59, 130, 246), Color.FromArgb(37, 99, 235),
                LinearGradientMode.ForwardDiagonal))
                g.FillEllipse(brush, rect);

            string letter = lblAvatarName.Text?.Length > 0
                ? lblAvatarName.Text[0].ToString().ToUpper() : "A";

            using (var font = new Font("Segoe UI", 14F, FontStyle.Bold))
            using (var sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            })
                g.DrawString(letter, font, Brushes.White,
                    new RectangleF(0, 0, size, size), sf);
        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {
            Color borderColor = AppTheme.IsDark
                ? Color.FromArgb(30, 41, 59)
                : Color.FromArgb(226, 232, 240);
            using (var pen = new Pen(borderColor, 1))
                e.Graphics.DrawLine(pen, 0, pnlHeader.Height - 1,
                    pnlHeader.Width, pnlHeader.Height - 1);
        }

        private void HookNavHover(NavItem item)
        {
            item.Btn.MouseEnter += (s, ev) =>
            {
                if (_activeItem.Btn == item.Btn) return;
                item.Btn.BackColor = AppTheme.Current.SidebarHover;
                item.Btn.ForeColor = AppTheme.Current.TextPrimary;
            };
            item.Btn.MouseLeave += (s, ev) =>
            {
                if (_activeItem.Btn == item.Btn) return;
                item.Btn.BackColor = Color.Transparent;
                item.Btn.ForeColor = AppTheme.Current.TextMuted;
            };
        }

        private void SetActiveNav(NavItem target, string pageTitle, string breadcrumb = null)
        {
            foreach (var item in _navItems)
            {
                item.Accent.BackColor = AppTheme.Current.Sidebar;
                item.Btn.BackColor = Color.Transparent;
                item.Btn.ForeColor = AppTheme.Current.TextMuted;
                item.Btn.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular);
            }
            HighlightActiveNav(target);
            _activeItem = target;
            lblPageTitle.Text = pageTitle;
            lblBreadcrumb.Text = $"Dashboard  /  {(breadcrumb ?? pageTitle)}";
        }

        public void LoadUserControl(UserControl uc)
        {
            try
            {
                pnlContent.SuspendLayout();
                pnlContent.Controls.Clear();
                uc.Dock = DockStyle.Fill;
                ThemeManager.Apply(uc);
                pnlContent.Controls.Add(uc);
                uc.BringToFront();
                pnlContent.ResumeLayout();
                _currentUC = uc;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể tải module.\n\n{ex.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTQ_Click(object sender, EventArgs e)
        {
            SetActiveNav(_navItems[0], "Tổng Quan");
            try { LoadUserControl(new ucTongQuan()); }
            catch (Exception ex) { ShowLoadError("Tổng Quan", ex); }
        }

        private void btnCD_Click(object sender, EventArgs e)
        {
            SetActiveNav(_navItems[1], "Cư Dân");
            try { LoadUserControl(new ucCuDan()); }
            catch (Exception ex) { ShowLoadError("Cư Dân", ex); }
        }

        private void btnCH_Click(object sender, EventArgs e)
        {
            SetActiveNav(_navItems[2], "Căn Hộ");
            try { LoadUserControl(new ucCanHo()); }
            catch (Exception ex) { ShowLoadError("Căn Hộ", ex); }
        }

        private void btnPT_Click(object sender, EventArgs e)
        {
            SetActiveNav(_navItems[3], "Phương Tiện");
            try { LoadUserControl(new ucPhuongTien()); }
            catch (Exception ex) { ShowLoadError("Phương Tiện", ex); }
        }

        private void btnHD_Click(object sender, EventArgs e)
        {
            SetActiveNav(_navItems[4], "Hợp Đồng");
            try { LoadUserControl(new ucHopDong()); }
            catch (Exception ex) { ShowLoadError("Hợp Đồng", ex); }
        }

        private void btnHC_Click(object sender, EventArgs e)
        {
            SetActiveNav(_navItems[5], "Hóa Đơn");
            try { LoadUserControl(new ucHoaDon()); }
            catch (Exception ex) { ShowLoadError("Hóa Đơn", ex); }
        }

        private void btnTT_Click(object sender, EventArgs e)
        {
            SetActiveNav(_navItems[6], "Thanh Toán");
            try { LoadUserControl(new ucThanhToan()); }
            catch (Exception ex) { ShowLoadError("Thanh Toán", ex); }
        }

        private void btnCN_Click(object sender, EventArgs e)
        {
            SetActiveNav(_navItems[7], "Công Nợ");
            try { LoadUserControl(new ucCongNo()); }
            catch (Exception ex) { ShowLoadError("Công Nợ", ex); }
        }

        private void btnDV_Click(object sender, EventArgs e)
        {
            SetActiveNav(_navItems[8], "Dịch Vụ");
            try { LoadUserControl(new ucDichVu()); }
            catch (Exception ex) { ShowLoadError("Dịch Vụ", ex); }
        }

        private void btnDKDV_Click(object sender, EventArgs e)
        {
            SetActiveNav(_navItems[9], "Đăng Ký Dịch Vụ");
            try { LoadUserControl(new ucDangKyDichVu()); }
            catch (Exception ex) { ShowLoadError("Đăng Ký Dịch Vụ", ex); }
        }

        private void btnBT_Click(object sender, EventArgs e)
        {
            SetActiveNav(_navItems[10], "Bảo Trì");
            try { LoadUserControl(new ucBaoTri()); }
            catch (Exception ex) { ShowLoadError("Bảo Trì", ex); }
        }

        private void btnKN_Click(object sender, EventArgs e)
        {
            SetActiveNav(_navItems[11], "Khiếu Nại");
            try { LoadUserControl(new ucKhieuNai()); }
            catch (Exception ex) { ShowLoadError("Khiếu Nại", ex); }
        }

        private void btnTB_Click(object sender, EventArgs e)
        {
            SetActiveNav(_navItems[12], "Thông Báo");
            try { LoadUserControl(new ucThongBao()); }
            catch (Exception ex) { ShowLoadError("Thông Báo", ex); }
        }

        private void btnBC_Click(object sender, EventArgs e)
        {
            SetActiveNav(_navItems[13], "Báo Cáo");
            try { LoadUserControl(new ucBaoCao()); }
            catch (Exception ex) { ShowLoadError("Báo Cáo", ex); }
        }

        private void btnND_Click(object sender, EventArgs e)
        {
            SetActiveNav(_navItems[14], "Người Dùng");
            try { LoadUserControl(new ucNguoiDung()); }
            catch (Exception ex) { ShowLoadError("Người Dùng", ex); }
        }

        private void btnPQ_Click(object sender, EventArgs e)
        {
            SetActiveNav(_navItems[15], "Phân Quyền");
            try { LoadUserControl(new ucPhanQuyen()); }
            catch (Exception ex) { ShowLoadError("Phân Quyền", ex); }
        }

        private void btnAL_Click(object sender, EventArgs e)
        {
            SetActiveNav(_navItems[16], "Audit Log");
            try { LoadUserControl(new ucAuditLog()); }
            catch (Exception ex) { ShowLoadError("Audit Log", ex); }
        }
        private void btnCC_Click(object sender, EventArgs e)
        {
            SetActiveNav(_navItems[11], "Chấm Công");
            try { LoadUserControl(new ucChamCong()); }
            catch (Exception ex) { ShowLoadError("Chấm Công", ex); }
        }
        private void btnBL_Click(object sender, EventArgs e)
        {
            SetActiveNav(_navItems[12], "Bảng Lương");
            try { LoadUserControl(new ucBangLuong()); }
            catch (Exception ex) { ShowLoadError("Bảng Lương", ex); }
        }
        private void btnDX_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Bạn có chắc muốn đăng xuất không?",
                "Xác nhận đăng xuất",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    AppTheme.ThemeChanged -= OnThemeChanged;

                    SessionManager.KetThucPhien();

                    frmDangNhap login = new frmDangNhap();

                    login.FormClosed += (s, args) =>
                    {
                        Application.Exit();
                    };

                    login.Show();

                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        $"Lỗi đăng xuất.\n\n{ex.Message}",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void ShowLoadError(string moduleName, Exception ex)
        {
            MessageBox.Show($"Không thể tải module [{moduleName}].\n\n{ex.Message}",
                "Lỗi tải module", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private static Panel MakeStatCard(string icon, string value, string label, Color accent)
        {
            var card = new Panel { Size = new Size(196, 104), BackColor = AppTheme.Current.Card };
            card.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, 196, 104, 10, 10));
            card.Controls.AddRange(new Control[]
            {
                new Panel { Dock = DockStyle.Top, Height = 3, BackColor = accent },
                new Label { Text = icon,  Font = new Font("Segoe UI", 20F),
                            Location = new Point(14, 18), AutoSize = true, BackColor = Color.Transparent },
                new Label { Text = value, Font = new Font("Segoe UI", 20F, FontStyle.Bold),
                            ForeColor = accent, Location = new Point(60, 18),
                            AutoSize = true, BackColor = Color.Transparent },
                new Label { Text = label, Font = new Font("Segoe UI", 8.5F),
                            ForeColor = AppTheme.Current.TextMuted,
                            Location = new Point(14, 70), AutoSize = true, BackColor = Color.Transparent },
            });
            return card;
        }

        private static Label MakeLabel(string text, Font font, Color color, Point loc, bool autoSize)
        {
            return new Label
            {
                Text = text,
                Font = font,
                ForeColor = color,
                Location = loc,
                AutoSize = autoSize,
                BackColor = Color.Transparent,
            };
        }
    }
}