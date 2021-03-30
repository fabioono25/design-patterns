using System;

namespace design_patterns.Behavioral.Strategy.Basic
{
    public interface IHero
    {
        string DoAction();

        // strategy
        void ChangeSuperPower(ISuperPower power);
    }
}
