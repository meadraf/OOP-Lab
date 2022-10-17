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
        public int Saturability { get; set; }
        public string Type { get; set; }
        public Point Coordinate {get; set;}

        private int _priority;

        public bool InsideBound(Point point, List<GameObject>[,] map)
        {
            return point.X >= 0 && point.Y >= 0
                                && point.X < map.GetLength(0) && point.Y < map.GetLength(1);
        }
    }
}