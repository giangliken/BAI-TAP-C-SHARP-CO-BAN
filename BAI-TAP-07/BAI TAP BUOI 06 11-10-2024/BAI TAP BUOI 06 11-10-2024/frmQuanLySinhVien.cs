using BLL;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAI_TAP_BUOI_06_11_10_2024
{

    public partial class frmQuanLySinhVien : Form
    {
        public readonly StudentService studentService = new StudentService();
        public readonly FacultyService facultyService = new FacultyService();
        public readonly MajorService majorService = new MajorService();
        public frmQuanLySinhVien()
        {
            InitializeComponent();
        }

        private void frmQuanLySinhVien_Load(object sender, EventArgs e)
        {
            cbbNganh.DataSource = majorService.GetAll();
            cbbNganh.DisplayMember = "Name";
            cbbNganh.ValueMember = "MajorID";



            dgvDanhSachSinhVien.AutoGenerateColumns = false;

            //Thiết lập tên cho các cột tương ứng
            dgvDanhSachSinhVien.Columns[0].DataPropertyName = "StudentID";
            dgvDanhSachSinhVien.Columns[1].DataPropertyName = "fullname";
            dgvDanhSachSinhVien.Columns[2].DataPropertyName = "FacultyName";
            dgvDanhSachSinhVien.Columns[3].DataPropertyName = "averagescore";
            dgvDanhSachSinhVien.Columns[4].DataPropertyName = "MajorName";

            dgvDanhSachSinhVien.DataSource = studentService.GetAll();

        }

        private void dgvDanhSachSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem có click vào dòng hợp lệ không (đảm bảo không phải dòng tiêu đề)
            if (e.RowIndex >= 0)
            {
                // Lấy dòng được chọn
                DataGridViewRow row = dgvDanhSachSinhVien.Rows[e.RowIndex];

                // Gán dữ liệu từ dòng được chọn vào các TextBox
                txtMSSV.Text = row.Cells["mssv"].Value?.ToString();           // Lấy MSSV
                txtTenSinhVien.Text = row.Cells["fullname"].Value?.ToString();     // Lấy họ tên
                txtDiemTB.Text = row.Cells["averagescore"].Value?.ToString();      // Lấy điểm TB

                // Thiết lập ComboBox ngành
                string selectedMajorName = row.Cells["major"].Value?.ToString();
                if (!string.IsNullOrEmpty(selectedMajorName))
                {
                    // Tìm và chọn chuyên ngành tương ứng trong ComboBox
                    foreach (var item in cbbNganh.Items)
                    {
                        Major major = item as Major;
                        if (major != null && major.Name == selectedMajorName)
                        {
                            cbbNganh.SelectedItem = item;  // Chọn chuyên ngành tương ứng
                            break;
                        }
                    }
                }
            }
        }


        private void txtMSSV_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenSinhVien_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThemSua_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các TextBox
            string mssv = txtMSSV.Text.Trim();
            string fullname = txtTenSinhVien.Text.Trim();
            float diemTB;

            // Kiểm tra xem điểm trung bình có hợp lệ không
            if (!float.TryParse(txtDiemTB.Text.Trim(), out diemTB))
            {
                MessageBox.Show("Điểm trung bình không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra xem có chọn một ngành không
            if (cbbNganh.SelectedIndex >= 0)
            {
                // Lấy MajorID từ danh sách các Major trong ComboBox
                Major selectedMajor = (Major)cbbNganh.SelectedItem; // Lấy đối tượng Major từ ComboBox

                // Tạo một đối tượng sinh viên mới
                Student student = new Student
                {
                    StudentID = mssv,
                    FullName = fullname,
                    AverageScore = diemTB,
                    MajorID = selectedMajor.MajorID, // Sử dụng MajorID từ đối tượng Major đã chọn
                    FacultyID = selectedMajor.FacultyID // Lấy FacultyID từ đối tượng Major
                };

                try
                {
                    // Gọi phương thức để thêm hoặc cập nhật sinh viên
                    studentService.AddOrUpdate(student);
                    MessageBox.Show("Thông tin sinh viên đã được lưu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Làm mới DataGridView
                    dgvDanhSachSinhVien.DataSource = studentService.GetAll();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn chuyên ngành.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvDanhSachSinhVien_TabIndexChanged(object sender, EventArgs e)
        {

        }


        private int? selectedMajorID; // Khai báo biến để lưu mã ngành đã chọn

        private void cbbNganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem có chọn một giá trị hợp lệ không
            if (cbbNganh.SelectedValue != null)
            {
                // Lấy giá trị được chọn
                var selectedValue = cbbNganh.SelectedValue;

                // Kiểm tra xem nó có phải là kiểu int không
                if (selectedValue is string majorIDString)
                {
                    selectedMajorID = int.Parse(majorIDString); // Lưu mã ngành vào biến (đảm bảo nó là kiểu int)

                    // Lấy tên chuyên ngành từ ComboBox
                    string majorName = cbbNganh.Text;

                    // Hiển thị MajorID và MajorName lên màn hình (nếu cần)
                    //MessageBox.Show($"Major ID: {selectedMajorID}\nMajor Name: {majorName}", "Thông tin chuyên ngành", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //MessageBox.Show("Giá trị không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn chuyên ngành.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void btnXoa_Click(object sender, EventArgs e)
        {
            string mssv = txtMSSV.Text.Trim();

            if (string.IsNullOrEmpty(mssv))
            {
                MessageBox.Show("Vui lòng nhập MSSV để xóa sinh viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Gọi phương thức xóa sinh viên
                studentService.Delete(mssv);
                MessageBox.Show("Sinh viên đã được xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Làm mới DataGridView
                dgvDanhSachSinhVien.DataSource = studentService.GetAll();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoc_CheckedChanged(object sender, EventArgs e)
        {
            if (btnLoc.Checked)
            {
                dgvDanhSachSinhVien.AutoGenerateColumns = false;

                //Thiết lập tên cho các cột tương ứng
                dgvDanhSachSinhVien.Columns[0].DataPropertyName = "StudentID";
                dgvDanhSachSinhVien.Columns[1].DataPropertyName = "fullname";
                dgvDanhSachSinhVien.Columns[2].DataPropertyName = "FacultyName";
                dgvDanhSachSinhVien.Columns[3].DataPropertyName = "averagescore";
                dgvDanhSachSinhVien.Columns[4].DataPropertyName = "MajorName";

                dgvDanhSachSinhVien.DataSource = studentService.LayDanhSachSinhVienChuaDKCN();
            }
            else
            {
                frmQuanLySinhVien_Load(sender, e);
            }
        }

        private void quảnLíKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyKhoa frmQuanLyKhoa = new frmQuanLyKhoa();
            frmQuanLyKhoa.ShowDialog();
            
        }

        private void quảnLíChuyênNgànhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyChuyenNganh quanLyChuyenNganh = new frmQuanLyChuyenNganh();
            quanLyChuyenNganh.ShowDialog();
        }
    }

}
