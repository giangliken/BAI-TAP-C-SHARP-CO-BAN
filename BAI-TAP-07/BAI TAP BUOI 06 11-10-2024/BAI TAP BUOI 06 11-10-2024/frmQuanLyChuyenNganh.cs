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

namespace BAI_TAP_BUOI_06_11_10_2024
{
    public partial class frmQuanLyChuyenNganh : Form
    {
        private readonly FacultyService facultyService = new FacultyService();
        private readonly MajorService majorService = new MajorService();
        public frmQuanLyChuyenNganh()
        {
            InitializeComponent();
        }

        private void frmQuanLyChuyenNganh_Load(object sender, EventArgs e)
        {
            cbbKhoa.DataSource = facultyService.GetFaculty();
            cbbKhoa.DisplayMember = "FacultyName";
            cbbKhoa.ValueMember = "FacultyID";

            LoadMajorsIntoDataGridView();
        }

        private void cbbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void btnThemSua_Click(object sender, EventArgs e)
        {
            // Lấy FacultyID từ combobox cbbKhoa
            int facultyID = (int)cbbKhoa.SelectedValue;

            // Lấy tên chuyên ngành từ textbox (giả sử bạn có textbox để nhập tên chuyên ngành)
            string majorName = txtTenCN.Text;

            if (!string.IsNullOrWhiteSpace(majorName))
            {
                // Gọi phương thức thêm chuyên ngành
                bool success = majorService.AddMajor(facultyID, majorName);

                if (success)
                {
                    MessageBox.Show("Thêm chuyên ngành thành công!");
                    // Cập nhật lại danh sách chuyên ngành (nếu có)
                }
                else
                {
                    MessageBox.Show("Thêm chuyên ngành thất bại.");
                }
                LoadMajorsIntoDataGridView();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên chuyên ngành.");
            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (cbbKhoa.Text == "")
            {
                MessageBox.Show("Tên Khoa không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtTenCN.Text == "")
            {
                MessageBox.Show("Tên chuyên ngành không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            try
            {
                majorService.DeleteMajorByName(txtTenCN.Text);
                MessageBox.Show("Thông tin khoa đã được xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Làm mới DataGridView
                frmQuanLyChuyenNganh_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvDanhSachChuyenNganh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtTenCN_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoadMajorsIntoDataGridView()
        {
            // Lấy danh sách MajorDTO từ MajorService
            var majors = majorService.GetAllMajorsWithFaculty();

            // Xóa dữ liệu cũ (nếu có) trước khi thêm dữ liệu mới
            dgvDanhSachChuyenNganh.Rows.Clear();

            // Đổ dữ liệu vào DataGridView
            foreach (var major in majors)
            {
                dgvDanhSachChuyenNganh.Rows.Add(major.FacultyName, major.MajorID, major.MajorName);
            }
        }

        private void dgvDanhSachChuyenNganh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem có click vào dòng hợp lệ không (đảm bảo không phải dòng tiêu đề)
            if (e.RowIndex >= 0)
            {
                // Lấy dòng được chọn
                DataGridViewRow row = dgvDanhSachChuyenNganh.Rows[e.RowIndex];

                // Gán dữ liệu từ dòng được chọn vào các TextBox
                cbbKhoa.Text = row.Cells[0].Value?.ToString();
                txtTenCN.Text=row.Cells[2].Value?.ToString();
            }
        }
    }
}
