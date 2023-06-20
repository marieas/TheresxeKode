using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verksted
{
    internal class Mechanic
    {
        List<CarPart> faultyParts { get; set; }
        Car CarToFix { get; set; }
        public Mechanic(Car carToFix)
        {
            CarToFix = carToFix;
            faultyParts = new List<CarPart>(); 
            Console.WriteLine($"{CarToFix.CarType} is entering shop");
        }
        public void CheckCarForFaults()
        {
            foreach (var part in CarToFix.Parts)
            {
                Console.WriteLine($"Mechanic is checking {part.PartName}");

                if (part.Faulty)
                {
                    faultyParts.Add(part);
                    Console.WriteLine($"There is something wrong with {part.PartName}");
                }
                else
                {
                    Console.WriteLine($"Nothing is wrong with {part.PartName}");
                }
            }
        }
        public void FixFaultyParts()
        {
            foreach(var partToFix in faultyParts)
            {
                CarToFix.ReplaceCarPart(partToFix);
            }
            Console.WriteLine("the car is now fixed and can be picked up");
        }
    }
}
