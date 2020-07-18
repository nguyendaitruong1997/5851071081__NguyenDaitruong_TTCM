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
    public partial class DanhSachKhachHangDangKiThuePhong_User : UserControl
    {
        public DanhSachKhachHangDangKiThuePhong_User()
        {
            InitializeComponent();
        }
        DataClasses1DataContext dt = new DataClasses1DataContext();

      

        private void DanhSachKhachHangDangKiThuePhong_User_Load(object sender, EventArgs e)
        {

           
          //  btnThem.Enabled = true;
           
            dataGridViewX1.AutoGenerateColumns = false;
            dataGridViewX1.DataSource = dt.PhieuThuePhongs.ToList();

        }
        public void seaching_PhieuThue(string s)
        {
            dataGridViewX1.DataSource = dt.seaching_PhieuThuePhong(s);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
          
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DanhSachKhachHangDangKiThuePhong_User_Load(sender, e);

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DanhSachKhachHangDangKiThuePhong_User_Load(sender, e);
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
            worksheet.Cells[1, 4] = "Danh Sách Khách Hàng Đăng Kí Thuê Phòng";
            worksheet.Cells[2, 4] = "Tháng:...............................";
            worksheet.Cells[3, 4] = "STT";
            worksheet.Cells[3, 5] = "Mã Phiếu Thuê";
            worksheet.Cells[3, 6] = "Mã Nhân Viên";
            worksheet.Cells[3, 7] = "Doanh Thu";

            for (int i = 0; i < dataGridViewX1.RowCount - 1; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    worksheet.Cells[i + 4, 4] = i + 1;
                    worksheet.Cells[i + 4, j + 5] = dataGridViewX1.Rows[i].Cells[j].Value;
                }
            }
        }

        private void txttimKiemHoadoa_TextChanged(object sender, EventArgs e)
        {
            seaching_PhieuThue(txttimKiemHoadoa.Text.Trim());
        }
    }
}
