using De02.Database;
using De02_BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De02
{
    public partial class frmSanPham : Form
    {
        private readonly DanhMucService danhMucService = new DanhMucService();
        public frmSanPham()
        {
            InitializeComponent();
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";

            LoadData();
        }

        private void LoadData()
        {
            try
            {
                List<SANPHAM> danhSachSanPham = danhMucService.GetAllSanPham();
                List<LOAISP> danhSachLoaiSP = danhMucService.GetAllLoaiSP();

                var danhSachSP = danhSachSanPham
                    .Join(danhSachLoaiSP, sp => sp.MALOAI, lsp => lsp.MALOAI, (sp, lsp) => new
                    {
                        MASP = sp.MASP,
                        TENSP = sp.TENSP,
                        NGAYNHAP = sp.NGAYNHAP,
                        TENLOAI = lsp.TENLOAI
                    })
                    .ToList();

                dgvSanPham.DataSource = danhSachSP;

                // Đổi tên cột
                dgvSanPham.Columns[0].HeaderText = "Mã SP";
                dgvSanPham.Columns[1].HeaderText = "Tên SP";
                dgvSanPham.Columns[2].HeaderText = "Ngày Nhập";
                dgvSanPham.Columns[3].HeaderText = "Loại SP";

                // Đổ dữ liệu vào cboLoaiSP
                cboLoaiSP.DataSource = danhSachLoaiSP;
                cboLoaiSP.DisplayMember = "TENLOAI";
                cboLoaiSP.ValueMember = "MALOAI";

                dgvSanPham.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtMaSP_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenSP_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cboLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dgvSanPham.Rows[e.RowIndex];
                if (row.Cells[0].Value != null)
                {
                    txtMaSP.Text = row.Cells[0].Value.ToString();
                }
                if (row.Cells[1].Value != null)
                {
                    txtTenSP.Text = row.Cells[1].Value.ToString();
                }
                if (row.Cells[2].Value != null)
                {
                    dateTimePicker1.Value = Convert.ToDateTime(row.Cells[2].Value);
                }
                if (row.Cells[3].Value != null)
                {
                    string value = row.Cells[3].Value.ToString();
                    foreach (LOAISP item in cboLoaiSP.Items)
                    {
                        if (item.TENLOAI == value)
                        {
                            cboLoaiSP.SelectedItem = item;
                            break;
                        }
                    }
                }
            }
        }





        private void frmSanPham_MouseClick(object sender, MouseEventArgs e)
        {
            
                txtMaSP.Text = "";
                txtTenSP.Text = "";
                dateTimePicker1.Value = DateTime.Now;
                cboLoaiSP.SelectedIndex = -1;
           
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                SANPHAM sanPham = new SANPHAM
                {
                    MASP = txtMaSP.Text,
                    TENSP = txtTenSP.Text,
                    NGAYNHAP = dateTimePicker1.Value,
                    MALOAI = cboLoaiSP.SelectedValue.ToString()
                };

                danhMucService.AddSanPham(sanPham);
                MessageBox.Show("Thêm mới sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                SANPHAM sanPham = new SANPHAM
                {
                    MASP = txtMaSP.Text,
                    TENSP = txtTenSP.Text,
                    NGAYNHAP = dateTimePicker1.Value,
                    MALOAI = cboLoaiSP.SelectedValue.ToString()
                };

                danhMucService.UpdateSanPham(sanPham);
                MessageBox.Show("Sửa sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaSP.Text))
                {
                    MessageBox.Show("Vui lòng nhập mã sản phẩm để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }

                danhMucService.DeleteSanPham(txtMaSP.Text);
                MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string search = txtSearch.Text.ToLower();
                List<SANPHAM> danhSachSanPham = danhMucService.SearchSanPham(search);
                List<LOAISP> danhSachLoaiSP = danhMucService.GetAllLoaiSP();

                var danhSachSP = danhSachSanPham
                    .Join(danhSachLoaiSP, sp => sp.MALOAI, lsp => lsp.MALOAI, (sp, lsp) => new
                    {
                        MASP = sp.MASP,
                        TENSP = sp.TENSP,
                        NGAYNHAP = sp.NGAYNHAP,
                        TENLOAI = lsp.TENLOAI
                    })
                    .ToList();

                dgvSanPham.DataSource = danhSachSP;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ClearInputs()
        {
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            cboLoaiSP.SelectedIndex = -1;
            txtSearch.Text = "";
        }

        private void btLuu_Click(object sender, EventArgs e)
        {

        }

        private void btKLuu_Click(object sender, EventArgs e)
        {

        }
    }
}
