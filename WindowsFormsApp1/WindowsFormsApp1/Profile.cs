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
    public partial class Profile : Form
    {
        string username;
        public Profile()
        {
            InitializeComponent();
        }
        private void Profile_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=MSI;Initial Catalog=Foodcenter;Integrated Security=True;TrustServerCertificate=True";
            string query = "SELECT * FROM tableusername";

            using (SqlConnection connection1 = new SqlConnection(connectionString))
            {
                try
                {
                    connection1.Open();
                    using (SqlCommand command = new SqlCommand(query, connection1))
                    {
                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            txtProfileName.Text = result.ToString();

                            username = Convert.ToString(txtProfileName.Text);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home homeObj = new Home();
            homeObj.Show();
            this.Close();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Menu menuObj = new Menu();
            menuObj.Show();
            this.Close();
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            Cart cartObj = new Cart();
            cartObj.Show();
            this.Close();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            Orders ordersObj = new Orders();
            ordersObj.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=MSI;Initial Catalog=Foodcenter;Integrated Security=True;TrustServerCertificate=True");
            connection.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM tableusername", connection);
            int rowsAffected = cmd.ExecuteNonQuery();

            Login loginObj = new Login();
            loginObj.Show();
            this.Close();


        }

        private void txtProfileName_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
