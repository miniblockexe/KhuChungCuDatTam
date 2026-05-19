namespace KhuChungCuDatTam.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class toa_nha
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public toa_nha()
        {
            can_ho = new HashSet<can_ho>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string ten_toa { get; set; }

        public int? so_tang { get; set; }

        public int? so_can_ho { get; set; }

        public string dia_chi { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngay_xay_dung { get; set; }

        [Required]
        [StringLength(20)]
        public string trang_thai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<can_ho> can_ho { get; set; }
    }
}
