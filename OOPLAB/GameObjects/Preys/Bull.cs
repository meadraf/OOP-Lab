using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLAB
{
    class Bull : Preys
    {
        public Bull()
        {
            Type = "Preys";
            NormalSpeed = 2;
            MaxSatiety = 6;
            PreysSaturability = 8;
        }
    }
}
