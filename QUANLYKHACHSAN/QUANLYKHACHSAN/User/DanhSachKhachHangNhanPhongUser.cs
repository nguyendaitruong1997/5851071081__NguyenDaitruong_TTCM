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

        public void seaching_hd(string s)
        {
            dataGridViewX2.DataSource= dt.seaching_HoaDon(s);

        }
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

        private void txttimKiemHoadoa_TextChanged(object sender, EventArgs e)
        {
            seaching_hd(txttimKiemHoadoa.Text.Trim());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            app.Visible = true;
            // Dua du lieu vao excel
            worksheet.Cells[1, 7] = labelX1.Text;
            worksheet.Cells[3, 4] = "STT";
            worksheet.Cells[3, 5] = "Mã Hóa Đơn";
            worksheet.Cells[3, 6] = "Mã Phiếu Thuê";
            worksheet.Cells[3, 7] = "Mã Khách Hàng";
            worksheet.Cells[3, 8] = "CMND";
            worksheet.Cells[3, 9] = "Ngày Thuê Phòng";
            worksheet.Cells[3, 10] = "Ngày Trả Phòng";
          

            for (int i = 0; i < dataGridViewX2.RowCount-1; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    worksheet.Cells[i + 4, 4] = i + 1;
                    worksheet.Cells[i + 4, j + 5] = dataGridViewX2.Rows[i].Cells[j].Value;
                }
            }
        }
    }
}
