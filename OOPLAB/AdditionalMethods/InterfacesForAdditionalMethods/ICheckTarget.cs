﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLAB
{
     interface ICheckTarget
    {
        public bool CheckTarget(GameObject target, ObjectWhoCanLookAround animal);
    }
}
