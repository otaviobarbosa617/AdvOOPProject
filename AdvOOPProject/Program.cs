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
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            AirlineCoordinator adminCoord = new AirlineCoordinator();
            runProgram();

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
            while (!int.TryParse(Console.ReadLine(), out userChoice) || (userChoice > 1 || userChoice < 12)) 
            {
                MainMenu();
                Console.WriteLine("\nPlease Enter a Valid choice:");
            }
            return userChoice;
        }

        private static void GuiApplication()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainPage());
        }

        public static void runProgram()
        {
            int userChoice = GetUserChoice();
            if (userChoice == 1)
            {
                Console.Clear();
                AddCustomer();
            }
            if (userChoice == 10)
            {
                GuiApplication();
            }
        }

        public static void AddCustomer()
        {
            

            
        }
    }
}
