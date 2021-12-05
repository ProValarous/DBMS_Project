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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=NITRO-PC;Initial Catalog=EPIC;Integrated Security=True";

        private void am_TextChanged(object sender, EventArgs e)
        {

        }

        private void enter_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "UPDATE Wallet SET Amount = Amount " + Convert.ToInt32(am.Text.ToString()) + " WHERE idWallet = (select Wallet_idWallet from Users where Username = '" + account.Text.ToString() + "')";

                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Connection Made!");
            }
        }

        private void account_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            if (con.State == System.Data.ConnectionState.Open)
            {

                string q = "select Amount from Wallet where idWallet = (select Wallet_idWallet from Users where Username = '" + account.Text + "')";

                SqlCommand cmd = new SqlCommand(q, con);

                SqlDataReader w = cmd.ExecuteReader();

                this.Hide();
                Form3 f = new Form3();

                while (w.Read())
                {
                    f.walletAmount.Text = w.GetValue(0).ToString();
                }
                w.Close();

                string q2 = "select game_name from game g inner join library l on g.idGame = l.Game_idGame inner join users u on l.Users_idUsers = u.idUsers where Username = '" + account.Text + "'";
                SqlDataAdapter cmd2 = new SqlDataAdapter(q2, con);

                DataTable dbt = new DataTable();

                cmd2.Fill(dbt);

                f.dataGrid.DataSource = dbt;


                //get user name
                f.account.Text = account.Text;

                //switch form
                f.Show();

            }
        }
    }
}
