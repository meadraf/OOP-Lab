using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;

namespace OOPLAB
{
    class Predators : Animals
    {
        public override void Eat(List<GameObject>[,] map)
        {
            var prey = DeleteObject(map, "Preys");
            Satiety += prey.Saturability;
        }
       
    }
}
