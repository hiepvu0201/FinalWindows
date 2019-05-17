using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyRapPhim_Final.BSLayer;

namespace QuanLyRapPhim_Final.User_Controls
{
    public partial class QuanLyKhachHangUC : UserControl
    {
        bool Them;
        string err;
        BLKhachHang dbKH = new BLKhachHang();

        public QuanLyKhachHangUC()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            // Xóa trống các đối tượng trong Panel
            txtMaKH.ResetText();
            txtHovalotKH.ResetText();
            txtTenKH.ResetText();
            // Không cho thao tác trên các nút Lưu / Hủy
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            try
            {
                this.khachHangTableAdapter.Fill(this.quanLyRapPhimDataSet_KHACHHANG.KhachHang);
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table THANHPHO. Lỗi rồi!!!");
            }
        }
        private void QuanLyKhachHangUC_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            Them = true;

            txtHovalotKH.Enabled = true;
            txtHovalotKH.ResetText();
            txtMaKH.Enabled = true;
            txtMaKH.ResetText();
            txtTenKH.Enabled = true;
            txtTenKH.ResetText();

            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            Them = false;

            Dgv_KHACHHANG_CellClick(null, null);
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            txtMaKH.Enabled = false;
        }

        private void Dgv_KHACHHANG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgv_KHACHHANG.CurrentCell.RowIndex;

            txtMaKH.Text = dgv_KHACHHANG.Rows[r].Cells[0].Value.ToString();
            txtHovalotKH.Text = dgv_KHACHHANG.Rows[r].Cells[1].Value.ToString();
            txtTenKH.Text = dgv_KHACHHANG.Rows[r].Cells[2].Value.ToString();
        }

        private void BtnHuy_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                try
                {
                    BLKhachHang blKH = new BLKhachHang();
                    blKH.ThemKhachHang(this.txtMaKH.Text.Trim(), this.txtHovalotKH.Text.Trim(), this.txtTenKH.Text.Trim(), ref err);
                    LoadData();
                    MessageBox.Show("Đã thêm xong!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không thêm được. Lỗi rồi!");
                }
            }
            else
            {
                BLKhachHang blKH = new BLKhachHang();
                blKH.CapNhatKhachHang(this.txtMaKH.Text, this.txtTenKH.Text, ref err);
                LoadData();
                MessageBox.Show("Đã sửa xong!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int r = dgv_KHACHHANG.CurrentCell.RowIndex;
            string strKH = dgv_KHACHHANG.Rows[r].Cells[0].Value.ToString();

            DialogResult traloi;
            traloi = MessageBox.Show("Bạn thực sự muốn xóa?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {

                try
                {
                    dbKH.XoaKhachHang(ref err, strKH);
                    LoadData();
                    MessageBox.Show("Đã xóa!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Lỗi!!! Xóa thất bại!");
                }

            }
        }
    }
}