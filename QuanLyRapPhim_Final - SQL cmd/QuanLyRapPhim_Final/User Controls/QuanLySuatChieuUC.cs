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
    public partial class QuanLySuatChieuUC : UserControl
    {
        bool Them;
        string err;
        BLSuatChieu dbNV = new BLSuatChieu();

        public QuanLySuatChieuUC()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            // Xóa trống các đối tượng trong Panel
            txtMaPhim.ResetText();
            txtSuatChieu.ResetText();
            txtMaRap.ResetText();
            // Không cho thao tác trên các nút Lưu / Hủy
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDel.Enabled = true;
            try
            {
                this.suatChieuPhimTableAdapter.Fill(quanLyRapPhimDataSet_SUATCHIEUPHIM.SuatChieuPhim);
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table ChucVu. Lỗi rồi!!!");
            }
        }

        private void dgv_SUATCHIEU_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgv_SUATCHIEU.CurrentCell.RowIndex;

            txtMaPhim.Text = dgv_SUATCHIEU.Rows[r].Cells[0].Value.ToString();
            txtSuatChieu.Text = dgv_SUATCHIEU.Rows[r].Cells[1].Value.ToString();
            txtMaRap.Text = dgv_SUATCHIEU.Rows[r].Cells[2].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Them = true;

            txtMaPhim.Enabled = true;
            txtMaPhim.ResetText();
            txtSuatChieu.Enabled = true;
            txtSuatChieu.ResetText();
            txtMaRap.Enabled = true;
            txtMaRap.ResetText();

            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDel.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Them = false;

            dgv_SUATCHIEU_CellClick(null, null);
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDel.Enabled = false;

            txtMaPhim.Enabled = false;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int r = dgv_SUATCHIEU.CurrentCell.RowIndex;
            string strSC = dgv_SUATCHIEU.Rows[r].Cells[1].Value.ToString();

            DialogResult traloi;
            traloi = MessageBox.Show("Bạn thực sự muốn xóa?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {

                try
                {
                    dbNV.XoaSuatChieu(ref err, strSC);
                    LoadData();
                    MessageBox.Show("Đã xóa!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Lỗi!!! Xóa thất bại!");
                }

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                try
                {
                    BLSuatChieu blSC = new BLSuatChieu();
                    blSC.ThemSuatChieu(this.txtMaPhim.Text.Trim(), this.txtSuatChieu.Text.Trim(), this.txtMaRap.Text.Trim(), ref err);
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
                BLSuatChieu blSC = new BLSuatChieu();
                blSC.CapNhatSuatChieu(this.txtMaPhim.Text, this.txtSuatChieu.Text, this.txtMaRap.Text,ref err);
                LoadData();
                MessageBox.Show("Đã sửa xong!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void QuanLySuatChieuUC_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
