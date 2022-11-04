using System;
using System.Collections.Generic;
using design_patterns.HeadFirst.IteratorDesignPattern;
using design_patterns.HeadFirst.TemplateMethod;
using Xunit;

namespace design_patternsTests.HeadFirst.Iterator
{
    public class IteratorTests
    {
        [Fact]
        public void WorkingWithIterator()
        {
            PancakeHouseMenu pancakeHouseMenu = new PancakeHouseMenu();
            DinerMenu dinerMenu = new DinerMenu();
            Waitress waitress = new Waitress(pancakeHouseMenu, dinerMenu);
            // Use implicit iteration
            waitress.printMenu();
        }
    }
}

