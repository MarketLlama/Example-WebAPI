using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webdb.Models
{
    public class SQLVehicleRepository : IVehicleRepository
    {
        public SQLVehicleRepository(AppDbContext context)
        {
            Context = context;
        }

        public AppDbContext Context { get; }

        public Vehicle Add(Vehicle vehicle)
        {
            Context.Vehicles.Add(vehicle);
            Context.SaveChanges();
            return vehicle;
        }

        public Vehicle Delete(int Id)
        {
            Vehicle vehicle = Context.Vehicles.Find(Id);
            if(vehicle != null)
            {
                Context.Vehicles.Remove(vehicle);
                Context.SaveChanges();
            }
            return vehicle;
        }

        public IEnumerable<Vehicle> GetAllVehicle()
        {
            return Context.Vehicles;
        }

        public Vehicle GetVehicle(int Id)
        {
            return Context.Vehicles.Find(Id);
        }

        public Vehicle Update(Vehicle vehicleChanges)
        {
            var vehicle = Context.Vehicles.Attach(vehicleChanges);
            vehicle.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            Context.SaveChanges();
            return vehicleChanges;
        }
    }
}