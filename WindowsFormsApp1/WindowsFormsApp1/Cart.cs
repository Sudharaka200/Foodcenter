using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Data.SqlClient;
using Azure.Core;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Cart : Form
    {
        public TextBox txtCartChilliChikenPizzaPrice12;
        public Cart()
        {
            InitializeComponent();
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Cart_Load(object sender, EventArgs e)
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
                            labname.Text = result.ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
            // TODO: This line of code loads data into the 'foodcenterDataSet2.pizzamenu' table. You can move, or remove it, as needed.
            this.pizzamenuTableAdapter.Fill(this.foodcenterDataSet2.pizzamenu);
            // TODO: This line of code loads data into the 'foodcenterDataSet.Cart2' table. You can move, or remove it, as needed.
            this.cart2TableAdapter.Fill(this.foodcenterDataSet.Cart2);

            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.Columns.Add("Pizza Name", 150);
            listView1.Columns.Add("Size", 100);
            listView1.Columns.Add("Price", 80);
            listView1.Columns.Add("Quantity", 80);

            SqlConnection connection = new SqlConnection("Data Source=MSI;Initial Catalog=Foodcenter;Integrated Security=True;TrustServerCertificate=True");
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT pizzaname,size,price,quantity FROM customeroders", connection);
            SqlDataReader da = cmd.ExecuteReader();

            int sum = 0;
            while (da.Read())
            {
                var item1 = listView1.Items.Add(da[0].ToString());
                item1.SubItems.Add(da[1].ToString());
                item1.SubItems.Add(da[2].ToString());
                item1.SubItems.Add(da[3].ToString());

                int price = Convert.ToInt32(da[2]);
                int quantity = Convert.ToInt32(da[3]);
                sum += price * quantity;
            }
            da.Close();

            txtTotal.Text = sum.ToString();

            int shipping = 300;
            int totalBill = 0;
            txtShipping.Text = shipping.ToString();

            totalBill = sum + shipping;
            txtTotalBill.Text = totalBill.ToString();



            connection.Close();
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtCartChilliChikenPizzaPrice_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void txtShipping_TextChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=MSI;Initial Catalog=Foodcenter;Integrated Security=True;TrustServerCertificate=True");
            connection.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM pizzamenu", connection);
            int rowsAffected = cmd.ExecuteNonQuery();

            Menu menuObj = new Menu();
            menuObj.Show();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu menuObj = new Menu();
            menuObj.Show();
            this.Close();
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=MSI;Initial Catalog=Foodcenter;Integrated Security=True;TrustServerCertificate=True";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string insertQuery = "INSERT INTO [PizzaOrders] (Total) VALUES (@Total)";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, con);

                    insertCmd.Parameters.AddWithValue("@Total", txtTotalBill.Text);
                    int rowsAffected = insertCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Order Succesfull");
                        Orders orderObj = new Orders();
                        orderObj.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Order Unsuccesfull");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
