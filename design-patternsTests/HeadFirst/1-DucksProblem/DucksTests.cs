using design_patterns.HeadFirst.DucksProblem;
using Xunit;

namespace design_patternsTests.HeadFirst.DucksProblem
{
    public class DucksTests
    {
        [Fact]
        public void ShouldReturnTheSameInstance(){
            var mallardDuck = new MallardDuck();
            //var rubberDuck = new RubberDuck();
            //rubberDuck.performFly(); // ERROR: rubber ducks cannot fly!!!

            mallardDuck.display();
            mallardDuck.performFly();
            mallardDuck.performQuack();
        }        
    }
}