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

namespace storing_and_retriving_data_from_db
{
    public partial class Form2 : Form
    {
        SqlDataReader dr;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source = Shiva-Jaligama\\SQLEXPRESS; database = Sample; integrated security = SSPI");
            SqlCommand sc = new SqlCommand("select * from info where username = '" + textBox1.Text + "' and passwrd = '" + textBox2.Text + "'", con);
            con.Open();
            dr = sc.ExecuteReader();

            if (textBox1.Text == string.Empty && textBox2.Text == string.Empty)
            {
                MessageBox.Show("enter the values");

            }
            else if(textBox1.Text.Length<5 && textBox1.MaxLength >= 8)
            {
                MessageBox.Show("Username length should be min 6 and max 8 characters");
            }
            else if(textBox2.Text.Length<5)
            {
                MessageBox.Show("Password length should be min 6 and max 8 characters");
            }
            if (dr.Read() == true)
            {
                MessageBox.Show("Thank you for loggin in");
            }
            else
            {
                MessageBox.Show("Login failed");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(Control c in this.Controls)
            {
                if(c is TextBox)
                {
                    c.Text = "";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
            Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
    }
}
