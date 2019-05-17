using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace QuanLyRapPhim_Final.BSLayer
{
    class BLChucVu
    {

        public System.Data.Linq.Table<ChucVu> LayChucVu()
        {
            DataSet ds = new DataSet();
            QuanLyRapPhimDataContext qlCV = new QuanLyRapPhimDataContext();
            return qlCV.ChucVus;
        }
        
        public bool ThemChucVu(string MaCV, string ChucVu,
            int Luong, ref string err)
        {
            try
            {
                QuanLyRapPhimDataContext qlCV = new QuanLyRapPhimDataContext();
                ChucVu cv = new ChucVu();
                cv.MaCV = MaCV;
                cv.ChucVu1 = ChucVu;
                cv.Luong = Luong;

                qlCV.ChucVus.InsertOnSubmit(cv);
                qlCV.ChucVus.Context.SubmitChanges();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không thêm được. Lỗi rồi!");
            }
            return true;
        }
        public bool XoaChucVu(ref string err, string MaCV)
        {
            try
            {
                QuanLyRapPhimDataContext qlCV = new QuanLyRapPhimDataContext();
                var cvQuery = from cv in qlCV.ChucVus
                                where cv.MaCV == MaCV
                                select cv;

                qlCV.ChucVus.DeleteAllOnSubmit(cvQuery);
                qlCV.SubmitChanges();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!!!");
            }
            return true;
        }
        public bool CapNhatChucVu(string MaCV, string ChucVu,int Luong, ref string err)
        {
            try
            {
                QuanLyRapPhimDataContext qlCV = new QuanLyRapPhimDataContext();
                var cvQuery = (from cv in qlCV.ChucVus where cv.MaCV == MaCV select cv).SingleOrDefault();
                if (cvQuery != null)
                {
                    cvQuery.ChucVu1 = ChucVu;
                    cvQuery.Luong = Luong;
                    qlCV.SubmitChanges();
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
