using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLAB
{
    class Tiger : Predators
    {
        public Tiger()
        {
            Type = "Predators";
            MaxSatiety = 15;
            NormalSpeed = 2;
            MaxSpeed = 3;
            RadiusOfView = 6;
        }
    }
}
