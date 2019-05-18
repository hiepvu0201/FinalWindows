using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyRapPhim_Final.BSLayer
{
    class BLPhim
    {

        public System.Data.Linq.Table<Phim> LayPhim()
        {
            DataSet ds = new DataSet();
            QuanLyRapPhimDataContext qlP = new QuanLyRapPhimDataContext();
            return qlP.Phims;
        }
        public bool ThemPhim(string TenPhim, string MaPhim, int GiaVe, MemoryStream Poster, ref string err)
        {
            try
            {
                QuanLyRapPhimDataContext qlP = new QuanLyRapPhimDataContext();
                Phim p = new Phim();
                p.TenPhim =TenPhim;
                p.MaPhim = MaPhim;
                p.GiaVe = GiaVe;
                p.Poster = Poster.ToArray();

                qlP.Phims.InsertOnSubmit(p);
                qlP.Phims.Context.SubmitChanges();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không thêm được. Lỗi rồi!");
            }
            return true;
        }
        public bool XoaPhim(ref string err, string MaPhim)
        {
            try
            {
                QuanLyRapPhimDataContext qlP = new QuanLyRapPhimDataContext();
                var pQuery = from p in qlP.Phims
                              where p.MaPhim == MaPhim
                              select p;

                qlP.Phims.DeleteAllOnSubmit(pQuery);
                qlP.SubmitChanges();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!!!");
            }
            return true;
        }
        public bool CapNhatPhim(string MaPhim, string TenPhim,int GiaVe,MemoryStream Poster, ref string err)
        {
            try
            {
                QuanLyRapPhimDataContext qlP = new QuanLyRapPhimDataContext();
                var pQuery = (from p in qlP.Phims where p.MaPhim == MaPhim select p).SingleOrDefault();
                if (pQuery != null)
                {
                    pQuery.TenPhim = TenPhim;
                    pQuery.GiaVe = GiaVe;
                    pQuery.Poster = Poster.ToArray();
                    qlP.SubmitChanges();
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