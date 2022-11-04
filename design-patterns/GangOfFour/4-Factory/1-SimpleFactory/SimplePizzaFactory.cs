using System.Xml.Linq;

namespace design_patterns.HeadFirst.Factory.SimpleFactory
{
    // this is not a GoF design pattern, but it is a simple way
    // to solve using a "kind of" pattern
    public class SimplePizzaFactory
    {
        internal Pizza createPizza(string type)
        {
            Pizza pizza;

            switch (type)
            {
                case "cheese":
                    pizza = new CheesePizza();
                    break;
                case "clam":
                    pizza = new ClamPizza();
                    break;
                case "veggie":
                    pizza = new VeggiePizza();
                    break;
                default:
                    pizza = new CheesePizza();
                    break;
            }

            return pizza;
        }
    }

    public class PizzaStore
    {
        SimplePizzaFactory factory;

        public PizzaStore(SimplePizzaFactory factory)
        {
            this.factory = factory;
        }

        public Pizza orderPizza(string type)
        {
            var pizza = factory.createPizza(type);

            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();

            return pizza;
        }
    }

    internal class CheesePizza : Pizza
    {
        public CheesePizza()
        {
            name = "Cheese Pizza";
            dough = "Regular Crust";
            sauce = "Marinara Pizza Sauce";
            toppings.Add("Fresh Mozzarella");
            toppings.Add("Parmesan");
        }
    }

    internal class ClamPizza : Pizza
    {
        public ClamPizza()
        {
            name = "Clam Pizza";
            dough = "Thin crust";
            sauce = "White garlic sauce";
            toppings.Add("Clams");
            toppings.Add("Grated parmesan cheese");
        }
    }

    internal class VeggiePizza : Pizza
    {
        public VeggiePizza()
        {
            name = "Veggie Pizza";
            dough = "Crust";
            sauce = "Marinara sauce";
            toppings.Add("Shredded mozzarella");
            toppings.Add("Grated parmesan");
            toppings.Add("Diced onion");
            toppings.Add("Sliced mushrooms");
            toppings.Add("Sliced red pepper");
            toppings.Add("Sliced black olives");
        }
    }
}

