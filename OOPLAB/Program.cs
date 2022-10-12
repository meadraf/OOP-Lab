using OOPLAB;
using System;

namespace OOPLAB
{
    class Program
    {
        
        static void Main()
        {
            var Map = new List<GameObject>[128, 128];
            for (int i = 0; i < 128; i++)
                for (int j = 0; j < 128; j++)
                    Map[i, j] = new List<GameObject>();
            var boba = new Bear();
            Map[0, 0].Add(boba);
            Map[0, 0].Add(new Cow());
            boba.Eat(Map);
            Console.WriteLine(boba.Satiety);

        }
        
    }
}


