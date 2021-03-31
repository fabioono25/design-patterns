using System;

namespace design_patterns.Behavioral.Strategy.Basic
{
    public interface IHero
    {
        // this will change - ex: log. No need to redeploy in this case
        string DoAction(); // command

        // strategy
        void ChangeSuperPower(ISuperPower power); // change
    }
}
