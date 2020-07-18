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
              
                MessageBox.Show("Tài khoản Hoặc Mật Khẩu Không Đúng", "Thông Báo", MessageBoxButtons.OK);
                return false;

            }    
          
           
            return false;
        }

        private void btnQuenMatKhau_Click(object sender, EventArgs e)
        {
            panelDangNhap.Visible = false;
            panel_DoiMatKhau.Visible = false;
            pn_QuenMK.Visible = true;
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            panelDangNhap.Visible = true;
            panel_DoiMatKhau.Visible = false;
            pn_QuenMK.Visible = false;
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

        private void bt_QuayLai_Click(object sender, EventArgs e)
        {

            panelDangNhap.Visible = true;
            panel_DoiMatKhau.Visible = false;
            pn_QuenMK.Visible = false;


        }

        private void bunifuThinHoTro_Click(object sender, EventArgs e)
        {
            var data = dt.TaiKhoans.Where(s => s.TenDangNhap == txtUserPhanQuenMK.Text.Trim())
                .Where(s => s.Gmail == txtSoDienThoaiPhanQuenMK.Text.Trim()).FirstOrDefault();
            if(data==null)
            {
                MessageBox.Show("Không có tài khoản này !");

            }
            else
            {

                string TKdoimk ="";
                TKdoimk = txtUserPhanQuenMK.Text.Trim();

                try
                {
                    string bodyemail = "Xin Chào bạn Chúng Tôi Đã Nhận Được Yêu Cầu Cần Hỗ Trợ Của Bạn: \n\n"
+ "\tChúng Tôi Sẽ Hướng Dẫn Bạn Cách Đổi Mật Khẩu\n"
+ "Bước 1: Tại Phần Đổi Mật Khẩu, Bạn Nhập Tên Tài Khoản Của Bạn\n"
+ "Bước 2: Tiếp Theo Bạn Cần Nhập Mã Xác Minh \n"
+ "\t\t=> Mã Xác Minh Của Bạn Là: " + data.MatKhau.Remove(6, 26)
+ "\nBước 3: Nhập Mật Khẩu Mới Của Bạn, Xong Bạn Click Vào Đổi Mật Khẩu\n"
+ "Chúc bạn thành công";
                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress("dhvsport00@gmail.com");
                    mail.To.Add(data.Gmail);
                    mail.Subject = "Khách Sạn Trưởng Đẹp TRai";

                    mail.Body = bodyemail;
                    SmtpClient smptClient = new SmtpClient();
                    smptClient.Host = "smtp.gmail.com";
                    System.Net.NetworkCredential credential = new NetworkCredential();
                    credential.UserName = "dhvsport00@gmail.com";
                    credential.Password = "DHVSport450LeVanViet";
                    smptClient.Credentials = credential;
                    smptClient.Port = 587;
                    smptClient.EnableSsl = true;
                    smptClient.Send(mail);
                    MessageBox.Show("Đã gửi mã xác minh về Email\nMời Kiểm Tra Để Đổi Mật Khẩu", "Thông báo", MessageBoxButtons.OK);
                    panelDangNhap.Visible = false;
                    panel_DoiMatKhau.Visible = true;
                    pn_QuenMK.Visible = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("Kiểm tra lại mạng hoặc thông tin Email\nHoặc liên hệ với người quản trị", "Lỗi");
                }
            }
        }

        private void bt_DoiMoiMK_Click(object sender, EventArgs e)
        {
            if(txt_TenTaiKhoanPhanDoiMatKhau.Text=="" || txt_TenTaiKhoanPhanDoiMatKhau.Text.Trim()==""
                || txt_MatKhauMOi.Text=="")
            {

            }
            else
            {
                var Tk = dt.TaiKhoans.Where(s => s.TenDangNhap == txt_TenTaiKhoanPhanDoiMatKhau.Text.Trim())
                    .Where(s => s.MatKhau == txt_MaXacMinh.Text.Trim().Remove(6, 26));
                if(Tk==null)
                {
                    MessageBox.Show("Thông tin sai");

                }  
                else if( Tk!=null)
                {
                    dt.update_mk(txt_TenTaiKhoanPhanDoiMatKhau.Text, MaHoa( txt_MatKhauMOi.Text.Trim()));
                    MessageBox.Show("Đổi mk thành công");
                    panelDangNhap.Visible = true;
                    panel_DoiMatKhau.Visible = false;
                    pn_QuenMK.Visible = false;
                }    
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormDK formDK = new FormDK();
            formDK.ShowDialog();
        }
    }
}
