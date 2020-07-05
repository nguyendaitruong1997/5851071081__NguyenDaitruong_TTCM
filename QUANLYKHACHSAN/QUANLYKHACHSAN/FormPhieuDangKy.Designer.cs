namespace QUANLYKHACHSAN
{
    partial class FormPhieuDangKy
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
            this.DataPhieuDangKy = new QUANLYKHACHSAN.DataPhieuDangKy();
            this.selectPhieuDangKiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.selectPhieuDangKiTableAdapter = new QUANLYKHACHSAN.DataPhieuDangKyTableAdapters.selectPhieuDangKiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataPhieuDangKy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectPhieuDangKiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.selectPhieuDangKiBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QUANLYKHACHSAN.ReportPhieuDangKy.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1055, 630);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataPhieuDangKy
            // 
            this.DataPhieuDangKy.DataSetName = "DataPhieuDangKy";
            this.DataPhieuDangKy.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // selectPhieuDangKiBindingSource
            // 
            this.selectPhieuDangKiBindingSource.DataMember = "selectPhieuDangKi";
            this.selectPhieuDangKiBindingSource.DataSource = this.DataPhieuDangKy;
            // 
            // selectPhieuDangKiTableAdapter
            // 
            this.selectPhieuDangKiTableAdapter.ClearBeforeFill = true;
            // 
            // FormPhieuDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 630);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormPhieuDangKy";
            this.Text = "FormPhieuDangKy";
            this.Load += new System.EventHandler(this.FormPhieuDangKy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataPhieuDangKy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectPhieuDangKiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource selectPhieuDangKiBindingSource;
        private DataPhieuDangKy DataPhieuDangKy;
        private DataPhieuDangKyTableAdapters.selectPhieuDangKiTableAdapter selectPhieuDangKiTableAdapter;
    }
}