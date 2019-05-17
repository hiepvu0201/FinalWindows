using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyRapPhim_Final.DBLayer;
using System.Data;

namespace QuanLyRapPhim_Final.BSLayer
{
    class BLNhanVien
    {
        DBMain db = null;
        public BLNhanVien()
        {
            db = new DBMain();
        }
        public DataSet LayNhanVien()
        {
            return db.ExecuteQueryDataSet("select * from NhanVien",
                CommandType.Text);
        }
        public bool ThemNhanVien(string MaNV, string HovaTenLotNV,
            string TenNV, string MaCV,int SoGioNghi, int NghiNam,ref string err)
        {
            string sqlString =
                $"Insert Into NhanVien Values " +
                "( " + " N'" + HovaTenLotNV + " ' ,N'" + TenNV + "',N'"
                + MaNV + "',N'" + MaCV + "','" + SoGioNghi + "','" + NghiNam+"') ";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaNhanVien(ref string err, string MaNV)
        {
            string sqlString = "Delete From NhanVien Where MaNV='"
                + MaNV + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatNhanVien( string HovaLot,string TenNV,string MaCV,int SoGioNghi, int NghiNam,string MaNV, ref string err)
        {
            string sqlString = "Update NhanVien Set HovaLotNV=N'"+ HovaLot+ "',TenNV=N'" + TenNV  +"',MaCV='"+MaCV+ "', GioNghi="+SoGioNghi + ", TongGioNghi=" + NghiNam +
                " Where MaNV='" + MaNV + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public DataSet TimKiemNhanVien(string Ten)
        {
            return db.ExecuteQueryDataSet("select * " +
                "from NhanVien where TenNV=N'" + Ten + "'", CommandType.Text);
        }
    }
}