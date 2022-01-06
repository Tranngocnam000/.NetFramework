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
    public partial class GiaoDich : Form
    {
        BUS_GIAODICH gd = new BUS_GIAODICH();
        BUS_KHACHHANG kh = new BUS_KHACHHANG();
        BUS_XE xe = new BUS_XE();
        DataTable dgvkh;
        DataTable dgvxe;
        int id;
        public GiaoDich()
        {
            dgvkh = kh.getkhachhang();
            dgvxe = xe.getxe();
            InitializeComponent();
        }
        private void GiaoDich_Load(object sender, EventArgs e)
        {
            for(int i=0; i<dgvxe.Rows.Count;i++)
            {
                cmbtenxe.Items.Add(dgvxe.Rows[i]["TenXe"]);
                cmbtenxe.Text = dgvxe.Rows[0]["TenXe"].ToString();
            }
            
            for(int i=0; i <dgvkh.Rows.Count; i++)
            {
                cmbtenkh.Items.Add(dgvkh.Rows[i]["TenKhachHang"]);
                cmbtenkh.Text = dgvkh.Rows[0]["TenKhachHang"].ToString();
            }
            dgvgd.DataSource = gd.getgd();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            TrangChu home = new TrangChu();
            home.Show();
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string Maxe = dgvxe.Rows[int.Parse(cmbtenxe.SelectedIndex.ToString())]["MaXe"].ToString();
            string Makh = dgvkh.Rows[int.Parse(cmbtenkh.SelectedIndex.ToString())]["MaKhachHang"].ToString();
            DateTime ngaybatdau = dtpbatdau.Value;
            DateTime ngayketthuc = dtpketthuc.Value;
            int songaythue = (ngayketthuc - ngaybatdau).Days;
            if (songaythue > 0)
            {
                if (Makh != "" && Maxe != "" && ngaybatdau.Date != null && ngayketthuc.Date != null)
                {
                    if (gd.Suagd(id, int.Parse(Makh), int.Parse(Maxe), ngaybatdau, ngayketthuc))
                    {
                        MessageBox.Show("Sửa giao dịch thành công");
                        dgvgd.DataSource = gd.getgd();
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại");
                    }
                }
                else MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else MessageBox.Show("Nhập ngày không hợp lệ!");
            
            
        }

        private void dgvgd_Click(object sender, EventArgs e)
        {
            int i = dgvgd.CurrentRow.Index;
            id = int.Parse(dgvgd[0, i].Value.ToString());
            cmbtenkh.SelectedItem = dgvgd[1, i].Value.ToString();
            cmbtenxe.SelectedItem = dgvgd[2, i].Value.ToString();
            dtpbatdau.Text = dgvgd[3, i].Value.ToString();
            dtpketthuc.Text = dgvgd[4, i].Value.ToString();
        } 

        private void btnThem_Click(object sender, EventArgs e)
        {
            string Maxe = dgvxe.Rows[int.Parse(cmbtenxe.SelectedIndex.ToString())]["MaXe"].ToString();
            string Makh = dgvkh.Rows[int.Parse(cmbtenkh.SelectedIndex.ToString())]["MaKhachHang"].ToString();
            DateTime ngaybatdau = dtpbatdau.Value;
            DateTime ngayketthuc = dtpketthuc.Value;
            int songaythue = (ngayketthuc - ngaybatdau).Days;
            if (songaythue > 0)
            {
                if (Makh != "" && Maxe != "" && ngaybatdau.Date != null && ngayketthuc.Date != null)
                {
                    if (gd.Themgd(int.Parse(Makh), int.Parse(Maxe), ngaybatdau, ngayketthuc))
                    {
                        MessageBox.Show("Thêm giao dịch thành công");
                        dgvgd.DataSource = gd.getgd();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại");
                    }
                }
                else MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else MessageBox.Show("Nhập ngày không hợp lệ");  
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (gd.Xoagd(id))
            {
                MessageBox.Show("Xóa thành công");
                dgvgd.DataSource = gd.getgd();
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txttim.Text != "")
            {
                dgvgd.DataSource = gd.Timgd(txttim.Text);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm");
            }
        }

        private void btnTaomoi_Click(object sender, EventArgs e)
        {
            TaoMoiGD tmgd = new TaoMoiGD();
            tmgd.Show();
        }

        private void btnin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tên khách hàng: " + id
                +"dnskldnad"+12);
        }
    }
}
