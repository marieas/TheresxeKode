using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verksted
{
    class CarPart
    {
        public string PartName { get; set; }
        public bool Faulty { get; set; }
        public CarPart(string partName, bool faulty)
        {
            PartName = partName;
            Faulty = faulty;
        }

        public void FixPart()
        {
            Faulty = false;
            Console.WriteLine($"{PartName} is being fixed");
        }
    }
}
