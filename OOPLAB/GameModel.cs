using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLAB
{

    class GameModel
    {
        public List<GameObject>[,] Map = new List<GameObject>[64, 64];
        public Random RandomValue = new Random();
        // Map = new List<GameObject>[64, 64];
        
        public bool InBounds(Point point)
        {
            return point.X >= 0 && point.Y >= 0
                && point.X <= Map.GetLength(0) && point.Y <= Map.GetLength(1);
        }
    }
}
