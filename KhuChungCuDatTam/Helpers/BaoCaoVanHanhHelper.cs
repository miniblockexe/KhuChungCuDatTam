using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KhuChungCuDatTam.Models;

namespace KhuChungCuDatTam.Helpers
{
    public class VanHanhThongKe
    {
        // Bảo trì
        public decimal TongChiPhiBaoTri { get; set; }
        public int SoLanBaoTri { get; set; }
        public string MoTaNhieuNhat { get; set; }   // thay thiet_bi → mo_ta
        // Khiếu nại
        public int TongKhieuNai { get; set; }
        public int DaXuLy { get; set; }
        public int ChuaXuLy { get; set; }
        public string LoaiKNPhoBien { get; set; }   // top mo_ta keyword
        public double TyLeGiaiQuyet { get; set; }
    }

    public static class BaoCaoVanHanhHelper
    {
        // ── Bảo trì ─────────────────────────────────────────────────────────
        public static List<BaoTriVanHanhRow> LayDuLieuBaoTri(int nam, int thang = 0)
        {
            using (var db = new DbChungCu())
            {
                return db.bao_tri
                    .Include("can_ho")
                    .Include("nguoi_dung")
                    .Where(b => b.ngay_yeu_cau.Year == nam &&
                                (thang == 0 || b.ngay_yeu_cau.Month == thang))
                    .ToList()
                    .Select(b => new BaoTriVanHanhRow
                    {
                        CanHo = b.can_ho != null ? b.can_ho.so_can_ho : "—",
                        MoTa = b.mo_ta,
                        NgayYeuCau = b.ngay_yeu_cau,
                        NgayHoanThanh = b.ngay_hoan_thanh,
                        TrangThai = b.trang_thai,
                        ChiPhi = b.chi_phi ?? 0,
                        NhanVien = b.nguoi_dung != null ? b.nguoi_dung.ho_ten : "—",
                        ThangNam = b.ngay_yeu_cau.ToString("MM/yyyy")
                    })
                    .OrderBy(r => r.NgayYeuCau)
                    .ToList();
            }
        }

        // ── Khiếu nại ────────────────────────────────────────────────────────
        // khieu_nai -> cu_dan -> can_ho (cần Include chain)
        public static List<KhieuNaiVanHanhRow> LayDuLieuKhieuNai(int nam, int thang = 0)
        {
            using (var db = new DbChungCu())
            {
                return db.khieu_nai
                    .Include("cu_dan")
                    .Include("cu_dan.can_ho")
                    .Include("nguoi_dung")
                    .Where(k => k.ngay_gui.Year == nam &&
                                (thang == 0 || k.ngay_gui.Month == thang))
                    .ToList()
                    .Select(k => new KhieuNaiVanHanhRow
                    {
                        CanHo = k.cu_dan != null && k.cu_dan.can_ho != null
                                        ? k.cu_dan.can_ho.so_can_ho : "—",
                        CuDan = k.cu_dan != null ? k.cu_dan.ho_ten : "—",
                        MoTa = k.mo_ta,
                        NgayGui = k.ngay_gui,
                        TrangThai = k.trang_thai,
                        PhanHoi = k.phan_hoi ?? "",
                        NhanVien = k.nguoi_dung != null ? k.nguoi_dung.ho_ten : "—",
                        ThangNam = k.ngay_gui.ToString("MM/yyyy")
                    })
                    .OrderBy(r => r.NgayGui)
                    .ToList();
            }
        }

        // ── Thống kê tổng hợp cho stat-cards ────────────────────────────────
        public static VanHanhThongKe LayThongKe(int nam, int thang = 0)
        {
            var bt = LayDuLieuBaoTri(nam, thang);
            var kn = LayDuLieuKhieuNai(nam, thang);

            // Mô tả bảo trì xuất hiện nhiều nhất (cắt 30 ký tự cho gọn)
            string moTaNhieuNhat = bt
                .GroupBy(b => b.MoTa)
                .OrderByDescending(g => g.Count())
                .Select(g => g.Key.Length > 30 ? g.Key.Substring(0, 30) + "…" : g.Key)
                .FirstOrDefault() ?? "—";

            // Khiếu nại phổ biến (lấy từ khóa đầu của mo_ta)
            string loaiKNPhoBien = kn
                .GroupBy(k => k.MoTa.Split(' ')[0])   // từ đầu tiên làm "loại"
                .OrderByDescending(g => g.Count())
                .Select(g => g.Key)
                .FirstOrDefault() ?? "—";

            int daXuLy = kn.Count(k => k.TrangThai == "Đã xử lý");
            int chuaXuLy = kn.Count - daXuLy;

            double tyLeGQ = kn.Count > 0
                ? Math.Round(daXuLy * 100.0 / kn.Count, 1)
                : 0;

            return new VanHanhThongKe
            {
                TongChiPhiBaoTri = bt.Sum(b => b.ChiPhi),
                SoLanBaoTri = bt.Count,
                MoTaNhieuNhat = moTaNhieuNhat,
                TongKhieuNai = kn.Count,
                DaXuLy = daXuLy,
                ChuaXuLy = chuaXuLy,
                LoaiKNPhoBien = loaiKNPhoBien,
                TyLeGiaiQuyet = tyLeGQ
            };
        }
    }
}