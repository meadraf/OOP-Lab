using System.Drawing;

namespace OOPLAB
{
    class BearFactory : IGeneration
    {
      public void Generation(List<GameObject>[,] map, Point Coordinate)
        {
            ActionsOnMap.AddObject(Coordinate, map, new Bear());
        }
    }
}