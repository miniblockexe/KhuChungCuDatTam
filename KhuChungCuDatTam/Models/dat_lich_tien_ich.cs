namespace KhuChungCuDatTam.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class dat_lich_tien_ich
    {
        public int id { get; set; }

        public int tien_ich_id { get; set; }

        public int cu_dan_id { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime thoi_gian_bat_dau { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime thoi_gian_ket_thuc { get; set; }

        [Required]
        [StringLength(20)]
        public string trang_thai { get; set; }

        public virtual cu_dan cu_dan { get; set; }

        public virtual tien_ich_chung tien_ich_chung { get; set; }
    }
}
