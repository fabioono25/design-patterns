using design_patterns.HeadFirst.DucksProblem;
using Xunit;

namespace design_patternsTests.HeadFirst.DucksProblem
{
    public class DucksTests
    {
        [Fact]
        public void ShouldReturnTheSameInstance(){
            var mallardDuck = new MallardDuck();
            var rubberDuck = new RubberDuck();
            rubberDuck.Fly(); // ERROR: rubber ducks cannot fly!!!

            // var second = SingleObject.getInstance();
            // Assert.Same(first, second);
            // first.SomeValue++;
            // Assert.Equal(first.SomeValue, second.SomeValue);
            // second.SomeValue++;
            // Assert.Equal(first.SomeValue, second.SomeValue);
        }        
    }
}