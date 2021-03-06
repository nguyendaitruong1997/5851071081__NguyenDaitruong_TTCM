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
    public partial class DanhSachSuDungDichVu : Form
    {
       
        
        public DanhSachSuDungDichVu()
        {
            InitializeComponent();
        }
        DataClasses1DataContext dt = new DataClasses1DataContext();
        public int i;

        private void DanhSachSuDungDichVu_Load(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            dtDs.AutoGenerateColumns = false;
            txtMaSuDung.Enabled = false;

            dtDs.DataSource = dt.DanhSachDichVus.ToList();
            cmbSoPhieuNhan.Enabled = false;
            this.cmbSoPhieuNhan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            try
            {
                cmbSoPhieuNhan.Text = "";
                cmbSoPhieuNhan.ValueMember = "SoPhieuThue";
                cmbSoPhieuNhan.DisplayMember = "SoPhieuThue";

                cmbSoPhieuNhan.DataSource = dt.checkPhieuThueDV1();
            }
            catch (Exception)


            {

            }

        }        

        private void toolStripButtonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public bool check()
        {
            var danhSachDichVu = dt.DanhSachDichVus.Where(s => s.MaDanhSach == txtMaSuDung.Text.Trim()).FirstOrDefault();
            if(danhSachDichVu==null)
            {
              //  MessageBox.Show("aaaaaaaaa");
                return true;
            } 
            else if(danhSachDichVu!=null)
            {
               // MessageBox.Show("bbbbbbbbbbb");
                return false;

            }
            return false;

          
        }
        public bool checkIn_HoaDon()
        {
            CT_PhieuThue cT_PhieuThue = dt.CT_PhieuThues.Where(s => s.SoPhieuThue == Convert.ToInt32(cmbSoPhieuNhan.SelectedValue.ToString())).
                FirstOrDefault();
            if(cT_PhieuThue!=null)
            {
                PhieuThuePhong phieuThuePhong = dt.PhieuThuePhongs.Where(s => s.MaPhieuThue == cT_PhieuThue.MaPhieuThue).FirstOrDefault();
                if(phieuThuePhong!=null)
                {
                    HoaDon hoaDon = dt.HoaDons.Where(s => s.MaPhieuThue == phieuThuePhong.MaPhieuThue).FirstOrDefault();
                    if(hoaDon!=null)
                    {
                        return false;
                    }    
                }    
            }    
            return true;
        }
        private void toolStripButtonLuu_Click(object sender, EventArgs e)
        {
            if(i==1)
            {
                if(check()==true)
                {
                    DanhSachDichVu danhSachDichVu = dt.DanhSachDichVus.Where(s => s.SoPhieuThue == Convert.ToInt32(cmbSoPhieuNhan.SelectedValue.ToString()))
                        .FirstOrDefault();
                    if(danhSachDichVu==null)
                    {
                        DialogResult xoa = MessageBox.Show("bạn có muốn Thêm không?", "", MessageBoxButtons.YesNo);
                        if (xoa == DialogResult.Yes)
                        {
                            dt.themdanhsachDV(txtMaSuDung.Text, Convert.ToInt32(cmbSoPhieuNhan.SelectedValue.ToString()));

                            MessageBox.Show("Thêm Thành Công ?", "Thông Báo", MessageBoxButtons.OK);

                        }

                    }  
                    else
                    {
                        MessageBox.Show("Số Phiếu Nhận đã tồn tại không thể thêm!", "Thông Báo", MessageBoxButtons.OK);
                    }    
                  
                   

                }    
                else
                {
                    MessageBox.Show("Mã Sử Dụng Đã Tồn Tại !");
                }    

            }  
            else if(i==2)
            {
                if(checkIn_HoaDon()==true)
                {

                    DialogResult xoa = MessageBox.Show("bạn có muốn sửa không?", "", MessageBoxButtons.YesNo);
                    if (xoa == DialogResult.Yes)
                    {
                        dt.update_danhsachDV(txtMaSuDung.Text, Convert.ToInt32(cmbSoPhieuNhan.Text));


                        MessageBox.Show("Sửa Thành Công ?", "Thông Báo", MessageBoxButtons.OK);

                    }

                }  
                else
                {
                    MessageBox.Show("Dịch Vụ Này Đã Thanh Toán Không Thể Sửa");
                }    

              
            }
            DanhSachSuDungDichVu_Load(sender, e);
           // dtNguoiDung.DataSource = new DataClasses1DataContext().TaiKhoans.ToList();
            dtDs.DataSource = new DataClasses1DataContext().DanhSachDichVus.ToList();




        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if(checkIn_HoaDon()==true)
            {
                if(txtMaSuDung.Text=="")
                {
                    MessageBox.Show("Bạn Chưa Chọn Hóa ĐƠn Xóa!");
                }  
                else
                {
                    DV dV = dt.DVs.Where(s => s.MaDanhSach == txtMaSuDung.Text).FirstOrDefault();
                    if(dV !=null)
                    {
                        MessageBox.Show("Không Thể Xóa");
                    }    
                    else
                    {
                        DialogResult xoa = MessageBox.Show("bạn có muốn xóa không?", "", MessageBoxButtons.YesNo);
                        if (xoa == DialogResult.Yes)
                        {



                            dt.deleteDanhSach(txtMaSuDung.Text);
                            MessageBox.Show("Xóa Thành Công !");

                        }

                    }    
                  
                  


                }    
               
             

            } 
            else
            {
                MessageBox.Show("Dịch Vụ Này Đã Thanh Toán Không Thể Xóa");

            }    
           
            DanhSachSuDungDichVu_Load(sender, e);

        }

        private void DataGV_Delete(object sender, DataGridViewRowCancelEventArgs e)
        {
            
        }

        private void toolTimKiem_Enter(object sender, EventArgs e)
        {
           
        }

        private void toolTimKiem_Leave(object sender, EventArgs e)
        {
            
        }

        private void toolTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void tìmMãDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void tìmMãPhiếuNhậnToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void btnMaDVu_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMaPhieuNhan_Click(object sender, EventArgs e)
        {
            
        }

        private void TienDVu_ValueChanged(object sender, EventArgs e)
        {  
            //numTienDVu.Value = tien;

            //numTienDVu.Value=(numSoLuong.Value*dvi.DonGia);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            txtMaSuDung.Enabled = true;
            txtMaSuDung.Text = "";
            cmbSoPhieuNhan.Enabled = true;
            cmbSoPhieuNhan.Text = "";
            i = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DichVu dichVu = new DichVu();
            dichVu.ShowDialog();


        }

        private void panelEx1_Click(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DanhSachSuDungDichVu_Load(sender, e);
            txtMaSuDung.Text = "";
        }

        private void dtDs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.cmbSoPhieuNhan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            int i = dtDs.CurrentRow.Index;
            txtMaSuDung.Text = dtDs.Rows[i].Cells[0].Value.ToString();
            string s= Convert.ToString(dtDs.Rows[i].Cells["SoPhieuThue"].Value.ToString());
            cmbSoPhieuNhan.Text = s;
          
            btnSua.Enabled = true;
           
        }
        public void TimKiem(string valuaToFind)
        {
            dtDs.DataSource = dt.sechingDs(valuaToFind);


        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            txtMaSuDung.Enabled = false;
            cmbSoPhieuNhan.Enabled = true;
            i = 2;
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void cmbSoPhieuNhan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {
            TimKiem(txttimkiem.Text.Trim());
        }
    }
}