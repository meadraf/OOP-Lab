namespace OOPLAB;

public static class StatisticsOutput
{
    public static void Print(this Statistics statistics)
    {
        Console.WriteLine("Turn " + statistics.TurnsCount + ":");
        Console.WriteLine("Number of predators: " + statistics.PredatorsCount);
        Console.WriteLine("Number of preys: " + statistics.PreysCount);
        Console.WriteLine("\nSum of animals: " + statistics.AnimalsCount);
    }
}