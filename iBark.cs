using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkingDogs
{
    interface IIBark
    {
        string Name { get; set; }
        string Color { get; set; }
        string BarkSound { get; set; }
        string Bark();
    }
}
