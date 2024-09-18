using QUAN_LY_SINH_VIEN;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace QUAN_LY_SINH_VIEN
{
    internal class Program
    {
        static void xuatMenu()
        {
            Console.WriteLine("------------------------------------------------MENU------------------------------------------------");
            Console.WriteLine("1: Them sinh vien");
            Console.WriteLine("2: In danh sach sinh vien hien co");
            Console.WriteLine("3: In danh sach sinh vien thuoc khoa \"CNTT\" ");
            Console.WriteLine("4: In danh sach sinh vien sap xep theo diem TB tang dan");
            Console.WriteLine("5: In danh sach sinh vien co diem TB >=5 ");
            Console.WriteLine("6: In danh sach sinh vien co diem TB >=5 va thuoc khoa \"CNTT\" ");
            Console.WriteLine("7: In thong tin sinh vien co diem TB cao nhat va thuoc khoa \"CNTT \" ");
            Console.WriteLine("8: Thong ke xep loai sinh vien");

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
                foreach (var sv in kq)
                {
                    sv.xuatThongTin();
                }
            }
        }

        //xuat ra danh sach sinh vien thuoc khoa "CNTT"
        static public void xuatDanhSachSinhVienKhoaCNTT()
        {
            var kq = from sv in danhSachSinhVien
                     where sv.Khoa1.Contains("CNTT")
                     select sv;

            if (kq.Count() == 0)
            {
                Console.WriteLine("Khong co sinh vien nao thuoc khoa CNTT");
            }
            else
            {
                foreach (var sv in kq)
                {
                    sv.xuatThongTin();
                }
            }
        }

        //xuat ra danh sach sinh vien co diem TB >= 5
        static public void xuatDanhSachSinhVienDiemLonHon5()
        {
            var kq = from sv in danhSachSinhVien
                     where sv.DiemTB >= 5
                     select sv;
            if (kq.Count() == 0)
            {
                Console.WriteLine("Danh sach trong!");
            }
            else
            {
                foreach (var sv in kq)
                {
                    sv.xuatThongTin();
                }
            }
        }

        //xuat ra danh sach sinh vien sap xep diem TB tang
        static public void xuatDanhSachSinhVienSapXepTheoDiemTang()
        {
            var kq = from sv in danhSachSinhVien
                     orderby sv.DiemTB
                     select sv;
            if (kq.Count() == 0)
            {
                Console.WriteLine("Danh sach trong!");
            }
            else
            {
                foreach (var sv in kq)
                {
                    sv.xuatThongTin();
                }
            }
        }

        //xuat ra danh sach sinh vien co diem TB >=5 va thuoc khoa CNTT
        static public void xuatDanhSachThoa2DK()
        {
            var kq = from sv in danhSachSinhVien
                     where (sv.DiemTB >= 5) && (sv.Khoa1.Contains("CNTT"))
                     select sv;
            if ((kq.Count() == 0))
            {
                Console.WriteLine("Danh sach trong!");
            }
            else
            {
                foreach (var sv in kq)
                {
                    sv.xuatThongTin();
                }
            }
        }

        //xuat ra thong tin sinh vien co diem cao nhat va thuoc khoa CNTT
        static public void xuatThongTinSinhVienDiemMax()
        {
            var MAX = danhSachSinhVien.Max(sv => sv.DiemTB);
            var kq = from sv in danhSachSinhVien
                     where ((sv.DiemTB >= MAX) && (sv.Khoa1.Contains("CNTT")))
                     select sv;
            if (kq.Count() == 0)
            {
                Console.WriteLine("Danh sach trong!");
            }
            else
            {
                foreach (var sv in kq)
                {
                    sv.xuatThongTin();
                }
            }

        }

        //thong ke xep loai theo diem
        static public void thongKeDanhSachSinhVien()
        {
            // Nhom sinh vien theo thang diem va dem so luong
            var xuatSac = danhSachSinhVien.Where(sv => sv.DiemTB >= 9 && sv.DiemTB <= 10).Count();
            var gioi = danhSachSinhVien.Where(sv => sv.DiemTB >= 8 && sv.DiemTB < 9).Count();
            var kha = danhSachSinhVien.Where(sv => sv.DiemTB >= 7 && sv.DiemTB < 8).Count();
            var trungBinh = danhSachSinhVien.Where(sv => sv.DiemTB >= 5 && sv.DiemTB < 7).Count();
            var yeu = danhSachSinhVien.Where(sv => sv.DiemTB >= 4 && sv.DiemTB < 5).Count();
            var kem = danhSachSinhVien.Where(sv => sv.DiemTB < 4).Count();

            // Xuat ket qua
            Console.WriteLine("Thong ke sinh vien theo thang diem:");
            Console.WriteLine($"Xuat sac (9-10): {xuatSac}");
            Console.WriteLine($"Gioi (8-<9): {gioi}");
            Console.WriteLine($"Kha (7-<8): {kha}");
            Console.WriteLine($"Trung binh (5-<7): {trungBinh}");
            Console.WriteLine($"Yeu (4-<5): {yeu}");
            Console.WriteLine($"Kem (<4): {kem}");
        }

        static List<Student> danhSachSinhVien = new List<Student>();
        static void Main(string[] args)
        {
            //du lieu mau

            //Them sinh vien vao danh sach
            Student st1 = new Student(1234, "Nguyen Truong Giang", "CNTT", 10);
            danhSachSinhVien.Add(st1);
            Student st2 = new Student(1235, "Pham Tien Dong", "Khoa Luat", 10);
            danhSachSinhVien.Add(st2);
            Student st3 = new Student(1236, "Vo Tan Tai", "CNTT", 8);
            danhSachSinhVien.Add(st3);
            Student st4 = new Student(1237, "Duong Minh Tien", "Khoa ngon ngu Han", 8.6);
            danhSachSinhVien.Add(st4);
            Student st5 = new Student(1238, "Ho Xuan Nguyen", "CNTT", 4.1);
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
                                xuatDanhSachSinhVienKhoaCNTT();
                                Console.ReadKey();
                            }
                            break;
                        case 4:
                            {
                                Console.WriteLine("Danh sach sinh vien:");
                                xuatDanhSachSinhVienDiemLonHon5();
                                Console.ReadKey();

                            }
                            break;
                        case 5:
                            {
                                Console.WriteLine("Danh sach sinh vien:");
                                xuatDanhSachSinhVienSapXepTheoDiemTang();
                                Console.ReadKey();
                            }
                            break;
                        case 6:
                            {
                                Console.WriteLine("Danh sach sinh vien:");
                                xuatDanhSachThoa2DK();
                                Console.ReadKey();
                            }
                            break;
                        case 7:
                            {
                                Console.WriteLine("Danh sach sinh vien:");
                                xuatThongTinSinhVienDiemMax();
                                Console.ReadKey();
                            }
                            break;
                        case 8:
                            {
                                Console.WriteLine("Thong ke: ");
                                thongKeDanhSachSinhVien();
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
