namespace KhuChungCuDatTam.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class dang_ky_dich_vu
    {
        public int id { get; set; }

        public int can_ho_id { get; set; }

        public int dich_vu_id { get; set; }

        [Column(TypeName = "date")]
        public DateTime ngay_dang_ky { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngay_huy { get; set; }

        [Required]
        [StringLength(20)]
        public string trang_thai { get; set; }

        public virtual can_ho can_ho { get; set; }

        public virtual dich_vu dich_vu { get; set; }
    }
}
