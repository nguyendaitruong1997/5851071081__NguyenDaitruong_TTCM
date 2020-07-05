using QUANLYKHACHSAN.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace QUANLYKHACHSAN
{
    public partial class FormHoTro : Form
    {
        public FormHoTro()
        {
            InitializeComponent();
        }
        DataClasses1DataContext dt = new DataClasses1DataContext();

        private void bunifuThinHoTro_Click(object sender, EventArgs e)
        {
            /*DialogResult dtr = MessageBox.Show("Bạn Có Chắc Muốn Đổi Mật Khẩu Không", "Thông báo", MessageBoxButtons.OKCancel);
            if (dtr == DialogResult.OK)
            {
                //NHANVIEN nv = dt.NHANVIENs.Where(s => s.USERLOGIN == txtUserPhanQuenMK.Text.Trim()).Where(s => s.EMAIL == (txtGmailPhanQuenMK.Text.Trim())).FirstOrDefault();
                var rda = dt.TaiKhoans.Where(s => s.TenDangNhap == txtUserPhanQuenMK.Text.Trim()).Where(s => s.EMAIL == txtSoDienThoaiPhanQuenMK.Text.Trim()).FirstOrDefault();
                if (rda == null)
                {
                    MessageBox.Show("Không có tài khoản này!", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    string bodyemail = "Xin Chào " + rda.TENNHANVIEN + " Chúng Tôi Đã Nhận Được Yêu Cầu Cần Hổ Trợ Của Bạn: \n\n"
                                    + "\tChúng Tôi Sẽ Hướng Dẫn Bạn Cách Đổi Mật Khẩu\n"
                                    + "Bước 1: Tại Phần Đổi Mật Khẩu, Bạn Nhập Tên Tài Khoản Của Bạn\n"
                                    + "Bước 2: Tiếp Theo Bạn Cần Nhập Mã Xác Minh \n"
                                    + "\t\t=> Mã Xác Minh Của Bạn Là: " + rda.PASSWORD.Remove(6, 26)
                                    + "\nBước 3: Nhập Mật Khẩu Mới Của Bạn, Xong Bạn Click Vào Đổi Mật Khẩu";
                    try
                    {
                        MailMessage mail = new MailMessage();
                        mail.From = new MailAddress("tvfahasa@gmail.com");
                        mail.To.Add(rda.EMAIL);
                        mail.Subject = "Thư Viện Fahasa- Đưa Tri Thức Đến Gần Với Các Bạn";
                        mail.Body = bodyemail;
                        SmtpClient smptClient = new SmtpClient();
                        smptClient.Host = "smtp.gmail.com";
                        System.Net.NetworkCredential credential = new NetworkCredential();
                        credential.UserName = "tvfahasa@gmail.com";
                        credential.Password = "Hehehe123";
                        smptClient.Credentials = credential;
                        smptClient.Port = 587;
                        smptClient.EnableSsl = true;
                        smptClient.Send(mail);
                        MessageBox.Show("Đã gửi mã xác minh về EmailMời Kiểm Tra Để Đổi Mật Khẩu", "Thông báo", MessageBoxButtons.OK);
                        if (panel_DoiMatKhau.Left == 657)
                        {
                            pn_QuenMK.Visible = false;
                            pn_QuenMK.Left = 657;

                            panel_DoiMatKhau.Visible = false;
                            panel_DoiMatKhau.Left = 41;
                            panel_DoiMatKhau.Visible = true;
                            panel_DoiMatKhau.Refresh();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else if (dtr == DialogResult.Cancel)
            {

            }
        }

        private void bt_DoiMoiMK_Click(object sender, EventArgs e)
        {
            TaiKhoan nv = dt.TaiKhoans.Where(s => s.TenDangNhap == txt_TenTaiKhoanPhanDoiMatKhau.Text.Trim()).Where(s => s.MatKhau.Remove(6, 26) == txt_MaXacMinh.Text.Trim()).FirstOrDefault();
            if (nv == null)
            {
                MessageBox.Show("Bạn Đã Nhập Sai Mã Xác Minh Vui Lòng Check Mail Hoặc Kiểm Tra Lại!", "Thông Báo", MessageBoxButtons.OK);
            }
            else
            {
               /* dt.UPDATEMAHOA(txt_TenTaiKhoanPhanDoiMatKhau.Text.Trim(), MaHoa(txt_MatKhauMOi.Text.Trim()));
                MessageBox.Show("Chào Mừng Bạn Đến Với Thư Viện FaHaSa (-_-)", "Thông Báo", MessageBoxButtons.OK);
                FormWinDow f = new FormWinDow();*/
               
               /* this.Hide();
                f.Show();*/
            }
        }
    }

