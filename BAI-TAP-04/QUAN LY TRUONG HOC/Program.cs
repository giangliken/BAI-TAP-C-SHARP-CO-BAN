using System;
using System.Collections.Generic;
using System.Linq;

namespace QUAN_LY_TRUONG_HOC
{
    internal class Program
    {
        static List<Person> danhSachLuuTru = new List<Person>();
        static List<Student> danhSachSinhVien = new List<Student>();
        static List<Teacher> danhSachGiangVien = new List<Teacher>();

        static void Menu()
        {
            Console.WriteLine("-------------------------MENU-------------------------");
            Console.WriteLine("1: Them sinh vien");
            Console.WriteLine("2: Them giang vien");
            Console.WriteLine("3: Xuat danh sach sinh vien");
            Console.WriteLine("4: Xuat danh sach giang vien");
            Console.WriteLine("5: Thong ke danh sach");
            Console.WriteLine("6: Xuat danh sach sinh vien thuoc khoa CNTT");
            Console.WriteLine("7: Xuat danh sach giang vien co dia chi o Quan 9");
            Console.WriteLine("8: Xuat danh sach sinh vien co diem TB cao nhat va thuoc khoa CNTT");
            Console.WriteLine("9: Thong ke theo thang diem (Danh sach sinh vien)");
            Console.WriteLine("0: Thoat!");
        }
        static void Main(string[] args)
        {
            int luachon = 0;
            bool isValue = false;
            while (!isValue)
            {
                Console.Clear();
                Menu();
                try
                {
                    luachon = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Lua chon phai la mot so nguyen!. Nhap lai!");
                }
                switch (luachon)
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
                            themGiangVien();
                            Console.ReadKey();
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("Danh sach sinh vien:");
                            xuatDanhSachSinhVien();
                            Console.ReadKey();
                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine("Danh sach giang vien: ");
                            xuatDanhSachGiangVien();
                            Console.ReadKey();
                        }
                        break;
                    case 5:
                        {
                            Console.WriteLine("THONG KE:");
                            int stcount = danhSachSinhVien.Count;
                            int tccount = danhSachGiangVien.Count;
                            Console.WriteLine("SL Sinh Vien: {0} | SL Giang Vien: {1}", stcount, tccount);
                            Console.ReadKey();

                        }
                        break;
                    case 6:
                        {
                            Console.WriteLine("Danh sach sinh vien:");
                            xuatDanhSachSinhVienKhoaCNTT();
                            Console.ReadKey();
                        }
                        break;
                    case 7:
                        {
                            Console.WriteLine("Danh sach giang vien: ");
                            xuatDanhSachGiangVienQ9();
                            Console.ReadKey();
                        }
                        break;
                    case 8:
                        {
                            Console.WriteLine("Thong tin sinh vien: ");
                            xuatThongTinSinhVienThoa2DK();
                            Console.ReadKey();
                        }
                        break;
                    case 9:
                        {
                            Console.WriteLine("THONG KE:");
                            thongKeDanhSachSinhVien();
                            Console.ReadKey();
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("Lua chon {0} khong co chuc nang!", luachon);
                            Console.ReadKey();
                        }
                        break;

                }

            }

            Console.ReadLine();
        }

        //them sinh vien
        static public void themSinhVien()
        {
            Student x = new Student();
            x.Input();
            danhSachSinhVien.Add(x);
            Console.WriteLine("Them thanh cong!");
        }

        //xuat danh sach sinh vien
        static public void xuatDanhSachSinhVien()
        {
            if (danhSachSinhVien.Count == 0)
            {
                Console.WriteLine("Danh sach trong!");
            }
            else
            {
                foreach (var x in danhSachSinhVien)
                {
                    x.Output();
                }
            }

        }

        //them giang vien
        static public void themGiangVien()
        {
            Teacher x = new Teacher();
            x.Input();
            danhSachGiangVien.Add(x);
        }

        //xuat danh sach giang vien
        static public void xuatDanhSachGiangVien()
        {
            if (danhSachGiangVien.Count == 0)
            {
                Console.WriteLine("Danh sach trong!");
            }
            else
            {
                foreach (var x in danhSachGiangVien)
                {
                    x.Output();
                }
            }

        }

        //xuat danh sach sinh vien thuoc khoa CNTT
        static public void xuatDanhSachSinhVienKhoaCNTT()
        {
            var kq = from sv in danhSachSinhVien
                     where sv.Khoa1.Contains("CNTT")
                     select sv;

            if (danhSachSinhVien.Count == 0)
            {
                Console.WriteLine("Danh sach trong!");
            }
            else
            {
                foreach (var x in kq)
                {
                    x.Output();
                }
            }

        }

        //xuat thong tin giang vien co dia chi o Quan 9
        static public void xuatDanhSachGiangVienQ9()
        {
            var kq = from sv in danhSachGiangVien
                     where sv.DiaChi.Contains("Quan 9")
                     select sv;

            if (kq.Count() == 0)
            {
                Console.WriteLine("Danh sach trong!");
            }
            else
            {
                foreach (var x in kq)
                {
                    x.Output();
                }
            }
        }

        //xuat ra thong tin sinh vien co diem trung binh cao nhat va thuoc khoa CNTT
        static public void xuatThongTinSinhVienThoa2DK()
        {
            var diemMAX = danhSachSinhVien.Max(sv => sv.DiemTB);
            var kq = from sv in danhSachSinhVien
                     where (sv.Khoa1.Contains("CNTT") && sv.DiemTB >= diemMAX)
                     select sv;

            if (danhSachSinhVien.Count == 0)
            {
                Console.WriteLine("Danh sach trong!");
            }
            else
            {
                foreach (var x in kq)
                {
                    x.Output();
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


    }
}
