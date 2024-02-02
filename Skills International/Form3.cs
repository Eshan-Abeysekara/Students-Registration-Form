using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Skills_International
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        
        private void Form3_Load(object sender, EventArgs e)
        {
            Display();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-BQVD19L\\SQLEXPRESS01;Initial Catalog=Students;Integrated Security=True");

        public void Display()
        {
            SqlCommand command = new SqlCommand("select * from Registration", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dg.DataSource= dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Display();
        }
    }
}
