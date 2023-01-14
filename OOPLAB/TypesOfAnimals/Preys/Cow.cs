using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLAB
{
    class Cow : Preys, IFactory
    {
        public Cow()
        {
            MaxSatiety = 3;
            Saturability = 5;
            RadiusOfView = 20;
            MaxSpeed = 2;
            YoungAge = 10;
        }
        public Animals BorningChild()
        {
            return new Cow();
        }
    }
}
