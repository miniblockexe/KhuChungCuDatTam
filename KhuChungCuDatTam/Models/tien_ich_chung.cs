namespace KhuChungCuDatTam.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tien_ich_chung
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tien_ich_chung()
        {
            dat_lich_tien_ich = new HashSet<dat_lich_tien_ich>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(100)]
        public string ten_tien_ich { get; set; }

        public string mo_ta { get; set; }

        public int? suc_chua { get; set; }

        [Required]
        [StringLength(20)]
        public string trang_thai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dat_lich_tien_ich> dat_lich_tien_ich { get; set; }
    }
}
