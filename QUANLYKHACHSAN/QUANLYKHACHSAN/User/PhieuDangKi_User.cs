using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QUANLYKHACHSAN.Database;
using QUANLYKHACHSAN.UserInterface;

namespace QUANLYKHACHSAN.User
{
    public partial class PhieuDangKi_User : UserControl
    {
        public PhieuDangKi_User()
        {
            InitializeComponent();
        }
        public int i = 0;
        public int a;
        DataClasses1DataContext dt = new DataClasses1DataContext();

        private void groupPanel2_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewX1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void PhieuDangKi_User_Load(object sender, EventArgs e)
        {

           
            cmbMaKH.DataSource = dt.KhachHangs.ToList();

            cmbMaKH.DisplayMember = "MaKhachHang";
            cmbMaKH.ValueMember = "MaKhachHang";

            comboMaNV.DataSource = dt.NhanViens.ToList();

            comboMaNV.DisplayMember = "MaNhanVien";
            comboMaNV.ValueMember = "MaNhanVien";

            
            


            cmbMaPHong.DataSource = dt.Phongs.Where(p=>p.MaTinhTrang=="TT4").ToList();
            cmbMaPHong.Text = "";
            cmbMaPHong.DisplayMember = "MaPhong";
            cmbMaPHong.ValueMember = "MaPhong";
            cmbMaPHong.Text = "";

            dtPhieuDangKi.AutoGenerateColumns = false;

            dtPhieuDangKi.DataSource = dt.CT_PhieuThues.ToList();
            a = dtPhieuDangKi.RowCount;


            btnThem.Enabled = true;
           // btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaPhieuThue.Enabled = false;
            cmbMaPHong.Enabled = false;
            cmbMaKH.Enabled = false;
            comboMaNV.Enabled = false;
            dateTimeNgayNhan.Enabled = false;
            dateNgayDangKy.Enabled = false;
            txtMaPhieuThue.Enabled = false;
            txtMaChiTiet.Enabled = false;
            int i = 0;
            txtSoNguoiO.Enabled = false;
            comboBox1.Enabled = false;
            /*   txtMaChiTiet.Text = dtPhieuDangKi.Rows[i].Cells[0].Value.ToString();
               string maphieu = dtPhieuDangKi.Rows[i].Cells[1].Value.ToString();
               txtMaPhieuThue.Text = maphieu;
               cmbMaPHong.SelectedValue = dtPhieuDangKi.Rows[i].Cells[2].Value.ToString();
               dateNgayDangKy.Text = dtPhieuDangKi.Rows[i].Cells[3].Value.ToString();
               dateTimeNgayNhan.Text = dtPhieuDangKi.Rows[i].Cells[4].Value.ToString();

               PhieuThuePhong phieu = dt.PhieuThuePhongs.FirstOrDefault(p => p.MaPhieuThue == maphieu);
               cmbMaKH.SelectedValue = phieu.MaKhachHang;*/
            txtSoNguoiO.Enabled = false;
          //  comboBox1.Enabled = false;





        }
     
        public void clickThem()
        {
           

            // txtGhichu.Enabled = false;
            btnSua.Enabled = false;
           // btnXoa.Enabled = false;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            // txtGhichu.Text = "";
           
            i = 1;
        }
        public void clickSua()
        {
          

            //  txtGhichu.Enabled = false;
            btnSua.Enabled = false;
            //btnXoa.Enabled = false;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            
            i = 2;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            clickThem();
            txtMaPhieuThue.Enabled = false; ;
            txtMaChiTiet.Enabled = false;
            cmbMaPHong.Enabled = true;
            cmbMaKH.Enabled = true;
            comboMaNV.Enabled = true;
            dateTimeNgayNhan.Enabled = true;
            dateNgayDangKy.Enabled = true;
            txtSoNguoiO.Enabled = true;
            comboBox1.Enabled = true; ;
            txtMaChiTiet.Enabled = true;
            txtMaPhieuThue.Enabled = true;

            
        }
        public bool check()
        {
            if(txtMaPhieuThue.Text=="" || txtMaChiTiet.Text=="" ||cmbMaPHong.Text=="")
            {
              
                return false;

            }
            else
            {
                var data = dt.CT_PhieuThues.Where(s => s.SoPhieuThue == Convert.ToInt32(txtMaChiTiet.Text)).FirstOrDefault();
                var data1 = dt.PhieuThuePhongs.Where(s => s.MaPhieuThue == txtMaPhieuThue.Text).FirstOrDefault();
                if (data == null && data1 == null)
                {
                    return true;
                }
              


            }
           
            
            return false;
        }
      

        private void btnLuu_Click(object sender, EventArgs e)
        {
           
            if(i==1)
            {
                if(check()==true)
                {
                    DialogResult xoa = MessageBox.Show("bạn có muốn Thêm không?", "", MessageBoxButtons.YesNo);
                    if (xoa == DialogResult.Yes)
                    {  
                        dt.themPhieuThueedm(txtMaPhieuThue.Text, comboMaNV.SelectedValue.ToString(), cmbMaKH.SelectedValue.ToString(), Convert.ToInt32
                            (txtSoNguoiO.Text), comboBox1.Text );
                        dt.insertCT_PHieuThue1(Convert.ToInt32(txtMaChiTiet.Text), txtMaPhieuThue.Text, cmbMaPHong.SelectedValue.ToString(), Convert.ToDateTime
                            (dateNgayDangKy.Value.ToString()), Convert.ToDateTime(dateTimeNgayNhan.Value.ToString()), null);
                        string maphong;
                        maphong = cmbMaPHong.Text;
                        dt.update_Phong(maphong, "TT2", null);

                        ////  dt.ThemphieuDangKi(Convert.ToInt32(txtMaChiTiet.Text),txtMaPhieuThue.Text,comboMaNV.SelectedValue.ToString(),cmbMaKH.SelectedValue.ToString(),cmbMaPHong.SelectedValue.ToString()
                        //     ,Convert.ToDateTime(dateNgayDangKy.Value.ToString()),Convert.ToDateTime(dateTimeNgayNhan.Value.ToString()));



                    }

                }  
                else
                {
                    MessageBox.Show("Phiếu thuê đã tồn tại hoặc bạn chưa nhập đẩy đủ thông tin ?", "", MessageBoxButtons.OK);

                }    
              

            }
           else if(i==2)
            {
                HoaDon hoaDon = dt.HoaDons.Where(s => s.MaPhieuThue == txtMaPhieuThue.Text).FirstOrDefault();
                if(hoaDon==null)
                {
                  

                        DialogResult xoa = MessageBox.Show("Bạn có muốn sửa không?", "", MessageBoxButtons.YesNo);
                        if (xoa == DialogResult.Yes)
                        {

                            dt.update_PhieuThue(txtMaPhieuThue.Text, comboMaNV.SelectedValue.ToString(),
                                cmbMaKH.SelectedValue.ToString(), Convert.ToInt32
                                (txtSoNguoiO.Text), comboBox1.Text);
                            dt.update_CTPhieuThue1(Convert.ToInt32(txtMaChiTiet.Text), txtMaPhieuThue.Text, cmbMaPHong.SelectedValue.ToString(), Convert.ToDateTime
                                 (dateNgayDangKy.Value.ToString()), Convert.ToDateTime(dateTimeNgayNhan.Value.ToString()));
                            // dt.UpdateThemPhieuDangKi(Convert.ToInt32(txtMaChiTiet.Text), txtMaPhieuThue.Text,cmbMaPHong.SelectedValue.ToString()
                            //  ,Convert.ToDateTime(dateNgayDangKy.Value.ToString()), Convert.ToDateTime(dateTimeNgayNhan.Value.ToString()));

                            MessageBox.Show("Sủa Thành Công");


                        }

                    
                   

                   


                }
                else
                {
                    MessageBox.Show("Không Sửa Được","Thông báo !",MessageBoxButtons.OK);

                }





            }
            PhieuDangKi_User_Load(sender, e);

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            PhieuDangKi_User_Load(sender, e);
            

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            clickSua();
            txtSoNguoiO.Enabled = true;
            comboBox1.Enabled = true;
            txtMaPhieuThue.Enabled = false;
            comboMaNV.Enabled = false;

            cmbMaPHong.Enabled = true;
            cmbMaKH.Enabled = true;
            comboMaNV.Enabled = true;
            dateTimeNgayNhan.Enabled = true;
            dateNgayDangKy.Enabled = true;
        }

        public static int machitiet;
        private void dtPhieuDangKi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dtPhieuDangKi.CurrentRow.Index;

            machitiet = Convert.ToInt32(dtPhieuDangKi.Rows[i].Cells[0].Value.ToString());

            txtMaChiTiet.Text= dtPhieuDangKi.Rows[i].Cells[0].Value.ToString();
            string maphieu = dtPhieuDangKi.Rows[i].Cells[1].Value.ToString();
            txtMaPhieuThue.Text = maphieu;
            cmbMaPHong.Text = dtPhieuDangKi.Rows[i].Cells[2].Value.ToString();
            dateNgayDangKy.Text = dtPhieuDangKi.Rows[i].Cells[3].Value.ToString();
            dateTimeNgayNhan.Text = dtPhieuDangKi.Rows[i].Cells[4].Value.ToString();

            var phieu = dt.PhieuThuePhongs.Where(p => p.MaPhieuThue == maphieu).FirstOrDefault();
            if(phieu!=null)
            {
                cmbMaKH.Text = phieu.MaKhachHang;
                txtSoNguoiO.Text = phieu.SoNguoi.ToString();
                comboBox1.Text = phieu.KhachNuocNgoai;
                cmbMaKH.SelectedValue = phieu.MaKhachHang;
                comboMaNV.SelectedValue = phieu.MaNhanVien;

            }    
           
            



        }

        private void btnMaKH_Click(object sender, EventArgs e)
        {
            FormKhachHang formKhachHang = new FormKhachHang();
            formKhachHang.ShowDialog();
            PhieuDangKi_User_Load(sender, e);
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            FormNhanVien formNhanVien = new FormNhanVien();
            formNhanVien.ShowDialog();
            PhieuDangKi_User_Load(sender, e);
        }

        private void ã(object sender, EventArgs e)
        {

        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void cmbMaPHong_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSoNguoiO.Enabled = true;
            try
            {
                Database.Phong phong = dt.Phongs.Where(p => p.MaPhong == cmbMaPHong.SelectedValue.ToString()).FirstOrDefault();

                Database.LoaiPhong loaiPhong = dt.LoaiPhongs.Where(p => p.MaLoaiPhong == phong.MaloaiPhong).FirstOrDefault();

                txtSoNguoiO.Maximum = Convert.ToInt32(loaiPhong.SoNguoiToiDa);
            }
            catch (Exception)
            {
               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtSoPhieuDang.Text=="")
            {
                dtPhieuDangKi.DataSource = dt.CT_PhieuThues.ToList();

            }   
            else
            {
                dtPhieuDangKi.DataSource = dt.CT_PhieuThues.Where(s => s.SoPhieuThue == Convert.ToInt32(txtSoPhieuDang.Text)).ToList();

            }    

           

            
           
            //var data = dt.CT_PhieuThues.Where(s => s.SoPhieuThue == txtSoPhieuDang.Text).
        }

        private void txtSoPhieuDang_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FormPhieuDangKy f = new FormPhieuDangKy();
            f.ShowDialog();
        }
        public void timkiem(string s)
        {
            dtPhieuDangKi.DataSource = dt.seaching_PhieuDK(s);
        }

        private void txtSoPhieuDang_TextChanged_1(object sender, EventArgs e)
        {
            timkiem(txtSoPhieuDang.Text.Trim());
        }

        private void txtSoPhieuDang_Click(object sender, EventArgs e)
        {
            txtSoPhieuDang.Text = "";
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {

        }

        private void txtSoNguoiO_ValueChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FormPhieuDangKy formPhieuDangKy = new FormPhieuDangKy();
            formPhieuDangKy.ShowDialog();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            if(txtMaChiTiet.Text==""||txtMaPhieuThue.Text=="")
            {
                MessageBox.Show("Bạn chưa chọn đúng phiếu xóa !");
            }    
            else
            {


                HoaDon hoaDon = dt.HoaDons.FirstOrDefault(s => s.MaPhieuThue == txtMaPhieuThue.Text);
                if(hoaDon!=null)
                {
                    MessageBox.Show(" Không được xóa !");
                } 
                else
                {
                    DanhSachDichVu danhSachDichVu = dt.DanhSachDichVus.Where(s => s.SoPhieuThue == Convert.ToInt32(txtMaChiTiet.Text)).FirstOrDefault();
                    if(danhSachDichVu!=null)
                    {
                        MessageBox.Show("Hiện tại khách đang ở tại khách sạn và đã sử dụng dịch vụ, không thể xóa !", "Thông Báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        DialogResult xoa = MessageBox.Show("bạn có muốn xóa không?", "", MessageBoxButtons.YesNo);
                        if (xoa == DialogResult.Yes)
                        {
                            string maphong;
                            maphong = cmbMaPHong.Text;
                            dt.delete_PhieuDk(Convert.ToInt32(txtMaChiTiet.Text), txtMaPhieuThue.Text);

                            // maphong = cmbMaPHong.Text;
                            dt.update_Phong(maphong, "TT4", null);

                        }

                    }
                  
                       


                }    
               

            }    
           
            PhieuDangKi_User_Load(sender, e);
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
