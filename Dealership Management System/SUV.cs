using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dealership_Management_System
{
    class SUV : Vehicle
    {
        public SUV(string make, string model, string year, string registrationNumber) : base(make, model, year, registrationNumber)
        {

        }
        protected override void PrintDetails()
        {
            Console.WriteLine("SUV details");
            Console.WriteLine("Make:" + this.make);
            Console.WriteLine("Model:" + this.model);
            Console.WriteLine("Year:" + this.year);
            Console.WriteLine("Registration Number:" + this.registrationNumber);
        }
    }
}
