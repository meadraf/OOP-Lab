namespace OOPLAB;

class Simulation
{
    private readonly Statistics _statistics;
    public static event Action Update;
    private readonly int _delay;
    private readonly int _maxTurns;
    
    public Simulation(List<GameObject>[,] map)
    {
        _delay = 700;
        _maxTurns = 100;
        _statistics = new Statistics(map);
    }

    public void Start()
    {
        while (_statistics.TurnsCount < _maxTurns)
        {
            Update.Invoke();
            Thread.Sleep(_delay);
            
            Console.Clear();
            _statistics.CountPredators();
            _statistics.CountPreys();
            _statistics.Print();
        }
    }
}