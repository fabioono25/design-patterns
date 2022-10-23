using System;
using System.Text;

namespace design_patterns.HeadFirst.State
{
    public class GumballMachine
    {
        State soldOutState;
        State noQuarterState;
        State hasQuarterState;
        State soldState;
        State winnerState;

        State state;
        int count = 0;

        public GumballMachine(int numberGumballs)
        {
            soldOutState = new SoldOutState(this);
            noQuarterState = new NoQuarterState(this);
            hasQuarterState = new HasQuarterState(this);
            soldState = new SoldState(this);
            winnerState = new WinnerState(this);

            this.count = numberGumballs;
            if (numberGumballs > 0)
            {
                state = noQuarterState;
            }
        }

        public void insertQuarter()
        {
            state.insertQuarter();
        }

        public void ejectQuarter()
        {
            state.ejectQuarter();
        }

        public void turnCrank()
        {
            state.turnCrank();
            state.dispense();
        }

        public void setState(State state)
        {
            this.state = state;
        }

        public void releaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot...");
            if (count > 0)
            {
                count = count - 1;
            }
        }

        public int getCount()
        {
            return count;
        }

        public void refill(int count)
        {
            this.count += count;
            Console.WriteLine("The gumball machine was just refilled; its new count is: " + this.count);
            state.refill();
        }

        public State getState()
        {
            return state;
        }

        public State getSoldOutState()
        {
            return soldOutState;
        }

        public State getNoQuarterState()
        {
            return noQuarterState;
        }

        public State getHasQuarterState()
        {
            return hasQuarterState;
        }

        public State getSoldState()
        {
            return soldState;
        }

        public State getWinnerState()
        {
            return winnerState;
        }

        public String toString()
        {
            var result = new StringBuilder();
            result.Append("\nMighty Gumball, Inc.");
            result.Append("\nJava-enabled Standing Gumball Model #2004");
            result.Append("\nInventory: " + count + " gumball");
            if (count != 1)
            {
                result.Append("s");
            }
            result.Append("\n");
            result.Append("Machine is " + state + "\n");
            return result.ToString();
        }
    }
}

