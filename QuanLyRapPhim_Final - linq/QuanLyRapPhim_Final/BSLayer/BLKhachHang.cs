using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyRapPhim_Final.BSLayer
{
    class BLKhachHang
    {

        public System.Data.Linq.Table<KhachHang> LayKhachHang()
        {
            DataSet ds = new DataSet();
            QuanLyRapPhimDataContext qlKH = new QuanLyRapPhimDataContext();
            return qlKH.KhachHangs;
        }
        public bool ThemKhachHang(string MaKH, string HovaTenLotKH, 
            string TenKH, ref string err)
        {
            try
            {
                QuanLyRapPhimDataContext qlKH = new QuanLyRapPhimDataContext();
                KhachHang kh = new KhachHang();
                kh.MaKH = MaKH;
                kh.HovaLotKH = HovaTenLotKH;
                kh.TenKH = TenKH;

                qlKH.KhachHangs.InsertOnSubmit(kh);
                qlKH.KhachHangs.Context.SubmitChanges();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không thêm được. Lỗi rồi!");
            }
            return true;
        }
        public bool XoaKhachHang(ref string err, string MaKH)
        {
            try
            {
                QuanLyRapPhimDataContext qlKH = new QuanLyRapPhimDataContext();
                var khQuery = from kh in qlKH.KhachHangs
                              where kh.MaKH == MaKH
                              select kh;

                qlKH.KhachHangs.DeleteAllOnSubmit(khQuery);
                qlKH.SubmitChanges();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!!!");
            }
            return true;
        }
        public bool CapNhatKhachHang(string MaKH,
            string TenKH, string HovaTenLotKH,ref string err)
        {
            try
            {
                QuanLyRapPhimDataContext qlKH = new QuanLyRapPhimDataContext();
                var khQuery = (from kh in qlKH.KhachHangs where kh.MaKH == MaKH select kh).SingleOrDefault();
                if (khQuery != null)
                {
                    khQuery.TenKH = TenKH;
                    khQuery.HovaLotKH = HovaTenLotKH;
                    qlKH.SubmitChanges();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Không sửa được. Lỗi rồi!");
            }
            return true;
        }
    }
}