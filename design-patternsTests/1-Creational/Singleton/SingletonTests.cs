using System;
using design_patterns.Behavioral.Strategy.Basic;
using design_patterns.Creational.Singleton.Basic;
using Xunit;

namespace design_patternsTests.Behavioral.Strategy.Basic
{
    public class SingletonTests
    {
        [Fact]
        public void ShouldReturnTheSameInstance(){
            var first = SingleObject.getInstance();
            var second = SingleObject.getInstance();
            Assert.Same(first, second);
            first.SomeValue++;
            Assert.Equal(first.SomeValue, second.SomeValue);
            second.SomeValue++;
            Assert.Equal(first.SomeValue, second.SomeValue);
        }        
    }
}
