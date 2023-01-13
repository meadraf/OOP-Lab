using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLAB
{
    abstract class Preys : Animals
    {
        public override void Eat(List<GameObject>[,] map)
        {
            var Grass = (Grass)map[Coordinate.X, Coordinate.Y][0];
            Grass.Eaten();
            Satiety += Grass.Saturability;
            target = null;
        }
    }
}
