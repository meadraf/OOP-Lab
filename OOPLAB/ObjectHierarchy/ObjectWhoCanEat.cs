using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLAB
{
    class ObjectWhoCanEat : ObjectWhoHasTarget
    {
        private int _satiety = 0;
        public int Satiety
        {
            get { return _satiety; }
            set
            {
                _satiety = value;
                if (_satiety > MaxSatiety)
                    _satiety = MaxSatiety;
                if (_satiety < 0)
                    _satiety = 0;
            }
        }
        public int MaxSatiety { get; set; }

        public virtual void Eat(List<GameObject>[,] map) { }
    }
}
