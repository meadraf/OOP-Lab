namespace OOPLAB;

static class StatisticsOutput
{
    public static void Print(this Statistics statistics)
    {
        Console.WriteLine("Turn " + statistics.TurnsCount + ":");
        Console.WriteLine("Number of predators: " + statistics.PredatorsCount);
        Console.WriteLine("Number of preys: " + statistics.PreysCount);
        Console.WriteLine("\nSum of animals: " + statistics.AnimalsCount +"\n");
        if(statistics.PredatorSpecietyCounter.ContainsKey(typeof(Bear)))
            Console.WriteLine("Bears: " + statistics.PredatorSpecietyCounter[typeof(Bear)]);
        if (statistics.PredatorSpecietyCounter.ContainsKey(typeof(Hyena)))
            Console.WriteLine("Hyenas: " + statistics.PredatorSpecietyCounter[typeof(Hyena)]);
        if (statistics.PredatorSpecietyCounter.ContainsKey(typeof(Tiger)))
            Console.WriteLine("Tigers: " + statistics.PredatorSpecietyCounter[typeof(Tiger)]);
        if (statistics.PredatorSpecietyCounter.ContainsKey(typeof(Wolf)))
            Console.WriteLine("Wolfs: " + statistics.PredatorSpecietyCounter[typeof(Wolf)]);
        
        Console.WriteLine();

        if (statistics.PreySpecietyCounter.ContainsKey(typeof(Bull))) 
            Console.WriteLine("Bulls: " + statistics.PreySpecietyCounter[typeof(Bull)]);
        else
            Console.WriteLine("Bulls: " + 0);
        if (statistics.PreySpecietyCounter.ContainsKey(typeof(Cow)))
            Console.WriteLine("Cows: " + statistics.PreySpecietyCounter[typeof(Cow)]);
        else
            Console.WriteLine("Cows: " + 0);
        if (statistics.PreySpecietyCounter.ContainsKey(typeof(Rabbit)))
            Console.WriteLine("Rabbits: " + statistics.PreySpecietyCounter[typeof(Rabbit)]);
        else
            Console.WriteLine("Rabbits: " + 0);
        if (statistics.PreySpecietyCounter.ContainsKey(typeof(Sheep)))
            Console.WriteLine("Sheeps: " + statistics.PreySpecietyCounter[typeof(Sheep)]);
        else
            Console.WriteLine("Sheeps: " + 0);
    }
}