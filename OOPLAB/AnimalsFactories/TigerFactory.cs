using System.Drawing;

namespace OOPLAB
{
    class TigerFactory : IGeneration
    {
      public void Generation(List<GameObject>[,] map, Point Coordinate)
        {
            ActionsOnMap.AddObject(Coordinate, map, new Tiger());
        }
    }
}