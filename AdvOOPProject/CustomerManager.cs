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
        private int numAccounts;
        private int maxAccounts;
        private Customer[] customersList;


        //TODO Method to remove customer from DB;

        public CustomerManager(int maxAccounts)
        {
            numAccounts = 0;
            this.maxAccounts = maxAccounts;
            customersList = new Customer[maxAccounts];
        }

        public bool addAccount(string firstName, string lastName, string phoneNum)
        {
            if (numAccounts < maxAccounts)
            {
                customersList[numAccounts] = new Customer(firstName, lastName, phoneNum);
                numAccounts++;
                return true;
            }
            return false;
        }

        public bool addAccount(string fName, string phoneNum)
        {
            if (numAccounts < maxAccounts)
            {
                customersList[numAccounts] = new Customer(fName, phoneNum);
                numAccounts++;
                return true;
            }
            return false;
        }

        public override string ToString()
            //TODO This method should connect to the DB and retrive all
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
