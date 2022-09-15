using System;
using design_patterns.HeadFirst.Factory.FactoryMethod;
using design_patterns.HeadFirst.Factory.SimpleFactory;

namespace design_patterns.HeadFirst.Factory.AbstractFactory
{
    public interface PizzaIngredientFactory
    {
        public Dough createDough();
        public Sauce createSauce();
        public Cheese createCheese();
        public Veggies[] createVeggies();
        public Clams createClam();
        public Pepperoni createPepperoni();
    }

    public class Pepperoni
    {
        public String toString()
        {
            return "Pepperoni from ingredients Factory";
        }
    }

    public class Clams
    {
        public String toString()
        {
            return "Clams from ingredients Factory";
        }
    }

    public class Veggies
    {
        public String toString()
        {
            return "Veggies from ingredients Factory";
        }
    }

    public class Cheese
    {
        public String toString()
        {
            return "Cheese from ingredients Factory";
        }
    }

    public class Sauce
    {
        public String toString()
        {
            return "Sauce from ingredients Factory";
        }
    }

    public class Dough
    {
    }

    public class NYPizzaIngredientFactory : PizzaIngredientFactory
    {
        public Dough createDough()
        {
            return new ThinCrustDough();
        }

        public Sauce createSauce()
        {
            return new MarinaraSauce();
        }

        public Cheese createCheese()
        {
            return new ReggianoCheese();
        }

        public Veggies[] createVeggies()
        {
            var veggies = new Veggies[] { new Garlic(), new Onion(), new Mushroom(), new RedPepper() };
            return veggies;
        }

        public Pepperoni createPepperoni()
        {
            return new SlicedPepperoni();
        }

        public Clams createClam()
        {
            return new FreshClams();
        }
    }

    internal class FreshClams : Clams
    {
        public String toString()
        {
            return "Fresh Clams";
        }
    }

    internal class SlicedPepperoni : Pepperoni
    {
        public String toString()
        {
            return "Sliced Pepperoni";
        }
    }

    internal class RedPepper : Veggies
    {
        public RedPepper()
        {
        }

        public String toString()
        {
            return "Red Pepper";
        }
    }

    internal class Mushroom : Veggies
    {
        public Mushroom()
        {
        }

        public String toString()
        {
            return "Mushrooms";
        }
    }

    internal class Onion : Veggies
    {
        public Onion()
        {
        }

        public String toString()
        {
            return "Onion";
        }
    }

    internal class Garlic : Veggies
    {
        public Garlic()
        {
        }

        public String toString()
        {
            return "Garlic";
        }
    }

    internal class ReggianoCheese : Cheese
    {
        public String toString()
        {
            return "Parmigiano Reggiano style";
        }
    }

    internal class MarinaraSauce : Sauce
    {
        public String toString()
        {
            return "Marinara style";
        }
    }

    internal class ThinCrustDough : Dough
    {
        public String toString()
        {
            return "ThickCrust style extra thick crust dough";
        }
    }

    public abstract class PizzaStore
    {
        protected abstract Pizza createPizza(String item);

        public Pizza orderPizza(String type)
        {
            Pizza pizza = createPizza(type);
            Console.WriteLine("--- Making a " + pizza.getName() + " ---");
            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();
            return pizza;
        }
    }

    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza createPizza(String item)
        {
            Pizza pizza = null;
            PizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();

            if (item.Equals("cheese"))
            {
                pizza = new CheesePizza(ingredientFactory);
                pizza.setName("New York Style Cheese Pizza");

            }
            else if (item.Equals("veggie"))
            {
                pizza = new VeggiePizza(ingredientFactory);
                pizza.setName("New York Style Veggie Pizza");

            }
            else if (item.Equals("clam"))
            {
                pizza = new ClamPizza(ingredientFactory);
                pizza.setName("New York Style Clam Pizza");

            }
            else if (item.Equals("pepperoni"))
            {
                pizza = new PepperoniPizza(ingredientFactory);
                pizza.setName("New York Style Pepperoni Pizza");

            }
            return pizza;
        }
    }
}

