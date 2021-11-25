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

        public Customer(string fName, string lName, string phoneNum)
        {
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

        public string getFName()
        {
            return fName;
        }
        public string getLName()
        {
            return lName;
        }
        public string getPhoneNum()
        {
            return phoneNum;
        }
    }
}
