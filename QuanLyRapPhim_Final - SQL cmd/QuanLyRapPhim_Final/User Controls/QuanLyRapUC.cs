using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyRapPhim_Final.BSLayer;
using System.Data.SqlClient;

namespace QuanLyRapPhim_Final.User_Controls
{
    public partial class QuanLyRapUC : UserControl
    {
        bool Them;
        string err;
        BLRap dbRap = new BLRap();
        DataTable dt = new DataTable();

        public QuanLyRapUC()
        {
            InitializeComponent();
        }

        private void QuanLyRapUC_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            try
            {
                txtMaRap.Enabled = false;
                //dgv_RAP.DataSource = dbRap.LayRap();
                dgv_RAP.AutoResizeColumns();

                // Xóa trống các đối tượng trong Panel
                txtMaRap.ResetText();
                txtSoDayGhe.ResetText();
                txtSoLuongGhe.ResetText();
                txtLoaiPhim.ResetText();

                // Không cho thao tác trên các nút Lưu / Hủy
                btnSave.Enabled = false;
                btnCancel.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
                btnAdd.Enabled = true;
                btnEdit.Enabled = true;
                btnDel.Enabled = true;
                this.rapTableAdapter.Fill(this.quanLyRapPhimDataSet_RAP.Rap);
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table NHANVIEN. Lỗi rồi!!!");
            }
        }
        private void BtnAdd_Click_1(object sender, EventArgs e)
        {
            Them = true;

            txtMaRap.Enabled = true;

            txtMaRap.ResetText();
            txtSoDayGhe.Enabled = true;
            txtSoDayGhe.ResetText();
            txtSoLuongGhe.Enabled = true;
            txtSoLuongGhe.ResetText();
            txtLoaiPhim.Enabled = true;
            txtLoaiPhim.ResetText();

            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDel.Enabled = false;
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            int r = dgv_RAP.CurrentCell.RowIndex;
            string strRap = dgv_RAP.Rows[r].Cells[0].Value.ToString();

            DialogResult traloi;
            traloi = MessageBox.Show("Bạn thực sự muốn xóa?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {

                try
                {
                    dbRap.XoaRap(ref err, strRap);
                    LoadData();
                    MessageBox.Show("Đã xóa!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Lỗi!!! Xóa thất bại!");
                }

            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {

            Them = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDel.Enabled = false;

            txtMaRap.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtMaRap.ResetText();
            txtSoDayGhe.ResetText();
            txtSoLuongGhe.ResetText();
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDel.Enabled = true;
            btnCancel.Enabled = true;
            btnSave.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                try
                {
                    BLRap blRap = new BLRap();
                    blRap.ThemRap(this.txtMaRap.Text.Trim(), this.txtSoDayGhe.Text.Trim(),
                       txtSoLuongGhe.Text.Trim(), txtLoaiPhim.Text.Trim(), ref err);
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
                try
                {
                    BLRap blRap = new BLRap();
                    blRap.CapNhatRap(this.txtMaRap.Text.Trim(),this.txtSoDayGhe.Text.Trim(),this.txtSoLuongGhe.Text.Trim(),this.txtLoaiPhim.Text.Trim(), ref err);
                    LoadData();
                    MessageBox.Show("Đã sửa xong!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không sửa được. Lỗi rồi!");
                }
            }
        }

        private void dgv_RAP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgv_RAP.CurrentCell.RowIndex;

            txtMaRap.Text = dgv_RAP.Rows[r].Cells[0].Value.ToString();
            txtSoDayGhe.Text = dgv_RAP.Rows[r].Cells[1].Value.ToString();
            txtSoLuongGhe.Text = dgv_RAP.Rows[r].Cells[2].Value.ToString();
            txtLoaiPhim.Text = dgv_RAP.Rows[r].Cells[3].Value.ToString();
        }
    }
}
