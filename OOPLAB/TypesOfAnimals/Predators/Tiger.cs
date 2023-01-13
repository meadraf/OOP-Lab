using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLAB
{
    class Tiger : Predators, IFactory
    {
        public Tiger()
        {
            MaxSatiety = 30;
            MaxSpeed = 3;
            RadiusOfView = 4;
            YoungAge = 23;
        }
        public Animals BorningChild()
        {
            return new Tiger();
        }
    }
}
