using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_Tap_OOP.QuanLySinhVien
{
    public class Nguoi
    {
        protected int soBaoDanh;
        protected string hoTen;
        protected string diaChi;
        protected int mucUuTien;
        protected char khoi;

        

        public Nguoi() { }
        public Nguoi(int soBaoDanh, string hoTen, string diaChi, int mucUuTien, char khoi)
        {
            this.soBaoDanh = soBaoDanh;
            this.hoTen = hoTen;
            this.diaChi = diaChi;
            this.mucUuTien = mucUuTien;
            this.khoi = khoi;
        }

        public void input()
        {
            Console.Write("Nhap so bao danh: ");
            soBaoDanh = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap ho ten: ");
            hoTen = Console.ReadLine();
            Console.Write("Nhap dia chi: ");
            diaChi = Console.ReadLine();
            Console.Write("Nhap muc uu tien: ");
            mucUuTien = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap khoi: ");
            khoi = Convert.ToChar(Console.ReadLine());
        }

        public void output()
        {
            Console.WriteLine("{0,-10} | {1,-30} | {2,-30} | {3,-10} | {4,-10}", soBaoDanh, hoTen, diaChi, mucUuTien, khoi);
        }

        public int laySoBaoDanh() { return soBaoDanh; }
    }
}
