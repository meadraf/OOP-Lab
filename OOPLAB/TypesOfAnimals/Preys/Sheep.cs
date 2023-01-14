using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLAB
{
    class Sheep : Preys, IFactory
    {
        public Sheep()
        {
            MaxSatiety = 2;
            Saturability = 4;
            RadiusOfView = 20;
            MaxSpeed = 2;
            YoungAge = 12;
        }
        public Animals BorningChild()
        {
            return new Sheep();
        }
    }
}
