using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BEL;
using System.Data;

namespace BAL
{
    public class BAL_HoaDonThue
    {
        private static BAL_HoaDonThue instance;

        public static BAL_HoaDonThue Instance
        {
            get { if (instance == null) BAL_HoaDonThue.instance = new BAL_HoaDonThue(); return BAL_HoaDonThue.instance; }
            private set { BAL_HoaDonThue.instance = value; }
        }
        private BAL_HoaDonThue() { }

        public List<BEL_HoaDonThue> LoadHoaDon()
        {
            List<BEL_HoaDonThue> list = new List<BEL_HoaDonThue>();
            DataTable data = DAL_HoaDonThue.Instance.LoadHoaDon();
            foreach (DataRow row in data.Rows)
            {
                BEL_HoaDonThue item = new BEL_HoaDonThue(row);
                list.Add(item);
            }
            return list;
        }
        public BEL_HoaDonThue LoadHDThueTheoPhong(string sophong)
        {
            DataTable data = DAL_HoaDonThue.Instance.LoadHDThueTheoPhong(sophong);
            BEL_HoaDonThue item = new BEL_HoaDonThue(data.Rows[0]);
            return item;
        }
        public BEL_HoaDonThue LoadHDThueTheoMaDP(string madp)
        {
            DataTable data = DAL_HoaDonThue.Instance.LoadHDThueTheoMaDP(madp);
            BEL_HoaDonThue item = new BEL_HoaDonThue(data.Rows[0]);
            return item;
        }
        public bool AddHoaDon(BEL_HoaDonThue hd,string makh,string sophong)
        {
            return DAL_HoaDonThue.Instance.AddHoaDon(hd,makh, sophong);
        }
        public bool UpHoaDon(string matp,string mahd,float tong)
        {
            int result = DAL_HoaDonThue.Instance.UpHoaDon(matp, mahd, tong);
            return result > 0;
        }
        public bool AddChiTiet(string mahd, string sophong)
        {
            int result_2 = DAL_HoaDonThue.Instance.AddChiTiet(mahd,sophong);
            return result_2 > 0;
        }
    }
}
