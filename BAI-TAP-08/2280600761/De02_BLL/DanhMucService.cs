using De02.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De02_BLL
{
    public class DanhMucService
    {
        private readonly Model1 context;

        public DanhMucService()
        {
            context = new Model1();
        }

        public List<SANPHAM> GetAllSanPham()
        {
            return context.SANPHAM.ToList();
        }

        public List<LOAISP> GetAllLoaiSP()
        {
            return context.LOAISP.ToList();
        }

        public void AddSanPham(SANPHAM sanPham)
        {
            context.SANPHAM.Add(sanPham);
            context.SaveChanges();
        }

        public void UpdateSanPham(SANPHAM sanPham)
        {
            SANPHAM existingSanPham = context.SANPHAM.Find(sanPham.MASP);
            if (existingSanPham != null)
            {
                existingSanPham.TENSP = sanPham.TENSP;
                existingSanPham.NGAYNHAP = sanPham.NGAYNHAP;
                existingSanPham.MALOAI = sanPham.MALOAI;
                context.SaveChanges();
            }
        }

        public void DeleteSanPham(string maSP)
        {
            SANPHAM sanPham = context.SANPHAM.Find(maSP);
            if (sanPham != null)
            {
                context.SANPHAM.Remove(sanPham);
                context.SaveChanges();
            }
        }

        public List<SANPHAM> SearchSanPham(string keyword)
        {
            return context.SANPHAM
                .Where(sp => sp.TENSP.ToLower().Contains(keyword.ToLower()))
                .ToList();
        }
    }
}
