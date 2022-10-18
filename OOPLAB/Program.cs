using OOPLAB;
using System;
using System.Drawing;

namespace OOPLAB
{
    class Program
    {
        
        static void Main()
        {
            GameModel gameModel = new GameModel();
            //List<GameObject>[,] map;

            //map = new List<GameObject>[64, 64];
            //for (int i = 0; i < 64; i++)
            //{
            //    for (int j = 0; j < 64; j++)
            //    {
            //        map[i, j] = new List<GameObject>();
            //    }
            //}
            Simulation simulation = new Simulation(gameModel.map);
            simulation.Start();
            //var bear = new Bear();
            //var sheep = new Sheep();
            //bear.Add(new Point(3, 3), map);
            //sheep.Add(new Point(3, 10), map);
            //bear.Move(map);
            //for (int i = 0; i < 50; i++)
            //{
            //    bear.Move(map);
            //    Console.WriteLine("{0}, {1} ", bear.Coordinate.X, bear.Coordinate.Y);
            //}
            //map[3,10].Add(new Grass());
            //sheep.Move(map);
        }
    }
}


