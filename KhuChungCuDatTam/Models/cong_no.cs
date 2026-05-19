namespace KhuChungCuDatTam.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class cong_no
    {
        public int id { get; set; }

        public int can_ho_id { get; set; }

        public int? hoa_don_id { get; set; }

        public decimal so_tien_no { get; set; }

        [Column(TypeName = "date")]
        public DateTime? han_thanh_toan { get; set; }

        [Required]
        [StringLength(20)]
        public string trang_thai { get; set; }

        public virtual can_ho can_ho { get; set; }

        public virtual hoa_don hoa_don { get; set; }
    }
}
