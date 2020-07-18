using QUANLYKHACHSAN.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace QUANLYKHACHSAN
{
    public partial class FormDK : Form
    {
        public FormDK()
        {
            InitializeComponent();
        }
        DataClasses1DataContext dt = new DataClasses1DataContext();

        private void label1_Click(object sender, EventArgs e)
        {

        }
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
            var data = dt.TaiKhoans.Where(s => s.TenDangNhap == txtTenDangnhap.Text.Trim()).FirstOrDefault();
            if (data == null)
            {
                return true;
            }
            return false;
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            if (txtTenDangnhap.Text == "" || (txtMatKhau.Text) == "" ||  txtEmail.Text == "")
            {
                MessageBox.Show("Bạn hãy nhập đầy đủ thông tin!", "Thông báo!", MessageBoxButtons.YesNo);

            }
            else
            {
                if (check() == true)
                {
                    DialogResult xoa = MessageBox.Show("bạn có muốn đăng kí?", "Thông báo!", MessageBoxButtons.YesNo);
                    if (xoa == DialogResult.Yes)
                    {
                        var data = dt.insertt(txtTenDangnhap.Text, MaHoa(txtMatKhau.Text), 2, txtEmail.Text);
                        MessageBox.Show("Đăng kí thành công!", "Thông báo!", MessageBoxButtons.OK);
                        txtTenDangnhap.Text = "";
                        txtMatKhau.Text = "";
                        txtEmail.Text = "";

                    }

                }
                else
                {
                    MessageBox.Show("Tài Khoản Đã Tồn Tại!", "Thông Báo!", MessageBoxButtons.OK);
                }


            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
