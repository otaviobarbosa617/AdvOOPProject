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
        public List<Customer> CustomerList { get; set; }


        //TODO Method to remove customer from DB;

        public CustomerManager(int size)
        {
            CustomerList = new List<Customer>(size);
        }

        public void AddAccount(string firstName, string lastName, string phoneNumber)
        {
       
                CustomerList.Add(new Customer(firstName, lastName, phoneNumber));

        }

        public void AddAccount(string firstName, string phoneNumber)
        {
            CustomerList.Add(new Customer(firstName, phoneNumber));

        }


        public override string ToString()
            //TODO This method should connect to the DB and retrive all
        {
            if (CustomerList.Count == 0)
            {
                return "There are no Clients on file";
            }
            else
            {
                string s = "Clients List:\n";
                for (int i = 0; i < CustomerList.Count; i++)
                {
                    s += CustomerList[i].ToString() + "\n";
                }
                return s;
            }
        }

    }
}
