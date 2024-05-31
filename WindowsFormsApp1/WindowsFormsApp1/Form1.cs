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
using System.Diagnostics;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=MSI;Initial Catalog=Foodcenter;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            string query = "SELECT COUNT(*) FROM SignUp WHERE username = @username AND password = @password";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@username",txtLoginEmail.Text);
            cmd.Parameters.AddWithValue("@password",txtloginPassword.Text);
            int count = (int)cmd.ExecuteScalar();
            con.Close();
            if(count > 0)
            {
                Home homeObj = new Home();
                homeObj.Show();
                this.Hide();

                SqlConnection con1 = new SqlConnection("Data Source=MSI;Initial Catalog=Foodcenter;Integrated Security=True;TrustServerCertificate=True");
                con1.Open();

                string insertQuery = "INSERT INTO tableusername (name) VALUES (@name)";
                SqlCommand insertCmd = new SqlCommand(insertQuery, con1);

                insertCmd.Parameters.AddWithValue("@name", txtLoginEmail.Text);
                int rowsAffected = insertCmd.ExecuteNonQuery();

            }
            else
            {
                MessageBox.Show("Check your username and password !!");
            }
           
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            CreateAccount createAccountBoj = new CreateAccount();
            createAccountBoj.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtloginPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtLoginEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Admin adminObj = new Admin();
            adminObj.Show();
            this.Hide();
        }
    }
}
