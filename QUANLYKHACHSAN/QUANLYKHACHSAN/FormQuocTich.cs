using QUANLYKHACHSAN.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QUANLYKHACHSAN
{
    public partial class FormQuocTich : Form
    {
        public FormQuocTich()
        {
            InitializeComponent();
        }
        public  int i = 0;
        DataClasses1DataContext dt = new DataClasses1DataContext();

        private void btnThem_Click(object sender, EventArgs e)
        {
            clickthem();


        }
        public void seaching_QuocTich(string s)
        {
            datagQuocTich.DataSource = dt.Seaching_QuocTich(s);
        }
        public void clickthem()
        {
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
           
            txtQuocTich.Enabled = true;
            txtQuocTich.Text = "";
            txtGhiChu.Text = "";

        }

        private void FormQuocTich_Load(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
           
            datagQuocTich.DataSource = dt.LoaiKhachHangs.ToList();
            txtQuocTich.Text = datagQuocTich.Rows[0].Cells[0].Value.ToString();
            txtGhiChu.Text = datagQuocTich.Rows[0].Cells[1].Value.ToString();
            txtQuocTich.Enabled = false;
           // string s = "05/07/2020";
          //  DateTime dateTime = Convert.ToDateTime(s.ToString());
            //MessageBox.Show(dateTime.Day.ToString());
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            if (i == 1)
            {
                DialogResult xoa = MessageBox.Show("bạn có muốn Thêm không?", "Thông Báo!", MessageBoxButtons.YesNo);
                if (xoa == DialogResult.Yes)
                {
                    dt.themLoaiKhachHang(txtQuocTich.Text,txtGhiChu.Text);
                    MessageBox.Show("Thêm Thành Công ?", "Thông Báo", MessageBoxButtons.OK);

                }

            }
           
           
            btnLuu.Enabled = false;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
        }

        private void datagQuocTich_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = datagQuocTich.CurrentRow.Index;
            txtQuocTich.Text = datagQuocTich.Rows[i].Cells[0].Value.ToString();
            txtGhiChu.Text = datagQuocTich.Rows[i].Cells[1].Value.ToString();
          
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            FormQuocTich_Load(sender, e);

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            seaching_QuocTich(txtTimKiem.Text.Trim());
        }
    }
}
