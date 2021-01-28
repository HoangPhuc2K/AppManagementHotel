using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_LoaiPhong
    {
        private static DAL_LoaiPhong instance;

        public static DAL_LoaiPhong Instance
        {
            get { if (instance == null) DAL_LoaiPhong.instance = new DAL_LoaiPhong(); return DAL_LoaiPhong.instance; }
            private set { DAL_LoaiPhong.instance = value; }
        }
        private DAL_LoaiPhong() { }
        public DataTable  LoadLoaiPhong()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from LoaiPhong");
            return data;
        }
        public DataTable LoadLoaiPhongTheoMa(string maloaiphong)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from LoaiPhong where MaLoaiPhong = @maloaiphong ", new object[] { maloaiphong });
            return data;
        }
        public DataTable LoadLoaiPhongTheoTen(string ten)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from LoaiPhong where TenLoaiPhong = @ten ", new object[] { ten });
            return data;
        }
    }
}
