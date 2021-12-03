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
            labelAddedCustomer.Hide();
            CheckDB();
            if (CheckDB() == false)
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                try
                {
                    cmd.CommandText = $"insert into Customers (firstName, lastName, phoneNumber) values ('{textBox_firstName.Text}', '{textBox_lastName.Text}', '{textBox_phoneNumber.Text}')";
                }
                catch (Exception)
                {

                    throw;
                }
                cmd.ExecuteNonQuery();
                textBox_firstName.Text = textBox_lastName.Text = textBox_phoneNumber.Text = "";
                conn.Close();
                labelSucessAdd();
            }
            

        }

        private bool CheckDB()
        {
            labelAddedCustomer.Hide();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            try
            {
                cmd.CommandText = $"Select count(*) from Customers where firstName = '{textBox_firstName.Text}' and lastName = '{textBox_lastName.Text}' and phoneNumber = '{textBox_phoneNumber.Text}'";
            }
            catch (Exception)
            {

                throw;
            }
            Int32 userExists = (Int32) cmd.ExecuteScalar();
            if (userExists > 0)
            {
                conn.Close();
                labelAddedCustomer.Show();
                labelAddedCustomer.Text = "Customer already on the Customer List - Press Clear Fields to re-tipe or check the list of Customer on the Customers Menu";
                return true;
            }
            else
            {
                conn.Close();
                return false;
            }

        }

        private void labelSucessAdd()
        {
            labelAddedCustomer.Show();
            labelAddedCustomer.Text = "Customer Added with Success!";
        }

        private void label4_Click(object sender, EventArgs e)
        {
            labelAddedCustomer.Hide();
        }

        private void buttonClearFieds_Click(object sender, EventArgs e)
        {
            textBox_firstName.Text = textBox_lastName.Text = textBox_phoneNumber.Text = "";
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Form tmp = this.FindForm();
            tmp.Close();
            tmp.Dispose();
        }
    }
}
