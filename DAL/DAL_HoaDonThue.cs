using BEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAL
{
    public class DAL_HoaDonThue
    {
        private static DAL_HoaDonThue instance;

        public static DAL_HoaDonThue Instance
        {
            get { if (instance == null) DAL_HoaDonThue.instance = new DAL_HoaDonThue(); return DAL_HoaDonThue.instance; }
            private set { DAL_HoaDonThue.instance = value; }
        }
        private DAL_HoaDonThue() { }
        public DataTable LoadHoaDon()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from dbo.HoaDonThuePhong");
            return data;
        }
        public DataTable LoadHDThueTheoPhong(string sophong)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from HoaDonThuePhong HD,ChiTietHoaDonThuePhong CT where HD.MaHD = CT.MaHD and CT.SoPhong = @sophong ", new object[] { sophong });
            return data;
        }
        public DataTable LoadHDThueTheoMaDP(string madp)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from HoaDonThuePhong where MaDatPhong = @madp ", new object[] { madp });
            return data;
        }
        public bool AddHoaDon(BEL_HoaDonThue hd, string makh, string sophong)
        {
            string sql_1 = "INSERT INTO [dbo].[HoaDonThuePhong] " + " ( [MaNV] , [MaDatPhong] , [MaTraPhong] ,[MaKH] ,[NgayLapHD] ,[TienDatCoc] ,[TongTienThue] ,[TrangThai]) " +
                "VALUES( @manv , @madp , NULL , @makh , GETDATE() , @tiencoc , @tongtien , @trangthai )";
            int result_1 = DataProvider.Instance.ExecuteNonQuery(sql_1, new object[] { hd.Manv, hd.Madatphong, hd.Makh, hd.Tiencoc, hd.Tongtien, hd.Trangthai });
            return result_1 > 0;
        }
        public int AddChiTiet(string mahd, string sophong)
        {
            string sql = "INSERT INTO ChiTietHoaDonThuePhong " +
                "VALUES( @mahd , @sophong )";
            int result = DataProvider.Instance.ExecuteNonQuery(sql, new object[] { mahd, sophong });
            return result;
        }
        public int UpHoaDon(string matp, string mahd, float tong)
        {
            int result = 0;
            if (matp == null)
            {
                string sql = "UPDATE dbo.HoaDonThuePhong " +
                "SET MaTraPhong = NULL , TongTienThue = @tong  where MaHD = @mahd ";
                result = DataProvider.Instance.ExecuteNonQuery(sql, new object[] { tong, mahd });
            }
            else
            {
                string sql = "UPDATE dbo.HoaDonThuePhong " +
                    "SET MaTraPhong = @traphong , TongTienThue = @tong  where MaHD = @mahd ";
                result = DataProvider.Instance.ExecuteNonQuery(sql, new object[] { matp, tong, mahd });
            }
            return result;
        }
    }
}
