namespace OOPLAB;

class Simulation
{
    private readonly Statistics _statistics;
    public static event Action Update;
    public delegate void AnimalsMove(List<GameObject>[,] map);
    public static event AnimalsMove Move;
    private readonly int _delay;
    private readonly int _maxTurns;
    private List<GameObject>[,] _map;
    
    public Simulation(List<GameObject>[,] map)
    {
        _delay = 50;
        _maxTurns = 100;
        _statistics = new Statistics(map);
        _map = map;
    }

    public void Start()
    {
        while (_statistics.TurnsCount < _maxTurns)
        {
            Update.Invoke();
            Move.Invoke(_map);
            Thread.Sleep(_delay);
            
            Console.Clear();
            _statistics.CountPredators();
            _statistics.CountPreys();
            _statistics.Print();
        }
    }
}