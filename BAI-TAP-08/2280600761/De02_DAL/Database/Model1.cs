using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace De02.Database
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<LOAISP> LOAISP { get; set; }
        public virtual DbSet<SANPHAM> SANPHAM { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LOAISP>()
                .Property(e => e.MALOAI)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LOAISP>()
                .HasMany(e => e.SANPHAM)
                .WithRequired(e => e.LOAISP)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SANPHAM>()
                .Property(e => e.MASP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SANPHAM>()
                .Property(e => e.MALOAI)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
