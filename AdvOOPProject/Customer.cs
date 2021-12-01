using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvOOPProject
{
    class Customer
    {

        private string fName;
        private string lName;
        private string phoneNum;
        private string customerId;
        private Booking numBooked;

        public Customer(string fName, string lName, string phoneNum)
        {
            if (string.IsNullOrEmpty(customerId))
            {
                Guid newID = Guid.NewGuid();
                customerId = newID.ToString();
            }
            this.fName = fName;
            this.lName = lName;
            this.phoneNum = phoneNum;
        }

        // public Customer(string fName, string lName, string phoneNum, string numBooked)
        //    {
        //        this.fName = fName;
        //       this.lName = lName;
        //       this.phoneNum = phoneNum;
        //   this.numBooked = new Booking (fName, lName, phoneNum);
        //    }

        public string GetFName()
        {
            return fName;
        }
        public string GetLName()
        {
            return lName;
        }
        public string GetPhoneNum()
        {
            return phoneNum;
        }
        public string GetId()
        {
            return customerId;
        }

        public override string ToString()
        {
            string s = "Client INFO\n";
            s += "--------------\n";
            s += "ID: " + customerId;
            s += "\nCustomer Name: " + fName;
            s += "\nCustomer Last Name: " + lName;
            s += "\nPhone Number: " + phoneNum;
            return s;
        }

    }
}