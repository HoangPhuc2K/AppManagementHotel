using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class BEL_LoaiPhong
    {
        private string maloaiphong;
        private string tenloaiphong;
        private float giaphong;

        public BEL_LoaiPhong(string maloaiphong,string ten, float giatien)
        {
            this.maloaiphong = maloaiphong;
            this.tenloaiphong = ten;
            this.giaphong = giatien;
        }
        public BEL_LoaiPhong(DataRow row)
        {
            this.maloaiphong = row["MaLoaiPhong"].ToString();
            this.tenloaiphong = row["TenLoaiPhong"].ToString();
            this.giaphong = float.Parse(row["GiaPhong"].ToString());
        }
        public string Maloaiphong
        {
            get { return maloaiphong; }
            set { maloaiphong = value; }
        }
        public string Tenloaiphong
        {
            get { return tenloaiphong; }
            set { tenloaiphong = value; }
        }
        public float Giaphong
        {
            get { return giaphong; }
            set { giaphong = value; }
        }
    }
}
