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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string conString = "Data Source=NITRO-PC;Initial Catalog=EPIC;Integrated Security=True";

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            if (con.State == System.Data.ConnectionState.Open)
            {
                string q0 = "INSERT INTO Wallet(Amount) VALUES("+0+")";

                SqlCommand cmd0 = new SqlCommand(q0, con);
                cmd0.ExecuteNonQuery();


                string q = "INSERT INTO Users(Wallet_idWallet, Username, Date_of_birth, country, sex, email, User_password) VALUES(" + "(select top 1 idWallet from Wallet order by idWallet DESC)" + ",'" + Username.Text.ToString() + "','" + DOB.Text.ToString() + "','" + Country.Text.ToString() + "','" + sex.Text.ToString() + "','" + Email.Text.ToString()+ "','" + Pword.Text.ToString() + "')";

                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Connection Made!");


                this.Hide();
                Form3 f = new Form3();

                //get wallet
                //string q = "INSERT INTO Users(Wallet_idWallet, Username, Date_of_birth, country, sex, email, User_password) VALUES(" + 1 + ",'" + Username.Text.ToString() + "','" + DOB.Text.ToString() + "','" + Country.Text.ToString() + "','" + sex.Text.ToString() + "','" + Email.Text.ToString() + "','" + Pword.Text.ToString() + "')";


                string q1 = "select Amount from Wallet where idWallet = " + "(select Wallet_idWallet from Users where Username = '" + Username.Text.ToString() + "')";

                SqlCommand cmd1 = new SqlCommand(q1, con);

                SqlDataReader w = cmd1.ExecuteReader();

                while (w.Read())
                {
                    f.walletAmount.Text = w.GetValue(0).ToString();
                }


                //get user name
                f.account.Text = Username.Text.ToString();

                //switch form
                f.Show();
            }

            
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DOB_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            if (con.State == System.Data.ConnectionState.Open)
            {
                /*
                string q0 = "INSERT INTO Wallet(Amount) VALUES(" + 0 + ")";

                SqlCommand cmd0 = new SqlCommand(q0, con);
                cmd0.ExecuteNonQuery();
                */

                //string q = "INSERT INTO Users(Wallet_idWallet, Username, Date_of_birth, country, sex, email, User_password) VALUES(" + "(select top 1 idWallet from Wallet order by idWallet DESC)" + ",'" + Username.Text.ToString() + "','" + DOB.Text.ToString() + "','" + Country.Text.ToString() + "','" + sex.Text.ToString() + "','" + Email.Text.ToString() + "','" + Pword.Text.ToString() + "')";

                
                //w.Close();

                string q1 = "select User_password from Users where Username = '" + loginUsername.Text.ToString() + "'";


                SqlCommand cmd1 = new SqlCommand(q1, con);

                SqlDataReader p = cmd1.ExecuteReader();

                string pass = "invalid";

                while (p.Read())
                {
                    pass = p.GetValue(0).ToString();
                }

                if (pass == loginPword.Text.ToString())
                    {
                        p.Close();

                        string q = "select Amount from Wallet where idWallet = (select Wallet_idWallet from Users where Username = '" + loginUsername.Text.ToString() + "')";

                        SqlCommand cmd = new SqlCommand(q, con);

                        SqlDataReader w = cmd.ExecuteReader();


                        this.Hide();
                        Form3 f = new Form3();

                        while (w.Read())
                        {
                            f.walletAmount.Text = w.GetValue(0).ToString();
                        }

                        //get user name
                        f.account.Text = loginUsername.Text.ToString();

                        //switch form
                        f.Show();
                    }
                
                MessageBox.Show("Connection Made!");
            }

            
        }
    }
}
