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
    public partial class uctrlThietBi : UserControl
    {
        private static uctrlThietBi instance;
        public static uctrlThietBi Instance
        {
            get { if (instance == null) uctrlThietBi.instance = new uctrlThietBi(); return instance; }
            private set { uctrlThietBi.instance = value; }
        }
        public uctrlThietBi()
        {
            InitializeComponent();
        }
        private void uctrlThietBi_Load(object sender, EventArgs e)
        {
            LoadThietBi();
        }
        public void load()
        {
            LoadThietBi();
        }
        private void LoadThietBi()
        {
            dgvThietBi.DataSource = null;
            List<BEL_ThietBi> list = BAL_ThietBi.Instance.LoadThietBi();
            dgvThietBi.DataSource = list;
        }
        private bool KiemTraTrong()
        {
            if (txtMaTB.Text != "" && txttenTB.Text != "" && txtsoluong.Text != "" && txtmaloaiphong.Text != "")
                return true;
            return false;
        }
        private void btnTBThem_Click(object sender, EventArgs e)
        {
            if (KiemTraTrong())
            {
                BEL_ThietBi tb = new BEL_ThietBi(txtMaTB.Text, txttenTB.Text, txtsoluong.Text, txtmaloaiphong.Text);
                if (BAL_ThietBi.Instance.InsertThietBi(tb))
                {
                    LoadThietBi();
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

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnTBSua_Click(object sender, EventArgs e)
        {
            if (KiemTraTrong())
            {
                BEL_ThietBi tb = new BEL_ThietBi(txtMaTB.Text, txttenTB.Text, txtsoluong.Text, txtmaloaiphong.Text);
                if (BAL_ThietBi.Instance.UpThietBi(tb))
                {
                    LoadThietBi();
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

        private void btnTBXoa_Click(object sender, EventArgs e)
        {
            BEL_ThietBi tb = new BEL_ThietBi(txtMaTB.Text, txttenTB.Text, txtsoluong.Text, txtmaloaiphong.Text);
            if (BAL_ThietBi.Instance.DelThietBi(tb))
            {
                LoadThietBi();
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void dgvThietBi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dgvThietBi.Rows[e.RowIndex];
                txtMaTB.Text = row.Cells["MaTB"].Value.ToString();
                txttenTB.Text = row.Cells["TenTB"].Value.ToString();
                txtsoluong.Text = row.Cells["SoLuong"].Value.ToString();
                txtmaloaiphong.Text = row.Cells["MaLoaiPhong"].Value.ToString();

            }
            catch
            {

            }
        }
    }
}
