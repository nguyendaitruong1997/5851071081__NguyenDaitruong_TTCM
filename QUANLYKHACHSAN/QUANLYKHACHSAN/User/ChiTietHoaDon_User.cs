using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QUANLYKHACHSAN.Database;
using System.Globalization;

namespace QUANLYKHACHSAN.User
{
    public partial class ChiTietHoaDon_User : UserControl
    {
        public ChiTietHoaDon_User()
        {
            InitializeComponent();
        }
        public int i;
        DataClasses1DataContext dt = new DataClasses1DataContext();
        CultureInfo cultureInfo = new CultureInfo("vi-VN");

        private void groupPanel2_Click(object sender, EventArgs e)
        {
            

        }

        private void ChiTietHoaDon_User_Load(object sender, EventArgs e)
        {

          
           // txtSoPhieuNhan.Enabled = false;

            dataGridViewX1.DataSource = dt.selectcthd();
            btnLuu.Enabled = false;
            btnSua.Enabled = true;
            btnThem.Enabled = true;
            
            btnXoa.Enabled = true;

            txtMaHoaDon.Enabled = false;
            //txtTenNhanVien.Enabled = false;
            cmbMaKH.Enabled = false;
            cmbMaPhieuThue.Enabled = false;
            //txtTienPhong.Enabled = false;
          //  cmbMaPhong.Enabled = false;
           // txtTienPhong.Enabled = false;
           // cmbMaPhong.Enabled = false;
            //txtTienDVu.Enabled = false;
            //numGiamGia.Enabled = false;
           //// cmbMaChinhSach.Enabled = false;
           // txtPhuThu.Enabled = false;
           // numSoNgay.Enabled = false;
            //txtHinhThucTT.Enabled = false;
          //  txtThanhTien.Enabled = false;
            txtTongTien.Enabled = false;
           // dateNgaylap.Enabled = false;
            // cmbMaSDDVu.Enabled = false;
            
            cmbMaPhieuThue.ValueMember = "MaPhieuThue";
            cmbMaPhieuThue.DisplayMember = "MaPhieuThue";
            cmbMaPhieuThue.DataSource = dt.PhieuThuePhongs.ToList();
            cmbNhanVien.DataSource = dt.NhanViens.ToList();
            cmbNhanVien.ValueMember = "MaNhanVien";
            cmbNhanVien.DisplayMember = "TenNhanVien";

            cmbMaKH.DataSource = dt.KhachHangs.ToList();
            cmbMaKH.ValueMember = "MaKhachHang";
            cmbMaKH.DisplayMember = "TenKhachHang";

            txtMaHoaDon.Enabled = false;
            txtSoNgay.Enabled = false;
            cmbMaKH.Enabled = false;
            cmbMaPhieuThue.Enabled = false;
            cmbNhanVien.Enabled = false;
            txtTienPhong.Enabled = false;
            dateNgayThuePhong.Enabled = false;
            dateTimePicker1.Enabled = false;
            dtNgayTraPhong.Enabled = false;
            txtTongTien.Enabled = false;
            dateTimePicker1.Value = DateTime.Now;
          //  MessageBox.Show(dateTimePicker1.Value.ToString());
            
        }
        

        private void btnThem_Click(object sender, EventArgs e)
        {
            i = 1;
            txtMaHoaDon.Enabled = true;
            txtSoNgay.Enabled = false;
            cmbMaKH.Enabled = false;
            cmbMaPhieuThue.Enabled = true;
            cmbNhanVien.Enabled = true;
            txtTienPhong.Enabled = false;
            dateNgayThuePhong.Enabled = false;
            dateTimePicker1.Enabled = false;
            dtNgayTraPhong.Enabled = false;
            txtTongTien.Enabled = false;
            dateTimePicker1.Value = DateTime.Now;
            dtNgayTraPhong.Value = DateTime.Now;





            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnThoat.Enabled = true;
            txtMaHoaDon.Enabled = true;
            //txtTenNhanVien.Enabled = true;
          //  cmbMaKH.Enabled = true;
          //  cmbMaPhieuThue.Enabled = true;
          //  txtTienPhong.Enabled = true;
          //  cmbMaPhong.Enabled = true;
          //  txtTienPhong.Enabled = true;
           // cmbMaPhong.Enabled = true;
            //txtTienDVu.Enabled = true;
          ////  numGiamGia.Enabled = true;
           // cmbMaChinhSach.Enabled = true;
          //  txtPhuThu.Enabled = true;
          //  numSoNgay.Enabled = true;
           // txtHinhThucTT.Enabled = true;
          //  txtThanhTien.Enabled = true;
          //  txtTongTien.Enabled = true;
          //  dateNgaylap.Enabled = true;
          //  cmbMaSDDVu.Enabled = true;

            txtMaHoaDon.Text = "";
            //txtTenNhanVien.Text = "";
            txtTongTien.Text = "";
            //  txtTienPhong.Text = "";
            //  txtTienDVu.Text = "";
            //  txtPhuThu.Text = "";
            //  txtHinhThucTT.Text = "";
            //  txtThanhTien.Text = "";
            try
            {
                cmbMaPhieuThue.Text = "";
                 cmbMaPhieuThue.ValueMember = "MaPhieuThue";
                cmbMaPhieuThue.DisplayMember = "MaPhieuThue";

                cmbMaPhieuThue.DataSource = dt.checkPhieuThueChuaThanhToan();
            }
            catch (Exception)
            {

            }
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            ChiTietHoaDon_User_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            i = 2;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThoat.Enabled = true;
            txtMaHoaDon.Enabled = true;
            //txtTenNhanVien.Enabled = true;
            cmbMaKH.Enabled = true;
            cmbMaPhieuThue.Enabled = true;
            txtTienPhong.Enabled = false; ;
            cmbMaKH.Enabled = false;
            //   cmbMaPhong.Enabled = true;
            txtTienPhong.Enabled = false; ;
            //  cmbMaPhong.Enabled = true;
            //txtTienDVu.Enabled = true;
            // numGiamGia.Enabled = true;
            //  cmbMaChinhSach.Enabled = true;
            //  txtPhuThu.Enabled = true;
            //  numSoNgay.Enabled = true;
            //  txtHinhThucTT.Enabled = true;
            //  txtThanhTien.Enabled = true;
            txtTongTien.Enabled = false;
            txtMaHoaDon.Enabled = false;
            cmbNhanVien.Enabled = true;
            
            
          //  dateNgaylap.Enabled = true;
          //  cmbMaSDDVu.Enabled = true;


        }

        String s;
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(i==1)
            {
                if (txtMaHoaDon.Text == "" || cmbNhanVien.SelectedValue.ToString() == "" || cmbMaPhieuThue.SelectedValue.ToString() == "")
                {
                    MessageBox.Show("Bạn hãy nhập đầy đủ thông tin!");

                }
                else
                {
                    HoaDon hoaDon = dt.HoaDons.Where(s => s.MaHoaDon == Convert.ToInt32(txtMaHoaDon.Text)).FirstOrDefault();
                    if(hoaDon!=null)
                    {
                        MessageBox.Show("Hóa Đơn Đã Tồn Tại Vui Lòng Nhập Mã Hóa Đơn Khác !", "Thông Báo!", MessageBoxButtons.OK);
                    }
                    else
                    {
                        dt.themhd(Convert.ToInt32(txtMaHoaDon.Text), cmbNhanVien.SelectedValue.ToString(), cmbMaKH.SelectedValue.ToString(),
                   cmbMaPhieuThue.SelectedValue.ToString(), Convert.ToInt32(txtSoNgay.Text), Convert.ToInt32(tt), Convert.ToDateTime(dtNgayTraPhong.Text));
                        MessageBox.Show("Bạn đã thêm thành công");
                        s = cmbMaPhieuThue.SelectedValue.ToString();

                    }
                  



                    CT_PhieuThue MaLoaiPhhong = dt.CT_PhieuThues.Where(p => p.MaPhieuThue == cmbMaPhieuThue.SelectedValue.ToString()).FirstOrDefault();

                    dt.update_TinhTrangPhongCuaPhong(MaLoaiPhhong.MaPhong.ToString(), "TT3", null);

                }
                
 

            }
            else if (i == 2)
            {
                if (txtMaHoaDon.Text == "" || cmbNhanVien.SelectedValue.ToString() == "" || cmbMaPhieuThue.SelectedValue.ToString() == "")
                {
                    MessageBox.Show("Bạn hãy nhập đầy đủ thông tin!");

                }
                else
                {
                    dt.suahd(Convert.ToInt32(txtMaHoaDon.Text), cmbNhanVien.SelectedValue.ToString(), cmbMaKH.SelectedValue.ToString(),
                     cmbMaPhieuThue.SelectedValue.ToString(), Convert.ToInt32(txtSoNgay.Text), Convert.ToInt32(tt), Convert.ToDateTime(dtNgayTraPhong.Text));
                    MessageBox.Show("Bạn đã sửa thành công");
                    s = cmbMaPhieuThue.SelectedValue.ToString();



                    CT_PhieuThue MaLoaiPhhong = dt.CT_PhieuThues.Where(p => p.MaPhieuThue == cmbMaPhieuThue.SelectedValue.ToString()).FirstOrDefault();

                    dt.update_TinhTrangPhongCuaPhong(MaLoaiPhhong.MaPhong.ToString(), "TT3", null);

                }

            }    




                dataGridViewX1.DataSource = dt.selectcthd();
            ChiTietHoaDon_User_Load(sender, e);


            
           

        }
        double tt;

        private void cmbMaPhieuThue_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mapt = cmbMaPhieuThue.Text.ToString();
            PhieuThuePhong ptp = dt.PhieuThuePhongs.FirstOrDefault(p => p.MaPhieuThue == mapt);
            if (ptp != null)
            {
                cmbMaKH.SelectedValue = ptp.MaKhachHang;
            }
            CT_PhieuThue cT_PhieuThue = dt.CT_PhieuThues.FirstOrDefault(p => p.MaPhieuThue == mapt);

            

            if (cT_PhieuThue != null)
            {
                txtTienPhong.Text = cT_PhieuThue.DonGia.ToString();
                dateNgayThuePhong.Value =Convert.ToDateTime( cT_PhieuThue.NgayNhanPhong.Value.ToString());
           
                ////   MessageBox.Show(date.ToString());
                //MessageBox.Show(date.ToString());

                DateTime date1 = new DateTime(dateNgayThuePhong.Value.Year, dateNgayThuePhong.Value.Month,
                    dateNgayThuePhong.Value.Day, dateNgayThuePhong.Value.Hour, dateNgayThuePhong.Value.Minute, dateNgayThuePhong.Value.Second);

                DateTime date2 = new DateTime(dtNgayTraPhong.Value.Year, dtNgayTraPhong.Value.Month,
                    dtNgayTraPhong.Value.Day, dtNgayTraPhong.Value.Hour, dtNgayTraPhong.Value.Minute, dtNgayTraPhong.Value.Second);
                
                TimeSpan diff1 = date2.Subtract(date1);



                if ( diff1.Days<1)
                {
                    txtSoNgay.Text = "1";
                    

                }
                else if (diff1.Hours>=1 && diff1.Days>=1)
                {
                    txtSoNgay.Text = Convert.ToString( diff1.Days +1);
                }

                else if (diff1.Hours <1 && diff1.Days >= 1)
                {
                    txtSoNgay.Text = diff1.Days.ToString();
                }
                if(txtSoNgay.Text!=null && txtTienPhong.Text != null)
                {
                    tt = Convert.ToInt32(txtSoNgay.Text) * Convert.ToDouble(txtTienPhong.Text);

                    txtTongTien.Text = tt.ToString();
        
                }              
                // 
            }
           // MessageBox.Show(date.ToString());
        }
     //   public bool check()
        

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void txtSoNgay_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            var a = dt.PhieuThuePhongs.Where(s=>s.MaPhieuThue == textBox1.Text).FirstOrDefault();
            if (a== null)
            {
                cmbMaPhieuThue.Text = "";
            }    
            else
            cmbMaPhieuThue.SelectedValue = a.MaPhieuThue;
        }
        public static string mahd;
        private void toolStripTrangIn_Click(object sender, EventArgs e)
        {
            //Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            //Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            //Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            //worksheet = workbook.Sheets["Sheet1"];
            //worksheet = workbook.ActiveSheet;
            //app.Visible = true;
            //// Dua du lieu vao excel
            //worksheet.Cells[1, 4] = "Bảng Thống Kê Hóa Đơn";
            //worksheet.Cells[2, 3] = "";
            //worksheet.Cells[3, 1] = "STT";
            //worksheet.Cells[3, 2] = "Mã Hóa Đơn";
            //worksheet.Cells[3, 3] = "Mã Nhân Viên";
            //worksheet.Cells[3, 4] = "Khách Hàng";
            //worksheet.Cells[3, 5] = "Mã Phiếu Thuê";
            //worksheet.Cells[3, 6] = "Tiền Phòng";
            //worksheet.Cells[3, 7] = "Số Ngày Thuê";
            //worksheet.Cells[3, 8] = "Tổng Tiền";
            //worksheet.Cells[3, 9] = "Ngày Lập Hóa Đơn";

            //for (int i = 0; i < dataGridViewX1.RowCount; i++)
            //{
            //    for (int j = 0; j < 8; j++)
            //    {
            //        worksheet.Cells[i + 4, 1] = i + 1;
            //        worksheet.Cells[i + 4, j + 2] = dataGridViewX1.Rows[i].Cells[j].Value;
            //    }
            //}
            //int dem = dataGridViewX1.RowCount;



            //// Định dạng trang
            //worksheet.PageSetup.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlPortrait;
            //worksheet.PageSetup.PaperSize = Microsoft.Office.Interop.Excel.XlPaperSize.xlPaperA4;
            //worksheet.PageSetup.LeftMargin = 0;
            //worksheet.PageSetup.RightMargin = 0;
            //worksheet.PageSetup.TopMargin = 0;
            //worksheet.PageSetup.BottomMargin = 0;

            //// Đinh dạng cột
            //worksheet.Range["A1"].ColumnWidth = 20;
            //worksheet.Range["B1"].ColumnWidth = 45;
            //worksheet.Range["C1"].ColumnWidth = 49;
            //worksheet.Range["D1"].ColumnWidth = 33;
            //worksheet.Range["E1"].ColumnWidth = 31;
            //worksheet.Range["F1"].ColumnWidth = 52;
            //worksheet.Range["G1"].ColumnWidth = 23;
            //worksheet.Range["H1"].ColumnWidth = 22;
            //worksheet.Range["I1"].ColumnWidth = 45;

            //// Định dạng font chữ
            //worksheet.Range["A1", "J100"].Font.Name = "Times New Roman";
            //worksheet.Range["A1", "A100"].Font.Size = 24;
            //worksheet.Range["A3", "J100"].Font.Size = 16;
            //worksheet.Range["A1", "J1"].MergeCells = true;
            //worksheet.Range["A1", "J1"].Font.Bold = true;

            ////worksheet.Range["A3", "J3"].MergeCells = true;
            //worksheet.Range["A3", "J3"].Font.Bold = true;

            //// kẻ bảng
            //worksheet.Range["A3", "J" + (dem + 3)].Borders.LineStyle = 1;


            ////Định dạng dòng text
            //worksheet.Range["A1", "J1"].HorizontalAlignment = 3;
            //worksheet.Range["A3", "J3"].HorizontalAlignment = 3;
            //worksheet.Range["A4", "J" + (dem + 4)].HorizontalAlignment = 3;
            //worksheet.Range["B4", "J" + (dem + 4)].HorizontalAlignment = 3;
            //worksheet.Range["C4", "J" + (dem + 4)].HorizontalAlignment = 3;
            //worksheet.Range["D4", "J" + (dem + 4)].HorizontalAlignment = 3;
            //worksheet.Range["E4", "J" + (dem + 4)].HorizontalAlignment = 3;
            //worksheet.Range["F4", "J" + (dem + 4)].HorizontalAlignment = 3;
            //worksheet.Range["G4", "J" + (dem + 4)].HorizontalAlignment = 3;
            //worksheet.Range["H4", "J" + (dem + 4)].HorizontalAlignment = 3;
            //worksheet.Range["I4", "J" + (dem + 4)].HorizontalAlignment = 3;
            reportHoaDon f = new reportHoaDon();
            f.ShowDialog();
        }

        private void dataGridViewX1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridViewX1.CurrentRow.Index;
            if(i>=0 && i< dataGridViewX1.RowCount-1)
            {

                mahd = dataGridViewX1.Rows[i].Cells[0].Value.ToString();

                txtMaHoaDon.Text = dataGridViewX1.Rows[i].Cells[0].Value.ToString();
                cmbNhanVien.Text = dataGridViewX1.Rows[i].Cells[1].Value.ToString();
                cmbMaKH.Text = dataGridViewX1.Rows[i].Cells[2].Value.ToString();
                cmbMaPhieuThue.Text = dataGridViewX1.Rows[i].Cells[3].Value.ToString();
                string maphieu = dataGridViewX1.Rows[i].Cells[3].Value.ToString();
                // dateTimePicker1.Value =Convert.ToDateTime( dataGridViewX1.Rows[i].Cells[0].Value.ToString());
                txtTienPhong.Text = dataGridViewX1.Rows[i].Cells[4].Value.ToString();
                txtSoNgay.Text = dataGridViewX1.Rows[i].Cells[5].Value.ToString();
                txtTongTien.Text = dataGridViewX1.Rows[i].Cells[6].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(dataGridViewX1.Rows[i].Cells[7].Value.ToString());
                dtNgayTraPhong.Value = Convert.ToDateTime(dateTimePicker1.Value.ToString());
                CT_PhieuThue phieu = dt.CT_PhieuThues.FirstOrDefault(p => p.MaPhieuThue == maphieu);
                dateNgayThuePhong.Value = Convert.ToDateTime(phieu.NgayNhanPhong.Value.ToString());
            }    

           // MessageBox.Show(i.ToString());
            // cmbNhanVien.SelectedValue = dataGridViewX1.Rows[i].Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txttimKiemHoadoa.Text=="")
            {
                dataGridViewX1.DataSource = dt.selectcthd();

            }  
            else
            {
                dataGridViewX1.DataSource = dt.selectcthd().Where(s => s.MaHoaDon == Convert.ToInt32(txttimKiemHoadoa.Text)).ToList();

            }    
           // dataGridViewX1.DataSource = dt.selectcthd().Where(s => s.MaHoaDon == Convert.ToInt32(txttimKiemHoadoa.Text)).ToList();
        }

        private void txttimKiemHoadoa_Click(object sender, EventArgs e)
        {
            txttimKiemHoadoa.Text = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaHoaDon.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn hóa đơn xóa !!", "Thông Báo", MessageBoxButtons.OK);



            }
            else
            {
                DialogResult xoa = MessageBox.Show("bạn có chắc muốn xóa không?", "", MessageBoxButtons.YesNo);
                if (xoa == DialogResult.Yes)
                {
                    var data = dt.deleteHoaDon(Convert.ToInt32(txtMaHoaDon.Text));

                    CT_PhieuThue MaLoaiPhhong = dt.CT_PhieuThues.Where(p => p.MaPhieuThue == cmbMaPhieuThue.SelectedValue.ToString()).FirstOrDefault();

                    dt.update_TinhTrangPhongCuaPhong(MaLoaiPhhong.MaPhong.ToString(), "TT2", null);
                    ChiTietHoaDon_User_Load(sender, e);

                }

            }

        }
    }
}
