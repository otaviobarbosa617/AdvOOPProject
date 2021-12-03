using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvOOPProject
{
    class BookingManager
    {
        private int numBooking;
        private int maxBooking;
        private Booking[] bookList;

        public BookingManager(int maxBooking)
        {
            numBooking = 0;
            this.maxBooking = maxBooking;
            bookList = new Customer[maxBooking];
        }

        public bool addBooking(Customer c, Flight f)
        {
            if (!f.IsFull())
            {
                string date = DateTime.Now.ToString(@"MM\/dd\/yyyy h\:mm tt");
                f.addPassenger(c);
                Booking book = new Booking(date, c, f);
                //           Booking book = new Booking(date, c, f, currentBookNumber);            //from prof testing
                //           currentBookNumber++;
                bookList[numBooking] = book;
                numBooking++;
                return true;
            }
            return false;
        }


    }
}
