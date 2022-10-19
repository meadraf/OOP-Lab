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
            MaxSatiety = 12;
            MaxSpeed = 3;
            RadiusOfView = 4;
        }
    }
}
