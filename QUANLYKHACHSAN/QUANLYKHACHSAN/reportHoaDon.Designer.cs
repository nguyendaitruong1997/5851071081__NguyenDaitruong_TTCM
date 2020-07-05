namespace QUANLYKHACHSAN
{
    partial class reportHoaDon
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSetReport = new QUANLYKHACHSAN.DataSetReport();
            this.reportHoaDonChuanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportHoaDonChuanTableAdapter = new QUANLYKHACHSAN.DataSetReportTableAdapters.reportHoaDonChuanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportHoaDonChuanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.reportHoaDonChuanBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QUANLYKHACHSAN.ReportHoaDon.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1292, 615);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetReport
            // 
            this.DataSetReport.DataSetName = "DataSetReport";
            this.DataSetReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportHoaDonChuanBindingSource
            // 
            this.reportHoaDonChuanBindingSource.DataMember = "reportHoaDonChuan";
            this.reportHoaDonChuanBindingSource.DataSource = this.DataSetReport;
            // 
            // reportHoaDonChuanTableAdapter
            // 
            this.reportHoaDonChuanTableAdapter.ClearBeforeFill = true;
            // 
            // reportHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 615);
            this.Controls.Add(this.reportViewer1);
            this.Name = "reportHoaDon";
            this.Text = "reportHoaDon";
            this.Load += new System.EventHandler(this.reportHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportHoaDonChuanBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource reportHoaDonChuanBindingSource;
        private DataSetReport DataSetReport;
        private DataSetReportTableAdapters.reportHoaDonChuanTableAdapter reportHoaDonChuanTableAdapter;
    }
}