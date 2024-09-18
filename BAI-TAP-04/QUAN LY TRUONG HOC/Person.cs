using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUAN_LY_TRUONG_HOC
{
    public class Person
    {
        protected int ID;
        protected string Name;
        public void Input()
        {
            try
            {
                Console.Write("Nhap ID: ");
                ID = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("ID la mot so nguyen!. Nhap lai!");
            }
            
            Console.Write("Nhap ho ten: ");
            Name = Console.ReadLine();
        }

        public void Output()
        {
            Console.Write("{0,-10} | {1,-30} |",ID,Name);
        }
    }
}
