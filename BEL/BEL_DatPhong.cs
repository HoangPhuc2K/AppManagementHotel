using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class BEL_DatPhong
    {
        private string maDatPhong;
        private string maKH;
        private string soPhong;
        private DateTime ngayDatPhong;

        public BEL_DatPhong(string madatphong,string makh,string sophong,DateTime ngaydat) 
        {
            this.maDatPhong = madatphong;
            this.maKH = makh;
            this.soPhong = sophong;
            this.ngayDatPhong = ngaydat;
        }
        public BEL_DatPhong(DataRow row)
        {
            this.maDatPhong = row["MaDatPhong"].ToString();
            this.maKH = row["MaKH"].ToString();
            this.soPhong = row["SoPhong"].ToString();
            this.ngayDatPhong = DateTime.Parse(row["NgayDatPhong"].ToString());
        }


        public string MaDatPhong { get { return maDatPhong;} set { maDatPhong = value;} }
        public string MaKH { get { return maKH;} set { maKH = value;} }
        public string SoPhong { get { return soPhong;} set { soPhong = value;} }
        public DateTime NgayDatPhong { get { return ngayDatPhong; } set { NgayDatPhong = value; } }
    }
}
