using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLAB
{
    class Grass : GameObject
    {
        public bool IsGrown { get; set; }

        private int _growRate;

        public Grass()
        {
            Saturability = 1;
            Type = "Grass";
        }

        public void Eaten()
        {
            IsGrown = false;
            _growRate = 0;
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
}
