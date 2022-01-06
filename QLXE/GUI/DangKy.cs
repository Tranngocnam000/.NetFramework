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
    public partial class DangKy : Form
    {
        BUS_DANGKY kh = new BUS_DANGKY();
        public DangKy()
        {
            InitializeComponent();
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            DangNhap dn = new DangNhap();
            dn.Show();
            this.Hide();
        }

        private void btnxacnhan_Click(object sender, EventArgs e)
        {
            if(txttdn.Text != "" && txtmk.Text !="" && txtxnmk.Text != "")
            {
                if (txtmk.Text == txtxnmk.Text)
                {
                    if (kh.DangKy(txttdn.Text, txtmk.Text))
                    {
                        MessageBox.Show("Đăng ký thành công");
                        DangNhap dn = new DangNhap();
                        dn.Show();
                        this.Hide();
                    }
                    else MessageBox.Show("Đăng ký thất bại");
                }
                else MessageBox.Show("Mật khẩu không trùng khớp");
            } MessageBox.Show("Vui lòng điền đủ thông tin");
        }
    }
}
