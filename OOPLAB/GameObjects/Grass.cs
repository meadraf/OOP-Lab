namespace OOPLAB;

class Grass : GameObject
{
    private bool _isGrown;
    private int _growRate;
    
    public Grass()
    {
        _isGrown = true;
        _growRate = 10;
        Simulation.Update += Grow;
    }
    
    public void Eaten()
    {
        _isGrown = false;
        _growRate = 0;
    }
    
    private void Grow()
    {
        if (_isGrown == false)
        {
            _growRate++;
            if (_growRate == 10)
            {
                _isGrown = true;
            }
        }
    }
}