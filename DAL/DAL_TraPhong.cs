using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using System.Data;

namespace DAL
{
    public class DAL_TraPhong
    {
        private static DAL_TraPhong instance;

        public static DAL_TraPhong Instance
        {
            get { if (instance == null) DAL_TraPhong.instance = new DAL_TraPhong(); return DAL_TraPhong.instance; }
            private set { DAL_TraPhong.instance = value; }
        }
        private DAL_TraPhong() { }
        public DataTable LoadListTraPhong()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from TraPhong");
            return data;
        }
        public int AddTraPhong(BEL_TraPhong tp)
        {
            string sql = "INSERT INTO [dbo].[TraPhong] VALUES( @matraphong , @makh , @sophong , @ngaytra )";
            int result = DataProvider.Instance.ExecuteNonQuery(sql, new object[] { tp.Matraphong, tp.Makh, tp.Sophong, tp.Ngaytra });
            return result;
        }
        public bool KiemTraTonTai(string matp)
        {
            string sql = "select * from TraPhong where MaTP = @matp ";
            DataTable data = DataProvider.Instance.ExecuteQuery(sql, new object[] { matp });
            return data.Rows.Count > 0;
        }
    }
}
