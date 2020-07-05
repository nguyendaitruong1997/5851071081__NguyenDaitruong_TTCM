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
    public partial class BaoCaoDoanhThuUser : UserControl
    {
        public BaoCaoDoanhThuUser()
        {
            InitializeComponent();
        }
        DataClasses1DataContext dt = new DataClasses1DataContext();

        private void BaoCaoDoanhThuUser_Load(object sender, EventArgs e)
        {
            dataDoanhThu.DataSource = dt.selectDoanhThu(Convert.ToInt32(txtThang.Value));
        }

        private void txtThang_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                dataDoanhThu.DataSource = dt.selectDoanhThu(Convert.ToInt32(txtThang.Value));
                Double doanhthu = 0;

                for (int i = 0; i < dataDoanhThu.RowCount - 1; i++)
                {


                    doanhthu += Convert.ToDouble(dataDoanhThu.Rows[i].Cells["DoanhThu"].Value);


                    

                }

                for (int i = 0; i < dataDoanhThu.RowCount - 1; i++)
                {


                    Double doanhthuTungLoaiPhong= Convert.ToDouble(dataDoanhThu.Rows[i].Cells["DoanhThu"].Value.ToString()) / doanhthu *100;

                    dataDoanhThu.Rows[i].Cells["tyle"].Value=String.Format("{0:f} %", doanhthuTungLoaiPhong);
                }
                




            }
            catch (Exception)
            {

            }
            
        }

        private void toolStripTrangIn_Click(object sender, EventArgs e)
        {
             
          
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
            worksheet.Cells[1, 4] = "Báo Cáo Doanh Thu Theo Loại Phòng";
            worksheet.Cells[2, 4] = "Tháng:" + txtThang.Value.ToString();
            worksheet.Cells[3, 4] = "STT";
            worksheet.Cells[3, 5] = "Tỉ Lệ";
            worksheet.Cells[3, 6] = "Loại Phòng";
            worksheet.Cells[3, 7] = "Doanh Thu";

            for (int i = 0; i < dataDoanhThu.RowCount - 1; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    worksheet.Cells[i + 4, 4] = i + 1;
                    worksheet.Cells[i + 4, j + 5] = dataDoanhThu.Rows[i].Cells[j].Value;
                }
            }

        }
    }
}
