using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyRapPhim_Final.DBLayer;
using System.Data;
using System.IO;

namespace QuanLyRapPhim_Final.BSLayer
{
    class BLPhim
    {
        DBMain db = null;
        public BLPhim()
        {
            db = new DBMain();
        }
        public DataSet LayPhim()
        {
            return db.ExecuteQueryDataSet("select * from Phim", CommandType.Text);
        }
        public bool ThemPhim(string TenPhim, string MaPhim, int GiaVe, string Poster, ref string err)
        {
            string sqlString = $"Insert Into Phim Values(N'{TenPhim.Trim()}','{MaPhim.Trim()}',{GiaVe}," +
                $"( select BulkColumn from Openrowset(Bulk '{Poster}', single_Blob) as image))";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaPhim(ref string err, string MaPhim)
        {
            string sqlString = "Delete From Phim Where MaPhim='" + MaPhim + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatPhim(string MaPhim, string TenPhim,int GiaVe,string Poster, ref string err)
        {
            string sqlString = "Update Phim Set TenPhim=N'" + TenPhim + "', GiaVe=" + GiaVe + ", Poster=" + $"( select BulkColumn from Openrowset(Bulk '{Poster}', single_Blob) as image)"+
                " Where MaPhim='" + MaPhim + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}