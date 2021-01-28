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
    public partial class uctrlThongKeHDDichVu : UserControl
    {
        private static uctrlThongKeHDDichVu instance;

        public static uctrlThongKeHDDichVu Instance
        {
            get { if (instance == null) uctrlThongKeHDDichVu.instance = new uctrlThongKeHDDichVu(); return uctrlThongKeHDDichVu.instance; }
            private set { uctrlThongKeHDDichVu.instance = value; }
        }
        public uctrlThongKeHDDichVu()
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
                worksheet.Cells[1, 1] = "THỐNG KÊ HOÁ ĐƠN DỊCH VỤ";
                worksheet.Cells[3, 2] = "Ngày lặp:" + DateTime.Now;
                worksheet.Cells[6, 1] = "Mã hoá đơn dịch vụ";
                worksheet.Cells[6, 2] = "Ngày sử dụng";
                worksheet.Cells[6, 3] = "Thành tiền";
                worksheet.Cells[6, 4] = "Mã nhân viên";
                worksheet.Cells[6, 5] = "Mã khách hàng";
                worksheet.Cells[6, 6] = "Trạng thái";
                if (dgvDsHDDichVu.RowCount > 0)
                {
                    for (int i = 0; i < dgvDsHDDichVu.RowCount; i++)
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            worksheet.Cells[i + 7, j + 1] = dgvDsHDDichVu.Rows[i].Cells[j].Value;
                        }
                    }
                }
            }
            catch { }
        }
    }
}
