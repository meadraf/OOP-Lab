using System.Drawing;

namespace OOPLAB
{
    class WolfFactory : IGeneration
    {
        public void Generation(List<GameObject>[,] map, Point Coordinate)
        {
            ActionsOnMap.AddObject(Coordinate, map, new Wolf());
        }
    }
}