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
    public partial class Form1 : Form
    {
        SqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source = Shiva-Jaligama\\SQLEXPRESS; database = sample1; integrated security = SSPI");
            //SqlCommand sc = new SqlCommand("insert into gridview values(" + textBox1.Text + ",'" + textBox2.Text + "'," + textBox3.Text + ")", con); //--> Non parameterized
            //SqlCommand sc = new SqlCommand("insert into gridview values(@a1,@a2,@a3)", con); --> parameterized
            //sc.Parameters.AddWithValue("@a1", textBox1.Text);
            //sc.Parameters.AddWithValue("@a2", textBox2.Text);
            //sc.Parameters.AddWithValue("@a3", textBox3.Text);
            con.Open();
            //int i = sc.ExecuteNonQuery();
            //MessageBox.Show(i + "inserted");
            
            con.Close();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if (dr.Read() == true)
            //{
            //    textBox1.Text = dr[0].ToString();
            //    textBox2.Text = dr[1].ToString();
            //    textBox3.Text = dr[2].ToString();
            //}
            //else
            //{
            //    MessageBox.Show("Completed");
            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach(Control c in this.Controls)
            {
                if(c is TextBox)
                {
                    c.Text = "";
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source = Shiva-Jaligama\\SQLEXPRESS; database = Sample; integrated security = SSPI");
            //SqlCommand sc = new SqlCommand("select * from gridview", con);
            SqlCommand sc = new SqlCommand("select * from gridview where sno = '" + textBox1.Text + "'", con);
            con.Open();
            dr = sc.ExecuteReader();

            if (dr.Read() == true)
            {
                //textBox1.Text = dr[0].ToString();
                textBox2.Text = dr[1].ToString();
                textBox3.Text = dr[2].ToString();
            }
            else
            {
                MessageBox.Show("invalid");
            }
        }
    }
}
