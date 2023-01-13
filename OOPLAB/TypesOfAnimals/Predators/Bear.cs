using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLAB
{
    class Bear : Predators, IFactory
    {
        
        public Bear()
        {
            MaxSatiety = 40;
            MaxSpeed = 2;
            RadiusOfView = 3;
            YoungAge = 20;
        }

        public Animals BorningChild()
        {
            return new Bear();
        }
    }
}
