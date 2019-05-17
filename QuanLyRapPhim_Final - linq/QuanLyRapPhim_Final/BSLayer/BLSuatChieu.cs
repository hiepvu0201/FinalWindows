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
    class BLSuatChieu
    {
       
        public System.Data.Linq.Table<SuatChieuPhim> LaySuatChieu()
        {
            DataSet ds = new DataSet();
            QuanLyRapPhimDataContext qlSC = new QuanLyRapPhimDataContext();
            return qlSC.SuatChieuPhims;
        }
        
        public bool ThemSuatChieu(string MaPhim, string SuatChieu, string MaRap, ref string err)
        {
            try
            {
                QuanLyRapPhimDataContext qlSC = new QuanLyRapPhimDataContext();
                SuatChieuPhim sc = new SuatChieuPhim();
                sc.MaPhim = MaPhim;
                sc.SuatChieu = SuatChieu;
                sc.MaRap = MaRap;

                qlSC.SuatChieuPhims.InsertOnSubmit(sc);
                qlSC.SuatChieuPhims.Context.SubmitChanges();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không thêm được. Lỗi rồi!");
            }
            return true;
        }
        public bool XoaSuatChieu(ref string err, string SuatChieu)
        {
            try
            {
                QuanLyRapPhimDataContext qlSC = new QuanLyRapPhimDataContext();
                var scQuery = from sc in qlSC.SuatChieuPhims
                             where sc.SuatChieu == SuatChieu
                             select sc;

                qlSC.SuatChieuPhims.DeleteAllOnSubmit(scQuery);
                qlSC.SubmitChanges();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!!!");
            }
            return true;
        }
        public bool CapNhatSuatChieu(string MaPhim, string SuatChieu, string MaRap,ref string err)
        {
            try
            {
                QuanLyRapPhimDataContext qlSC = new QuanLyRapPhimDataContext();
                var scQuery = (from sc in qlSC.SuatChieuPhims where sc.MaPhim == MaPhim select sc).SingleOrDefault();
                if (scQuery != null)
                {
                    scQuery.SuatChieu = SuatChieu;
                    scQuery.MaRap = MaRap;

                    qlSC.SubmitChanges();
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
