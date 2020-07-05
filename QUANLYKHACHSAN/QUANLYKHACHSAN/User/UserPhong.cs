using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QUANLYKHACHSAN.UserInterface;
using QUANLYKHACHSAN.Database;
using Phong = QUANLYKHACHSAN.Database.Phong;

namespace QUANLYKHACHSAN.User
{
    public partial class UserPhong : UserControl
    {
        public UserPhong()
        {
            InitializeComponent();
        }
        DataClasses1DataContext dt = new DataClasses1DataContext();
        public int i = 0;
        private void btnMaLPhong_Click(object sender, EventArgs e)
        {
            UserInterface.LoaiPhong loaiPhong = new UserInterface.LoaiPhong();
            loaiPhong.ShowDialog();
        }

        private void btnTinhTrangPhong_Click(object sender, EventArgs e)
        {
            LoaiTinhTrangPhong loaiTinhTrangPhong = new LoaiTinhTrangPhong();
            loaiTinhTrangPhong.ShowDialog();
            UserPhong_Load(sender, e);



        }
        public string s = "";
        public void reset()
        {
           // txtGhichu.Text = "";
            txtMaPhong.Text = "";
        }
        public void ennable()
        {
           // txtGhichu.Enabled = false;
            txtMaPhong.Enabled = false;
            cmbMaLPhong.Enabled = false;
            cmbMaTTrPhong.Enabled = false;
        }
        public void notennable()
        {
          //  txtGhichu.Enabled = true;
            txtMaPhong.Enabled = true;
            cmbMaLPhong.Enabled = true;
            cmbMaTTrPhong.Enabled = true;
        }
        public void clickThem()
        {
            notennable();
            
           // txtGhichu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
           // txtGhichu.Text = "";
            txtMaPhong.Text = "";
            i = 1;
        }
        public void clickSua()
        {
            notennable();

          //  txtGhichu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            txtMaPhong.Enabled = false;
            i = 2;
        }
        private void UserPhong_Load(object sender, EventArgs e)
        {
            cmbMaLPhong.DataSource = dt.LoaiPhongs.ToList();

            cmbMaLPhong.DisplayMember = "TenLoaiPhong";
            cmbMaLPhong.ValueMember = "MaLoaiPhong";
             
            cmbMaTTrPhong.DataSource = dt.TinhTrangPhongs.ToList();


            cmbMaTTrPhong.DisplayMember = "TenTinhTrang";
            cmbMaTTrPhong.ValueMember = "MaTinhTrang";
            dataGridViewphong.AutoGenerateColumns = false;
            dataGridViewphong.DataSource = dt.SlectPhong();

            ennable();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            txtMaPhong.Text = dataGridViewphong.Rows[0].Cells[0].Value.ToString();
            cmbMaLPhong.Text = dataGridViewphong.Rows[0].Cells[1].Value.ToString();
            cmbMaTTrPhong.SelectedValue = dataGridViewphong.Rows[0].Cells[2].Value.ToString();
           // txtGhichu.Text = dataGridViewphong.Rows[0].Cells[3].Value.ToString();

        }

        string ttcu;

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            clickThem();

        }

        private void LuuToolStripButton_Click(object sender, EventArgs e)
        {
            if (i == 1)
            {
                DialogResult xoa = MessageBox.Show("bạn có muốn Thêm không?", "", MessageBoxButtons.YesNo);
                if (xoa == DialogResult.Yes)
                {

                    dt.themPhong(txtMaPhong.Text, cmbMaLPhong.SelectedValue.ToString(), cmbMaTTrPhong.SelectedValue.ToString(), null);


                }

            }
            else if (i == 2)
            {
                string a;
                Phong phong = dt.Phongs.Where(s => s.MaPhong == txtMaPhong.Text).FirstOrDefault();
                a = phong.MaTinhTrang.ToString();

                if(a=="TT2")
                {
                    MessageBox.Show("Phòng đã có khách đăng kí không được sửa trạng thái phòng hehe !!");
                }
                 
                else  
                {
                    if(cmbMaTTrPhong.SelectedValue.ToString()=="TT2")
                    {
                        MessageBox.Show("Không sửa được vì phòng chưa có người thuê !!");

                    }    
                    else
                    {
                        DialogResult xoa = MessageBox.Show("bạn có muốn sửa không?", "", MessageBoxButtons.YesNo);
                        if (xoa == DialogResult.Yes)
                        {
                            s = cmbMaTTrPhong.Text;
                            dt.updatePhong(txtMaPhong.Text, cmbMaLPhong.SelectedValue.ToString(), cmbMaTTrPhong.SelectedValue.ToString(), s);


                        }

                    }    
                  
                   

                }    


               

            }



        
           
         
            UserPhong_Load(sender, e);


        }

        private void txtGhichu_TextChanged(object sender, EventArgs e)
        {
            //txtGhichu.Text = cmbMaTTrPhong.Text;
        }

        private void cmbMaTTrPhong_TextChanged(object sender, EventArgs e)
        {
           // txtGhichu.Text = cmbMaTTrPhong.Text;
        }

        private void dataGridViewphong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridViewphong.CurrentRow.Index;
            int a = dataGridViewphong.CurrentCell.ColumnIndex;
            txtMaPhong.Text = dataGridViewphong.Rows[i].Cells[0].Value.ToString();
            cmbMaLPhong.Text= dataGridViewphong.Rows[i].Cells[1].Value.ToString();
            cmbMaTTrPhong.SelectedValue = dataGridViewphong.Rows[i].Cells[2].Value.ToString();
         
          //  txtGhichu.Text= dataGridViewphong.Rows[i].Cells[3].Value.ToString();

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            UserPhong_Load(sender, e);
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            clickSua();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult xoa = MessageBox.Show("bạn có muốn xóa không?", "", MessageBoxButtons.YesNo);
            if (xoa == DialogResult.Yes)
            {
                dt.deletePhong(txtMaPhong.Text);

            }
            UserPhong_Load(sender, e);

        }
    }
}
