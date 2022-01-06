using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using BUS;

namespace GUI
{
    public partial class LoaiXe : Form
    {
        BUS_LOAIXE loai = new BUS_LOAIXE();
        int id;
        public LoaiXe()
        {
            InitializeComponent();
        }

        private void LoaiXe_Load(object sender, EventArgs e)
        {
            dgvloai.DataSource = loai.getLoai();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            TrangChu home = new TrangChu();
            home.Show();
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtten.Text != "" )
            {
                if (loai.ThemLoai(txtten.Text))
                {
                    MessageBox.Show("Thêm thành công!");
                    dgvloai.DataSource = loai.getLoai();
                    ;
                }
                else
                {
                    MessageBox.Show("Thêm thất bại ");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập loại xe!");
            }
        }

        private void dgvloai_Click(object sender, EventArgs e)
        {
            int i = dgvloai.CurrentRow.Index;
            id = int.Parse(dgvloai[0, i].Value.ToString());
            txtten.Text = dgvloai[1, i].Value.ToString();
            txtten.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (loai.XoaLoai(id))
            {
                MessageBox.Show("Xóa thành công!");
                dgvloai.DataSource = loai.getLoai();
            }
            MessageBox.Show("Xóa thất bại!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtten.Text != "")
            {
                if (loai.SuaLoai(id,txtten.Text))
                {
                    MessageBox.Show("Sửa thành công!");
                    dgvloai.DataSource = loai.getLoai();
                    ;
                }
                else
                {
                    MessageBox.Show("Sửa thất bại ");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            dgvloai.DataSource = loai.TimLoai(txtTim.Text);
        }
    }
}
