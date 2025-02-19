using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gixx2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "Sebe" && txtPass.Text == "Gix")
            {
            FrmMain frmMain = new FrmMain();
            frmMain.Show();
            this.Hide();
            }
            else
            {
                MessageBox.Show("Maaf Bro Anda Salah Input Email atau Password");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
