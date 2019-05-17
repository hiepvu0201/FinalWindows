using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapPhim_Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWelcome_Click(object sender, EventArgs e)
        {
            pnlClick.Height = btnWelcome.Height;
            pnlClick.Top = btnWelcome.Top;
            welcomeUC1.BringToFront();
            lblHeader.Text = "Welcome";
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            DialogResult flag = MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (flag == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnQuanLyPhim_Click(object sender, EventArgs e)
        {

            pnlClick.Height = btnQuanLyPhim.Height;
            pnlClick.Top = btnQuanLyPhim.Top;
            phimUC1.BringToFront();
            lblHeader.Text = "Phim đang chiếu";
        }

        private void btnQuanLyKhachHang_Click(object sender, EventArgs e)
        {
            pnlClick.Height = btnQuanLyKhachHang.Height;
            pnlClick.Top = btnQuanLyKhachHang.Top;
            quanLyKhachHangUC1.BringToFront();
            lblHeader.Text = "Quản lý khách hàng";
        }

        private void btnQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            pnlClick.Height = btnQuanLyNhanVien.Height;
            pnlClick.Top = btnQuanLyNhanVien.Top;
            quanLyNhanVienUC1.BringToFront();
            lblHeader.Text = "Quản lý nhân viên";
        }

        private void btnQuanLyRap_Click(object sender, EventArgs e)
        {
            pnlClick.Height = btnQuanLyRap.Height;
            pnlClick.Top = btnQuanLyRap.Top;
            quanLyRapUC1.BringToFront();
            lblHeader.Text = "Quản lý rạp";
        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {
            pnlClick.Height = btnDatVe.Height;
            pnlClick.Top = btnDatVe.Top;
            datVeUC1.BringToFront();
            lblHeader.Text = "Đặt vé";

        }

        private void btnChucVuNhanVien_Click(object sender, EventArgs e)
        {
            pnlClick.Height = btnChucVuNhanVien.Height;
            pnlClick.Top = btnChucVuNhanVien.Top;
            chucVuUC1.BringToFront();
            lblHeader.Text = "Chức vụ nhân viên";
        }

        private void btnQuanLySuatChieu_Click(object sender, EventArgs e)
        {
            pnlClick.Height = btnQuanLySuatChieu.Height;
            pnlClick.Top = btnQuanLySuatChieu.Top;
            quanLySuatChieuUC1.BringToFront();
            lblHeader.Text = "Chức vụ nhân viên";
        }
    }
}