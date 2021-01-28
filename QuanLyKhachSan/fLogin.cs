using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
using BEL;

namespace QuanLyKhachSan
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
            txtUserName.Select();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Username = txtUserName.Text;
            string Password = txtPassWord.Text;
            if (Login(Username,Password)) {
                BEL_TaiKhoan tk = BAL_TaiKhoan.Instance.LoadTK(Username, Password);
                fAdmin Ad = new fAdmin(tk);
                this.Hide();
                Ad.ShowDialog();
                this.Show(); 
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private bool Login(string Username,string Password)
        {
            return BAL_TaiKhoan.Instance.Login(Username, Password);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát!","Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
