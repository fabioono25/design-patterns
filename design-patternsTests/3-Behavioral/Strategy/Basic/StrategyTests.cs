using System;
using design_patterns.Behavioral.Strategy.Basic;
using Xunit;

namespace design_patternsTests.Behavioral.Strategy.Basic
{
    public class StrategyTests
    {
        [Fact]
        public void ShouldReturnSuperPower(){
            IHero superMan = new FlyMan();
            Assert.Equal(new Fly().ExercisePower(), superMan.DoAction());
            IHero fishMan = new FishMan();
            Assert.Equal(new Swim().ExercisePower(), fishMan.DoAction());
        }

        [Fact]
        public void ShouldReturnChangedSuperPower(){
            // IoC here?
            var person = new Hero();
            Assert.Equal(new RegularPerson().ExercisePower(), person.DoAction());
            person.ChangeSuperPower(new Fly());
            Assert.Equal(new Fly().ExercisePower(), person.DoAction());
            person.ChangeSuperPower(new Swim());
            Assert.Equal(new Swim().ExercisePower(), person.DoAction());
        }        
    }
}
