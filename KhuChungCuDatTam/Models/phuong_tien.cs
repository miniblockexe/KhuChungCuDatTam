namespace KhuChungCuDatTam.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class phuong_tien
    {
        public int id { get; set; }

        public int cu_dan_id { get; set; }

        [Required]
        [StringLength(20)]
        public string bien_so { get; set; }

        [Required]
        [StringLength(20)]
        public string loai_xe { get; set; }

        public decimal phi_gui_thang { get; set; }

        [Required]
        [StringLength(20)]
        public string trang_thai { get; set; }

        public virtual cu_dan cu_dan { get; set; }
    }
}
