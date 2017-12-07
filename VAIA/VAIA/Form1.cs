using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace VAIA
{
    public partial class Form1 : Form
    {
        public string textEnter="";
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, System.EventArgs e)
        {
            listBox1.Items.Add(textEnter);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            listBox1.Items.Clear();
            for(int i=0; i < 1000; i++)
            {
                listBox1.Items.Add(random.Next(1, 1000).ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
            
        }
        

        private void button4_Click(object sender, EventArgs e)
        {
            StreamWriter streamwriter = new StreamWriter("c:\\output.txt");
            streamwriter.WriteLine(textBox2.Text);
            streamwriter.Close();

            foreach(Control clear in this.Controls)
            {
                if(clear is TextBox)
                {
                    ((TextBox)clear).Text = string.Empty;
                }
            }
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();
            textBox1.Text = file.FileName;
        }
    }
}
