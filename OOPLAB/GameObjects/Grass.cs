namespace OOPLAB;

class Grass : GameObject
{
    public bool IsGrown;
    private int _growRate;
    
    public Grass()
    {
        Saturability = 1;
        Type = "Grass";
        IsGrown = true;
        _growRate = 10;
        Simulation.Update += Grow;
        
    }
    
    public void Eaten()
    {
        if (IsGrown)
        {
            IsGrown = false;
            _growRate = 0;
        }
    }
    
    private void Grow()
    {
        if (IsGrown == false)
        {
            _growRate++;
            if (_growRate == 10)
            {
                IsGrown = true;
            }
        }
    }
}