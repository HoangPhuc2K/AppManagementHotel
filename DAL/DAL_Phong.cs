using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using System.Data;

namespace DAL
{
    public class DAL_Phong
    {
        private static DAL_Phong instance;

        public static DAL_Phong Instance
        {
            get { if (instance == null) DAL_Phong.instance = new DAL_Phong(); return DAL_Phong.instance; }
            private set { DAL_Phong.instance = value; }
        }
        private DAL_Phong() { }

        public DataTable LoadRoomList()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from Phong where TrangThai = 'Yes'");
            return data;
        }
        public DataTable LoadRoomSoPhong(string sophong)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from Phong where SoPhong = @sophong and TrangThai = 'Yes'", new object[] { sophong });
            return data;
        }
        public DataTable LoadRoomTrangThai(string trangthai)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from Phong where TrangThaiPhong = @TrangThaiPhong and TrangThai = 'Yes'", new object[] { trangthai });
            return data;
        }
        public int InsertRoom(BEL_Phong room)
        {
            string sql = "INSERT INTO [dbo].[Phong] VALUES( @SoPhong , @MaLoaiPhong , @TrangThaiPhong , @trangthai )";
            int result = DataProvider.Instance.ExecuteNonQuery(sql, new object[] { room.Sophong, room.Maloaiphong, "No","Yes"});
            return result;
        }
        public int UpdateRoom(BEL_Phong room)
        {
            string sql = "UPDATE dbo.Phong SET MaLoaiPhong = @maloaiphong WHERE SoPhong = @sophong";
            int result = DataProvider.Instance.ExecuteNonQuery(sql, new object[] { room.Maloaiphong, room.Sophong });
            return result;
        }
        public int UpdateRoomTrangThai(string sophong,string trangthai)
        {
            string sql = "UPDATE dbo.Phong SET TrangThaiPhong = @trangthai WHERE SoPhong = @sophong";
            int result = DataProvider.Instance.ExecuteNonQuery(sql, new object[] {trangthai,sophong });
            return result;
        }
        public int DeleteRoom(BEL_Phong room)
        {
            string sql = "UPDATE dbo.Phong SET TrangThai = 'No' WHERE SoPhong = @sophong";
            int result = DataProvider.Instance.ExecuteNonQuery(sql, new object[] { room.Sophong });
            return result;
        }
    }
}
