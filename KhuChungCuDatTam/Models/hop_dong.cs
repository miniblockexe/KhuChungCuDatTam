namespace KhuChungCuDatTam.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class hop_dong
    {
        public int id { get; set; }

        public int can_ho_id { get; set; }

        public int cu_dan_id { get; set; }

        [Required]
        [StringLength(20)]
        public string loai_hop_dong { get; set; }

        [Column(TypeName = "date")]
        public DateTime ngay_bat_dau { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngay_ket_thuc { get; set; }

        public decimal? gia_tri_hop_dong { get; set; }

        public decimal tien_dat_coc { get; set; }

        [Required]
        [StringLength(20)]
        public string trang_thai { get; set; }

        [StringLength(255)]
        public string file_hop_dong { get; set; }

        public virtual can_ho can_ho { get; set; }

        public virtual cu_dan cu_dan { get; set; }
    }
}
