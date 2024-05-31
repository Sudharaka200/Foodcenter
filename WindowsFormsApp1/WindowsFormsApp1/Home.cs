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
using System.Collections;

namespace WindowsFormsApp1
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        private void Home_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=MSI;Initial Catalog=Foodcenter;Integrated Security=True;TrustServerCertificate=True";
            string query = "SELECT * FROM tableusername";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            labname.Text = result.ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
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

        private void btnprofile_Click(object sender, EventArgs e)
        {
            Profile profileObj = new Profile();
            profileObj.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menuObj = new Menu();
            menuObj.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }


}

