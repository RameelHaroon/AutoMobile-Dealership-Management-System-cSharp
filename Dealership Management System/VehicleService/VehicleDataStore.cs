using Dealership_Management_System.VehicleService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dealership_Management_System.VehicleService
{
    /// <summary>
    /// Class to store all the vehicles data and responsible for storing, updating and deleting vehicle related data
    /// </summary>
    class VehicleDataStore
    {
        private List<Vehicle> vehicles;
        static private VehicleDataStore instance = null;

        private VehicleDataStore()
        {
            vehicles = new List<Vehicle>();
        }

        /// <summary>
        /// Applying singleton pattern, only one instance of the datastore can exist
        /// </summary> 
        public VehicleDataStore getInstance()
        {
            if (instance == null) { 
                return new VehicleDataStore();
            }

            return instance;
        }

        public void create(Vehicle vehicle)
        {
            if (getVehicle(vehicle.getRegistrationNumber()) != null)
            {
                vehicles.Add(vehicle);
            }
            else
            {
                Console.WriteLine($"Vehicle with {vehicle.getRegistrationNumber()} registration number already exists");
            }
        }

        public void update(Vehicle updatedVehicle, string registrationNumber)
        {

            int index = vehicles.FindIndex(car => car.getRegistrationNumber() == registrationNumber);
            if (index != -1)
            {
                vehicles[index] = updatedVehicle;
            }
            else
            {
                Console.WriteLine($"Vehicle with {registrationNumber} registration does not exist");
            }
        }

        public void delete(string registrationNumber)
        {

            int index = vehicles.FindIndex(car => car.getRegistrationNumber() == registrationNumber);
            if (index != -1)
            {
                vehicles.RemoveAt(index);
            }
            else
            {
                Console.WriteLine($"Vehicle with {registrationNumber} registration does not exist");
            }
        }

        public Vehicle? getVehicle(string registrationNumber)
        {

            int index = vehicles.FindIndex(car => car.getRegistrationNumber() == registrationNumber);
            if (index != -1)
            {
                return vehicles[index];
            }

            Console.WriteLine($"Vehicle with {registrationNumber} registration does not exist");

            return null;
        }

        public List<Vehicle> getVehicles()
        {
            return this.vehicles;
        }

    }

}
