namespace KhuChungCuDatTam.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tam_tru
    {
        public int id { get; set; }

        public int? cu_dan_id { get; set; }

        [Required]
        [StringLength(100)]
        public string ho_ten { get; set; }

        [StringLength(20)]
        public string cmnd_cccd { get; set; }

        [Column(TypeName = "date")]
        public DateTime ngay_bat_dau { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngay_ket_thuc { get; set; }

        [Required]
        [StringLength(20)]
        public string trang_thai { get; set; }

        public virtual cu_dan cu_dan { get; set; }
    }
}
