using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyRapPhim_Final.DBLayer;
using System.Data;

namespace QuanLyRapPhim_Final.BSLayer
{
    class BLDatVe
    {
        DBMain db = null;
        public BLDatVe()
        {
            db = new DBMain();
        }
        public DataSet LayThongTinVe()
        {
            return db.ExecuteQueryDataSet("select * from DatVe",
                CommandType.Text);
        }

        public DataSet findBookedSeat(string MaRap, string tgChieu)
        {

            return db.ExecuteQueryDataSet($"select Day,So from DatVe where MaRap='{MaRap.Trim()}' and SuatChieu='{tgChieu.Trim()}'", CommandType.Text);

            //return db.ExecuteQueryDataSet(
            //    $"select Day,So from DatVe where MaRap=" +
            //    $"'{MaRap.Trim()}'",CommandType.Text);

        }
        public DataSet findHour(string tgChieu)
        {

            return db.ExecuteQueryDataSet("select A.SuatChieu,B.TenPhim,B.MaPhim from DatVe as A inner join Phim as B on A.MaPhim = B.MaPhim", CommandType.Text);

            //return db.ExecuteQueryDataSet(
            //    "select A.SuatChieu,B.TenPhim from DatVe as A " +
            //    "inner join Phim as B on A.MaPhim = B.MaPhim",
            //    CommandType.Text);

        }
        public bool themVe(string MaPhim, string Rap, string SuatChieu, string MaNV, string MaKH, string Day, string Ghe, ref string err)
        {
            string sqlString = $"Insert Into DatVe values('{MaPhim.Trim()}','{SuatChieu.Trim()}','{MaNV.Trim()}','{MaKH.Trim()}','{Rap.Trim()}','{Day.Trim()}','{Ghe.Trim()}')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaRap(ref string err, string MaRap)
        {
            string sqlString = "Delete From DatVe Where MaRap='" + MaRap + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
