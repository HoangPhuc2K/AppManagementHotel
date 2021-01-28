using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class uctrlGioiThieu : UserControl
    {
        private static uctrlGioiThieu instance;

        public static uctrlGioiThieu Instance
        {
            get { if (instance == null) uctrlGioiThieu.instance = new uctrlGioiThieu(); return uctrlGioiThieu.instance; }
            private set { uctrlGioiThieu.instance = value; }
        }
        public uctrlGioiThieu()
        {
            InitializeComponent();
        }
    }
}
