namespace KhuChungCuDatTam.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class hoa_don_chi_tiet
    {
        public int id { get; set; }

        public int hoa_don_id { get; set; }

        [Required]
        [StringLength(50)]
        public string loai { get; set; }

        [StringLength(255)]
        public string mo_ta { get; set; }

        public decimal so_luong { get; set; }

        public decimal don_gia { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? thanh_tien { get; set; }

        public virtual hoa_don hoa_don { get; set; }
    }
}
