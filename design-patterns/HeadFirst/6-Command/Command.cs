using System;
namespace design_patterns.HeadFirst.Command
{
    // common interface for all commands
    public interface Command
    {
        public void Execute();
    }

    public class NoCommand : Command
    {
        public void Execute()
        {
            Console.WriteLine("No command executed");
        }
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

    public class LightOffCommand : Command
    {
        Light light;

        public LightOffCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.off();
        }
    }

    // receiver: knows how to perform the action needed
    public class Light
    {
        internal string location;
        public Light(string location)
        {
            this.location = location;
        }

        internal void on()
        {
            Console.WriteLine("Light is on!");
        }

        internal void off()
        {
            Console.WriteLine("Light is off!");
        }
    }

    public class GarageDoorOpenCommand : Command
    {
        GarageDoor garageDoor;

        public GarageDoorOpenCommand(GarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }

        public void Execute()
        {
            garageDoor.open();
        }
    }

    public class GarageDoorCloseCommand : Command
    {
        GarageDoor garageDoor;

        public GarageDoorCloseCommand(GarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }

        public void Execute()
        {
            garageDoor.close();
        }
    }

    public class GarageDoor
    {
        internal string location;
        public GarageDoor(string location)
        {
            this.location = location;
        }

        internal void close()
        {
            Console.WriteLine("Garage door is closed!");
        }

        internal void open()
        {
            Console.WriteLine("Garage door is open!");
        }
    }

    public class CeilingFan
    {
        String location = "";
        int level;
        public static int HIGH = 2;
        public static int MEDIUM = 1;
        public static int LOW = 0;

        public CeilingFan(String location)
        {
            this.location = location;
        }

        public void high()
        {
            // turns the ceiling fan on to high
            level = HIGH;
            Console.WriteLine(location + " ceiling fan is on high");

        }

        public void medium()
        {
            // turns the ceiling fan on to medium
            level = MEDIUM;
            Console.WriteLine(location + " ceiling fan is on medium");
        }

        public void low()
        {
            // turns the ceiling fan on to low
            level = LOW;
            Console.WriteLine(location + " ceiling fan is on low");
        }

        public void off()
        {
            // turns the ceiling fan off
            level = 0;
            Console.WriteLine(location + " ceiling fan is off");
        }

        public int getSpeed()
        {
            return level;
        }
    }

    public class CeilingFanOnCommand : Command
    {
        CeilingFan ceilingFan;

        public CeilingFanOnCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }
        public void Execute()
        {
            ceilingFan.high();
        }
    }
    public class CeilingFanOffCommand : Command
    {
        CeilingFan ceilingFan;

        public CeilingFanOffCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }
        public void Execute()
        {
            ceilingFan.high();
        }
    }
}