namespace OOPLAB;

interface IStatistics
{
    public void RecordStatistics();
    public TurnInfo CurrentTurnInfo { get; }
    public TurnInfo this[int index] { get; }
}