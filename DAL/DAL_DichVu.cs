using BEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_DichVu
    {
        private static DAL_DichVu instance;

        public static DAL_DichVu Instance
        {
            get { if (instance == null) DAL_DichVu.instance = new DAL_DichVu(); return DAL_DichVu.instance; }
            private set { DAL_DichVu.instance = value; }
        }
        private DAL_DichVu() { }
        public DataTable LoadListDV()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from DichVu where TrangThai = 'Yes'");
            return data;
        }
        public int AddDichVu(BEL_DichVu dv)
        {
            string sql = "INSERT INTO [dbo].[DichVu] " +
                "VALUES( @tendv , @gia , @donvi , @trangthai , @giamgia )";
            int result = DataProvider.Instance.ExecuteNonQuery(sql, new object[] {  dv.Tendv,dv.Gia,dv.Donvi,"Yes",dv.Giamgia});
            return result;
        }
        public int UpDichVu(BEL_DichVu dv)
        {
            string sql = "UPDATE [dbo].[DichVu] " +
                "SET TenDichVu = @ten , Gia = @gia , DonViTinh = @donvi , GiamGia = @giamgia WHERE MaDV = @madv ";
            int result = DataProvider.Instance.ExecuteNonQuery(sql, new object[] {  dv.Tendv, dv.Gia,dv.Donvi,dv.Giamgia,dv.Madv});
            return result;
        }
        public int DelDichVu(string madv)
        {
            string sql = "UPDATE [dbo].[DichVu] " +
                " SET TrangThai = 'No' WHERE MaDV = @madv ";
            int result = DataProvider.Instance.ExecuteNonQuery(sql, new object[] { madv });
            return result;
        }
        public DataTable LoadDichVuTheoTen(string ten)
        {
            string sql = "select * from DichVu where TenDichVu = @ten ";
            DataTable data = DataProvider.Instance.ExecuteQuery(sql, new object[] {ten});
            return data;
        }
        public DataTable LoadDichVuTheoMaHD(string mahddv)
        {
            string sql = "select DichVu.MaDV,TenDichVu,Gia,DonViTinh,GiamGia from DichVu,ChiTietHoaDonDichVu where DichVu.MaDV = ChiTietHoaDonDichVu.MaDV and MaHoaDonDV = @mahddv ";
            DataTable data = DataProvider.Instance.ExecuteQuery(sql, new object[] { mahddv });
            return data;
        }
        public DataTable TimDichVu(string tendv)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from DichVu where TenDichVu like '%"+tendv+"%' and TrangThai = 'Yes'");
            return data;
        }
    }
}
