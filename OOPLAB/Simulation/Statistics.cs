namespace OOPLAB;

public class Statistics
{
    private int _animalsCount;
    public int AnimalsCount
    {
        get => _animalsCount = PredatorsCount + PreysCount;
        private set => _animalsCount = value;

    }
    public int PredatorsCount { get; private set; }
    public int PreysCount { get; private set; }
    public int TurnsCount { get; private set; }
    
    public Statistics()
    {
        AnimalsCount = 0;
        PredatorsCount = 0;
        PreysCount = 0;
        TurnsCount = 0;
    }

    public int NextTurn() => TurnsCount++;
    
    public int CountPredators(List<object>[,] map)
    {
        foreach (var cell in map)
        {
            foreach (var animal in cell)
            {
                if (animal.GetType() == typeof(Predators))
                {
                    PredatorsCount++;
                }
            }
        }

        return PredatorsCount;
    }

    public int CountPreys(List<object>[,] map)
    {
        foreach (var cell in map)
        {
            foreach (var animal in cell)
            {
                if (animal.GetType() == typeof(Preys))
                {
                    PreysCount++;
                }
            }
        }

        return PreysCount;
    }
  
}