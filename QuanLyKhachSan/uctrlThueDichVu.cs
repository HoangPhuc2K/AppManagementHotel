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
    public partial class uctrlThueDichVu : UserControl
    {
        private static uctrlThueDichVu instance;
        private static BEL_TaiKhoan TK;

        public static BEL_TaiKhoan TK1
        {
            get { return uctrlThueDichVu.TK; }
            set { uctrlThueDichVu.TK = value; }
        }

        private List<BEL_DichVu> DsDV = new List<BEL_DichVu>();
        private List<BEL_DichVu> DsDVDaCo = new List<BEL_DichVu>();

        public static uctrlThueDichVu Instance
        {
            get {if(instance == null) uctrlThueDichVu.instance = new uctrlThueDichVu(); return uctrlThueDichVu.instance; }
            private set { uctrlThueDichVu.instance = value; }
        }
        public uctrlThueDichVu()
        {
            InitializeComponent();
        }
        public void load()
        {
            LoadCBBDV(cbbDsDV);
            LoadRoom();
        }
        private void uctrlThueDichVu_Load(object sender, EventArgs e)
        {
            LoadCBBDV(cbbDsDV);
            LoadRoom();
        }
        private void LoadRoom()
        {
            flpDsPhongDV.Controls.Clear();
            List<BEL_Phong> listroom = BAL_Phong.Instance.LoadRoomList();
            List<BEL_LoaiPhong> listLoai = BAL_LoaiPhong.Instance.LoadLoaiPhong();
            foreach (BEL_Phong item in listroom)
            {
                Button btn = new Button() { Width = BAL_Phong.RoomWidth, Height = BAL_Phong.RoomHeight };
                btn.Image = Image.FromFile(Application.StartupPath + "\\Img\\door.png");
                btn.Text = item.Sophong.ToString();
                btn.TextAlign = ContentAlignment.BottomCenter;
                btn.Click += btnPhong_Click;
                if (item.Trangthaiphong == "Yes")
                {
                    btn.BackColor = Color.Red;
                    flpDsPhongDV.Controls.Add(btn);
                }
            }
        }
        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnDVThanhToan_Click(object sender, EventArgs e)
        {
            if (txtDVTong.Text != "0")
            {
                if (DsDV.Count > 0 && DsDVDaCo.Count == 0)
                {
                    BEL_DatPhong DP = BAL_DatPhong.Instance.LoadDatPhongTheoSoPhong(txtDVSoPhong.Text);
                    BEL_HoaDonDichVu hd = new BEL_HoaDonDichVu(0, DP.MaKH, DateTime.Now, txtDVTong.Text, TK1.Manv.ToString());
                    BAL_HoaDonDichVu.Instance.AddHoaDonDV(hd);
                    BAL_HoaDonDichVu.Instance.AddChiTiet(DsDV, txtDVSoPhong.Text);
                    lvDsDichVu.Items.Clear();
                    MessageBox.Show("Thêm dịch vụ thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if(DsDV.Count > 0 && DsDVDaCo.Count > 0)
                {
                    BAL_HoaDonDichVu.Instance.AddChiTiet(DsDV, txtDVSoPhong.Text);
                    BEL_DatPhong dp = BAL_DatPhong.Instance.LoadDatPhongTheoSoPhong(txtDVSoPhong.Text);
                    BEL_HoaDonDichVu hddv = BAL_HoaDonDichVu.Instance.LayHoaDonTheoMaKH(dp.MaKH);
                    BAL_HoaDonDichVu.Instance.UpTongTien(hddv.Mahd.ToString(), txtDVTong.Text);
                    lvDsDichVu.Items.Clear();
                    MessageBox.Show("Thêm dịch vụ thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                if(DsDV.Count == 0)
                {
                    MessageBox.Show("Chưa có dịch mới được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            else
            {
                MessageBox.Show("Hãy chọn chọn dịch vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThue_Click(object sender, EventArgs e)
        {
            if (txtDVSoPhong.Text != "")
            {
                if (KiemTraDVTrung(cbbDsDV.Text))
                {
                    ListViewItem listview = new ListViewItem();
                    listview.Text = cbbDsDV.Text;
                    BEL_DichVu dv = BAL_DichVu.Instance.LoadDichVuTheoTen(cbbDsDV.Text);
                    listview.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dv.Gia.ToString() });
                    listview.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dv.Giamgia });
                    lvDsDichVu.Items.Add(listview);
                    BEL_DichVu item = BAL_DichVu.Instance.LoadDichVuTheoTen(cbbDsDV.Text);
                    DsDV.Add(item);
                    TinhTongTien();
                }
                else
                {
                    MessageBox.Show("Dịch vụ đã có", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private bool KiemTraDVTrung(string ten)
        {
            if (lvDsDichVu.Items.Count > 0)
            {
                foreach (ListViewItem item in lvDsDichVu.Items)
                {
                    if (item.Text == ten)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private void TinhTongTien()
        {
            double TongTien = 0;
            if (lvDsDichVu.Items.Count > 0)
            {
                foreach (ListViewItem item in lvDsDichVu.Items)
                {
                    TongTien += double.Parse(item.SubItems[1].Text) - (double.Parse(item.SubItems[1].Text) * (double.Parse(item.SubItems[2].Text) / 100));
                }
            }
            txtDVTong.Text = TongTien.ToString();
        }
        
        private void LoadCBBDV(ComboBox cbb)
        {
            cbb.DataSource = null;
            cbb.DataSource = BAL_DichVu.Instance.LoadListDV();
            cbb.DisplayMember = "Tendv";
            cbb.ValueMember = "Madv";
        }
        private void btnPhong_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtDVSoPhong.Text = btn.Text;
            lvDsDichVu.Items.Clear();
            BEL_DatPhong dp = BAL_DatPhong.Instance.LoadDatPhongTheoSoPhong(txtDVSoPhong.Text);
            BEL_HoaDonDichVu hddv = BAL_HoaDonDichVu.Instance.LayHoaDonTheoMaKH(dp.MaKH);
            if (hddv != null)
            {
                DsDVDaCo = BAL_DichVu.Instance.LoadDichVuTheoMaHD(hddv.Mahd.ToString());
                if (DsDVDaCo.Count > 0)
                {
                    foreach (BEL_DichVu dv in DsDVDaCo)
                    {
                        ListViewItem lvitem = new ListViewItem();
                        lvitem.Text = dv.Tendv;
                        lvitem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dv.Gia.ToString() });
                        lvitem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dv.Giamgia.ToString() });
                        lvDsDichVu.Items.Add(lvitem);
                    }
                }
                TinhTongTien();
            }   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem lv in lvDsDichVu.SelectedItems)
            {
                bool KiemTra = false;
                foreach(BEL_DichVu dv in DsDVDaCo)
                {
                    if (dv.Tendv == lv.Text)
                        KiemTra = true;
                }
                if (KiemTra == false)
                {
                    lvDsDichVu.Items.Remove(lv);
                    foreach (BEL_DichVu dv in DsDV)
                    {
                        if (lv.Text == dv.Tendv)
                            DsDV.Remove(dv);
                        if (DsDV.Count == 0)
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Dịch vụ đã được thêm vào hoá đơn không thể xoá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            TinhTongTien();
        }

    }
}
