namespace KhuChungCuDatTam.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class audit_log
    {
        public int id { get; set; }

        public int nguoi_dung_id { get; set; }

        [Required]
        [StringLength(50)]
        public string hanh_dong { get; set; }

        [Required]
        [StringLength(50)]
        public string bang { get; set; }

        public int? ban_ghi_id { get; set; }

        public string mo_ta { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime thoi_gian { get; set; }

        public virtual nguoi_dung nguoi_dung { get; set; }
    }
}
