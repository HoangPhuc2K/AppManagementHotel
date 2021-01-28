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
    public class BAL_Quyen
    {
        private static BAL_Quyen instance;

        public static BAL_Quyen Instance
        {
            get { if (instance == null) BAL_Quyen.instance = new BAL_Quyen(); return BAL_Quyen.instance; }
            private set { BAL_Quyen.instance = value; }
        }
        private BAL_Quyen() { }

        public List<BEL_Quyen> LoadListQuyen()
        {
            List<BEL_Quyen> list = new List<BEL_Quyen>();
            DataTable data = DAL_Quyen.Instance.LoadListQuyen();
            foreach (DataRow row in data.Rows)
            {
                BEL_Quyen item = new BEL_Quyen(row);
                list.Add(item);
            }
            return list;
        }
    }
}
