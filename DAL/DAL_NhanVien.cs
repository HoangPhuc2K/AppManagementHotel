using BEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_NhanVien
    {
        private static DAL_NhanVien instance;

        public static DAL_NhanVien Instance
        {
            get { if (instance == null) DAL_NhanVien.instance = new DAL_NhanVien(); return DAL_NhanVien.instance; }
            private set { DAL_NhanVien.instance = value; }
        }
        private DAL_NhanVien() { }

        public DataTable LoadListNV()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from NhanVien where TrangThai = 'Yes'");
            return data;
        }
        public int AddNhanVien(BEL_NhanVien nv)
        {
            string sql = "INSERT INTO [dbo].[NhanVien] " +
                "VALUES( @diachi , @tennv , @gioitinh , @ngaysinh , @heso , @cmnd , @chucvu , @trangthai )";
            int result = DataProvider.Instance.ExecuteNonQuery(sql, new object[] { nv.Diachi, nv.Tennv, nv.Gioitinh ,nv.Ngaysinh,nv.Hesoluong, nv.Cmnd, nv.Chucvu, "Yes" });
            return result;
        }
        public int UpNhanVien(BEL_NhanVien nv)
        {
            string sql = "UPDATE [dbo].[NhanVien] " +
                "SET DiaChi = @diahi , TenNhanVien = @tennv , GioiTinh = @gioitinh , NgaySinh = @ngaysinh , HeSoLuong = @heso , CMND = @cmnd , ChucVu = @chucvu , TrangThai = @trangthai where MaNV = @manv ";
            int result = DataProvider.Instance.ExecuteNonQuery(sql, new object[] { nv.Diachi, nv.Tennv, nv.Gioitinh, nv.Ngaysinh ,nv.Hesoluong, nv.Cmnd, nv.Chucvu, "Yes", nv.Manv });
            return result;
        }
        public int DelNhanVien(BEL_NhanVien nv)
        {
            string sql = "UPDATE [dbo].[NhanVien] " +
                " SET TrangThai = 'No' WHERE MaNV = @manv ";
            int result = DataProvider.Instance.ExecuteNonQuery(sql, new object[] { nv.Manv });
            return result;
        }
        public DataTable TimNhanVien(string ten)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from NhanVien where TenNhanVien like '%"+ten+"%' and TrangThai = 'Yes'");
            return data;
        }
    }
}
