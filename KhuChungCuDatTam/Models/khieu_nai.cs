namespace KhuChungCuDatTam.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class khieu_nai
    {
        public int id { get; set; }

        public int cu_dan_id { get; set; }

        [Required]
        public string mo_ta { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime ngay_gui { get; set; }

        [Required]
        [StringLength(20)]
        public string trang_thai { get; set; }

        public string phan_hoi { get; set; }

        public int? nhan_vien_xu_ly_id { get; set; }

        public virtual cu_dan cu_dan { get; set; }

        public virtual nguoi_dung nguoi_dung { get; set; }
    }
}
