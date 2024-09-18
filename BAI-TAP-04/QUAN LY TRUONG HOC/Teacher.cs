using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUAN_LY_TRUONG_HOC
{
    public class Teacher:Person
    {
        private string diaChi;
        public string DiaChi { get => diaChi; set => diaChi = value; }

        public Teacher() { }

        public Teacher(string diaChi)
        {
            this.diaChi = diaChi;
        }

        public void Input()
        {
            base.Input();
            Console.Write("Nhap dia chi: ");
            diaChi = Console.ReadLine();    
        }

        public void Output()
        {
            base.Output();
            Console.WriteLine("{0,-50}", diaChi);
        }
    }
}
