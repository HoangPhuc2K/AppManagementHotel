using BEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_HoaDonDichVu
    {
        private static DAL_HoaDonDichVu instance;

        public static DAL_HoaDonDichVu Instance
        {
            get { if (instance == null) DAL_HoaDonDichVu.instance = new DAL_HoaDonDichVu(); return DAL_HoaDonDichVu.instance; }
            private set { DAL_HoaDonDichVu.instance = value; }
        }

        private DAL_HoaDonDichVu() { }

        public int AddHoaDonDV(BEL_HoaDonDichVu dv)
        {
            string sql = " INSERT INTO  HoaDonDichVu ( ThanhTien , MaNV, MaKH ) "+
                " VALUES( @thanhtien , @manv , @makh )";
            int result = DataProvider.Instance.ExecuteNonQuery(sql, new object[] { dv.Thanhtien, dv.Manv,dv.Makh });
            return result;
        }
        public int AddChiTiet(BEL_DichVu dv,string mahd,string sophong)
        {
            string sql = "INSERT INTO ChiTietHoaDonDichVu " +
                "VALUES( @madv , @mahd , @sophong )";
            int result = DataProvider.Instance.ExecuteNonQuery(sql, new object[] { dv.Madv, mahd, sophong });
            return result;
        }
        public int LayHoaDonMoiNhat()
        { 
            string sql = " select Max(MaHoaDonDV) from HoaDonDichVu where TrangThai = 'Yes'";
            object result = DataProvider.Instance.ExecuteScalar(sql);
            return int.Parse(result.ToString());
        }
        public DataTable LayHoaDonTheoMakh(string makh)
        {
            string sql = "select * from HoaDonDichVu where TrangThai = 'Yes' and MaKH = @makh ";
            DataTable data = DataProvider.Instance.ExecuteQuery(sql,new object[] { makh});
            return data;
        }
        public int UpTongTien(string mahd,string thanhtien)
        {
            string sql = "UPDATE HoaDonDichVu SET ThanhTien = @thanhtien where MaHoaDonDV = @mahddv ";
            int result = DataProvider.Instance.ExecuteNonQuery(sql, new object[] { thanhtien, mahd });
            return result;
        }
    }
}
