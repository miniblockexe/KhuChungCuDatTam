namespace KhuChungCuDatTam.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class can_ho
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public can_ho()
        {
            bao_tri = new HashSet<bao_tri>();
            chi_so_dien_nuoc = new HashSet<chi_so_dien_nuoc>();
            cong_no = new HashSet<cong_no>();
            cu_dan = new HashSet<cu_dan>();
            dang_ky_dich_vu = new HashSet<dang_ky_dich_vu>();
            hoa_don = new HashSet<hoa_don>();
            hop_dong = new HashSet<hop_dong>();
            tai_lieu = new HashSet<tai_lieu>();
        }

        public int id { get; set; }

        public int toa_nha_id { get; set; }

        [Required]
        [StringLength(20)]
        public string so_can_ho { get; set; }

        public int? tang { get; set; }

        public decimal? dien_tich { get; set; }

        [Required]
        [StringLength(20)]
        public string trang_thai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bao_tri> bao_tri { get; set; }

        public virtual toa_nha toa_nha { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<chi_so_dien_nuoc> chi_so_dien_nuoc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cong_no> cong_no { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cu_dan> cu_dan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dang_ky_dich_vu> dang_ky_dich_vu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hoa_don> hoa_don { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hop_dong> hop_dong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tai_lieu> tai_lieu { get; set; }
    }
}
