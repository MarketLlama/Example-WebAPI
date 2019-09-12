using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webdb.Models
{
    public interface IVehicleRepository
    {
        Vehicle GetVehicle(int Id);
        IEnumerable<Vehicle> GetAllVehicle();
        Vehicle Add(Vehicle vehicle);
        Vehicle Update(Vehicle vehicleChanges);
        Vehicle Delete(int Id); 
    }
}