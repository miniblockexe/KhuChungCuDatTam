using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using KhuChungCuDatTam.Models;
using KhuChungCuDatTam.Helpers;
using KhuChungCuDatTam.Data; // Để dùng HashHelper

namespace KhuChungCuDatTam.Repositories
{
    public class NguoiDungRepository
    {
        // ══════════════════════════════════════════════════════
        //  XÁC THỰC
        // ══════════════════════════════════════════════════════

        public nguoi_dung DangNhap(string tenDangNhap, string matKhauRaw)
        {
            string matKhauHash = HashHelper.SHA256Hash(matKhauRaw);

            using (var db = new DbChungCu())
            {
                // Dùng Include để lấy luôn thông tin vai_tro (thay cho JOIN)
                return db.nguoi_dung
                    .Include(nd => nd.vai_tro)
                    .FirstOrDefault(nd => nd.ten_dang_nhap == tenDangNhap
                                      && nd.mat_khau == matKhauHash
                                      && nd.trang_thai == "active");
            }
        }

        // ══════════════════════════════════════════════════════
        //  KIỂM TRA TỒN TẠI
        // ══════════════════════════════════════════════════════

        public bool TonTaiTenDangNhap(string tenDangNhap)
        {
            using (var db = new DbChungCu())
            {
                return db.nguoi_dung.Any(nd => nd.ten_dang_nhap == tenDangNhap);
            }
        }

        public bool TonTaiEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;
            using (var db = new DbChungCu())
            {
                return db.nguoi_dung.Any(nd => nd.email == email);
            }
        }

        // ══════════════════════════════════════════════════════
        //  THÊM / XÓA / SỬA
        // ══════════════════════════════════════════════════════

        public int DangKy(nguoi_dung nd)
        {
            try
            {
                using (var db = new DbChungCu())
                {
                    var entity = new nguoi_dung
                    {
                        ten_dang_nhap = nd.ten_dang_nhap,
                        mat_khau = HashHelper.SHA256Hash(nd.mat_khau),
                        ho_ten = nd.ho_ten,
                        email = nd.email,
                        so_dien_thoai = nd.so_dien_thoai,
                        vai_tro_id = nd.vai_tro_id,
                        trang_thai = "active",
                        ngay_tao = DateTime.Now
                    };

                    db.nguoi_dung.Add(entity);
                    db.SaveChanges();
                    return entity.id;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"[DangKy] Lỗi: {ex.Message}");
                return -1;
            }
        }

        public List<nguoi_dung> LayTatCa()
        {
            using (var db = new DbChungCu())
            {
                return db.nguoi_dung
                    .Include(nd => nd.vai_tro)
                    .OrderByDescending(nd => nd.id)
                    .ToList();
            }
        }

        public nguoi_dung LayTheoId(int id)
        {
            using (var db = new DbChungCu())
            {
                return db.nguoi_dung
                    .Include(nd => nd.vai_tro)
                    .FirstOrDefault(nd => nd.id == id);
            }
        }

        public bool CapNhat(nguoi_dung nd)
        {
            using (var db = new DbChungCu())
            {
                var existing = db.nguoi_dung.Find(nd.id);
                if (existing == null) return false;

                existing.ho_ten = nd.ho_ten;
                existing.email = nd.email;
                existing.so_dien_thoai = nd.so_dien_thoai;
                existing.vai_tro_id = nd.vai_tro_id;

                return db.SaveChanges() > 0;
            }
        }

        public bool DoiMatKhau(int id, string matKhauCuRaw, string matKhauMoiRaw)
        {
            string hashCu = HashHelper.SHA256Hash(matKhauCuRaw);
            string hashMoi = HashHelper.SHA256Hash(matKhauMoiRaw);

            using (var db = new DbChungCu())
            {
                var nd = db.nguoi_dung.FirstOrDefault(x => x.id == id && x.mat_khau == hashCu);
                if (nd == null) return false;

                nd.mat_khau = hashMoi;
                return db.SaveChanges() > 0;
            }
        }

        public bool DatLaiMatKhau(int id, string matKhauMoiRaw)
        {
            using (var db = new DbChungCu())
            {
                var nd = db.nguoi_dung.Find(id);
                if (nd == null) return false;

                nd.mat_khau = HashHelper.SHA256Hash(matKhauMoiRaw);
                return db.SaveChanges() > 0;
            }
        }

        public bool DoiTrangThai(int id, string trangThai)
        {
            using (var db = new DbChungCu())
            {
                var nd = db.nguoi_dung.Find(id);
                if (nd == null) return false;

                nd.trang_thai = trangThai;
                return db.SaveChanges() > 0;
            }
        }
    }
}