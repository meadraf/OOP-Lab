using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;

namespace OOPLAB
{
    class Predators : Animals
    {
        private Preys EatingPreys(List<GameObject>[,] map)
        {
            var deletedObject = map[Coordinate.X, Coordinate.Y]
                .Where(gameObject => gameObject == target)
                .Select(gameObject => (Preys)gameObject)
                .FirstOrDefault();

            map[Coordinate.X, Coordinate.Y].Remove(deletedObject);
            return deletedObject;
        }

        public override void Eat(List<GameObject>[,] map)
        {
            var prey = EatingPreys(map);
            if (prey != null)
                Satiety += prey.Saturability;
        }
    }
}
