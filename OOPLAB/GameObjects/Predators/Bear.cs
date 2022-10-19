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
            MaxSatiety = 20;
            MaxSpeed = 2;
            RadiusOfView = 3;
        }
    }
}
