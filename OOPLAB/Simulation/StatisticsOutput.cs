namespace OOPLAB;

static class StatisticsOutput
{
    public static void Print(this Statistics statistics)
    {
        Console.WriteLine("Turn " + statistics.TurnsCount + ":");
        Console.WriteLine("Number of predators: " + statistics.PredatorsCount);
        Console.WriteLine("Number of preys: " + statistics.PreysCount);
        Console.WriteLine("\nSum of animals: " + statistics.AnimalsCount +"\n");
        
        Console.WriteLine("Bears: " + statistics.PredatorSpecietyCounter[typeof(Bear)]);
        Console.WriteLine("Hyenas: " + statistics.PredatorSpecietyCounter[typeof(Hyena)]);
        Console.WriteLine("Tigers: " + statistics.PredatorSpecietyCounter[typeof(Tiger)]);
        Console.WriteLine("Wolfs: " + statistics.PredatorSpecietyCounter[typeof(Wolf)]);
        Console.WriteLine();
        
        Console.WriteLine("Bulls: " + statistics.PreySpecietyCounter[typeof(Bull)]);
        Console.WriteLine("Cows: " + statistics.PreySpecietyCounter[typeof(Cow)]);
        Console.WriteLine("Rabbits: " + statistics.PreySpecietyCounter[typeof(Rabbit)]);
        Console.WriteLine("Sheeps: " + statistics.PreySpecietyCounter[typeof(Sheep)]);
    }
}