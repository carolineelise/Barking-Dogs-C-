using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkingDogs
{
    class GenericDog
    { 
        public string Name { get; set; } = "Clifford";
        public string Color { get; set; } = "Red";
        public string BarkSound { get; set; } = "Gaua Gaua";
        public string Bark() { return BarkSound; }
    }
}
                    //CAN SET THIS AS AN INTERFACE AND HAVE NO PROPERTIES IN THE OTHER DOGS