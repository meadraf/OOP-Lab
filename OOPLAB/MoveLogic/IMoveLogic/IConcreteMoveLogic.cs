using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLAB
{
    interface IConcreteMoveLogic
    {
        void Move(List<GameObject>[,] map, Animals animal);
    }
}
