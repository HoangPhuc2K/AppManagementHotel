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
    public class BAL_TraPhong
    {
        private static BAL_TraPhong instance;

        public static BAL_TraPhong Instansce
        {
            get { if (instance == null) BAL_TraPhong.instance = new BAL_TraPhong(); return BAL_TraPhong.instance; }
            private set { BAL_TraPhong.instance = value; }
        }
        private BAL_TraPhong() { }

        public List<BEL_TraPhong> LoadListTraPhong()
        {
            List<BEL_TraPhong> list = new List<BEL_TraPhong>();
            DataTable data = DAL_TraPhong.Instance.LoadListTraPhong();
            foreach (DataRow row in data.Rows)
            {
                BEL_TraPhong item = new BEL_TraPhong(row);
                list.Add(item);
            }
            return list;
        }
        public bool AddTraPhong(BEL_TraPhong tp)
        {
            int result = DAL_TraPhong.Instance.AddTraPhong(tp);
            return result > 0;
        }
        public bool KiemTraTonTai(string matp)
        {
            return DAL_TraPhong.Instance.KiemTraTonTai(matp);
        }
    }
}
