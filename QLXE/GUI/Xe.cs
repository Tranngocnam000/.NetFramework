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
    public partial class Xe : Form
    {
        BUS_XE xe = new BUS_XE();
        BUS_LOAIXE loai = new BUS_LOAIXE();
        DataTable dgvloai;
        int id;
        public Xe()
        {
            InitializeComponent();
            dgvloai = loai.getLoai();
        }

        private void Xe_Load(object sender, EventArgs e)
        {
            for(int i=0; i < dgvloai.Rows.Count; i++)
            {
                cmbloai.Items.Add(dgvloai.Rows[i]["TenLoai"]);
                cmbloai.Text = dgvloai.Rows[0]["TenLoai"].ToString();
            }
            string MaLoai = dgvloai.Rows[int.Parse(cmbloai.SelectedIndex.ToString())]["MaLoai"].ToString();
            dgvXe.DataSource = xe.getxe();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            TrangChu home = new TrangChu();
            home.Show();
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ma = dgvloai.Rows[int.Parse(cmbloai.SelectedIndex.ToString())]["MaLoai"].ToString();
            int maloai = int.Parse(ma);         
            int gt = int.Parse(txtgt.Text);
            int sg = int.Parse(txtsg.Text);
            if (txtten.Text != "" && txtbs.Text != "" && txttt.Text != "")
            {
                if (xe.ThemXe(txtten.Text, txtbs.Text, txttt.Text, gt, maloai, sg))
                {
                    MessageBox.Show("Thêm thành công!");
                    dgvXe.DataSource = xe.getxe();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
            else MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            dgvXe.DataSource = xe.TimXe(txttim.Text);
        }

        private void dgvXe_Click(object sender, EventArgs e)
        {
            int i = dgvXe.CurrentRow.Index;
            id = int.Parse(dgvXe[0, i].Value.ToString());
            txtten.Text = dgvXe[1, i].Value.ToString();
            cmbloai.SelectedItem = dgvXe[2, i].Value.ToString();
            txtbs.Text = dgvXe[3, i].Value.ToString();
            txttt.Text = dgvXe[4, i].Value.ToString();
            txtgt.Text = dgvXe[5, i].Value.ToString();
            txtsg.Text = dgvXe[6, i].Value.ToString();
            txtten.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (xe.XoaXe(id))
            {
                MessageBox.Show("Xóa thành công!");
                dgvXe.DataSource = xe.getxe();
            } MessageBox.Show("Xóa thất bại!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtten.Text != "" && txtbs.Text != "" && txttt.Text != "" && txtgt.Text != "" && txtsg.Text != "" && cmbloai.Text!="")
            {
                string ma = dgvloai.Rows[int.Parse(cmbloai.SelectedIndex.ToString())]["MaLoai"].ToString();
                int maloai = int.Parse(ma);
                int gt = int.Parse(txtgt.Text);
                int sg = int.Parse(txtsg.Text);

                if (xe.SuaXe(id, txtten.Text, txtbs.Text, txttt.Text, gt, maloai, sg))
                {
                    MessageBox.Show("Sửa thành công!");
                    dgvXe.DataSource = xe.getxe();
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
    }
}
