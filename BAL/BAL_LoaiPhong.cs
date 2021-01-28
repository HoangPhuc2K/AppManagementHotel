using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using DAL;
using System.Data;

namespace BAL
{
    public class BAL_LoaiPhong
    {
        private static BAL_LoaiPhong instance;

        public static BAL_LoaiPhong Instance
        {
            get { if (instance == null) BAL_LoaiPhong.instance = new BAL_LoaiPhong(); return BAL_LoaiPhong.instance; }
            private set { BAL_LoaiPhong.instance = value; }
        }
        private BAL_LoaiPhong(){}
        public List<BEL_LoaiPhong> LoadLoaiPhong()
        {
            List<BEL_LoaiPhong> list = new List<BEL_LoaiPhong>();
            DataTable data = DAL_LoaiPhong.Instance.LoadLoaiPhong();
            foreach (DataRow row in data.Rows)
            {
                BEL_LoaiPhong item = new BEL_LoaiPhong(row);
                list.Add(item);
            }
            return list;
        }
        public BEL_LoaiPhong LoadLoaiPhongTheoMa(string maloaiphong)
        {
            BEL_LoaiPhong item = null;
            DataTable data = DAL_LoaiPhong.Instance.LoadLoaiPhongTheoMa(maloaiphong);
            foreach(DataRow row in data.Rows)
            {
               item = new BEL_LoaiPhong(row);
            }
            return item;
        }
        public BEL_LoaiPhong LoadLoaiPhongTheoTen(string ten)
        {
            BEL_LoaiPhong item = null;
            DataTable data = DAL_LoaiPhong.Instance.LoadLoaiPhongTheoTen(ten);
            foreach (DataRow row in data.Rows)
            {
                item = new BEL_LoaiPhong(row);
            }
            return item;
        }
    }
}
