﻿using QUANLYKHACHSAN.Database;
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
    public partial class LoaiPhong : Form
    {
       
        public LoaiPhong()
        {
            InitializeComponent();
        }

        public int i = 0;
        DataClasses1DataContext dtt = new DataClasses1DataContext();
        public void seaching_LoaiPg(string s)
        {
            dataLoaiPhong.DataSource = dtt.seaching_loaiPhong(s);
        }
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (i == 1)
            {
                if (txtMaLoaiPhong.Text == "" || txtTenLoaiPhong.Text == "" || (txtDonGia.Text) == "" ||
                   (txtSoNguoiChuan.Text) == "" || (txtSoNguoiToiDa.Text) == "")
                {
                    MessageBox.Show("Bạn hãy nhập đầy đủ thông tin!", "Thông Báo", MessageBoxButtons.OK);

                }
                else
                {
                    var data1 = dtt.LoaiPhongs.Where(s => s.MaLoaiPhong == txtMaLoaiPhong.Text.Trim()).FirstOrDefault();
                    if (data1 == null)
                    {
                        DialogResult xoa = MessageBox.Show("Bạn có muốn Thêm không?", "", MessageBoxButtons.YesNo);
                        if (xoa == DialogResult.Yes)
                        {
                            var data = dtt.ThemLoaiPhongaaaaaa(txtMaLoaiPhong.Text, txtTenLoaiPhong.Text, Convert.ToInt32(txtDonGia.Text), Convert.ToInt32(txtSoNguoiChuan.Text), Convert.ToInt32(txtSoNguoiToiDa.Text));

                            MessageBox.Show("Thêm Thành Công ?", "Thông Báo", MessageBoxButtons.OK);

                        }

                    }
                    else
                    {
                        MessageBox.Show("Đã Có Loại Phòng Này !");
                    }
                      

                }    
               

            }
            else if (i == 2)
            {

                if (txtMaLoaiPhong.Text == "" || txtTenLoaiPhong.Text == "" || (txtDonGia.Text) == "" ||
                   (txtSoNguoiChuan.Text) == "" || (txtSoNguoiToiDa.Text) == "")
                {
                    MessageBox.Show("Bạn hãy nhập đầy đủ thông tin!", "Thông Báo", MessageBoxButtons.OK);

                }
                else
                {
                    DialogResult xoa = MessageBox.Show("Bạn có muốn sửa không?", "Thông Báo!", MessageBoxButtons.YesNo);
                    if (xoa == DialogResult.Yes)
                    {
                        var data = dtt.SuaLoaiPhongaaaaaa(txtMaLoaiPhong.Text, txtTenLoaiPhong.Text, Convert.ToInt32(txtDonGia.Text), Convert.ToInt32(txtSoNguoiChuan.Text), Convert.ToInt32(txtSoNguoiToiDa.Text));
                        MessageBox.Show("Sửa Thành Công ?", "Thông Báo", MessageBoxButtons.OK);

                    }

                }    
               



            }
            LoaiPhongUser_Load(sender, e);
            btnLuu.Enabled = false;



        }

        public void enable()
        {
            txtDonGia.Enabled = false;
            txtMaLoaiPhong.Enabled = false;
            txtSoNguoiChuan.Enabled = false;
            txtSoNguoiToiDa.Enabled = false;
            txtTenLoaiPhong.Enabled = false;
          //  txtTyLeGiaTang.Enabled = false;


        }
        public void notenable()
        {
            txtDonGia.Enabled = true;
            txtMaLoaiPhong.Enabled = true;
            txtSoNguoiChuan.Enabled = true;
            txtSoNguoiToiDa.Enabled = true;
            txtTenLoaiPhong.Enabled = true;
          //  txtTyLeGiaTang.Enabled = true;

        }

        private void LoaiPhongUser_Load(object sender, EventArgs e)
        {
            enable();


            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            txtMaLoaiPhong.Enabled = false;
            dataLoaiPhong.AutoGenerateColumns = false;


            dataLoaiPhong.DataSource = new DataClasses1DataContext().LoaiPhongs.ToList();

            
            
            txtMaLoaiPhong.Text = dataLoaiPhong.Rows[0].Cells[0].Value.ToString();
            txtTenLoaiPhong.Text = dataLoaiPhong.Rows[0].Cells[1].Value.ToString();
            txtDonGia.Text = dataLoaiPhong.Rows[0].Cells[2].Value.ToString();
            txtSoNguoiChuan.Text = dataLoaiPhong.Rows[0].Cells[3].Value.ToString();
            txtSoNguoiToiDa.Text = dataLoaiPhong.Rows[0].Cells[4].Value.ToString();
           // txtTyLeGiaTang.Text = dataLoaiPhong.Rows[0].Cells[5].Value.ToString();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {



            DialogResult xoa = MessageBox.Show("bạn có muốn xóa không?", "", MessageBoxButtons.YesNo);
            if (xoa == DialogResult.Yes)
            {
                var data = dtt.xoaLoaiPhong(txtMaLoaiPhong.Text);

            }
            LoaiPhongUser_Load(sender, e);

        }

        private void toolStripCapNhat_Click(object sender, EventArgs e)
        {
            clickcapnhat();
        }
        public void clickcapnhat()
        {
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            i = 2;
            notenable();
            txtMaLoaiPhong.Enabled = false;
            btnXoa.Enabled = false;
           
        }
        public void clickthem()
        {
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            txtMaLoaiPhong.Enabled = true;
            notenable();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            clickthem();
            reset();
            i = 1;
        }
        public void reset()
        {
            txtMaLoaiPhong.Text = "";
            txtTenLoaiPhong.Text = "";
            txtDonGia.Text = "";
            txtSoNguoiChuan.Text = "";
            txtSoNguoiToiDa.Text = "";
           // txtTyLeGiaTang.Text = "";

        }



        private void toolStripButtonThoat_Click(object sender, EventArgs e)
        {
            LoaiPhongUser_Load(sender, e);

        }

        private void dataLoaiPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataLoaiPhong.CurrentRow.Index;
            txtMaLoaiPhong.Text = dataLoaiPhong.Rows[i].Cells[0].Value.ToString();
            txtTenLoaiPhong.Text = dataLoaiPhong.Rows[i].Cells[1].Value.ToString();
            txtDonGia.Text = dataLoaiPhong.Rows[i].Cells[2].Value.ToString();
            txtSoNguoiChuan.Text = dataLoaiPhong.Rows[i].Cells[3].Value.ToString();
            txtSoNguoiToiDa.Text = dataLoaiPhong.Rows[i].Cells[4].Value.ToString();
         //  txtTyLeGiaTang.Text = dataLoaiPhong.Rows[i].Cells[5].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtTimKiem.Text=="")
            {
                dataLoaiPhong.DataSource = new DataClasses1DataContext().LoaiPhongs.ToList();

            }   
            else
            {
                dataLoaiPhong.DataSource = dtt.LoaiPhongs.Where(s => s.MaLoaiPhong == txtTimKiem.Text).ToList();

            }    
           
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            seaching_LoaiPg(txtTimKiem.Text.Trim());
        }
    }
}