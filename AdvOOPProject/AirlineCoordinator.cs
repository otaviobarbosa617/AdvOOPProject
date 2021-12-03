using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvOOPProject
{
    class AirlineCoordinator
    {
        FlightManager flightManager;
        CustomerManager customerManager;

        public AirlineCoordinator(int custIdSeed, int maxCustomers, int maxFlights)
        {
            flightManager = new FlightManager(maxFlights);
            customerManager = new CustomerManager(maxCustomers);
        }

        public bool AddFlight(int flightNumber, string origin, string destination, int maxSeats)
        {
            return flightManager.AddFlight(flightNumber, origin, destination, maxSeats);
        }

        public string FlightList()
        {
            return flightManager.GetFlightList();
        }

        public bool DeleteFlight(int flightId)
        {
            return flightManager.DeleteFlight(flightId);
        }

        public int ViewFligth(int fligthId)
        {
            //this one is waiting for the view ONE flight method on flight manager
            return flightManager.FindFlight(fligthId);
        }

        public bool AddCustomer(string firstName, string lastName, string phoneNumber)
        {
            return customerManager.AddAccount(firstName, lastName, phoneNumber);
        }

        public string ViewCustomers()
        {
            return customerManager.ToString();
        }

        public bool DeleteCustomer(int customerId)
        {
            return customerManager.DeleteCustomer(customerId);
        }

    }
}
