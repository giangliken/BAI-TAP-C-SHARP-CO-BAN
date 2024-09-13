using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    internal class Program
    {
        static void xuatMenu()
        {
            Console.WriteLine("------------------------------------------------MENU------------------------------------------------");
            Console.WriteLine("1: Them sinh vien");
            Console.WriteLine("2: In danh sach sinh vien hien co");
            Console.WriteLine("3: Tim va in ra danh sach sinh vien co do tuoi tu 15 -> 18");
            Console.WriteLine("4: Tim va in ra danh sach sinh vien co ten bat dau bang chu 'A' ");
            Console.WriteLine("5: Tinh tong tuoi cac sinh vien co trong danh sach");
            Console.WriteLine("6: Tim va in ra sinh vien co tuoi lon nhat trong danh sach ");
            Console.WriteLine("7: Sap xep danh sach sinh vien theo tuoi tang dan");

        }

        //them sinh vien vao danh sach
        static public void themSinhVien()
        {
            Student sv = new Student();
            sv.nhapThongTin();
            danhSachSinhVien.Add(sv);
            Console.WriteLine("Them thanh cong sinh vien vao danh sach!");
        }

        //xuat danh sach sinh vien
        static public void xuatDanhSachSinhVien()
        {
            var kq = from sv in danhSachSinhVien
                     select sv;
            if (kq.Count() == 0)
            {
                Console.WriteLine("Danh sach hien dang trong!");
            }
            else
            {
                foreach(var sv in kq)
                {
                    sv.xuatThongTin();
                }
            }
        }

        //xuat danh sach sinh vien co do tuoi tu 15 - 18
        static public void xuatDanhSachSinhVienTheoDoTuoi()
        {
            var kq = from sv in danhSachSinhVien
                     where sv.Age1>=15 && sv.Age1<=18
                     select sv;
            foreach(var sv in kq)
            {
                sv.xuatThongTin();
            }
            
        }

        //xuat danh sach sinh vien co ten bat dau bang chu 'A'
        static public void xuatDanhSachSinhVienTheoTen()
        {
            var kq = from sv in danhSachSinhVien
                     where sv.Name1.StartsWith("A")
                     select sv;
            foreach (var sv in kq)
            {
                sv.xuatThongTin();
            }
        }

        //tinh tong tuoi cua sinh vien trong danh sach sinh vien
        static public int tinhTongTuoiDanhSachSinhVien()
        {
            return danhSachSinhVien.Sum(sv => sv.Age1);
        }

        //tim va in ra sinh vien co tuoi lon nhat trong danh sach sinh vien
        static public void xuatSinhVienTuoiMax()
        {
            int maxTuoi = danhSachSinhVien.Max(sv => sv.Age1);
            var kq = from sv in danhSachSinhVien
                     where sv.Age1 == maxTuoi
                     select sv;
            foreach(var sv in kq)
            {
                sv.xuatThongTin();
            }
        }

        //sap xep danh sach sinh vien tang theo tuoi
        static public void xuatDanhSachSauKhiSapXep()
        {
            var kq = from sv in danhSachSinhVien
                     orderby sv.Age1
                     select sv;

            foreach( var sv in kq)
            {
                sv.xuatThongTin();
            }
        }


        static List<Student> danhSachSinhVien = new List<Student>();
        static void Main(string[] args)
        {
            //du lieu mau

            // Them sinh vien vao danh sach
            Student st1 = new Student(1234, "Nguyen Truong Giang", 21);
            danhSachSinhVien.Add(st1);
            Student st2 = new Student(1235, "Pham Tien Dong", 10);
            danhSachSinhVien.Add(st2);
            Student st3 = new Student(1236, "Vo Tan Tai", 15);
            danhSachSinhVien.Add(st3);
            Student st4 = new Student(1237, "Duong Minh Tien", 18);
            danhSachSinhVien.Add(st4);
            Student st5 = new Student(1238, "AHo Xuan Nguyen", 40);
            danhSachSinhVien.Add(st5);

            bool isValue = false;
            int luaChon = 0;
            while (!isValue)
            {
                Console.Clear();
                xuatMenu();
                try
                {
                    Console.Write("Nhap lua chon: ");
                    luaChon = Convert.ToInt32(Console.ReadLine());
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
                                themSinhVien();
                                Console.ReadKey();
                            }
                            break;
                        case 2:
                            {
                                Console.WriteLine("Danh sach sinh vien:");
                                xuatDanhSachSinhVien();
                                Console.ReadKey();
                            }
                            break;
                        case 3:
                            {
                                Console.WriteLine("Danh sach sinh vien:");
                                xuatDanhSachSinhVienTheoDoTuoi();
                                Console.ReadKey();
                            }
                            break;
                        case 4:
                            {
                                Console.WriteLine("Danh sach sinh vien:");
                                xuatDanhSachSinhVienTheoTen();
                                Console.ReadKey();

                            }
                            break;
                        case 5:
                            {
                                Console.WriteLine("Tong tuoi sinh vien trong danh sach hien co la: " + tinhTongTuoiDanhSachSinhVien());
                                Console.ReadKey();
                            }
                            break;
                        case 6:
                            {
                                xuatSinhVienTuoiMax();
                                Console.ReadKey();
                            }
                            break;
                        case 7:
                            {
                                Console.WriteLine("Danh sach sinh vien:");
                                xuatDanhSachSauKhiSapXep();
                                Console.ReadKey();
                            }
                            break;
                        default:
                            {
                                Console.WriteLine("Lua chon " + luaChon + " khong co chuc nang!");
                                Console.ReadKey();
                            }
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Hay nhap lua chon la mot so nguyen!");
                    Console.ReadKey();
                }
                

            }
            
            Console.ReadKey();
        }
    }
}
