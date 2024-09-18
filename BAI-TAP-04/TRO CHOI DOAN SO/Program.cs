using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TroChoiDoanSo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------CHUONG TRINH DOAN SO------------");
            Random random = new Random();
            int targetNumber = random.Next(100, 999);
            //Console.WriteLine("###{0}###", targetNumber);
            string targetString = targetNumber.ToString();
            int count = 1;
            int maxcount = 7;
            string guess, feedback = "";
            while (feedback != "+++" && count <= maxcount)
            {
                Console.Write("Lan doan thu {0}: ", count);
                guess = Console.ReadLine();
                feedback = GetFeedback(targetString, guess);
                Console.WriteLine("Phan hoi tu may tinh: {0}", feedback);
                count++;
            }
            Console.WriteLine("Nguoi choi da doan {0} lan. Tro choi ket thuc!", count - 1);
            if (count > maxcount)
            {
                Console.WriteLine("Nguoi choi thua cuoc. So can doan la: {0}", targetNumber);
            }
            else
            {
                Console.WriteLine("Nguoi choi thang cuoc!");
            }
            Console.ReadKey();
        }

        static string GetFeedback(string target, string guess)
        {
            string feedback = "";
            for (int i = 0; i < target.Length; i++)
            {
                if (target[i] == guess[i])
                {
                    feedback += "+";
                }
                else
                {
                    feedback += "?";
                }
            }
            return feedback;
        }
    }
}
