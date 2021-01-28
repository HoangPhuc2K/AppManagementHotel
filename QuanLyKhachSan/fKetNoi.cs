using DAL;
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
    public partial class fKetNoi : Form
    {
        public fKetNoi()
        {
            InitializeComponent();
        }

        private void btnKetNoi_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtServer.Text!="" && txtDatabase.Text != "")
                {
                    DataProvider.TenServer = txtServer.Text;
                    DataProvider.TenDatabase = txtDatabase.Text;
                    this.Close();
                }
            }
            catch { }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát","Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
