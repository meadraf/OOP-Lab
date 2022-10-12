﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLAB
{
     interface IAnimals
    {
        void Move(List<GameObject>[,]Map);
        void Eat(List<GameModel>[,]Map);
        void Pairing();

    }
}
