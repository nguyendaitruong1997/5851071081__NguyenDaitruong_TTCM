using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QUANLYKHACHSAN.Database;
using System.Security.Cryptography;

namespace QUANLYKHACHSAN.User
{
    public partial class DanhSachNguoiDungUser : UserControl
    {
        public DanhSachNguoiDungUser()
        {
            InitializeComponent();
        }
        DataClasses1DataContext dt = new DataClasses1DataContext();
        public int i = 0;
        public string MaHoa(string txt)
        {
            MD5 mh = MD5.Create();
            //Chuyển kiểu chuổi thành kiểu byte
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(txt);
            //mã hóa chuỗi đã chuyển
            byte[] hash = mh.ComputeHash(inputBytes);
            //tạo đối tượng StringBuilder (làm việc với kiểu dữ liệu lớn)
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            txt = sb.ToString();
            return txt;
        }
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            clickthem();
            txtTenDangnhap.Text = "";
            txtMatKhau.Text = "";
            txtEmail.Enabled = true;
           // txtEmail.Text = "";
            i = 1;
            txtEmail.Text = "";
            btnSua.Enabled = false;
        }
        public void clickhuy()
        {

        }
      
        public void clickthem()
        {
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            txtTenDangnhap.Enabled = true;
            cbLoaiNguoiDung.Enabled = true;
            txtMatKhau.Enabled = true;
          
          

        }
        public bool check()
        {
            var data = dt.TaiKhoans.Where(s => s.TenDangNhap == txtTenDangnhap.Text.Trim()).FirstOrDefault();
            if(data==null)
            {
                return true;
            }    
            return false;
        }
        private void toolStripLuu_Click(object sender, EventArgs e)
            
        {
            if(i==1)
            {
                if (txtTenDangnhap.Text == "" || MaHoa(txtMatKhau.Text) == "" || (cbLoaiNguoiDung.Text) == "" || txtEmail.Text == "")
                {
                    MessageBox.Show("Bạn hãy nhập đầy đủ thông tin!", "Thông báo!", MessageBoxButtons.YesNo);

                }
                else
                {
                    if (check() == true)
                    {
                        DialogResult xoa = MessageBox.Show("bạn có muốn thêm không?", "Thông báo!", MessageBoxButtons.YesNo);
                        if (xoa == DialogResult.Yes)
                        {
                            var data = dt.insertt(txtTenDangnhap.Text, MaHoa(txtMatKhau.Text), Convert.ToInt32(cbLoaiNguoiDung.Text),txtEmail.Text);
                            MessageBox.Show("Thêm người dùng thành công!", "Thông báo!", MessageBoxButtons.OK);

                        }

                    }
                    else
                    {
                        MessageBox.Show("Người dùng đã tôn tại!", "Thông Báo!", MessageBoxButtons.OK);
                    }


                }


            } 
            else if(i==2)
            {
                if (txtTenDangnhap.Text == "" || MaHoa(txtMatKhau.Text) == "" || (cbLoaiNguoiDung.Text) == "" || txtEmail.Text == "")
                {
                    MessageBox.Show("Bạn hãy nhập đầy đủ thông tin!", "Thông báo!", MessageBoxButtons.YesNo);

                }
                else
                {
                   
                    {
                        DialogResult xoa = MessageBox.Show("bạn có muốn sửa không?", "Thông báo!", MessageBoxButtons.YesNo);
                        if (xoa == DialogResult.Yes)
                        {
                            var data = dt.update_Nguoidung(txtTenDangnhap.Text, MaHoa(txtMatKhau.Text), Convert.ToInt32(cbLoaiNguoiDung.Text), txtEmail.Text);
                            MessageBox.Show("Sửa người dùng thành công!", "Thông báo!", MessageBoxButtons.OK);

                        }

                    }
                   


                }

            }    
            

           
            DanhSachNguoiDungUser_Load( sender,  e);




        }

        private void dataGridViewX1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i =dtNguoiDung.CurrentRow.Index;
            txtTenDangnhap.Text = dtNguoiDung.Rows[i].Cells[0].Value.ToString();
            txtMatKhau.Text = dtNguoiDung.Rows[i].Cells[1].Value.ToString();
            cbLoaiNguoiDung.Text= dtNguoiDung.Rows[i].Cells[2].Value.ToString();
           
        }
        public void load()
        {
            cbLoaiNguoiDung.Items.Add("1");
            cbLoaiNguoiDung.Items.Add("2");
            dtNguoiDung.DataSource = new DataClasses1DataContext().TaiKhoans.ToList();
        }

        private void DanhSachNguoiDungUser_Load(object sender, EventArgs e)
        {
            cbLoaiNguoiDung.Items.Add("1");
            cbLoaiNguoiDung.Items.Add("2");

            dtNguoiDung.AutoGenerateColumns = false;
            dtNguoiDung.DataSource = dt.TaiKhoans.ToList();
            btnLuu.Enabled = false;
            txtTenDangnhap.Enabled = false;
            txtMatKhau.Enabled = false;
            cbLoaiNguoiDung.Enabled = false;
            txtEmail.Enabled = false;

            txtTenDangnhap.Text = dtNguoiDung.Rows[0].Cells[0].Value.ToString();
            txtMatKhau.Text = dtNguoiDung.Rows[0].Cells[1].Value.ToString();
            cbLoaiNguoiDung.Text = dtNguoiDung.Rows[0].Cells[2].Value.ToString();
            txtEmail.Text = dtNguoiDung.Rows[0].Cells[3].Value.ToString();
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;


        }
      
       

        private void dtNguoiDung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtNguoiDung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dtNguoiDung.CurrentRow.Index;
            txtTenDangnhap.Text = dtNguoiDung.Rows[i].Cells[0].Value.ToString();
            txtMatKhau.Text = dtNguoiDung.Rows[i].Cells[1].Value.ToString();
            cbLoaiNguoiDung.Text = dtNguoiDung.Rows[i].Cells[2].Value.ToString();
            txtEmail.Text = dtNguoiDung.Rows[i].Cells[3].Value.ToString();
            //btnSua.Enabled = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            DialogResult xoa = MessageBox.Show("bạn có muốn xóa không?", "", MessageBoxButtons.YesNo);
            if (xoa == DialogResult.Yes)
            {
                dt.delleteTaiKhoan(txtTenDangnhap.Text);
                dtNguoiDung.DataSource = new DataClasses1DataContext().TaiKhoans.ToList();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DanhSachNguoiDungUser_Load(sender,  e);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            i = 2;
            txtTenDangnhap.Enabled = false;
            txtEmail.Enabled = true;
            txtMatKhau.Enabled = true;
            cbLoaiNguoiDung.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            
        }
    }
}
