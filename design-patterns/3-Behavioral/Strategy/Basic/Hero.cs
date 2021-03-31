using System;

namespace design_patterns.Behavioral.Strategy.Basic
{
    // context
    public class Hero : IHero
    {
        private ISuperPower _power;
        private RegularPerson regularPerson;

        public Hero(): this(new RegularPerson())
        {
        }

        public Hero(ISuperPower power)
        {
            _power = power;
        }

        public void ChangeSuperPower(ISuperPower power)
        {
            _power = power;
        }

        public string DoAction() => _power.ExercisePower();
    }

    public class FlyMan: Hero {
        public FlyMan() : base(new Fly())
        {
        }
    } 

    public class FishMan: Hero {
        public FishMan() : base(new Swim())
        {
        }
    }     
}
