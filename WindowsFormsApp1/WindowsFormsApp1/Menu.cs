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
using Microsoft.IdentityModel.Tokens;
using System.Diagnostics;
using Azure;
using System.Net.NetworkInformation;

namespace WindowsFormsApp1
{
    public partial class Menu : Form
    {
        int numChilli = 1;
        int numOnlion = 1;
        int numTomato = 1;
        string username;
        public Menu()
        {

            InitializeComponent();
        }
        private void Menu_Load(object sender, EventArgs e)
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

                            username = Convert.ToString(labname.Text);
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
            Home homeobj = new Home();
            homeobj.Show();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnprofile_Click(object sender, EventArgs e)
        {
            Profile profileObj = new Profile();
            profileObj.Show();
            this.Close();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            Orders ordersObj = new Orders();
            ordersObj.Show();
            this.Close();
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            Cart cartObj = new Cart();
            cartObj.Show();
            this.Close();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu2 menuObj = new Menu2();
            menuObj.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=MSI;Initial Catalog=Foodcenter;Integrated Security=True;TrustServerCertificate=True";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string insertQuery = "INSERT INTO [customeroders] (username,pizzaname,size,price,quantity) VALUES (@username,@pizzaname,@size,@price,@quantity)";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, con);
                    insertCmd.Parameters.AddWithValue("@username", labname.Text);
                    insertCmd.Parameters.AddWithValue("@pizzaname", labChilliChikenPizza.Text);
                    insertCmd.Parameters.AddWithValue("@size", cmbChilliChikenPizza.SelectedItem.ToString());
                    insertCmd.Parameters.AddWithValue("@price", txtChilliChikenPizza.Text);
                    insertCmd.Parameters.AddWithValue("@quantity", txtChiliChickenQuantity.Text);
                    int rowsAffected = insertCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Added to cart");
                        Cart cartObj = new Cart();
                        cartObj.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Error adding to cart");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=MSI;Initial Catalog=Foodcenter;Integrated Security=True;TrustServerCertificate=True";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string insertQuery = "INSERT INTO [customeroders] (username,pizzaname,size,price,quantity) VALUES (@username,@pizzaname,@size,@price,@quantity)";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, con);
                    insertCmd.Parameters.AddWithValue("@username", labname.Text);
                    insertCmd.Parameters.AddWithValue("@pizzaname", labCheesyOnionPizza.Text);
                    insertCmd.Parameters.AddWithValue("@size", cmbCheesyOnionPizza.SelectedItem.ToString());
                    insertCmd.Parameters.AddWithValue("@price", txtCheesyOnionPizza.Text);
                    insertCmd.Parameters.AddWithValue("@quantity", txtOnionQuantity.Text);
                    int rowsAffected = insertCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Added to cart");
                        Cart cartObj = new Cart();
                        cartObj.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Error adding to cart");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=MSI;Initial Catalog=Foodcenter;Integrated Security=True;TrustServerCertificate=True";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string insertQuery = "INSERT INTO [customeroders] (username,pizzaname,size,price,quantity) VALUES (@username,@pizzaname,@size,@price,@quantity)";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, con);

                    insertCmd.Parameters.AddWithValue("@username", labname.Text);
                    insertCmd.Parameters.AddWithValue("@pizzaname", labCheesyTomatoPizza.Text);
                    insertCmd.Parameters.AddWithValue("@size", cmbCheesyTomatoPizza.SelectedItem.ToString());
                    insertCmd.Parameters.AddWithValue("@price", txtCheesyTomatoPizza.Text);
                    insertCmd.Parameters.AddWithValue("@quantity", txtTomatoQuantity.Text);
                    int rowsAffected = insertCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Added to cart");
                        Cart cartObj = new Cart();
                        cartObj.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Error adding to cart");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbChilliChikenPizza_SelectedIndexChanged(object sender, EventArgs e)
        {
            string size;
            int price = 0;

            size = cmbChilliChikenPizza.SelectedItem.ToString();

            if (size == "Medium")
            {
                price = 1500;
            }
            else if (size == "Personal")
            {
                price = 2000;
            }
            else if (size == "Large")
            {
                price = 3000;
            }

            //Display
            this.txtChilliChikenPizza.Text = price.ToString();
        }

        private void cmbCheesyOnionPizza_SelectedIndexChanged(object sender, EventArgs e)
        {
            string size;
            int price = 0;

            size = cmbCheesyOnionPizza.SelectedItem.ToString();

            if (size == "Medium")
            {
                price = 1500;
            }
            else if (size == "Personal")
            {
                price = 2000;
            }
            else if (size == "Large")
            {
                price = 3000;
            }

            //Display
            this.txtCheesyOnionPizza.Text = price.ToString();
        }

        private void cmbCheesyTomatoPizza_SelectedIndexChanged(object sender, EventArgs e)
        {
            string size;
            int price = 0;

            size = cmbCheesyTomatoPizza.SelectedItem.ToString();

            if (size == "Medium")
            {
                price = 1500;
            }
            else if (size == "Personal")
            {
                price = 2000;
            }
            else if (size == "Large")
            {
                price = 3000;
            }

            //Display
            this.txtCheesyTomatoPizza.Text = price.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnChilliChikenPlus_Click(object sender, EventArgs e)
        {


            this.txtChiliChickenQuantity.Text = numChilli.ToString();
            numChilli++;

        }

        private void btnChilliChikenMin_Click(object sender, EventArgs e)
        {
            if (numChilli > 0)
            {
                this.txtChiliChickenQuantity.Text = numChilli.ToString();
                numChilli--;
            }
            else if (numChilli <= 0)
            {
                numChilli = 0;
                this.txtChiliChickenQuantity.Text = numChilli.ToString();
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btnOnionPlus_Click(object sender, EventArgs e)
        {
            this.txtOnionQuantity.Text = numOnlion.ToString();
            numOnlion++;
        }

        private void btnOnionmin_Click(object sender, EventArgs e)
        {

            if (numOnlion > 0)
            {
                this.txtOnionQuantity.Text = numOnlion.ToString();
                numOnlion--;
            }
            else if (numOnlion <= 0)
            {
                numOnlion = 0;
                this.txtOnionQuantity.Text = numOnlion.ToString();
            }
        }

        private void btnTomatoPlus_Click(object sender, EventArgs e)
        {
            this.txtTomatoQuantity.Text = numTomato.ToString();
            numTomato++;
        }

        private void btnTomatoMin_Click(object sender, EventArgs e)
        {
            if (numTomato > 0)
            {
                this.txtTomatoQuantity.Text = numTomato.ToString();
                numTomato--;
            }
            else if (numTomato <= 0)
            {
                numTomato = 0;
                this.txtTomatoQuantity.Text = numTomato.ToString();
            }
        }



    }
}
  



