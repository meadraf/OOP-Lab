using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOPLAB
{
    class Predators : Animals
    {
        public Preys target;

        public void Move(List<GameObject>[,] Map)
        {
            var movedObject = DeleteObject(Map, "Predators");
            if(target != null)
            {
                Point temp = new Point();
                Point coordinateDifferences = new Point(0,0);
                coordinateDifferences.X = Coordinate.X - target.Coordinate.X;
                coordinateDifferences.Y = Coordinate.Y - target.Coordinate.Y;
                if (coordinateDifferences.X < 0) temp.X = Coordinate.X + MaxSpeed / 2;
                else if(coordinateDifferences.X > 0) temp.X = Coordinate.X - MaxSpeed / 2;
                
            }
            else
            {
                
            }
        }

        Animals DeleteObject(List<GameObject>[,]Map, string Type)
        {
            var deletedObject = Map[Coordinate.X, Coordinate.Y]
                .Where(gameObject => gameObject.Type == Type)
                .Select(gameObject => (Animals)gameObject)
                .FirstOrDefault();

            Map[Coordinate.X, Coordinate.Y].Remove(deletedObject);
            return deletedObject;
        }
        public void Eat(List<GameObject>[,] Map)
        {

            var prey = DeleteObject(Map, "Preys");
            Satiety += prey.PreysSaturability;
            

            
        }
        private bool IsOnBound(Point point)
        {
            return Coordinate.X + RadiusOfView == point.X ||
                Coordinate.X - RadiusOfView == point.X ||
                Coordinate.Y + RadiusOfView == point.Y ||
                Coordinate.Y - RadiusOfView == point.Y;
        }
        private bool CheckFieldOfView(GameModel model)
        {
            var isVisited = new HashSet<Point>();
            isVisited.Add(Coordinate);
            var bfs = new Queue<Point>();
            bfs.Enqueue(Coordinate);
            while(bfs.Count != 0)
            {
                var point = bfs.Dequeue();
                foreach (var p in model.Map[point.X, point.Y])
                {
                    if (p.Type == "Preys")
                    {
                        target = (Preys)p;
                        return true;
                    }
                    
                }
                if (!IsOnBound(point))
                    for (int i = -1; i <= 1; i++)
                        for (int j = -1; j <= 1; j++) 
                        {
                            var nextPoint = new Point(point.X+i, point.X+j);
                            if (model.InBounds(nextPoint))
                            {
                                if (!isVisited.Contains(nextPoint))
                                {
                                    isVisited.Add(nextPoint);
                                    bfs.Enqueue(nextPoint);
                                }
                            }
                        }
            }
            return false;
            
        } 
    }
}
