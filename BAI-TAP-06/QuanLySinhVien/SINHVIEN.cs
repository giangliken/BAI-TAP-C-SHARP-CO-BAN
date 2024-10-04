namespace QuanLySinhVien
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SINHVIEN")]
    public partial class SINHVIEN
    {
        [Key]
        [StringLength(20)]
        public string StudenID { get; set; }

        [StringLength(200)]
        public string FullName { get; set; }

        public double? DiemTB { get; set; }

        public int MaKhoa { get; set; }

        public virtual KHOA KHOA { get; set; }

    }
}
