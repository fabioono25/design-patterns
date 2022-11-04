using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns.HeadFirst.Factory.FactoryMethod
{
    public abstract class Pizza
    {
        protected String name;
        protected String dough;
        protected String sauce;
        protected List<String> toppings = new List<String>();

        public String getName()
        {
            return name;
        }

        public void prepare()
        {
            Console.WriteLine("Preparing " + name);
        }

        public void bake()
        {
            Console.WriteLine("Baking " + name);
        }

        public void cut()
        {
            Console.WriteLine("Cutting " + name);
        }

        public void box()
        {
            Console.WriteLine("Boxing " + name);
        }

        public String toString()
        {
            // code to display pizza name and ingredients
            var display = new StringBuilder();
            display.Append("---- " + name + " ----\n");
            display.Append(dough + "\n");
            display.Append(sauce + "\n");

            foreach (var topping in toppings)
            {
                display.Append(topping + "\n");
            }

            return display.ToString();
        }
    }
}

