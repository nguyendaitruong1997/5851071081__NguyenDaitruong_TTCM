namespace QUANLYKHACHSAN.User
{
    partial class BaoCaoDoanhThuUser
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtThang = new System.Windows.Forms.NumericUpDown();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dataDoanhThu = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.MaLoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoanhThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tyle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtThang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDoanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.labelX2);
            this.panel1.Controls.Add(this.txtThang);
            this.panel1.Controls.Add(this.labelX1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1360, 329);
            this.panel1.TabIndex = 7;
            // 
            // labelX2
            // 
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.ForeColor = System.Drawing.Color.Blue;
            this.labelX2.Location = new System.Drawing.Point(546, 113);
            this.labelX2.Margin = new System.Windows.Forms.Padding(4);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(103, 38);
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = "Tháng";
            // 
            // txtThang
            // 
            this.txtThang.Location = new System.Drawing.Point(654, 122);
            this.txtThang.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.txtThang.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(124, 22);
            this.txtThang.TabIndex = 2;
            this.txtThang.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.txtThang.ValueChanged += new System.EventHandler(this.txtThang_ValueChanged);
            // 
            // labelX1
            // 
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.Blue;
            this.labelX1.Location = new System.Drawing.Point(564, 4);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(279, 28);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "BÁO CÁO DOANH THU";
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(0, 329);
            this.dataGridViewX1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.RowHeadersWidth = 51;
            this.dataGridViewX1.Size = new System.Drawing.Size(1360, 471);
            this.dataGridViewX1.TabIndex = 10;
            // 
            // dataDoanhThu
            // 
            this.dataDoanhThu.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDoanhThu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLoaiPhong,
            this.DoanhThu,
            this.tyle});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataDoanhThu.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataDoanhThu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataDoanhThu.Location = new System.Drawing.Point(0, 329);
            this.dataDoanhThu.Margin = new System.Windows.Forms.Padding(4);
            this.dataDoanhThu.Name = "dataDoanhThu";
            this.dataDoanhThu.RowHeadersWidth = 51;
            this.dataDoanhThu.Size = new System.Drawing.Size(1360, 471);
            this.dataDoanhThu.TabIndex = 12;
            // 
            // MaLoaiPhong
            // 
            this.MaLoaiPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaLoaiPhong.DataPropertyName = "MaLoaiPhong";
            this.MaLoaiPhong.HeaderText = "Loại phòng";
            this.MaLoaiPhong.MinimumWidth = 6;
            this.MaLoaiPhong.Name = "MaLoaiPhong";
            // 
            // DoanhThu
            // 
            this.DoanhThu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DoanhThu.DataPropertyName = "DoanhThu";
            this.DoanhThu.HeaderText = "Doanh Thu";
            this.DoanhThu.MinimumWidth = 6;
            this.DoanhThu.Name = "DoanhThu";
            // 
            // tyle
            // 
            this.tyle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tyle.DataPropertyName = "tyle";
            this.tyle.HeaderText = "Tỷ lệ";
            this.tyle.MinimumWidth = 6;
            this.tyle.Name = "tyle";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(535, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(267, 49);
            this.button1.TabIndex = 4;
            this.button1.Text = "XUẤT BÁO CÁO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BaoCaoDoanhThuUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataDoanhThu);
            this.Controls.Add(this.dataGridViewX1);
            this.Controls.Add(this.panel1);
            this.Name = "BaoCaoDoanhThuUser";
            this.Size = new System.Drawing.Size(1360, 800);
            this.Load += new System.EventHandler(this.BaoCaoDoanhThuUser_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtThang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDoanhThu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        public System.Windows.Forms.NumericUpDown txtThang;
        public System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataDoanhThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoanhThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn tyle;
        private DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.Button button1;
    }
}
