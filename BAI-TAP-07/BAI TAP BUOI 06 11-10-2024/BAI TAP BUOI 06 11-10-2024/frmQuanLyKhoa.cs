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
    public partial class frmQuanLyKhoa : Form
    {
        private readonly FacultyService facultyService = new FacultyService();
        public frmQuanLyKhoa()
        {
            InitializeComponent();
        }

        private void frmQuanLyKhoa_Load(object sender, EventArgs e)
        {

            dgvDanhSachKhoa.AutoGenerateColumns = false;

            //Thiết lập tên cho các cột tương ứng
            dgvDanhSachKhoa.Columns[0].DataPropertyName = "FacultyID";
            dgvDanhSachKhoa.Columns[1].DataPropertyName = "FacultyName";
            dgvDanhSachKhoa.DataSource = facultyService.GetFaculty();

        }

        private void dgvDanhSachKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem có click vào dòng hợp lệ không (đảm bảo không phải dòng tiêu đề)
            if (e.RowIndex >= 0)
            {
                // Lấy dòng được chọn
                DataGridViewRow row = dgvDanhSachKhoa.Rows[e.RowIndex];

                // Gán dữ liệu từ dòng được chọn vào các TextBox
                txtTenKhoa.Text = row.Cells[1].Value?.ToString();          
            }
        }

        private void btnThemSua_Click(object sender, EventArgs e)
        {
            if (txtTenKhoa.Text == "")
            {
                MessageBox.Show("Tên Khoa không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                facultyService.AddOrUpdate(txtTenKhoa.Text);
                MessageBox.Show("Thông tin khoa đã được lưu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Làm mới DataGridView
                dgvDanhSachKhoa.DataSource = facultyService.GetFaculty();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtTenKhoa.Text == "")
            {
                MessageBox.Show("Tên Khoa không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                facultyService.Delete(txtTenKhoa.Text);
                MessageBox.Show("Thông tin khoa đã được xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Làm mới DataGridView
                dgvDanhSachKhoa.DataSource = facultyService.GetFaculty();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmQuanLyKhoa_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
