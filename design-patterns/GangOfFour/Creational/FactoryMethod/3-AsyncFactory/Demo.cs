using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace design_patterns.GangOfFour.Creational.FactoryMethod.AsyncFactory
{
    public class Foo
    {
        public Foo()
        {
            // await Task.Delay(1000); // not possible
        }

        public async Task<Foo> InitAsync()
        {
            await Task.Delay(1000);
            return this;
        }
    }

    public class Foo2
    {
        private Foo2()
        {
            // await Task.Delay(1000); // not possible
        }

        private async Task<Foo2> InitAsync()
        {
            await Task.Delay(1000);
            return this;
        }

        public static Task<Foo2> CreateAsync()
        {
            var result = new Foo2();
            return result.InitAsync();
        }
    }

}