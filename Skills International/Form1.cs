using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skills_International
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uname.Text = "";
            psw.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (uname.Text == "Admin" && psw.Text =="Skills@123")
            {
                Form2 frm2 = new Form2();
                this.Hide();
                frm2.Show();
            }
            else
            {
                MessageBox.Show("Incorrect User Name Or Password........!!!");
            }
        }
    }
}
