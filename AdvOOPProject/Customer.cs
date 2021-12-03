using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AdvOOPProject
{
    class Customer
    {
        //SQL Connection
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\CustomersDB.mdf;Integrated Security=True");

        protected string firstName;
        protected string lastName;
        protected string phoneNumber;
        protected int customerId;
        private int bookings;

        public Customer(string firstName, string lastName, string phoneNumber)
        {

            CheckDB();
            if (CheckDB() == false)
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                try
                {
                    cmd.CommandText = $"insert into Customers (firstName, lastName, phoneNumber) values ('{firstName}', '{lastName}', '{phoneNumber}')";
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
                cmd.ExecuteNonQuery();
                conn.Close();
                this.firstName = firstName;
                this.lastName = lastName;
                this.phoneNumber = phoneNumber;
                customerId = CustomerIdDb();
                bookings = 0;
            }
        }

        public Customer(string firstName, string phoneNumber)
        {

            CheckDB();
            if (CheckDB() == false)
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                try
                {
                    cmd.CommandText = $"insert into Customers (firstName, phoneNumber) values ('{firstName}', '{phoneNumber}')";
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
                cmd.ExecuteNonQuery();
                conn.Close();
                this.firstName = firstName;
                lastName = "Not provided/Not existent";
                this.phoneNumber = phoneNumber;
                customerId = CustomerIdDb();
                bookings = 0;
            }
        }

        private bool CheckDB()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            try
            {
                cmd.CommandText = $"Select count(*) from Customers where firstName = '{firstName}' and lastName = '{lastName}' and phoneNumber = '{phoneNumber}'";
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            Int32 userExists = (Int32)cmd.ExecuteScalar();
            if (userExists > 0)
            {
                conn.Close();
                return true;
            }
            else
            {
                conn.Close();
                return false;
            }

        }

        private int CustomerIdDb()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            try
            {
                cmd.CommandText = $"Select customerId from Customers where firstName = '{firstName}' and lastName = '{lastName}' and phoneNumber = '{phoneNumber}'";
            }
            catch (Exception)
            {

                throw;
            }
            Int32 s = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            return s;

        }

        //private int CustomerBookings()
        //{
        //    conn.Open();
        //    SqlCommand cmd = conn.CreateCommand();
        //    cmd.CommandType = System.Data.CommandType.Text;
        //    try
        //    {
        //        cmd.CommandText = $"Select booking from Customers where firstName = '{firstName}' and lastName = '{lastName}' and phoneNumber = '{phoneNumber}'";
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //    int s = Convert.ToInt32(cmd.ExecuteScalar());
        //    conn.Close();
        //    return s;

        //}

        // public Customer(string fName, string lName, string phoneNum, string numBooked)
        //    {
        //        this.fName = fName;
        //       this.lName = lName;
        //       this.phoneNum = phoneNum;
        //   this.numBooked = new Booking (fName, lName, phoneNum);
        //    }

        public string GetFirstName()
        {
            return firstName;
        }
        public string GetLastName()
        {
            return firstName;
        }
        public string GetPhoneNumber()
        {
            return firstName;
        }
        public int GetCustomerId()
        {
            return customerId;
        }

        public int GetNumberOfBookings()
        {
            return bookings;
        }


        public override string ToString()
        {
            string s = "Client INFO\n";
            s += "--------------\n";
            s += "ID: " + customerId;
            s += "\nCustomer Name: " + firstName;
            s += "\nCustomer Last Name: " + lastName;
            s += "\nPhone Number: " + phoneNumber;
            s += "\nBookings:" + bookings;
            return s;
        }
    }
}