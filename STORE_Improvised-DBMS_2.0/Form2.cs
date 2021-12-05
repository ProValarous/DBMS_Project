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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();


        }

        public string conString = "Data Source=NITRO-PC;Initial Catalog=EPIC;Integrated Security=True";

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void store_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "EXEC buy @Username = '" + acountName.Text + "', @idGame = " + 2;

                SqlCommand cmd = new SqlCommand(q, con);

                SqlDataReader w = cmd.ExecuteReader();
            }
        }

        private void acountName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            SqlConnection con = new SqlConnection(conString);
            con.Open();

            if (con.State == System.Data.ConnectionState.Open)
            {

                string q = "select Amount from Wallet where idWallet = (select Wallet_idWallet from Users where Username = '" + acountName.Text + "')";

                SqlCommand cmd = new SqlCommand(q, con);

                SqlDataReader w = cmd.ExecuteReader();

                this.Hide();
                Form3 f = new Form3();

                while (w.Read())
                {
                    f.walletAmount.Text = w.GetValue(0).ToString();
                }
                w.Close();

                string q2 = "select game_name from game g inner join library l on g.idGame = l.Game_idGame inner join users u on l.Users_idUsers = u.idUsers where Username = '" + acountName.Text + "'";
                SqlDataAdapter cmd2 = new SqlDataAdapter(q2, con);

                DataTable dbt = new DataTable();

                cmd2.Fill(dbt);

                f.dataGrid.DataSource = dbt;


                //get user name
                f.account.Text = acountName.Text;

                //switch form
                f.Show();


            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "EXEC buy @Username = '" + acountName.Text + "', @idGame = " + 3;

                SqlCommand cmd = new SqlCommand(q, con);

                SqlDataReader w = cmd.ExecuteReader();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "EXEC buy @Username = '" + acountName.Text + "', @idGame = " + 4;

                SqlCommand cmd = new SqlCommand(q, con);

                SqlDataReader w = cmd.ExecuteReader();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "EXEC buy @Username = '" + acountName.Text + "', @idGame = " + 5;

                SqlCommand cmd = new SqlCommand(q, con);

                SqlDataReader w = cmd.ExecuteReader();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "EXEC buy @Username = '" + acountName.Text + "', @idGame = " + 6;

                SqlCommand cmd = new SqlCommand(q, con);

                SqlDataReader w = cmd.ExecuteReader();
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "EXEC buy @Username = '" + acountName.Text + "', @idGame = " + 7;

                SqlCommand cmd = new SqlCommand(q, con);

                SqlDataReader w = cmd.ExecuteReader();
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "EXEC buy @Username = '" + acountName.Text + "', @idGame = " + 8;

                SqlCommand cmd = new SqlCommand(q, con);

                SqlDataReader w = cmd.ExecuteReader();
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "EXEC buy @Username = '" + acountName.Text + "', @idGame = " + 9;

                SqlCommand cmd = new SqlCommand(q, con);

                SqlDataReader w = cmd.ExecuteReader();
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "EXEC buy @Username = '" + acountName.Text + "', @idGame = " + 10;

                SqlCommand cmd = new SqlCommand(q, con);

                SqlDataReader w = cmd.ExecuteReader();
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "EXEC buy @Username = '" + acountName.Text + "', @idGame = " + 11;

                SqlCommand cmd = new SqlCommand(q, con);

                SqlDataReader w = cmd.ExecuteReader();
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "EXEC buy @Username = '" + acountName.Text + "', @idGame = " + 12;

                SqlCommand cmd = new SqlCommand(q, con);

                SqlDataReader w = cmd.ExecuteReader();
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "EXEC buy @Username = '" + acountName.Text + "', @idGame = " + 13;

                SqlCommand cmd = new SqlCommand(q, con);

                SqlDataReader w = cmd.ExecuteReader();
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "EXEC buy @Username = '" + acountName.Text + "', @idGame = " + 14;

                SqlCommand cmd = new SqlCommand(q, con);

                SqlDataReader w = cmd.ExecuteReader();
            }
        }
    }
}
