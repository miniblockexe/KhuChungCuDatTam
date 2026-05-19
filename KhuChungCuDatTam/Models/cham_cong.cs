namespace KhuChungCuDatTam.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class cham_cong
    {
        public int id { get; set; }

        public int nguoi_dung_id { get; set; }

        [Column(TypeName = "date")]
        public DateTime ngay { get; set; }

        public TimeSpan? gio_vao { get; set; }

        public TimeSpan? gio_ra { get; set; }

        [Required]
        [StringLength(20)]
        public string trang_thai { get; set; }

        public virtual nguoi_dung nguoi_dung { get; set; }
    }
}
