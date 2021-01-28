using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class BEL_Quyen
    {
        private string maquyen;
        private string tenquyen;
        private string mota;

        public BEL_Quyen(string ma, string ten, string mota)
        {
            this.maquyen = ma;
            this.tenquyen = ten;
            this.mota = mota;
        }
        public BEL_Quyen(DataRow row)
        {
            this.maquyen = row["MaQuyen"].ToString();
            this.tenquyen = row["TenQuyen"].ToString();
            this.mota = row["MoTa"].ToString();
        }
        public string Mota
        {
            get { return mota; }
            set { mota = value; }
        }

        public string Tenquyen
        {
            get { return tenquyen; }
            set { tenquyen = value; }
        }


        public string Maquyen
        {
            get { return maquyen; }
            set { maquyen = value; }
        }
    }
}
