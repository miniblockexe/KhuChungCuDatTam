using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KhuChungCuDatTam.Models;

namespace KhuChungCuDatTam.Helpers
{
    public static class BaoCaoHelper
    {
        public static List<BaoCaoViewModel> LayDuLieu(int nam, int thang = 0)
        {
            using (var db = new DbChungCu())
            {
                var hoaDons = db.hoa_don
                    .Include("can_ho")
                    .Include("thanh_toan")
                    .Where(h => h.thang_nam.Year == nam &&
                                (thang == 0 || h.thang_nam.Month == thang))
                    .ToList();

                var baoTriList = db.bao_tri
                    .Where(b => b.ngay_yeu_cau.Year == nam &&
                                (thang == 0 || b.ngay_yeu_cau.Month == thang))
                    .ToList();

                var result = new List<BaoCaoViewModel>();

                foreach (var hd in hoaDons)
                {
                    decimal daTT = hd.thanh_toan != null
                        ? hd.thanh_toan.Sum(t => t.so_tien)
                        : 0;

                    decimal cpBaoTri = baoTriList
                        .Where(b => b.can_ho_id == hd.can_ho_id &&
                                    b.ngay_yeu_cau.Month == hd.thang_nam.Month)
                        .Sum(b => b.chi_phi ?? 0);

                    string trangThai = daTT >= hd.tong_tien ? "✔ Đã TT"
                                     : daTT > 0 ? "⚡ TT một phần"
                                     : "✘ Chưa TT";

                    result.Add(new BaoCaoViewModel
                    {
                        ThangNam = hd.thang_nam.ToString("MM/yyyy"),
                        SoCanHo = hd.can_ho?.so_can_ho ?? "—",
                        TongHoaDon = hd.tong_tien,
                        DaThanhToan = daTT,
                        ConNo = hd.tong_tien - daTT,
                        ChiPhiBaoTri = cpBaoTri,
                        TrangThai = trangThai
                    });
                }

                return result.OrderBy(r => r.ThangNam)
                             .ThenBy(r => r.SoCanHo)
                             .ToList();
            }
        }

        public static (decimal doanhThu, decimal congNo, decimal cpBaoTri)
            LayThongKe(int nam, int thang = 0)
        {
            var data = LayDuLieu(nam, thang);
            return (
                data.Sum(r => r.DaThanhToan),
                data.Sum(r => r.ConNo),
                data.Sum(r => r.ChiPhiBaoTri)
            );
        }
    }
}
