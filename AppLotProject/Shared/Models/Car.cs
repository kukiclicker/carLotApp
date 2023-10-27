using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Car
    {
        public int CarID { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public int Year { get; set; }
        public string CarBody { get; set; }
        public string Mileage { get; set; }
        public string Engine { get; set; }
        public string Transmission { get; set; }
        public string Fuel { get; set; }
        public string Color { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string CarCondition { get; set; }
        public string CarStatus { get; set; }
    }
}
