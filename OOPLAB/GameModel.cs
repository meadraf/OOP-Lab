namespace OOPLAB
{
    class GameModel
    {
        public List<GameObject>[,] Map;

        GameModel()
        {
            Map = new List<GameObject>[128, 128];
            for (int i = 0; i < 128; i++)
                for (int j = 0; j < 128; j++)
                    Map[i, j] = new List<GameObject>();
        }
        
        
    }
}
