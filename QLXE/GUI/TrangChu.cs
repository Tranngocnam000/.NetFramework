using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            kh.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Xe xe = new Xe();
            xe.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoaiXe xe = new LoaiXe();
            xe.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GiaoDich gd = new GiaoDich();
            gd.Show();
            this.Close();
        }
    }
}
