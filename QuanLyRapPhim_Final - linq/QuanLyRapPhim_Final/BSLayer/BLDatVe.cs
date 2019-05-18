using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyRapPhim_Final.BSLayer
{
    class BLDatVe
    {

        public System.Data.Linq.Table<DatVe> LayThongTinVe()
        {
            DataSet ds = new DataSet();
            QuanLyRapPhimDataContext qlv = new QuanLyRapPhimDataContext();
            return qlv.DatVes;
        }

        public void findBookedSeat(string maRap, string tgChieu, ref List<string> bookedSeatAlpha, ref List<string> bookedSeatNum)
        {
            QuanLyRapPhimDataContext qlrp = new QuanLyRapPhimDataContext();
            var query = (from i in qlrp.DatVes where i.MaRap == maRap && i.SuatChieu == tgChieu select new { i.Day, i.So }).ToList();
            for (int i = 0; i < query.Count; i++)
            {
                bookedSeatAlpha.Add(query[i].Day);
                bookedSeatNum.Add(query[i].So.ToString());
            }
        }

        public bool themVe(string MaPhim, string Rap, string SuatChieu, string MaNV, string MaKH, string Day, string Ghe, ref string err)
        {
            QuanLyRapPhimDataContext qlrp = new QuanLyRapPhimDataContext();
            DatVe datVe = new DatVe();
            datVe.MaPhim = MaPhim;
            datVe.MaRap = Rap;
            datVe.SuatChieu = SuatChieu;
            datVe.MaNV = MaNV;
            datVe.MaKH = MaKH;
            datVe.Day = Day;
            datVe.So = Convert.ToInt32(Ghe);
            qlrp.DatVes.InsertOnSubmit(datVe);
            qlrp.DatVes.Context.SubmitChanges();
            return true;
            //string sqlString = $"Insert Into DatVe values('{MaPhim.Trim()}','{SuatChieu.Trim()}','{MaNV.Trim()}','{MaKH.Trim()}','{Rap.Trim()}','{Day.Trim()}','{Ghe.Trim()}')";
            //return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public DataTable right()
        {
            DataTable dt = new DataTable();
            dt.Clear();
            QuanLyRapPhimDataContext qlrp = new QuanLyRapPhimDataContext();
            var query = (from i in qlrp.DatVes join j in qlrp.Phims on i.MaPhim equals j.MaPhim select new { i.SuatChieu, j.TenPhim, j.MaPhim }).ToList();
            for (int i = 0; i < query.Count; i++)
            {
                dt.Rows[i].ItemArray[0] = query[i].MaPhim;
                dt.Rows[i].ItemArray[1] = query[i].SuatChieu;
                dt.Rows[i].ItemArray[2] = query[i].TenPhim;
            }

            return dt;
        }

    }
}
