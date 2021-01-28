namespace QuanLyKhachSan
{
    partial class uctrlNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uctrlNhanVien));
            this.tabNVThongTinNV = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNVXoa = new System.Windows.Forms.Button();
            this.btnNVSua = new System.Windows.Forms.Button();
            this.btnNVThem = new System.Windows.Forms.Button();
            this.txtNVChucVu = new System.Windows.Forms.TextBox();
            this.txtNVDiaChi = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.txtNVHeSoLuong = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.radNVNu = new System.Windows.Forms.RadioButton();
            this.radNVNam = new System.Windows.Forms.RadioButton();
            this.label34 = new System.Windows.Forms.Label();
            this.txtNVCMND = new System.Windows.Forms.TextBox();
            this.txtNVHoTenNV = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.txtNVMaNV = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cbbTKMaNV = new System.Windows.Forms.ComboBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.label43 = new System.Windows.Forms.Label();
            this.btnTKRestPW = new System.Windows.Forms.Button();
            this.cbbMaQuyen = new System.Windows.Forms.ComboBox();
            this.btnTKSua = new System.Windows.Forms.Button();
            this.btnTKXoa = new System.Windows.Forms.Button();
            this.btnTKThem = new System.Windows.Forms.Button();
            this.TimeTKLanDNhap = new System.Windows.Forms.DateTimePicker();
            this.label42 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.txtTKUsername = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.dgvTKNhanVien = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabNVThongTinNV.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // tabNVThongTinNV
            // 
            this.tabNVThongTinNV.Controls.Add(this.tabPage4);
            this.tabNVThongTinNV.Controls.Add(this.tabPage3);
            this.tabNVThongTinNV.Location = new System.Drawing.Point(0, 3);
            this.tabNVThongTinNV.Name = "tabNVThongTinNV";
            this.tabNVThongTinNV.SelectedIndex = 0;
            this.tabNVThongTinNV.Size = new System.Drawing.Size(1218, 445);
            this.tabNVThongTinNV.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.MediumTurquoise;
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.textBox1);
            this.tabPage4.Controls.Add(this.dtpNgaySinh);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.btnNVXoa);
            this.tabPage4.Controls.Add(this.btnNVSua);
            this.tabPage4.Controls.Add(this.btnNVThem);
            this.tabPage4.Controls.Add(this.txtNVChucVu);
            this.tabPage4.Controls.Add(this.txtNVDiaChi);
            this.tabPage4.Controls.Add(this.label37);
            this.tabPage4.Controls.Add(this.label36);
            this.tabPage4.Controls.Add(this.txtNVHeSoLuong);
            this.tabPage4.Controls.Add(this.label35);
            this.tabPage4.Controls.Add(this.groupBox9);
            this.tabPage4.Controls.Add(this.label34);
            this.tabPage4.Controls.Add(this.txtNVCMND);
            this.tabPage4.Controls.Add(this.txtNVHoTenNV);
            this.tabPage4.Controls.Add(this.label33);
            this.tabPage4.Controls.Add(this.txtNVMaNV);
            this.tabPage4.Controls.Add(this.label32);
            this.tabPage4.Controls.Add(this.dgvNhanVien);
            this.tabPage4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1210, 416);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Thông tin nhân viên";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(545, 114);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(200, 26);
            this.dtpNgaySinh.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(404, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Ngày sinh";
            // 
            // btnNVXoa
            // 
            this.btnNVXoa.BackColor = System.Drawing.Color.White;
            this.btnNVXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNVXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnNVXoa.Image")));
            this.btnNVXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNVXoa.Location = new System.Drawing.Point(1068, 351);
            this.btnNVXoa.Name = "btnNVXoa";
            this.btnNVXoa.Size = new System.Drawing.Size(117, 39);
            this.btnNVXoa.TabIndex = 18;
            this.btnNVXoa.Text = "Xoá";
            this.btnNVXoa.UseVisualStyleBackColor = false;
            this.btnNVXoa.Click += new System.EventHandler(this.btnNVXoa_Click);
            // 
            // btnNVSua
            // 
            this.btnNVSua.BackColor = System.Drawing.Color.White;
            this.btnNVSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNVSua.Image = ((System.Drawing.Image)(resources.GetObject("btnNVSua.Image")));
            this.btnNVSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNVSua.Location = new System.Drawing.Point(1068, 290);
            this.btnNVSua.Name = "btnNVSua";
            this.btnNVSua.Size = new System.Drawing.Size(117, 39);
            this.btnNVSua.TabIndex = 17;
            this.btnNVSua.Text = "Sửa";
            this.btnNVSua.UseVisualStyleBackColor = false;
            this.btnNVSua.Click += new System.EventHandler(this.btnNVSua_Click);
            // 
            // btnNVThem
            // 
            this.btnNVThem.BackColor = System.Drawing.Color.White;
            this.btnNVThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNVThem.ForeColor = System.Drawing.Color.Black;
            this.btnNVThem.Image = ((System.Drawing.Image)(resources.GetObject("btnNVThem.Image")));
            this.btnNVThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNVThem.Location = new System.Drawing.Point(1068, 225);
            this.btnNVThem.Name = "btnNVThem";
            this.btnNVThem.Size = new System.Drawing.Size(117, 39);
            this.btnNVThem.TabIndex = 16;
            this.btnNVThem.Text = "Thêm";
            this.btnNVThem.UseVisualStyleBackColor = false;
            this.btnNVThem.Click += new System.EventHandler(this.btnNVThem_Click);
            // 
            // txtNVChucVu
            // 
            this.txtNVChucVu.Location = new System.Drawing.Point(922, 72);
            this.txtNVChucVu.Name = "txtNVChucVu";
            this.txtNVChucVu.Size = new System.Drawing.Size(200, 26);
            this.txtNVChucVu.TabIndex = 15;
            // 
            // txtNVDiaChi
            // 
            this.txtNVDiaChi.Location = new System.Drawing.Point(922, 24);
            this.txtNVDiaChi.Name = "txtNVDiaChi";
            this.txtNVDiaChi.Size = new System.Drawing.Size(200, 26);
            this.txtNVDiaChi.TabIndex = 13;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(792, 76);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(77, 20);
            this.label37.TabIndex = 11;
            this.label37.Text = "Chức vụ";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(792, 24);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(68, 20);
            this.label36.TabIndex = 10;
            this.label36.Text = "Địa chỉ";
            // 
            // txtNVHeSoLuong
            // 
            this.txtNVHeSoLuong.Location = new System.Drawing.Point(922, 117);
            this.txtNVHeSoLuong.Name = "txtNVHeSoLuong";
            this.txtNVHeSoLuong.Size = new System.Drawing.Size(200, 26);
            this.txtNVHeSoLuong.TabIndex = 9;
            this.txtNVHeSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(792, 117);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(110, 20);
            this.label35.TabIndex = 8;
            this.label35.Text = "Hệ số lương";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.radNVNu);
            this.groupBox9.Controls.Add(this.radNVNam);
            this.groupBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.Location = new System.Drawing.Point(404, 10);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(341, 88);
            this.groupBox9.TabIndex = 7;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Giới tính";
            // 
            // radNVNu
            // 
            this.radNVNu.AutoSize = true;
            this.radNVNu.Location = new System.Drawing.Point(246, 34);
            this.radNVNu.Name = "radNVNu";
            this.radNVNu.Size = new System.Drawing.Size(53, 24);
            this.radNVNu.TabIndex = 1;
            this.radNVNu.TabStop = true;
            this.radNVNu.Text = "Nữ";
            this.radNVNu.UseVisualStyleBackColor = true;
            // 
            // radNVNam
            // 
            this.radNVNam.AutoSize = true;
            this.radNVNam.Location = new System.Drawing.Point(38, 34);
            this.radNVNam.Name = "radNVNam";
            this.radNVNam.Size = new System.Drawing.Size(68, 24);
            this.radNVNam.TabIndex = 0;
            this.radNVNam.TabStop = true;
            this.radNVNam.Text = "Nam";
            this.radNVNam.UseVisualStyleBackColor = true;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(15, 120);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(64, 20);
            this.label34.TabIndex = 6;
            this.label34.Text = "CMND";
            // 
            // txtNVCMND
            // 
            this.txtNVCMND.Location = new System.Drawing.Point(172, 117);
            this.txtNVCMND.Name = "txtNVCMND";
            this.txtNVCMND.Size = new System.Drawing.Size(200, 26);
            this.txtNVCMND.TabIndex = 5;
            // 
            // txtNVHoTenNV
            // 
            this.txtNVHoTenNV.Location = new System.Drawing.Point(172, 69);
            this.txtNVHoTenNV.Name = "txtNVHoTenNV";
            this.txtNVHoTenNV.Size = new System.Drawing.Size(200, 26);
            this.txtNVHoTenNV.TabIndex = 4;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(15, 72);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(126, 20);
            this.label33.TabIndex = 3;
            this.label33.Text = "Tên nhân viên";
            // 
            // txtNVMaNV
            // 
            this.txtNVMaNV.Enabled = false;
            this.txtNVMaNV.Location = new System.Drawing.Point(172, 24);
            this.txtNVMaNV.Name = "txtNVMaNV";
            this.txtNVMaNV.Size = new System.Drawing.Size(200, 26);
            this.txtNVMaNV.TabIndex = 2;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(15, 24);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(120, 20);
            this.label32.TabIndex = 1;
            this.label32.Text = "Mã nhân viên";
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Location = new System.Drawing.Point(3, 225);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.RowTemplate.Height = 24;
            this.dgvNhanVien.Size = new System.Drawing.Size(1044, 179);
            this.dgvNhanVien.TabIndex = 0;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.MediumTurquoise;
            this.tabPage3.Controls.Add(this.cbbTKMaNV);
            this.tabPage3.Controls.Add(this.groupBox10);
            this.tabPage3.Controls.Add(this.cbbMaQuyen);
            this.tabPage3.Controls.Add(this.btnTKSua);
            this.tabPage3.Controls.Add(this.btnTKXoa);
            this.tabPage3.Controls.Add(this.btnTKThem);
            this.tabPage3.Controls.Add(this.TimeTKLanDNhap);
            this.tabPage3.Controls.Add(this.label42);
            this.tabPage3.Controls.Add(this.label41);
            this.tabPage3.Controls.Add(this.txtTKUsername);
            this.tabPage3.Controls.Add(this.label40);
            this.tabPage3.Controls.Add(this.label39);
            this.tabPage3.Controls.Add(this.dgvTKNhanVien);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1210, 416);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tài khoản nhân viên";
            // 
            // cbbTKMaNV
            // 
            this.cbbTKMaNV.FormattingEnabled = true;
            this.cbbTKMaNV.Location = new System.Drawing.Point(724, 48);
            this.cbbTKMaNV.Name = "cbbTKMaNV";
            this.cbbTKMaNV.Size = new System.Drawing.Size(137, 28);
            this.cbbTKMaNV.TabIndex = 21;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.label43);
            this.groupBox10.Controls.Add(this.btnTKRestPW);
            this.groupBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox10.Location = new System.Drawing.Point(581, 228);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(254, 161);
            this.groupBox10.TabIndex = 20;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "ResetPass";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(6, 43);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(213, 20);
            this.label43.TabIndex = 9;
            this.label43.Text = "PassWord mặc định:123";
            // 
            // btnTKRestPW
            // 
            this.btnTKRestPW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnTKRestPW.Location = new System.Drawing.Point(34, 82);
            this.btnTKRestPW.Name = "btnTKRestPW";
            this.btnTKRestPW.Size = new System.Drawing.Size(174, 50);
            this.btnTKRestPW.TabIndex = 19;
            this.btnTKRestPW.Text = "ResetPassword";
            this.btnTKRestPW.UseVisualStyleBackColor = false;
            this.btnTKRestPW.Click += new System.EventHandler(this.btnTKRestPW_Click);
            // 
            // cbbMaQuyen
            // 
            this.cbbMaQuyen.FormattingEnabled = true;
            this.cbbMaQuyen.Location = new System.Drawing.Point(1046, 129);
            this.cbbMaQuyen.Name = "cbbMaQuyen";
            this.cbbMaQuyen.Size = new System.Drawing.Size(137, 28);
            this.cbbMaQuyen.TabIndex = 18;
            // 
            // btnTKSua
            // 
            this.btnTKSua.BackColor = System.Drawing.Color.White;
            this.btnTKSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTKSua.Image = ((System.Drawing.Image)(resources.GetObject("btnTKSua.Image")));
            this.btnTKSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTKSua.Location = new System.Drawing.Point(968, 317);
            this.btnTKSua.Name = "btnTKSua";
            this.btnTKSua.Size = new System.Drawing.Size(117, 39);
            this.btnTKSua.TabIndex = 17;
            this.btnTKSua.Text = "Sửa";
            this.btnTKSua.UseVisualStyleBackColor = false;
            this.btnTKSua.Click += new System.EventHandler(this.btnTKSua_Click);
            // 
            // btnTKXoa
            // 
            this.btnTKXoa.BackColor = System.Drawing.Color.White;
            this.btnTKXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTKXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnTKXoa.Image")));
            this.btnTKXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTKXoa.Location = new System.Drawing.Point(1087, 316);
            this.btnTKXoa.Name = "btnTKXoa";
            this.btnTKXoa.Size = new System.Drawing.Size(117, 39);
            this.btnTKXoa.TabIndex = 16;
            this.btnTKXoa.Text = "Xoá";
            this.btnTKXoa.UseVisualStyleBackColor = false;
            this.btnTKXoa.Click += new System.EventHandler(this.btnTKXoa_Click);
            // 
            // btnTKThem
            // 
            this.btnTKThem.BackColor = System.Drawing.Color.White;
            this.btnTKThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTKThem.Image = ((System.Drawing.Image)(resources.GetObject("btnTKThem.Image")));
            this.btnTKThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTKThem.Location = new System.Drawing.Point(850, 317);
            this.btnTKThem.Name = "btnTKThem";
            this.btnTKThem.Size = new System.Drawing.Size(117, 39);
            this.btnTKThem.TabIndex = 15;
            this.btnTKThem.Text = "Thêm";
            this.btnTKThem.UseVisualStyleBackColor = false;
            this.btnTKThem.Click += new System.EventHandler(this.btnTKThem_Click);
            // 
            // TimeTKLanDNhap
            // 
            this.TimeTKLanDNhap.Enabled = false;
            this.TimeTKLanDNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TimeTKLanDNhap.Location = new System.Drawing.Point(1046, 50);
            this.TimeTKLanDNhap.Name = "TimeTKLanDNhap";
            this.TimeTKLanDNhap.Size = new System.Drawing.Size(137, 26);
            this.TimeTKLanDNhap.TabIndex = 10;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(890, 129);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(89, 20);
            this.label42.TabIndex = 8;
            this.label42.Text = "Mã quyền";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(890, 56);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(132, 20);
            this.label41.TabIndex = 7;
            this.label41.Text = "Lân đăng nhập";
            // 
            // txtTKUsername
            // 
            this.txtTKUsername.Location = new System.Drawing.Point(724, 129);
            this.txtTKUsername.Name = "txtTKUsername";
            this.txtTKUsername.Size = new System.Drawing.Size(137, 26);
            this.txtTKUsername.TabIndex = 4;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(573, 129);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(97, 20);
            this.label40.TabIndex = 3;
            this.label40.Text = "UserName";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(577, 53);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(120, 20);
            this.label39.TabIndex = 2;
            this.label39.Text = "Mã nhân viên";
            // 
            // dgvTKNhanVien
            // 
            this.dgvTKNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTKNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTKNhanVien.Location = new System.Drawing.Point(3, 6);
            this.dgvTKNhanVien.Name = "dgvTKNhanVien";
            this.dgvTKNhanVien.RowHeadersWidth = 51;
            this.dgvTKNhanVien.RowTemplate.Height = 24;
            this.dgvTKNhanVien.Size = new System.Drawing.Size(564, 398);
            this.dgvTKNhanVien.TabIndex = 0;
            this.dgvTKNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTKNhanVien_CellClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(837, 193);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 26);
            this.textBox1.TabIndex = 21;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(616, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nhập tên nhân viên";
            // 
            // uctrlNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabNVThongTinNV);
            this.Name = "uctrlNhanVien";
            this.Size = new System.Drawing.Size(1221, 445);
            this.Load += new System.EventHandler(this.uctrlNhanVien_Load);
            this.tabNVThongTinNV.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKNhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabNVThongTinNV;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnNVXoa;
        private System.Windows.Forms.Button btnNVSua;
        private System.Windows.Forms.Button btnNVThem;
        private System.Windows.Forms.TextBox txtNVChucVu;
        private System.Windows.Forms.TextBox txtNVDiaChi;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox txtNVHeSoLuong;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.RadioButton radNVNu;
        private System.Windows.Forms.RadioButton radNVNam;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox txtNVCMND;
        private System.Windows.Forms.TextBox txtNVHoTenNV;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox txtNVMaNV;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Button btnTKRestPW;
        private System.Windows.Forms.ComboBox cbbMaQuyen;
        private System.Windows.Forms.Button btnTKSua;
        private System.Windows.Forms.Button btnTKXoa;
        private System.Windows.Forms.Button btnTKThem;
        private System.Windows.Forms.DateTimePicker TimeTKLanDNhap;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox txtTKUsername;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.DataGridView dgvTKNhanVien;
        private System.Windows.Forms.ComboBox cbbTKMaNV;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}
