using System;
using System.Collections.Generic;

namespace design_patterns.HeadFirst.IteratorDesignPattern
{
    public interface Iterator<T>
    {
        bool hasNext();
        MenuItem next();
    }

    public class DinerMenuIterator : Iterator<MenuItem> {
        MenuItem [] list;
        int position = 0;

        public DinerMenuIterator(MenuItem[] list)
        {
            this.list = list;
        }

        public MenuItem next()
        {
            MenuItem menuItem = list[position];
            position = position + 1;
            return menuItem;
        }

        public bool hasNext()
        {
            if (position >= list.Length || list[position] == null)
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
                for (int i = position - 1; i < (list.Length - 1); i++)
                {
                    list[i] = list[i + 1];
                }
                list[list.Length - 1] = null;
            }
        }
    }

    public class PancakeHouseMenuIterator : Iterator<MenuItem>
    {
        List<MenuItem> list;
        int position = 0;

        public PancakeHouseMenuIterator(List<MenuItem> list)
        {
            this.list = list;
        }

        public MenuItem next()
        {
            MenuItem menuItem = list[position];
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

    public class Waitress
    {
        Menu pancakeHouseMenu;
        Menu dinerMenu;

        public Waitress(Menu pancakeHouseMenu, Menu dinerMenu)
        {
            this.pancakeHouseMenu = pancakeHouseMenu;
            this.dinerMenu = dinerMenu;
        }

        // implicit iteration
        public void printMenu()
        {
            List<MenuItem> breakfastItems = ((PancakeHouseMenu)pancakeHouseMenu).getMenuItems();
            foreach (MenuItem m in breakfastItems)
            {
                printMenuItem(m);
            }

            MenuItem[] lunchItems = ((DinerMenu)dinerMenu).getMenuItems();
            foreach (MenuItem m in lunchItems)
            {
                printMenuItem(m);
            }
        }

        public void printMenuItem(MenuItem menuItem)
        {
            Console.WriteLine(menuItem.getName() + ", ");
            Console.WriteLine(menuItem.getPrice() + " -- ");
            Console.WriteLine(menuItem.getDescription());
        }
    }
}

