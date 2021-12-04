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

namespace STORE_Improvised
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        public string conString = "Data Source=NITRO-PC;Initial Catalog=EPIC;Integrated Security=True";


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void create_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "INSERT INTO Game(Seller_idSeller, Game_name, Game_description, Price) VALUES(" + "(select idSeller from seller where Distributer_name"+ seller.Text +") '" + gameName.Text.ToString() + "','" + gameDescription.Text.ToString() + "','" + gamePrice.Text.ToString() + "')";

                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Connection Made!");
            }
        }
    }
}
