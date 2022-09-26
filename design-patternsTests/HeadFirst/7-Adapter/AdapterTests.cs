using System;
using design_patterns.HeadFirst.Adapter;
using Xunit;

namespace design_patternsTests.HeadFirst.Adapter
{
    public class AdapterTests
    {
        [Fact]
        public void WorkingWithSimpleAdapter()
        {
            var duck = new MallardDuck();

            var turkey = new WildTurkey();
            var turkeyAdapter = new TurkeyAdapter(turkey);

            Console.WriteLine("The turkey says...");
            turkey.gobble();
            turkey.fly();

            Console.WriteLine("The duck says...");
            duck.quack();
            duck.fly();

            Console.WriteLine("The TurkeyAdapter says...");
            turkeyAdapter.quack();
            turkeyAdapter.fly();

            testDuck(turkeyAdapter);
        }

        private void testDuck(Duck turkey)
        {
            turkey.quack();
            turkey.fly();
        }
    }
}

