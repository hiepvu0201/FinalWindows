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
            setNhanViencb();
            setCombobox2();
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
            comboBox2.DataSource = dbPhim.LayPhim();
            comboBox2.DisplayMember = "TenPhim";
            comboBox2.ValueMember = "TenPhim";
        }
        private void setRaptxt()
        {
            var dtPhim = dbPhim.LayPhim().ToList();
            var dtsuatchieu = dbSuatChieu.LaySuatChieu().ToList();
            for (int i = 0; i < dtPhim.Count; i++)
            {
                if (comboBox2.Text == dtPhim[i].TenPhim)
                {
                    for (int j = 0; j < dtsuatchieu.Count; j++)
                    {
                        if (dtPhim[i].MaPhim == dtsuatchieu[j].MaPhim && dtsuatchieu[j].SuatChieu == SuatChieucb.Text)
                        {
                            globalRap = dtsuatchieu[j].MaRap.ToString();
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
            bookedSeatAlpha = new List<string>();
            bookedSeatNum = new List<string>();
            dbDatVe.findBookedSeat(globalRap, SuatChieucb.Text, ref bookedSeatAlpha, ref bookedSeatNum);

        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            setRaptxt();
            //gọi hàm set cb suất chiếu
            SuatChieucb.Enabled = true;
            if (comboBox2.ValueMember != "")
            {
                setCbSuatChieu();
            }

            //render chỗ khi change index


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
            //dtRap = new DataTable();
            //dtRap.Clear();
            //dtPhim = new DataTable();
            var dtPhim = dbPhim.LayPhim().ToList();
            setRaptxt();
            if (globalRap != null)
            {
                var demRap = dbRap.findrap(globalRap);

                if (demRap != 0)
                {

                    dbRap.findsodayghe(globalRap, ref Program.hangGhe);
                    dbRap.findSoLuongGhe(globalRap, ref Program.soGhe);
                    seatLoader.removeSeat(ref seatPanel);
                    seatPanel.Refresh();
                    getBookedSeat();
                    seatLoader.renderSeat(ref seatPanel, bookedSeatAlpha, bookedSeatNum);
                    setBtnEven(seatLoader.btns);
                }
            }
        }
        private void setCbSuatChieu()
        {
            var dtPhim = dbPhim.LayPhim().ToList();
            if (comboBox2.ValueMember.ToString() == "") return;


            for (int i = 0; i < dtPhim.Count; i++)
            {
                if (comboBox2.Text == dtPhim[i].TenPhim)
                {
                    currentMaPhim = dtPhim[i].MaPhim;
                }
            }

            SuatChieucb.DataSource = dbSuatChieu.LaySuatChieu().Where(item => item.MaPhim == currentMaPhim);
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

            nhanViencb.DataSource = dbNhanVien.LayNhanVien();
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
                var demRap = dbRap.findrap(globalRap);

                if (demRap != 0)
                {

                    dbRap.findsodayghe(globalRap, ref Program.hangGhe);
                    dbRap.findSoLuongGhe(globalRap, ref Program.soGhe);
                    seatLoader.removeSeat(ref seatPanel);
                    seatPanel.Refresh();
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


                var dtPhim = dbPhim.LayPhim();
                string maPhim = findMaPhim();
                string maNV = findMaNV();
                dbDatVe = new BLDatVe();

                //todo
                try
                {
                    dbDatVe.themVe(maPhim, raptxt.Text, SuatChieucb.Text, maNV, globalMaKH, Daytxt.Text, ghetxt.Text, ref err);
                    MessageBox.Show("thêm thành công!");
                    storedMaKH = globalMaKH;
                    Daytxt.Text = "";
                    ghetxt.Text = "";
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

            var dtDatVe = dbDatVe.LayThongTinVe().ToList();

            for (int i = 0; i < dtDatVe.Count; i++)
            {
                if (globalMaKH == dtDatVe[i].MaKH.ToString())
                {
                    if (SuatChieucb.Text == dtDatVe[i].SuatChieu)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private string findMaPhim()
        {
            var dt = dbPhim.LayPhim().ToList();
            int i = 0;
            while (i < dt.Count && comboBox2.Text != dt[i].TenPhim)
            {
                i++;
            }
            return dt[i].MaPhim;
        }
        private string findMaNV()
        {
            var dtNhanVien = dbNhanVien.LayNhanVien().ToList();
            int i = 0;
            while (i < dtNhanVien.Count && globalMaNV != (Convert.ToInt64(dtNhanVien[i].MaNV) - 1))
            {
                i++;
            }
            return dtNhanVien[i].MaNV;
        }
        private void setMaKHcb()
        {

            maKHcb.DataSource = dbKhachHang.LayKhachHang();
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
