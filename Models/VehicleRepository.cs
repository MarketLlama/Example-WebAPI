using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace webdb.Models
{
    public class VehicleRepository : IVehicleRepository
    {
        private List<Vehicle> _vehicleList;

        public VehicleRepository()
        {

        }
        public Vehicle Add(Vehicle vehicle)
        {
            throw new NotImplementedException();
        }

        public Vehicle Delete(int Id)
        {
            Vehicle vehicle = _vehicleList.FirstOrDefault(v => v.Id == Id);

            if(vehicle != null)
            {
                _vehicleList.Remove(vehicle);
            }
            return vehicle;
        }

        public IEnumerable<Vehicle> GetAllVehicle()
        {
            return _vehicleList;
        }

        public Vehicle GetVehicle(int Id)
        {
            return _vehicleList.FirstOrDefault(v => v.Id == Id);
        }

        public Vehicle Update(Vehicle vehicleChanges)
        {
            Vehicle vehicle = _vehicleList.FirstOrDefault(v => v.Id == vehicleChanges.Id);

            if(vehicle != null)
            {
                vehicle.Registration = vehicleChanges.Registration;
                vehicle.VehicleType = vehicleChanges.VehicleType;
            }
            return vehicle;
        }
    }
}