using QUANLYKHACHSAN.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace QUANLYKHACHSAN.UserInterface
{
    public partial class LoaiTinhTrangPhong : Form
    {


        public int i = 0;
        public LoaiTinhTrangPhong()
        {
            InitializeComponent();
        }
        DataClasses1DataContext dt = new DataClasses1DataContext();

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

            clickthem();
           
        }
        public void clickthem()
        {
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            txtMaLoaiTinhTrang.Enabled = true;
            txtTenLoaiTinhTrang.Enabled = true;
            reset();
            i = 1;

        }

        public void reset()
        {

            txtMaLoaiTinhTrang.Text = "";
            txtTenLoaiTinhTrang.Text = "";
           


        }

        private void KhachHangUser_Load(object sender, EventArgs e)
        {

            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            txtTenLoaiTinhTrang.Enabled = false;
            
            txtMaLoaiTinhTrang.Enabled = false;



            dataTinhTrang.DataSource = new DataClasses1DataContext().TinhTrangPhongs.ToList();


            txtMaLoaiTinhTrang.Text = dataTinhTrang.Rows[0].Cells[0].Value.ToString();

            txtTenLoaiTinhTrang.Text = dataTinhTrang.Rows[0].Cells[1].Value.ToString();



        }

        private void save_Click(object sender, EventArgs e)
        {



            if (i == 1)
            {
                DialogResult xoa = MessageBox.Show("Bạn có muốn Thêm không?", "", MessageBoxButtons.YesNo);
                if (xoa == DialogResult.Yes)
                {
                    dt.insertTT(txtMaLoaiTinhTrang.Text, txtTenLoaiTinhTrang.Text);

                    MessageBox.Show("Thêm Thành Công ?", "Thông Báo", MessageBoxButtons.OK);

                }

            }
            else if (i == 2)
            {
                DialogResult xoa = MessageBox.Show("bạn có muốn sửa không?", "", MessageBoxButtons.YesNo);
                if (xoa == DialogResult.Yes)
                {
                    var data = dt.updateTT(txtMaLoaiTinhTrang.Text, txtTenLoaiTinhTrang.Text);
                    MessageBox.Show("Sửa Thành Công ?", "Thông Báo", MessageBoxButtons.OK);

                }



            }
            KhachHangUser_Load(sender, e);
            btnLuu.Enabled = false;

        }

        private void datagKhachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataTinhTrang.CurrentRow.Index;

            txtMaLoaiTinhTrang.Text = dataTinhTrang.Rows[i].Cells[0].Value.ToString();

            txtTenLoaiTinhTrang.Text = dataTinhTrang.Rows[i].Cells[1].Value.ToString();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            i = 2;
            txtMaLoaiTinhTrang.Enabled = false;
            txtTenLoaiTinhTrang.Enabled = true;
            btnXoa.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult xoa = MessageBox.Show("Bạn có muốn xóa không?", "", MessageBoxButtons.YesNo);
            if (xoa == DialogResult.Yes)
            {
                var data = dt.deleteTT(txtMaLoaiTinhTrang.Text);

            }
            dataTinhTrang.DataSource = new DataClasses1DataContext().TinhTrangPhongs.ToList();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            KhachHangUser_Load(sender, e);
        }
    }



}
