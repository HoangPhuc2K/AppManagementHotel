using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class BEL_TaiKhoan
    {
        private int matk;

        public int Matk
        {
            get { return matk; }
            set { matk = value; }
        }
        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
       
        private int manv;

        public int Manv
        {
            get { return manv; }
            set { manv = value; }
        }
        private DateTime lanCuoiDangNhap;

        public DateTime LanCuoiDangNhap
        {
            get { return lanCuoiDangNhap; }
            set { lanCuoiDangNhap = value; }
        }
        private string maquyen;

        public string Maquyen
        {
            get { return maquyen; }
            set { maquyen = value; }
        }
        private string trangthai;

        public string Trangthai
        {
            get { return trangthai; }
            set { trangthai = value; }
        }
        public BEL_TaiKhoan(int matk,string username,int manv,DateTime landangnhapcuoi,string maquyen,string trangthai)
        {
            this.matk = matk;
            this.username = username;
            this.manv = manv;
            this.lanCuoiDangNhap = landangnhapcuoi;
            this.maquyen = maquyen;
            this.trangthai = trangthai;
        }
        public BEL_TaiKhoan(DataRow row)
        {
            this.matk = int.Parse(row["MaTK"].ToString());
            this.username = row["Username"].ToString();
            this.manv = int.Parse(row["MaNV"].ToString());
            this.lanCuoiDangNhap = DateTime.Parse(row["LanDangNhapCuoi"].ToString());
            this.maquyen = row["MaQuyen"].ToString();
            this.trangthai = row["TrangThai"].ToString();
        }
    }
}
