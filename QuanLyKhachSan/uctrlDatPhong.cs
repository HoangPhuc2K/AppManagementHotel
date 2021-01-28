using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
using BEL;

namespace QuanLyKhachSan
{
    public partial class uctrlDatPhong : UserControl
    {
        private static uctrlDatPhong instance;

        public static uctrlDatPhong Instance
        {
            get {if(instance ==  null) uctrlDatPhong.instance = new uctrlDatPhong(); return uctrlDatPhong.instance; }
            private set { uctrlDatPhong.instance = value; }
        }
        public uctrlDatPhong()
        {
            InitializeComponent();
        }
        private static int manv;

        public static int Manv
        {
            get { return uctrlDatPhong.manv; }
            set { uctrlDatPhong.manv = value; }
        }

        private void btnDPXoa_Click(object sender, EventArgs e)
        {
            XoaTrongDP();
        }

        private void btnDPLuu_Click(object sender, EventArgs e)
        {
            if (KiemTraTrongDP())
            {
                string GioiTinh;
                if (radDPNam.Checked == true)
                {
                    GioiTinh = "Nam";
                }
                else
                {
                    GioiTinh = "Nu";
                }
                BEL_KhachHang kh = new BEL_KhachHang(txtDPMaKH.Text, txtDPHoTenKH.Text, GioiTinh, txtSDTDP.Text, TimeDPNgaySinh.Value, txtDPDiaChi.Text, txtDPQuocTich.Text, txtDPCMND.Text);
                BEL_DatPhong dp = new BEL_DatPhong(txtDPMaDP.Text, txtDPMaKH.Text, cbDPSoPhong.Text, TimeDPNgayDat.Value);
                BEL_HoaDonThue hd = new BEL_HoaDonThue("NULL", Manv, dp.MaDatPhong, "NULL", kh.MaKH, DateTime.Now, float.Parse(txtDPTienCoc.Text), 0, "Yes");
                if (BAL_KhachHang.Instance.LoadKhachHangTheoMa(kh.MaKH) == null)
                {
                    if (BAL_DatPhong.Instance.LoadDatPhongTheoMa(dp.MaDatPhong) == null)
                    {
                        if (BAL_KhachHang.Instance.InsertCustomer(kh))
                        {
                            if (BAL_DatPhong.Instance.AddDatPhong(dp))
                            {
                                MessageBox.Show("Đặt phòng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                BAL_HoaDonThue.Instance.AddHoaDon(hd, kh.MaKH, dp.SoPhong);
                                BAL_Phong.Instance.UpdateRoomTrangThai(cbDPSoPhong.Text, "Yes");
                                XoaTrongDP();
                                BAL_HoaDonThue.Instance.AddChiTiet(BAL_HoaDonThue.Instance.LoadHDThueTheoMaDP(dp.MaDatPhong).Mahd, dp.SoPhong);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Đặt phòng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mã đặt phòng trùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Mã khách hàng trùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private bool KiemTraTrongDP()
        {

            if ((txtDPMaKH.Text != "" && txtDPHoTenKH.Text != "" && txtDPDiaChi.Text != "" && txtDPQuocTich.Text != "" && txtDPCMND.Text != "" && txtDPMaDP.Text != "" && cbDPSoPhong.Text != "") &&( radDPNam.Checked == true || radDPNu.Checked == true))
            {
                return true;
            }
            return false;
        }
        private void XoaTrongDP()
        {
            txtDPMaKH.Text = "";
            txtDPMaKH.Focus();
            txtDPHoTenKH.Text = "";
            txtSDTDP.Text = "";
            txtDPDiaChi.Text = "";
            txtDPQuocTich.Text = "";
            txtDPCMND.Text = "";
            txtDPMaDP.Text = "";
            cbDPSoPhong.Text = "";
            txtDPTienCoc.Text = "0";
            TimeDPNgaySinh.Value = DateTime.Now;
            radDPNam.Checked = false;
            radDPNu.Checked = false;
        }
        private void LoadPhongTrangThai(ComboBox cbb, string trangthai)
        {
            cbb.DataSource = null;
            cbb.DataSource = BAL_Phong.Instance.LoadRoomTrangThai(trangthai);
            cbb.DisplayMember = "SoPhong";
            cbb.ValueMember = "SoPhong";
        }

        private void uctrlDatPhong_Load(object sender, EventArgs e)
        {
            LoadPhongTrangThai(cbDPSoPhong, "No");
        }
        public void load()
        {
            LoadPhongTrangThai(cbDPSoPhong, "No");
        }
    }
}
