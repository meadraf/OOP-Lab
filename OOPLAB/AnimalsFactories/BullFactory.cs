using System.Drawing;

namespace OOPLAB
{
    class BullFactory : IGeneration
    {
        public void Generation(List<GameObject>[,] map, Point Coordinate)
        {
             ActionsOnMap.AddObject(Coordinate, map, new Bull()); 
        }
    }
}