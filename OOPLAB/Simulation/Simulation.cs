namespace OOPLAB;

public class Simulation
{
    public int MoveCount { get; private set;}
    public Statistics Statistics;
    public static event Action Update;
    private int _delay;
    private int _maxTurns;
    
    public Simulation()
    {
        MoveCount = 0;
        _delay = 700;
        _maxTurns = 100;
        this.Statistics = new Statistics();
    }

    public void Start()
    {
        while (MoveCount < _maxTurns)
        {
            Update.Invoke();
            Thread.Sleep(_delay);
            
            Console.Clear();
            Statistics.NextTurn();
            Statistics.Print();
        }
    }
}