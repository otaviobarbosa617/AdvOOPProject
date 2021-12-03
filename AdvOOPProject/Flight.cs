using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvOOPProject
{
    class Flight
    {
        private int flightNumber;
        private string origin;
        private string destination;
        private int maxSeats;
        private int numPassengers;
        private Customer[] passengers;

        public Flight(int flightNumber, string origin, string destination, int maxSeats)
        {
            this.flightNumber = flightNumber;
            this.origin = origin;
            this.destination = destination;
            this.maxSeats = maxSeats;
            numPassengers = 0;
            passengers = new Customer[maxSeats];
        }

        public int getFlightNumber() { return flightNumber; }
        public string getOrigin() { return origin; }
        public string getDestination() { return destination; }
        public int getMaxSeats() { return maxSeats; }
        public int getNumPassengers() { return numPassengers; }

        public bool addPassenger(Customer c)
        {
            if (numPassengers >= maxSeats) { return false; }
            passengers[numPassengers] = c;
            numPassengers++;
            return true;
        }

        public int findPassenger(int custId)
        {
            for (int x = 0; x < maxSeats; x++)
            {
                if (passengers[x].GetCustomerId().Equals(custId))
                    return x;
            }
            return -1;
        }

        public bool removePassenger(int custId)
        {
            int loc = findPassenger(custId);
            if (loc == -1) return false;
            passengers[loc] = passengers[numPassengers - 1];
            numPassengers--;
            return true;
        }

        public string getPassengerList()
        {
            string s = "\nPassengers on flight " + flightNumber + ":";
            for (int x = 0; x < numPassengers; x++)
            {
                s = s + "\n" + passengers[x].GetFirstName() + " " + passengers[x].GetLastName();
            }
            return s;
        }

        public bool IsFull()
        {
            if (numPassengers >= maxSeats)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            string s = "Flight Number: " + flightNumber;
            s = s + "\nOrigin: " + origin;
            s = s + "\nDestination:" + destination;
            s = s + "\nNumber of Passengers:" + numPassengers;
            s = s + "\nAvailable seats:" + (maxSeats - numPassengers);
            s = s + getPassengerList();
            return s;
        }
    }
}
