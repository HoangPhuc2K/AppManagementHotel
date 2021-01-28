using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class BEL_ThietBi
    {
        private string maTB;

        public string MaTB
        {
            get { return maTB; }
            set { maTB = value; }
        }
        private string tenTB;

        public string TenTB
        {
            get { return tenTB; }
            set { tenTB = value; }
        }
        private string soluong;

        public string Soluong
        {
            get { return soluong; }
            set { soluong = value; }
        }
        private string maLoaiPhong;

        public string MaLoaiPhong
        {
            get { return maLoaiPhong; }
            set { maLoaiPhong = value; }
        }
        public BEL_ThietBi(string ma, string ten, string soluong, string loai)
        {
            this.maTB = ma;
            this.tenTB = ten;
            this.soluong = soluong;
            this.maLoaiPhong = loai;
        }
        public BEL_ThietBi(DataRow row)
        {
            this.maTB = row["MaTB"].ToString();
            this.tenTB = row["TenTB"].ToString();
            this.soluong = row["SoLuong"].ToString();
            this.maLoaiPhong = row["MaLoaiPhong"].ToString();
        }
    }
}
