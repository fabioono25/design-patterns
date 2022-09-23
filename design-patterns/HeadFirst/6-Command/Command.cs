using System;
namespace design_patterns.HeadFirst.Command
{
    // common interface for all commands
    public interface Command
    {
        public void Execute();
    }

    // Concrete command
    public class LightOnCommand : Command
    {
        Light light;

        public LightOnCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.on();
        }
    }

    // receiver: knows how to perform the action needed
    public class Light
    {
        internal void on()
        {
            Console.WriteLine("Light is on!");
        }
    }

    public class GarageDoorOpen : Command
    {
        GarageDoor garageDoor;

        public GarageDoorOpen(GarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }

        public void Execute()
        {
            garageDoor.open();
        }
    }

    public class GarageDoor
    {
        internal void open()
        {
            Console.WriteLine("Garage door is open!");
        }
    }
}

