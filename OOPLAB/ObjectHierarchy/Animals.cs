﻿using OOPLAB.MoveLogic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace OOPLAB
{
    abstract class Animals : ObjectWhoCanLookAround
    {
        private int _age;

        public bool DeadlyHungerLevel;
        public int HungerLevel { get; set; }
        public int YoungAge { get; set;}
        public int Age
        {
            get { return _age; }
            set
            {
                _age = value;
                if (_age < 0)
                    _age = 0;
            }
        }
        public Animals()
        {
            DeadlyHungerLevel = false;
            Age = 20;
            Simulation.Move += Move;
            Simulation.Update += GrowingUp;
            Simulation.Update += GettingHunger;
        }
        private void GrowingUp()
        {
            Age++;
        }
        private void GettingHunger()
        {
            if (Satiety == 0 && Age > YoungAge)
                HungerLevel++;
            if (Satiety > 0)
                HungerLevel = 0;
            if (HungerLevel == 50)
                DeadlyHungerLevel = true;
        }

        public void Move(List<GameObject>[,] map)
        {

            MoveLogicStrategy moveStrategy = new MoveLogicStrategy();
            if (Age < YoungAge)
                moveStrategy.setConcreteStrategy(new ConcreteMoveLogicA());
            else if (this is Predators)
                moveStrategy.setConcreteStrategy(new ConcreteMoveLogicB());
            else if (this is Preys)
                moveStrategy.setConcreteStrategy(new ConcreteMoveLogicC());

            moveStrategy.MoveStrategy(map, this);
        }
    }
}
