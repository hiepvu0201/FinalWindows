using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyRapPhim_Final.DBLayer;
using System.Data;

namespace QuanLyRapPhim_Final.BSLayer
{
    class BLSuatChieu
    {
        DBMain db = null;
        public BLSuatChieu()
        {
            db = new DBMain();
        }
        public DataSet LaySuatChieu()
        {
            return db.ExecuteQueryDataSet("select * from SuatChieuPhim", CommandType.Text);
        }
        public DataSet LaySuatChieuCuaPhim(string MaPhim)
        {
            //return db.ExecuteQueryDataSet($"select B.MaPhim,A.SuatChieu from SuatChieuPhim as A inner join DatVe as B on A.MaPhim = B.MaPhim where A.MaPhim='{MaPhim.Trim()}'", CommandType.Text);
            return db.ExecuteQueryDataSet($"select * from SuatChieuPhim where MaPhim='{MaPhim.Trim()}'", CommandType.Text);
        }
        public bool ThemSuatChieu(string MaPhim, string SuatChieu, string MaRap, ref string err)
        {
            string sqlString = "Insert Into Rap Values(" + "'" + MaPhim + "',N'" +
                 SuatChieu + "',N'" + MaRap +  "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaSuatChieu(ref string err, string SuatChieu)
        {
            string sqlString = "Delete From Phim Where SuatChieu='" + SuatChieu + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatSuatChieu(string MaPhim, string SuatChieu, string MaRap,ref string err)
        {
            string sqlString = "Update SuatChieuPhim Set SuatChieu='" + SuatChieu + "',MaRap='"+MaRap+"' Where MaPhim='"
                + MaPhim + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
