using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OOPLAB
{
    class CheckTargetForPredators : ICheckTarget
    {
        public bool CheckTarget(GameObject target, ObjectWhoCanLookAround animal)
        {
            Random chanceForWrongTarget = new Random();
            if ((target is ChildPoops && chanceForWrongTarget.Next(0,2) == 0)
                || animal.PairingTargetTest(target))
            {
                animal.target = target;
                return true;
            }
            if(target is Preys)
            {
                var obj = (Animals)target;
                if(obj.Age > obj.YoungAge)
                {
                    animal.target = target;
                    return true;
                }
            }
            
               
            return false;
        }
    }
}
