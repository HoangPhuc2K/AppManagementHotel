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
    public partial class uctrlPhongcs : UserControl
    {
        private static uctrlPhongcs instance;
        private static int manv;

        public static int Manv
        {
            private get { return uctrlPhongcs.manv; }
            set { uctrlPhongcs.manv = value; }
        }


        public static uctrlPhongcs Instance
        {
            get {uctrlPhongcs.instance = new uctrlPhongcs(); return uctrlPhongcs.instance; }
            private set { uctrlPhongcs.instance = value; }
        }
        public uctrlPhongcs()
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
        private bool KiemTraTrong()
        {
            if (txtSoPhong.Text != "" && cbbMaLoaiPhong.Text != "")
                return true;
            return false;
        }
        private void LoadRoom()
        {
            flpPhong.Controls.Clear();
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
                }
                else
                {
                    btn.BackColor = Color.White;
                }
                flpPhong.Controls.Add(btn);
            }
            GVPhong.DataSource = listroom;
            cbbMaLoaiPhong.DataSource = listLoai;
            cbbMaLoaiPhong.DisplayMember = "TenLoaiPhong";
            cbbMaLoaiPhong.ValueMember = "MaLoaiPhong";
        }
        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            List<BEL_Phong> room = BAL_Phong.Instance.LoadRoomList();
            if (txtSoPhong.Text != "" && cbbMaLoaiPhong.Text != "")
            {
                BEL_Phong add = new BEL_Phong(txtSoPhong.Text,BAL_LoaiPhong.Instance.LoadLoaiPhongTheoTen(cbbMaLoaiPhong.Text).Maloaiphong, "No");
                bool flag = true;

                for (int i = 0; i < room.Count; i++)
                {
                    if (room[i].Sophong == add.Sophong)
                    {
                        flag = false;
                    }
                }
                if (flag)
                {
                    if (BAL_Phong.Instance.InsertRoom(add))
                        MessageBox.Show("Đã thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    flpPhong.Controls.Clear();
                    LoadRoom();
                }
                else
                {
                    MessageBox.Show("Phòng đã có!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else 
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnUpRoom_Click(object sender, EventArgs e)
        {
            List<BEL_Phong> room = BAL_Phong.Instance.LoadRoomList();
            if (txtSoPhong.Text != "" && cbbMaLoaiPhong.Text != "")
            {
                BEL_Phong add = new BEL_Phong(txtSoPhong.Text, cbbMaLoaiPhong.Text, null);
                bool flag = false;
                for (int i = 0; i < room.Count; i++)
                {
                    if (room[i].Sophong == add.Sophong)
                    {
                        flag = true;
                    }
                }
                if (flag)
                {
                    BAL_Phong.Instance.UpdateRoom(add);
                    flpPhong.Controls.Clear();
                    LoadRoom();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnDelRoom_Click(object sender, EventArgs e)
        {
            if (KiemTraTrong())
            {
                string maloaiphong = BAL_LoaiPhong.Instance.LoadLoaiPhongTheoTen(cbbMaLoaiPhong.Text).Maloaiphong;
                string trangthai = BAL_Phong.Instance.LoadRoomSoPhong(txtSoPhong.Text).Trangthaiphong;

                BEL_Phong Del = new BEL_Phong(txtSoPhong.Text,maloaiphong,trangthai);
                if (Del.Trangthaiphong != "Yes")
                {
                    if (BAL_Phong.Instance.DeleteRoom(Del))
                    {
                        txtSoPhong.Text = "";
                        flpPhong.Controls.Clear();
                        LoadRoom();
                        MessageBox.Show("Đã xoá phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Xoá phòng không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Phòng đang sử dụng không thể xoá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void GVPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = GVPhong.Rows[e.RowIndex];
                txtSoPhong.Text = row.Cells["SoPhong"].Value.ToString();
                cbbMaLoaiPhong.Text = BAL_LoaiPhong.Instance.LoadLoaiPhongTheoMa(row.Cells["MaLoaiPhong"].Value.ToString()).Tenloaiphong;
            }
            catch
            {

            }
        }
        
        public void loadlai()
        {
            flpPhong.Controls.Clear();
            LoadRoom();
        }
        private void btnPhong_Click(object sender, EventArgs e)
        {
            Button btn = (Button) sender;
            txtSoPhong.Text = btn.Text;
            string maloai = BAL_Phong.Instance.LoadRoomSoPhong(txtSoPhong.Text).Maloaiphong;
            cbbMaLoaiPhong.Text = BAL_LoaiPhong.Instance.LoadLoaiPhongTheoMa(maloai).Tenloaiphong;
        }

        private void uctrlPhongcs_Load(object sender, EventArgs e)
        {
            LoadRoom();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadRoom();
        }
    }
}
