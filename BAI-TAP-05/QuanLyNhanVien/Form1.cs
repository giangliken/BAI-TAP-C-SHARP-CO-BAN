using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuanLyNhanVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Thêm dữ liệu vào DataGridView
        private void btnThem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(); // Tạo mới Form2 để thêm nhân viên
            if (form2.ShowDialog() == DialogResult.OK) // Chờ người dùng nhấn "Đồng ý"
            {
                // Thêm dòng mới vào DataGridView từ dữ liệu của Form2
                dataGridView1.Rows.Add(form2.nhanVienMoi.MaSo, form2.nhanVienMoi.HoTen, form2.nhanVienMoi.LuongCoBan);
            }
        }

        // Sửa dữ liệu trong DataGridView thông qua Form2
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) // Kiểm tra có dòng được chọn không
            {
                // Lấy dòng được chọn
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Tạo đối tượng nhân viên từ dữ liệu của dòng đã chọn
                NhanVien nv = new NhanVien
                {
                    MaSo = selectedRow.Cells[0].Value.ToString(),
                    HoTen = selectedRow.Cells[1].Value.ToString(),
                    LuongCoBan = Convert.ToDecimal(selectedRow.Cells[2].Value)
                };

                // Mở Form2 với dữ liệu nhân viên để sửa
                Form2 form2 = new Form2(nv);
                if (form2.ShowDialog() == DialogResult.OK) // Chờ người dùng nhấn "Đồng ý"
                {
                    // Cập nhật lại dòng đã chọn với dữ liệu mới từ Form2
                    selectedRow.Cells[0].Value = form2.nhanVienMoi.MaSo;
                    selectedRow.Cells[1].Value = form2.nhanVienMoi.HoTen;
                    selectedRow.Cells[2].Value = form2.nhanVienMoi.LuongCoBan;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa.");
            }
        }

        // Xóa dòng thông qua Form2
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) // Kiểm tra có dòng được chọn không
            {
                // Lấy dòng được chọn
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Tạo đối tượng nhân viên từ dữ liệu của dòng đã chọn
                NhanVien nv = new NhanVien
                {
                    MaSo = selectedRow.Cells[0].Value.ToString(),
                    HoTen = selectedRow.Cells[1].Value.ToString(),
                    LuongCoBan = Convert.ToDecimal(selectedRow.Cells[2].Value)
                };

                // Mở Form2 để người dùng xác nhận việc xóa
                Form2 form2 = new Form2(nv, isDelete: true); // Truyền thêm flag isDelete
                if (form2.ShowDialog() == DialogResult.OK) // Chờ người dùng nhấn "Đồng ý"
                {
                    // Xóa dòng nếu người dùng đồng ý
                    dataGridView1.Rows.RemoveAt(selectedRow.Index);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.");
            }
        }

        // Thoát ứng dụng
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    // Lớp đại diện cho nhân viên
    public class NhanVien
    {
        public string MaSo { get; set; }
        public string HoTen { get; set; }
        public decimal LuongCoBan { get; set; }
    }
}
