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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminUserDeatils adminUserDeatilsObj = new AdminUserDeatils();
            adminUserDeatilsObj.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.Columns.Add("OrderID", 70);
            listView1.Columns.Add("Name",100);
            listView1.Columns.Add("Pizzaname",140);
            listView1.Columns.Add("Size",100);
            listView1.Columns.Add("price",100);
            listView1.Columns.Add("Quantity",100);

            SqlConnection connection = new SqlConnection("Data Source=MSI;Initial Catalog=Foodcenter;Integrated Security=True;TrustServerCertificate=True");
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM customeroders", connection);
            SqlDataReader da = cmd.ExecuteReader();

            int sum = 0;
            while (da.Read())
            {
                var item1 = listView1.Items.Add(da[0].ToString());
                item1.SubItems.Add(da[1].ToString());
                item1.SubItems.Add(da[2].ToString());
                item1.SubItems.Add(da[3].ToString());
                item1.SubItems.Add(da[4].ToString());
                item1.SubItems.Add(da[5].ToString());
            }
            da.Close();
            connection.Close();

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string connectionString = "Data Source=MSI;Initial Catalog=Foodcenter;Integrated Security=True;TrustServerCertificate=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM customeroders", connection))
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                    }
                    using (SqlCommand cmd1 = new SqlCommand("DELETE FROM PizzaOrders", connection))
                    {
                        int rowsAffected1 = cmd1.ExecuteNonQuery();
                    }
                }
                Dashboard dashboardObj = new Dashboard();
                dashboardObj.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            Login loginObj = new Login();
            loginObj.Show();
            this.Hide();
        }
    }
}
