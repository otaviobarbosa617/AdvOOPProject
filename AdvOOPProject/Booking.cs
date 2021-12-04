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
        private Flight[] flightsBooking;
        private string date;

        public Booking(int maxBooking, string date, Customer c, Flight f )
        {
            numBooking = 0;
            this.maxBooking = maxBooking;
            customerBooking = new Customer[maxBooking];
            flightsBooking = new Flight[maxBooking];
            this.date = date;
        
        }

        //TODO - Finish the booking Class

        //public bool AddBooking(string date, Customer c, Flight f)
        //{
        //    date = DateTime.Now.ToString(@"MM\/dd\/yyyy h\:mm tt");

        //}

    }




}
