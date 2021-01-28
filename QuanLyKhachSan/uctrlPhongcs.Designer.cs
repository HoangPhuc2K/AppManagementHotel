namespace QuanLyKhachSan
{
    partial class uctrlPhongcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uctrlPhongcs));
            this.tabPhong = new System.Windows.Forms.TabControl();
            this.tabThongTin = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GVPhong = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelRoom = new System.Windows.Forms.Button();
            this.btnUpRoom = new System.Windows.Forms.Button();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbMaLoaiPhong = new System.Windows.Forms.ComboBox();
            this.txtSoPhong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.flpPhong = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPhong.SuspendLayout();
            this.tabThongTin.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVPhong)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPhong
            // 
            this.tabPhong.Controls.Add(this.tabThongTin);
            this.tabPhong.Location = new System.Drawing.Point(0, 3);
            this.tabPhong.Name = "tabPhong";
            this.tabPhong.SelectedIndex = 0;
            this.tabPhong.Size = new System.Drawing.Size(1210, 474);
            this.tabPhong.TabIndex = 1;
            this.tabPhong.Tag = "";
            // 
            // tabThongTin
            // 
            this.tabThongTin.Controls.Add(this.panel1);
            this.tabThongTin.Location = new System.Drawing.Point(4, 25);
            this.tabThongTin.Name = "tabThongTin";
            this.tabThongTin.Padding = new System.Windows.Forms.Padding(3);
            this.tabThongTin.Size = new System.Drawing.Size(1202, 445);
            this.tabThongTin.TabIndex = 0;
            this.tabThongTin.Text = "Thông tin phòng";
            this.tabThongTin.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.GVPhong);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.flpPhong);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(6, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 432);
            this.panel1.TabIndex = 0;
            // 
            // GVPhong
            // 
            this.GVPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GVPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVPhong.Location = new System.Drawing.Point(619, 238);
            this.GVPhong.Name = "GVPhong";
            this.GVPhong.RowHeadersWidth = 51;
            this.GVPhong.RowTemplate.Height = 24;
            this.GVPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GVPhong.Size = new System.Drawing.Size(551, 158);
            this.GVPhong.TabIndex = 3;
            this.GVPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GVPhong_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDelRoom);
            this.panel2.Controls.Add(this.btnUpRoom);
            this.panel2.Controls.Add(this.btnAddRoom);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(1013, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(157, 205);
            this.panel2.TabIndex = 2;
            // 
            // btnDelRoom
            // 
            this.btnDelRoom.BackColor = System.Drawing.Color.White;
            this.btnDelRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelRoom.Image = ((System.Drawing.Image)(resources.GetObject("btnDelRoom.Image")));
            this.btnDelRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelRoom.Location = new System.Drawing.Point(21, 143);
            this.btnDelRoom.Name = "btnDelRoom";
            this.btnDelRoom.Size = new System.Drawing.Size(117, 39);
            this.btnDelRoom.TabIndex = 3;
            this.btnDelRoom.Text = "Xoá";
            this.btnDelRoom.UseVisualStyleBackColor = false;
            this.btnDelRoom.Click += new System.EventHandler(this.btnDelRoom_Click);
            // 
            // btnUpRoom
            // 
            this.btnUpRoom.BackColor = System.Drawing.Color.White;
            this.btnUpRoom.Image = ((System.Drawing.Image)(resources.GetObject("btnUpRoom.Image")));
            this.btnUpRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpRoom.Location = new System.Drawing.Point(21, 85);
            this.btnUpRoom.Name = "btnUpRoom";
            this.btnUpRoom.Size = new System.Drawing.Size(117, 39);
            this.btnUpRoom.TabIndex = 2;
            this.btnUpRoom.Text = "Sửa";
            this.btnUpRoom.UseVisualStyleBackColor = false;
            this.btnUpRoom.Click += new System.EventHandler(this.btnUpRoom_Click);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.BackColor = System.Drawing.Color.White;
            this.btnAddRoom.Image = ((System.Drawing.Image)(resources.GetObject("btnAddRoom.Image")));
            this.btnAddRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddRoom.Location = new System.Drawing.Point(21, 22);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(117, 39);
            this.btnAddRoom.TabIndex = 0;
            this.btnAddRoom.Text = "Thêm ";
            this.btnAddRoom.UseVisualStyleBackColor = false;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbMaLoaiPhong);
            this.groupBox1.Controls.Add(this.txtSoPhong);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(620, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 218);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lý phòng";
            // 
            // cbbMaLoaiPhong
            // 
            this.cbbMaLoaiPhong.FormattingEnabled = true;
            this.cbbMaLoaiPhong.Location = new System.Drawing.Point(181, 134);
            this.cbbMaLoaiPhong.Name = "cbbMaLoaiPhong";
            this.cbbMaLoaiPhong.Size = new System.Drawing.Size(164, 28);
            this.cbbMaLoaiPhong.TabIndex = 6;
            // 
            // txtSoPhong
            // 
            this.txtSoPhong.Location = new System.Drawing.Point(181, 43);
            this.txtSoPhong.Name = "txtSoPhong";
            this.txtSoPhong.Size = new System.Drawing.Size(164, 26);
            this.txtSoPhong.TabIndex = 3;
            this.txtSoPhong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Loại phòng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Số phòng";
            // 
            // flpPhong
            // 
            this.flpPhong.AutoScroll = true;
            this.flpPhong.Location = new System.Drawing.Point(11, 14);
            this.flpPhong.Name = "flpPhong";
            this.flpPhong.Size = new System.Drawing.Size(553, 314);
            this.flpPhong.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "Làm mới";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // uctrlPhongcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabPhong);
            this.Name = "uctrlPhongcs";
            this.Size = new System.Drawing.Size(1211, 480);
            this.Load += new System.EventHandler(this.uctrlPhongcs_Load);
            this.tabPhong.ResumeLayout(false);
            this.tabThongTin.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GVPhong)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPhong;
        private System.Windows.Forms.TabPage tabThongTin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView GVPhong;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDelRoom;
        private System.Windows.Forms.Button btnUpRoom;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSoPhong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.FlowLayoutPanel flpPhong;
        private System.Windows.Forms.ComboBox cbbMaLoaiPhong;
        private System.Windows.Forms.Button button1;
    }
}
