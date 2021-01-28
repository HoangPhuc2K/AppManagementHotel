using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class BEL_HoaDonThue
    {
        private string mahd;
        private int manv;
        private string madatphong;
        private string matraphong;
        private string makh;
        private DateTime ngaylap;
        private float tiencoc;
        private float tongtien;
        private string trangthai;

        public BEL_HoaDonThue(string mahd, int  manv, string madatphong, string matraphong, string makh, DateTime ngaylap, float tiencoc, float tongtien, string trangthai)
        {
            this.mahd = mahd;
            this.manv = manv;
            this.madatphong = madatphong;
            this.matraphong = matraphong;
            this.makh = makh;
            this.ngaylap = ngaylap;
            this.tiencoc = tiencoc;
            this.tongtien = tongtien;
            this.trangthai = trangthai;
        }
        public BEL_HoaDonThue(DataRow row)
        {
            this.mahd = row["MaHD"].ToString();
            this.manv = int.Parse(row["MaNV"].ToString());
            this.madatphong = row["MaDatPhong"].ToString();
            this.matraphong = row["MaTraPhong"].ToString();
            this.makh = row["MaKH"].ToString();
            this.ngaylap = DateTime.Parse(row["NgayLapHD"].ToString());
            this.tiencoc = float.Parse(row["TienDatCoc"].ToString());
            this.tongtien = float.Parse(row["TongTienThue"].ToString());
            this.trangthai = row["TrangThai"].ToString();
        }
        public string Mahd
        {
            get { return mahd; }
            set { mahd = value; }
        }
        public int Manv
        {
            get { return manv; }
            set { manv = value; }
        }
        public string Madatphong
        {
            get { return madatphong; }
            set { madatphong = value; }
        }
        public string Matraphong
        {
            get { return matraphong; }
            set { matraphong = value; }
        }
        public string Makh
        {
            get { return makh; }
            set { makh = value; }
        }
        public DateTime Ngaylap
        {
            get { return ngaylap; }
            set { ngaylap = value; }
        }
        public float Tiencoc
        {
            get { return tiencoc; }
            set { tiencoc = value; }
        }
        public float Tongtien
        {
            get { return tongtien; }
            set { tongtien = value; }
        }
        public string Trangthai
        {
            get { return trangthai; }
            set { trangthai = value; }
        }
    }
}
