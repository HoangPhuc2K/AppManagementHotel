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
    public partial class uctrlDichVu : UserControl
    {
        private static uctrlDichVu instance;
        private static BEL_TaiKhoan TK;

        public BEL_TaiKhoan TK1
        {
            get { return TK; }
            set { TK = value; }
        }

        public static uctrlDichVu Instance
        {
            get {if(instance == null) uctrlDichVu.instance = new uctrlDichVu(); return uctrlDichVu.instance; }
            private set { uctrlDichVu.instance = value; }
        }
        private void uctrlDichVu_Load(object sender, EventArgs e)
        {
            LoadDichVu(dgvDichVu);
        }
        public uctrlDichVu()
        {
            InitializeComponent();
        }
        public void load() 
        {
            LoadDichVu(dgvDichVu);
        }
        private void LoadDichVu(DataGridView dgv)
        {
            dgv.DataSource = null;
            List<BEL_DichVu> list = BAL_DichVu.Instance.LoadListDV();
            dgv.DataSource = list;
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private bool KiemTraTrong()
        {
            if (txtDVTenDV.Text != "" && txtDVGiaTien.Text != "" && cbbDVDonVi.Text != "" && txtDVGiamGia.Text != "")
                return true;
            return false;
        }

        private void btnDVThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (KiemTraTrong())
                {
                    BEL_DichVu dv = new BEL_DichVu(null, txtDVTenDV.Text, float.Parse(txtDVGiaTien.Text), cbbDVDonVi.Text, txtDVGiamGia.Text);
                    if (BAL_DichVu.Instance.AddDichVu(dv))
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDichVu(dgvDichVu);
                        XoaTrong();
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
            catch { }
        }

        private void tbnDVSua_Click(object sender, EventArgs e)
        {
            if (KiemTraTrong())
            {
                BEL_DichVu dv = new BEL_DichVu(txtDVMaDV.Text, txtDVTenDV.Text, float.Parse(txtDVGiaTien.Text), cbbDVDonVi.Text, txtDVGiamGia.Text);
                if (BAL_DichVu.Instance.UpDichVu(dv))
                {
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDichVu(dgvDichVu);
                    XoaTrong();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dgvDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dgvDichVu.Rows[e.RowIndex];
                txtDVMaDV.Text = row.Cells["Madv"].Value.ToString();
                txtDVTenDV.Text = row.Cells["Tendv"].Value.ToString();
                txtDVGiaTien.Text = row.Cells["Gia"].Value.ToString();
                cbbDVDonVi.Text = row.Cells["Donvi"].Value.ToString();
                txtDVGiamGia.Text = row.Cells["Giamgia"].Value.ToString();
            }
            catch { }
        }
        private void XoaTrong()
        {
            txtDVMaDV.Text = "";
            txtDVTenDV.Text = "";
            txtDVGiaTien.Text = "";
            cbbDVDonVi.Text = "";
            txtDVGiamGia.Text = "";
        }

        private void btnDVXoa_Click(object sender, EventArgs e)
        {
            if (txtDVMaDV.Text != "")
            {
                if (BAL_DichVu.Instance.DelDichVu(txtDVMaDV.Text))
                {
                    MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDichVu(dgvDichVu);
                    XoaTrong();
                }
                else
                {
                    MessageBox.Show("Xoá thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TimDichVu(dgvDichVu, textBox1.Text);
        }
        private void TimDichVu(DataGridView data, string ten)
        {
            data.DataSource = null;
            data.DataSource = BAL_DichVu.Instance.TimDichVu(ten);
        }
    }
}
