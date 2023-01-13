using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLAB
{
    class Rabbit : Preys, IFactory
    {
        public Rabbit()
        {
            MaxSpeed = 3;
            MaxSatiety = 1;
            Saturability = 2;
            RadiusOfView = 7;
            YoungAge = 12;
        }
        public Animals BorningChild()
        {
            return new Rabbit();
        }
    }
}
