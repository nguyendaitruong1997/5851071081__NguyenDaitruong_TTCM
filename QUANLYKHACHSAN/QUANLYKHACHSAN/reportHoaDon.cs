using QUANLYKHACHSAN.User;
using QUANLYKHACHSAN.UserInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QUANLYKHACHSAN
{
    public partial class reportHoaDon : Form
    {
        public reportHoaDon()
        {
            InitializeComponent();
        }

        private void reportHoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetReport.reportHoaDonChuan' table. You can move, or remove it, as needed.
            this.reportHoaDonChuanTableAdapter.Fill(this.DataSetReport.reportHoaDonChuan, Convert.ToInt32(ChiTietHoaDon_User.mahd));

            this.reportViewer1.RefreshReport();
        }
    }
}
