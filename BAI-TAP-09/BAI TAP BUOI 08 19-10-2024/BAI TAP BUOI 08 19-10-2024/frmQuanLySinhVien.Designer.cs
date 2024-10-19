namespace BAI_TAP_BUOI_08_19_10_2024
{
    partial class frmQuanLySinhVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiDataGridView1 = new Sunny.UI.UIDataGridView();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.txtMaSinhVien = new Sunny.UI.UITextBox();
            this.txtTenSinhVien = new Sunny.UI.UITextBox();
            this.txtTuoi = new Sunny.UI.UITextBox();
            this.txtChuyenNganh = new Sunny.UI.UITextBox();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnThem = new Sunny.UI.UIButton();
            this.btnSua = new Sunny.UI.UIButton();
            this.btnXoa = new Sunny.UI.UIButton();
            this.studentBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.studentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.schoolDBDataSet = new BAI_TAP_BUOI_08_19_10_2024.SchoolDBDataSet();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.majorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentTableAdapter = new BAI_TAP_BUOI_08_19_10_2024.SchoolDBDataSetTableAdapters.StudentTableAdapter();
            this.btnNext = new Sunny.UI.UIButton();
            this.btnPrevious = new Sunny.UI.UIButton();
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.uiLabel1.Location = new System.Drawing.Point(382, 25);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(520, 62);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "QUẢN LÝ SINH VIÊN";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel2.Location = new System.Drawing.Point(22, 135);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(254, 37);
            this.uiLabel2.TabIndex = 1;
            this.uiLabel2.Text = "Thông tin sinh viên";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiDataGridView1
            // 
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.uiDataGridView1.AutoGenerateColumns = false;
            this.uiDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.uiDataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.uiDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.uiDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.uiDataGridView1.ColumnHeadersHeight = 32;
            this.uiDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.uiDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIDDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.majorDataGridViewTextBoxColumn});
            this.uiDataGridView1.DataSource = this.studentBindingSource1;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.uiDataGridView1.DefaultCellStyle = dataGridViewCellStyle13;
            this.uiDataGridView1.EnableHeadersVisualStyles = false;
            this.uiDataGridView1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.Location = new System.Drawing.Point(558, 135);
            this.uiDataGridView1.Name = "uiDataGridView1";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uiDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.uiDataGridView1.RowHeadersWidth = 51;
            this.uiDataGridView1.RowHeight = 0;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.uiDataGridView1.RowTemplate.Height = 24;
            this.uiDataGridView1.SelectedIndex = -1;
            this.uiDataGridView1.ShowGridLine = false;
            this.uiDataGridView1.ShowRect = false;
            this.uiDataGridView1.Size = new System.Drawing.Size(692, 526);
            this.uiDataGridView1.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.uiDataGridView1.TabIndex = 2;
            this.uiDataGridView1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.uiDataGridView1_CellContentClick);
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel3.Location = new System.Drawing.Point(41, 189);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(148, 31);
            this.uiLabel3.TabIndex = 3;
            this.uiLabel3.Text = "Mã sinh viên";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel4.Location = new System.Drawing.Point(41, 240);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(148, 31);
            this.uiLabel4.TabIndex = 4;
            this.uiLabel4.Text = "Tên sinh viên";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel4.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel5.Location = new System.Drawing.Point(41, 293);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(100, 31);
            this.uiLabel5.TabIndex = 5;
            this.uiLabel5.Text = "Tuổi";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel5.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel6
            // 
            this.uiLabel6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLabel6.Location = new System.Drawing.Point(41, 347);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(100, 31);
            this.uiLabel6.TabIndex = 6;
            this.uiLabel6.Text = "Ngành";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel6.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // txtMaSinhVien
            // 
            this.txtMaSinhVien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaSinhVien.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource1, "StudentID", true));
            this.txtMaSinhVien.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSinhVien.Location = new System.Drawing.Point(196, 177);
            this.txtMaSinhVien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaSinhVien.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtMaSinhVien.Name = "txtMaSinhVien";
            this.txtMaSinhVien.ShowText = false;
            this.txtMaSinhVien.Size = new System.Drawing.Size(344, 42);
            this.txtMaSinhVien.TabIndex = 7;
            this.txtMaSinhVien.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtMaSinhVien.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // txtTenSinhVien
            // 
            this.txtTenSinhVien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenSinhVien.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource1, "FullName", true));
            this.txtTenSinhVien.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSinhVien.Location = new System.Drawing.Point(196, 229);
            this.txtTenSinhVien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenSinhVien.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtTenSinhVien.Name = "txtTenSinhVien";
            this.txtTenSinhVien.ShowText = false;
            this.txtTenSinhVien.Size = new System.Drawing.Size(344, 42);
            this.txtTenSinhVien.TabIndex = 8;
            this.txtTenSinhVien.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtTenSinhVien.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // txtTuoi
            // 
            this.txtTuoi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTuoi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource1, "Age", true));
            this.txtTuoi.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTuoi.Location = new System.Drawing.Point(196, 282);
            this.txtTuoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTuoi.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtTuoi.Name = "txtTuoi";
            this.txtTuoi.ShowText = false;
            this.txtTuoi.Size = new System.Drawing.Size(344, 42);
            this.txtTuoi.TabIndex = 8;
            this.txtTuoi.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtTuoi.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // txtChuyenNganh
            // 
            this.txtChuyenNganh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtChuyenNganh.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentBindingSource1, "Major", true));
            this.txtChuyenNganh.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChuyenNganh.Location = new System.Drawing.Point(196, 336);
            this.txtChuyenNganh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtChuyenNganh.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtChuyenNganh.Name = "txtChuyenNganh";
            this.txtChuyenNganh.ShowText = false;
            this.txtChuyenNganh.Size = new System.Drawing.Size(344, 42);
            this.txtChuyenNganh.TabIndex = 8;
            this.txtChuyenNganh.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtChuyenNganh.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(DAL.Database.Student);
            // 
            // btnThem
            // 
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnThem.Location = new System.Drawing.Point(77, 472);
            this.btnThem.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 35);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.FillColor = System.Drawing.Color.LightGreen;
            this.btnSua.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.Location = new System.Drawing.Point(236, 472);
            this.btnSua.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 35);
            this.btnSua.Style = Sunny.UI.UIStyle.Custom;
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sửa";
            this.btnSua.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FillColor = System.Drawing.Color.SandyBrown;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Location = new System.Drawing.Point(387, 472);
            this.btnXoa.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 35);
            this.btnXoa.Style = Sunny.UI.UIStyle.Custom;
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // studentBindingSource2
            // 
            this.studentBindingSource2.DataSource = typeof(DAL.Database.Student);
            // 
            // studentBindingSource1
            // 
            this.studentBindingSource1.DataMember = "Student";
            this.studentBindingSource1.DataSource = this.schoolDBDataSet;
            // 
            // schoolDBDataSet
            // 
            this.schoolDBDataSet.DataSetName = "SchoolDBDataSet";
            this.schoolDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // majorDataGridViewTextBoxColumn
            // 
            this.majorDataGridViewTextBoxColumn.DataPropertyName = "Major";
            this.majorDataGridViewTextBoxColumn.HeaderText = "Major";
            this.majorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.majorDataGridViewTextBoxColumn.Name = "majorDataGridViewTextBoxColumn";
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // btnNext
            // 
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnNext.Location = new System.Drawing.Point(558, 94);
            this.btnNext.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(100, 35);
            this.btnNext.TabIndex = 12;
            this.btnNext.Text = "Next";
            this.btnNext.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnPrevious.Location = new System.Drawing.Point(704, 94);
            this.btnPrevious.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(100, 35);
            this.btnPrevious.TabIndex = 13;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // frmQuanLySinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtChuyenNganh);
            this.Controls.Add(this.txtTuoi);
            this.Controls.Add(this.txtTenSinhVien);
            this.Controls.Add(this.txtMaSinhVien);
            this.Controls.Add(this.uiLabel6);
            this.Controls.Add(this.uiLabel5);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiDataGridView1);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmQuanLySinhVien";
            this.Text = "QUẢN LÝ SINH VIÊN";
            this.Load += new System.EventHandler(this.frmQuanLySinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIDataGridView uiDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn majorDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UITextBox txtMaSinhVien;
        private Sunny.UI.UITextBox txtTenSinhVien;
        private Sunny.UI.UITextBox txtTuoi;
        private Sunny.UI.UITextBox txtChuyenNganh;
        private SchoolDBDataSet schoolDBDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource1;
        private SchoolDBDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private Sunny.UI.UIButton btnThem;
        private Sunny.UI.UIButton btnSua;
        private Sunny.UI.UIButton btnXoa;
        private System.Windows.Forms.BindingSource studentBindingSource2;
        private Sunny.UI.UIButton btnNext;
        private Sunny.UI.UIButton btnPrevious;
    }
}

