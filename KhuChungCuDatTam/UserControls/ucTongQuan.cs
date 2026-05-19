using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using KhuChungCuDatTam.Models;

namespace KhuChungCuDatTam.UserControls
{
    public partial class ucTongQuan : UserControl
    {
        private static readonly Color CLR_BG = Color.FromArgb(15, 23, 42);
        private static readonly Color CLR_CARD = Color.FromArgb(30, 41, 59);
        private static readonly Color CLR_BORDER = Color.FromArgb(51, 65, 85);
        private static readonly Color CLR_MUTED = Color.FromArgb(100, 116, 139);
        private static readonly Color CLR_TEXT = Color.FromArgb(203, 213, 225);
        private static readonly Color CLR_PRIMARY = Color.FromArgb(59, 130, 246);

        private List<(string Label, decimal Value)> _chartData =
            new List<(string, decimal)>();

        public ucTongQuan()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint, true);
        }

        private void ucTongQuan_Load(object sender, EventArgs e)
        {
            pnlChartHost.Paint += pnlChartHost_Paint;

            ApplyRoundedCards();
            ApplyCardLayout();

            lblDate.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            timerClock_Tick(null, EventArgs.Empty);

            this.BeginInvoke(new Action(() =>
            {
                RefreshAll();
                timerClock.Start();
                timerRefresh.Start();
            }));
        }
        private void ucTongQuan_Resize(object sender, EventArgs e)
        {
            ApplyCardLayout();
            pnlChartHost.Invalidate();
        }

        private void timerClock_Tick(object sender, EventArgs e)
            => lblClock.Text = DateTime.Now.ToString("HH:mm:ss");

        private void timerRefresh_Tick(object sender, EventArgs e)
            => RefreshAll();

        private void RefreshAll()
        {
            LoadStatistics();
            LoadChart();
            LoadBills();
            LoadNotifications();
        }

        public void LoadStatistics()
        {
            try
            {
                using (var db = new DbChungCu())
                {
                    cardCuDan_Value.Text = db.cu_dan.Count().ToString();

                    cardCanHo_Value.Text = db.can_ho.Count().ToString();

                    int thang = DateTime.Now.Month;
                    int nam = DateTime.Now.Year;

                    var payments = db.thanh_toan.ToList();
                    decimal doanhThu = db.hoa_don
    .Where(h => h.thang_nam.Month == thang && h.thang_nam.Year == nam)
    .Sum(h => (decimal?)h.tong_tien) ?? 0m;

                    cardDoanhThu_Value.Text = FormatMoney(doanhThu);

                    cardHoaDon_Value.Text = db.hoa_don
                        .Count(h => h.trang_thai == "chua_thanh_toan")
                        .ToString();

                    cardKhieuNai_Value.Text = db.khieu_nai.Count().ToString();

                    cardPhuongTien_Value.Text = db.phuong_tien.Count().ToString();
                }
            }
            catch (Exception ex)
            {
                SetAllCardsError();
                ShowError("LoadStatistics", ex);
            }
        }

        public void LoadChart()
        {
            try
            {
                _chartData.Clear();

                using (var db = new DbChungCu())
                {
                    var months = Enumerable.Range(0, 6)
                        .Select(i => DateTime.Now.AddMonths(-5 + i))
                        .ToList();

                    var payments = db.thanh_toan.ToList();

                    _chartData = months.Select(m => (
                        Label: m.ToString("MM/yyyy"),
                        Value: payments
                            .Where(t => t.ngay_thanh_toan.Month == m.Month
                                     && t.ngay_thanh_toan.Year == m.Year)
                            .Sum(t => (decimal?)t.so_tien) ?? 0m
                    )).ToList();
                }
            }
            catch (Exception ex)
            {
                ShowError("LoadChart", ex);
            }
            finally
            {
                pnlChartHost.Invalidate();
            }
        }

        public void LoadBills()
        {
            try
            {
                using (var db = new DbChungCu())
                {
                    var bills = (from h in db.hoa_don
                                 join ch in db.can_ho on h.can_ho_id equals ch.id
                                 orderby h.ngay_tao descending
                                 select new
                                 {
                                     SoCanHo = ch.so_can_ho,
                                     ThangNam = h.thang_nam,
                                     TongTien = h.tong_tien,
                                     TrangThai = h.trang_thai
                                 })
                                .Take(8)
                                .ToList();

                    dgvHoaDon.Rows.Clear();
                    foreach (var b in bills)
                    {
                        int idx = dgvHoaDon.Rows.Add(
                            b.SoCanHo,
                            b.ThangNam.ToString("MM/yyyy"),
                            FormatMoney(b.TongTien),
                            MapTrangThaiHoaDon(b.TrangThai)
                        );
                        ColorBillRow(dgvHoaDon.Rows[idx], b.TrangThai);
                    }
                }
            }
            catch (Exception ex)
            {
                ShowError("LoadBills", ex);
            }
        }

        public void LoadNotifications()
        {
            try
            {
                pnlNotifyList.Controls.Clear();

                using (var db = new DbChungCu())
                {
                    var items = db.thong_bao
                        .Where(t => t.gui_tat_ca == true)  
                        .OrderByDescending(t => t.ngay_gui)
                        .Take(5)
                        .Select(t => new
                        {
                            t.tieu_de,
                            t.noi_dung,
                            t.ngay_gui
                        })
                        .ToList();

                    int yPos = 0;
                    foreach (var item in items)
                    {
                        var ctrl = BuildNotifyItem(item.tieu_de, item.noi_dung, item.ngay_gui, yPos);
                        pnlNotifyList.Controls.Add(ctrl);
                        yPos += ctrl.Height + 6;
                    }

                    if (pnlNotifyList.Controls.Count == 0)
                        pnlNotifyList.Controls.Add(BuildEmptyNotify());
                }
            }
            catch (Exception ex)
            {
                ShowError("LoadNotifications", ex);
            }
        }

        private void pnlChartHost_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            var w = pnlChartHost.Width;
            var h = pnlChartHost.Height;

            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(CLR_CARD);

            if (_chartData == null || _chartData.Count == 0)
            {
                DrawCenteredText(g, "Không có dữ liệu", w, h);
                return;
            }

            const int padL = 60, padR = 50, padT = 24, padB = 50;
            int chartW = w - padL - padR;
            int chartH = h - padT - padB;

            if (chartW <= 0 || chartH <= 0) return;

            decimal maxVal = _chartData.Max(d => d.Value);
            if (maxVal == 0) maxVal = 1;

            using (var gridPen = new Pen(Color.FromArgb(40, 255, 255, 255), 1))
            {
                for (int i = 0; i <= 4; i++)
                {
                    float gy = padT + chartH - (chartH * i / 4f);
                    g.DrawLine(gridPen, padL, gy, padL + chartW, gy);

                    decimal val = maxVal * i / 4;
                    using (var f = new Font("Segoe UI", 7.5F))
                        g.DrawString(FormatMoneyShort(val), f,
                            new SolidBrush(CLR_MUTED),
                            new RectangleF(0, gy - 8, padL - 4, 16),
                            new StringFormat
                            {
                                Alignment = StringAlignment.Far,
                                LineAlignment = StringAlignment.Center
                            });
                }
            }

            using (var axisPen = new Pen(CLR_BORDER, 1))
            {
                g.DrawLine(axisPen, padL, padT, padL, padT + chartH);
                g.DrawLine(axisPen, padL, padT + chartH, padL + chartW, padT + chartH);
            }

            int count = _chartData.Count;
            float slot = chartW / (float)count;      
            float barW = slot * 0.5f;                 

            for (int i = 0; i < count; i++)
            {
                var (label, value) = _chartData[i];

                float centerX = padL + slot * i + slot / 2f; 
                float bx = centerX - barW / 2f;          
                float barH = chartH * (float)(value / maxVal);
                float by = padT + chartH - barH;

                if (barH > 0)
                {
                    var barRect = new RectangleF(bx, by, barW, barH);
                    using (var brush = new LinearGradientBrush(barRect,
                        Color.FromArgb(59, 130, 246),
                        Color.FromArgb(37, 99, 235),
                        LinearGradientMode.Vertical))
                    {
                        g.FillRectangle(brush, barRect);
                    }

                    using (var f = new Font("Segoe UI", 7.5F, FontStyle.Bold))
                        g.DrawString(FormatMoneyShort(value), f,
                            new SolidBrush(Color.FromArgb(147, 197, 253)),
                            new RectangleF(centerX - 30, by - 18, 60, 16),
                            new StringFormat { Alignment = StringAlignment.Center });
                }

                using (var f = new Font("Segoe UI", 8F))
                    g.DrawString(label, f, new SolidBrush(CLR_MUTED),
                        new RectangleF(centerX - 30, padT + chartH + 6, 60, 20),
                        new StringFormat { Alignment = StringAlignment.Center });
            }
        }

        private void ApplyCardLayout()
        {
            var cards = new[]
            {
                cardCuDan, cardCanHo, cardDoanhThu,
                cardHoaDon, cardKhieuNai, cardPhuongTien
            };

            int available = pnlCards.Width;
            int count = cards.Length;
            if (available <= 0 || count == 0) return;

            const int gap = 10;
            int totalGap = gap * (count - 1);
            int cardW = Math.Max(140, (available - totalGap) / count);
            int cardH = pnlCards.Height - 16;
            int x = 0;

            foreach (var card in cards)
            {
                card.Size = new Size(cardW, cardH);
                card.Location = new Point(x, 8);
                x += cardW + gap;
            }
        }

        private void ApplyRoundedCards()
        {
            var cards = new[]
            {
                cardCuDan, cardCanHo, cardDoanhThu,
                cardHoaDon, cardKhieuNai, cardPhuongTien,
                pnlChartCard, pnlBillCard, pnlNotifyCard
            };

            foreach (var c in cards)
            {
                c.Paint += (s, pe) =>
                {
                    var panel = (Panel)s;
                    using (var path = RoundedPath(panel.ClientRectangle, 10))
                        panel.Region = new Region(path);
                };
            }
        }

        private static GraphicsPath RoundedPath(Rectangle rect, int radius)
        {
            int d = radius * 2;
            var path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }

        private Panel BuildNotifyItem(string tieuDe, string noiDung, DateTime ngay, int yPos)
        {
            var pnl = new Panel
            {
                Location = new Point(0, yPos),
                Size = new Size(pnlNotifyList.Width - 4, 68),
                BackColor = Color.FromArgb(15, 23, 42),
                Padding = new Padding(10, 6, 10, 6),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
            };

            var accent = new Panel
            {
                Location = new Point(0, 0),
                Size = new Size(3, 68),
                BackColor = CLR_PRIMARY,
            };

            var lblTitle = new Label
            {
                Text = tieuDe,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(14, 8),
                Size = new Size(pnl.Width - 20, 18),
                AutoEllipsis = true,
                BackColor = Color.Transparent,
            };

            string preview = noiDung?.Length > 60 ? noiDung.Substring(0, 60) + "…" : noiDung;
            var lblBody = new Label
            {
                Text = preview,
                Font = new Font("Segoe UI", 8F),
                ForeColor = CLR_TEXT,
                Location = new Point(14, 28),
                Size = new Size(pnl.Width - 20, 16),
                AutoEllipsis = true,
                BackColor = Color.Transparent,
            };

            var lblTime = new Label
            {
                Text = ngay.ToString("dd/MM/yyyy HH:mm"),
                Font = new Font("Segoe UI", 7.5F),
                ForeColor = CLR_MUTED,
                Location = new Point(14, 46),
                AutoSize = true,
                BackColor = Color.Transparent,
            };

            pnl.Controls.Add(accent);
            pnl.Controls.Add(lblTitle);
            pnl.Controls.Add(lblBody);
            pnl.Controls.Add(lblTime);
            return pnl;
        }

        private Panel BuildEmptyNotify() =>
            new Panel
            {
                Location = new Point(0, 0),
                Size = new Size(pnlNotifyList.Width - 4, 50),
                BackColor = Color.Transparent,
                Controls =
                {
                    new Label
                    {
                        Text      = "Không có thông báo mới",
                        Font      = new Font("Segoe UI", 9F),
                        ForeColor = CLR_MUTED,
                        Dock      = DockStyle.Fill,
                        TextAlign = ContentAlignment.MiddleCenter,
                        BackColor = Color.Transparent,
                    }
                }
            };

        private static string FormatMoney(decimal value)
        {
            if (value >= 1_000_000_000) return $"{value / 1_000_000_000:N1} tỷ";
            if (value >= 1_000_000) return $"{value / 1_000_000:N1} tr";
            return $"{value:N0} đ";
        }

        private static string FormatMoneyShort(decimal value)
        {
            if (value >= 1_000_000_000) return $"{value / 1_000_000_000:N1}B";
            if (value >= 1_000_000) return $"{value / 1_000_000:N0}M";
            if (value >= 1_000) return $"{value / 1_000:N0}K";
            return $"{value:N0}";
        }

        private static string MapTrangThaiHoaDon(string raw)
        {
            switch (raw?.ToLower())
            {
                case "da_thanh_toan": return "✅ Đã TT";
                case "chua_thanh_toan": return "⏳ Chưa TT";
                case "qua_han": return "🔴 Quá Hạn";
                default: return raw;
            }
        }

        private void ColorBillRow(DataGridViewRow row, string trangThai)
        {
            Color fg;
            switch (trangThai?.ToLower())
            {
                case "da_thanh_toan": fg = Color.FromArgb(34, 197, 94); break;
                case "qua_han": fg = Color.FromArgb(239, 68, 68); break;
                default: fg = Color.FromArgb(245, 158, 11); break;
            }
            if (row.Cells["colHD_TrangThai"] != null)
                row.Cells["colHD_TrangThai"].Style.ForeColor = fg;
        }

        private void SetAllCardsError()
        {
            const string err = "Err";
            cardCuDan_Value.Text = err;
            cardCanHo_Value.Text = err;
            cardDoanhThu_Value.Text = err;
            cardHoaDon_Value.Text = err;
            cardKhieuNai_Value.Text = err;
            cardPhuongTien_Value.Text = err;
        }

        private static void DrawCenteredText(Graphics g, string text, int w, int h)
        {
            using (var f = new Font("Segoe UI", 10F))
            using (var sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            })
                g.DrawString(text, f,
                    new SolidBrush(Color.FromArgb(100, 116, 139)),
                    new RectangleF(0, 0, w, h), sf);
        }

        private static void ShowError(string context, Exception ex)
            => System.Diagnostics.Debug.WriteLine($"[ucTongQuan.{context}] {ex.Message}");
    }
}