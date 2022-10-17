namespace OOPLAB;

class Statistics
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
    private readonly List<GameObject>[,] _map;

    public Statistics(List<GameObject>[,] map)
    {
        Simulation.Update += NextTurn;
        _map = map;
        AnimalsCount = 0;
        PredatorsCount = 0;
        PreysCount = 0;
        TurnsCount = 0;
    }

    private void NextTurn() => TurnsCount++;
    
    public int CountPredators()
    {
        PredatorsCount = 0;
        foreach (var cell in _map)
        {
            foreach (var animal in cell)
            {
                if (animal is Predators)
                {
                    PredatorsCount++;
                }
            }
        }

        return PredatorsCount;
    }

    public int CountPreys()
    {
        PreysCount = 0;
        foreach (var cell in _map)
        {
            foreach (var animal in cell)
            {
                if (animal is Preys)
                {
                    PreysCount++;
                }
            }
        }

        return PreysCount;
    }
}