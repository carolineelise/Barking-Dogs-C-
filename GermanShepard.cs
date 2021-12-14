using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkingDogs
{
    class GermanShepard : IIBark
    {
        public string Name { get; set; } = "Kujo";
        public string Color { get; set; } = "Tan and Black";
        public string BarkSound { get; set; } = "WAU WAU";
        public string Bark() { return BarkSound; }
    }

}
