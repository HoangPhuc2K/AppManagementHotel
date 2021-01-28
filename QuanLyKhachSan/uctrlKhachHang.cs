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
    public partial class uctrlKhachHang : UserControl
    {
        private static uctrlKhachHang instance;

        public static uctrlKhachHang Instance
        {
            get { if(instance == null) uctrlKhachHang.instance = new uctrlKhachHang(); return uctrlKhachHang.instance; }
            private set { uctrlKhachHang.instance = value; }
        }
        public uctrlKhachHang()
        {
            InitializeComponent();
        }

        private void uctrlKhachHang_Load(object sender, EventArgs e)
        {
            LoadKhachHang();
        }
        public void load()
        {
            LoadKhachHang();
        }
        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void LoadKhachHang()
        {
            dgvKhachHang.DataSource = null;
            List<BEL_KhachHang> list = BAL_KhachHang.Instance.LoadListKhachHang();
            dgvKhachHang.DataSource = list;
        }

        private void btnKHThem_Click(object sender, EventArgs e)
        {
            if (KiemTraTrong())
            {
                string gioitinh = null;
                if(radKHNam.Checked ==true)
                    gioitinh = "Nam";
                else
                    gioitinh = "Nu";
                BEL_KhachHang kh = new BEL_KhachHang(txtMaKH.Text, txtHoTenKH.Text, gioitinh, txtSDTKH.Text, PkNgaySinhKH.Value, txtDiaChiKH.Text, txtQuocTichKH.Text, txtKHCMND.Text);
                if(BAL_KhachHang.Instance.InsertCustomer(kh))
                {
                    LoadKhachHang();
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private bool KiemTraTrong()
        {
            if ((txtKHCMND.Text !="" &&txtMaKH.Text != "" && txtHoTenKH.Text != "" && txtDiaChiKH.Text != "" && txtSDTKH.Text != "" && txtQuocTichKH.Text != "") && (radKHNam.Checked == true || radKHNu.Checked ==true) )
            {
                return true;
            }
            return false;
        }
        private void XoaTrong()
        {
            txtMaKH.Text = "";
            txtMaKH.Focus();
            txtHoTenKH.Text = "";
            txtDiaChiKH.Text = "";
            txtQuocTichKH.Text = "";
            txtSDTKH.Text = "";
            txtKHCMND.Text = "";
            radKHNam.Checked = false;
            radKHNu.Checked = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            XoaTrong();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadKhachHang();
        }

        private void btnKHSua_Click(object sender, EventArgs e)
        {
            if (KiemTraTrong())
            {
                string gioitinh = null;
                if (radKHNam.Checked == true)
                    gioitinh = "Nam";
                else
                    gioitinh = "Nu";
                BEL_KhachHang kh = new BEL_KhachHang(txtMaKH.Text, txtHoTenKH.Text, gioitinh, txtSDTKH.Text, PkNgaySinhKH.Value, txtDiaChiKH.Text, txtQuocTichKH.Text, txtKHCMND.Text);
                if (BAL_KhachHang.Instance.UpCustomer(kh))
                {
                    LoadKhachHang();
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dgvKhachHang.Rows[e.RowIndex];
                txtMaKH.Text = row.Cells["Makh"].Value.ToString();
                txtHoTenKH.Text = row.Cells["Hotenkh"].Value.ToString();
                txtKHCMND.Text = row.Cells["Cmnd"].Value.ToString();
                txtDiaChiKH.Text = row.Cells["Diachi"].Value.ToString();
                txtQuocTichKH.Text = row.Cells["Quoctich"].Value.ToString();
                txtSDTKH.Text = row.Cells["Sdt"].Value.ToString();
                PkNgaySinhKH.Value = DateTime.Parse(row.Cells["Ngaysinh"].Value.ToString());
                if (row.Cells["Gioitinh"].Value.ToString() == "Nam")
                {
                    radKHNam.Checked = true;
                }
                else
                {
                    radKHNu.Checked = false;
                }
            }
            catch
            {

            }

        }

        private void txtKHSeach_TextChanged(object sender, EventArgs e)
        {
            List<BEL_KhachHang> list = BAL_KhachHang.Instance.SeachCus(txtKHSeach.Text);
            if (list.Count > 0)
            {
                dgvKhachHang.DataSource = null;
                dgvKhachHang.DataSource = list;
            }
        }
    }
}
