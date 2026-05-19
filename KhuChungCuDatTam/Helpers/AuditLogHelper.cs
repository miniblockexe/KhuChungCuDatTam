using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KhuChungCuDatTam.Models;

namespace KhuChungCuDatTam.Helpers
{
    public static class AuditLogHelper
    {
        public static int CurrentUserId { get; set; } = 0;

        public static void GhiLog(string hanhDong, string bang, int? banGhiId, string moTa)
        {
            try
            {
                using (var db = new DbChungCu())
                {
                    db.audit_log.Add(new audit_log
                    {
                        nguoi_dung_id = CurrentUserId,
                        hanh_dong = hanhDong,
                        bang = bang,
                        ban_ghi_id = banGhiId,
                        mo_ta = moTa,
                        thoi_gian = DateTime.Now
                    });
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            { 
                System.Diagnostics.Debug.WriteLine($"[AuditLog] Lỗi ghi log: {ex}");
            }
        }
    }
}