using System;
using System.Collections.Generic;

namespace Bai_Tap_OOP.QuanLySinhVien
{
    internal class QuanLySinhVien
    {
        static List<Nguoi> danhSachSinhVien = new List<Nguoi>();

        static public void themThiSinh()
        {
            Nguoi i = new Nguoi();
            i.input();
            danhSachSinhVien.Add(i);
            Console.WriteLine("Them thanh cong!");
        }

        static public void xuatDanhSachThiSinh()
        {
            int count = 0;
            foreach(var x in danhSachSinhVien)
            {
                x.output();
                count++;
            }
            if (count == 0)
            {
                Console.WriteLine("Danh sach trong!");
            }

        }

        static public void timKiemThiSinh()
        {
            int count = 0;
            Console.WriteLine("Nhap ma so thi sinh can tim: ");
            int x = Convert.ToInt32(Console.ReadLine());
            foreach(var i in danhSachSinhVien)
            {
                if (x == i.laySoBaoDanh())
                {
                    i.output();
                    count++;
                }
            }

            if (count == 0)
            {
                Console.WriteLine("Khong tim thay thi sinh");
            }
            else
            {
                Console.WriteLine("Tim kiem thanh cong!");
            }
        }

        static public void xoaThiSinh()
        {
            int count = 0;
            Console.WriteLine("Nhap so bao danh thi sinh can xoa: ");
            int x = Convert.ToInt32(Console.ReadLine());
            foreach(var i in danhSachSinhVien)
            {
                if (x == i.laySoBaoDanh())
                {
                    danhSachSinhVien.Remove(i);
                    count++;
                    break;
                }
                
            }

            if (count == 0)
            {
                Console.WriteLine("Khong tim thay so bao danh thi sinh!");
            }
            else
            {
                Console.WriteLine("Xoa thanh cong!");
            }
        }

        static public void hienMenu()
        {
            bool isValue = false;
            while (!isValue)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("--------------------------------------MENU--------------------------------------");
                    Console.WriteLine("1: Them thi sinh");
                    Console.WriteLine("2: Hien thi danh sach thi sinh");
                    Console.WriteLine("3: Tim kiem thi sinh");
                    Console.WriteLine("4: Xoa thi sinh");
                    Console.WriteLine("0: Thoat");
                    int luaChon = Convert.ToInt32(Console.ReadLine());
                    switch (luaChon)
                    {
                        case 0:
                            {
                                Console.WriteLine("Nhan Enter de thoat!");
                                isValue = true;
                            }
                            break;
                        case 1:
                            {
                                themThiSinh();
                                Console.ReadKey();
                            }
                            break;
                        case 2:
                            {
                                xuatDanhSachThiSinh();
                                Console.ReadKey();
                            }
                            break;
                        case 3:
                            {
                                timKiemThiSinh();
                                Console.ReadKey();
                            }
                            break;
                        case 4:
                            {
                                xoaThiSinh();
                                Console.ReadKey();
                            }
                            break;

                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Vui long nhap so nguyen");
                }

            }
        }
        static void Main(string[] args)
        {
            
            hienMenu();
            Console.ReadKey();
        }
    }
}
