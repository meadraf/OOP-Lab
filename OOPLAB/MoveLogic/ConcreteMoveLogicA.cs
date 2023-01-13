using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLAB
{
    class ConcreteMoveLogicA : IConcreteMoveLogic
    {
        void IConcreteMoveLogic.Move(List<GameObject>[,] map, Animals animal)
        {
            ActionsOnMap.AddObject(animal.Coordinate, map, new ChildPoops(map));
        }
    }
}
