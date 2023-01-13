using System.Drawing;

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
    public Dictionary<Type, int> PreySpecietyCounter;
    public Dictionary<Type, int> PredatorSpecietyCounter;
    private readonly List<GameObject>[,] _map;

    public Statistics(List<GameObject>[,] map)
    {
        Simulation.Update += NextTurn;
        _map = map;
        AnimalsCount = 0;
        PredatorsCount = 0;
        PreysCount = 0;
        TurnsCount = 0;
        PreySpecietyCounter = new Dictionary<Type, int>(4);
        PredatorSpecietyCounter = new Dictionary<Type, int>(4);

    }

    private void NextTurn() => TurnsCount++;
    
    public int CountPredators()
    {
        ResetPredators();
        foreach (var cell in _map)
        {
            foreach (var animal in cell)
            {
                if (animal is Predators)
                {
                    PredatorSpecietyCounter.TryAdd(animal.GetType(), 0);
                    PredatorSpecietyCounter[animal.GetType()]++;
                    PredatorsCount++;
                }
            }
        }

        return PredatorsCount;
    }

    public int CountPreys()
    {
        ResetPreys();
        foreach (var cell in _map)
        {
            foreach (var animal in cell)
            {
                if (animal is Preys)
                {
                    PreySpecietyCounter.TryAdd(animal.GetType(), 0);
                    PreySpecietyCounter[animal.GetType()]++;
                    PreysCount++;
                }
            }
        }

        return PreysCount;
    }

    private void ResetPreys()
    {
        PreysCount = 0;
        PreySpecietyCounter.Clear();
    }

    private void ResetPredators()
    {
        PredatorsCount = 0;
        PredatorSpecietyCounter.Clear();
    }
}