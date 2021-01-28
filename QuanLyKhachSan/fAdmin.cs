using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BEL;
using BAL;
using System.Data;

namespace QuanLyKhachSan
{
    public partial class fAdmin : Form
    {
        private BEL_TaiKhoan TK;
        public fAdmin(BEL_TaiKhoan tk)
        {
            InitializeComponent();
            this.TK = tk;
        }


        private void fAdmin_Load(object sender, EventArgs e)
        {
            LoadTab();
        }

        private void LoadTab() 
        {
            TabPage tabGioiThieu = new TabPage();
            tabGioiThieu.Name = "tabGioiThieu";
            tabGioiThieu.Controls.Add(uctrlGioiThieu.Instance);
            tabControlQuanLy.TabPages.Add(tabGioiThieu);
            TabPage tabThueDV = new TabPage();
            tabThueDV.Name = "TabThueDichVu";
            uctrlThueDichVu.TK1 = TK;
            tabThueDV.Controls.Add(uctrlThueDichVu.Instance);
            tabControlQuanLy.TabPages.Add(tabThueDV);
            TabPage tabDichVu = new TabPage();
            tabDichVu.Name = "tabQLDichVu";
            tabDichVu.Text = "tabDichVu";
            uctrlDichVu.Instance.TK1 = this.TK;
            tabDichVu.Controls.Add(uctrlDichVu.Instance);
            tabControlQuanLy.TabPages.Add(tabDichVu);
            TabPage tabTraPhong = new TabPage();
            tabTraPhong.Name = "TabTraPhong";
            uctrlTraPhong.Manv = TK.Manv;
            tabTraPhong.Controls.Add(uctrlTraPhong.Instance);
            tabControlQuanLy.TabPages.Add(tabTraPhong);
            TabPage tabDatPhong = new TabPage();
            tabDatPhong.Name = "TabDatPhong";
            uctrlDatPhong.Manv = TK.Manv;
            tabDatPhong.Controls.Add(uctrlDatPhong.Instance);
            tabControlQuanLy.TabPages.Add(tabDatPhong);
            TabPage tabNhanVien = new TabPage();
            tabNhanVien.Name = "tabQLNhanVien";
            tabNhanVien.Text = "tabNhanVien";
            tabNhanVien.Controls.Add(uctrlNhanVien.Instance);
            tabControlQuanLy.TabPages.Add(tabNhanVien);
            TabPage tabPhong = new TabPage();
            tabPhong.Name = "tabQLPhong";
            tabPhong.Text = "TabPhong";
            uctrlPhongcs.Manv = TK.Manv;
            tabPhong.Controls.Add(uctrlPhongcs.Instance);
            tabControlQuanLy.TabPages.Add(tabPhong);
            TabPage tabKhachHang = new TabPage();
            tabKhachHang.Name = "tabQLKhachHang";
            tabKhachHang.Text = "TabKhachHang";
            tabKhachHang.Controls.Add(uctrlKhachHang.Instance);
            tabControlQuanLy.TabPages.Add(tabKhachHang);
            TabPage tabThongKeHDThue = new TabPage();
            tabThongKeHDThue.Name = "tabThongkeHDThue";
            tabThongKeHDThue.Text = "TabThongKeHoaDonThue";
            tabThongKeHDThue.Controls.Add(uctrlThongKeHoaDonThue.Instance);
            tabControlQuanLy.TabPages.Add(tabThongKeHDThue);
            TabPage tabThongKeHDichVu = new TabPage();
            tabThongKeHDichVu.Name = "tabThongkeHDDichVu";
            tabThongKeHDichVu.Text = "TabThongKeHoaDonDichVu";
            tabThongKeHDichVu.Controls.Add(uctrlThongKeHDDichVu.Instance);
            tabControlQuanLy.TabPages.Add(tabThongKeHDichVu);
            TabPage tabThietBi = new TabPage();
            tabThietBi.Name = "tabQLThietBi";
            tabThietBi.Text = "tabThietBi";
            tabThietBi.Controls.Add(uctrlThietBi.Instance);
            tabControlQuanLy.TabPages.Add(tabThietBi);
            if (TK.Maquyen == "Q002")
            {
                ribbtnPhong.Visible = false;
                ribbonbtnDichVu.Visible = false;
                ribKhacHang.Visible = false;
                ribNhanVien.Visible = false;
                ribThongKe.Visible = false;
                ribHeThong.Visible = false;
                ribbonPanerlThietBi.Visible = false;
            }
            else
            {
                ribbtnPhong.Visible = true;
                ribbonbtnDichVu.Visible = true;
                ribKhacHang.Visible = true;
                ribNhanVien.Visible = true;
                ribThongKe.Visible = true;
                ribHeThong.Visible = true;
                ribbonPanerlThietBi.Visible = true;
            }
        }


        private void ribbBtnCustomer_Click(object sender, EventArgs e)
        {
            uctrlKhachHang.Instance.load();
            tabControlQuanLy.SelectTab("tabQLKhachHang");
        }

        private void ribbtnPhong_Click(object sender, EventArgs e)
        {
            uctrlPhongcs.Instance.loadlai();
            tabControlQuanLy.SelectTab("tabQLPhong");
        }

        private void ribbtnNhanVien_Click(object sender, EventArgs e)
        {
            uctrlNhanVien.Instance.load();
            tabControlQuanLy.SelectTab("tabQLNhanVien");
        }

        private void ribbonbtnDichVu_Click(object sender, EventArgs e)
        {
            uctrlDichVu.Instance.load();
            tabControlQuanLy.SelectTab("tabQLDichVu");
        }

        private void ribDatPhong_Click(object sender, EventArgs e)
        {
            uctrlDatPhong.Instance.load();
            tabControlQuanLy.SelectTab("TabDatPhong");
        }

        private void ribbonTraPhong_Click(object sender, EventArgs e)
        {
            uctrlTraPhong.Instance.load();
            tabControlQuanLy.SelectTab("TabTraPhong");
        }

        private void ribbonThueDv_Click(object sender, EventArgs e)
        {
            uctrlThueDichVu.Instance.load();
            tabControlQuanLy.SelectTab("TabThueDichVu");
        }

        private void ribbonGioiThieu_Click(object sender, EventArgs e)
        {
            tabControlQuanLy.SelectTab("tabGioiThieu");
        }

        private void ribIDoiPassWord_Click(object sender, EventArgs e)
        {
            fDoiMatKhau DoiMatKhau = new fDoiMatKhau(TK.Username);
            DoiMatKhau.ShowDialog();
        }

        private void ribbonTKHoaDon_Click(object sender, EventArgs e)
        {
            uctrlThongKeHoaDonThue.Instance.LoadLai();
            tabControlQuanLy.SelectTab("tabThongkeHDThue");
        }

        private void ribbonTKDichVu_Click(object sender, EventArgs e)
        {
            tabControlQuanLy.SelectTab("tabThongkeHDDichVu");
        }

        private void ribbonKetNoiCSDL_Click(object sender, EventArgs e)
        {
            fKetNoi KetNoi = new fKetNoi();
            KetNoi.ShowDialog();
        }

        private void ribbonThietBi_Click(object sender, EventArgs e)
        {
            uctrlThietBi.Instance.load();
            tabControlQuanLy.SelectTab("TabQLThietBi");
        }
    }
}
