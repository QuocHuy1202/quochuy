using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class giaodien : Form
    {
        public giaodien()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void quanlitaikhoan_Click(object sender, EventArgs e)
        {
            quanlitaikhoan f = new quanlitaikhoan();
            this.Hide();
            f.ShowDialog();
            this.Show();

        }
        private void benhnhan_Click(object sender, EventArgs e)
        {
            benhnhan f = new benhnhan();

            this.Hide();
            f.ShowDialog();
            this.Show();


        }
        private void thietbiyte_Click(object sender, EventArgs e)
        {
            thietbiyte f = new thietbiyte();
            this.Hide();
            f.ShowDialog();
            this.Show();

        }
        private void nhanvienyte_Click(object sender, EventArgs e)
        {
            nhanvienyte f = new nhanvienyte();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

    }
}
