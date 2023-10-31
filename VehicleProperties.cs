using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialTest
{
    internal partial class Vehicle
    {
        public Vehicle(string make, string model)
        {
            Make = make;
            Model = model;
        }
        public string Make { get; set; }
        public string Model { get; set; }
    }
}
