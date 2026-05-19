using System;
using System.Collections.Generic;
using System.Linq;
using KhuChungCuDatTam.Models;

namespace KhuChungCuDatTam.Repositories
{
    public class VaiTroRepository
    {
        /// <summary>Lấy tất cả vai trò</summary>
        public List<vai_tro> LayTatCa()
        {
            using (var db = new DbChungCu())
            {
                return db.vai_tro
                    .OrderBy(vt => vt.id)
                    .ToList();
            }
        }

        /// <summary>Lấy vai trò không phải Admin (dùng cho form đăng ký tự do)</summary>
        public List<vai_tro> LayVaiTroCongKhai()
        {
            using (var db = new DbChungCu())
            {
                return db.vai_tro
                    .Where(vt => vt.ten_vai_tro != "Admin")
                    .OrderBy(vt => vt.id)
                    .ToList();
            }
        }

        /// <summary>Lấy vai trò theo ID</summary>
        public vai_tro LayTheoId(int id)
        {
            using (var db = new DbChungCu())
            {
                // Find là cách nhanh nhất để tìm theo Khóa chính (Primary Key)
                return db.vai_tro.Find(id);
            }
        }
    }
}