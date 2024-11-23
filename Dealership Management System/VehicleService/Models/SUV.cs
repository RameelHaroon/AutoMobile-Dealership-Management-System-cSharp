using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dealership_Management_System.VehicleService.Models
{
    class SUV : Vehicle
    {
        public SUV(string make, string model, string year, string registrationNumber) : base(make, model, year, registrationNumber)
        {

        }
        protected override void PrintDetails()
        {
            Console.WriteLine("SUV details");
            Console.WriteLine("Make:" + make);
            Console.WriteLine("Model:" + model);
            Console.WriteLine("Year:" + year);
            Console.WriteLine("Registration Number:" + registrationNumber);
        }
    }
}
