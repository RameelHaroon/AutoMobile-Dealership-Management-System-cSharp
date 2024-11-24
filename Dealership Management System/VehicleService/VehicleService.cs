using Dealership_Management_System.VehicleService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dealership_Management_System.VehicleService
{
    class VehicleService
    {
        private VehicleDataStore vehicleDataStore;
        public VehicleService() { 
            this.vehicleDataStore = new VehicleDataStore();
        }

        public void addVehicle()
        {
            Vehicle newVehicle = createVehicle();
            if (newVehicle != null)
            {
                this.vehicleDataStore.create(newVehicle);
            }
            else
            {
                Console.WriteLine("UNSUCCESSFULL");
            }
        }

        public void updateVehicle()
        {
            Vehicle updatedVehicle = createVehicle();
            string registraion = Console.ReadLine();
            if (updatedVehicle != null && registraion != null)
            {
                this.vehicleDataStore.update(updatedVehicle, updatedVehicle.getRegistrationNumber());
            }
            else
            {
                Console.WriteLine("UNSUCCESSFULL");
            }
        }

        public void deleteVehicle()
        {
            string registraion = Console.ReadLine();
            if (registraion != null)
            {
                this.vehicleDataStore.delete(registraion);
            }
            else
            {
                Console.WriteLine("UNSUCCESSFULL");
            }
        }

        private Vehicle? createVehicle()
        {
            Vehicle vehicle = null;

            try
            {
                Console.WriteLine("Press 1 for Sedan and 2 for SUV");
                int option = Convert.ToInt32(Console.ReadLine());
                string type = "";

                switch (option)
                {
                    case 1:
                        type = "Sedan";
                        break;
                    case 2:
                        type = "SUV";
                        break;
                }
                Console.WriteLine("Enter car Make");
                string make = Console.ReadLine();
                Console.WriteLine("Enter car Model");
                string model = Console.ReadLine();
                Console.WriteLine("Enter car year");
                string year = Console.ReadLine();
                Console.WriteLine("Enter car Registration number");
                string registration = Console.ReadLine();
                vehicle = new Sedan(make, model, year, registration, type);
            }
            catch (Exception ex) { 
                Console.WriteLine(ex.Message);
            }

            return vehicle;
        }
    }
}
