using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class BAL_HoaDonDichVu
    {
        private static BAL_HoaDonDichVu instance;

        public static BAL_HoaDonDichVu Instance
        {
            get { if (instance == null) BAL_HoaDonDichVu.instance = new BAL_HoaDonDichVu(); return BAL_HoaDonDichVu.instance; }
            private set { BAL_HoaDonDichVu.instance = value; }
        }
        private BAL_HoaDonDichVu() { }

        public bool AddHoaDonDV(BEL_HoaDonDichVu dv)
        {
            int result = DAL_HoaDonDichVu.Instance.AddHoaDonDV(dv);
            return result > 0;
        }
        public void AddChiTiet(List<BEL_DichVu> dv,string sophong)
        {
            int mahd = LayHoaDonMoiNhat();
            foreach (BEL_DichVu item in dv)
            {
                int result = DAL_HoaDonDichVu.Instance.AddChiTiet(item, mahd.ToString(), sophong);
            }
        }
        public int LayHoaDonMoiNhat()
        {
            return DAL_HoaDonDichVu.Instance.LayHoaDonMoiNhat();
        }
        public BEL_HoaDonDichVu LayHoaDonTheoMaKH(string makh)
        {
            DataTable data = DAL_HoaDonDichVu.Instance.LayHoaDonTheoMakh(makh);
            if (data.Rows.Count > 0)
            {
                BEL_HoaDonDichVu dv = new BEL_HoaDonDichVu(data.Rows[0]);
                return dv;
            }
            return null;
        }
        public bool UpTongTien(string mahd, string thanhtien)
        {
            int result = DAL_HoaDonDichVu.Instance.UpTongTien(mahd, thanhtien);
            return result > 0;
        }
    }
}
