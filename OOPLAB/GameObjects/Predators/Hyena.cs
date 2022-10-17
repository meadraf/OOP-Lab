using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLAB
{
    class Hyena : Predators
    {
        public Hyena()
        {
            Type = "Predators";
            MaxSatiety = 10;
            NormalSpeed = 2;
            MaxSpeed = 3;
            RadiusOfView = 4;
        }
    }
}
