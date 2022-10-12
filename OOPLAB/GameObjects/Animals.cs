using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLAB
{
    class Animals : GameObject
    {
        private int _satiety = 0;

        public int RadiusOfView { get; set; }
        public int MaxSatiety {get; set;}
        public int NormalSpeed { get; set;}
        public int MaxSpeed { get; set;}
        public int PreysSaturability { get; set;}


        public int Satiety
        {
            get { return _satiety; }
            set
            {
                if (value <= MaxSatiety)
                {
                    _satiety = value;
                    
                }
                    
            }
        }
        
        


    }
}
