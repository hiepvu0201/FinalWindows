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
    class BLRap
    {

        public System.Data.Linq.Table<Rap> LayRap()
        {
            DataSet ds = new DataSet();
            QuanLyRapPhimDataContext qlR = new QuanLyRapPhimDataContext();
            return qlR.Raps;
        }
        public bool ThemRap(string MaRap, string SoDayGhe, 
            string SoLuongGhe,string LoaiRap, ref string err)
        {
            try
            {
                QuanLyRapPhimDataContext qlR = new QuanLyRapPhimDataContext();
                Rap r = new Rap();
                r.SoDayGhe = SoDayGhe;
                r.SoLuongGhe = SoLuongGhe;
                r.LoaiPhim = LoaiRap;

                qlR.Raps.InsertOnSubmit(r);
                qlR.Raps.Context.SubmitChanges();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không thêm được. Lỗi rồi!");
            }
            return true;
        }
        public bool XoaRap(ref string err, string MaRap)
        {
            try
            {
                QuanLyRapPhimDataContext qlR = new QuanLyRapPhimDataContext();
                var rQuery = from r in qlR.Raps
                              where r.MaRap == MaRap
                              select r;

                qlR.Raps.DeleteAllOnSubmit(rQuery);
                qlR.SubmitChanges();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!!!");
            }
            return true;
        }
        public bool CapNhatRap(string MaRap, string SoDayGhe,string SoLuongGhe,string LoaiPhim, ref string err)
        {
            try
            {
                QuanLyRapPhimDataContext qlR = new QuanLyRapPhimDataContext();
                var rQuery = (from r in qlR.Raps where r.MaRap == MaRap select r).SingleOrDefault();
                if (rQuery != null)
                {
                    rQuery.SoDayGhe = SoDayGhe;
                    rQuery.SoLuongGhe = SoLuongGhe;
                    rQuery.LoaiPhim = LoaiPhim;
                    
                    qlR.SubmitChanges();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Không sửa được. Lỗi rồi!");
            }
            return true;
        }
        public int findrap(string marap)
        {
            QuanLyRapPhimDataContext qlrp = new QuanLyRapPhimDataContext();
            var temp = qlrp.Raps.Where(item => item.MaRap == marap).ToList();
            return temp.Count;
            //return db.executequerydataset
            //    ($"select marap from rap where marap='" +
            //    $"{marap.trim()}'", commandtype.text);
        }
        public void findsodayghe(string marap, ref int dayGhe)
        {
            QuanLyRapPhimDataContext qlrp = new QuanLyRapPhimDataContext();
            var temp = (from i in qlrp.Raps where i.MaRap == marap select i.SoDayGhe).ToList();
            dayGhe = Convert.ToInt32(temp[0]);
            //return db.executequerydataset
            //    ($"select sodayghe from rap where marap='" +
            //    $"{marap.trim()}'", commandtype.text);
        }
        public void findSoLuongGhe(string MaRap, ref int hangGhe)
        {
            QuanLyRapPhimDataContext qlrp = new QuanLyRapPhimDataContext();
            var temp = (from i in qlrp.Raps where i.MaRap == MaRap select i.SoDayGhe).ToList();
            hangGhe = Convert.ToInt32(temp[0]);
            //return db.ExecuteQueryDataSet
            //    ($"select SoLuongGhe from Rap where MaRap='" +
            //    $"{MaRap.Trim()}'", CommandType.Text);
        }
    }
}