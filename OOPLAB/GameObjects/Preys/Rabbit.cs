using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLAB
{
    class Rabbit : Preys
    {
        public Rabbit()
        {
            Type = "Preys";
            NormalSpeed = 2;
            MaxSpeed = 3;
            MaxSatiety = 1;
            Saturability = 2;
            RadiusOfView = 4;
        }
    }
}
