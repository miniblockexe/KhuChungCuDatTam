namespace KhuChungCuDatTam.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class chi_so_dien_nuoc
    {
        public int id { get; set; }

        public int can_ho_id { get; set; }

        [Column(TypeName = "date")]
        public DateTime thang_nam { get; set; }

        public decimal? chi_so_dien_cu { get; set; }

        public decimal? chi_so_dien_moi { get; set; }

        public decimal? chi_so_nuoc_cu { get; set; }

        public decimal? chi_so_nuoc_moi { get; set; }

        [Column(TypeName = "date")]
        public DateTime ngay_ghi { get; set; }

        public virtual can_ho can_ho { get; set; }
    }
}
