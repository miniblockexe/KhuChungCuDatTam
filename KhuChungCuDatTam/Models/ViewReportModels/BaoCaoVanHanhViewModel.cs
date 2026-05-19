using System;

namespace KhuChungCuDatTam.Models
{
    public class BaoTriVanHanhRow
    {
        public string CanHo { get; set; }  
        public string MoTa { get; set; }   
        public DateTime NgayYeuCau { get; set; }
        public DateTime? NgayHoanThanh { get; set; }
        public string TrangThai { get; set; }
        public decimal ChiPhi { get; set; }
        public string NhanVien { get; set; } 
        public string ThangNam { get; set; }  
    }

    public class KhieuNaiVanHanhRow
    {
        public string CanHo { get; set; }  
        public string CuDan { get; set; }   
        public string MoTa { get; set; }
        public DateTime NgayGui { get; set; }
        public string TrangThai { get; set; }
        public string PhanHoi { get; set; }
        public string NhanVien { get; set; }
        public string ThangNam { get; set; }
    }
}