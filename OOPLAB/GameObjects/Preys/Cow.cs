using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLAB
{
    class Cow : Preys
    {
        public Cow()
        {
            Type = "Preys";
            NormalSpeed = 1;
            MaxSatiety = 4;
            PreysSaturability = 5;
        }
    }
}
