namespace KhuChungCuDatTam.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class thanh_toan
    {
        public int id { get; set; }

        public int hoa_don_id { get; set; }

        public decimal so_tien { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime ngay_thanh_toan { get; set; }

        public int nhan_vien_thu_id { get; set; }

        [Required]
        [StringLength(50)]
        public string ma_phieu_thu { get; set; }

        [Required]
        [StringLength(20)]
        public string phuong_thuc { get; set; }

        public virtual hoa_don hoa_don { get; set; }

        public virtual nguoi_dung nguoi_dung { get; set; }
    }
}
