using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLAB
{        
    class GameModel
    {
        public List<GameObject>[,] Map;     
        public Random RandomValue = new Random();   
        public GameModel()
        {
            Map = new List<GameObject>[64, 64]; 
            for (int i = 0; i < 64; i++)
            {
                for (int j = 0; j < 64; j++)
                {
                    Map[i, j] = new List<GameObject>();
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
                        int GenerationChance = RandomValue.Next(0, 5);     
                        if(GenerationChance == 3) switch(GenerateRandomValue()) 
                        {
                        case 1:
                            Map[i,j].Add(new Bear());
                            break;
                        case 2:
                            Map[i,j].Add(new Hyena());
                            break;
                        case 3:
                            Map[i,j].Add(new Tiger());
                            break;
                        case 4:
                            Map[i,j].Add(new Wolf());
                            break;
                        case 5:
                            Map[i,j].Add(new Bull());
                            break;    
                        case 6:
                            Map[i,j].Add(new Cow());
                            break;
                        case 7:
                            Map[i,j].Add(new Rabbit());
                            break;
                        case 8:
                            Map[i,j].Add(new Sheep());
                            break; 
                        } 
                    }
                }    
        }  
        private int GenerateRandomValue()
        {   
            int GeneratedValue = RandomValue.Next(1, 9);
            return GeneratedValue;      
        }   
        private void GenerateGrass(int x, int y)
        {  
            int k = 0; bool ex = true;
            for(int i = y; i < y + 13; i++) 
            {
                for(int j = x - k; j <= x + k; j++) 
                {
                     Map[j,i].Add(new Grass());
                }
                if(k == 6) ex = false;
                if(ex) k++;
                else k--;
            }   
        }   
     
    }
}
