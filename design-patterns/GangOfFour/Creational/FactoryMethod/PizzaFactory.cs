using System;
using System.Xml.Linq;

namespace design_patterns.HeadFirst.Factory.FactoryMethod
{
    public abstract class PizzaStore
    {
        public Pizza orderPizza(string type)
        {
            var pizza = createPizza(type);

            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();

            return pizza;
        }

        // now, the responsibility to create pizza is from the subclasses
        public abstract Pizza createPizza(string type);
    }

    public class NYPizzaStore : PizzaStore
    {
        public override Pizza createPizza(string type)
        {
            switch (type)
            {
                case "cheese":
                    return new NYCheesePizza();
                case "clam":
                    return new NYClamPizza();
                case "veggie":
                    return new NYVeggiePizza();
                default:
                    return new NYCheesePizza();
            }
        }
    }


    public class ChicagoPizzaStore : PizzaStore
    {
        public override Pizza createPizza(string type)
        {
            switch (type)
            {
                case "cheese":
                    return new ChicagoCheesePizza();
                case "clam":
                    return new ChicagoClamPizza();
                case "veggie":
                    return new ChicagoVeggiePizza();
                default:
                    return new ChicagoCheesePizza();
            }
        }
    }

    internal class NYCheesePizza : Pizza
    {
        public NYCheesePizza()
        {
            name = "NY Style Sauce and Cheese Pizza";
            dough = "Thin Crust Dough";
            sauce = "Marinara Sauce";

            toppings.Add("Grated Reggiano Cheese");
        }
    }

    internal class NYClamPizza : Pizza
    {
        public NYClamPizza()
        {
            name = "NY Style Clam Pizza";
            dough = "Thin Crust Dough";
            sauce = "Marinara Sauce";

            toppings.Add("Grated Reggiano Cheese");
            toppings.Add("Fresh Clams from Long Island Sound");
        }
    }

    internal class NYVeggiePizza : Pizza
    {
        public NYVeggiePizza()
        {
            name = "NY Style Veggie Pizza";
            dough = "Thin Crust Dough";
            sauce = "Marinara Sauce";

            toppings.Add("Grated Reggiano Cheese");
            toppings.Add("Garlic");
            toppings.Add("Onion");
            toppings.Add("Mushrooms");
            toppings.Add("Red Pepper");
        }
    }

    internal class ChicagoCheesePizza : Pizza
    {
        public ChicagoCheesePizza()
        {
            name = "Chicago Style Deep Dish Cheese Pizza";
            dough = "Extra Thick Crust Dough";
            sauce = "Plum Tomato Sauce";

            toppings.Add("Shredded Mozzarella Cheese");
        }

        //void cut()
        //{
        //    System.Console.WriteLine("Cutting the pizza into square slices");
        //}
    }

    internal class ChicagoClamPizza : Pizza
    {
        public ChicagoClamPizza()
        {
            name = "Chicago Style Clam Pizza";
            dough = "Extra Thick Crust Dough";
            sauce = "Plum Tomato Sauce";

            toppings.Add("Shredded Mozzarella Cheese");
            toppings.Add("Frozen Clams from Chesapeake Bay");
        }

        void cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }

    internal class ChicagoVeggiePizza : Pizza
    {
        public ChicagoVeggiePizza()
        {
            name = "Chicago Deep Dish Veggie Pizza";
            dough = "Extra Thick Crust Dough";
            sauce = "Plum Tomato Sauce";

            toppings.Add("Shredded Mozzarella Cheese");
            toppings.Add("Black Olives");
            toppings.Add("Spinach");
            toppings.Add("Eggplant");
        }

        void cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}

