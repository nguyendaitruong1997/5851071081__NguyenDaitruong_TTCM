using QUANLYKHACHSAN.User;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace QUANLYKHACHSAN
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
           

        }
        
       
        //private NguoiDungInFo m_NguoiDung= new NguoiDungInFo();

        //public NguoiDungInFo NguoiDung
        //{
        //    get { return m_NguoiDung; }
        //    set { m_NguoiDung = value; }
        //}

        private void frmMain_Load(object sender, EventArgs e)
        {
           
            Default();
          
            //  btnDoanhThu.Enabled = false;



            FormDangNhap formDangNhap = new FormDangNhap();
            if(formDangNhap.i==1)

            {
                Admin();//nghe chưa
               // nghnghe 
           // nghe chưanghe
              //  btnDangNhap.Enabled = false;
            } 
            else if(formDangNhap.i==2)
            {
                User();
               // btnDangNhap.Enabled = false;
            }
          //  btnDangNhap.Enabled = false;
           //mic nghe kko nghe

            
            
         
             
            //ds.ShowDialog();
        }

       
        

       
        public void DoiMatKhau()
        {
        
        }

     
        
        private void buttonDangKy_Click(object sender, EventArgs e)
        {
            KhachHangUser hangUser = new KhachHangUser();
            panel1.Controls.Clear();
            panel1.Controls.Add(hangUser);
           

        }        

        private void ToolStripMenuItemDangKy_Click(object sender, EventArgs e)
        {
           
        }

        private void ToolStripMenuItemNhanPhong_Click(object sender, EventArgs e)
        {
           
        }

        private void ToolStripMenuItemTraPhong_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonDichVu_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonPhong_Click(object sender, EventArgs e)
        {
            UserPhong hangUser = new UserPhong();
            panel1.Controls.Clear();
            panel1.Controls.Add(hangUser);
        }

        private void btnThietBiTrongPhong_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonDoiMatKhau_Click(object sender, EventArgs e)
        {

            DoiMatKhauUser hangUser = new DoiMatKhauUser();
            panel1.Controls.Clear();
            panel1.Controls.Add(hangUser);
        }

        private void buttonDangXuat_Click(object sender, EventArgs e)
        {
            Default();
        }

        private void toolStripThemPhong_Click(object sender, EventArgs e)
        {
           
        }

        public void Default()
        {
            btnDangNhap.Enabled = true;
            btnDangXuat.Enabled = false;
            btnDoiMatKhau.Enabled = false;
            btnNguoiDung.Enabled = false;
            btnNhanVien.Enabled = false;
            btnKhachHang.Enabled = false;
            btnDangKi.Enabled = false;
            btnnTraPhong.Enabled = false;
            btnPhong.Enabled = false;
            btnKHDangKy.Enabled = false;
            btnKHNhanPhong.Enabled = false;
            btnLoaiPhong.Enabled = false;
            btnDoanhThu.Enabled = false;
            btnQuiDinh.Enabled = false;



            //this.buttonTraPhong.Enabled = false;
            //this.toolStripThemPhong.Enabled = false;
            //this.ToolStripMenuItemTraPhong.Enabled = false;
            //this.ToolStripMenuItemNhanPhong.Enabled = false;
            //this.ToolStripMenuItemDangKy.Enabled = false;
            //this.ToolStripCapNhat.Enabled = false;
        }


        public void Admin()
        {
            btnQuanLy.Enabled = true;
            btnDoanhMuc.Enabled = true;
            btnThongKe.Enabled = true;
            btnTroGiup.Enabled = true;


            btnDangNhap.Enabled = false;
            btnDangXuat.Enabled = true;
            btnDoiMatKhau.Enabled = true;
            btnNguoiDung.Enabled = true;
            btnNhanVien.Enabled = true;
            btnKhachHang.Enabled = true;
            btnDangKi.Enabled = true;
            btnnTraPhong.Enabled = true;
            btnPhong.Enabled = true;
            btnKHDangKy.Enabled = true;
            btnKHNhanPhong.Enabled = true;
            btnLoaiPhong.Enabled = true;
            btnDoanhThu.Enabled = true;
            btnQuiDinh.Enabled = true;


            


            //this.buttonTraPhong.Enabled = true;
            //this.toolStripThemPhong.Enabled = true;
            //this.ToolStripMenuItemTraPhong.Enabled = true;
            //this.ToolStripMenuItemNhanPhong.Enabled = true;
            //this.ToolStripMenuItemDangKy.Enabled = true;
            //this.ToolStripCapNhat.Enabled = true;

        }

        public void User()
        {
            btnDangNhap.Enabled = false;
            btnDangXuat.Enabled = true;
            btnDoiMatKhau.Enabled = true;
            btnNguoiDung.Enabled = false;
            btnNhanVien.Enabled = false;
            btnKhachHang.Enabled = true;
            btnDangKi.Enabled = true;
            btnnTraPhong.Enabled = true;
            btnPhong.Enabled = true;
            btnKHDangKy.Enabled = true;
            btnKHNhanPhong.Enabled = true;
            btnLoaiPhong.Enabled = true;
            btnDoanhThu.Enabled = true;
            btnQuiDinh.Enabled = true;


            btnQuanLy.Enabled = true;
            btnDoanhMuc.Enabled = true;
            btnThongKe.Enabled = true;
            btnTroGiup.Enabled = true;



            //this.buttonTraPhong.Enabled = true;
            //this.toolStripThemPhong.Enabled = false;
            //this.ToolStripMenuItemTraPhong.Enabled = true;
            //this.ToolStripMenuItemNhanPhong.Enabled = true;
            //this.ToolStripMenuItemDangKy.Enabled = true;
            //this.ToolStripCapNhat.Enabled = false;
        }

        private void buttonNguoiDung_Click(object sender, EventArgs e)
        {
            
            DanhSachNguoiDungUser hangUser = new DanhSachNguoiDungUser();
            panel1.Controls.Clear();
            panel1.Controls.Add(hangUser);
             
        }

        private void buttonKHDangKy_Click(object sender, EventArgs e)
        {
            DanhSachKhachHangDangKiThuePhong_User hangUser = new DanhSachKhachHangDangKiThuePhong_User();
            panel1.Controls.Clear();
            panel1.Controls.Add(hangUser);
        }

        private void buttonKHNhanPhong_Click(object sender, EventArgs e)
        {
            DanhSachKhachHangNhanPhongUser hangUser = new DanhSachKhachHangNhanPhongUser();
            panel1.Controls.Clear();
            panel1.Controls.Add(hangUser);
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
          /*  HoaDonUser hangUser = new HoaDonUser();
            panel1.Controls.Clear();
            panel1.Controls.Add(hangUser);*/
        }

        private void ToolStripCapNhat_Click(object sender, EventArgs e)
        {
               

        }

        private void buttonQuiDinh_Click(object sender, EventArgs e)
        {
            QuyDinhUser hangUser = new QuyDinhUser();
            panel1.Controls.Clear();
            panel1.Controls.Add(hangUser);
        }

        private void buttonThongTin_Click(object sender, EventArgs e)
        {
            
        }

        private void listViewEx1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       
      
      
        private void buttonItemLoaiPhong_Click(object sender, EventArgs e)
        {
            LoaiPhongUser hangUser = new LoaiPhongUser();
            panel1.Controls.Clear();
            panel1.Controls.Add(hangUser);
        }

        private void buttonItemLoaiDVu_Click(object sender, EventArgs e)
        {
            LoaiDIchVuUser hangUser = new LoaiDIchVuUser();
            panel1.Controls.Clear();
            panel1.Controls.Add(hangUser);
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            BaoCaoDoanhThuUser hangUser = new BaoCaoDoanhThuUser();
            panel1.Controls.Clear();
            panel1.Controls.Add(hangUser);
        }

        private void buttonItem16_Click(object sender, EventArgs e)
        {

           // PhieuNhanPhongUser hangUser = new PhieuNhanPhongUser();
           // panel1.Controls.Clear();
           // panel1.Controls.Add(hangUser);
        }



        private void buttonHuongDan_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem17_Click(object sender, EventArgs e)
        {

            ChiTietHoaDon_User hangUser = new ChiTietHoaDon_User();
            panel1.Controls.Clear();
            panel1.Controls.Add(hangUser);
        }

        private void buttonItem33_Click(object sender, EventArgs e)
        {


            dangNhap();
           



        }
        private void dangNhap()

        {
            
            FormDangNhap formDangNhap= new FormDangNhap();
            formDangNhap.ShowDialog();
            if (formDangNhap.i == 1)
            {
                Admin();
            }
            else if(formDangNhap.i==2)
            {
                User();
            }

        }
       

        private void buttonItem15_Click(object sender, EventArgs e)
        {

            PhieuDangKi_User hangUser = new PhieuDangKi_User();
            panel1.Controls.Clear();
            panel1.Controls.Add(hangUser);
        }

        private void buttonItem18_Click(object sender, EventArgs e)
        {

        }



        private void ribbonBar2_ItemClick(object sender, EventArgs e)
        {

        }
        private void buttonItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonDangKy_MouseHover(object sender, EventArgs e)
        {

        }

        private void buttonDangKy_DoubleClick(object sender, EventArgs e)
        {
            btnDangKy.BackColor = Color.Red;
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            NhanVienUser dangKiNhanPhong = new NhanVienUser();
            panel1.Controls.Clear();
            panel1.Controls.Add(dangKiNhanPhong);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
        }

        private void ribbonControl2_Click(object sender, EventArgs e)
        {


        }

        private void buttonItem16_Click_1(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/nuguyendaitruong");
        }
    }
}