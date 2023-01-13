using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLAB
{
    class FactoryOnBorningAnimals : IFactory
    {
        private IFactory? _father;
        public void SetFather(Animals father)
        {
            _father = (IFactory)father;    
        }
        public Animals BorningChild()
        {
            return _father.BorningChild();
        }
    }
}
