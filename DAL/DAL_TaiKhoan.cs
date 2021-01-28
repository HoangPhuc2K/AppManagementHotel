using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using System.Data;

namespace DAL
{
    public class DAL_TaiKhoan
    {
        private static DAL_TaiKhoan instance;

        public static DAL_TaiKhoan Instance
        {
            get { if (instance == null) DAL_TaiKhoan.instance = new DAL_TaiKhoan(); return DAL_TaiKhoan.instance; }
            private set { DAL_TaiKhoan.instance = value; }
        }
        private DAL_TaiKhoan() { }
        public bool Login(string Username, string Password)
        {
            string sql = "SELECT * FROM dbo.TaiKhoan WHERE Username = @Username AND Password = @Password";
            DataTable result = DataProvider.Instance.ExecuteQuery(sql, new object[] { Username, Password });
            if (result.Rows.Count > 0)
            {
                string UP = "UPDATE [dbo].[TaiKhoan] " +
                "SET LanDangNhapCuoi = GETDATE() WHERE Username = @username";
                DataProvider.Instance.ExecuteNonQuery(UP, new object[] { Username });
                return true;
            }
            return false;
        }
        public int AddAccount(BEL_TaiKhoan tk,string mk)
        {
            string sql = "INSERT INTO [dbo].[TaiKhoan] " +
                "VALUES( @username , @manv , @password , @landangnhapcuoi , @maquyen , @trangthai )";
            int result = DataProvider.Instance.ExecuteNonQuery(sql, new object[] { tk.Username, tk.Manv,mk, tk.LanCuoiDangNhap, tk.Maquyen, tk.Trangthai });
            return result;
        }
        public int UpAccount(BEL_TaiKhoan tk)
        {
            string sql = "UPDATE [dbo].[TaiKhoan] " +
                "SET MaNV = @manv, LanDangNhapCuoi = @lancuoi , MaQuyen = @maquyen , TrangThai = @trangthai WHERE MaNV = @manv ";
            int result = DataProvider.Instance.ExecuteNonQuery(sql, new object[] { tk.Manv, tk.LanCuoiDangNhap, tk.Maquyen, tk.Trangthai, tk.Manv });
            return result;
        }
        public int DelAccount(int manv)
        {
            string sql = "UPDATE [dbo].[TaiKhoan] SET TrangThai = 'No' WHERE MaNV = @manv";
            int result = DataProvider.Instance.ExecuteNonQuery(sql, new object[] { manv });
            return result;
        }
        public DataTable LoadListTK()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from TaiKhoan where MaQuyen != 'Q001' and TrangThai = 'Yes'");
            return data;
        }
        public DataTable LoadTK(string Username, string Password)
        {
            string sql = "SELECT * FROM dbo.TaiKhoan WHERE Username = @Username AND Password = @Password";
            DataTable data = DataProvider.Instance.ExecuteQuery(sql, new object[] { Username, Password });
            return data;
        }
        public int ResetPassword(int MaNV,string Password)
        {
            string sql = "UPDATE [dbo].[TaiKhoan] " +
                "SET Password = @Pass WHERE MaNV = @manv ";
            int result = DataProvider.Instance.ExecuteNonQuery(sql, new object[] { Password, MaNV });
            return result;
        }
        public int DoiMatKhau(string password,string tentk)
        {
            string sql = "UPDATE TaiKhoan " +
                "SET Password = @Pass WHERE Username = @tentk ";
            int result = DataProvider.Instance.ExecuteNonQuery(sql, new object[] { password, tentk });
            return result;
        }
    }
}
