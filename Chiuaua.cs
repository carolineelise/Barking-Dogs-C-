using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkingDogs
{
    class Chiuaua : IIBark
    {
        public string Name { get; set; } = "Rat";
        public string Color { get; set; } = "White";
        public string BarkSound { get; set; } = "Keff Keff Keff";
        public string Bark() { return BarkSound; }
        public string Walk() { return "Let's Go!"; }
    }

}
