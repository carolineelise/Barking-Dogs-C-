using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkingDogs
{
    class Collie : IIBark
    {
        public string Name { get; set; } = "Lassie";
        public string Color { get; set; } = "Black and White";
        public string BarkSound { get; set; } = "Bow Bow";
        public string Bark() { return BarkSound; }
    }
}
