using BEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_KhachHang
    {
        private static DAL_KhachHang instance;

        public static DAL_KhachHang Instance
        {
            get { if (instance == null) DAL_KhachHang.instance = new DAL_KhachHang(); return DAL_KhachHang.instance; }
            private set { DAL_KhachHang.instance = value; }
        }
        private DAL_KhachHang() { }
        public DataTable LoadListKhachHang()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from KhachHang");
            return data;
        }
        public DataTable LoadKhachHangTheoMa(string Makh)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from KhachHang where MaKH = @makh ", new object[] { Makh });
            return data;
        }
        public int InsertCustomer(BEL_KhachHang kh)
        {
            string sql = "INSERT INTO dbo.KhachHang " +
                        " VALUES( @MaKH , @HoTenKH , @GioiTinh , @SDT , @NgaySinh , @DiaChi , @QuocTich , @cmnd , @trangthai )";
            int result = DataProvider.Instance.ExecuteNonQuery(sql, new object[] { kh.MaKH, kh.Hotenkh, kh.Gioitinh, kh.Sdt, kh.Ngaysinh, kh.Diachi, kh.Quoctich, kh.Cmnd, "Yes" });
            return result;
        }
        public int UpCustomer(BEL_KhachHang kh)
        {
            string sql = " UPDATE [dbo].[KhachHang] " +
                        " SET HoTenKH = @HoTenKH , GioiTinh = @GioiTinh , SDT = @SDT , NgaySinh = @NgaySinh , DiaChi = @DiaChi , QuocTich = @QuocTich , CMND = @cmnd " +
                        " WHERE MaKH = @MaKH ";
            int result = DataProvider.Instance.ExecuteNonQuery(sql, new object[] { kh.Hotenkh, kh.Gioitinh, kh.Sdt, kh.Ngaysinh, kh.Diachi, kh.Quoctich, kh.Cmnd, kh.MaKH });
            return result;
        }
        public int DellCustomer(string makh)
        {
            string sql = "UPDATE dbo.KhachHang SET TrangThai = 'No' " +
                    "WHERE MaKH = @MaKH";
            int result = DataProvider.Instance.ExecuteNonQuery(sql, new object[] { makh });
            return result;
        }
        public DataTable SeachCus(string tennv)
        {
            string sql = "select * from [dbo].[KhachHang] where HoTenKH like '%" + tennv + "%'";
            DataTable data = DataProvider.Instance.ExecuteQuery(sql);
            return data;
        }
        public bool KiemTraTonTai(string makh)
        {
            string sql = "select * from KhachHang where MaKH = @makh ";
            DataTable data = DataProvider.Instance.ExecuteQuery(sql, new object[] { makh });
            return data.Rows.Count > 0;
        }
    }
}
