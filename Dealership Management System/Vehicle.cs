using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dealership_Management_System
{
    abstract class Vehicle
    {
        protected string make { get; set; }
        protected string model { get; set; }
        protected string year { get; set; }
        protected string registrationNumber { get; set; }

        public Vehicle(string make, string model, string year, string registrationNumber)
        {
            this.make = make;   
            this.model = model; 
            this.year = year;
            this.registrationNumber = registrationNumber;
        }
        protected abstract void PrintDetails();
    }
}
