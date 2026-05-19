using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using KhuChungCuDatTam.Models;
using KhuChungCuDatTam.Helpers;

namespace KhuChungCuDatTam.Forms
{
    public partial class frmBaoCaoCongNo : Form
    {
        public frmBaoCaoCongNo()
        {
            InitializeComponent();
            this.Load += new EventHandler(FrmBaoCaoCongNo_Load);
        }

        private void FrmBaoCaoCongNo_Load(object sender, EventArgs e)
        {
            cboNam.Items.Clear();
            for (int y = DateTime.Today.Year; y >= DateTime.Today.Year - 4; y--)
                cboNam.Items.Add(y.ToString());
            cboNam.SelectedIndex = 0;

            cboThang.Items.Clear();
            cboThang.Items.Add("Tất cả");
            for (int m = 1; m <= 12; m++)
                cboThang.Items.Add("Tháng " + m.ToString());
            cboThang.SelectedIndex = 0;

            RunReport();
        }

        private void btnXemBaoCao_Click(object sender, EventArgs e)
        {
            RunReport();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            cboThang.SelectedIndex = 0;
            cboNam.SelectedIndex = 0;
            RunReport();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            ExportExcel();
        }

        private void RunReport()
        {
            try
            {
                int nam = int.Parse(cboNam.SelectedItem.ToString());
                int thang = cboThang.SelectedIndex;

                List<CongNoViewModel> data = CongNoHelper.LayDuLieu(nam, thang);
                UpdateStatCards(data);

                reportViewer.LocalReport.ReportEmbeddedResource =
                    "KhuChungCuDatTam.Report.BaoCaoCongNo.rdlc";

                reportViewer.LocalReport.DataSources.Clear();
                reportViewer.LocalReport.DataSources.Add(
                    new ReportDataSource("DataSet1", data));

                string tenThang = thang == 0 ? "Tất cả" : "Tháng " + thang.ToString();

                var thongKe = CongNoHelper.LayThongKe(nam, thang);

                ReportParameter[] parameters = new ReportParameter[]
                {
                    new ReportParameter("pNam", nam.ToString()),
                    new ReportParameter("pThang", tenThang),
                    new ReportParameter("pTongNo", thongKe.tongNo.ToString("N0") + " đ"),
                    new ReportParameter("pSoQuaHan", thongKe.soQuaHan.ToString())
                };

                reportViewer.LocalReport.SetParameters(parameters);
                reportViewer.RefreshReport();
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                if (ex.InnerException != null)
                    msg += "\n\nInner: " + ex.InnerException.Message;
                if (ex.InnerException?.InnerException != null)
                    msg += "\n\nInner2: " + ex.InnerException.InnerException.Message;

                MessageBox.Show("Lỗi tải báo cáo công nợ:\n" + msg, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateStatCards(List<CongNoViewModel> data)
        {
            lblTongNoVal.Text =
                data.Sum(r => r.ConNo).ToString("N0") + " đ";

            lblQuaHanVal.Text =
                data.Count(r => r.QuaHan).ToString();

            lblChuaTTVal.Text =
                data.Count(r => r.ConNo > 0).ToString();

            lblCanHoNoVal.Text =
                data.Where(r => r.ConNo > 0)
                    .Select(r => r.SoCanHo)
                    .Distinct()
                    .Count()
                    .ToString();
        }
        private void ExportExcel()
        {
            int nam = int.Parse(cboNam.SelectedItem.ToString());
            int thang = cboThang.SelectedIndex;

            List<CongNoViewModel> data = CongNoHelper.LayDuLieu(nam, thang);

            if (data.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Xuất báo cáo công nợ";
            sfd.Filter = "CSV Files (*.csv)|*.csv";
            sfd.FileName = "BaoCaoCongNo_" + nam.ToString() + "_" + thang.ToString("D2") + ".csv";
            sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (sfd.ShowDialog() != DialogResult.OK)
            {
                sfd.Dispose();
                return;
            }

            try
            {
                using (var sw = new System.IO.StreamWriter(sfd.FileName, false, System.Text.Encoding.UTF8))
                {
                    sw.Write('\uFEFF');
                    sw.WriteLine("Tháng/Năm,Căn Hộ,Tổng HĐ (đ),Đã TT (đ),Còn Nợ (đ),Quá Hạn,Trạng Thái");

                    foreach (CongNoViewModel r in data)
                    {
                        sw.WriteLine(
                            r.ThangNam + "," +
                            r.SoCanHo + "," +
                            r.TongHoaDon.ToString() + "," +
                            r.DaThanhToan.ToString() + "," +
                            r.ConNo.ToString() + "," +
                            (r.QuaHan ? "Có" : "Không") + "," +
                            r.TrangThai);
                    }
                }

                MessageBox.Show(
                    "Xuất thành công " + data.Count.ToString() + " bản ghi!\n" + sfd.FileName,
                    "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xuất file: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sfd.Dispose();
            }
        }
    }
}