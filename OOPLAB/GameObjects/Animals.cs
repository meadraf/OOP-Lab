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
        public int MaxSatiety { get; set; }
        public int MaxSpeed { get; set; }
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

        private bool CheckTargetForPredators(GameObject obj)
        {
            if (obj is Preys || PairingTargetTest(obj))
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
                if (this.GetType() == obj.GetType() && !ReferenceEquals(this, obj))
                {
                    var pairingObj = (Animals)obj;
                    return (pairingObj.Satiety == MaxSatiety);
                }
            }
            return false;
        }

        private bool CheckTargetForPreys(GameObject obj)
        {
            if (obj is Grass)
            {
                var grass = (Grass)obj;
                if (grass.IsGrown)
                {
                    target = obj;
                    return true;
                }
            }
            if (PairingTargetTest(obj))
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

        private void Action(List<GameObject>[,] map)
        {
            if (Satiety == MaxSatiety && target.GetType() == this.GetType())
                Pairing(map);
            else
                Eat(map);
        }

        private Animals DeleteObjectForMove(List<GameObject>[,] map)
        {
            map[Coordinate.X, Coordinate.Y].Remove(this);
            return this;
        }

        private bool OnBound(Point point)
        {
            return Coordinate.X + RadiusOfView == point.X ||
                Coordinate.X - RadiusOfView == point.X ||
                Coordinate.Y + RadiusOfView == point.Y ||
                Coordinate.Y - RadiusOfView == point.Y;
        }

        private Point TargetMovement(GameObject target)
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

            newCoordinate += new Size(Coordinate.X, Coordinate.Y);

            return newCoordinate;
        }

        private void Pairing(List<GameObject>[,] map)
        {
            var pairingAnimals = map[Coordinate.X, Coordinate.Y]
               .Where(animal => animal.GetType() == target.GetType())
               .Select(animal => (Animals)animal)
               .ToList();

            foreach (var animal in pairingAnimals)
            {
                animal.Satiety = 0;
                animal.target = null;
            }
            var newBornAnimal = pairingAnimals.FirstOrDefault();
            newBornAnimal.Add(Coordinate, map);
        }

        private Point ChangeDirection(Point newCoordinate, List<GameObject>[,] map)
        {
            if (newCoordinate.X >= map.GetLength(0))
                newCoordinate.X -= 2;
            if (newCoordinate.X < 0)
                newCoordinate.X += 2;
            if (newCoordinate.Y >= map.GetLength(1))
                newCoordinate.Y -= 2;
            if (newCoordinate.Y < 0)
                newCoordinate.Y += 2;
            return newCoordinate;
        }

        private Point RandomDirection()
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

        public void Add(Point newCoordinate, List<GameObject>[,] map)
        {
            map[newCoordinate.X, newCoordinate.Y].Add(this);
            Coordinate = newCoordinate;
        }

        public virtual void Eat(List<GameObject>[,] map) { }

        public void Move(List<GameObject>[,] map)
        {
            if (this is Preys)
                CheckFieldOfView(map, CheckTargetForPreys);
            else
                CheckFieldOfView(map, CheckTargetForPredators);

            Point newCoordinate;
            var movedObject = DeleteObjectForMove(map);

            if (target != null)
                newCoordinate = TargetMovement(target);
            else
            {
                var random = RandomDirection();
                newCoordinate = random;
                newCoordinate += new Size(Coordinate.X, Coordinate.Y);
                if (!InsideBound(newCoordinate, map))
                    newCoordinate = ChangeDirection(newCoordinate, map);
            }

            Add(newCoordinate, map);
            if (target != null && newCoordinate == target.Coordinate)
                Action(map);

        }
    }
}
