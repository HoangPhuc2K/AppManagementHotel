using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Quyen
    {
        private static DAL_Quyen instance;

        public static DAL_Quyen Instance
        {
            get { if (instance == null) DAL_Quyen.instance = new DAL_Quyen(); return DAL_Quyen.instance; }
            private set { DAL_Quyen.instance = value; }
        }

        private DAL_Quyen() { }

        public DataTable LoadListQuyen()
        {
            string sql = "select * from Quyen";
            DataTable data = DataProvider.Instance.ExecuteQuery(sql);
            return data;
        }
    }
}
