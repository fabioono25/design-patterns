using System;
using System.IO;

namespace design_patterns.HeadFirst.TemplateMethod
{
    public abstract class CaffeineBeverageWithHook
    {
        public void prepareRecipe()
        {
            boilWater();
            brew();
            pourInCup();
            if (customerWantsCondiments())
            {
                addCondiments();
            }
        }

        public abstract void brew();

        public abstract void addCondiments();

        void boilWater()
        {
            Console.WriteLine("Boiling water");
        }

        void pourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }

        public bool customerWantsCondiments()
        {
            return true;
        }
    }

    public class CoffeeWithHook: CaffeineBeverageWithHook
    {
        public override void brew()
        {
            Console.WriteLine("Dripping Coffee through filter");
        }

        public override void addCondiments()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }

        public bool customerWantsCondiments()
        {

            String answer = getUserInput();

            if (answer.ToLowerInvariant().StartsWith("y"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private String getUserInput()
        {
            String answer = null;

            Console.WriteLine("Would you like milk and sugar with your coffee (y/n)? ");

            try
            {
                answer = Console.ReadLine();
            }
            catch (IOException ioe)
            {
                Console.WriteLine("IO error trying to read your answer");
            }
            if (answer == null)
            {
                return "no";
            }
            return answer;
        }
    }

    public class TeaWithHook: CaffeineBeverageWithHook
    {


    public override void brew()
    {
        Console.WriteLine("Steeping the tea");
    }

    public override void addCondiments()
    {
        Console.WriteLine("Adding Lemon");
    }

    public bool customerWantsCondiments()
    {

        String answer = getUserInput();

        if (answer.ToLowerInvariant().StartsWith("y"))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private String getUserInput()
    {
        // get the user's response
        String answer = null;

        Console.WriteLine("Would you like lemon with your tea (y/n)? ");

        try
        {
            answer = Console.ReadLine();
        }
        catch (IOException ioe)
        {
            Console.WriteLine("IO error trying to read your answer");
        }
        if (answer == null)
        {
            return "no";
        }
        return answer;
    }
}
}

