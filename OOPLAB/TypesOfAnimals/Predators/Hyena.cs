using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLAB
{
    class Hyena : Predators, IFactory
    {
        public Hyena()
        {
            MaxSatiety = 20;
            MaxSpeed = 3;
            RadiusOfView = 4;
            YoungAge = 18;
        }
        public Animals BorningChild()
        {
            return new Hyena();
        }
    }
}
