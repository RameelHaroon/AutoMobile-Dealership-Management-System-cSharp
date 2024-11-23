using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dealership_Management_System.VehicleService.Models
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

        // Getter and Setters
        public void setRegistrationNumber(string registrationNumber) { this.registrationNumber = registrationNumber; }
        public string getRegistrationNumber() { return registrationNumber; }
        public void setMake(string make) { this.make = make; }
        public string getMake() { return make; }

        public void setModel(string model) { this.model = model; }

        public string getModel() { return model; }

        public void setYear(string year) { this.year = year; }
        public string getYear() { return year; }
    }
}
