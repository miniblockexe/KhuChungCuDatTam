namespace KhuChungCuDatTam.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class nguoi_dung
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public nguoi_dung()
        {
            audit_log = new HashSet<audit_log>();
            bang_luong = new HashSet<bang_luong>();
            bao_tri = new HashSet<bao_tri>();
            cham_cong = new HashSet<cham_cong>();
            khieu_nai = new HashSet<khieu_nai>();
            thanh_toan = new HashSet<thanh_toan>();
            thong_bao = new HashSet<thong_bao>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string ten_dang_nhap { get; set; }

        [Required]
        [StringLength(255)]
        public string mat_khau { get; set; }

        [StringLength(100)]
        public string ho_ten { get; set; }

        [StringLength(100)]
        public string email { get; set; }

        [StringLength(20)]
        public string so_dien_thoai { get; set; }

        public int vai_tro_id { get; set; }

        [Required]
        [StringLength(10)]
        public string trang_thai { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime ngay_tao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<audit_log> audit_log { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bang_luong> bang_luong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bao_tri> bao_tri { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cham_cong> cham_cong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<khieu_nai> khieu_nai { get; set; }

        public virtual vai_tro vai_tro { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<thanh_toan> thanh_toan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<thong_bao> thong_bao { get; set; }
    }
}
