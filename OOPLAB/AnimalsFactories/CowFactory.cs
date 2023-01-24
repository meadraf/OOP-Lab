using System.Drawing;

namespace OOPLAB
{
    class CowFactory : IGeneration
    {
        public void Generation(List<GameObject>[,] map, Point Coordinate)
        {
            ActionsOnMap.AddObject(Coordinate, map, new Cow());
        }
    }
}