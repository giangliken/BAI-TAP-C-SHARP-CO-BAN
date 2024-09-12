using System;
using System.Runtime.CompilerServices;

namespace Helloworld
{
    internal class Program
    {
        //phuong thuc giai phuong trinh bac 1
        public static void luaChon1()
        {
            int a = 0;
            int b = 0;
            bool isValue = false;
            while (!isValue)
            {
                Console.Write("Nhap a: ");
                try
                {
                    a = Convert.ToInt32(Console.ReadLine());
                    isValue = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Hay nhap vao mot so nguyen!");
                }
            }

            isValue = false;
            while (!isValue)
            {
                Console.Write("Nhap b: ");
                try
                {
                    b = Convert.ToInt32(Console.ReadLine());
                    isValue = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Hay nhap vao mot so nguyen!");
                }
            }

            if (a == 0)
            {
                Console.WriteLine("Khong the chia cho 0");
            }
            else
            {
                float x = (float)-b / a;
                Console.WriteLine("Ket qua cua {0}/{1} = {2}: ",-b,a,x);
            }
            Console.ReadKey();
        }

        //phuong thuc giai phuong trinh bac 2
        public static void luaChon2()
        {
            int a = 0;
            int b = 0;
            int c = 0;
            bool isValue = false;
            while (!isValue)
            {
                Console.Write("Nhap a: ");
                try
                {
                    a = Convert.ToInt32(Console.ReadLine());
                    isValue = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Hay nhap vao mot so nguyen!");
                }
            }

            isValue = false;
            while (!isValue)
            {
                Console.Write("Nhap b: ");
                try
                {
                    b = Convert.ToInt32(Console.ReadLine());
                    isValue = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Hay nhap vao mot so nguyen!");
                }
            }

            isValue = false;
            while (!isValue)
            {
                Console.Write("Nhap c: ");
                try
                {
                    c = Convert.ToInt32(Console.ReadLine());
                    isValue = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Hay nhap vao mot so nguyen!");
                }
            }

            if (a == 0)
            {

                if (b == 0)
                {
                    Console.WriteLine("Khong the chia cho 0");
                }
                else
                {
                    float x = (float)-c / b;
                    Console.WriteLine("Ket qua cua {0}/{1} = {2}: ", -c, b, x);
                }
                Console.ReadKey();
            }
            else
            {
                //tinh Denta
                double D = Math.Pow(b, 2) - (4 * a * c);
                if (D < 0)
                {
                    Console.WriteLine("Phuong trinh {0}x^2 + {1}x + {2} = 0 vo nghiem", a, b, c);
                }
                if (D == 0)
                {
                    double x = -b / (2 * a);
                    Console.WriteLine("Phuong trinh {0}x^2 + {1}x + {2} = 0 co nghiem kep x1 = x2 = {3}", a, b, c, x);
                }
                if (D > 0)
                {
                    Console.WriteLine("Phuong trinh {0}x^2 + {1}x + {2} = 0 co 2 nghiem phan biet", a, b, c);
                    double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(D)) / (2 * a);
                    Console.WriteLine("x1 = {0} | x2 = {1} ", x1, x2);
                }
            }

        }

        //phuong thuc tinh giai thua
        public static void luaChon3()
        {
            int n = 0;
            bool isValue = false;
            while (!isValue)
            {
                Console.Write("Nhap n: ");
                try
                {
                    n = Convert.ToInt32(Console.ReadLine());
                    isValue = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Vui long nhap so nguyen!");
                }
            }
            long T = 1;
            for(int i = 1; i <= n; i++)
            {
                T *= i;
            }
            Console.WriteLine("Giai thua cua {0} la: {1}", n, T);
        }

        //phuong thuc kiem tra so nguyen to
        public static bool CheckSNT(int n)
        {
            if (n < 2) return false;
            if (n == 2) return true;
            for(int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }

        //phuong thuc dem so luong so nguyen to trong khoang tu 1 - > n
        public static void luaChon4()
        {
            int n = 0;
            bool isValue = false;
            while (!isValue)
            {
                Console.Write("Nhap n: ");
                try
                {
                    n = Convert.ToInt32(Console.ReadLine());
                    isValue = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Vui long nhap so nguyen!");
                }
            }

            int dem = 0;
            for(int i = 0; i <= n; i++)
            {
                if (CheckSNT(i))
                {
                    Console.Write(i + " ");
                    dem++;
                }
                    
                
            }
            Console.WriteLine("Tong so luong so nguyen to tu 1 den {0} la {1}", n, dem);

        }

        public static void luaChon5()
        {
            int n = 0;
            bool isValue = false;
            while (!isValue)
            {
                Console.Write("Nhap n: ");
                try
                {
                    n = Convert.ToInt32(Console.ReadLine());
                    if (n > 0)
                    {
                        isValue = true;
                    }
                    else
                    {
                        Console.WriteLine("Hay nhap mot so nguyen lon hon 0!");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Hay nhap vao mot so nguyen!");
                }
            }

            if (n == 1)
            {
                Console.WriteLine("Tong day Fibonacci thu " + n + " la: 1");
            }
            else
            {
                int[] A = new int[n];
                A[0] = 1;
                A[1] = 1;
                for (int i = 2; i < n; i++)
                {
                    A[i] = A[i - 1] + A[i - 2];
                }

                // Hien thi day Fibonacci
                Console.Write("Day Fibonacci: ");
                for (int i = 0; i < n; i++)
                {
                    Console.Write(A[i] + " ");
                }

                // Tinh tong day Fibonacci
                int sum = 0;
                for (int i = 0; i < n; i++)
                {
                    sum += A[i];
                }
                Console.WriteLine("\nTong day Fibonacci thu " + n + " la: " + sum);
            }
            Console.ReadKey();
        }



        static void Main(string[] args)
        {
            int luachon = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("-----------------MENU-----------------");
                Console.WriteLine("1: Giai phuong trinh bac 1 (ax +b = 0)");
                Console.WriteLine("2: Giai phuong trinh bac 2 (ax^2 + bx + c = 0)");
                Console.WriteLine("3: Tinh giai thua cua mot so tu nhien n");
                Console.WriteLine("4: Dem so luong so nguyen to tu 1 den n");
                Console.WriteLine("5: Tim day Fibonanci thu n");
                Console.Write("Vui long nhap lua chon: ");
                try
                {
                    luachon = Convert.ToInt32(Console.ReadLine());
                    switch (luachon)
                    {
                        case 0:
                            {
                                Console.WriteLine("Nhan Enter de thoat!");
                                Console.ReadKey();
                            } break;
                        case 1:
                            {
                                luaChon1();
                            } break;
                        case 2:
                            {
                                luaChon2();
                                Console.ReadKey();
                            }
                            break;
                        case 3:
                            {
                                luaChon3();
                                Console.ReadKey();
                            }
                            break;
                        case 4:
                            {
                                luaChon4();
                                Console.ReadKey();
                            }
                            break;
                        case 5:
                            {
                                    luaChon5();
                                Console.ReadKey();
                            }
                            break;
                        default:
                            {
                                Console.WriteLine("Lua chon {0} khong co chuc nang!",luachon);
                                Console.ReadKey();
                            } break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Lua chon khong hop le! Chon lai!");
                    Console.ReadKey();
                }
            } while (luachon != 0);
            Console.ReadKey();
        }
    }
}
