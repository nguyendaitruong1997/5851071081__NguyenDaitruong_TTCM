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
    public partial class LoaiDichVu : Form
    {
        public LoaiDichVu()
        {
            InitializeComponent();
        }
        DataClasses1DataContext dt = new DataClasses1DataContext();
        private void LoaiDichVu_Load(object sender, EventArgs e)
        {
            dtgLoaiDV.AutoGenerateColumns = false;
            dtgLoaiDV.DataSource = dt.LoaiDVs.ToList();
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnHuy.Enabled = true;
            btnXoa.Enabled = false;
            

           
        }

        private void dtgLoaiDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dtgLoaiDV.CurrentRow.Index;
            txtMaLoaiDV.Text = dtgLoaiDV.Rows[i].Cells[0].Value.ToString();
            txtTenLoaiPhong.Text = dtgLoaiDV.Rows[i].Cells[1].Value.ToString();
            txtDonGia.Text = dtgLoaiDV.Rows[i].Cells[2].Value.ToString();
            btnXoa.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            txtDonGia.Text ="";
            txtMaLoaiDV.Text = "";
            txtTenLoaiPhong.Text = "";
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            LoaiDichVu_Load(sender, e);

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            var data = dt.LoaiDVs.Where(s => s.MaLoaiDV == txtMaLoaiDV.Text).FirstOrDefault();
            if(data ==null)
            {
                DialogResult xoa = MessageBox.Show("bạn có chắc muốn thêm không?", "", MessageBoxButtons.YesNo);
                if (xoa == DialogResult.Yes)
                {
                    dt.themLoaiDV(txtMaLoaiDV.Text, txtTenLoaiPhong.Text, txtDonGia.Text);
                    MessageBox.Show("Thêm thành công?", "", MessageBoxButtons.OK);


                }

            }
            else
            {
                MessageBox.Show("Loại Dịch Vụ Đã Tồn Tại", "", MessageBoxButtons.OK);

            }
         

           
            LoaiDichVu_Load(sender, e);

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DV dV = dt.DVs.Where(s => s.MaLoaiDV == txtMaLoaiDV.Text).FirstOrDefault();
            if(dV!=null)
            {
                MessageBox.Show("Không xóa được !", "", MessageBoxButtons.OK);
            }
            else
            {
                DialogResult xoa = MessageBox.Show("bạn có chắc muốn xóa không?", "", MessageBoxButtons.YesNo);
                if (xoa == DialogResult.Yes)
                {
                    dt.xoaDV(txtMaLoaiDV.Text);
                    MessageBox.Show("xóa thành công?", "", MessageBoxButtons.OK);


                }

            }
        }
    }
}
