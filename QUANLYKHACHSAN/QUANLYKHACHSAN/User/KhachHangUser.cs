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

namespace QUANLYKHACHSAN.User
{
    public partial class KhachHangUser : UserControl
    {
        public int i = 0;
        public KhachHangUser()
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
            txtMaKhachHang.Enabled = true;
            reset();
            notenable();
            i = 1;

        }
        public void notenable()
        {

            txtCMND.Enabled = true;
            txtDiaChi.Enabled = true;
            txtMaKhachHang.Enabled = true;
            txtSdt.Enabled = true;
            cbGioiTinh.Enabled = true;
            cmbQuocTich.Enabled = true;
            txtTenKhachHang.Enabled = true;

        }
        public void ennable()
        {
            txtCMND.Enabled = false;
            txtDiaChi.Enabled = false;
            txtMaKhachHang.Enabled = false;
            txtSdt.Enabled = false;
            cbGioiTinh.Enabled = false;
            cmbQuocTich.Enabled = false;
            txtTenKhachHang.Enabled = false;

        }

        public void reset()
        {
          
            txtMaKhachHang.Text = "";
            txtTenKhachHang.Text = "";
            txtCMND.Text = "";
            txtDiaChi.Text = "";
            txtSdt.Text = "";
            txtTimKiem.Text = "";


        }

        private void KhachHangUser_Load(object sender, EventArgs e)
        {

            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            txtMaKhachHang.Enabled = false;
            ennable();

            cbGioiTinh.Items.Add("Nam");
            cbGioiTinh.Items.Add("Nữ");
            cmbQuocTich.DataSource = dt.LoaiKhachHangs.ToList();

            cmbQuocTich.DisplayMember = "GhiChu";
            cmbQuocTich.ValueMember = "QuocTich";
            datagKhachhang.AutoGenerateColumns = false;
            datagKhachhang.DataSource = new DataClasses1DataContext().KhachHangs.ToList();


            

        }

        private void save_Click(object sender, EventArgs e)
        {
            


            if (i == 1)
            {
                if(txtMaKhachHang.Text==""|| cmbQuocTich.SelectedValue.ToString()==""|| txtTenKhachHang.Text==""|| txtCMND.Text==""|| cbGioiTinh.Text==""|| txtDiaChi.Text==""|| txtSdt.Text=="")
                {
                    MessageBox.Show("Bạn chưa nhập đầy đủ thông tin !", "Thông Báo", MessageBoxButtons.OK);

                }  
                else
                {
                    KhachHang khachHang = dt.KhachHangs.Where(s => s.MaKhachHang == txtMaKhachHang.Text).FirstOrDefault();
                    if(khachHang !=null)
                    {
                        MessageBox.Show("Khách Hàng đã tồn tại vui lòng nhập mã khách hàng khác !!");
                    }    
                    else
                    {
                        DialogResult xoa = MessageBox.Show("bạn có muốn Thêm không?", "", MessageBoxButtons.YesNo);
                        if (xoa == DialogResult.Yes)
                        {
                            dt.themkhachhangs(txtMaKhachHang.Text, cmbQuocTich.SelectedValue.ToString(), txtTenKhachHang.Text, txtCMND.Text, cbGioiTinh.Text, txtDiaChi.Text, txtSdt.Text);

                            MessageBox.Show("Thêm Thành Công ?", "Thông Báo", MessageBoxButtons.OK);

                        }

                    }    
                  

                }    
               

            }
            else if (i == 2)
            {

               

                if (txtMaKhachHang.Text == "" || cmbQuocTich.SelectedValue.ToString() == "" || txtTenKhachHang.Text == "" || txtCMND.Text == "" || cbGioiTinh.Text == "" || txtDiaChi.Text == "" || txtSdt.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập đầy đủ thông tin !", "Thông Báo", MessageBoxButtons.OK);

                }
                else
                {
                    PhieuThuePhong phieuThuePhong = dt.PhieuThuePhongs.Where(s => s.MaKhachHang == txtMaKhachHang.Text).FirstOrDefault();
                    if(phieuThuePhong!=null)
                    {
                        MessageBox.Show(" Không cho sửa ?", "", MessageBoxButtons.OK);

                    }    
                    DialogResult xoa = MessageBox.Show("bạn có muốn sửa không?", "", MessageBoxButtons.YesNo);
                    if (xoa == DialogResult.Yes)
                    {
                        var data = dt.suakhachhang(txtMaKhachHang.Text, cmbQuocTich.SelectedValue.ToString(), txtTenKhachHang.Text, txtCMND.Text, cbGioiTinh.Text, txtDiaChi.Text, txtSdt.Text);
                        MessageBox.Show("Sửa Thành Công ?", "Thông Báo", MessageBoxButtons.OK);

                    }

                }    
              



            }
            KhachHangUser_Load(sender, e);
            btnLuu.Enabled = false;

        }

        private void datagKhachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = datagKhachhang.CurrentRow.Index;
            txtMaKhachHang.Text = datagKhachhang.Rows[i].Cells[0].Value.ToString();
            txtTenKhachHang.Text = datagKhachhang.Rows[i].Cells[1].Value.ToString();
            cmbQuocTich.SelectedValue = datagKhachhang.Rows[i].Cells[2].Value.ToString();
            txtCMND.Text = datagKhachhang.Rows[i].Cells[3].Value.ToString();
            cbGioiTinh.Text = datagKhachhang.Rows[i].Cells[4].Value.ToString();
            txtDiaChi.Text = datagKhachhang.Rows[i].Cells[5].Value.ToString();
            txtSdt.Text = datagKhachhang.Rows[i].Cells[6].Value.ToString();


        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            i = 2;
            txtMaKhachHang.Enabled = false;
            btnXoa.Enabled = false;


            txtCMND.Enabled = true;
            txtDiaChi.Enabled = true;
           // txtMaKhachHang.Enabled = true;
            txtSdt.Enabled = true;
            cbGioiTinh.Enabled = true;
            cmbQuocTich.Enabled = true;
            txtTenKhachHang.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            PhieuThuePhong phieuThuePhong = dt.PhieuThuePhongs.Where(s => s.MaKhachHang == txtMaKhachHang.Text).FirstOrDefault();
            if(phieuThuePhong==null)
            {
                DialogResult xoa = MessageBox.Show("Bạn có muốn xóa không?", "", MessageBoxButtons.YesNo);
                if (xoa == DialogResult.Yes)
                {
                    var data = dt.xoakhachhang(txtMaKhachHang.Text);

                }
                datagKhachhang.DataSource = new DataClasses1DataContext().KhachHangs.ToList();

            }
            else
            {
                MessageBox.Show("Không xóa được !");
            }

          
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            KhachHangUser_Load(sender,e);
        }

        private void btnMaKH_Click(object sender, EventArgs e)
        {
            FormQuocTich formQuocTich = new FormQuocTich();
            formQuocTich.ShowDialog();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(txtTimKiem.Text=="")
            {
                datagKhachhang.DataSource = new DataClasses1DataContext().KhachHangs.ToList();

            }   
            else
            {
                datagKhachhang.DataSource = dt.KhachHangs.Where(s => s.MaKhachHang == txtMaKhachHang.Text).ToList();

            }    
            
        }

        private void txtTimKiem_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
        }
    }
}
