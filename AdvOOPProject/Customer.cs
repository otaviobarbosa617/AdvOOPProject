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
        private Booking numBooked;
        private string customerId;

        public Customer(string fName, string lName, string phoneNum, string customerId)
        {
            if (string.IsNullOrEmpty(customerId))
            {
                Guid newID = Guid.NewGuid();
                customerId = newID.ToString();
            }
            this.fName = fName;
            this.lName = lName;
            this.phoneNum = phoneNum;
            this.customerId = customerId;
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

        public int GetId()
        {
            
            return customerID;
        }
    }
}
