using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login loginObj = new Login();
            loginObj.Show();
            this.Hide();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=MSI;Initial Catalog=Foodcenter;Integrated Security=True;TrustServerCertificate=True");
            con.Open();

            string insertQuery = "INSERT INTO Signup (username,phonenumber,password) VALUES (@username,@phonenumber,@password)";
            SqlCommand insertCmd = new SqlCommand(insertQuery ,con);

            insertCmd.Parameters.AddWithValue("@username",txtNewAccountEmail.Text);
            insertCmd.Parameters.AddWithValue("@phonenumber",txtnewAccountPhoneNumber.Text);
            insertCmd.Parameters.AddWithValue("@password",txtNewAccountPassword.Text);

            int rowsAffected = insertCmd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                Login loginObj = new Login();
                loginObj.Show();
                this.Hide();
            }
            else
            {
                // Insert failed
                MessageBox.Show("Error");
            }
            con.Close();
        }
    }
}
