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
    public partial class DanhSachKhachHangNhanPhongUser : UserControl
    {
        public DanhSachKhachHangNhanPhongUser()
        {
            InitializeComponent();
        }
        DataClasses1DataContext dt = new DataClasses1DataContext();


        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
           // btnThem.Enabled = false;
            //btnSua.Enabled = false;
           //// btnXoa.Enabled = false;
           // btnHuy.Enabled = true;
           // btnLuu.Enabled = true;
        }

        private void DanhSachKhachHangNhanPhongUser_Load(object sender, EventArgs e)
        {
            dataGridViewX2.AutoGenerateColumns = false;
            dataGridViewX2.DataSource = dt.lichsukhach();
           

          
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DanhSachKhachHangNhanPhongUser_Load( sender,  e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DanhSachKhachHangNhanPhongUser_Load(sender, e);
        }
    }
}
