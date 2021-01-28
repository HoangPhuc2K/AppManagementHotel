using BEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_DatPhong
    {
        private static DAL_DatPhong instance;

        public static DAL_DatPhong Instance
        {
            get { if (instance == null) DAL_DatPhong.instance = new DAL_DatPhong(); return DAL_DatPhong.instance; }
            private set { DAL_DatPhong.instance = value; }
        }
        private DAL_DatPhong() { }

        public DataTable LoadDatPhong()
        {
            DataTable Data = DataProvider.Instance.ExecuteQuery("select * from DatPhong where TrangThaiDat = 'No'");
            return Data;
        }
        public DataTable LoadDatPhongTheoSoPhong(string sophong)
        {
            DataTable Data = DataProvider.Instance.ExecuteQuery("select * from DatPhong where TrangThaiDat = 'No' and SoPhong = @sophong ", new object[] { sophong });
            return Data;
        }
        public DataTable LoadDatPhongTheoMa(string madp)
        {
            DataTable Data = DataProvider.Instance.ExecuteQuery("select * from DatPhong where MaDatPhong = @madp ", new object[] { madp });
            return Data;
        }
        public int AddDatPhong(BEL_DatPhong room)
        {
            string sql = "INSERT INTO dbo.DatPhong VALUES( @madp , @makh , @sophong , @ngaydat , @trangthai )";
            int result = DataProvider.Instance.ExecuteNonQuery(sql, new object[] { room.MaDatPhong, room.MaKH, room.SoPhong, room.NgayDatPhong,"No" });
            return result;
        }
        public int UpTrangThaiDat(string makh)
        {
            string sql = "UPDATE dbo.DatPhong SET TrangThaiDat = 'Yes' WHERE MaKH = @makh ";
            int result = DataProvider.Instance.ExecuteNonQuery(sql,new object[]{makh});
            return result;
        }
        public bool KiemTraTonTai(string madp)
        {
            string sql = "select * from DatPhong where MaDP = @madp ";
            DataTable data = DataProvider.Instance.ExecuteQuery(sql, new object[] { madp });
            return data.Rows.Count > 0;
        }
    }
}
