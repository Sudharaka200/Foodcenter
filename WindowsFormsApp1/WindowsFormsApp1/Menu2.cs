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
    public partial class Menu2 : Form
    {
        public Menu2()
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

        private void button5_Click(object sender, EventArgs e)
        {
            Menu menuObj = new Menu();
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

                    string insertQuery = "INSERT INTO [SausageDelight] (size,price) VALUES (@size,@price)";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, con);

                    insertCmd.Parameters.AddWithValue("@size", cmbSausagePizza.SelectedItem.ToString());
                    insertCmd.Parameters.AddWithValue("@price", txtSausagePizza.Text);
                    int rowsAffected = insertCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Added to cart");
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

        private void btnChickenBaconPizza_Click(object sender, EventArgs e)
        {

            try
            {
                string connectionString = "Data Source=MSI;Initial Catalog=Foodcenter;Integrated Security=True;TrustServerCertificate=True";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string insertQuery = "INSERT INTO [SausageDelight] (size,price) VALUES (@size,@price)";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, con);

                    insertCmd.Parameters.AddWithValue("@size", cmbChickenBaconPizza.SelectedItem.ToString());
                    insertCmd.Parameters.AddWithValue("@price", txtChickenBaconPizza.Text);
                    int rowsAffected = insertCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Added to cart");
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

        private void cmbSausagePizza_SelectedIndexChanged(object sender, EventArgs e)
        {
            string size;
            int price=0;

            size = cmbSausagePizza.SelectedItem.ToString();

            if(size == "Medium")
            {
                price = 1500;
            }
            else if(size == "Personal")
            {
                price = 2000;
            }
            else if(size == "Large")
            {
                price = 3000;
            }

            //Display
            this.txtSausagePizza.Text = price.ToString();

        }

        private void cmbChickenBaconPizza_SelectedIndexChanged(object sender, EventArgs e)
        {

            string size;
            int price = 0;

            size = cmbChickenBaconPizza.SelectedItem.ToString();

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
            this.txtChickenBaconPizza.Text = price.ToString();
        }
    }
    }

