using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialTest
{
    internal partial class Vehicle
    {
        internal void Drive()
        {
            Console.WriteLine($"Din {Make} {Model} brummar på");
        }
    }
}
