using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using KhuChungCuDatTam.Models;

namespace KhuChungCuDatTam.Helpers
{
    public static class CongNoHelper
    {
        public static List<CongNoViewModel> LayDuLieu(int nam, int thang = 0)
        {
            using (var db = new DbChungCu())
            {
                var hoaDons = db.hoa_don
                    .Include("can_ho")
                    .Include("thanh_toan")
                    .Where(h => h.thang_nam.Year == nam &&
                                (thang == 0 || h.thang_nam.Month == thang))
                    .ToList();

                DateTime homNay = DateTime.Today;

                var result = new List<CongNoViewModel>();

                foreach (var hd in hoaDons)
                {
                    decimal daTT = hd.thanh_toan != null
                        ? hd.thanh_toan.Sum(t => t.so_tien)
                        : 0;

                    decimal conNo = hd.tong_tien - daTT;
                    if (conNo < 0) conNo = 0;

                    bool quaHan = conNo > 0 &&
                                  (hd.thang_nam.Year < homNay.Year ||
                                  (hd.thang_nam.Year == homNay.Year && hd.thang_nam.Month < homNay.Month));

                    string trangThai = conNo <= 0 ? "✔ Đã thanh toán"
                                     : quaHan ? "⚠ Quá hạn"
                                     : "⏳ Chưa thanh toán";

                    result.Add(new CongNoViewModel
                    {
                        ThangNam = hd.thang_nam.ToString("MM/yyyy"),
                        SoCanHo = hd.can_ho?.so_can_ho ?? "—",
                        TongHoaDon = hd.tong_tien,
                        DaThanhToan = daTT,
                        ConNo = conNo,
                        QuaHan = quaHan,
                        TrangThai = trangThai
                    });
                }

                return result
                    .OrderByDescending(r => r.QuaHan)
                    .ThenByDescending(r => r.ConNo)
                    .ThenBy(r => r.SoCanHo)
                    .ToList();
            }
        }

        public static (decimal tongNo, decimal daThu, int soHoaDonNo, int soQuaHan)
            LayThongKe(int nam, int thang = 0)
        {
            var data = LayDuLieu(nam, thang);

            return (
                data.Sum(r => r.ConNo),
                data.Sum(r => r.DaThanhToan),
                data.Count(r => r.ConNo > 0),
                data.Count(r => r.QuaHan)
            );
        }
    }
}