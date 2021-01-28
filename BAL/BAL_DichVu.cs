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
    public class BAL_DichVu
    {
        private static BAL_DichVu instance;

        public static BAL_DichVu Instance
        {
            get { if (instance == null) BAL_DichVu.instance = new BAL_DichVu(); return BAL_DichVu.instance; }
            private set { BAL_DichVu.instance = value; }
        }
        private BAL_DichVu() { }
        public List<BEL_DichVu> LoadListDV()
        {
            List<BEL_DichVu> list = new List<BEL_DichVu>();
            DataTable data = DAL_DichVu.Instance.LoadListDV();
            foreach (DataRow row in data.Rows)
            {
                BEL_DichVu item = new BEL_DichVu(row);
                list.Add(item);
            }
            return list;
        }
        public List<BEL_DichVu> TimDichVu(string tendv)
        {
            List<BEL_DichVu> list = new List<BEL_DichVu>();
            DataTable data = DAL_DichVu.Instance.TimDichVu(tendv);
            foreach (DataRow row in data.Rows)
            {
                BEL_DichVu item = new BEL_DichVu(row);
                list.Add(item);
            }
            return list;
        }
        public bool AddDichVu(BEL_DichVu dv)
        {
            int result = DAL_DichVu.Instance.AddDichVu(dv);
            return result > 0;
        }
        public bool UpDichVu(BEL_DichVu dv)
        {
            int result = DAL_DichVu.Instance.UpDichVu(dv);
            return result > 0;
        }
        public bool DelDichVu(string madv)
        {
            int result = DAL_DichVu.Instance.DelDichVu(madv);
            return result > 0;
        }
        public BEL_DichVu LoadDichVuTheoTen(string ten)
        {
            DataTable data = DAL_DichVu.Instance.LoadDichVuTheoTen(ten);
            BEL_DichVu dv = new BEL_DichVu(data.Rows[0]);
            return dv;
        }
        public List<BEL_DichVu> LoadDichVuTheoMaHD(string mahddv)
        {
            List<BEL_DichVu> list = new List<BEL_DichVu>();
            DataTable data = DAL_DichVu.Instance.LoadDichVuTheoMaHD(mahddv);
            if (data.Rows.Count > 0)
            {
                foreach (DataRow row in data.Rows)
                {
                    BEL_DichVu item = new BEL_DichVu(row);
                    list.Add(item);
                }
                return list;
            }
            return null;
        }
    }
}
