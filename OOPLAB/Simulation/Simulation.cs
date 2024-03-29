namespace OOPLAB;

class Simulation
{
    private readonly IStatistics _statistics;
    public static event Action Update;
    public delegate void AnimalsMove(List<GameObject>[,] map);
    public static event AnimalsMove Move;
    private readonly int _delay;
    public static int MaxTurns { get; private set; }
    private readonly List<GameObject>[,] _map;
    
    public Simulation(List<GameObject>[,] map)
    {
        _delay = 20;
        MaxTurns = 200;
        _statistics = new Statistics(map);
        _map = map;
    }

    public void Start()
    {
        while (_statistics.TurnsCount < MaxTurns)
        {
            Update.Invoke();
            Move.Invoke(_map);
            Thread.Sleep(_delay);
            
            Console.Clear();
            _statistics.RecordStatistics();
            _statistics.Print();
        }
    }
}