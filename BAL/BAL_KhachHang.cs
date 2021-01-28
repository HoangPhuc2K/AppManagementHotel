using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using DAL;

namespace BAL
{
    public class BAL_KhachHang
    {
        private static BAL_KhachHang instance;

        public static BAL_KhachHang Instance 
        { 
            get { if (instance == null) BAL_KhachHang.instance = new BAL_KhachHang(); return instance; }
            set { instance = value; } 
        }
        private BAL_KhachHang() { }

        public List<BEL_KhachHang> LoadListKhachHang() 
        {
            List<BEL_KhachHang> list = new List<BEL_KhachHang>();
            DataTable data = DAL_KhachHang.Instance.LoadListKhachHang();
            foreach(DataRow row in data.Rows)
            {
                BEL_KhachHang item = new BEL_KhachHang(row);
                list.Add(item);
            }
            return list;
        }
        public BEL_KhachHang LoadKhachHangTheoMa(string Makh) 
        {
            BEL_KhachHang list = null;
            DataTable data = DAL_KhachHang.Instance.LoadKhachHangTheoMa(Makh);
            foreach (DataRow row in data.Rows)
            {
                list = new BEL_KhachHang(row);
            }
            return list;
        }
        public bool InsertCustomer(BEL_KhachHang kh)
        {
            int result = DAL_KhachHang.Instance.InsertCustomer(kh);
            return result > 0;
        }
        public bool UpCustomer(BEL_KhachHang kh)
        {
            int result = DAL_KhachHang.Instance.UpCustomer(kh);
            return result > 0;
        }
        public bool DellCustomer(string makh)
        {
            int result = DAL_KhachHang.Instance.DellCustomer(makh);
            return result > 0;
        }
        public List<BEL_KhachHang> SeachCus(string tennv)
        {
            List<BEL_KhachHang> list = new List<BEL_KhachHang>();
            DataTable data = DAL_KhachHang.Instance.SeachCus(tennv);
            if (data.Rows.Count > 0)
            {
                foreach (DataRow row in data.Rows)
                {
                    BEL_KhachHang item = new BEL_KhachHang(row);
                    list.Add(item);
                }
            }
            return list;
        }
        public bool KiemTraTonTai(string makh)
        {
            return DAL_KhachHang.Instance.KiemTraTonTai(makh);
        }
    }
}
