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
        public Random RandomValue = new Random();   
        public GameModel()
        {
            map = new List<GameObject>[64, 64]; 
            for (int i = 0; i < 64; i++)
            {
                for (int j = 0; j < 64; j++)
                {
                    map[i, j] = new List<GameObject>();
                }
            }  
            GenerateGrass(53, 45); 
            GenerateGrass(30, 24);
            GenerateGrass(8, 47); 
            GenerateGrass(8, 2);
            GenerateGrass(50, 2); 
            GenerateAnimals();                                                       
        }

        private void GenerateAnimals()
        {   
            for (int i = 0; i < 64; i++)
            {
                    for (int j = 0; j < 64; j++)
                    {
                    int GC = RandomValue.Next(1, 81);     
                        if(GC == 1 || GC == 2 || GC == 3 || GC == 4) switch(GenerateRandPrey()) 
                        {
                        case 1:
                            new Bear().Add(new Point(i, j), map);
                            break;
                        case 2:
                            new Hyena().Add(new Point(i, j), map);
                            break;
                        case 3:
                            new Tiger().Add(new Point(i, j), map);
                            break;
                        case 4:
                            new Wolf().Add(new Point(i, j), map);
                            break;
                        }
                         if(GC == 5) switch(GenerateRandPredator()) 
                        {
                        case 5:
                            new Bull().Add(new Point(i, j), map);
                            break;    
                        case 6:
                            new Cow().Add(new Point(i, j), map);
                            break;
                        case 7:
                            new Rabbit().Add(new Point(i, j), map);
                            break;
                        case 8:
                            new Sheep().Add(new Point(i, j), map);
                            break; 
                        }
                    }
            }    
        }  
        private int GenerateRandPrey()
        {   
            int GeneratedValue = RandomValue.Next(1, 5);
            return GeneratedValue;      
        } 
         private int GenerateRandPredator()
        {   
            int GeneratedValue = RandomValue.Next(4, 9);
            return GeneratedValue;      
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


