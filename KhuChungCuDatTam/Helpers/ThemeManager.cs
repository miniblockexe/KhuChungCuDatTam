using System.Drawing;
using System.Windows.Forms;

namespace KhuChungCuDatTam
{
    public static class ThemeManager
    {
        
        public static void Apply(Control root)
        {
            var p = AppTheme.Current;
            ApplyRecursive(root, p, isRoot: true);
        }

       
        private static void ApplyRecursive(Control ctrl, ThemePalette p, bool isRoot = false)
        {
            
            ApplyControl(ctrl, p, isRoot);

            foreach (Control child in ctrl.Controls)
                ApplyRecursive(child, p, isRoot: false);
        }

        private static void ApplyControl(Control ctrl, ThemePalette p, bool isRoot)
        {
            if (ctrl is Form form)
            {
                form.BackColor = p.Background;
                return;
            }

            if (isRoot && ctrl is UserControl uc)
            {
                uc.BackColor = p.Background;
                return;
            }

            if (ctrl is DataGridView dgv)
            {
                ApplyDataGridView(dgv, p);
                return;
            }

            if (ctrl is TextBox txt)
            {
                txt.BackColor = p.Input;
                txt.ForeColor = p.TextPrimary;
                txt.BorderStyle = BorderStyle.FixedSingle;
                return;
            }

            if (ctrl is ComboBox cbo)
            {
                cbo.BackColor = p.Input;
                cbo.ForeColor = p.TextPrimary;
                cbo.FlatStyle = FlatStyle.Flat;
                return;
            }

            if (ctrl is RichTextBox rtb)
            {
                rtb.BackColor = p.Input;
                rtb.ForeColor = p.TextPrimary;
                return;
            }

            if (ctrl is DateTimePicker dtp)
            {
                dtp.CalendarMonthBackground = p.Card;
                dtp.CalendarForeColor = p.TextPrimary;
                dtp.CalendarTitleBackColor = p.Primary;
                dtp.CalendarTitleForeColor = Color.White;
                return;
            }

            if (ctrl is Button btn)
            {
                ApplyButton(btn, p);
                return;
            }

            if (ctrl is Label lbl)
            {
                ApplyLabel(lbl, p);
                return;
            }

            if (ctrl is Panel pnl)
            {
                ApplyPanel(pnl, p);
                return;
            }

            if (ctrl is TabControl tab)
            {
                tab.BackColor = p.Card;
                return;
            }

            if (ctrl is TabPage tp)
            {
                tp.BackColor = p.Card;
                tp.ForeColor = p.TextPrimary;
                return;
            }

            if (ctrl is GroupBox gb)
            {
                gb.BackColor = p.Card;
                gb.ForeColor = p.TextLabel;
                return;
            }

            if (ctrl is CheckBox chk)
            {
                chk.BackColor = Color.Transparent;
                chk.ForeColor = p.TextPrimary;
                return;
            }
            if (ctrl is RadioButton rdb)
            {
                rdb.BackColor = Color.Transparent;
                rdb.ForeColor = p.TextPrimary;
                return;
            }

            if (ctrl is NumericUpDown nud)
            {
                nud.BackColor = p.Input;
                nud.ForeColor = p.TextPrimary;
                return;
            }

            if (ctrl is ListBox lb)
            {
                lb.BackColor = p.Input;
                lb.ForeColor = p.TextPrimary;
                return;
            }

            if (ctrl.BackColor != Color.Transparent)
                ctrl.BackColor = p.Background;
        }

        private static void ApplyButton(Button btn, ThemePalette p)
        {
            Color bg = btn.BackColor;

            bool isAccent =
                IsCloseTo(bg, p.Primary) ||
                IsCloseTo(bg, p.Success) ||
                IsCloseTo(bg, p.Danger) ||
                IsCloseTo(bg, p.Warning) ||

                IsCloseTo(bg, AppTheme.Dark.Primary) ||
                IsCloseTo(bg, AppTheme.Dark.Success) ||
                IsCloseTo(bg, AppTheme.Dark.Danger) ||
                IsCloseTo(bg, AppTheme.Dark.Warning) ||
                IsCloseTo(bg, AppTheme.Light.Primary) ||
                IsCloseTo(bg, AppTheme.Light.Success) ||
                IsCloseTo(bg, AppTheme.Light.Danger) ||
                IsCloseTo(bg, AppTheme.Light.Warning);

            if (!isAccent)
            {
                btn.BackColor = p.ButtonMuted;
                btn.ForeColor = Color.White;
            }
            else
            {
                btn.ForeColor = Color.White;
            }

            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
        }
        private static void ApplyLabel(Label lbl, ThemePalette p)
        {
            lbl.BackColor = Color.Transparent;

            Color fg = lbl.ForeColor;

            if (IsCloseTo(fg, Color.White) || IsCloseTo(fg, AppTheme.Dark.TextPrimary))
            {
                lbl.ForeColor = p.TextPrimary;
                return;
            }

            if (IsCloseTo(fg, AppTheme.Dark.TextLabel) || IsCloseTo(fg, AppTheme.Light.TextLabel))
            {
                lbl.ForeColor = p.TextLabel;
                return;
            }

            if (IsCloseTo(fg, AppTheme.Dark.TextMuted) || IsCloseTo(fg, AppTheme.Light.TextMuted))
            {
                lbl.ForeColor = p.TextMuted;
                return;
            }

            if (IsCloseTo(fg, AppTheme.Dark.Primary))
            {
                lbl.ForeColor = p.Primary;
                return;
            }

            lbl.ForeColor = p.TextPrimary;
        }

        private static void ApplyPanel(Panel pnl, ThemePalette p)
        {
            Color bg = pnl.BackColor;

            if (bg == Color.Transparent)
                return;

            if (IsCloseTo(bg, AppTheme.Dark.Sidebar) || IsCloseTo(bg, AppTheme.Light.Sidebar))
            {
                pnl.BackColor = p.Sidebar;
                return;
            }

            if (IsCloseTo(bg, AppTheme.Dark.Header) || IsCloseTo(bg, AppTheme.Light.Header))
            {
                pnl.BackColor = p.Header;
                return;
            }

            if (IsCloseTo(bg, AppTheme.Dark.Card) || IsCloseTo(bg, AppTheme.Light.Card))
            {
                pnl.BackColor = p.Card;
                return;
            }

            if (IsCloseTo(bg, AppTheme.Dark.Toolbar) || IsCloseTo(bg, AppTheme.Light.Toolbar))
            {
                pnl.BackColor = p.Toolbar;
                return;
            }

            if (IsCloseTo(bg, AppTheme.Dark.Primary))
                return;

            pnl.BackColor = p.Background;
        }

        private static void ApplyDataGridView(DataGridView dgv, ThemePalette p)
        {
            dgv.BackgroundColor = p.Background;
            dgv.GridColor = p.Border;

            dgv.DefaultCellStyle.BackColor = p.Background;
            dgv.DefaultCellStyle.ForeColor = p.TextPrimary;
            dgv.DefaultCellStyle.SelectionBackColor = p.Primary;
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;

            dgv.AlternatingRowsDefaultCellStyle.BackColor = p.GridAltRow;
            dgv.AlternatingRowsDefaultCellStyle.ForeColor = p.TextPrimary;
            dgv.AlternatingRowsDefaultCellStyle.SelectionBackColor = p.Primary;
            dgv.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.White;

            dgv.ColumnHeadersDefaultCellStyle.BackColor = p.GridHeader;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = p.TextLabel;
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = p.GridHeader;
            dgv.ColumnHeadersDefaultCellStyle.SelectionForeColor = p.TextLabel;
            dgv.EnableHeadersVisualStyles = false;
        }

        private static bool IsCloseTo(Color a, Color b, int tolerance = 15)
        {
            return System.Math.Abs(a.R - b.R) <= tolerance &&
                   System.Math.Abs(a.G - b.G) <= tolerance &&
                   System.Math.Abs(a.B - b.B) <= tolerance;
        }
    }
}