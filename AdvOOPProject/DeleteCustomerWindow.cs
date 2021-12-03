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
    public partial class DeleteCustomerWindow : Form
    {
        //SQL
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\CustomersDB.mdf;Integrated Security=True");
        public DeleteCustomerWindow()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void DeleteCustomerWindow_Load(object sender, EventArgs e)
        {

        }

        private void CheckDB()
        {
            labelCustomer.Hide();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            try
            {
                cmd.CommandText = $"Select * from Customers where customerId = '{textBox_ID.Text}' or firstName = '{textBox_firstName.Text}' and lastName = '{textBox_lastName.Text}' and phoneNumber = '{textBox_phoneNumber.Text}'";
            }
            catch (Exception)
            {

                throw;
            }
            cmd.ExecuteNonQuery();
            DataTable dTable = new DataTable();
            SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);
            dAdapter.Fill(dTable);
            dataGridView1.DataSource = dTable;
            conn.Close();
            if (dTable.Rows is null)
            {
                labelCustomer.Show();
                labelCustomer.Text = "User not found";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonFindCustomer_Click(object sender, EventArgs e)
        {
            CheckDB();
        }

        private void buttonClearFieds_Click(object sender, EventArgs e)
        {
            textBox_ID.Text = textBox_firstName.Text = textBox_lastName.Text = textBox_phoneNumber.Text = "";
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Form tmp = this.FindForm();
            tmp.Close();
            tmp.Dispose();
        }

        private void buttonDeleteCustomer_Click(object sender, EventArgs e)
        {
            labelCustomer.Hide();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            try
            {
                cmd.CommandText = $"Delete from Customers where customerId = '{textBox_ID.Text}' or firstName = '{textBox_firstName.Text}' and lastName = '{textBox_lastName.Text}' and phoneNumber = '{textBox_phoneNumber.Text}'";
            }
            catch (Exception)
            {

                throw;
            }
            cmd.ExecuteNonQuery();
            labelCustomer.Show();
            labelCustomer.Text = "Customer deleted!";
            conn.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
