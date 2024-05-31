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
    public partial class Orders : Form
    {
        public Orders()
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

        private void btnprofile_Click(object sender, EventArgs e)
        {
            Profile profileObj = new Profile();
            profileObj.Show();
            this.Close();
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'foodcenterDataSet1.Ordertable' table. You can move, or remove it, as needed.
            //this.ordertableTableAdapter.Fill(this.foodcenterDataSet1.Ordertable);

            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.Columns.Add("Order Number", 250);
            listView1.Columns.Add("Price", 250);

            SqlConnection connection = new SqlConnection("Data Source=MSI;Initial Catalog=Foodcenter;Integrated Security=True;TrustServerCertificate=True");
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM PizzaOrders", connection);
            SqlDataReader da = cmd.ExecuteReader();

            int sum = 0;
            while (da.Read())
            {
                var item1 = listView1.Items.Add(da[0].ToString());
                item1.SubItems.Add(da[1].ToString());
            }
            da.Close();
            connection.Close();
        
        }

        private void labOrderNumber_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
