using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyRapPhim_Final.DBLayer;
using System.Data;

namespace QuanLyRapPhim_Final.BSLayer
{
    class BLKhachHang
    {
        DBMain db = null;
        public BLKhachHang()
        {
            db = new DBMain();
        }
        public DataSet LayKhachHang()
        {
            return db.ExecuteQueryDataSet("" +
                "select * from KhachHang", 
                CommandType.Text);
        }
        public bool ThemKhachHang(string MaKH, string HovaTenLotKH, 
            string TenKH, ref string err)
        {
            string sqlString =
                $"Insert Into KhachHang Values " +
                "( " + " '" + MaKH + " ' ,N'" + HovaTenLotKH +
                "',N' " + TenKH + "') ";
            return db.MyExecuteNonQuery(sqlString,
                CommandType.Text, ref err);
        }
        public bool XoaKhachHang(ref string err, string MaKH)
        {
            string sqlString = "Delete From KhachHang Where MaKH='"
                + MaKH + "'";
            return db.MyExecuteNonQuery(sqlString, 
                CommandType.Text, ref err);
        }
        public bool CapNhatKhachHang(string MaKH,
            string TenKH, ref string err)
        {
            string sqlString = "Update KhachHang Set TenKH=N'" +
                TenKH + "' Where MaKH='" + MaKH + "'";
            return db.MyExecuteNonQuery(sqlString, 
                CommandType.Text, ref err);
        }
    }
}