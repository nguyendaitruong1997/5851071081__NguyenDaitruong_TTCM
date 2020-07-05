using QUANLYKHACHSAN.User;
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
    public partial class FormPhieuDangKy : Form
    {
        public FormPhieuDangKy()
        {
            InitializeComponent();
        }

        private void FormPhieuDangKy_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataPhieuDangKy.selectPhieuDangKi' table. You can move, or remove it, as needed.
            this.selectPhieuDangKiTableAdapter.Fill(this.DataPhieuDangKy.selectPhieuDangKi, PhieuDangKi_User.machitiet);

            this.reportViewer1.RefreshReport();
        }
    }
}
