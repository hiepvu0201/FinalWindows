namespace QuanLyRapPhim_Final
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlClick = new System.Windows.Forms.Panel();
            this.btnQuanLySuatChieu = new System.Windows.Forms.Button();
            this.btnChucVuNhanVien = new System.Windows.Forms.Button();
            this.btnDatVe = new System.Windows.Forms.Button();
            this.btnQuanLyRap = new System.Windows.Forms.Button();
            this.btnQuanLyNhanVien = new System.Windows.Forms.Button();
            this.btnQuanLyKhachHang = new System.Windows.Forms.Button();
            this.btnQuanLyPhim = new System.Windows.Forms.Button();
            this.btnWelcome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.quanLySuatChieuUC1 = new QuanLyRapPhim_Final.User_Controls.QuanLySuatChieuUC();
            this.chucVuUC1 = new QuanLyRapPhim_Final.User_Controls.ChucVuUC();
            this.welcomeUC1 = new QuanLyRapPhim_Final.User_Controls.WelcomeUC();
            this.quanLyRapUC1 = new QuanLyRapPhim_Final.User_Controls.QuanLyRapUC();
            this.quanLyNhanVienUC1 = new QuanLyRapPhim_Final.User_Controls.QuanLyNhanVienUC();
            this.quanLyKhachHangUC1 = new QuanLyRapPhim_Final.User_Controls.QuanLyKhachHangUC();
            this.phimUC1 = new QuanLyRapPhim_Final.User_Controls.PhimUC();
            this.datVeUC1 = new QuanLyRapPhim_Final.User_Controls.DatVeUC();
            this.label1 = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.pnlClick);
            this.panel1.Controls.Add(this.btnQuanLySuatChieu);
            this.panel1.Controls.Add(this.btnChucVuNhanVien);
            this.panel1.Controls.Add(this.btnDatVe);
            this.panel1.Controls.Add(this.btnQuanLyRap);
            this.panel1.Controls.Add(this.btnQuanLyNhanVien);
            this.panel1.Controls.Add(this.btnQuanLyKhachHang);
            this.panel1.Controls.Add(this.btnQuanLyPhim);
            this.panel1.Controls.Add(this.btnWelcome);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 1100);
            this.panel1.TabIndex = 0;
            // 
            // pnlClick
            // 
            this.pnlClick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pnlClick.Location = new System.Drawing.Point(3, 117);
            this.pnlClick.Name = "pnlClick";
            this.pnlClick.Size = new System.Drawing.Size(18, 58);
            this.pnlClick.TabIndex = 10;
            // 
            // btnQuanLySuatChieu
            // 
            this.btnQuanLySuatChieu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnQuanLySuatChieu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuanLySuatChieu.ForeColor = System.Drawing.Color.Indigo;
            this.btnQuanLySuatChieu.Location = new System.Drawing.Point(3, 565);
            this.btnQuanLySuatChieu.Name = "btnQuanLySuatChieu";
            this.btnQuanLySuatChieu.Size = new System.Drawing.Size(216, 58);
            this.btnQuanLySuatChieu.TabIndex = 9;
            this.btnQuanLySuatChieu.Text = "Quản lý suất chiếu";
            this.btnQuanLySuatChieu.UseVisualStyleBackColor = false;
            this.btnQuanLySuatChieu.Click += new System.EventHandler(this.btnQuanLySuatChieu_Click);
            // 
            // btnChucVuNhanVien
            // 
            this.btnChucVuNhanVien.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnChucVuNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChucVuNhanVien.ForeColor = System.Drawing.Color.Indigo;
            this.btnChucVuNhanVien.Location = new System.Drawing.Point(3, 501);
            this.btnChucVuNhanVien.Name = "btnChucVuNhanVien";
            this.btnChucVuNhanVien.Size = new System.Drawing.Size(216, 58);
            this.btnChucVuNhanVien.TabIndex = 6;
            this.btnChucVuNhanVien.Text = "Chức vụ nhân viên";
            this.btnChucVuNhanVien.UseVisualStyleBackColor = false;
            this.btnChucVuNhanVien.Click += new System.EventHandler(this.btnChucVuNhanVien_Click);
            // 
            // btnDatVe
            // 
            this.btnDatVe.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDatVe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDatVe.ForeColor = System.Drawing.Color.Indigo;
            this.btnDatVe.Location = new System.Drawing.Point(3, 437);
            this.btnDatVe.Name = "btnDatVe";
            this.btnDatVe.Size = new System.Drawing.Size(216, 58);
            this.btnDatVe.TabIndex = 3;
            this.btnDatVe.Text = "Đặt vé";
            this.btnDatVe.UseVisualStyleBackColor = false;
            this.btnDatVe.Click += new System.EventHandler(this.btnDatVe_Click);
            // 
            // btnQuanLyRap
            // 
            this.btnQuanLyRap.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnQuanLyRap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuanLyRap.ForeColor = System.Drawing.Color.Indigo;
            this.btnQuanLyRap.Location = new System.Drawing.Point(3, 373);
            this.btnQuanLyRap.Name = "btnQuanLyRap";
            this.btnQuanLyRap.Size = new System.Drawing.Size(216, 58);
            this.btnQuanLyRap.TabIndex = 3;
            this.btnQuanLyRap.Text = "Quản lý rạp";
            this.btnQuanLyRap.UseVisualStyleBackColor = false;
            this.btnQuanLyRap.Click += new System.EventHandler(this.btnQuanLyRap_Click);
            // 
            // btnQuanLyNhanVien
            // 
            this.btnQuanLyNhanVien.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnQuanLyNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuanLyNhanVien.ForeColor = System.Drawing.Color.Indigo;
            this.btnQuanLyNhanVien.Location = new System.Drawing.Point(3, 309);
            this.btnQuanLyNhanVien.Name = "btnQuanLyNhanVien";
            this.btnQuanLyNhanVien.Size = new System.Drawing.Size(216, 58);
            this.btnQuanLyNhanVien.TabIndex = 3;
            this.btnQuanLyNhanVien.Text = "Quản lý nhân viên";
            this.btnQuanLyNhanVien.UseVisualStyleBackColor = false;
            this.btnQuanLyNhanVien.Click += new System.EventHandler(this.btnQuanLyNhanVien_Click);
            // 
            // btnQuanLyKhachHang
            // 
            this.btnQuanLyKhachHang.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnQuanLyKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuanLyKhachHang.ForeColor = System.Drawing.Color.Indigo;
            this.btnQuanLyKhachHang.Location = new System.Drawing.Point(3, 245);
            this.btnQuanLyKhachHang.Name = "btnQuanLyKhachHang";
            this.btnQuanLyKhachHang.Size = new System.Drawing.Size(216, 58);
            this.btnQuanLyKhachHang.TabIndex = 3;
            this.btnQuanLyKhachHang.Text = "Quản lý khách hàng";
            this.btnQuanLyKhachHang.UseVisualStyleBackColor = false;
            this.btnQuanLyKhachHang.Click += new System.EventHandler(this.btnQuanLyKhachHang_Click);
            // 
            // btnQuanLyPhim
            // 
            this.btnQuanLyPhim.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnQuanLyPhim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuanLyPhim.ForeColor = System.Drawing.Color.Indigo;
            this.btnQuanLyPhim.Location = new System.Drawing.Point(3, 181);
            this.btnQuanLyPhim.Name = "btnQuanLyPhim";
            this.btnQuanLyPhim.Size = new System.Drawing.Size(216, 58);
            this.btnQuanLyPhim.TabIndex = 1;
            this.btnQuanLyPhim.Text = "Phim đang chiếu";
            this.btnQuanLyPhim.UseVisualStyleBackColor = false;
            this.btnQuanLyPhim.Click += new System.EventHandler(this.btnQuanLyPhim_Click);
            // 
            // btnWelcome
            // 
            this.btnWelcome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnWelcome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnWelcome.ForeColor = System.Drawing.Color.Indigo;
            this.btnWelcome.Location = new System.Drawing.Point(3, 117);
            this.btnWelcome.Name = "btnWelcome";
            this.btnWelcome.Size = new System.Drawing.Size(216, 58);
            this.btnWelcome.TabIndex = 1;
            this.btnWelcome.Text = "Welcome";
            this.btnWelcome.UseVisualStyleBackColor = false;
            this.btnWelcome.Click += new System.EventHandler(this.btnWelcome_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.quanLySuatChieuUC1);
            this.panel2.Controls.Add(this.chucVuUC1);
            this.panel2.Controls.Add(this.welcomeUC1);
            this.panel2.Controls.Add(this.quanLyRapUC1);
            this.panel2.Controls.Add(this.quanLyNhanVienUC1);
            this.panel2.Controls.Add(this.quanLyKhachHangUC1);
            this.panel2.Controls.Add(this.phimUC1);
            this.panel2.Controls.Add(this.datVeUC1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panelHeader);
            this.panel2.Location = new System.Drawing.Point(228, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(905, 1100);
            this.panel2.TabIndex = 1;
            // 
            // quanLySuatChieuUC1
            // 
            this.quanLySuatChieuUC1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.quanLySuatChieuUC1.Location = new System.Drawing.Point(4, 116);
            this.quanLySuatChieuUC1.Margin = new System.Windows.Forms.Padding(4);
            this.quanLySuatChieuUC1.Name = "quanLySuatChieuUC1";
            this.quanLySuatChieuUC1.Size = new System.Drawing.Size(1792, 1102);
            this.quanLySuatChieuUC1.TabIndex = 11;
            // 
            // chucVuUC1
            // 
            this.chucVuUC1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.chucVuUC1.Location = new System.Drawing.Point(0, 116);
            this.chucVuUC1.Margin = new System.Windows.Forms.Padding(4);
            this.chucVuUC1.Name = "chucVuUC1";
            this.chucVuUC1.Size = new System.Drawing.Size(1792, 1102);
            this.chucVuUC1.TabIndex = 10;
            // 
            // welcomeUC1
            // 
            this.welcomeUC1.Location = new System.Drawing.Point(1, 116);
            this.welcomeUC1.Name = "welcomeUC1";
            this.welcomeUC1.Size = new System.Drawing.Size(858, 617);
            this.welcomeUC1.TabIndex = 9;
            // 
            // quanLyRapUC1
            // 
            this.quanLyRapUC1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quanLyRapUC1.Location = new System.Drawing.Point(1, 116);
            this.quanLyRapUC1.Margin = new System.Windows.Forms.Padding(4);
            this.quanLyRapUC1.Name = "quanLyRapUC1";
            this.quanLyRapUC1.Size = new System.Drawing.Size(1195, 754);
            this.quanLyRapUC1.TabIndex = 8;
            // 
            // quanLyNhanVienUC1
            // 
            this.quanLyNhanVienUC1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quanLyNhanVienUC1.Location = new System.Drawing.Point(1, 116);
            this.quanLyNhanVienUC1.Margin = new System.Windows.Forms.Padding(4);
            this.quanLyNhanVienUC1.Name = "quanLyNhanVienUC1";
            this.quanLyNhanVienUC1.Size = new System.Drawing.Size(1195, 754);
            this.quanLyNhanVienUC1.TabIndex = 7;
            // 
            // quanLyKhachHangUC1
            // 
            this.quanLyKhachHangUC1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quanLyKhachHangUC1.Location = new System.Drawing.Point(1, 118);
            this.quanLyKhachHangUC1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.quanLyKhachHangUC1.Name = "quanLyKhachHangUC1";
            this.quanLyKhachHangUC1.Size = new System.Drawing.Size(1195, 754);
            this.quanLyKhachHangUC1.TabIndex = 6;
            // 
            // phimUC1
            // 
            this.phimUC1.Location = new System.Drawing.Point(1, 117);
            this.phimUC1.Name = "phimUC1";
            this.phimUC1.Size = new System.Drawing.Size(896, 918);
            this.phimUC1.TabIndex = 5;
            // 
            // datVeUC1
            // 
            this.datVeUC1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.datVeUC1.Location = new System.Drawing.Point(1, 116);
            this.datVeUC1.Margin = new System.Windows.Forms.Padding(4);
            this.datVeUC1.Name = "datVeUC1";
            this.datVeUC1.Size = new System.Drawing.Size(896, 613);
            this.datVeUC1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(1, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(896, 61);
            this.label1.TabIndex = 3;
            this.label1.Text = "PHẦN MỀM QUẢN LÝ RẠP PHIM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.ForestGreen;
            this.panelHeader.Controls.Add(this.pbClose);
            this.panelHeader.Controls.Add(this.lblHeader);
            this.panelHeader.Location = new System.Drawing.Point(1, 62);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(896, 49);
            this.panelHeader.TabIndex = 1;
            // 
            // pbClose
            // 
            this.pbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
            this.pbClose.Location = new System.Drawing.Point(813, -1);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(57, 47);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClose.TabIndex = 1;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.White;
            this.lblHeader.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(343, 6);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(152, 40);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Welcome";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1130, 749);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnWelcome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnQuanLyKhachHang;
        private System.Windows.Forms.Button btnQuanLyNhanVien;
        private System.Windows.Forms.Button btnQuanLyRap;
        private System.Windows.Forms.Button btnDatVe;
        private System.Windows.Forms.Button btnQuanLyPhim;
        private User_Controls.PhimUC phimUC1;
        private User_Controls.DatVeUC datVeUC1;
        private User_Controls.WelcomeUC welcomeUC1;
        private User_Controls.QuanLyRapUC quanLyRapUC1;
        private User_Controls.QuanLyNhanVienUC quanLyNhanVienUC1;
        private User_Controls.QuanLyKhachHangUC quanLyKhachHangUC1;
        private System.Windows.Forms.Button btnChucVuNhanVien;
        private User_Controls.ChucVuUC chucVuUC1;
        private System.Windows.Forms.Button btnQuanLySuatChieu;
        private User_Controls.QuanLySuatChieuUC quanLySuatChieuUC1;
        private System.Windows.Forms.Panel pnlClick;
    }
}