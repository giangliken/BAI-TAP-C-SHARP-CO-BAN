using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUAN_LY_TRUONG_HOC
{
    public class Student:Person
    {
        private string Khoa;
        private double diemTB;

        public string Khoa1 { get => Khoa; set => Khoa = value; }
        public double DiemTB { get => diemTB; set => diemTB = value; }
    
        public Student() { }

        public Student(string khoa, double diemTB)
        {
            Khoa = khoa;
            this.diemTB = diemTB;
        }

        public void Input()
        {
            base.Input();
            Console.Write("Nhap ten khoa / vien: ");
            Khoa = Console.ReadLine();
            try
            {
                Console.Write("Nhap diem TB: ");
                diemTB = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Diem TB phai la mot so nguyen hoac so thuc!. Nhap lai!");
            }
        }

        public void Output()
        {
            base.Output();
            Console.WriteLine("{0,-30} | {1,-4}",Khoa, diemTB);
        }
    }
}
