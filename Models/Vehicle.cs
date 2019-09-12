using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace webdb.Models
{
    public class Vehicle 
    {
        public int Id {get; set;}
        [Required]        
        public string Registration {get; set;}
        [Required]
        public string VehicleType {get; set;}
    }
}