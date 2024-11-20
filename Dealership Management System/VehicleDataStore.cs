using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dealership_Management_System
{
    class VehicleDataStore
    {
        private List<Vehicle> vehicles;

        public VehicleDataStore()
        {
            this.vehicles = new List<Vehicle>();
        }

        public void create(Vehicle vehicle)
        {
            if(getVehicle(vehicle.getRegistrationNumber()) != null){
                vehicles.Add(vehicle);
            }
            else
            {
                Console.WriteLine($"Vehicle with {vehicle.getRegistrationNumber()} registration number already exists");
            }
        }

        public void update(Vehicle updatedVehicle, string registrationNumber) {

            int index = this.vehicles.FindIndex(car => car.getRegistrationNumber() == registrationNumber);
            if (index != -1)
            {
                vehicles[index] = updatedVehicle;
            }
            else
            {
                Console.WriteLine($"Vehicle with {registrationNumber} registration does not exists");
            }
        }

        public void delete( string registrationNumber) { 
        
        }

        public Vehicle getVehicle(string registrationNumber) {
            return null;
        }

        static public List<Vehicle> getVehicles()
        {
            return this.vehicles;
        }

        public bool vehicleExists(string registrationNumber) {
            
        }
    }

        
   
}
