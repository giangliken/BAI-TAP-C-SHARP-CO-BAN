using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QuanLySinhVien
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<KHOA> KHOA { get; set; }
        public virtual DbSet<SINHVIEN> SINHVIEN { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KHOA>()
                .HasMany(e => e.SINHVIEN)
                .WithRequired(e => e.KHOA)
                .WillCascadeOnDelete(false);
        }
    }
}
