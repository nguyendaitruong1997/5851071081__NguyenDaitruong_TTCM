using QUANLYKHACHSAN.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace QUANLYKHACHSAN
{
    public partial class FormDangNhap : Form
    {
        
        public  int i = 0;
        public FormDangNhap()
        {
            InitializeComponent();
        }
        DataClasses1DataContext dt = new DataClasses1DataContext();
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

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(kiemtra()==true)

            {
                this.Hide();

            }   
           
           
           
           /* if(txtTenDangNhap.Text.Trim()=="admin"&& txtMatKhau.Text.Trim()=="123")
            {
                i = 1;
                this.Close();
            }  
            else if(txtTenDangNhap.Text.Trim() == "user" && txtMatKhau.Text.Trim() == "123")
            {
                i = 2;
                this.Close();

            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!");
            }*/


        }
        public bool kiemtra()
        {
            // t muốn đăng nhập voi quyền người dùng
            TaiKhoan data = dt.TaiKhoans.Where(s => s.TenDangNhap == txtTenDangNhap.Text.Trim()).Where(s => s.MatKhau == MaHoa(txtMatKhau.Text.Trim())).FirstOrDefault();
            if(data!=null)
            {
                if(data.Quyen==1)
                {
                    MessageBox.Show("Bạn đã đăng nhập với quyền Admin", "Thông Báo", MessageBoxButtons.OK);
                    i = 1;
                    return true;

                } 
                else if(data.Quyen==2)
                {
                    i = 2;
                    MessageBox.Show("Bạn đã đăng nhập với quyền người dùng!", "Thông Báo", MessageBoxButtons.OK);
                    return true;

                }    
               

            }
          //  var dataa = dt.TaiKhoans.Where(s => s.TenDangNhap == txtTenDangNhap.Text).Where(s => s.MatKhau == MaHoa(txtMatKhau.Text)).FirstOrDefault();
           
            else
            {
                MessageBox.Show("kkk");
                MessageBox.Show("Tài khoản Hoặc Mật Khẩu Không Đúng", "Thông Báo", MessageBoxButtons.OK);
                return false;

            }    
          
           
            return false;
        }

        private void btnQuenMatKhau_Click(object sender, EventArgs e)
        {
            
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void txtTenDangNhap_Click(object sender, EventArgs e)
        {
            txtTenDangNhap.Text = "";
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMatKhau_Click(object sender, EventArgs e)
        {
            txtMatKhau.Text = "";

        }
    }
}
