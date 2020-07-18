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
    public partial class NhanVienUser : UserControl
    {
        public NhanVienUser()
        {
            InitializeComponent();
        }
        public int i = 0;
        DataClasses1DataContext dt = new DataClasses1DataContext();

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (i == 1)
            {
                if(txtMaNhanVien.Text==""|| txtTenNhanVien.Text==""|| cbbGioiTinh.Text==""||
                        txtQueQuan.Text=="" ||txtNgaySinh.Text=="")
                {
                    MessageBox.Show("Bạn Hãy Nhập Đẩy Đủ Thông Tin!", "Thông Báo", MessageBoxButtons.OK);
                }
                else
                {
                    var nv = dt.NhanViens.Where(s => s.MaNhanVien == txtMaNhanVien.Text.Trim()).FirstOrDefault();
                    if (nv == null)
                    {
                        DialogResult xoa = MessageBox.Show("bạn có muốn Thêm không?", "", MessageBoxButtons.YesNo);
                        if (xoa == DialogResult.Yes)
                        {
                            var data = dt.themnhanvien(txtMaNhanVien.Text, txtTenNhanVien.Text, cbbGioiTinh.Text, txtQueQuan.Text, txtNgaySinh.Text);
                            MessageBox.Show("Thêm Thành Công ?", "Thông Báo", MessageBoxButtons.OK);

                        }

                    }
                    else
                    {
                        MessageBox.Show("Nhân Viên Đã Tồn Tại !", "Thông Báo", MessageBoxButtons.OK);
                    }

                }
              
              
                              
            }else if(i==2)
            {
                if (txtMaNhanVien.Text == "" || txtTenNhanVien.Text == "" || cbbGioiTinh.Text == "" ||
                        txtQueQuan.Text == "" || txtNgaySinh.Text == "")
                {
                    MessageBox.Show("Bạn Hãy Nhập Đẩy Đủ Thông Tin!", "Thông Báo", MessageBoxButtons.OK);
                }
                else
                {
                    DialogResult xoa = MessageBox.Show("bạn có muốn sửa không?", "", MessageBoxButtons.YesNo);
                    if (xoa == DialogResult.Yes)
                    {
                        var data = dt.suanhanvien(txtMaNhanVien.Text, txtTenNhanVien.Text, cbbGioiTinh.Text, txtQueQuan.Text, txtNgaySinh.Text);
                        MessageBox.Show("Sửa Thành Công ?", "Thông Báo", MessageBoxButtons.OK);

                    }

                }
              
              
                

            }
            NhanVienUser_Load(sender, e);
            btnLuu.Enabled =false;



        }
        public void timkim(string s)
        {
            dtgNhanVien.DataSource = dt.seaching_nv(s);
        }
        public void notenable()
        {

            txtMaNhanVien.Enabled = true;
            txtNgaySinh.Enabled = true;
            txtQueQuan.Enabled = true;
            txtTenNhanVien.Enabled = true;
            cbbGioiTinh.Enabled = true;

        }
        public void ennable()
        {
            txtMaNhanVien.Enabled = false;
            txtNgaySinh.Enabled = false;
            txtQueQuan.Enabled = false;
            txtTenNhanVien.Enabled = false;
            cbbGioiTinh.Enabled = false;
            
        }
        private void NhanVienUser_Load(object sender, EventArgs e)
        {
      

            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnXoa.Enabled = true;
            btnCapNhat.Enabled = true;
            txtMaNhanVien.Enabled = false;
            ennable();
            
            cbbGioiTinh.Items.Add("Nam");
            cbbGioiTinh.Items.Add("Nữ");
            dtgNhanVien.DataSource = new DataClasses1DataContext().NhanViens.ToList();

            txtMaNhanVien.Text = dtgNhanVien.Rows[0].Cells[0].Value.ToString();
            txtTenNhanVien.Text = dtgNhanVien.Rows[0].Cells[1].Value.ToString();
            cbbGioiTinh.Text = dtgNhanVien.Rows[0].Cells[2].Value.ToString();
            txtQueQuan.Text = dtgNhanVien.Rows[0].Cells[3].Value.ToString();
            txtNgaySinh.Text = dtgNhanVien.Rows[0].Cells[4].Value.ToString();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

           if(txtMaNhanVien.Text!=null)
            {
                PhieuThuePhong phieuThuePhong = dt.PhieuThuePhongs.Where(s => s.MaNhanVien == txtMaNhanVien.Text).FirstOrDefault();
                if(phieuThuePhong==null)
                {
                    DialogResult xoa = MessageBox.Show("bạn có muốn xóa không?", "", MessageBoxButtons.YesNo);
                    if (xoa == DialogResult.Yes)
                    {
                        var data = dt.xoanhanvienn(txtMaNhanVien.Text);

                    }

                }
                else
                {
                    MessageBox.Show("Không Thể Xóa !");
                }
              

            } 
           else
            {
                MessageBox.Show("Bạn Chưa Chọn Nhân Viên Xóa");
            }    
          
           
            dtgNhanVien.DataSource = new DataClasses1DataContext().NhanViens.ToList();
        }

        private void dtgNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dtgNhanVien.CurrentRow.Index;
            txtMaNhanVien.Text = dtgNhanVien.Rows[i].Cells[0].Value.ToString();
            txtTenNhanVien.Text = dtgNhanVien.Rows[i].Cells[1].Value.ToString();
            cbbGioiTinh.Text = dtgNhanVien.Rows[i].Cells[2].Value.ToString();
            txtQueQuan.Text = dtgNhanVien.Rows[i].Cells[3].Value.ToString();
            txtNgaySinh.Text = dtgNhanVien.Rows[i].Cells[4].Value.ToString();
            
        }

        private void toolStripCapNhat_Click(object sender, EventArgs e)
        {
            clickcapnhat();
        }
        public void clickcapnhat()
        {
            btnCapNhat.Enabled = false;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            i = 2;
            txtMaNhanVien.Enabled = false;
            btnXoa.Enabled = false;

            txtNgaySinh.Enabled = true;
            txtQueQuan.Enabled = true;
            txtTenNhanVien.Enabled = true;
            cbbGioiTinh.Enabled = true;

        }
        public void clickthem()
        {
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnCapNhat.Enabled = false;
            txtMaNhanVien.Enabled = true;
            notenable();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            clickthem();
          
            reset();
            i = 1;
        }
        public void reset()
        {
            txtMaNhanVien.Text = "";
            txtNgaySinh.Text = "";
            txtQueQuan.Text = "";
            txtTenNhanVien.Text = "";
          
        }

        private void dtgNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButtonThoat_Click(object sender, EventArgs e)
        {
            NhanVienUser_Load(sender, e);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtTimKiem.Text=="")
            {
                dtgNhanVien.DataSource = new DataClasses1DataContext().NhanViens.ToList();


            }    
            else
            {
                dtgNhanVien.DataSource = dt.NhanViens.Where(s => s.MaNhanVien == txtTimKiem.Text).ToList();

            }    
           
        }

        private void txtTimKiem_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            timkim(txtTimKiem.Text.Trim());
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            app.Visible = true;
            // Dua du lieu vao excel
            worksheet.Cells[1, 7] = "Báo Cáo Doanh Thu Theo Loại Phòng";
            worksheet.Cells[3, 4] = "STT";
            worksheet.Cells[3, 5] = "Mã Nhân Viên";
            worksheet.Cells[3, 6] = "Tên Nhân Viên";
            worksheet.Cells[3, 7] = "Giới Tính";
            worksheet.Cells[3, 8] = "Quê Quán ";
            worksheet.Cells[3, 9] = "Ngày Sinh";

            for (int i = 0; i < dtgNhanVien.RowCount ; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    worksheet.Cells[i + 4, 4] = i + 1;
                    worksheet.Cells[i + 4, j + 5] = dtgNhanVien.Rows[i].Cells[j].Value;
                }
            }
        }
    }
}
