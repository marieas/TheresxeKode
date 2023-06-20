using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verksted
{
    internal class Car
    {
        public List<CarPart> Parts;
        public string CarType { get; set; }
        public Car(string carType)
        {
            CarType = carType;

            Parts = new List<CarPart>()
            {
                new CarPart("Engine",true),
                new CarPart("Breaks", false)
            };
            
        }

        public void ReplaceCarPart(CarPart carPart)
        {
            Parts.Where(part => part.PartName == carPart.PartName && carPart.Faulty).First().FixPart();
        }
    }
}
