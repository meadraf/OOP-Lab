﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLAB.MoveLogic
{
    class ConcreteMoveLogicB : IConcreteMoveLogic
    {
        void IConcreteMoveLogic.Move(List<GameObject>[,] map, Animals animal)
        {
            if (animal.target is not null && animal.Coordinate == animal.target.Coordinate)
            {
                if (animal.Satiety == animal.MaxSatiety 
                    && animal.target.GetType() == animal.GetType())
                    animal.PairingAnimals(map);
                else
                    animal.Eat(map);
            }
                
        }
    }
}
