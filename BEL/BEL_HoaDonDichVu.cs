using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class BEL_HoaDonDichVu
    {
        private int mahd;

        public int Mahd
        {
            get { return mahd; }
            set { mahd = value; }
        }
        private string makh;

        public string Makh
        {
            get { return makh; }
            set { makh = value; }
        }
        private DateTime ngaydung;

        public DateTime Ngaydung
        {
            get { return ngaydung; }
            set { ngaydung = value; }
        }
        private string thanhtien;

        public string Thanhtien
        {
            get { return thanhtien; }
            set { thanhtien = value; }
        }

        private string manv;

        public string Manv
        {
            get { return manv; }
            set { manv = value; }
        }
        public BEL_HoaDonDichVu(int mahd,string makh, DateTime ngaysd,string thanhtien,string manv)
        {
            this.mahd = mahd;
            this.makh = makh;
            this.ngaydung = ngaysd;
            this.thanhtien = thanhtien;
            this.manv = manv;
        }
        public BEL_HoaDonDichVu(DataRow row)
        {
            this.mahd = int.Parse(row["MaHoaDonDV"].ToString());
            this.ngaydung = DateTime.Parse(row["NgaySuDung"].ToString());
            this.thanhtien = row["ThanhTien"].ToString();
            this.manv = row["MaNV"].ToString();
        }
    }
}
