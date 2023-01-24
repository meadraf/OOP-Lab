using System.Drawing;

namespace OOPLAB
{
    class HyenaFactory : IGeneration
    {
       public void Generation(List<GameObject>[,] map, Point Coordinate)
        {
            ActionsOnMap.AddObject(Coordinate, map, new Hyena());
        } 
    }
}