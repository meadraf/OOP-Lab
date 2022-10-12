using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLAB
{
    class GameObject
    {
        public string Type { get; set; }
        public Point Coordinate {get; private set;}
        private int _priority;
    }
}
