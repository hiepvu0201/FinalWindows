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
    public partial class QuanLyNhanVienUC : UserControl
    {
        bool Them;
        string err;
        private string temp="";
        BLNhanVien dbNV = new BLNhanVien();
        BLChucVu dbCV = new BLChucVu();
        DataTable dt = null;
        int month = DateTime.Now.Month;
        int day = DateTime.Now.Day;
        int nam= DateTime.Now.Year;

        public QuanLyNhanVienUC()
        {
            InitializeComponent();
        }

        private void QuanLyNhanVienUC_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        void LoadData()
        {
            // Xóa trống các đối tượng trong Panel
            txtHovalotNV.Enabled = true;
            txtHovalotNV.ResetText();
            txtMaNV.Enabled = false;
            txtMaNV.ResetText();
            txtTenNV.Enabled = true;
            txtTenNV.ResetText();
            txtMaNV.ResetText();
            txtHovalotNV.ResetText();
            txtTenNV.ResetText();
            // Không cho thao tác trên các nút Lưu / Hủy
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
            btnAdd.Enabled = true;
            btnEditNV.Enabled = true;
            btnDelNV.Enabled = true;
            txtChucVu.Enabled = false;
            txtLuong.Enabled = false;

            lblThang.Text = month.ToString();
            lblNgay.Text = day.ToString();

            lblGioNghi.Text = "0";
            lblNghiThang.Text = "0";

            try
            {
                
                this.cbbMaCV.DataSource = dbCV.LayChucVu();
                this.cbbMaCV.DisplayMember = "MaCV";
                this.cbbMaCV.ValueMember = "MaCV";
                this.cbbMaCV.Refresh();

                dgv_NHANVIEN.DataSource = dbNV.LayNhanVien();
                dgv_NHANVIEN.Refresh();
                

            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table ChucVu. Lỗi rồi!!!");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Them = true;

            txtHovalotNV.Enabled = true;
            txtHovalotNV.ResetText();
            txtMaNV.Enabled = true;
            txtMaNV.ResetText();
            txtTenNV.Enabled = true;
            txtTenNV.ResetText();

            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            btnAdd.Enabled = false;
            btnEditNV.Enabled = false;
            btnDelNV.Enabled = false;
        }

        private void btnEditNV_Click(object sender, EventArgs e)
        {
            Them = false;

            dgv_NHANVIEN_CellClick(null, null);
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            btnAdd.Enabled = false;
            btnEditNV.Enabled = false;
            btnDelNV.Enabled = false;

            txtMaNV.Enabled = false;
        }

        private void dgv_NHANVIEN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgv_NHANVIEN.CurrentCell.RowIndex;

            txtMaNV.Text = dgv_NHANVIEN.Rows[r].Cells[2].Value.ToString();
            txtHovalotNV.Text = dgv_NHANVIEN.Rows[r].Cells[0].Value.ToString();
            txtTenNV.Text = dgv_NHANVIEN.Rows[r].Cells[1].Value.ToString();
            cbbMaCV.Text= dgv_NHANVIEN.Rows[r].Cells[3].Value.ToString();
            lblNghiThang.Text= dgv_NHANVIEN.Rows[r].Cells[4].Value.ToString();
            lblNghiNam.Text = dgv_NHANVIEN.Rows[r].Cells[5].Value.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                try
                {
                    BLNhanVien blNV = new BLNhanVien();
                    blNV.ThemNhanVien(this.txtMaNV.Text.Trim(), this.txtHovalotNV.Text.Trim(), this.txtTenNV.Text.Trim(), cbbMaCV.Text,0,0,ref err);
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
                BLNhanVien blNV = new BLNhanVien();
                blNV.CapNhatNhanVien( this.txtHovalotNV.Text.Trim(),this.txtTenNV.Text.Trim(),this.cbbMaCV.Text,Int32.Parse(lblNghiThang.Text), Int32.Parse(lblNghiNam.Text), this.txtMaNV.Text,ref err);
                LoadData();
                MessageBox.Show("Đã sửa xong!");
            }
        }

        private void btnDelNV_Click(object sender, EventArgs e)
        {
            int r = dgv_NHANVIEN.CurrentCell.RowIndex;
            string strNV = dgv_NHANVIEN.Rows[r].Cells[2].Value.ToString();

            DialogResult traloi;
            traloi = MessageBox.Show("Bạn thực sự muốn xóa?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {

                try
                {
                    dbNV.XoaNhanVien(ref err, strNV);
                    LoadData();
                    MessageBox.Show("Đã xóa!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Lỗi!!! Xóa thất bại!");
                }

            }
        }

        private void cbbMaCV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbMaCV.ValueMember == "") return;
            using (QuanLyRapPhimDataContext db = new QuanLyRapPhimDataContext())
            {
                //txtChucVu.Text = dgv_NHANVIEN.SelectedCells[0].Owning[];
                //txtLuong.Text = dgv_NHANVIEN.SelectedCells[0].OwningRow.Cells["Luong"].Value.ToString();
                var dtChucVu = dbCV.LayChucVu().ToList();
                if (cbbMaCV.ValueMember.ToString() == "") return;


                for (int i = 0; i < dtChucVu.Count; i++)
                {
                    if (cbbMaCV.Text == dtChucVu[i].MaCV)
                    {
                        txtChucVu.Text = dtChucVu[i].ChucVu1;
                        txtLuong.Text = dtChucVu[i].Luong.ToString();
                    }
                }
            }
        }

        private void txtName_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                dgv_NHANVIEN.DataSource = dbNV.TimKiemNhanVien(txtName.Text);
                dgv_NHANVIEN.Refresh();
                if (txtName.Text == "")
                {
                    dgv_NHANVIEN.DataSource = dbNV.LayNhanVien();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd1_Click(object sender, EventArgs e)
        {
            int temp,temp1;
            temp = Int32.Parse(lblNghiThang.Text);
            temp++;

            temp1 = Int32.Parse(lblNghiNam.Text);
            temp1++;

            lblNghiThang.Text = temp.ToString();
            lblNghiNam.Text = temp1.ToString();
        }

        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            Them = false;
            txtMaNV.Enabled = false;
            txtHovalotNV.Enabled = false;
            txtTenNV.Enabled = false;
            txtChucVu.Enabled = true;
            txtLuong.Enabled = true;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;

            btnAdd.Enabled = false;
            btnEditNV.Enabled = false;
            btnDelNV.Enabled = false;

        }
        
        private int demNgayTrongThang(int month)
        {
            if(month==1|| month == 3 || month == 5 || month == 7 || month == 8 
                || month == 10 || month == 12)
                return 31;
            else if(month == 4 || month == 6 || month == 9 || month == 11 )
                return 30;
            else
            {
                if (nam % 400 == 0 || (nam % 100 != 0 && nam % 4 == 0))
                {
                    return 29;
                }
                else
                {
                    return 28;
                }
            }
        }

        private int demNgayUpToNow(int month)
        {
            int ngayUpToNow=0;
            for(int i=1;i<=month;i++)
            {
                ngayUpToNow+=demNgayTrongThang(i);
            }
            return ngayUpToNow;
        }

        private int demNgayFromNow(int month)
        {
            int ngayFromNow = 0;
            for (int i = month; i <= 12; i++)
            {
                ngayFromNow += demNgayTrongThang(i);
            }
            return ngayFromNow;
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            lblGioNghi.Text = lblNghiThang.Text;

            int ca;
            if (txtChucVu.Text == "Parttime")
                ca = 4;
            else
                ca = 8;
            int ngayDiLam =demNgayTrongThang(month);
            int luong1Gio = Int32.Parse(txtLuong.Text);
            int gioNghi = Int32.Parse(lblGioNghi.Text);
            lblLuong.Text = (ngayDiLam*ca*luong1Gio-gioNghi).ToString();

            int ngayDiLam1=demNgayUpToNow(month)+demNgayFromNow(month);
            int gioNghiCaNam= Int32.Parse(lblNghiNam.Text);
            lblThuNhapNam.Text=(ngayDiLam1*ca*luong1Gio - gioNghiCaNam).ToString();
        }
    }
}