using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dealership_Management_System.VehicleService.Models
{
    class Sedan : Vehicle
    {
        public Sedan(string make, string model, string year, string registrationNumber, string type) : base(make, model, year, registrationNumber, type)
        {

        }
        protected override void PrintDetails()
        {
            Console.WriteLine("Sedan details");
            Console.WriteLine("Make:" + make);
            Console.WriteLine("Model:" + model);
            Console.WriteLine("Year:" + year);
            Console.WriteLine("Registration Number:" + registrationNumber);
        }
    }
}
