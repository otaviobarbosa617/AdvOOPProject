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
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MainPage());

            Customer cm1 = new Customer("Otavio", "Anacleto", "Test");
            Customer cm2 = new Customer("Test", "Test", "Test");
            Customer cm3 = new Customer("Otavio", "Anacleto", "Test");
            Console.WriteLine(cm1.ToString());
            Console.WriteLine(cm2.ToString());
            Console.WriteLine(cm3.ToString());
            Console.ReadLine();
        }
    }
}
