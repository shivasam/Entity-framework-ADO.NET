using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace Form_WPF_
{
    /// <summary>
    /// Interaction logic for dbconnection.xaml
    /// </summary>
    public partial class dbconnection : Window
    {
        public dbconnection()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection("data source = Shiva-Jaligama\\SQLEXPRESS; database=sample1; integrated security = SSPI");
            SqlCommand cmd = new SqlCommand("select * from table01 where no=@p1",con);
            cmd.Parameters.AddWithValue("@p1", txt1.Text);
            //cmd.Parameters.AddWithValue("@p1", txt2.Text);
            //cmd.Parameters.AddWithValue("@p1", txt3.Text);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read() == true)
            {
                //txt1.Text = dr[0].ToString();
                txt2.Text = dr[1].ToString();
                txt3.Text = dr[2].ToString();
            }
            else
            {
                MessageBox.Show("Invalid");
            }
            con.Close();

        }
    }
}
