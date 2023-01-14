namespace OOPLAB;

static class StatisticsOutput
{
    public static void Print(this Statistics statistics)
    {
        Console.WriteLine("Turn " + statistics.TurnsCount + ":");
        Console.WriteLine("Number of predators: " + statistics.CurrentTurnInfo.PredatorsCount);
        Console.WriteLine("Number of preys: " + statistics.CurrentTurnInfo.PreysCount);
        Console.WriteLine("\nSum of animals: " + statistics.CurrentTurnInfo.AnimalsCount + "\n");

        PrintPredatorSpeciety(statistics, typeof(Bear));
        PrintPredatorSpeciety(statistics, typeof(Hyena));
        PrintPredatorSpeciety(statistics, typeof(Tiger));
        PrintPredatorSpeciety(statistics, typeof(Wolf));

        Console.WriteLine();

        PrintPreySpeciety(statistics, typeof(Bull));
        PrintPreySpeciety(statistics, typeof(Cow));
        PrintPreySpeciety(statistics, typeof(Rabbit));
        PrintPreySpeciety(statistics, typeof(Sheep));

        Console.WriteLine();

        if (statistics.TurnsCount == Simulation.MaxTurns)
        {
            DrawGraph(statistics);
        }
    }

    private static void PrintPredatorSpeciety(this Statistics statistics, Type type)
    {
        if (statistics.CurrentTurnInfo.PredatorSpecietyCounter.ContainsKey(type))
            Console.WriteLine(type.ToString().Replace("OOPLAB.", "") + "s: " +
                              statistics.CurrentTurnInfo.PredatorSpecietyCounter[type]);
    }

    private static void PrintPreySpeciety(this Statistics statistics, Type type)
    {
        if (statistics.CurrentTurnInfo.PreySpecietyCounter.ContainsKey(type))
            Console.WriteLine(type.ToString().Replace("OOPLAB.", "") + "s: " +
                              statistics.CurrentTurnInfo.PreySpecietyCounter[type]);
    }

    private static void DrawGraph(this Statistics statistics)
    {
        var turnScale = 4;
        var countScale = 25;
        var graphY = 20;

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(500 + " animals");

        for (int i = graphY; i >= 0; i--)
        {
            Console.Write("   | ");

            for (int j = 0; j < Simulation.MaxTurns / turnScale; j++)
            {
                if (statistics[j * turnScale].PredatorsCount / countScale == i)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(".");
                }
                else if (statistics[j * turnScale].PreysCount / countScale == i)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(".");
                }
                else
                    Console.Write(" ");
            }

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine();
        }

        Console.Write(0);
        Console.Write("  |");
        for (int i = 0; i < Simulation.MaxTurns / turnScale; i++)
        {
            Console.Write("_");
        }

        Console.WriteLine(" " + Simulation.MaxTurns + " turns");

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Predators: ■");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Preys: ■");
    }
}