using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyRapPhim_Final.DBLayer;
using System.Data;

namespace QuanLyRapPhim_Final.BSLayer
{
    class BLRap
    {
        DBMain db = null;
        public BLRap()
        {
            db = new DBMain();
        }
        public DataSet LayRap()
        {
            return db.ExecuteQueryDataSet("select * from Rap",
                CommandType.Text);
        }
        public bool ThemRap(string MaRap, string SoDayGhe, 
            string SoLuongGhe,string LoaiRap, ref string err)
        {
            string sqlString = "Insert Into Rap Values(" + "'" + MaRap + "',N'" +
                SoDayGhe + "',N'" + SoLuongGhe + "',N'" +LoaiRap + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaRap(ref string err, string MaRap)
        {
            string sqlString = "Delete From Rap Where MaRap='" + MaRap + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatRap(string MaRap, string SoDayGhe,string SoLuongGhe,string LoaiPhim, ref string err)
        {
            string sqlString = "Update Rap Set SoDayGhe='" + SoDayGhe + "',SoLuongGhe='" +SoLuongGhe+"',LoaiPhim='"+LoaiPhim+"'"+
                " Where MaRap='" + MaRap + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public DataSet findRap(string MaRap)
        {
            return db.ExecuteQueryDataSet
                ($"select MaRap from Rap where MaRap='" +
                $"{MaRap.Trim()}'", CommandType.Text);
        }
        public DataSet findSoDayGhe(string MaRap)
        {
            return db.ExecuteQueryDataSet
                ($"select SoDayGhe from Rap where MaRap='" +
                $"{MaRap.Trim()}'", CommandType.Text);
        }
        public DataSet findSoLuongGhe(string MaRap)
        {
            return db.ExecuteQueryDataSet
                ($"select SoLuongGhe from Rap where MaRap='" +
                $"{MaRap.Trim()}'", CommandType.Text);
        }
    }
}