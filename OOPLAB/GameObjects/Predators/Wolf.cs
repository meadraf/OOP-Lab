using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLAB
{
    class Wolf : Predators
    {
        public Wolf()
        {
            Type = "Predators";
            MaxSatiety = 12;
            NormalSpeed = 2;
            MaxSpeed = 3;
            RadiusOfView = 6;
        }
    }
}
