using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvOOPProject
{
    class Booking
    {
        private int numBooking;
        private int maxBooking;
        private Customer[] customerBooking;

        public Booking(int maxBooking)
        {
            numBooking = 0;
            this.maxBooking = maxBooking;
            customerBooking = new Customer[maxBooking];
        }

        public bool AddBooking()
        {

        }

    }




}
