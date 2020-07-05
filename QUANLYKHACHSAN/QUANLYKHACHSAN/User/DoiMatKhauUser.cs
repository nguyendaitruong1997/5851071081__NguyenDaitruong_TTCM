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
    public partial class DoiMatKhauUser : UserControl
    {
        public DoiMatKhauUser()
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
        public bool check()
        {
            var data = dt.TaiKhoans.Where(s => s.TenDangNhap == textBoxX1.Text.Trim()).Where(s => s.MatKhau == MaHoa( txtMatKhauCu.Text.Trim()));
            if(data!=null)
            {
                return true;
            } 
            else

            return false;
        }
      

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if(check()==true)
            {
                if( ( txtMatKhauMoi.Text.Trim())!=( txtXacNhanMatKhau.Text.Trim()))
                {
                    MessageBox.Show("Xác nhận mật khẩu không chính xác!");
                }   
                else
                {
                    dt.doimk(textBoxX1.Text,MaHoa( txtMatKhauMoi.Text));
                    MessageBox.Show("Đổi mật khẩu thành công !");

                }    

            }  
            else
            {
                MessageBox.Show("Tài Khoản không tồn tại !");
            }    
        }

        private void txtXacNhanMatKhau_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
