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
    public partial class DichVu : Form
    {
       
        public DichVu()
        {
            InitializeComponent();
        }
        DataClasses1DataContext dt = new DataClasses1DataContext();
        public int i;

        private void DichVu_Load(object sender, EventArgs e)
        {
            cmbMaDanhSach.Enabled = false;
            cmbMaLDVu.Enabled = false;
            txtMaDVu.Enabled = false;
            cmbMaDanhSach.DisplayMember = "MaDanhSach";
            cmbMaDanhSach.ValueMember = "MaDanhSach";
            cmbMaDanhSach.DataSource = dt.selectDS();

            cmbMaLDVu.DataSource = dt.LoaiDVs.ToList();
            cmbMaLDVu.DisplayMember = "TenLoaiDV";
            cmbMaLDVu.ValueMember = "MaLoaiDV";
            dataDV.AutoGenerateColumns = false;
            dataDV.DataSource = dt.selectDV();
            btnHuy.Enabled = true;
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;
            
           
           
        }

        private void toolStripButtonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButtonLuu_Click(object sender, EventArgs e)
        {
            var dv = dt.DVs.Where(s => s.MaDV == txtMaDVu.Text).FirstOrDefault();
            if(dv!=null)
            {
                MessageBox.Show("Dịch Vụ Đã Tồn Tại!");
            }
            else
            {
                dt.them_DV(txtMaDVu.Text, cmbMaLDVu.SelectedValue.ToString(), null, cmbMaDanhSach.SelectedValue.ToString());

            }
          
            DichVu_Load( sender,  e);



        }
        public bool checkIn_HoaDon()
        {
            DV dV = dt.DVs.Where(s => s.MaDV == txtMaDVu.Text).FirstOrDefault();
            if(dV!=null)
            {
                DanhSachDichVu danhSachDichVu = dt.DanhSachDichVus.Where(s => s.MaDanhSach == cmbMaDanhSach.Text).FirstOrDefault();
                if (danhSachDichVu != null)
                {
                  
                    CT_PhieuThue cT_PhieuThue = dt.CT_PhieuThues.Where(s => s.SoPhieuThue == Convert.ToInt32(danhSachDichVu.SoPhieuThue)).
                        FirstOrDefault();
                    if (cT_PhieuThue != null)
                    {

                      
                        PhieuThuePhong phieuThuePhong = dt.PhieuThuePhongs.Where(s => s.MaPhieuThue == cT_PhieuThue.MaPhieuThue).FirstOrDefault();
                        if (phieuThuePhong != null)
                        {
                            string a = phieuThuePhong.MaPhieuThue.ToString();
                          
                            HoaDon hoaDon = dt.HoaDons.Where(s => s.MaPhieuThue == phieuThuePhong.MaPhieuThue).FirstOrDefault();
                            if (hoaDon != null)
                            {
                              
                                return false;
                            }

                        }

                    }

                    //MessageBox.Show("Dịch Vụ Này đã được thanh toán trong hóa đơn! không xóa được");
                }

            }    
          
            return true;


        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (checkIn_HoaDon() == true)
            {
                if (txtMaDVu.Text == "")
                {
                    MessageBox.Show("Bạn Chưa Chọn Hóa ĐƠn Xóa!");
                }
                else
                {
                   
                   
                        DialogResult xoa = MessageBox.Show("bạn có muốn xóa không?", "", MessageBoxButtons.YesNo);
                        if (xoa == DialogResult.Yes)
                        {



                        dt.xoaDV(txtMaDVu.Text);
                            MessageBox.Show("Xóa Thành Công !");

                        }

               }



            }
            else
            {
                MessageBox.Show("Dịch Vụ Này Đã Thanh Toán Không Thể Xóa");

            }
        }
        private void DataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
        }

        private void btnThemMLDV_Click(object sender, EventArgs e)
        {

        }

        private void btnThemMaDVi_Click(object sender, EventArgs e)
        {

        }

        private void TimMaLDVuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void toolTimKiem_Enter(object sender, EventArgs e)
        {
           
        }

        private void toolTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void toolTimKiem_Leave(object sender, EventArgs e)
        {
          
        }

        private void TimDonViToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            cmbMaLDVu.Enabled = true;
            cmbMaDanhSach.Enabled = true;
            txtMaDVu.Enabled = true;
            txtMaDVu.Text = "";
            cmbMaDanhSach.Text = "";
            cmbMaLDVu.Text = "";
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
        }

        private void toolTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void dataDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataDV.CurrentRow.Index;
            txtMaDVu.Text= dataDV.Rows[i].Cells[0].Value.ToString();
            cmbMaLDVu.Text = dataDV.Rows[i].Cells[1].Value.ToString();
            cmbMaDanhSach.Text= dataDV.Rows[i].Cells[2].Value.ToString();
            btnXoa.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelEx1_Click(object sender, EventArgs e)
        {

        }
        public void TimKiem(string valuaToFind)
        {
            dataDV.DataSource = dt.sechingDV(valuaToFind);


        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DichVu_Load(sender, e);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            TimKiem(txtTimkiem.Text.Trim());

        }

        private void btnMaLPhong_Click(object sender, EventArgs e)
        {
            LoaiDichVu loaiDichVu = new LoaiDichVu();
            loaiDichVu.ShowDialog();
        }
    }
}