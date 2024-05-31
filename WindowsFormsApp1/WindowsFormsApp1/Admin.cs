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

namespace WindowsFormsApp1
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=MSI;Initial Catalog=Foodcenter;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            string query = "SELECT COUNT(*) FROM adminlogin WHERE username = @username AND password = @password";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@username", txtLoginEmail.Text);
            cmd.Parameters.AddWithValue("@password", txtloginPassword.Text);
            int count = (int)cmd.ExecuteScalar();
            con.Close();
            if (count > 0)
            {
                Dashboard dashboardObj = new Dashboard();
                dashboardObj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Check your username and password !!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login loginObj = new Login();
            loginObj.Show();
            this.Hide();
        }
    }
}
