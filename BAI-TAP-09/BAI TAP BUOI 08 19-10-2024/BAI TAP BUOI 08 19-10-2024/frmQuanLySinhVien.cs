using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAI_TAP_BUOI_08_19_10_2024
{
    public partial class frmQuanLySinhVien : Form
    {
        private StudentService studentService = new StudentService();
        public frmQuanLySinhVien()
        {
            InitializeComponent();
        }


        private void frmQuanLySinhVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'schoolDBDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.schoolDBDataSet.Student);
            ClearTXT();
        }

        private void ClearTXT()
        {
            txtMaSinhVien.Text = string.Empty;
            txtTenSinhVien.Text = string.Empty;
            txtTuoi.Text = string.Empty;
            txtChuyenNganh.Text = string.Empty;
        }
        private void uiDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int studentID = int.Parse(txtMaSinhVien.Text);
                string fullName = txtTenSinhVien.Text;
                int age = int.Parse(txtTuoi.Text);
                string major = txtChuyenNganh.Text;

                // Thêm sinh viên mới bằng TableAdapter
                this.studentTableAdapter.Insert(studentID, fullName, age, major);

                // Tải lại danh sách sinh viên sau khi thêm
                this.studentTableAdapter.Fill(this.schoolDBDataSet.Student);
                MessageBox.Show("Thêm sinh viên thành công!");
                ClearTXT();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm sinh viên: " + ex.Message);
            }
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int studentID = int.Parse(txtMaSinhVien.Text); // Lấy mã sinh viên từ textbox
                string fullName = txtTenSinhVien.Text; // Lấy tên sinh viên từ textbox
                int age = int.Parse(txtTuoi.Text); // Lấy tuổi sinh viên từ textbox
                string major = txtChuyenNganh.Text; // Lấy chuyên ngành từ textbox

                // Kiểm tra xem sinh viên đã tồn tại chưa trước khi sửa
                var studentTable = this.studentTableAdapter.GetData();
                var studentRow = studentTable.FirstOrDefault(s => s.StudentID == studentID);

                if (studentRow != null)
                {
                    // Cập nhật thông tin sinh viên
                    studentRow.FullName = fullName;
                    studentRow.Age = age;
                    studentRow.Major = major;

                    // Sửa thông tin sinh viên trong cơ sở dữ liệu
                    this.studentTableAdapter.Update(studentRow);

                    // Tải lại danh sách sinh viên sau khi sửa
                    this.studentTableAdapter.Fill(this.schoolDBDataSet.Student);
                    MessageBox.Show("Cập nhật sinh viên thành công!");

                    ClearTXT(); // Xóa các textbox sau khi cập nhật
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sinh viên với mã này.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật sinh viên: " + ex.Message);
            }
        }



        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int studentID = int.Parse(txtMaSinhVien.Text); // Lấy mã sinh viên từ textbox

                // Kiểm tra xem sinh viên có tồn tại hay không
                var studentTable = this.studentTableAdapter.GetData();
                var studentRow = studentTable.FirstOrDefault(s => s.StudentID == studentID);

                if (studentRow != null)
                {
                    // Xóa sinh viên khỏi cơ sở dữ liệu
                    this.studentTableAdapter.DeleteStudent(studentID); // Sử dụng phương thức xóa mới

                    // Tải lại danh sách sinh viên sau khi xóa
                    this.studentTableAdapter.Fill(this.schoolDBDataSet.Student);
                    MessageBox.Show("Xóa sinh viên thành công!");

                    ClearTXT(); // Xóa các textbox sau khi xóa
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sinh viên với mã này.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa sinh viên: " + ex.Message);
            }
        }

        private int currentIndex = 0; // Chỉ số của sinh viên hiện tại

        private void UpdateStudentInfo()
        {
            var studentTable = this.studentTableAdapter.GetData();

            if (studentTable != null && studentTable.Rows.Count > 0 && currentIndex >= 0 && currentIndex < studentTable.Rows.Count)
            {
                // Lấy sinh viên hiện tại
                var studentRow = studentTable.Rows[currentIndex];

                // Cập nhật các TextBox
                txtMaSinhVien.Text = studentRow["StudentID"].ToString();
                txtTenSinhVien.Text = studentRow["FullName"].ToString();
                txtTuoi.Text = studentRow["Age"].ToString();
                txtChuyenNganh.Text = studentRow["Major"].ToString();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            var studentTable = this.studentTableAdapter.GetData();

            // Kiểm tra nếu còn sinh viên tiếp theo
            if (currentIndex < studentTable.Rows.Count - 1)
            {
                currentIndex++;
                UpdateStudentInfo(); // Cập nhật thông tin sinh viên
            }
            else
            {
                MessageBox.Show("Đã đến sinh viên cuối cùng.");
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu còn sinh viên trước đó
            if (currentIndex > 0)
            {
                currentIndex--;
                UpdateStudentInfo(); // Cập nhật thông tin sinh viên
            }
            else
            {
                MessageBox.Show("Đã đến sinh viên đầu tiên.");
            }
        }


    }
}
