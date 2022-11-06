using System;
using System.Collections.Generic;
using design_patterns.HeadFirst.IteratorDesignPattern;

namespace design_patterns.HeadFirst.IteratorDesignPattern
{
    public class MenuItem
    {
        String name;
        String description;
        bool vegetarian;
        double price;

        public MenuItem(String name,
                        String description,
                        bool vegetarian,
                        double price)
        {
            this.name = name;
            this.description = description;
            this.vegetarian = vegetarian;
            this.price = price;
        }

        public String getName()
        {
            return name;
        }

        public String getDescription()
        {
            return description;
        }

        public double getPrice()
        {
            return price;
        }

        public bool isVegetarian()
        {
            return vegetarian;
        }
    }

    public interface Menu
    {
        public Iterator<MenuItem> createIterator();
    }

    public class PancakeHouseMenu : Menu
    {
        List<MenuItem> menuItems;

        public PancakeHouseMenu()
        {
            menuItems = new List<MenuItem>();

            addItem("K&B's Pancake Breakfast",
                "Pancakes with scrambled eggs, and toast",
                true,
                2.99);

            addItem("Regular Pancake Breakfast",
                "Pancakes with fried eggs, sausage",
                false,
                2.99);

            addItem("Blueberry Pancakes",
                "Pancakes made with fresh blueberries, and blueberry syrup",
                true,
                3.49);

            addItem("Waffles",
                "Waffles, with your choice of blueberries or strawberries",
                true,
                3.59);
        }

        public void addItem(String name, String description,
                            bool vegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            menuItems.Add(menuItem);
        }

        public List<MenuItem> getMenuItems()
        {
            return menuItems;
        }

        public Iterator<MenuItem> createIterator()
        {
            // yield return menuItems.ConvertAll(p => new MenuItem(p.getName(), p.getDescription(), p.isVegetarian(), p.getPrice()));
            // yield return menuItems;
            return new PancakeHouseMenuIterator(menuItems);
        }

    // other menu methods here
}

public class DinerMenu : Menu
{
    static int MAX_ITEMS = 6;
    int numberOfItems = 0;
    MenuItem[] menuItems;

    public DinerMenu()
    {
        menuItems = new MenuItem[MAX_ITEMS];

        addItem("Vegetarian BLT",
            "(Fakin') Bacon with lettuce & tomato on whole wheat", true, 2.99);
        addItem("BLT",
            "Bacon with lettuce & tomato on whole wheat", false, 2.99);
        addItem("Soup of the day",
            "Soup of the day, with a side of potato salad", false, 3.29);
        addItem("Hotdog",
            "A hot dog, with saurkraut, relish, onions, topped with cheese",
            false, 3.05);
        addItem("Steamed Veggies and Brown Rice",
            "Steamed vegetables over brown rice", true, 3.99);
        addItem("Pasta",
            "Spaghetti with Marinara Sauce, and a slice of sourdough bread",
            true, 3.89);
    }

    public void addItem(String name, String description,
                         bool vegetarian, double price)
    {
        MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
        if (numberOfItems >= MAX_ITEMS)
        {
            Console.WriteLine("Sorry, menu is full!  Can't add item to menu");
        }
        else
        {
            menuItems[numberOfItems] = menuItem;
            numberOfItems = numberOfItems + 1;
        }
    }

    public MenuItem[] getMenuItems()
    {
        return menuItems;
    }

    public Iterator<MenuItem> createIterator()
    {
        return new DinerMenuIterator(menuItems);
        //return new AlternatingDinerMenuIterator(menuItems);
    }
 
	    // other menu methods here
    }
}

