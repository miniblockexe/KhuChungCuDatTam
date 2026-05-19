namespace KhuChungCuDatTam.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class dich_vu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public dich_vu()
        {
            dang_ky_dich_vu = new HashSet<dang_ky_dich_vu>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(100)]
        public string ten_dich_vu { get; set; }

        public string mo_ta { get; set; }

        public decimal don_gia { get; set; }

        [StringLength(50)]
        public string don_vi { get; set; }

        [Required]
        [StringLength(20)]
        public string trang_thai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dang_ky_dich_vu> dang_ky_dich_vu { get; set; }
    }
}

