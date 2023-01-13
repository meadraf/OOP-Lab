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
            Simulation simulation = new Simulation(gameModel.map);
            simulation.Start();

        }
    }
}


