namespace QuanLyKhachSan
{
    partial class rpHoaDon
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.HoaDon_ViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QUANLYKHACHSANDataSet = new QuanLyKhachSan.QUANLYKHACHSANDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.HoaDon_ViewTableAdapter = new QuanLyKhachSan.QUANLYKHACHSANDataSetTableAdapters.HoaDon_ViewTableAdapter();
            this.btnHoanTat = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.HoaDonDichVuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HoaDonDichVuTableAdapter = new QuanLyKhachSan.QUANLYKHACHSANDataSetTableAdapters.HoaDonDichVuTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.HoaDon_ViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QUANLYKHACHSANDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoaDonDichVuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // HoaDon_ViewBindingSource
            // 
            this.HoaDon_ViewBindingSource.DataMember = "HoaDon_View";
            this.HoaDon_ViewBindingSource.DataSource = this.QUANLYKHACHSANDataSet;
            // 
            // QUANLYKHACHSANDataSet
            // 
            this.QUANLYKHACHSANDataSet.DataSetName = "QUANLYKHACHSANDataSet";
            this.QUANLYKHACHSANDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoScroll = true;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.HoaDon_ViewBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.HoaDonDichVuBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyKhachSan.rpHoaDon.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1069, 574);
            this.reportViewer1.TabIndex = 0;
            // 
            // HoaDon_ViewTableAdapter
            // 
            this.HoaDon_ViewTableAdapter.ClearBeforeFill = true;
            // 
            // btnHoanTat
            // 
            this.btnHoanTat.Location = new System.Drawing.Point(841, 606);
            this.btnHoanTat.Name = "btnHoanTat";
            this.btnHoanTat.Size = new System.Drawing.Size(101, 38);
            this.btnHoanTat.TabIndex = 2;
            this.btnHoanTat.Text = "Hoàn tất";
            this.btnHoanTat.UseVisualStyleBackColor = true;
            this.btnHoanTat.Click += new System.EventHandler(this.btnHoanTat_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(968, 606);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(101, 38);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // HoaDonDichVuBindingSource
            // 
            this.HoaDonDichVuBindingSource.DataMember = "HoaDonDichVu";
            this.HoaDonDichVuBindingSource.DataSource = this.QUANLYKHACHSANDataSet;
            // 
            // HoaDonDichVuTableAdapter
            // 
            this.HoaDonDichVuTableAdapter.ClearBeforeFill = true;
            // 
            // rpHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 656);
            this.ControlBox = false;
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHoanTat);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rpHoaDon";
            this.Text = "rpHoaDon";
            this.Load += new System.EventHandler(this.rpHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HoaDon_ViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QUANLYKHACHSANDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoaDonDichVuBindingSource)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource HoaDon_ViewBindingSource;
        private QUANLYKHACHSANDataSet QUANLYKHACHSANDataSet;
        private QUANLYKHACHSANDataSetTableAdapters.HoaDon_ViewTableAdapter HoaDon_ViewTableAdapter;
        private System.Windows.Forms.Button btnHoanTat;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.BindingSource HoaDonDichVuBindingSource;
        private QUANLYKHACHSANDataSetTableAdapters.HoaDonDichVuTableAdapter HoaDonDichVuTableAdapter;
    }
}