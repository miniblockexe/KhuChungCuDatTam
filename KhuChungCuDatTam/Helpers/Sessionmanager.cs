using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KhuChungCuDatTam.Models;

namespace KhuChungCuDatTam.Helpers
{
    public static class SessionManager
    {
        public static int NguoiDungId { get; private set; }
        public static string HoTen { get; private set; }
        public static string TenDangNhap { get; private set; }
        public static string Email { get; private set; }
        public static int VaiTroId { get; private set; }
        public static string TenVaiTro { get; private set; }
        public static DateTime ThoiGianDangNhap { get; private set; }

        public static bool IsAdmin => VaiTroId == VaiTroConst.QUAN_TRI;
        public static bool IsQuanLy => VaiTroId == VaiTroConst.QUAN_LY;
        public static bool IsNhanVien => VaiTroId == VaiTroConst.NHAN_VIEN;
        public static bool IsKeToan => VaiTroId == VaiTroConst.KE_TOAN;
        public static bool DaKhoiTao => NguoiDungId > 0;

        public static void BatDauPhien(nguoi_dung nguoiDung)
        {
            if (nguoiDung == null) throw new ArgumentNullException(nameof(nguoiDung));

            NguoiDungId = nguoiDung.id;
            TenDangNhap = nguoiDung.ten_dang_nhap;
            HoTen = nguoiDung.ho_ten ?? nguoiDung.ten_dang_nhap;
            Email = nguoiDung.email;
            VaiTroId = nguoiDung.vai_tro_id;
            TenVaiTro = nguoiDung.vai_tro?.ten_vai_tro ?? "N/A";
            ThoiGianDangNhap = DateTime.Now;
            PermissionHelper.LoadQuyen(nguoiDung.vai_tro_id);
        }

        public static void KetThucPhien()
        {
            NguoiDungId = 0;
            HoTen = null;
            TenDangNhap = null;
            Email = null;
            VaiTroId = 0;
            TenVaiTro = null;
            ThoiGianDangNhap = default;

            PermissionHelper.XoaCache();
        }
    }
}