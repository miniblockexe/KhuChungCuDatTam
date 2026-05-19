namespace KhuChungCuDatTam.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tai_lieu
    {
        public int id { get; set; }

        [StringLength(255)]
        public string ten_file { get; set; }

        [StringLength(255)]
        public string duong_dan { get; set; }

        [StringLength(50)]
        public string loai { get; set; }

        public int? cu_dan_id { get; set; }

        public int? can_ho_id { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime ngay_tao { get; set; }

        public virtual can_ho can_ho { get; set; }

        public virtual cu_dan cu_dan { get; set; }
    }
}
