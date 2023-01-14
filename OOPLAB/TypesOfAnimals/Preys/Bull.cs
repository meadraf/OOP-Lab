using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLAB
{
    class Bull : Preys, IFactory
    {
        public Bull()
        {
            MaxSatiety = 4;
            Saturability = 8;
            RadiusOfView = 20;
            MaxSpeed = 2;
            YoungAge = 20;
        }
        public Animals BorningChild()
        {
            return new Bull();
        }
    }
}
