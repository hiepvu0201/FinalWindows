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
    public partial class ChucVuUC : UserControl
    {
        bool Them;
        string err;
        BLChucVu dbCV = new BLChucVu();
        DataTable dt = null;

        public ChucVuUC()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Them = true;

            txtMaCV.Enabled = true;
            txtMaCV.ResetText();
            txtChucVu.Enabled = true;
            txtChucVu.ResetText();
            txtLuong.Enabled = true;
            txtLuong.ResetText();

            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDel.Enabled = false;
        }

        private void ChucVuUC_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            txtMaCV.Enabled=false;

            txtMaCV.ResetText();
            txtChucVu.ResetText();
            txtLuong.ResetText();

            btnSave.Enabled = false;
            btnCancel.Enabled = false;
        
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnDel.Enabled = true;
            try
            {
                dt = new DataTable();
                dt.Clear();
                DataSet data = dbCV.LayChucVu();
                dt = data.Tables[0];
                this.dgv_CHUCVU.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table ChucVu. Lỗi rồi!!!");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Them = false;

            dgv_CHUCVU_CellClick(null, null);
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            btnDel.Enabled = false;

            txtMaCV.Enabled = false;
        }

        private void dgv_CHUCVU_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgv_CHUCVU.CurrentCell.RowIndex;

            txtMaCV.Text = dgv_CHUCVU.Rows[r].Cells[0].Value.ToString();
            txtChucVu.Text = dgv_CHUCVU.Rows[r].Cells[1].Value.ToString();
            txtLuong.Text = dgv_CHUCVU.Rows[r].Cells[2].Value.ToString();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int r = dgv_CHUCVU.CurrentCell.RowIndex;
            string strCV = dgv_CHUCVU.Rows[r].Cells[0].Value.ToString();

            DialogResult traloi;
            traloi = MessageBox.Show("Bạn thực sự muốn xóa?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {

                try
                {
                    dbCV.XoaChucVu(ref err, strCV);
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
                    BLChucVu blCV = new BLChucVu();
                    blCV.ThemChucVu(this.txtMaCV.Text.Trim(), this.txtChucVu.Text.Trim(), int.Parse(this.txtLuong.Text.ToString().Trim()), ref err);
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
                BLChucVu blCV = new BLChucVu();
                blCV.CapNhatChucVu(this.txtMaCV.Text, this.txtChucVu.Text, Int32.Parse(txtLuong.Text),ref err);
                LoadData();
                MessageBox.Show("Đã sửa xong!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
