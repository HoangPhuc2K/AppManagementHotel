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
    public partial class uctrlNhanVien : UserControl
    {
        private static uctrlNhanVien instance;

        public static uctrlNhanVien Instance
        {
            get {if(instance == null) uctrlNhanVien.instance = new uctrlNhanVien(); return uctrlNhanVien.instance; }
            private set { uctrlNhanVien.instance = value; }
        }
        public uctrlNhanVien()
        {
            InitializeComponent();
        }
        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void uctrlNhanVien_Load(object sender, EventArgs e)
        {
            LoadNhanVien();
            LoadAccount();
            HienThiCbbMaNV();
            HienThiCbbMQ();
        }
        public void load()
        {
            LoadNhanVien();
            LoadAccount();
            HienThiCbbMaNV();
            HienThiCbbMQ();
        }
        private void LoadNhanVien()
        {
            List<BEL_NhanVien> list = BAL_NhanVien.Instance.LoadListNV();
            dgvNhanVien.DataSource = list;
        }
        private void LoadAccount()
        {
            List<BEL_TaiKhoan> list = BAL_TaiKhoan.Instance.LoadListTK();
            dgvTKNhanVien.DataSource = list;

        }
        
        private void HienThiCbbMaNV() 
        {
            List<BEL_TaiKhoan> tk = BAL_TaiKhoan.Instance.LoadListTK();
            List<BEL_NhanVien> nv = BAL_NhanVien.Instance.LoadListNV();
            List<BEL_NhanVien> temp = new List<BEL_NhanVien>();
            foreach (BEL_TaiKhoan item in tk)
            {
                foreach (BEL_NhanVien item2 in nv)
                {
                    if (item.Manv == item2.Manv)
                    {
                        nv.Remove(item2);
                        break;
                    }
                }
            }
            cbbTKMaNV.DataSource = nv;
            cbbTKMaNV.DisplayMember = "Manv";
            cbbTKMaNV.ValueMember = "Tennv";
        }
        private void HienThiCbbMQ()
        {
            List<BEL_Quyen> quyen = BAL_Quyen.Instance.LoadListQuyen();
            cbbMaQuyen.DataSource = quyen;
            cbbMaQuyen.DisplayMember = "Maquyen";
            cbbMaQuyen.ValueMember = "Maquyen";
        }
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];
                if (row.Cells["Gioitinh"].Value.ToString() == "Nam")
                    radNVNam.Checked = true;
                else
                    radNVNu.Checked = true;
                txtNVMaNV.Text = row.Cells["Manv"].Value.ToString();
                txtNVHoTenNV.Text = row.Cells["Tennv"].Value.ToString();
                txtNVHeSoLuong.Text = row.Cells["Hesoluong"].Value.ToString();
                txtNVDiaChi.Text = row.Cells["Diachi"].Value.ToString();
                txtNVCMND.Text = row.Cells["Cmnd"].Value.ToString();
                txtNVChucVu.Text = row.Cells["Chucvu"].Value.ToString();
                dtpNgaySinh.Value = DateTime.Parse(row.Cells["Ngaysinh"].Value.ToString());
            }
            catch
            {

            }
        }
        private bool KiemTraTrong()
        {
            if ((txtNVHoTenNV.Text != "" && txtNVCMND.Text != "" && txtNVDiaChi.Text != "" && txtNVChucVu.Text != "" && txtNVHeSoLuong.Text != "") && (radNVNam.Checked == true || radNVNu.Checked == true))
                return true;
            return false;
        }
        private void btnNVThem_Click(object sender, EventArgs e)
        {
            if (KiemTraTrong())
            {
                string gioitinh = null;
                if (radNVNam.Checked == true)
                    gioitinh = "Nam";
                else
                    gioitinh = "Nu";
                BEL_NhanVien nv = new BEL_NhanVien(1, txtNVHoTenNV.Text, gioitinh, dtpNgaySinh.Value, txtNVDiaChi.Text, txtNVChucVu.Text, float.Parse(txtNVHeSoLuong.Text), txtNVCMND.Text);
                if (BAL_NhanVien.Instance.AddNhanVien(nv))
                {
                    MessageBox.Show("Thêm nhân viên thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadNhanVien();
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên thất bại", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnNVSua_Click(object sender, EventArgs e)
        {
            if (KiemTraTrong())
            {
                string gioitinh = null;
                if (radNVNam.Checked == true)
                    gioitinh = "Nam";
                else
                    gioitinh = "Nu";
                BEL_NhanVien nv = new BEL_NhanVien(int.Parse(txtNVMaNV.Text), txtNVHoTenNV.Text, gioitinh, dtpNgaySinh.Value, txtNVDiaChi.Text, txtNVChucVu.Text, float.Parse(txtNVHeSoLuong.Text), txtNVCMND.Text);
                if (BAL_NhanVien.Instance.UpNhanVien(nv))
                {
                    MessageBox.Show("Sửa nhân viên thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadNhanVien();
                }
                else
                {
                    MessageBox.Show("Sửa nhân viên thất bại", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnNVXoa_Click(object sender, EventArgs e)
        {
            string gioitinh = null;
            if (radNVNam.Checked == true)
                gioitinh = "Nam";
            else
                gioitinh = "Nu";
            BEL_NhanVien nv = new BEL_NhanVien(int.Parse(txtNVMaNV.Text), txtNVHoTenNV.Text, gioitinh,dtpNgaySinh.Value ,txtNVDiaChi.Text, txtNVChucVu.Text, float.Parse(txtNVHeSoLuong.Text), txtNVCMND.Text);
            if (BAL_NhanVien.Instance.DelNhanVien(nv))
            {
                MessageBox.Show("Xoá nhân viên thành công", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadNhanVien();
            }
            else
            {
                MessageBox.Show("Xoá nhân viên thất bại", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnTKThem_Click(object sender, EventArgs e)
        {
            int manv = int.Parse(cbbTKMaNV.Text);
            if (txtTKUsername.Text != "" && cbbMaQuyen.Text != "")
            {
                BEL_TaiKhoan tk = new BEL_TaiKhoan(1, txtTKUsername.Text, manv, DateTime.Now, cbbMaQuyen.Text, "Yes");
                if (BAL_TaiKhoan.Instance.AddAccount(tk))
                {
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAccount();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại hãy kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btnTKRestPW_Click(object sender, EventArgs e)
        {
            string manv = cbbTKMaNV.Text;
            if (manv != "")
            {
                if (BAL_TaiKhoan.Instance.ResetPassword(int.Parse(manv)))
                    MessageBox.Show("Reset thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Reset thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Chọn nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnTKXoa_Click(object sender, EventArgs e)
        {
            int manv = int.Parse(cbbTKMaNV.Text);
            if (cbbTKMaNV.Text != "")
            {
                if (BAL_TaiKhoan.Instance.DelAccount(manv))
                {
                    MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAccount();
                }
                else
                {
                    MessageBox.Show("Xoá thất bại hãy kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn tài khoản muốn xoá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnTKSua_Click(object sender, EventArgs e)
        {
            int manv = int.Parse(cbbTKMaNV.Text);
            if (txtTKUsername.Text != "" && cbbMaQuyen.Text != "" && cbbTKMaNV.Text != "")
            {
                BEL_TaiKhoan tk = new BEL_TaiKhoan(1, txtTKUsername.Text, manv, DateTime.Now, cbbMaQuyen.Text, "Yes");
                if (BAL_TaiKhoan.Instance.UpAccount(tk))
                {
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAccount();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại hãy kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvTKNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dgvTKNhanVien.Rows[e.RowIndex];
                cbbTKMaNV.Text = row.Cells["Manv"].Value.ToString();
                txtTKUsername.Text = row.Cells["Username"].Value.ToString();
                cbbMaQuyen.Text = row.Cells["Maquyen"].Value.ToString();
                TimeTKLanDNhap.Value = DateTime.Parse(row.Cells["Landangnhapcuoi"].Value.ToString());
            }
            catch { }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TimnNhanVien(dgvNhanVien, textBox1.Text);
        }
        private void TimnNhanVien(DataGridView data, string ten)
        {
            data.DataSource = null;
            data.DataSource = BAL_NhanVien.Instance.TimNhanVien(ten);
        }
    }
}
