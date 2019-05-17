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
    class BLNhanVien
    {

        public System.Data.Linq.Table<NhanVien> LayNhanVien()
        {
            DataSet ds = new DataSet();
            QuanLyRapPhimDataContext qlNV = new QuanLyRapPhimDataContext();
            return qlNV.NhanViens;
        }
        public bool ThemNhanVien(string MaNV, string HovaTenLotNV,
            string TenNV, string MaCV,int SoGioNghi, int NghiNam,ref string err)
        {
            try
            {
                QuanLyRapPhimDataContext qlNV = new QuanLyRapPhimDataContext();
                NhanVien nv = new NhanVien();
                nv.MaNV = MaNV;
                nv.HovaLotNV = HovaTenLotNV;
                nv.TenNV = TenNV;
                nv.MaCV = MaCV;
                nv.GioNghi = SoGioNghi;
                nv.TongGioNghi = NghiNam;

                qlNV.NhanViens.InsertOnSubmit(nv);
                qlNV.NhanViens.Context.SubmitChanges();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không thêm được. Lỗi rồi!");
            }
            return true;
        }
        public bool XoaNhanVien(ref string err, string MaNV)
        {
            try
            {
                QuanLyRapPhimDataContext qlNV = new QuanLyRapPhimDataContext();
                var nvQuery = from nv in qlNV.NhanViens
                              where nv.MaNV == MaNV
                              select nv;

                qlNV.NhanViens.DeleteAllOnSubmit(nvQuery);
                qlNV.SubmitChanges();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!!!");
            }
            return true;
        }
        public bool CapNhatNhanVien( string HovaLot,string TenNV,string MaCV,int SoGioNghi, int NghiNam,string MaNV, ref string err)
        {
            try
            {
                QuanLyRapPhimDataContext qlNV = new QuanLyRapPhimDataContext();
                var nvQuery = (from nv in qlNV.NhanViens where nv.MaNV == MaNV select nv).SingleOrDefault();
                if (nvQuery != null)
                {
                    nvQuery.HovaLotNV = HovaLot;
                    nvQuery.TenNV = TenNV;
                    nvQuery.MaCV = MaCV;
                    nvQuery.GioNghi = SoGioNghi;
                    nvQuery.TongGioNghi = NghiNam;
                    nvQuery.MaNV = MaNV;
                    qlNV.SubmitChanges();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Không sửa được. Lỗi rồi!");
            }
            return true;
        }

        public bool TimKiemNhanVien(string Ten)
        {
                QuanLyRapPhimDataContext qlNV = new QuanLyRapPhimDataContext();
                var nvQuery = (from nv in qlNV.NhanViens where nv.TenNV == Ten select nv).FirstOrDefault();
                if (nvQuery != null)
                return true;
            return false;
        }
    }
}