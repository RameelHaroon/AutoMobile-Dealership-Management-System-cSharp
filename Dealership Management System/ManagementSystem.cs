using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dealership_Management_System
{
    class ManagementSystem
    {
        public void startSystem()
        {
            bool exit = false;
            Console.WriteLine("Welcome to the System");
            while (!exit) {
                int option = mainMenuOptions();
                switch (option) {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Please enter correct option");
                        break;
                }
            }
        }

        private static int mainMenuOptions()
        {
            try
            {
                Console.WriteLine("Enter 1: Car service");
                Console.WriteLine("Enter 2: Customer service");
                Console.WriteLine("Enter 3 to exit");
                int input = Convert.ToInt32(Console.ReadLine());
                return input;
            }
            catch (Exception ex) { 
                Console.WriteLine(ex);
            }
            return -1;
        }
    }
}
