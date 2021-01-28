namespace QuanLyKhachSan
{
    partial class uctrlThueDichVu
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDVSoPhong = new System.Windows.Forms.TextBox();
            this.btnDVThanhToan = new System.Windows.Forms.Button();
            this.txtDVTong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lvDsDichVu = new System.Windows.Forms.ListView();
            this.TenDV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GiaDV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GiamGiaDV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnThue = new System.Windows.Forms.Button();
            this.cbbDsDV = new System.Windows.Forms.ComboBox();
            this.flpDsPhongDV = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1264, 467);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.MediumTurquoise;
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.txtDVSoPhong);
            this.tabPage3.Controls.Add(this.btnDVThanhToan);
            this.tabPage3.Controls.Add(this.txtDVTong);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.lvDsDichVu);
            this.tabPage3.Controls.Add(this.btnThue);
            this.tabPage3.Controls.Add(this.cbbDsDV);
            this.tabPage3.Controls.Add(this.flpDsPhongDV);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1256, 438);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Thuê dịch vụ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1086, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 32);
            this.button1.TabIndex = 30;
            this.button1.Text = "Xoá";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDVSoPhong
            // 
            this.txtDVSoPhong.Enabled = false;
            this.txtDVSoPhong.Location = new System.Drawing.Point(606, 37);
            this.txtDVSoPhong.Name = "txtDVSoPhong";
            this.txtDVSoPhong.Size = new System.Drawing.Size(158, 26);
            this.txtDVSoPhong.TabIndex = 29;
            // 
            // btnDVThanhToan
            // 
            this.btnDVThanhToan.Location = new System.Drawing.Point(1004, 347);
            this.btnDVThanhToan.Name = "btnDVThanhToan";
            this.btnDVThanhToan.Size = new System.Drawing.Size(133, 32);
            this.btnDVThanhToan.TabIndex = 28;
            this.btnDVThanhToan.Text = "Lưu";
            this.btnDVThanhToan.UseVisualStyleBackColor = true;
            this.btnDVThanhToan.Click += new System.EventHandler(this.btnDVThanhToan_Click);
            // 
            // txtDVTong
            // 
            this.txtDVTong.Enabled = false;
            this.txtDVTong.Location = new System.Drawing.Point(732, 350);
            this.txtDVTong.Name = "txtDVTong";
            this.txtDVTong.Size = new System.Drawing.Size(191, 26);
            this.txtDVTong.TabIndex = 27;
            this.txtDVTong.Text = "0";
            this.txtDVTong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(619, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Tổng tiền";
            // 
            // lvDsDichVu
            // 
            this.lvDsDichVu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TenDV,
            this.GiaDV,
            this.GiamGiaDV});
            this.lvDsDichVu.FullRowSelect = true;
            this.lvDsDichVu.HideSelection = false;
            this.lvDsDichVu.Location = new System.Drawing.Point(606, 70);
            this.lvDsDichVu.Name = "lvDsDichVu";
            this.lvDsDichVu.Size = new System.Drawing.Size(575, 241);
            this.lvDsDichVu.TabIndex = 25;
            this.lvDsDichVu.UseCompatibleStateImageBehavior = false;
            this.lvDsDichVu.View = System.Windows.Forms.View.Details;
            // 
            // TenDV
            // 
            this.TenDV.Text = "Tên dịch vụ";
            this.TenDV.Width = 115;
            // 
            // GiaDV
            // 
            this.GiaDV.Text = "Gía dịch vụ";
            this.GiaDV.Width = 135;
            // 
            // GiamGiaDV
            // 
            this.GiamGiaDV.Text = "Giảm giá";
            this.GiamGiaDV.Width = 85;
            // 
            // btnThue
            // 
            this.btnThue.Location = new System.Drawing.Point(978, 34);
            this.btnThue.Name = "btnThue";
            this.btnThue.Size = new System.Drawing.Size(102, 32);
            this.btnThue.TabIndex = 24;
            this.btnThue.Text = "Thêm";
            this.btnThue.UseVisualStyleBackColor = true;
            this.btnThue.Click += new System.EventHandler(this.btnThue_Click);
            // 
            // cbbDsDV
            // 
            this.cbbDsDV.FormattingEnabled = true;
            this.cbbDsDV.Location = new System.Drawing.Point(792, 37);
            this.cbbDsDV.Name = "cbbDsDV";
            this.cbbDsDV.Size = new System.Drawing.Size(170, 28);
            this.cbbDsDV.TabIndex = 23;
            // 
            // flpDsPhongDV
            // 
            this.flpDsPhongDV.Location = new System.Drawing.Point(6, 6);
            this.flpDsPhongDV.Name = "flpDsPhongDV";
            this.flpDsPhongDV.Size = new System.Drawing.Size(508, 404);
            this.flpDsPhongDV.TabIndex = 22;
            // 
            // uctrlThueDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "uctrlThueDichVu";
            this.Size = new System.Drawing.Size(1267, 473);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtDVSoPhong;
        private System.Windows.Forms.Button btnDVThanhToan;
        private System.Windows.Forms.TextBox txtDVTong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvDsDichVu;
        private System.Windows.Forms.ColumnHeader TenDV;
        private System.Windows.Forms.ColumnHeader GiaDV;
        private System.Windows.Forms.ColumnHeader GiamGiaDV;
        private System.Windows.Forms.Button btnThue;
        private System.Windows.Forms.ComboBox cbbDsDV;
        private System.Windows.Forms.FlowLayoutPanel flpDsPhongDV;
        private System.Windows.Forms.Button button1;
    }
}
