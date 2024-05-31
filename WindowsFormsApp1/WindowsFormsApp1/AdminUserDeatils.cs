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
    public partial class AdminUserDeatils : Form
    {
        public AdminUserDeatils()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dashboardObj = new Dashboard();
            dashboardObj.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void AdminUserDeatils_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.Columns.Add("Username", 170);
            listView1.Columns.Add("Phonenumber", 170);
            listView1.Columns.Add("Password", 170);

            SqlConnection connection = new SqlConnection("Data Source=MSI;Initial Catalog=Foodcenter;Integrated Security=True;TrustServerCertificate=True");
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT Username, Phonenumber, Password FROM Signup", connection);
            SqlDataReader da = cmd.ExecuteReader();

            int sum = 0;
            while (da.Read())
            {
                var item1 = listView1.Items.Add(da[0].ToString());
                item1.SubItems.Add(da[1].ToString());
                item1.SubItems.Add(da[2].ToString());
            }
            da.Close();


            connection.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login loginObj = new Login();
            loginObj.Show();
            this.Hide();
        }
    }
}
