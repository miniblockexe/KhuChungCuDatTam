namespace KhuChungCuDatTam.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class thong_bao
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public thong_bao()
        {
            thong_bao_cu_dan = new HashSet<thong_bao_cu_dan>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(200)]
        public string tieu_de { get; set; }

        [Required]
        public string noi_dung { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime ngay_gui { get; set; }

        public int nguoi_gui_id { get; set; }

        [Required]
        [StringLength(30)]
        public string loai { get; set; }

        public bool gui_tat_ca { get; set; }

        public virtual nguoi_dung nguoi_dung { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<thong_bao_cu_dan> thong_bao_cu_dan { get; set; }
    }
}
