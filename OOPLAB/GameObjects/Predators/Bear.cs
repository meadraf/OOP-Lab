using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLAB
{
    class Bear : Predators
    {
        
        public Bear()
        {
            Type = "Predators";
            MaxSatiety = 20;
            NormalSpeed = 1;
            MaxSpeed = 2;
            RadiusOfView = 5;

        }
    }
}
