using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLAB
{        
    class GameModel
    {
        public List<GameObject>[,] map;
        private int _mapLenght;
        public Random RandomValue = new Random();   
        public GameModel()
        {
            _mapLenght = 64;
            map = new List<GameObject>[_mapLenght, _mapLenght]; 
            for (int i = 0; i < _mapLenght; i++)
                for (int j = 0; j < _mapLenght; j++)
                    map[i, j] = new List<GameObject>();   

            GenerateGrass(53, 45); 
            GenerateGrass(30, 24);
            GenerateGrass(8, 47); 
            GenerateGrass(8, 2);
            GenerateGrass(50, 2); 
            GenerateAnimals();                                                       
        }

        private void GenerateAnimals()
        {   
            for (int i = 0; i < _mapLenght; i++)
            {
                    for (int j = 0; j < _mapLenght; j++)
                    {
                    int generationChance = RandomValue.Next(1, 81);     
                        if(generationChance < 5) 
                            switch(GenerateRandPrey()) 
                        {
                        case 1:
                            new Bull().Add(new Point(i, j), map);
                            break;
                        case 2:
                            new Cow().Add(new Point(i, j), map);
                            break;
                        case 3:
                            new Rabbit().Add(new Point(i, j), map);
                            break;                    
                        case 4:
                            new Sheep().Add(new Point(i, j), map);
                            break;                          
                        }
                         if(generationChance == 5) switch(GenerateRandPredator()) 
                        {
                        case 5:
                            new Bear().Add(new Point(i, j), map); 
                            break;    
                        case 6:
                            new Hyena().Add(new Point(i, j), map);
                            break;
                        case 7:
                            new Tiger().Add(new Point(i, j), map);
                            break;
                        case 8:
                            new Wolf().Add(new Point(i, j), map);
                            break;
                        }
                    }
            }    
        }  
        private int GenerateRandPrey()
        {   
            int generatedValue = RandomValue.Next(1, 5);
            return generatedValue;      
        } 
         private int GenerateRandPredator()
        {   
            int generatedValue = RandomValue.Next(4, 9);
            return generatedValue;      
        }  
        private void GenerateGrass(int x, int y)
        {  
            int k = 0; bool ex = true;
            for(int i = y; i < y + 13; i++) 
            {
                for(int j = x - k; j <= x + k; j++) 
                {
                    var grass = new Grass();
                    map[j, i].Add(grass);
                    grass.Coordinate = new Point(j, i);
                }
                                    
                
                if(k == 6) ex = false;
                if(ex) k++;
                else k--;
            }   
        }   
     
    }
}


