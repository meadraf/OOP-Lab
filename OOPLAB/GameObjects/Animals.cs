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
        private int _satiety;
        private static int _maxSatiety;
        int Satiety 
        {
            get { return _satiety; } 
            set
            {
                if(value <= _maxSatiety)
                    _satiety = value;
            }
        }


    }
}
