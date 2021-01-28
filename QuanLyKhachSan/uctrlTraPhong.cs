using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BEL;
using BAL;

namespace QuanLyKhachSan
{
    public partial class uctrlTraPhong : UserControl
    {
        private static uctrlTraPhong instance;

        public static uctrlTraPhong Instance
        {
            get {if(instance == null)uctrlTraPhong.instance = new uctrlTraPhong(); return uctrlTraPhong.instance; }
            private set { uctrlTraPhong.instance = value; }
        }
        private static int manv;

        public static int Manv
        {
            get { return uctrlTraPhong.manv; }
            set { uctrlTraPhong.manv = value; }
        }
        public uctrlTraPhong()
        {
            InitializeComponent();
        }

        private void btnTPXuat_Click(object sender, EventArgs e)
        {
            if (cbbTPSoPhong.Text != "" && txtTPMaTP.Text != "")
            {
                if (BAL_TraPhong.Instansce.KiemTraTonTai(txtTPMaTP.Text) == false)
                {
                    string sophong = cbbTPSoPhong.Text;
                    BEL_DatPhong dp = BAL_DatPhong.Instance.LoadDatPhongTheoSoPhong(sophong);
                    BEL_KhachHang kh = BAL_KhachHang.Instance.LoadKhachHangTheoMa(dp.MaKH);
                    BEL_TraPhong tp = new BEL_TraPhong(txtTPMaTP.Text, kh.MaKH, dp.SoPhong, DateTime.Now);
                    BEL_HoaDonThue hd = BAL_HoaDonThue.Instance.LoadHDThueTheoMaDP(dp.MaDatPhong);
                    BEL_HoaDonDichVu dv = BAL_HoaDonDichVu.Instance.LayHoaDonTheoMaKH(kh.MaKH);
                    if (dv != null)
                    {
                        if (txtTPThanhTien.Text == "0")
                        {
                            hd.Tongtien = (float.Parse(txtTPThanhTien.Text)) + float.Parse(dv.Thanhtien);
                        }
                        else
                        {
                            if (float.Parse(txtTPThanhTien.Text) < hd.Tiencoc)
                            {
                                hd.Tongtien = (hd.Tiencoc - float.Parse(txtTPThanhTien.Text)) + float.Parse(dv.Thanhtien);
                            }
                            else
                            {
                                hd.Tongtien = (float.Parse(txtTPThanhTien.Text) - hd.Tiencoc) + float.Parse(dv.Thanhtien);
                            }
                        }
                    }
                    else
                    {
                        if (txtTPThanhTien.Text == "0")
                        {
                            hd.Tongtien = (float.Parse(txtTPThanhTien.Text));
                        }
                        else
                        {
                            if (float.Parse(txtTPThanhTien.Text) < hd.Tiencoc)
                            {
                                hd.Tongtien = (hd.Tiencoc - float.Parse(txtTPThanhTien.Text));
                            }
                            else
                            {
                                hd.Tongtien = (float.Parse(txtTPThanhTien.Text) - hd.Tiencoc);
                            }
                        }
                    }
                    hd.Matraphong = txtTPMaTP.Text;
                    rpHoaDon rp = new rpHoaDon(dp.MaKH, sophong, dp, kh, tp, hd);
                    rp.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Trùng mã đặt phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbbTPSoPhong_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                string sophong = cbbTPSoPhong.Text;
                BEL_DatPhong dp = BAL_DatPhong.Instance.LoadDatPhongTheoSoPhong(sophong);
                BEL_KhachHang kh = BAL_KhachHang.Instance.LoadKhachHangTheoMa(dp.MaKH);
                BEL_Phong Phong = BAL_Phong.Instance.LoadRoomSoPhong(sophong);
                BEL_LoaiPhong loaiphong = BAL_LoaiPhong.Instance.LoadLoaiPhongTheoMa(Phong.Maloaiphong);
                txtTPHoTen.Text = kh.Hotenkh;
                TimeTPNgaySinh.Value = kh.Ngaysinh;
                if (kh.Gioitinh == "Nam")
                {
                    radTPNam.Checked = true;
                }
                else
                {
                    radTPNu.Checked = true;
                }
                txtTPSDT.Text = kh.Sdt;
                txtTPDiaChi.Text = kh.Diachi;
                txtTPQuocTich.Text = kh.Quoctich;
                txtTPCMND.Text = kh.Cmnd;
                TimeTPNgayDat.Value = dp.NgayDatPhong;
                DateTime dt = TimeTPNgayTra.Value;
                TimeSpan t = dt.Subtract(dp.NgayDatPhong);
                double day = t.TotalDays;
                txtTPThanhTien.Text = (Math.Round(day) * loaiphong.Giaphong).ToString();
            }
            catch
            {

            }
        }

        private void uctrlTraPhong_Load(object sender, EventArgs e)
        {
            LoadPhongTrangThai(cbbTPSoPhong, "Yes");
        }
        public void load() 
        {
            LoadPhongTrangThai(cbbTPSoPhong, "Yes");
        }
        private void LoadPhongTrangThai(ComboBox cbb, string trangthai)
        {
            cbb.DataSource = null;
            cbb.DataSource = BAL_Phong.Instance.LoadRoomTrangThai(trangthai);
            cbb.DisplayMember = "SoPhong";
            cbb.ValueMember = "SoPhong";
        }
    }
}
