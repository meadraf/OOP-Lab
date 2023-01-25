namespace OOPLAB
{        
     class GameModel
    {
        public List<GameObject>[,] map;
        public int _mapLenght = 64;       
        public GameModel()
        {
            map = new List<GameObject>[_mapLenght, _mapLenght]; 
            for (int i = 0; i < _mapLenght; i++)
                for (int j = 0; j < _mapLenght; j++)
                    map[i, j] = new List<GameObject>(); 
            GrassGeneration grassGeneration = new GrassGeneration(map);
            AnimalsGeneration animalsGeneration = new AnimalsGeneration(map, _mapLenght);
        }
    }

}   