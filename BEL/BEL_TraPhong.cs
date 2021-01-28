using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class BEL_TraPhong
    {
        private string matraphong;
        private string makh;
        private string sophong;
        private DateTime ngaytra;

        public BEL_TraPhong(string matraphong, string makh,string sophong,DateTime ngaytra)
        {
            this.matraphong = matraphong;
            this.makh = makh;
            this.sophong = sophong;
            this.ngaytra = ngaytra;
        }
        public BEL_TraPhong(DataRow row)
        {
            this.matraphong = row["MaTraPhong"].ToString();
            this.makh = row["MaKH"].ToString();
            this.sophong = row["SoPhong"].ToString();
            this.ngaytra = DateTime.Parse(row["NgayTraPhong"].ToString());
        }

        public DateTime Ngaytra
        {
            get { return ngaytra; }
            set { ngaytra = value; }
        }

        public string Sophong
        {
            get { return sophong; }
            set { sophong = value; }
        }

        public string Makh
        {
            get { return makh; }
            set { makh = value; }
        }

        public string Matraphong
        {
            get { return matraphong; }
            set { matraphong = value; }
        }
    }
}
