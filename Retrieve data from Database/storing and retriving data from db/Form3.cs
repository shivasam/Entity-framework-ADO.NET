using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace storing_and_retriving_data_from_db
{
    public partial class Form3 : Form
    {
        
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(Control x in this.Controls)
            {
                if(x is TextBox)
                {
                    x.Text = "";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            if (textBox1.Text == string.Empty && textBox2.Text == string.Empty && textBox3.Text == string.Empty && textBox4.Text == string.Empty)
            {
                MessageBox.Show("Enter the values");
            }
            else if (textBox1.Text.Length < 5)
            {
                MessageBox.Show("Username length should be minimum 6 characters");
            }
            else if (textBox2.Text.Length < 5)
            {
                
                MessageBox.Show("mail length should be minimum 6 characters");
            }
            else if (textBox3.Text.Length < 5)
            {

                MessageBox.Show("Password length should be minimum 6 characters");
            }
            else if (textBox4.Text != textBox3.Text)
            {

                MessageBox.Show("Password didn't matched");
            }
            else
            {
                SqlConnection con = new SqlConnection("data source = Shiva-Jaligama\\SQLEXPRESS; database = Sample; integrated security = SSPI");
                SqlCommand sc = new SqlCommand("insert into info values('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "')", con);
                con.Open();
                int i = sc.ExecuteNonQuery();
                MessageBox.Show(i + "successfully created");
                con.Close();

                Form2 f2 = new Form2();
                f2.Show();
                Hide();
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
