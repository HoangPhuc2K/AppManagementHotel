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
    public class BAL_ThietBi
    {
        private static BAL_ThietBi instace;

        public static BAL_ThietBi Instance
        {
            get { if (instace == null) BAL_ThietBi.instace = new BAL_ThietBi(); return BAL_ThietBi.instace; }
            set { BAL_ThietBi.instace = value; }
        }
        private BAL_ThietBi() { }

        public List<BEL_ThietBi> LoadThietBi()
        {
            List<BEL_ThietBi> list = new List<BEL_ThietBi>();
            DataTable Data = DAL_ThietBi.Instance.LoadThietBi();
            foreach (DataRow row in Data.Rows)
            {
                BEL_ThietBi item = new BEL_ThietBi(row);
                list.Add(item);
            }
            return list;
        }
        public bool InsertThietBi(BEL_ThietBi tb)
        {
            int result = DAL_ThietBi.Instance.InsertThietBi(tb);
            return result > 0;
        }
        public bool UpThietBi(BEL_ThietBi tb)
        {
            int result = DAL_ThietBi.Instance.UpThietBi(tb);
            return result > 0;
        }
        public bool DelThietBi(BEL_ThietBi tb)
        {
            int result = DAL_ThietBi.Instance.DelThietBi(tb);
            return result > 0;
        }
    }
}
