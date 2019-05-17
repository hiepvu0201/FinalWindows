namespace QuanLyRapPhim_Final.User_Controls
{
    partial class QuanLyRapUC
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
            this.txtMaRap = new System.Windows.Forms.TextBox();
            this.txtSoDayGhe = new System.Windows.Forms.TextBox();
            this.txtSoLuongGhe = new System.Windows.Forms.TextBox();
            this.dgv_RAP = new System.Windows.Forms.DataGridView();
            this.maRapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDayGheDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongGheDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiPhimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyRapPhimDataSet_RAP = new QuanLyRapPhim_Final.QuanLyRapPhimDataSet_RAP();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLoaiPhim = new System.Windows.Forms.TextBox();
            this.rapTableAdapter = new QuanLyRapPhim_Final.QuanLyRapPhimDataSet_RAPTableAdapters.RapTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RAP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyRapPhimDataSet_RAP)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Rạp :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Số dãy ghế :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Số lượng ghế :";
            // 
            // txtMaRap
            // 
            this.txtMaRap.Location = new System.Drawing.Point(229, 26);
            this.txtMaRap.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtMaRap.Name = "txtMaRap";
            this.txtMaRap.Size = new System.Drawing.Size(229, 26);
            this.txtMaRap.TabIndex = 8;
            // 
            // txtSoDayGhe
            // 
            this.txtSoDayGhe.Location = new System.Drawing.Point(229, 68);
            this.txtSoDayGhe.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtSoDayGhe.Name = "txtSoDayGhe";
            this.txtSoDayGhe.Size = new System.Drawing.Size(229, 26);
            this.txtSoDayGhe.TabIndex = 9;
            // 
            // txtSoLuongGhe
            // 
            this.txtSoLuongGhe.Location = new System.Drawing.Point(229, 111);
            this.txtSoLuongGhe.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtSoLuongGhe.Name = "txtSoLuongGhe";
            this.txtSoLuongGhe.Size = new System.Drawing.Size(229, 26);
            this.txtSoLuongGhe.TabIndex = 10;
            // 
            // dgv_RAP
            // 
            this.dgv_RAP.AutoGenerateColumns = false;
            this.dgv_RAP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_RAP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maRapDataGridViewTextBoxColumn,
            this.soDayGheDataGridViewTextBoxColumn,
            this.soLuongGheDataGridViewTextBoxColumn,
            this.loaiPhimDataGridViewTextBoxColumn});
            this.dgv_RAP.DataSource = this.rapBindingSource;
            this.dgv_RAP.Location = new System.Drawing.Point(33, 216);
            this.dgv_RAP.Name = "dgv_RAP";
            this.dgv_RAP.Size = new System.Drawing.Size(443, 150);
            this.dgv_RAP.TabIndex = 12;
            this.dgv_RAP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_RAP_CellClick);
            // 
            // maRapDataGridViewTextBoxColumn
            // 
            this.maRapDataGridViewTextBoxColumn.DataPropertyName = "MaRap";
            this.maRapDataGridViewTextBoxColumn.HeaderText = "MaRap";
            this.maRapDataGridViewTextBoxColumn.Name = "maRapDataGridViewTextBoxColumn";
            // 
            // soDayGheDataGridViewTextBoxColumn
            // 
            this.soDayGheDataGridViewTextBoxColumn.DataPropertyName = "SoDayGhe";
            this.soDayGheDataGridViewTextBoxColumn.HeaderText = "SoDayGhe";
            this.soDayGheDataGridViewTextBoxColumn.Name = "soDayGheDataGridViewTextBoxColumn";
            // 
            // soLuongGheDataGridViewTextBoxColumn
            // 
            this.soLuongGheDataGridViewTextBoxColumn.DataPropertyName = "SoLuongGhe";
            this.soLuongGheDataGridViewTextBoxColumn.HeaderText = "SoLuongGhe";
            this.soLuongGheDataGridViewTextBoxColumn.Name = "soLuongGheDataGridViewTextBoxColumn";
            // 
            // loaiPhimDataGridViewTextBoxColumn
            // 
            this.loaiPhimDataGridViewTextBoxColumn.DataPropertyName = "LoaiPhim";
            this.loaiPhimDataGridViewTextBoxColumn.HeaderText = "LoaiPhim";
            this.loaiPhimDataGridViewTextBoxColumn.Name = "loaiPhimDataGridViewTextBoxColumn";
            // 
            // rapBindingSource
            // 
            this.rapBindingSource.DataMember = "Rap";
            this.rapBindingSource.DataSource = this.quanLyRapPhimDataSet_RAP;
            // 
            // quanLyRapPhimDataSet_RAP
            // 
            this.quanLyRapPhimDataSet_RAP.DataSetName = "QuanLyRapPhimDataSet_RAP";
            this.quanLyRapPhimDataSet_RAP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(535, 26);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 35);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click_1);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(535, 81);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 35);
            this.btnDel.TabIndex = 14;
            this.btnDel.Text = "Xoá";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(535, 135);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 35);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(535, 189);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 35);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Huỷ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(535, 244);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 35);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 160);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 19);
            this.label4.TabIndex = 18;
            this.label4.Text = "Loại phim :";
            // 
            // txtLoaiPhim
            // 
            this.txtLoaiPhim.Location = new System.Drawing.Point(229, 157);
            this.txtLoaiPhim.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtLoaiPhim.Name = "txtLoaiPhim";
            this.txtLoaiPhim.Size = new System.Drawing.Size(229, 26);
            this.txtLoaiPhim.TabIndex = 19;
            // 
            // rapTableAdapter
            // 
            this.rapTableAdapter.ClearBeforeFill = true;
            // 
            // QuanLyRapUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtLoaiPhim);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgv_RAP);
            this.Controls.Add(this.txtSoLuongGhe);
            this.Controls.Add(this.txtSoDayGhe);
            this.Controls.Add(this.txtMaRap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuanLyRapUC";
            this.Size = new System.Drawing.Size(896, 1200);
            this.Load += new System.EventHandler(this.QuanLyRapUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RAP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyRapPhimDataSet_RAP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaRap;
        private System.Windows.Forms.TextBox txtSoDayGhe;
        private System.Windows.Forms.TextBox txtSoLuongGhe;
        private System.Windows.Forms.DataGridView dgv_RAP;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn maRapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDayGheDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongGheDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiPhimDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource rapBindingSource;
        private QuanLyRapPhimDataSet_RAP quanLyRapPhimDataSet_RAP;
        private System.Windows.Forms.TextBox txtLoaiPhim;
        private QuanLyRapPhimDataSet_RAPTableAdapters.RapTableAdapter rapTableAdapter;
    }
}