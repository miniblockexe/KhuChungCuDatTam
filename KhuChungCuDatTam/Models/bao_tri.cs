namespace KhuChungCuDatTam.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class bao_tri
    {
        public int id { get; set; }

        public int? can_ho_id { get; set; }

        [Required]
        public string mo_ta { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime ngay_yeu_cau { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngay_hoan_thanh { get; set; }

        public decimal? chi_phi { get; set; }

        [Required]
        [StringLength(20)]
        public string trang_thai { get; set; }

        public int? nhan_vien_xu_ly_id { get; set; }

        public virtual can_ho can_ho { get; set; }

        public virtual nguoi_dung nguoi_dung { get; set; }
    }
}
