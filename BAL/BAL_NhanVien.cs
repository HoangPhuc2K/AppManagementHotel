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
    public class BAL_NhanVien
    {
        private static BAL_NhanVien instance;

        public static BAL_NhanVien Instance
        {
            get { if(instance == null) BAL_NhanVien.instance = new BAL_NhanVien(); return BAL_NhanVien.instance; }
            private set { BAL_NhanVien.instance = value; }
        }
        private BAL_NhanVien() { }

        public List<BEL_NhanVien> LoadListNV()
        {
            List<BEL_NhanVien> list = new List<BEL_NhanVien>();
            DataTable data = DAL_NhanVien.Instance.LoadListNV();
            foreach (DataRow row in data.Rows)
            {
                BEL_NhanVien item = new BEL_NhanVien(row);
                list.Add(item);
            }
            return list;
        }
        public bool AddNhanVien(BEL_NhanVien nv)
        {
            int result = DAL_NhanVien.Instance.AddNhanVien(nv);
            return result > 0;
        }
        public bool UpNhanVien(BEL_NhanVien nv)
        {
            int result = DAL_NhanVien.Instance.UpNhanVien(nv);
            return result > 0;
        }
        public bool DelNhanVien(BEL_NhanVien nv)
        {
            int result = DAL_NhanVien.Instance.DelNhanVien(nv);
            return result > 0;
        }
        public List<BEL_NhanVien> TimNhanVien(string ten)
        {
            List<BEL_NhanVien> list = new List<BEL_NhanVien>();
            DataTable data = DAL_NhanVien.Instance.TimNhanVien(ten);
            foreach (DataRow row in data.Rows)
            {
                BEL_NhanVien item = new BEL_NhanVien(row);
                list.Add(item);
            }
            return list;
        }
    }
}
