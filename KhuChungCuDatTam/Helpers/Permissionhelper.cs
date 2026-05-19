using System;
using System.Collections.Generic;
using System.Linq;
using KhuChungCuDatTam.Models;

namespace KhuChungCuDatTam.Helpers
{
    public static class PermissionHelper
    {
        private static HashSet<string> _quyenCache = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        public static void LoadQuyen(int vaiTroId)
        {
            _quyenCache.Clear();
            try
            {
                using (var db = new DbChungCu())
                {
                    var vaiTro = db.vai_tro
                        .Include("quyens") 
                        .FirstOrDefault(vt => vt.id == vaiTroId);

                    if (vaiTro != null)
                        foreach (var q in vaiTro.quyens)
                            if (!string.IsNullOrEmpty(q.ten_quyen))
                                _quyenCache.Add(q.ten_quyen);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"[LoadQuyen] Lỗi: {ex.Message}");
            }
        }

        public static bool CoQuyen(string tenQuyen)
        {
            if (string.IsNullOrEmpty(tenQuyen)) return false;
            return _quyenCache.Contains(tenQuyen);
        }

        public static bool CoTatCaQuyen(params string[] tenQuyens)
        {
            foreach (var q in tenQuyens)
                if (!CoQuyen(q)) return false;
            return true;
        }

        public static bool CoItNhatMotQuyen(params string[] tenQuyens)
        {
            foreach (var q in tenQuyens)
                if (CoQuyen(q)) return true;
            return false;
        }

        public static IReadOnlyCollection<string> LayTatCaQuyen() => _quyenCache;

        public static void XoaCache() => _quyenCache.Clear();
        public static bool CoQuanLyCuDan => CoQuyen("quan_ly_cu_dan");
        public static bool CoQuanLyCanHo => CoQuyen("quan_ly_can_ho");
        public static bool CoQuanLyHoaDon => CoQuyen("quan_ly_hoa_don");
        public static bool CoQuanLyThanhToan => CoQuyen("quan_ly_thanh_toan");
        public static bool CoQuanLyBaoTri => CoQuyen("quan_ly_bao_tri");
        public static bool CoQuanLyNhanVien => CoQuyen("quan_ly_nhan_vien");
        public static bool CoXemBaoCao => CoQuyen("xem_bao_cao");
        public static bool CoQuanLyChamCong => CoQuyen("quan_ly_cham_cong");
        public static bool CoQuanLyBangLuong => CoQuyen("quan_ly_bang_luong");
        public static bool CoQuanLyDichVu => CoQuyen("quan_ly_dich_vu");
        public static bool CoGuiThongBao => CoQuyen("gui_thong_bao");
        public static bool CoQuanLyPhuongTien => CoQuyen("quan_ly_phuong_tien");
    }
}