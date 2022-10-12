using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLAB
{
    class Sheep : Preys
    {
        public Sheep()
        {
            Type = "Preys";
            NormalSpeed = 1;
            MaxSatiety = 3;
            PreysSaturability = 4;
        }
    }
}
