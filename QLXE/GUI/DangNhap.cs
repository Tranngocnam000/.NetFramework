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
    public partial class DangNhap : Form
    {
        BUS_DANGNHAP dn = new BUS_DANGNHAP();
        public static string id_user = "";
        public DangNhap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btndn_Click(object sender, EventArgs e)
        {
            id_user = dn.getID(txttk.Text, txtmk.Text);
            if (id_user != "")
            {
                MessageBox.Show("Đăng nhập thành công!");
                TrangChu home = new TrangChu();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tài khoảng và mật khẩu không đúng!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DangKy dk = new DangKy();
            dk.Show();
            //this.Close();
        }
    }
}
