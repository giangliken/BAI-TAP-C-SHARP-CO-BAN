using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUAN_LY_SINH_VIEN
{
    public class Student
    {
        private int ID;
        private string Name;
        private string Khoa;
        private double diemTB;

        public int ID1 { get => ID; set => ID = value; }
        public string Name1 { get => Name; set => Name = value; }
        public string Khoa1 { get => Khoa; set => Khoa = value; }
        public double DiemTB { get => diemTB; set => diemTB = value; }

        public Student() { }

        public Student(int ID, string Age, string Khoa, double diemTB)
        {
            this.ID = ID;
            this.Name = Age;
            this.Khoa = Khoa;
            this.DiemTB = diemTB;
        }

        public void nhapThongTin()
        {
            try
            {
                Console.Write("Nhap ma so sinh vien: ");
                ID = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Ma so sinh vien phai la mot so nguyen!");
            }

            Console.Write("Nhap ho ten sinh vien: ");
            Name = Console.ReadLine();

            Console.Write("Nhap khoa: ");
            Khoa = Console.ReadLine();

            try
            {
                Console.Write("Nhap diem TB: ");
                diemTB = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Vui long nhap vao mot so thuc!");
            }
        }

        public void xuatThongTin()
        {
            Console.WriteLine("{0,-10} | {1,-30} | {2,-30} | {3,-10}", ID, Name, Khoa, diemTB);
        }
    }
}
