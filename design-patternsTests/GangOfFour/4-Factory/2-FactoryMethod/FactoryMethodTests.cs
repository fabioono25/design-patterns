using System;
using System.Threading.Tasks;
using design_patterns.GangOfFour.Creational.FactoryMethod.AsyncFactory;
using design_patterns.GangOfFour.Creational.FactoryMethod.Points;
using design_patterns.HeadFirst.Factory.FactoryMethod;
using Xunit;

namespace design_patternsTests.HeadFirst.Factory.FactoryMethod
{
    public class FactoryMethodTests
    {
        /// <summary>
        /// Test 1: Pizza factory method test
        /// </summary>
        [Fact]
        public void ShouldExecuteTest()
        {
            var nyPizzaStore = new NYPizzaStore();
            var chicagoStore = new ChicagoPizzaStore();

            nyPizzaStore.orderPizza("veggie");
            chicagoStore.orderPizza("veggie");
        }

        /// <summary>
        /// Test 2: Point factory method test
        /// </summary>
        [Fact]
        public void ShouldCreatePoint()
        {
            //same idea of: Task.Factory.StartNew();

            var point = Point.Factory.NewPolarPoint(1.0, Math.PI / 2);
            Assert.True(point != null);
        }

        /// <summary>
        /// Test 3: Async invocation (without factory method)
        /// </summary>
        [Fact]
        public async Task ShouldCreateAsync()
        {
            var foo = new Foo();
            await foo.InitAsync(); // extra-invocation here, for creating something
            Assert.True(true);
        }

        /// <summary>
        /// Test 4: Async invocation (with factory method)
        /// </summary>
        [Fact]
        public async Task ShouldCreateAsyncWithFactoryMethod()
        {
            var x = await Foo2.CreateAsync();
            Assert.True(x != null);
        }

        // Test 5: Working with properties
        [Fact]  
        public void ShouldCreatePointWithProperties()
        {
            var origin = Point.Origin; // property, instantiated each time it is called
            Assert.True(origin != null);

            var origin2 = Point.Origin2; // field, instantiated only once (Singleton)
            Assert.True(origin2 != null);
        }
    }
}

