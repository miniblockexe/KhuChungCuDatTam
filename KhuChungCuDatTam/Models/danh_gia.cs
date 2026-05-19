namespace KhuChungCuDatTam.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class danh_gia
    {
        public int id { get; set; }

        public int cu_dan_id { get; set; }

        public string noi_dung { get; set; }

        public int diem { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime ngay_gui { get; set; }

        public virtual cu_dan cu_dan { get; set; }
    }
}
