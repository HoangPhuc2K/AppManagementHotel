using BEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_ThietBi
    {
        private static DAL_ThietBi instance;
        public static DAL_ThietBi Instance
        {
            get { if (instance == null) DAL_ThietBi.instance = new DAL_ThietBi(); return DAL_ThietBi.instance; }
            set { DAL_ThietBi.instance = value; }
        }
        private DAL_ThietBi() { }

        public DataTable LoadThietBi()
        {
            DataTable Data = DataProvider.Instance.ExecuteQuery("select * from ThietBiPhong where TrangThai = 'Yes'");
            return Data;
        }
        public int InsertThietBi(BEL_ThietBi equip)
        {
            string sql = "INSERT INTO [dbo].[ThietBiPhong] VALUES( @maTB , @tenTB , @soluong , @maLoaiPhong , @trangthai )";
            int result = DataProvider.Instance.ExecuteNonQuery(sql, new object[] { equip.MaTB, equip.TenTB, equip.Soluong, equip.MaLoaiPhong, "Yes" });
            return result;
        }
        public int UpThietBi(BEL_ThietBi equip)
        {
            string sql = "UPDATE dbo.ThietBiPhong SET TenTB = @tenTB , SoLuong = @soluong , MaLoaiPhong = @maLoaiPhong WHERE MaTB = @maTB";
            int result = DataProvider.Instance.ExecuteNonQuery(sql, new object[] { equip.TenTB, equip.Soluong, equip.MaLoaiPhong, equip.MaTB });
            return result;
        }
        public int DelThietBi(BEL_ThietBi equip)
        {
            string sql = "UPDATE dbo.ThietBiPhong SET TrangThai = 'No' WHERE MaTB = @maTB";
            int result = DataProvider.Instance.ExecuteNonQuery(sql, new object[] { equip.MaTB });
            return result;
        }
    }
}
