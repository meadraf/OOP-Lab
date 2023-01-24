using System.Drawing;
namespace OOPLAB
{
class GrassGeneration 
    { 
        public GrassGeneration(List<GameObject>[,] map)
        {
        GenerateGrass(55, 45, map); 
        GenerateGrass(26, 20, map);
        GenerateGrass(10, 45, map); 
        GenerateGrass(10, 2, map);
        GenerateGrass(46, 2, map); 
        }
        private void GenerateGrass(int x, int y, List<GameObject>[,] map)
        {  
            int CircleRadius = 0, CircleDiameter = 15; bool CircleCenter = false;
            for(int iter = y; iter < y + CircleDiameter; iter++) 
            {
                for(int j = x - CircleRadius; j <= x + CircleRadius; j++) 
                {
                    var grass = new Grass();
                    grass.Coordinate = new Point(j, iter);
                    ActionsOnMap.AddObject(grass.Coordinate, map, grass);
                }               
                if(CircleRadius == 7) CircleCenter = true;
                if(CircleCenter) CircleRadius--;
                else CircleRadius++;
            }   
        }    
    }
}



