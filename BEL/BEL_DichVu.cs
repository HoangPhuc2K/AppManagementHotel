using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class BEL_DichVu
    {
        private string madv;

        public string Madv
        {
            get { return madv; }
            set { madv = value; }
        }
        private string tendv;

        public string Tendv
        {
            get { return tendv; }
            set { tendv = value; }
        }
        private float gia;

        public float Gia
        {
            get { return gia; }
            set { gia = value; }
        }
        private string donvi;

        public string Donvi
        {
            get { return donvi; }
            set { donvi = value; }
        }
        private string giamgia;

        public string Giamgia
        {
            get { return giamgia; }
            set { giamgia = value; }
        }
        public BEL_DichVu(string ma, string ten, float gia,string donvi,string giamgia) 
        {
            this.madv = ma;
            this.tendv = ten;
            this.gia = gia;
            this.donvi = donvi;
            this.giamgia = giamgia;
        }
        public BEL_DichVu(DataRow row)
        {
            this.madv = row["MaDV"].ToString();
            this.tendv = row["TenDichVu"].ToString();
            this.gia = float.Parse(row["Gia"].ToString());
            this.donvi = row["DonViTinh"].ToString();
            this.giamgia = row["GiamGia"].ToString();
        }
    }
}
