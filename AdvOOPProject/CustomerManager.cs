using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AdvOOPProject
{
    class CustomerManager
    {
        //SQL Connection
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\CustomersDB.mdf;Integrated Security=True");

        private int numAccounts;
        private int maxAccounts;
        private Customer[] customersList;

        public CustomerManager(int maxAccounts)
        {
            numAccounts = 0;
            this.maxAccounts = maxAccounts;
            customersList = new Customer[maxAccounts];
        }

        public bool AddAccount(string firstName, string lastName, string phoneNumber)
        {
            if (numAccounts < maxAccounts)
            {
                customersList[numAccounts] = new Customer(firstName, lastName, phoneNumber);
                numAccounts++;
                return true;
            }
            return false;
        }

        public bool AddAccount(string firstName, string phoneNumber)
        {
            if (numAccounts < maxAccounts)
            {
                customersList[numAccounts] = new Customer(firstName, phoneNumber);
                numAccounts++;
                return true;
            }
            return false;
        }

        

        //This method to retrive all data from the table works but for know I don't know how to make it pretty like the ToString() one
        public void AllClientsDB()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            try
            {
                cmd.CommandText = "Select * from Customers";
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            SqlDataReader tableResults = cmd.ExecuteReader();
            while (tableResults.Read())
            {
                for (int i = 0; i < tableResults.FieldCount; i++)
                {
                    Console.WriteLine(tableResults.GetValue(i));
                }
                Console.WriteLine();
            }
            conn.Close();
        }

        public override string ToString()
        {
            if (numAccounts == 0)
            {
                return "There are no Clients on file";
            }
            else
            {
                string s = "Clients List:\n";
                for (int i = 0; i < numAccounts; i++)
                {
                    s += customersList[i].ToString() + "\n";
                }
                return s;
            }
        }

    }
}
