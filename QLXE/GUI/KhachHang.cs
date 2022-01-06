using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace GUI
{
    public partial class KhachHang : Form
    {
        BUS_KHACHHANG kh = new BUS_KHACHHANG();
        int id;
        public KhachHang()
        {
            
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            dgvkh.DataSource = kh.getkhachhang();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txthoten.Text != ""&& txtdiachi.Text != "" && txtsdt.Text != "" && txtcmnd.Text != "" && txtblx.Text != "")
            {
                if (kh.ThemKhachHang(txthoten.Text , txtdiachi.Text , txtsdt.Text , txtcmnd.Text , txtblx.Text))
                {
                    MessageBox.Show("Thêm thành công!");
                    dgvkh.DataSource = kh.getkhachhang();
;
                }
                else
                {
                    MessageBox.Show("Thêm thất bại ");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
        }

        private void dgvkh_Click(object sender, EventArgs e)
        {
            int i = dgvkh.CurrentRow.Index;
            id = int.Parse(dgvkh[0, i].Value.ToString());
            txthoten.Text = dgvkh[1, i].Value.ToString();
            txtdiachi.Text = dgvkh[2, i].Value.ToString();
            txtsdt.Text = dgvkh[3, i].Value.ToString();
            txtcmnd.Text = dgvkh[4, i].Value.ToString();
            txtblx.Text = dgvkh[5, i].Value.ToString();
            txthoten.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (kh.XoaKhachHang(id))
            {
                MessageBox.Show("Xóa thành công!");
                dgvkh.DataSource = kh.getkhachhang();
            }
            MessageBox.Show("Xóa thất bại!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txthoten.Text != "" && txtdiachi.Text != "" && txtsdt.Text != "" && txtcmnd.Text != "" && txtblx.Text != "")
            {
                if (kh.SuaKhachHang(id, txthoten.Text, txtdiachi.Text, txtsdt.Text, txtcmnd.Text, txtblx.Text))
                {
                    MessageBox.Show("Sửa thành công!");
                    dgvkh.DataSource = kh.getkhachhang();
                    ;
                }
                else
                {
                    MessageBox.Show("Sửa thất bại ");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            dgvkh.DataSource = kh.TimKhachHang(txttim.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TrangChu home = new TrangChu();
            home.Show();
            this.Hide();
        }
    }
}
