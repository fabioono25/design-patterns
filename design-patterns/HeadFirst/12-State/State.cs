using System;
namespace design_patterns.HeadFirst.State
{
    public interface State
    {
        public void insertQuarter();
        public void ejectQuarter();
        public void turnCrank();
        public void dispense();

        public void refill();
    }

    public class NoQuarterState: State
    {
            GumballMachine gumballMachine;


        public NoQuarterState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void insertQuarter()
        {
            Console.WriteLine("You inserted a quarter");
            gumballMachine.setState(gumballMachine.getHasQuarterState());
        }

        public void ejectQuarter()
        {
            Console.WriteLine("You haven't inserted a quarter");
        }

        public void turnCrank()
        {
            Console.WriteLine("You turned, but there's no quarter");
        }

        public void dispense()
        {
            Console.WriteLine("You need to pay first");
        }

        public void refill() { }

        public String toString()
        {
            return "waiting for quarter";
        }
    }

    public class SoldOutState : State
    {
        GumballMachine gumballMachine;


        public SoldOutState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void insertQuarter()
        {
            Console.WriteLine("You can't insert a quarter, the machine is sold out");
        }

        public void ejectQuarter()
        {
            Console.WriteLine("You can't eject, you haven't inserted a quarter yet");
        }

        public void turnCrank()
        {
            Console.WriteLine("You turned, but there are no gumballs");
        }

        public void dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }

        public void refill()
        {
            gumballMachine.setState(gumballMachine.getNoQuarterState());
        }

        public String toString()
        {
            return "sold out";
        }
    }

    public class HasQuarterState : State
    {
        Random randomWinner = new Random();
        GumballMachine gumballMachine;

        public HasQuarterState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void insertQuarter()
        {
            Console.WriteLine("You can't insert another quarter");
        }

        public void ejectQuarter()
        {
            Console.WriteLine("Quarter returned");
            gumballMachine.setState(gumballMachine.getNoQuarterState());
        }

        public void turnCrank()
        {
            Console.WriteLine("You turned...");
            int winner = randomWinner.Next(10);
            if ((winner == 0) && (gumballMachine.getCount() > 1))
            {
                gumballMachine.setState(gumballMachine.getWinnerState());
            }
            else
            {
                gumballMachine.setState(gumballMachine.getSoldState());
            }
        }

        public void dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }

        public void refill() { }

        public String toString()
        {
            return "waiting for turn of crank";
        }
    }

    public class SoldState : State
    {
        GumballMachine gumballMachine;


        public SoldState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void insertQuarter()
        {
            Console.WriteLine("Please wait, we're already giving you a gumball");
        }

        public void ejectQuarter()
        {
            Console.WriteLine("Sorry, you already turned the crank");
        }

        public void turnCrank()
        {
            Console.WriteLine("Turning twice doesn't get you another gumball!");
        }

        public void dispense()
        {
            gumballMachine.releaseBall();
            if (gumballMachine.getCount() > 0)
            {
                gumballMachine.setState(gumballMachine.getNoQuarterState());
            }
            else
            {
                Console.WriteLine("Oops, out of gumballs!");
                gumballMachine.setState(gumballMachine.getSoldOutState());
            }
        }

        public void refill() { }

        public String toString()
        {
            return "dispensing a gumball";
        }
    }
    public class WinnerState : State
    {
        GumballMachine gumballMachine;


        public WinnerState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void insertQuarter()
        {
            Console.WriteLine("Please wait, we're already giving you a Gumball");
        }

        public void ejectQuarter()
        {
            Console.WriteLine("Please wait, we're already giving you a Gumball");
        }

        public void turnCrank()
        {
            Console.WriteLine("Turning again doesn't get you another gumball!");
        }

        public void dispense()
        {
            gumballMachine.releaseBall();
            if (gumballMachine.getCount() == 0)
            {
                gumballMachine.setState(gumballMachine.getSoldOutState());
            }
            else
            {
                gumballMachine.releaseBall();
                Console.WriteLine("YOU'RE A WINNER! You got two gumballs for your quarter");
                if (gumballMachine.getCount() > 0)
                {
                    gumballMachine.setState(gumballMachine.getNoQuarterState());
                }
                else
                {
                    Console.WriteLine("Oops, out of gumballs!");
                    gumballMachine.setState(gumballMachine.getSoldOutState());
                }
            }
        }

        public void refill() { }

        public String toString()
        {
            return "despensing two gumballs for your quarter, because YOU'RE A WINNER!";
        }
    }
}

