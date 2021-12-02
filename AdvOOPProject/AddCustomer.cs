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

namespace AdvOOPProject
{
    public partial class AddCustomerWindow : Form
    {
        //SQL
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\CustomersDB.mdf;Integrated Security=True");

        public AddCustomerWindow()
        {
            InitializeComponent();
        }

        private void CustomerWindow_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"insert into Customers (fistName, lastName, phoneNumber) values ('{textBox_firstName.Text}', '{textBox_lastName.Text}', '{textBox_phoneNumber.Text}')";
            cmd.ExecuteNonQuery();
            textBox_firstName.Text = textBox_lastName.Text = textBox_phoneNumber.Text = "";
            conn.Close();
            labelSucessAdd();

        }

        private void labelSucessAdd()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select MAX(customerId) AS LastID from Customers";
            cmd.ExecuteNonQuery();
            labelAddedCustomer.Show();
            labelAddedCustomer.Text = $"Customer Added with Success! ID: {cmd.ToString()}";
            conn.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            labelAddedCustomer.Hide();
        }
    }
}
