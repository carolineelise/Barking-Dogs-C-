using System;
using System.Collections.Generic;

namespace BarkingDogs
{
    class Program
    {
        static void Main(string[] args)
        {
            var dogs = new List<IIBark>()
            { new Collie(), new Chiuaua(), new GermanShepard() };

            foreach (var dog in dogs) { Console.WriteLine($"My dog {dog.Name} says {dog.Bark()}");
                var chichi = dog as Chiuaua;
                if (chichi != null) { Console.WriteLine($"Walk Rat with me"); }
            }
            }
    }
}
