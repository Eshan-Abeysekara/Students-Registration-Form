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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Skills_International
{
    public partial class Form2 : Form
    {
        private const string ConnectionString = "Data Source=DESKTOP-BQVD19L\\SQLEXPRESS01;Initial Catalog=Students;Integrated Security=True";
        public Form2()
        {
            InitializeComponent();
            ComboBox();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            this.Hide();
            fm.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }


        SqlConnection con = new SqlConnection("Data Source=DESKTOP-BQVD19L\\SQLEXPRESS01;Initial Catalog=Students;Integrated Security=True");

        private void button4_Click(object sender, EventArgs e)
        {
            if (rb1.Checked == true)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Registration (firstName, lastName, dateOfBirth, gender, address, email, mobilePhone, homePhone, parentName, nic, contactNo) VALUES (@fname, @lname, @dob, @sex, @add, @em, @mobile, @home, @pname, @nicno, @cono)", con);

                cmd.Parameters.AddWithValue("@fname", fname.Text);
                cmd.Parameters.AddWithValue("@lname", lname.Text);
                cmd.Parameters.AddWithValue("@dob", dob.Value.Date);
                cmd.Parameters.AddWithValue("@sex", rb1.Text);
                cmd.Parameters.AddWithValue("@add", add.Text);
                cmd.Parameters.AddWithValue("@em", em.Text);
                cmd.Parameters.AddWithValue("@mobile", int.Parse(mobile.Text));
                cmd.Parameters.AddWithValue("@home", int.Parse(home.Text));
                cmd.Parameters.AddWithValue("@pname", pname.Text);
                cmd.Parameters.AddWithValue("@nicno", nicno.Text);
                cmd.Parameters.AddWithValue("@cono", cono.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Success");
                con.Close();

            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Registration (firstName, lastName, dateOfBirth, gender, address, email, mobilePhone, homePhone, parentName, nic, contactNo) VALUES (@fname, @lname, @dob, @sex, @add, @em, @mobile, @home, @pname, @nicno, @cono)", con);

                cmd.Parameters.AddWithValue("@fname", fname.Text);
                cmd.Parameters.AddWithValue("@lname", lname.Text);
                cmd.Parameters.AddWithValue("@dob", dob.Value.Date);
                cmd.Parameters.AddWithValue("@sex", rb2.Text);
                cmd.Parameters.AddWithValue("@add", add.Text);
                cmd.Parameters.AddWithValue("@em", em.Text);
                cmd.Parameters.AddWithValue("@mobile", int.Parse(mobile.Text));
                cmd.Parameters.AddWithValue("@home", int.Parse(home.Text));
                cmd.Parameters.AddWithValue("@pname", pname.Text);
                cmd.Parameters.AddWithValue("@nicno", nicno.Text);
                cmd.Parameters.AddWithValue("@cono", cono.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Success");
                con.Close();


            }
        }
        private void button7_Click(object sender, EventArgs e)
        {

        }
       private void button5_Click(object sender, EventArgs e)
        {

        }
        private void clear()
        {
            fname.Text = "";
            lname.Text = "";
            add.Text = "";
            em.Text = "";
            mobile.Text = "";
            home.Text = "";
            pname.Text = "";
            nicno.Text = "";
            cono.Text = "";
       }

        private void button1_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void regno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            this.Hide();
            frm3.Show();
        }

        private void ComboBox()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT regNo FROM Registration";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Assuming your ID column is of integer type
                    regno.DataSource = dataTable;
                    regno.DisplayMember = "regNo";
                    regno.ValueMember = "regNo";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


    }
}



