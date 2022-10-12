namespace OOPLAB;

public class Simulation
{
    public int MoveCount { get; private set;}
    public Statistics Statistics;
    public static event Action Update;
    private int _delay;
    
    public Simulation()
    {
        MoveCount = 0;
        _delay = 700;
        this.Statistics = new Statistics();
    }

    public void Start()
    {
        while (true)
        {
            Update.Invoke();
            Thread.Sleep(_delay);
            if (MoveCount == 100)
                return;
            
            Console.Clear();
            Statistics.NextTurn();
            Statistics.Print();
           
            
        }
    }
}