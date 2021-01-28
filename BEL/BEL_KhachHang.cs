using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class BEL_KhachHang
    {
        private string makh;
        private string hotenkh;
        private string gioitinh;
        private string sdt;
        private DateTime ngaysinh;
        private string diachi;
        private string quoctich;
        private string cmnd;


        public BEL_KhachHang(string makh,string hotenkh,string gioitinh,string sdt,DateTime ngaysinh,string diachi,string quoctich,string cmnd)
        {
            this.makh = makh;
            this.hotenkh = hotenkh;
            this.gioitinh = gioitinh;
            this.sdt = sdt;
            this.ngaysinh = ngaysinh;
            this.Diachi = diachi;
            this.quoctich = quoctich;
            this.cmnd = cmnd;
        }
        public BEL_KhachHang(DataRow row)
        {
            this.makh = row["MaKH"].ToString();
            this.Hotenkh = row["HoTenKH"].ToString();
            this.gioitinh = row["GioiTinh"].ToString();
            this.ngaysinh = DateTime.Parse(row["NgaySinh"].ToString());
            this.sdt = row["SDT"].ToString();
            this.Diachi = row["DiaChi"].ToString();
            this.quoctich = row["QuocTich"].ToString();
            this.cmnd = row["CMND"].ToString();
        }
        public string MaKH { get { return makh;} set { MaKH = value;} }
        public string Hotenkh { get { return hotenkh;} set { hotenkh = value;} }
        public string Gioitinh { get { return gioitinh;} set { gioitinh = value;} }
        public string Sdt { get { return sdt;} set { sdt = value;} }
        public DateTime Ngaysinh { get { return ngaysinh;} set { ngaysinh = value;} }
        public string Quoctich { get { return quoctich;} set { quoctich = value;} }
        public string Diachi { get { return diachi; } set { diachi = value; } }
        public string Cmnd { get { return cmnd; } set { cmnd = value; }}
    }
}
