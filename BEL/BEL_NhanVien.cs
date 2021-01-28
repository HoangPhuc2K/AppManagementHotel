using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class BEL_NhanVien
    {
        private int manv;
        private string tennv;
        private string gioitinh;
        private DateTime ngaysinh;
        private string diachi;
        private string chucvu;
        private float hesoluong;
        private string cmnd;

        public BEL_NhanVien(int manv, string tennv, string gioitinh, DateTime ngaysinh,string diachi, string chucvu, float heso, string cmnd)
        {
            this.manv = manv;
            this.tennv = tennv;
            this.gioitinh = gioitinh;
            this.ngaysinh = ngaysinh;
            this.diachi = diachi;
            this.chucvu = chucvu;
            this.hesoluong = heso;
            this.cmnd = cmnd;
        }

        public BEL_NhanVien(DataRow row)
        {
            this.manv = int.Parse(row["MaNV"].ToString());
            this.tennv = row["TenNhanVien"].ToString();
            this.gioitinh = row["GioiTinh"].ToString();
            this.ngaysinh = DateTime.Parse(row["NgaySinh"].ToString());
            this.diachi = row["DiaChi"].ToString();
            this.chucvu = row["ChucVu"].ToString();
            this.hesoluong = float.Parse(row["HeSoLuong"].ToString());
            this.cmnd = row["CMND"].ToString();
        }
        public int Manv
        {
            get { return manv; }
            set { manv = value; }
        }
        public string Tennv
        {
            get { return tennv; }
            set { tennv = value; }
        }
        public string Gioitinh
        {
            get { return gioitinh; }
            set { gioitinh = value; }
        }
        public DateTime Ngaysinh
        {
            get { return ngaysinh; }
            set { ngaysinh = value; }
        }
        public string Diachi
        {
            get { return diachi; }
            set { diachi = value; }
        }
        public string Chucvu
        {
            get { return chucvu; }
            set { chucvu = value; }
        }
        public float Hesoluong
        {
            get { return hesoluong; }
            set { hesoluong = value; }
        }
        public string Cmnd
        {
            get { return cmnd; }
            set { cmnd = value; }
        }
    }
}
