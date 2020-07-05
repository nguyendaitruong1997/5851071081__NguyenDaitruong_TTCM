using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QUANLYKHACHSAN.Database;

namespace QUANLYKHACHSAN.User
{
    public partial class DoiMatKhauUser : UserControl
    {
        public DoiMatKhauUser()
        {
            InitializeComponent();
        }
        DataClasses1DataContext dt = new DataClasses1DataContext();
        public bool check()
        {
            var data = dt.TaiKhoans.Where(s => s.TenDangNhap == textBoxX1.Text.Trim()).Where(s => s.MatKhau == txtMatKhauCu.Text.Trim());
            if(data!=null)
            {
                return true;
            }    
            return false;
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {

        }
    }
}
