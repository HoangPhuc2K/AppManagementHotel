namespace QuanLyKhachSan
{
    partial class uctrlThongKeHoaDonThue
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnXuatfile = new System.Windows.Forms.Button();
            this.dgvDsHDThue = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsHDThue)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1218, 492);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.tabPage1.Controls.Add(this.btnXuatfile);
            this.tabPage1.Controls.Add(this.dgvDsHDThue);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1210, 463);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hoá đơn";
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
            // dgvDsHDThue
            // 
            this.dgvDsHDThue.AllowDrop = true;
            this.dgvDsHDThue.AllowUserToResizeColumns = false;
            this.dgvDsHDThue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDsHDThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDsHDThue.Location = new System.Drawing.Point(6, 104);
            this.dgvDsHDThue.Name = "dgvDsHDThue";
            this.dgvDsHDThue.RowHeadersWidth = 51;
            this.dgvDsHDThue.RowTemplate.Height = 24;
            this.dgvDsHDThue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDsHDThue.Size = new System.Drawing.Size(1198, 356);
            this.dgvDsHDThue.TabIndex = 0;
            // 
            // uctrlThongKeHoaDonThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "uctrlThongKeHoaDonThue";
            this.Size = new System.Drawing.Size(1224, 498);
            this.Load += new System.EventHandler(this.uctrlThongKeHoaDonThue_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsHDThue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvDsHDThue;
        private System.Windows.Forms.Button btnXuatfile;
    }
}
