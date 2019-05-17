using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyRapPhim_Final.User_Controls;
using QuanLyRapPhim_Final.BSLayer;
using QuanLyRapPhim_Final.renderSeat;

namespace QuanLyRapPhim_Final.User_Controls
{
    public partial class DatVeUC : UserControl
    {
        DataTable dtRap = null;
        DataTable dtDatVe = null;
        DataTable dtPhim = null;
        DataTable dtSuatChieu = null;
        DataTable dtNhanVien = null;
        DataTable dtKH = null;

        BLNhanVien dbNhanVien = new BLNhanVien();
        BLSuatChieu dbSuatChieu = new BLSuatChieu();
        BLPhim dbPhim = new BLPhim();
        BLDatVe dbDatVe = new BLDatVe();
        BLRap dbRap = new BLRap();
        BLKhachHang dbKhachHang = new BLKhachHang();
        Graphics gp;
        private List<string> bookedSeatAlpha;
        private List<string> bookedSeatNum;
        private string globalRap;
        private string currentMaPhim;
        private string globalMaKH;
        private string storedMaKH = "";
        private int globalMaNV;
        private bool themFlag = false;
        string err;
        public DatVeUC()
        {
            InitializeComponent();
        }

        private void DatVeUC_Load(object sender, EventArgs e)
        {

            this.datVeTableAdapter.Fill(this.quanLyRapPhimDataSet_DATVE.DatVe);
            dtRap = new DataTable();
            dtRap.Clear();
            setNhanViencb();
            setCombobox2();
            DataSet ds = dbRap.LayRap();
            dtRap = ds.Tables[0];
            raptxt.Enabled = false;
            gp = seatPanel.CreateGraphics();
            seatPanel.Visible = false;
            SuatChieucb.Enabled = false;
            setMaKHcb();
            comboBox2.Enabled = false;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
        }
        private void setCombobox2()
        {
            dtPhim = new DataTable();
            dtPhim.Clear();
            DataSet ds = dbPhim.LayPhim();
            dtPhim = ds.Tables[0];
            comboBox2.DataSource = dtPhim;
            comboBox2.DisplayMember = "TenPhim";
            comboBox2.ValueMember = "TenPhim";
        }
        private void setRaptxt(DataTable dt)
        {

            dtSuatChieu = new DataTable();
            dtSuatChieu.Clear();
            DataSet dsSuatChieu = dbSuatChieu.LaySuatChieu();
            dtSuatChieu = dsSuatChieu.Tables[0];
            for (int i = 0; i < dtPhim.Rows.Count; i++)
            {
                if (comboBox2.Text == dt.Rows[i].ItemArray[0].ToString())
                {
                    for (int j = 0; j < dtSuatChieu.Rows.Count; j++)
                    {
                        if (dt.Rows[i].ItemArray[1].ToString() == dtSuatChieu.Rows[j].ItemArray[0].ToString() && dtSuatChieu.Rows[j].ItemArray[1].ToString() == SuatChieucb.Text)
                        {
                            globalRap = dtSuatChieu.Rows[j].ItemArray[2].ToString();
                            raptxt.Enabled = true;
                            raptxt.Text = globalRap;
                            raptxt.Enabled = false;
                        }

                    }

                }
            }

        }

        private void seatPanel_Paint(object sender, PaintEventArgs e)
        {
            render matrix = new render(seatPanel.Width, seatPanel.Height);
            matrix.drawTable(gp);
        }
        private void getBookedSeat()
        {
            if (SuatChieucb.ValueMember == "") return;

            dtDatVe = new DataTable();
            dtDatVe.Clear();
            //comboBox1.SelectedValue.ToString()
            DataSet ds = dbDatVe.findBookedSeat(globalRap, SuatChieucb.Text);
            dtDatVe = ds.Tables[0];
            bookedSeatAlpha = new List<string>();
            bookedSeatNum = new List<string>();
            if (dtDatVe.Rows.Count != 0)
            {
                for (int i = 0; i < dtDatVe.Rows.Count; i++)   //2 cột
                {

                    bookedSeatAlpha.Add(dtDatVe.Rows[i].ItemArray[0].ToString());
                    bookedSeatNum.Add(dtDatVe.Rows[i].ItemArray[1].ToString());

                }
            }
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            dtPhim = new DataTable();
            dtPhim.Clear();
            DataSet dsPhim = dbPhim.LayPhim();
            dtPhim = dsPhim.Tables[0];
            //setRaptxt(dtPhim);
            //gọi hàm set cb suất chiếu
            SuatChieucb.Enabled = true;
            if (comboBox2.ValueMember != "")
            {
                setCbSuatChieu(dtPhim);
            }

            //render chỗ khi change index


        }
        private string getHour()
        {

            dtDatVe = new DataTable();
            dtDatVe.Clear();
            DataSet dsDatVe = dbDatVe.findHour(SuatChieucb.SelectedItem.ToString());
            dtDatVe = dsDatVe.Tables[0];
            for (int i = 0; i < dtDatVe.Rows.Count; i++)
            {
                if (comboBox2.Text == dtDatVe.Rows[i].ItemArray[1].ToString())
                {
                    return dtDatVe.Rows[i].ItemArray[0].ToString();
                }
            }
            return "";
        }

        private void SuatChieucb_SelectedIndexChanged(object sender, EventArgs e)
        {
            Daytxt.Text = "";
            ghetxt.Text = "";
            if (comboBox2.ValueMember.ToString() == "") return;
            if (SuatChieucb.ValueMember.ToString() == "") return;
            //string time;

            seatPanel.Visible = true;
            render seatLoader = new render();
            dtRap = new DataTable();
            dtRap.Clear();
            dtPhim = new DataTable();
            DataSet dsPhim = dbPhim.LayPhim();
            dtPhim = dsPhim.Tables[0];
            setRaptxt(dtPhim);
            if (globalRap != null)
            {
                DataSet ds = dbRap.findRap(globalRap);
                dtRap = ds.Tables[0];

                if (dtRap.Rows.Count != 0)
                {
                    ds = dbRap.findSoDayGhe(globalRap);
                    dtRap = ds.Tables[0];
                    Program.hangGhe = Convert.ToInt32(dtRap.Rows[0].ItemArray[0].ToString());
                    ds = dbRap.findSoLuongGhe(globalRap);
                    dtRap = ds.Tables[0];
                    Program.soGhe = Convert.ToInt32(dtRap.Rows[0].ItemArray[0].ToString());
                    seatLoader.removeSeat(ref seatPanel);
                    seatPanel.Refresh();
                    //time = getHour();
                    getBookedSeat();
                    seatLoader.renderSeat(ref seatPanel, bookedSeatAlpha, bookedSeatNum);
                    setBtnEven(seatLoader.btns);
                }
            }
        }
        private void setCbSuatChieu(DataTable dtPhim)
        {
            if (comboBox2.ValueMember.ToString() == "") return;
            dtSuatChieu = new DataTable();
            dtSuatChieu.Clear();

            for (int i = 0; i < dtPhim.Rows.Count; i++)
            {
                if (comboBox2.Text == dtPhim.Rows[i].ItemArray[0].ToString())
                {
                    currentMaPhim = dtPhim.Rows[i].ItemArray[1].ToString();
                }
            }
            DataSet ds = dbSuatChieu.LaySuatChieuCuaPhim(currentMaPhim);
            dtSuatChieu = ds.Tables[0];
            SuatChieucb.DataSource = dtSuatChieu;
            SuatChieucb.DisplayMember = "SuatChieu";
            SuatChieucb.ValueMember = "SuatChieu";
        }

        private void nhanViencb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (nhanViencb.ValueMember == "") return;
            globalMaNV = nhanViencb.SelectedIndex;
        }
        private void setNhanViencb()
        {
            dtNhanVien = new DataTable();
            dtNhanVien.Clear();
            DataSet ds = dbNhanVien.LayNhanVien();
            dtNhanVien = ds.Tables[0];
            nhanViencb.DataSource = dtNhanVien;
            nhanViencb.DisplayMember = "TenNV";
            nhanViencb.ValueMember = "TenNV";
            globalMaNV = nhanViencb.SelectedIndex;
        }
        private void setBtnEven(List<Button> btns)
        {
            for (int i = 0; i < btns.Count; i++)
            {

                btns[i].Click += btn_click;

            }
        }
        private void btn_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string[] splitedString = btn.Text.Split('-');
            Daytxt.Text = splitedString[0];
            ghetxt.Text = splitedString[1];
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            if (SuatChieucb.ValueMember.ToString() == "") return;
            render seatLoader = new render();
            if (globalRap != null)
            {
                DataSet ds = dbRap.findRap(globalRap);
                dtRap = ds.Tables[0];

                if (dtRap.Rows.Count != 0)
                {
                    ds = dbRap.findSoDayGhe(globalRap);
                    dtRap = ds.Tables[0];
                    Program.hangGhe = Convert.ToInt32(dtRap.Rows[0].ItemArray[0].ToString());
                    ds = dbRap.findSoLuongGhe(globalRap);
                    dtRap = ds.Tables[0];
                    Program.soGhe = Convert.ToInt32(dtRap.Rows[0].ItemArray[0].ToString());
                    seatLoader.removeSeat(ref seatPanel);
                    seatPanel.Refresh();
                    //time = getHour();
                    getBookedSeat();
                    seatLoader.renderSeat(ref seatPanel, bookedSeatAlpha, bookedSeatNum);
                    setBtnEven(seatLoader.btns);
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            themFlag = true;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.Enabled = false;

            comboBox2.Enabled = true;

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!raptxt.Text.Equals("") && !ghetxt.Text.Equals("") && !Daytxt.Text.Equals(""))
            {
                bool checkKH = checkMaKH();
                if (checkKH == false)
                {
                    MessageBox.Show("bạn đã đặt suất chiếu này rồi!");
                    return;
                }

                dtPhim = new DataTable();
                dtPhim.Clear();
                DataSet dsPhim = dbPhim.LayPhim();
                dtPhim = dsPhim.Tables[0];
                string maPhim = findMaPhim(dtPhim);
                string maNV = findMaNV();
                dbDatVe = new BLDatVe();

                //todo
                try
                {
                    dbDatVe.themVe(maPhim, raptxt.Text, SuatChieucb.Text, maNV, globalMaKH, Daytxt.Text, ghetxt.Text, ref err);
                    MessageBox.Show("thêm thành công!");
                    storedMaKH = globalMaKH;
                }
                catch (Exception)
                {
                    MessageBox.Show("lỗi");
                }

            }
            else
            {
                MessageBox.Show("chưa hoàn thành đặt vé !");
            }
        }
        private bool checkMaKH()
        {
            dtDatVe = new DataTable();
            dtDatVe.Clear();
            DataSet ds = dbDatVe.LayThongTinVe();
            dtDatVe = ds.Tables[0];

            for (int i = 0; i < dtDatVe.Rows.Count; i++)
            {
                if (globalMaKH == dtDatVe.Rows[i].ItemArray[3].ToString())
                {
                    if (SuatChieucb.Text == dtDatVe.Rows[i].ItemArray[1].ToString())
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private string findMaPhim(DataTable dt)
        {
            int i = 0;
            while (i < dt.Rows.Count && comboBox2.Text != dt.Rows[i].ItemArray[0].ToString())
            {
                i++;
            }
            return dt.Rows[i].ItemArray[1].ToString();
        }
        private string findMaNV()
        {

            dtNhanVien = new DataTable();
            dtNhanVien.Clear();
            DataSet ds = dbNhanVien.LayNhanVien();
            dtNhanVien = ds.Tables[0];
            int i = 0;
            while (i < dtNhanVien.Rows.Count && globalMaNV != (Convert.ToInt64(dtNhanVien.Rows[i].ItemArray[2]) - 1))
            {
                i++;
            }
            return dtNhanVien.Rows[i].ItemArray[2].ToString();
        }
        private void setMaKHcb()
        {
            dtKH = new DataTable();
            dtKH.Clear();
            DataSet ds = dbKhachHang.LayKhachHang();
            dtKH = ds.Tables[0];
            maKHcb.DataSource = dtKH;
            maKHcb.DisplayMember = "MaKH";
            maKHcb.ValueMember = "MaKH";
            globalMaKH = maKHcb.Text;
        }

        private void maKHcb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (maKHcb.ValueMember == "") return;
            globalMaKH = maKHcb.Text;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            comboBox2.Text = "";
            SuatChieucb.Text = "";
            maKHcb.Text = "";
            raptxt.Text = "";
            Daytxt.Text = "";
            ghetxt.Text = "";
            nhanViencb.Text = "";

        }
    }
}
