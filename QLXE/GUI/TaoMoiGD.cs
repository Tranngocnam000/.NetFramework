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
    public partial class TaoMoiGD : Form
    {
        BUS_KHACHHANG kh = new BUS_KHACHHANG();
        BUS_XE xe = new BUS_XE();
        BUS_GIAODICH gd = new BUS_GIAODICH();
        DataTable dgvxe;
        DataTable dgvkh;
        public TaoMoiGD()
        {
            InitializeComponent();
            dgvxe = xe.getxe();
            dgvkh = kh.getkhachhang();
        }

        private void btnxn_Click(object sender, EventArgs e)
        {
            if(txtten.Text!="" && txtdiachi.Text != "" && txtsdt.Text != "" && txtscmnd.Text != "" && txtblx.Text != "")
            {
                kh.ThemKhachHang(txtten.Text, txtdiachi.Text, txtsdt.Text, txtscmnd.Text, txtblx.Text);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            string Maxe = dgvxe.Rows[int.Parse(cmbxe.SelectedIndex.ToString())]["MaXe"].ToString();
            int Makh = kh.getid(txtten.Text);
            DateTime ngaybatdau = dptbatdau.Value;
            DateTime ngayketthuc = dptketthuc.Value;
            int songaythue = (ngayketthuc - ngaybatdau).Days;
            if (songaythue > 0)
            {
                if (gd.Themgd(Makh, int.Parse(Maxe), ngaybatdau, ngayketthuc))
                {
                    MessageBox.Show("Tạo mới giao dịch thành công");
                }
                else
                {
                    MessageBox.Show("Tạo mới giao dịch thất bại", Maxe);
                }
            }
            else MessageBox.Show("Vui lòng chọn lại ngày");
        }

        private void TaoMoiGD_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvxe.Rows.Count; i++)
            {
                cmbxe.Items.Add(dgvxe.Rows[i]["TenXe"]);
                cmbxe.Text = dgvxe.Rows[0]["TenXe"].ToString();
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
