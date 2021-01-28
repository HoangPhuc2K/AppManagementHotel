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
    public class BAL_DatPhong
    {
        private static BAL_DatPhong instance;

        public static BAL_DatPhong Instance { get { if (instance == null) BAL_DatPhong.instance = new BAL_DatPhong(); return instance; }
            private set { instance = value; } 
        }
        private BAL_DatPhong() { }

        public List<BEL_DatPhong> LoadDatPhong() 
        {
            List<BEL_DatPhong> list = new List<BEL_DatPhong>();
            DataTable Data = DAL_DatPhong.Instance.LoadDatPhong();
            foreach (DataRow row in Data.Rows)
            {
                BEL_DatPhong item = new BEL_DatPhong(row);
                list.Add(item);
            }
            return list;
        }
        public BEL_DatPhong LoadDatPhongTheoSoPhong(string sophong)
        {
            BEL_DatPhong list = null;
            DataTable Data = DAL_DatPhong.Instance.LoadDatPhongTheoSoPhong(sophong);
            foreach (DataRow row in Data.Rows)
            {
                list = new BEL_DatPhong(row);
            }
            return list;
        }
        public bool AddDatPhong(BEL_DatPhong room) 
        {
            int result = DAL_DatPhong.Instance.AddDatPhong(room);
            return result > 0;
        }
        public bool UpTrangThaiDat(string makh)
        {
            int result = DAL_DatPhong.Instance.UpTrangThaiDat(makh);
            return result > 0;
        }
        public BEL_DatPhong LoadDatPhongTheoMa(string madp)
        {
            DataTable Data = DAL_DatPhong.Instance.LoadDatPhongTheoMa(madp);
            if (Data.Rows.Count > 0)
            {
                BEL_DatPhong item = new BEL_DatPhong(Data.Rows[0]);
                return item;
            }
            return null;
        }
        public bool KiemTraTonTai(string madp)
        {
            return DAL_DatPhong.Instance.KiemTraTonTai(madp);
        }
    }
}
