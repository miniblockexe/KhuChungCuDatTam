namespace KhuChungCuDatTam.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class hoa_don
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public hoa_don()
        {
            cong_no = new HashSet<cong_no>();
            hoa_don_chi_tiet = new HashSet<hoa_don_chi_tiet>();
            thanh_toan = new HashSet<thanh_toan>();
        }

        public int id { get; set; }

        public int can_ho_id { get; set; }

        [Column(TypeName = "date")]
        public DateTime thang_nam { get; set; }

        public decimal tien_dien { get; set; }

        public decimal tien_nuoc { get; set; }

        public decimal tien_gui_xe { get; set; }

        public decimal tien_bao_tri { get; set; }

        public decimal tien_phi_khac { get; set; }

        public decimal tong_tien { get; set; }

        [Required]
        [StringLength(20)]
        public string trang_thai { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime ngay_tao { get; set; }

        public virtual can_ho can_ho { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cong_no> cong_no { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hoa_don_chi_tiet> hoa_don_chi_tiet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<thanh_toan> thanh_toan { get; set; }
    }
}
