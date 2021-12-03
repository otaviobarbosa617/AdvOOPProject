/*
COMP 2129 - Advanced Object Orientated Programming - Final Project
Janine Mae Usana - 101328279
Omar Nabi - 101339235
Otavio Pereira-Barbosa - 101337690
*/


using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvOOPProject
{
    class Program
    {
        static AirlineCoordinator coordinator;

        public static void DeleteFlight()
        {
            int flightID;
            Console.Clear();
            Console.WriteLine(coordinator.FlightList());
            Console.WriteLine("Please Enter a Fligth ID to delete it:");
            flightID = Convert.ToInt32(Console.ReadLine());
            if (coordinator.DeleteFlight(flightID))
            {
                Console.WriteLine($"Flight ID {flightID} deleted.");
            }
            else
            {
                Console.WriteLine($"Flight ID {flightID} not found");
            }
            Console.WriteLine("\nPress any key to return");
            Console.ReadKey();
        }

        public static void AddFlight()
        {
            int flightNumber, maxSeats;
            string origin, destination;

            Console.Clear();
            Console.WriteLine("\nAdd Flight:\n");
            Console.Write("Flight Number: ");
            flightNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Maximum number of seats: ");
            maxSeats = Convert.ToInt32(Console.ReadLine());
            Console.Write("Origin: ");
            origin = Console.ReadLine();
            Console.Write("Destination: ");
            destination = Console.ReadLine();
            if (coordinator.AddFlight(flightNumber,origin,destination,maxSeats))
            {
                Console.WriteLine("\nFlight added with sucess");
            }
            else
            {
                Console.WriteLine("\nFlight was not added");
            }
            Console.WriteLine("Press any key to return");
            Console.ReadKey();

        }

        public static void ViewFlights()
        {
            Console.Clear();
            Console.WriteLine(coordinator.FlightList());
            Console.WriteLine("\nPress any key to return");
            Console.ReadKey();
        }

        public static void ViewFligth()
        {
            int flightID;
            Console.Clear();
            Console.Write("Enter the flight ID to retrive info:");
            flightID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(coordinator.ViewFligth(flightID).ToString());
            Console.WriteLine("\nPress any key to return");
            Console.ReadKey();
        }

        public static void AddCustomer()
        {
            string firstName, lastName, phoneNumber;
            Console.Clear();
            Console.WriteLine("Customer Menu - Add Customer\n");
            Console.Write("First Name: ");
            firstName = Console.ReadLine();
            Console.Write("\nLast Name: ");
            lastName = Console.ReadLine();
            Console.Write("\nPhone Number: ");
            phoneNumber = Console.ReadLine();
            if (coordinator.AddCustomer(firstName, lastName, phoneNumber))
            {
                Console.WriteLine("\nCustomer added!");
            }
            else
            {
                Console.WriteLine("\nCustomer not added!");
            }
            Console.WriteLine("\nPress any key to return");
            Console.ReadKey();
        }

        public static void ViewCustomers()
        {
            Console.Clear();
            Console.WriteLine("Customer Menu - View All Customers\n");
            Console.WriteLine(coordinator.ViewCustomers());
            Console.WriteLine("\nPress any key to return");
            Console.ReadKey();
        }

        public static void DeleteCustomer()
        {
            int customerId;
            Console.Clear();
            Console.WriteLine("Customer Menu - Delete Customer\n");
            Console.Write("Enter customer ID to be deleted: ");
            customerId = Convert.ToInt32(Console.ReadLine());
            if (coordinator.DeleteCustomer(customerId))
            {
                Console.WriteLine("\nCustomer deleted!");
            }
            else
            {
                Console.WriteLine("\nCustomer not deleted!");
            }
            
            Console.WriteLine("\nPress any key to return");
            Console.ReadKey();
        }

        private static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to XYZ Airlines System\n");
            Console.WriteLine("Type 10 for Visual(GUI) Application\nOr make a selection of the menu below:\n");

            Console.WriteLine("-------- Customer Menu: --------\n");
            Console.WriteLine("1 - Add Customer");
            Console.WriteLine("2 - View Customers");
            Console.WriteLine("3 - Delete Customers\n");

            Console.WriteLine("-------- Flight Menu: --------\n");
            Console.WriteLine("4 - Add Flight");
            Console.WriteLine("5 - View All Fligths");
            Console.WriteLine("6 - View Fligth");
            Console.WriteLine("7 - Delete Flight\n");

            Console.WriteLine("-------- Booking Menu: --------\n");
            Console.WriteLine("8 - Making Booking");
            Console.WriteLine("9 - View Bookings");
            Console.WriteLine("0 - Quit the program\n");

        }

        public static int GetUserChoice()
        {
            int userChoice;
            MainMenu();
            Console.WriteLine("Enter your choice:");
            while (!int.TryParse(Console.ReadLine(), out userChoice) || (userChoice < 1 || userChoice > 12))
            {
                MainMenu();
                Console.WriteLine("\nPlease Enter a Valid choice:");
            }
            return userChoice;
        }

        public static void runProgram()
        {
            int userChoice = GetUserChoice();

            while (userChoice != 0 || userChoice !=10 )
            {
                if (userChoice == 1)
                {
                    AddCustomer();
                }
                if (userChoice == 2)
                {
                    ViewCustomers();
                }
                if (userChoice == 3)
                {
                    DeleteCustomer();
                }

                if (userChoice == 4)
                {
                    AddFlight();
                }
                if (userChoice == 5)
                {
                    ViewFlights();
                }
                if (userChoice == 6)
                {
                    ViewFligth();
                }
                if (userChoice == 7)
                {
                    DeleteFlight();
                }
                if (userChoice == 10)
                {
                    GuiApplication();
                }
                userChoice = GetUserChoice();
            }


        }
        private static void GuiApplication()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainPage());
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            //Uncomment this to show the actual state of program with menus and all:
            coordinator = new AirlineCoordinator(1, 200, 200);
            runProgram();
        }

        










    }
}
