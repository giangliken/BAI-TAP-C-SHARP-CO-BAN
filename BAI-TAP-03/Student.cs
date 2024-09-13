using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    public class Student
    {
        private int ID;
        private string Name;
        private int Age;

        public Student() { }
        public Student(int iD, string name, int age)
        {
            ID1 = iD;
            Name1 = name;
            Age1 = age;
        }

        public int ID1 { get => ID; set => ID = value; }
        public string Name1 { get => Name; set => Name = value; }
        public int Age1 { get => Age; set => Age = value; }

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

            try
            {
                Console.Write("Nhap tuoi cua sinh vien: ");
                Age = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Tuoi phai la mot so nguyen!");
            }
        }

        public void xuatThongTin()
        {
            Console.WriteLine("{0,-10} | {1,-30} | {2,-4} ",ID,Name,Age);
        }
    }
}
