using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class BEL_Phong
    {
        private string sophong;
        private string maloaiphong;
        private string trangthaiphong;
        public BEL_Phong(string sophong,string maloaiphong,string trangthaiphong)
        {
            this.sophong = sophong;
            this.maloaiphong = maloaiphong;
            this.trangthaiphong = trangthaiphong;
        }
        public BEL_Phong(DataRow row)
        {
            this.sophong = row["SoPhong"].ToString();
            this.maloaiphong = row["MaLoaiPhong"].ToString();
            this.trangthaiphong = row["TrangThaiPhong"].ToString();
        }
        public string Sophong { get { return sophong;} set { sophong = value;} }
        public string Maloaiphong { get { return maloaiphong;} set { maloaiphong = value;} }
        public string Trangthaiphong { get { return trangthaiphong; } set { trangthaiphong = value; } }
    }
}
