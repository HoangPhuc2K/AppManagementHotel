using BAL;
using BEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class rpHoaDon : Form
    {
        private string makh;
        private string sophong;
        private BEL_DatPhong dp;
        private BEL_KhachHang kh;
        private BEL_TraPhong tp;
        private BEL_HoaDonThue hd;
        public rpHoaDon(string makh,string sophong ,BEL_DatPhong dp,BEL_KhachHang kh,BEL_TraPhong tp,BEL_HoaDonThue hd)
        {
            InitializeComponent();
            this.makh = makh;
            this.sophong = sophong;
            this.dp = dp;
            this.kh = kh;
            this.tp = tp;
            this.hd = hd;
        }

        private void rpHoaDon_Load(object sender, EventArgs e)
        {
            BAL_HoaDonThue.Instance.UpHoaDon(null, hd.Mahd, hd.Tongtien);
            // TODO: This line of code loads data into the 'QUANLYKHACHSANDataSet.HoaDon_View' table. You can move, or remove it, as needed.
            this.HoaDon_ViewTableAdapter.Fill(this.QUANLYKHACHSANDataSet.HoaDon_View, this.makh);
            // TODO: This line of code loads data into the 'QUANLYKHACHSANDataSet.DichVu_View' table. You can move, or remove it, as needed.
            this.HoaDonDichVuTableAdapter.Fill(this.QUANLYKHACHSANDataSet.HoaDonDichVu, this.makh);
            this.reportViewer1.RefreshReport();
            
        }

        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            BAL_TraPhong.Instansce.AddTraPhong(tp);
            BAL_HoaDonThue.Instance.UpHoaDon(tp.Matraphong, hd.Mahd, hd.Tongtien);
            BAL_DatPhong.Instance.UpTrangThaiDat(makh);
            BAL_Phong.Instance.UpdateRoomTrangThai(sophong, "No");
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Có muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
