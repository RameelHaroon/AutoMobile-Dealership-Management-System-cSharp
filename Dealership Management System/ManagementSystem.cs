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
            Console.WriteLine("Welcome to the System");
            while (true) {
                int option = mainMenuOptions();
                switch (option) {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
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
                Console.WriteLine("Enter 1 to Order a new car");
                Console.WriteLine("Enter 2 for stock inquiry");
                Console.WriteLine("Enter 3 to register new customer");
                Console.WriteLine("Enter 4 to search exiting customer");
                Console.WriteLine("Enter 5 for car details");
                Console.WriteLine("Enter 6 to exit");
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
