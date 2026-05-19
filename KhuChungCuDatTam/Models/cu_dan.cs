namespace KhuChungCuDatTam.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class cu_dan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cu_dan()
        {
            danh_gia = new HashSet<danh_gia>();
            dat_lich_tien_ich = new HashSet<dat_lich_tien_ich>();
            hop_dong = new HashSet<hop_dong>();
            khieu_nai = new HashSet<khieu_nai>();
            phuong_tien = new HashSet<phuong_tien>();
            tai_lieu = new HashSet<tai_lieu>();
            tam_tru = new HashSet<tam_tru>();
            thong_bao_cu_dan = new HashSet<thong_bao_cu_dan>();
        }

        public int id { get; set; }

        public int can_ho_id { get; set; }

        [Required]
        [StringLength(100)]
        public string ho_ten { get; set; }

        [StringLength(20)]
        public string so_dien_thoai { get; set; }

        [StringLength(100)]
        public string email { get; set; }

        [StringLength(20)]
        public string cmnd_cccd { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngay_sinh { get; set; }

        [Required]
        [StringLength(20)]
        public string loai_cu_dan { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngay_vao { get; set; }

        public virtual can_ho can_ho { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<danh_gia> danh_gia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dat_lich_tien_ich> dat_lich_tien_ich { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hop_dong> hop_dong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<khieu_nai> khieu_nai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<phuong_tien> phuong_tien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tai_lieu> tai_lieu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tam_tru> tam_tru { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<thong_bao_cu_dan> thong_bao_cu_dan { get; set; }
    }
}
