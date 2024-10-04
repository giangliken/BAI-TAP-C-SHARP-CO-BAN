using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Model1 context = new Model1();
                List<KHOA> danhSachKhoa = context.KHOA.ToList();
                List<SINHVIEN> danhSachSinhVien = context.SINHVIEN.ToList();
                FillFalcultyCombobox(danhSachKhoa);

                var danhSachSinhVienKhoa = danhSachSinhVien
                   .Join(danhSachKhoa, sv => sv.MaKhoa, k => k.MaKhoa, (sv, k) => new SinhVienKhoa
                   {
                       StudenID = sv.StudenID,
                       FullName = sv.FullName,
                       TenKhoa = k.TenKhoa,
                       DiemTB = (float)sv.DiemTB
                   })
                   .ToList();

                dataGridView1.DataSource = danhSachSinhVienKhoa;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        private void FillFalcultyCombobox(List<KHOA> danhSachKhoa)
        {
            this.txtKhoa.DataSource = danhSachKhoa;
            this.txtKhoa.DisplayMember = "TenKhoa";
            this.txtKhoa.ValueMember = "MaKhoa";
        }


        public class SinhVienKhoa
        {
            public string StudenID { get; set; }
            public string FullName { get; set; }
            public string TenKhoa { get; set; }
            public float DiemTB { get; set; }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thông tin từ các textbox
                string studentID = txtmssv.Text;
                string fullName = txtfullname.Text;
                KHOA khoa = (KHOA)txtKhoa.SelectedItem;
                float diemTB = float.Parse(txtDiemTB.Text);

                // Tạo mới một sinh viên
                SINHVIEN sinhVien = new SINHVIEN
                {
                    StudenID = studentID,
                    FullName = fullName,
                    MaKhoa = khoa.MaKhoa,
                    DiemTB = diemTB
                };

                // Thêm sinh viên vào cơ sở dữ liệu
                Model1 context = new Model1();
                context.SINHVIEN.Add(sinhVien);
                context.SaveChanges();

                // Cập nhật lại danh sách sinh viên trên DataGridView
                List<SINHVIEN> danhSachSinhVien = context.SINHVIEN.ToList();
                List<KHOA> danhSachKhoa = context.KHOA.ToList();

                var danhSachSinhVienKhoa = danhSachSinhVien
                  .Join(danhSachKhoa, sv => sv.MaKhoa, k => k.MaKhoa, (sv, k) => new SinhVienKhoa
                  {
                      StudenID = sv.StudenID,
                      FullName = sv.FullName,
                      TenKhoa = k.TenKhoa,
                      DiemTB = (float)sv.DiemTB
                  })
                  .ToList();

                dataGridView1.DataSource = danhSachSinhVienKhoa;

                // Thông báo thêm thành công
                MessageBox.Show("Thêm sinh viên thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm sinh viên: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thông tin của sinh viên cần sửa từ DataGridView
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                string studentID = dataGridView1.Rows[rowIndex].Cells["StudenID"].Value.ToString();

                // Lấy thông tin mới từ các textbox
                string fullName = txtfullname.Text;
                KHOA khoa = (KHOA)txtKhoa.SelectedItem;
                float diemTB = float.Parse(txtDiemTB.Text);

                // Cập nhật thông tin của sinh viên trong cơ sở dữ liệu
                Model1 context = new Model1();
                SINHVIEN sinhVien = context.SINHVIEN.Find(studentID);
                sinhVien.FullName = fullName;
                sinhVien.MaKhoa = khoa.MaKhoa;
                sinhVien.DiemTB = diemTB;
                context.SaveChanges();

                // Cập nhật lại danh sách sinh viên trên DataGridView
                List<SINHVIEN> danhSachSinhVien = context.SINHVIEN.ToList();
                List<KHOA> danhSachKhoa = context.KHOA.ToList();

                var danhSachSinhVienKhoa = danhSachSinhVien
                 .Join(danhSachKhoa, sv => sv.MaKhoa, k => k.MaKhoa, (sv, k) => new SinhVienKhoa
                 {
                     StudenID = sv.StudenID,
                     FullName = sv.FullName,
                     TenKhoa = k.TenKhoa,
                     DiemTB = (float)sv.DiemTB
                 })
                 .ToList();

                dataGridView1.DataSource = danhSachSinhVienKhoa;

                // Thông báo sửa thành công
                MessageBox.Show("Sửa sinh viên thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa sinh viên: " + ex.Message);
            }
        }

        private void btnXóa_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thông tin của sinh viên cần xóa từ DataGridView
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                string studentID = dataGridView1.Rows[rowIndex].Cells["StudenID"].Value.ToString();

                // Xóa sinh viên khỏi cơ sở dữ liệu
                Model1 context = new Model1();
                SINHVIEN sinhVien = context.SINHVIEN.Find(studentID);
                context.SINHVIEN.Remove(sinhVien);
                context.SaveChanges();

                // Cập nhật lại danh sách sinh viên trên DataGridView
                List<SINHVIEN> danhSachSinhVien = context.SINHVIEN.ToList();
                List<KHOA> danhSachKhoa = context.KHOA.ToList();

                var danhSachSinhVienKhoa = danhSachSinhVien
                .Join(danhSachKhoa, sv => sv.MaKhoa, k => k.MaKhoa, (sv, k) => new SinhVienKhoa
                {
                    StudenID = sv.StudenID,
                    FullName = sv.FullName,
                    TenKhoa = k.TenKhoa,
                    DiemTB = (float)sv.DiemTB
                })
                .ToList();

                dataGridView1.DataSource = danhSachSinhVienKhoa;

                // Thông báo xóa thành công
                MessageBox.Show("Xóa sinh viên thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa sinh viên: " + ex.Message);
            }
        }

    }

}
