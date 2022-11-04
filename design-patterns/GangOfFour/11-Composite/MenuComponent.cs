using System;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using design_patterns.HeadFirst.IteratorDesignPattern;
using System.Reflection;

namespace design_patterns.HeadFirst.Composite
{
    public abstract class MenuComponent
    {
        public virtual void add(MenuComponent menuComponent)
        {
            throw new Exception();
        }
        public virtual void remove(MenuComponent menuComponent)
        {
            throw new Exception();
        }
        public virtual MenuComponent getChild(int i)
        {
            throw new Exception();
        }

        public virtual String getName()
        {
            throw new Exception();
        }
        public virtual String getDescription()
        {
            throw new Exception();
        }
        public virtual double getPrice()
        {
            throw new Exception();
        }
        public virtual bool isVegetarian()
        {
            throw new Exception();
        }

        public virtual void print()
        {
            Type t = this.GetType(); // Where obj is object whose properties you need.
            PropertyInfo[] pi = t.GetProperties();
            foreach (PropertyInfo p in pi)
            {
                Console.WriteLine(p.Name + " : " + p.GetValue(this));
            }
        }
    }

    public class Menu : MenuComponent
    {
        List<MenuComponent> menuComponents = new List<MenuComponent>();
	    String name;
        String description;

        public Menu(String name, String description)
        {
            this.name = name;
            this.description = description;
        }

        public override void add(MenuComponent menuComponent)
        {
            menuComponents.Add(menuComponent);
        }

        public override void remove(MenuComponent menuComponent)
        {
            menuComponents.Remove(menuComponent);
        }

        public override MenuComponent getChild(int i)
        {
            return (MenuComponent)menuComponents[i];
        }

        public override String getName()
        {
            return name;
        }

        public override String getDescription()
        {
            return description;
        }

        public Iterator<MenuComponent> createIterator()
        {
            // yield return menuItems.ConvertAll(p => new MenuItem(p.getName(), p.getDescription(), p.isVegetarian(), p.getPrice()));
            // yield return menuItems;
            return new MenuIterator(menuComponents);
        }

        public override void print()
        {
            Console.WriteLine("\n" + getName());
            Console.WriteLine(", " + getDescription());
                Console.WriteLine("---------------------");

            Iterator<MenuComponent> iterator = createIterator();
            while (iterator.hasNext())
            {
                MenuComponent menuComponent =
                    (MenuComponent)iterator.next();
                menuComponent.print();
            }
        }
    }

    public class MenuIterator : Iterator<MenuComponent>
    {
        List<MenuComponent> list;
        int position = 0;

        public MenuIterator(List<MenuComponent> list)
        {
            this.list = list;
        }

        public MenuComponent next()
        {
            MenuComponent menuItem = list[position];
            position = position + 1;
            return menuItem;
        }

        public bool hasNext()
        {
            if (position >= list.Count || list[position] == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void remove()
        {
            if (position <= 0)
            {
                throw new Exception
                    ("You can't remove an item until you've done at least one next()");
            }
            if (list[position - 1] != null)
            {
                for (int i = position - 1; i < (list.Count - 1); i++)
                {
                    list[i] = list[i + 1];
                }
                list[list.Count - 1] = null;
            }
        }
    }

    public interface Iterator<T>
    {
        bool hasNext();
        MenuComponent next();
    }

    public class MenuItem : MenuComponent
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

        public void print()
        {
            Console.WriteLine("  " + getName());
            if (isVegetarian())
            {
                Console.WriteLine("(v)");
            }
            Console.WriteLine(", " + getPrice());
            Console.WriteLine("     -- " + getDescription());
        }
    }

    public class Waitress
    {
        MenuComponent allMenus;

        public Waitress(MenuComponent allMenus)
        {
            this.allMenus = allMenus;
        }

        public virtual void printMenu()
        {
            allMenus.print();
        }
    }
}

