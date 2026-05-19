using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KhuChungCuDatTam.Helpers;
using Microsoft.Reporting.WinForms;

namespace KhuChungCuDatTam.ReportView
{
    public partial class frmBaoCaoVanHanh : Form
    {
        public frmBaoCaoVanHanh()
        {
            InitializeComponent();
            this.Load += new EventHandler(FrmBaoCaoVanHanh_Load);
        }

        private void FrmBaoCaoVanHanh_Load(object sender, EventArgs e)
        {
            cboNam.Items.Clear();
            for (int y = DateTime.Today.Year; y >= DateTime.Today.Year - 4; y--)
                cboNam.Items.Add(y.ToString());
            cboNam.SelectedIndex = 0;

            cboThang.Items.Clear();
            cboThang.Items.Add("Tất cả");
            for (int m = 1; m <= 12; m++)
                cboThang.Items.Add("Tháng " + m);
            cboThang.SelectedIndex = 0;

            RunReport();
        }

        private void btnXemBaoCao_Click(object sender, EventArgs e) => RunReport();

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            cboThang.SelectedIndex = 0;
            cboNam.SelectedIndex = 0;
            RunReport();
        }

        private void btnXuat_Click(object sender, EventArgs e) => ExportCsv();

        private void RunReport()
        {
            try
            {
                int nam = int.Parse(cboNam.SelectedItem.ToString());
                int thang = cboThang.SelectedIndex;   

                var dataBaoTri = BaoCaoVanHanhHelper.LayDuLieuBaoTri(nam, thang);
                var dataKhieuNai = BaoCaoVanHanhHelper.LayDuLieuKhieuNai(nam, thang);

                UpdateStatCards(nam, thang);

                reportViewer.LocalReport.ReportEmbeddedResource =
                    "KhuChungCuDatTam.Report.BaoCaoVanHanh.rdlc";

                reportViewer.LocalReport.DataSources.Clear();
                reportViewer.LocalReport.DataSources.Add(
                    new ReportDataSource("DataSetBaoTri", dataBaoTri));
                reportViewer.LocalReport.DataSources.Add(
                    new ReportDataSource("DataSetKhieuNai", dataKhieuNai));

                string tenThang = thang == 0 ? "Tất cả" : "Tháng " + thang;
                reportViewer.LocalReport.SetParameters(new[]
                {
                    new ReportParameter("pNam",   nam.ToString()),
                    new ReportParameter("pThang", tenThang)
                });

                reportViewer.RefreshReport();
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                if (ex.InnerException != null)
                    msg += "\n\nInner: " + ex.InnerException.Message;
                if (ex.InnerException?.InnerException != null)
                    msg += "\n\nInner2: " + ex.InnerException.InnerException.Message;

                MessageBox.Show("Lỗi tải báo cáo:\n" + msg, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateStatCards(int nam, int thang)
        {
            var tk = BaoCaoVanHanhHelper.LayThongKe(nam, thang);

            lblCPBaoTriVal.Text = tk.TongChiPhiBaoTri.ToString("N0") + " đ";
            lblSoLanBTVal.Text = tk.SoLanBaoTri.ToString();
            lblMoTaNhieuNhatVal.Text = tk.MoTaNhieuNhat;

            lblTongKNVal.Text = tk.TongKhieuNai.ToString();
            lblDaXuLyVal.Text = tk.DaXuLy.ToString();
            lblChuaXuLyVal.Text = tk.ChuaXuLy.ToString();
            lblLoaiKNVal.Text = tk.LoaiKNPhoBien;
            lblTyLeVal.Text = tk.TyLeGiaiQuyet.ToString("F1") + " %";
        }

        private void ExportCsv()
        {
            int nam = int.Parse(cboNam.SelectedItem.ToString());
            int thang = cboThang.SelectedIndex;

            var bt = BaoCaoVanHanhHelper.LayDuLieuBaoTri(nam, thang);
            var kn = BaoCaoVanHanhHelper.LayDuLieuKhieuNai(nam, thang);

            if (bt.Count == 0 && kn.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var sfd = new SaveFileDialog())
            {
                sfd.Title = "Xuất báo cáo vận hành";
                sfd.Filter = "CSV Files (*.csv)|*.csv";
                sfd.FileName = $"BaoCaoVanHanh_{nam}_{thang:D2}.csv";
                sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                if (sfd.ShowDialog() != DialogResult.OK) return;

                try
                {
                    using (var sw = new System.IO.StreamWriter(
                        sfd.FileName, false, System.Text.Encoding.UTF8))
                    {
                        sw.Write('\uFEFF');

                        sw.WriteLine("=== BẢO TRÌ ===");
                        sw.WriteLine("Tháng/Năm,Căn Hộ,Mô Tả,Ngày Yêu Cầu,Ngày Hoàn Thành,Trạng Thái,Chi Phí (đ),Nhân Viên");
                        foreach (var r in bt)
                            sw.WriteLine($"{r.ThangNam},{r.CanHo},{r.MoTa}," +
                                         $"{r.NgayYeuCau:dd/MM/yyyy}," +
                                         $"{(r.NgayHoanThanh.HasValue ? r.NgayHoanThanh.Value.ToString("dd/MM/yyyy") : "")}," +
                                         $"{r.TrangThai},{r.ChiPhi},{r.NhanVien}");

                        sw.WriteLine();

                        sw.WriteLine("=== KHIẾU NẠI ===");
                        sw.WriteLine("Tháng/Năm,Căn Hộ,Cư Dân,Mô Tả,Ngày Gửi,Trạng Thái,Phản Hồi,Nhân Viên");
                        foreach (var r in kn)
                            sw.WriteLine($"{r.ThangNam},{r.CanHo},{r.CuDan},{r.MoTa}," +
                                         $"{r.NgayGui:dd/MM/yyyy},{r.TrangThai},{r.PhanHoi},{r.NhanVien}");
                    }

                    MessageBox.Show($"Xuất thành công!\n{sfd.FileName}", "Thành công",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xuất file: " + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
