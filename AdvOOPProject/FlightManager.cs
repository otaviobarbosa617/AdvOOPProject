using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvOOPProject
{
    class FlightManager
    {
        private int maxFlights;
        private int numFlights;
        private Flight[] flightList;

        public FlightManager(int maxFlights)
        {
            this.maxFlights = maxFlights;
            numFlights = 0;
            flightList = new Flight[maxFlights];
        }

        public bool AddFlight(int flightNumber, string origin, string destination, int maxSeats)
        {
            if (numFlights >= maxFlights) { return false; }
            Flight f = new Flight(flightNumber, origin, destination, maxSeats);
            flightList[numFlights] = f;
            numFlights++;
            return true;
        }

        public int FindFlight(int flightId)
        {
            for (int i = 0; i < numFlights; i++)
            {
                if (flightList[i].getFlightNumber() == flightId)
                {
                    return i;
                }
            }
            return -1;
        }
        public Flight FlightExists(int flightId)
        {
            int loc = FindFlight(flightId);
            if (flightId == -1)
            {
                return null;
            }
            return flightList[loc];
        }

        public bool DeleteFlight(int flightId)
        {
            int loc = FindFlight(flightId);
            if (loc == 1)
            {
                return false;
            }
            flightList[loc] = flightList[numFlights - 1];
            numFlights--;
            return true;
        }

        public string GetFlightList()
        {
            string s = "Flight List:";
            for (int i = 0; i < numFlights; i++)
            {
                s += $"\n{flightList[i].getFlightNumber()} from {flightList[i].getOrigin()} to {flightList[i].getDestination()}";
            }
            return s;
        }

        //We need to do this method to view one specific flight but I cannot think how it could make it
        //public string ViewFlight(int flightID)
        //{

        //}
    }
}
