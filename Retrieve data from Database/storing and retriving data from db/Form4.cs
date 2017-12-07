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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source = Shiva-Jaligama//SQLEXPRESS; database = Sample; integrated security = SSPI");
            SqlCommand da = new SqlCommand("myproc", con);
            con.Open();
            da.CommandType = CommandType.StoredProcedure;
            int i = da.ExecuteNonQuery();
            con.Close();
        }
    }
}
