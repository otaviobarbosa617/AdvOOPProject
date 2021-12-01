/*
COMP 2129 - Advanced Object Orientated Programming - Final Project
Janine Mae Usana - 
Omar Nabi - 
Otavio Pereira-Barbosa - 101337690
*/


using System;
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
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            //testing the customer id:
            CustomerManager cm = new CustomerManager(10);
            cm.addAccount("otavio", "barbosa", "6475623407");
            cm.addAccount("luciane", "11111111");

            Console.Write(cm.ToString());

        }
    }
}
