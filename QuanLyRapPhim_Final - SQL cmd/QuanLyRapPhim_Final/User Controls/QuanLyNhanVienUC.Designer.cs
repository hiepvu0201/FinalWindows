namespace QuanLyRapPhim_Final.User_Controls
{
    partial class QuanLyNhanVienUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtHovalotNV = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.dgv_NHANVIEN = new System.Windows.Forms.DataGridView();
            this.hovaLotNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maCVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioNghiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongGioNghiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyRapPhimDataSet_NHANVIEN = new QuanLyRapPhim_Final.QuanLyRapPhimDataSet_NHANVIEN();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnEditNV = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelNV = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.cbbMaCV = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblLuong = new System.Windows.Forms.Label();
            this.btnCal = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblThuNhapNam = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblGioNghi = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnQuanLy = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.lblThang = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblNghiThang = new System.Windows.Forms.Label();
            this.btnAdd1 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.lblNgay = new System.Windows.Forms.Label();
            this.nhanVienTableAdapter = new QuanLyRapPhim_Final.QuanLyRapPhimDataSet_NHANVIENTableAdapters.NhanVienTableAdapter();
            this.label14 = new System.Windows.Forms.Label();
            this.lblNghiNam = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NHANVIEN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyRapPhimDataSet_NHANVIEN)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Nhân Viên :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Họ và tên lót Nhân Viên :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên Nhân Viên :";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(229, 26);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(229, 26);
            this.txtMaNV.TabIndex = 6;
            // 
            // txtHovalotNV
            // 
            this.txtHovalotNV.Location = new System.Drawing.Point(227, 68);
            this.txtHovalotNV.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtHovalotNV.Name = "txtHovalotNV";
            this.txtHovalotNV.Size = new System.Drawing.Size(229, 26);
            this.txtHovalotNV.TabIndex = 7;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(227, 112);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(229, 26);
            this.txtTenNV.TabIndex = 8;
            // 
            // dgv_NHANVIEN
            // 
            this.dgv_NHANVIEN.AutoGenerateColumns = false;
            this.dgv_NHANVIEN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_NHANVIEN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NHANVIEN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hovaLotNVDataGridViewTextBoxColumn,
            this.tenNVDataGridViewTextBoxColumn,
            this.maNVDataGridViewTextBoxColumn,
            this.maCVDataGridViewTextBoxColumn,
            this.gioNghiDataGridViewTextBoxColumn,
            this.tongGioNghiDataGridViewTextBoxColumn});
            this.dgv_NHANVIEN.DataSource = this.nhanVienBindingSource;
            this.dgv_NHANVIEN.Location = new System.Drawing.Point(33, 442);
            this.dgv_NHANVIEN.Name = "dgv_NHANVIEN";
            this.dgv_NHANVIEN.Size = new System.Drawing.Size(725, 150);
            this.dgv_NHANVIEN.TabIndex = 9;
            this.dgv_NHANVIEN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_NHANVIEN_CellClick);
            // 
            // hovaLotNVDataGridViewTextBoxColumn
            // 
            this.hovaLotNVDataGridViewTextBoxColumn.DataPropertyName = "HovaLotNV";
            this.hovaLotNVDataGridViewTextBoxColumn.HeaderText = "HovaLotNV";
            this.hovaLotNVDataGridViewTextBoxColumn.Name = "hovaLotNVDataGridViewTextBoxColumn";
            // 
            // tenNVDataGridViewTextBoxColumn
            // 
            this.tenNVDataGridViewTextBoxColumn.DataPropertyName = "TenNV";
            this.tenNVDataGridViewTextBoxColumn.HeaderText = "TenNV";
            this.tenNVDataGridViewTextBoxColumn.Name = "tenNVDataGridViewTextBoxColumn";
            // 
            // maNVDataGridViewTextBoxColumn
            // 
            this.maNVDataGridViewTextBoxColumn.DataPropertyName = "MaNV";
            this.maNVDataGridViewTextBoxColumn.HeaderText = "MaNV";
            this.maNVDataGridViewTextBoxColumn.Name = "maNVDataGridViewTextBoxColumn";
            // 
            // maCVDataGridViewTextBoxColumn
            // 
            this.maCVDataGridViewTextBoxColumn.DataPropertyName = "MaCV";
            this.maCVDataGridViewTextBoxColumn.HeaderText = "MaCV";
            this.maCVDataGridViewTextBoxColumn.Name = "maCVDataGridViewTextBoxColumn";
            // 
            // gioNghiDataGridViewTextBoxColumn
            // 
            this.gioNghiDataGridViewTextBoxColumn.DataPropertyName = "GioNghi";
            this.gioNghiDataGridViewTextBoxColumn.HeaderText = "GioNghi";
            this.gioNghiDataGridViewTextBoxColumn.Name = "gioNghiDataGridViewTextBoxColumn";
            // 
            // tongGioNghiDataGridViewTextBoxColumn
            // 
            this.tongGioNghiDataGridViewTextBoxColumn.DataPropertyName = "TongGioNghi";
            this.tongGioNghiDataGridViewTextBoxColumn.HeaderText = "TongGioNghi";
            this.tongGioNghiDataGridViewTextBoxColumn.Name = "tongGioNghiDataGridViewTextBoxColumn";
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.quanLyRapPhimDataSet_NHANVIEN;
            // 
            // quanLyRapPhimDataSet_NHANVIEN
            // 
            this.quanLyRapPhimDataSet_NHANVIEN.DataSetName = "QuanLyRapPhimDataSet_NHANVIEN";
            this.quanLyRapPhimDataSet_NHANVIEN.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.Location = new System.Drawing.Point(518, 27);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 33);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReload
            // 
            this.btnReload.AutoSize = true;
            this.btnReload.Location = new System.Drawing.Point(518, 71);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(79, 33);
            this.btnReload.TabIndex = 17;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnEditNV
            // 
            this.btnEditNV.AutoSize = true;
            this.btnEditNV.Location = new System.Drawing.Point(518, 115);
            this.btnEditNV.Name = "btnEditNV";
            this.btnEditNV.Size = new System.Drawing.Size(240, 33);
            this.btnEditNV.TabIndex = 18;
            this.btnEditNV.Text = "Sửa Thông Tin  Nhân Viên";
            this.btnEditNV.UseVisualStyleBackColor = true;
            this.btnEditNV.Click += new System.EventHandler(this.btnEditNV_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.Location = new System.Drawing.Point(518, 160);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(67, 33);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelNV
            // 
            this.btnDelNV.AutoSize = true;
            this.btnDelNV.Location = new System.Drawing.Point(518, 206);
            this.btnDelNV.Name = "btnDelNV";
            this.btnDelNV.Size = new System.Drawing.Size(144, 33);
            this.btnDelNV.TabIndex = 20;
            this.btnDelNV.Text = "Xóa Nhân Viên";
            this.btnDelNV.UseVisualStyleBackColor = true;
            this.btnDelNV.Click += new System.EventHandler(this.btnDelNV_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.Location = new System.Drawing.Point(518, 252);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(63, 33);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 209);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 19);
            this.label4.TabIndex = 22;
            this.label4.Text = "Chức vụ : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 259);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 19);
            this.label5.TabIndex = 23;
            this.label5.Text = "Lương :";
            // 
            // txtLuong
            // 
            this.txtLuong.Enabled = false;
            this.txtLuong.Location = new System.Drawing.Point(227, 256);
            this.txtLuong.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(229, 26);
            this.txtLuong.TabIndex = 25;
            // 
            // cbbMaCV
            // 
            this.cbbMaCV.DisplayMember = "MaCV";
            this.cbbMaCV.FormattingEnabled = true;
            this.cbbMaCV.Location = new System.Drawing.Point(227, 157);
            this.cbbMaCV.Name = "cbbMaCV";
            this.cbbMaCV.Size = new System.Drawing.Size(229, 27);
            this.cbbMaCV.TabIndex = 26;
            this.cbbMaCV.ValueMember = "MaCV";
            this.cbbMaCV.SelectedIndexChanged += new System.EventHandler(this.cbbMaCV_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 19);
            this.label6.TabIndex = 27;
            this.label6.Text = "Mã chức vụ :";
            // 
            // txtChucVu
            // 
            this.txtChucVu.Enabled = false;
            this.txtChucVu.Location = new System.Drawing.Point(227, 206);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(229, 26);
            this.txtChucVu.TabIndex = 28;
            // 
            // txtName
            // 
            this.txtName.AllowDrop = true;
            this.txtName.Location = new System.Drawing.Point(170, 618);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(211, 26);
            this.txtName.TabIndex = 3;
            this.txtName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyUp);
            // 
            // lblLuong
            // 
            this.lblLuong.AutoSize = true;
            this.lblLuong.Location = new System.Drawing.Point(156, 705);
            this.lblLuong.Name = "lblLuong";
            this.lblLuong.Size = new System.Drawing.Size(17, 19);
            this.lblLuong.TabIndex = 2;
            this.lblLuong.Text = "0";
            // 
            // btnCal
            // 
            this.btnCal.AutoSize = true;
            this.btnCal.Location = new System.Drawing.Point(399, 616);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(134, 29);
            this.btnCal.TabIndex = 1;
            this.btnCal.Text = "Thống kê";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 621);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tìm nhân viên";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 705);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Lương :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(307, 705);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "Thu nhập cả năm :";
            // 
            // lblThuNhapNam
            // 
            this.lblThuNhapNam.AutoSize = true;
            this.lblThuNhapNam.Location = new System.Drawing.Point(464, 705);
            this.lblThuNhapNam.Name = "lblThuNhapNam";
            this.lblThuNhapNam.Size = new System.Drawing.Size(17, 19);
            this.lblThuNhapNam.TabIndex = 2;
            this.lblThuNhapNam.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(82, 672);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "Số giờ nghỉ :";
            // 
            // lblGioNghi
            // 
            this.lblGioNghi.AutoSize = true;
            this.lblGioNghi.Location = new System.Drawing.Point(190, 672);
            this.lblGioNghi.Name = "lblGioNghi";
            this.lblGioNghi.Size = new System.Drawing.Size(17, 19);
            this.lblGioNghi.TabIndex = 2;
            this.lblGioNghi.Text = "0";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(518, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 33);
            this.button1.TabIndex = 21;
            this.button1.Text = "Hủy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnQuanLy
            // 
            this.btnQuanLy.AutoSize = true;
            this.btnQuanLy.Location = new System.Drawing.Point(518, 301);
            this.btnQuanLy.Name = "btnQuanLy";
            this.btnQuanLy.Size = new System.Drawing.Size(143, 33);
            this.btnQuanLy.TabIndex = 21;
            this.btnQuanLy.Text = "Quản lý nhân viên ";
            this.btnQuanLy.UseVisualStyleBackColor = true;
            this.btnQuanLy.Click += new System.EventHandler(this.btnQuanLy_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 315);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 19);
            this.label11.TabIndex = 23;
            this.label11.Text = "Hôm nay là :";
            // 
            // lblThang
            // 
            this.lblThang.AutoSize = true;
            this.lblThang.Location = new System.Drawing.Point(174, 315);
            this.lblThang.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblThang.Name = "lblThang";
            this.lblThang.Size = new System.Drawing.Size(17, 19);
            this.lblThang.TabIndex = 23;
            this.lblThang.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 358);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(191, 19);
            this.label12.TabIndex = 23;
            this.label12.Text = "Số giờ nghỉ trong tháng này";
            // 
            // lblNghiThang
            // 
            this.lblNghiThang.AutoSize = true;
            this.lblNghiThang.Location = new System.Drawing.Point(260, 358);
            this.lblNghiThang.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNghiThang.Name = "lblNghiThang";
            this.lblNghiThang.Size = new System.Drawing.Size(17, 19);
            this.lblNghiThang.TabIndex = 23;
            this.lblNghiThang.Text = "0";
            // 
            // btnAdd1
            // 
            this.btnAdd1.AutoSize = true;
            this.btnAdd1.Location = new System.Drawing.Point(311, 351);
            this.btnAdd1.Name = "btnAdd1";
            this.btnAdd1.Size = new System.Drawing.Size(37, 33);
            this.btnAdd1.TabIndex = 21;
            this.btnAdd1.Text = "+1";
            this.btnAdd1.UseVisualStyleBackColor = true;
            this.btnAdd1.Click += new System.EventHandler(this.btnAdd1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(156, 315);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 19);
            this.label13.TabIndex = 23;
            this.label13.Text = "/";
            // 
            // lblNgay
            // 
            this.lblNgay.AutoSize = true;
            this.lblNgay.Location = new System.Drawing.Point(133, 315);
            this.lblNgay.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(17, 19);
            this.lblNgay.TabIndex = 23;
            this.lblNgay.Text = "0";
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(29, 399);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(182, 19);
            this.label14.TabIndex = 23;
            this.label14.Text = "Số giờ nghỉ trong năm nay";
            // 
            // lblNghiNam
            // 
            this.lblNghiNam.AutoSize = true;
            this.lblNghiNam.Location = new System.Drawing.Point(260, 399);
            this.lblNghiNam.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNghiNam.Name = "lblNghiNam";
            this.lblNghiNam.Size = new System.Drawing.Size(17, 19);
            this.lblNghiNam.TabIndex = 23;
            this.lblNghiNam.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(615, 705);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(143, 19);
            this.label15.TabIndex = 0;
            this.label15.Text = "Đơn vị : Nghìn đồng";
            // 
            // QuanLyNhanVienUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblThuNhapNam);
            this.Controls.Add(this.lblGioNghi);
            this.Controls.Add(this.lblLuong);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.txtChucVu);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbbMaCV);
            this.Controls.Add(this.txtLuong);
            this.Controls.Add(this.lblNghiNam);
            this.Controls.Add(this.lblNghiThang);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblNgay);
            this.Controls.Add(this.lblThang);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAdd1);
            this.Controls.Add(this.btnQuanLy);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelNV);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEditNV);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgv_NHANVIEN);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.txtHovalotNV);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuanLyNhanVienUC";
            this.Size = new System.Drawing.Size(896, 1200);
            this.Load += new System.EventHandler(this.QuanLyNhanVienUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NHANVIEN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyRapPhimDataSet_NHANVIEN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtHovalotNV;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.DataGridView dgv_NHANVIEN;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnEditNV;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelNV;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.ComboBox cbbMaCV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblLuong;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblThuNhapNam;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblGioNghi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnQuanLy;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblThang;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblNghiThang;
        private System.Windows.Forms.Button btnAdd1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn hovaLotNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maCVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioNghiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongGioNghiDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private QuanLyRapPhimDataSet_NHANVIEN quanLyRapPhimDataSet_NHANVIEN;
        private QuanLyRapPhimDataSet_NHANVIENTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblNghiNam;
        private System.Windows.Forms.Label label15;
    }
}