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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void dangki_Click(object sender, EventArgs e)
        {
            dangki f=new dangki();
            f.ShowDialog();

        }
        private void quenmatkhau_Click(object sender, EventArgs e)
        {
            quenmatkhau f = new quenmatkhau();
            f.ShowDialog();

        }
        private void dangnhap_Click(object sender, EventArgs e)
        {
            giaodien f = new giaodien();
            this.Hide();
            f.ShowDialog();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có thật sự muốn thoát chương trình?","Thông báo",MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
