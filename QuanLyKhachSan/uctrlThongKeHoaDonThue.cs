using BAL;
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
    public partial class uctrlThongKeHoaDonThue : UserControl
    {
        private static uctrlThongKeHoaDonThue instance;

        public static uctrlThongKeHoaDonThue Instance
        {
            get { if (instance == null) uctrlThongKeHoaDonThue.instance = new uctrlThongKeHoaDonThue(); return uctrlThongKeHoaDonThue.instance; }
            private set { uctrlThongKeHoaDonThue.instance = value; }
        }
        public uctrlThongKeHoaDonThue()
        {
            InitializeComponent();
        }

        private void btnXuatfile_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                app.Visible = true;
                worksheet.Cells[1, 1] = "THỐNG KÊ HOÁ ĐƠN";
                worksheet.Cells[3, 2] = "Ngày lặp:" + DateTime.Now;
                worksheet.Cells[6, 1] = "Mã hoá đơn";
                worksheet.Cells[6, 2] = "Mã nhân viên";
                worksheet.Cells[6, 3] = "Mã đặt phòng";
                worksheet.Cells[6, 4] = "Mã trả phòng";
                worksheet.Cells[6, 5] = "Mã khách hàng";
                worksheet.Cells[6, 6] = "Ngày lặp hoá đơn";
                worksheet.Cells[6, 7] = "Tiền đặt cọc";
                worksheet.Cells[6, 8] = "Tổng tiền thêu";
                if (dgvDsHDThue.RowCount > 0)
                {
                    for (int i = 0; i < dgvDsHDThue.RowCount; i++)
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            worksheet.Cells[i + 7, j + 1] = dgvDsHDThue.Rows[i].Cells[j].Value;
                        }
                    }
                }
            }
            catch { }
        }

        private void uctrlThongKeHoaDonThue_Load(object sender, EventArgs e)
        {
            HienThiGridView(dgvDsHDThue);
        }
        private void HienThiGridView(DataGridView data)
        {
            data.DataSource = null;
            data.DataSource = BAL_HoaDonThue.Instance.LoadHoaDon();
        }
        public void LoadLai()
        {
            HienThiGridView(dgvDsHDThue);
        }
    }
}
