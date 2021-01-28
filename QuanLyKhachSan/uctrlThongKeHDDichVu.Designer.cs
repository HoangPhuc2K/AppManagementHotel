namespace QuanLyKhachSan
{
    partial class uctrlThongKeHDDichVu
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnXuatfile = new System.Windows.Forms.Button();
            this.dgvDsHDDichVu = new System.Windows.Forms.DataGridView();
            this.qUANLYKHACHSANDataSet = new QuanLyKhachSan.QUANLYKHACHSANDataSet();
            this.hoaDonDichVuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hoaDonDichVuTableAdapter = new QuanLyKhachSan.QUANLYKHACHSANDataSetTableAdapters.HoaDonDichVuTableAdapter();
            this.maHoaDonDVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySuDungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsHDDichVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYKHACHSANDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonDichVuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1218, 492);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.tabPage1.Controls.Add(this.btnXuatfile);
            this.tabPage1.Controls.Add(this.dgvDsHDDichVu);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1210, 463);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hoá đơn dịch vụ";
            // 
            // btnXuatfile
            // 
            this.btnXuatfile.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnXuatfile.ForeColor = System.Drawing.Color.White;
            this.btnXuatfile.Location = new System.Drawing.Point(1007, 31);
            this.btnXuatfile.Name = "btnXuatfile";
            this.btnXuatfile.Size = new System.Drawing.Size(172, 43);
            this.btnXuatfile.TabIndex = 1;
            this.btnXuatfile.Text = "Xuất file Excel";
            this.btnXuatfile.UseVisualStyleBackColor = false;
            this.btnXuatfile.Click += new System.EventHandler(this.btnXuatfile_Click);
            // 
            // dgvDsHDDichVu
            // 
            this.dgvDsHDDichVu.AllowDrop = true;
            this.dgvDsHDDichVu.AllowUserToResizeColumns = false;
            this.dgvDsHDDichVu.AutoGenerateColumns = false;
            this.dgvDsHDDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDsHDDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDsHDDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHoaDonDVDataGridViewTextBoxColumn,
            this.ngaySuDungDataGridViewTextBoxColumn,
            this.thanhTienDataGridViewTextBoxColumn,
            this.maNVDataGridViewTextBoxColumn,
            this.maKHDataGridViewTextBoxColumn,
            this.trangThaiDataGridViewTextBoxColumn});
            this.dgvDsHDDichVu.DataSource = this.hoaDonDichVuBindingSource;
            this.dgvDsHDDichVu.Location = new System.Drawing.Point(6, 104);
            this.dgvDsHDDichVu.Name = "dgvDsHDDichVu";
            this.dgvDsHDDichVu.RowHeadersWidth = 51;
            this.dgvDsHDDichVu.RowTemplate.Height = 24;
            this.dgvDsHDDichVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDsHDDichVu.Size = new System.Drawing.Size(1198, 356);
            this.dgvDsHDDichVu.TabIndex = 0;
            // 
            // qUANLYKHACHSANDataSet
            // 
            this.qUANLYKHACHSANDataSet.DataSetName = "QUANLYKHACHSANDataSet";
            this.qUANLYKHACHSANDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hoaDonDichVuBindingSource
            // 
            this.hoaDonDichVuBindingSource.DataMember = "HoaDonDichVu";
            this.hoaDonDichVuBindingSource.DataSource = this.qUANLYKHACHSANDataSet;
            // 
            // hoaDonDichVuTableAdapter
            // 
            this.hoaDonDichVuTableAdapter.ClearBeforeFill = true;
            // 
            // maHoaDonDVDataGridViewTextBoxColumn
            // 
            this.maHoaDonDVDataGridViewTextBoxColumn.DataPropertyName = "MaHoaDonDV";
            this.maHoaDonDVDataGridViewTextBoxColumn.HeaderText = "MaHoaDonDV";
            this.maHoaDonDVDataGridViewTextBoxColumn.Name = "maHoaDonDVDataGridViewTextBoxColumn";
            this.maHoaDonDVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngaySuDungDataGridViewTextBoxColumn
            // 
            this.ngaySuDungDataGridViewTextBoxColumn.DataPropertyName = "NgaySuDung";
            this.ngaySuDungDataGridViewTextBoxColumn.HeaderText = "NgaySuDung";
            this.ngaySuDungDataGridViewTextBoxColumn.Name = "ngaySuDungDataGridViewTextBoxColumn";
            // 
            // thanhTienDataGridViewTextBoxColumn
            // 
            this.thanhTienDataGridViewTextBoxColumn.DataPropertyName = "ThanhTien";
            this.thanhTienDataGridViewTextBoxColumn.HeaderText = "ThanhTien";
            this.thanhTienDataGridViewTextBoxColumn.Name = "thanhTienDataGridViewTextBoxColumn";
            // 
            // maNVDataGridViewTextBoxColumn
            // 
            this.maNVDataGridViewTextBoxColumn.DataPropertyName = "MaNV";
            this.maNVDataGridViewTextBoxColumn.HeaderText = "MaNV";
            this.maNVDataGridViewTextBoxColumn.Name = "maNVDataGridViewTextBoxColumn";
            // 
            // maKHDataGridViewTextBoxColumn
            // 
            this.maKHDataGridViewTextBoxColumn.DataPropertyName = "MaKH";
            this.maKHDataGridViewTextBoxColumn.HeaderText = "MaKH";
            this.maKHDataGridViewTextBoxColumn.Name = "maKHDataGridViewTextBoxColumn";
            // 
            // trangThaiDataGridViewTextBoxColumn
            // 
            this.trangThaiDataGridViewTextBoxColumn.DataPropertyName = "TrangThai";
            this.trangThaiDataGridViewTextBoxColumn.HeaderText = "TrangThai";
            this.trangThaiDataGridViewTextBoxColumn.Name = "trangThaiDataGridViewTextBoxColumn";
            // 
            // uctrlThongKeHDDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "uctrlThongKeHDDichVu";
            this.Size = new System.Drawing.Size(1222, 495);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsHDDichVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYKHACHSANDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonDichVuBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnXuatfile;
        private System.Windows.Forms.DataGridView dgvDsHDDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHoaDonDVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySuDungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhTienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource hoaDonDichVuBindingSource;
        private QUANLYKHACHSANDataSet qUANLYKHACHSANDataSet;
        private QUANLYKHACHSANDataSetTableAdapters.HoaDonDichVuTableAdapter hoaDonDichVuTableAdapter;

    }
}
