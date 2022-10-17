using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLAB
{
    abstract class Animals : GameObject
    {
        
        private int _satiety = 0;

        public GameObject target;
        public int RadiusOfView { get; set; }
        public int MaxSatiety {get; set;}
        public int NormalSpeed { get; set;}
        public int MaxSpeed { get; set;}

        public int Satiety
        {
            get { return _satiety; }
            set
            {
                _satiety = value;
                if (_satiety > MaxSatiety)
                    _satiety = MaxSatiety;
            }
        }

        public Animals()
        {
            Simulation.Move += Move;
        }

        public void Add(Point newCoordinate, List<GameObject>[,] map)
        {
            map[newCoordinate.X, newCoordinate.Y].Add(this);
            Coordinate = newCoordinate;
        }

        public Animals DeleteObject(List<GameObject>[,] map, string Type)
        {
            
            var deletedObject = map[Coordinate.X, Coordinate.Y]
                .Where(gameObject => gameObject.Type == Type)
                .Select(gameObject => (Animals)gameObject)
                .FirstOrDefault();
            
            map[Coordinate.X, Coordinate.Y].Remove(deletedObject);
            return deletedObject;
        }

        public bool OnBound(Point point)
        {
            return Coordinate.X + RadiusOfView == point.X ||
                Coordinate.X - RadiusOfView == point.X ||
                Coordinate.Y + RadiusOfView == point.Y ||
                Coordinate.Y - RadiusOfView == point.Y;
        }

        public Point TargetMovement(GameObject target)
        {
            Point newCoordinate = new Point();
            Point coordinateDifferences = new Point();

            coordinateDifferences.X = target.Coordinate.X - Coordinate.X;
            coordinateDifferences.Y = target.Coordinate.Y - Coordinate.Y;

            if (MaxSpeed < Math.Abs(coordinateDifferences.X))
                newCoordinate.X = MaxSpeed * Math.Sign(coordinateDifferences.X);
            else
                newCoordinate.X = coordinateDifferences.X;
            if (MaxSpeed < Math.Abs(coordinateDifferences.Y))
                newCoordinate.Y = MaxSpeed * Math.Sign(coordinateDifferences.Y);
            else
                newCoordinate.Y = coordinateDifferences.Y;

            newCoordinate.X += Coordinate.X;
            newCoordinate.Y += Coordinate.Y;

            return newCoordinate;
        }

        public Point RandomDirection()
        {
            Point movePoint = new Point(0, 0);
            Random random = new Random();
            while (movePoint.IsEmpty)
            {
                movePoint.X = random.Next(-1, 2);
                movePoint.Y = random.Next(-1, 2);
            }
            return movePoint;
        }

        public virtual void Eat(List<GameObject>[,] map){}
        
        private void Action(List<GameObject>[,] map)
        {
            if (Satiety == MaxSatiety)
                Pairing(map);
            else
                Eat(map);
        }
        public void Pairing(List<GameObject>[,] map)
        {
            var pairingAnimals = map[Coordinate.X, Coordinate.Y]
               .Where(animal => animal is Animals)
               .Select(animal => (Animals)animal)
               .ToList();

            foreach (var animal in pairingAnimals)
                animal.Satiety = 0;

            var newBornAnimal = pairingAnimals.FirstOrDefault();
            newBornAnimal.Add(Coordinate, map);

        }

        private bool CheckTargetForPredators(GameObject obj)
        {
  
            if(obj is Preys || PairingTargetTest(obj))
            {
                target = obj;
                return true;
            }
            return false;
        }

        private bool PairingTargetTest(GameObject obj)
        {
            if (Satiety == MaxSatiety)
            {
                if (this.GetType() == obj.GetType())
                {
                    var pairingObj = (Animals)obj;
                    return (pairingObj.Satiety == MaxSatiety);
                }
            }
            return false;
        }

        private bool CheckTargetForPreys(GameObject obj)
        {    
            if(obj is Grass || PairingTargetTest(obj))
            {
                target = obj;
                return true;
            }
            return false;
        }

        private bool CheckFieldOfView(List<GameObject>[,] map, Func<GameObject, bool> CheckTarget)
        {
            var isVisited = new HashSet<Point>();
            isVisited.Add(Coordinate);
            var bfs = new Queue<Point>();
            bfs.Enqueue(Coordinate);
            while (bfs.Count != 0)
            {
                var point = bfs.Dequeue();
                foreach (var obj in map[point.X, point.Y])
                {
                    if (CheckTarget(obj))
                        return true;

                }
                if (!OnBound(point))
                    for (int i = -1; i <= 1; i++)
                        for (int j = -1; j <= 1; j++)
                        {
                            var nextPoint = new Point(point.X + i, point.X + j);
                            if (InsideBound(nextPoint, map))
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

        public void Move(List<GameObject>[,] map)
        {

            Point newCoordinate;
            var movedObject = DeleteObject(map, Type);

            if (target != null)
            {
                newCoordinate = TargetMovement(target);
            }
            else
            {
                var random = RandomDirection();
                newCoordinate = random;
                newCoordinate += new Size(Coordinate.X, Coordinate.Y);
                if (!InsideBound(newCoordinate, map))
                {
                    newCoordinate = new Point(random.X * (-1), random.Y * (-1));
                    newCoordinate += new Size(Coordinate.X, Coordinate.Y);
                }
            }
            Add(newCoordinate, map);
            if(newCoordinate == target.Coordinate)
            {
                Action(map);
            }

        }
    }
}
