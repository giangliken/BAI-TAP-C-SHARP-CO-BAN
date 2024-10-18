namespace De02.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LOAISP")]
    public partial class LOAISP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOAISP()
        {
            SANPHAM = new HashSet<SANPHAM>();
        }

        [Key]
        [StringLength(2)]
        public string MALOAI { get; set; }

        [Required]
        [StringLength(30)]
        public string TENLOAI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SANPHAM> SANPHAM { get; set; }
    }
}
