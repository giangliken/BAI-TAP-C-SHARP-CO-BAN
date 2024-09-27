using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAI_TAP_BUOI_03_27_09_2024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Định dạng ngày tháng cho DateTimePicker
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnNam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnNu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnTheThao_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnPhimAnh_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnDuLich_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnXuatThongTin_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các trường
            string fullName = txtFullName.Text;
            string birthDate = dateTimePicker1.Value.ToString("dd/MM/yyyy");

            // Lấy giới tính
            string gender = "";
            if (btnNam.Checked)
            {
                gender = "Nam";
            }
            else if (btnNu.Checked)
            {
                gender = "Nữ";
            }

            // Lấy sở thích
            List<string> hobbies = new List<string>();
            if (btnTheThao.Checked)
            {
                hobbies.Add("Thể Thao");
            }
            if (btnPhimAnh.Checked)
            {
                hobbies.Add("Phim Ảnh");
            }
            if (btnDuLich.Checked)
            {
                hobbies.Add("Du Lịch");
            }

            // Tạo chuỗi thông tin để hiển thị
            string output = $"Họ và Tên: {fullName}\nNgày Sinh: {birthDate}\nGiới Tính: {gender}\nSở Thích: {string.Join(", ", hobbies)}";

            // Hiển thị thông tin (có thể là trong một TextBox hoặc Label)
            MessageBox.Show(output, "Thông Tin Đã Nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

    }
}
