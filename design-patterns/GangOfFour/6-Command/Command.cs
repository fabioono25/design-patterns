using System;
namespace design_patterns.HeadFirst.Command
{
    // common interface for all commands
    public interface Command
    {
        public void Execute();
        public void Undo();
    }

    public class NoCommand : Command
    {
        public void Execute()
        {
            Console.WriteLine("No command executed");
        }

        public void Undo()
        {
            Console.WriteLine("Undo from nothing.");
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

        public void Undo()
        {
            light.off();
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

        public void Undo()
        {
            light.on();
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

        public void Undo()
        {
            garageDoor.close();
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

        public void Undo()
        {
            garageDoor.open();
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

    public enum CeilingFanSpeed { LOW, MEDIUM, HIGH}

    public class CeilingFan
    {
        String location = "";
        CeilingFanSpeed level;

        public CeilingFan(String location)
        {
            this.location = location;
        }

        public void high()
        {
            // turns the ceiling fan on to high
            level = CeilingFanSpeed.HIGH;
            Console.WriteLine(location + " ceiling fan is on high");

        }

        public void medium()
        {
            // turns the ceiling fan on to medium
            level = CeilingFanSpeed.MEDIUM;
            Console.WriteLine(location + " ceiling fan is on medium");
        }

        public void low()
        {
            // turns the ceiling fan on to low
            level = CeilingFanSpeed.LOW;
            Console.WriteLine(location + " ceiling fan is on low");
        }

        public void off()
        {
            // turns the ceiling fan off
            level = 0;
            Console.WriteLine(location + " ceiling fan is off");
        }

        public CeilingFanSpeed getSpeed()
        {
            return level;
        }
    }

    public class CeilingFanHighCommand : Command
    {
        CeilingFan ceilingFan;
        CeilingFanSpeed prevSpeed;

        public CeilingFanHighCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }
        public void Execute()
        {
            prevSpeed = ceilingFan.getSpeed();
            ceilingFan.high();
        }

        public void Undo()
        {
            switch (prevSpeed)
            {
                case CeilingFanSpeed.HIGH: ceilingFan.high(); break;
                case CeilingFanSpeed.MEDIUM: ceilingFan.medium(); break;
                case CeilingFanSpeed.LOW: ceilingFan.low(); break;
                default: ceilingFan.off(); break;
            }
        }
    }

    public class CeilingFanMediumCommand : Command
    {
        CeilingFan ceilingFan;
        CeilingFanSpeed prevSpeed;

        public CeilingFanMediumCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }
        public void Execute()
        {
            prevSpeed = ceilingFan.getSpeed();
            ceilingFan.medium();
        }

        public void Undo()
        {
            switch (prevSpeed)
            {
                case CeilingFanSpeed.HIGH: ceilingFan.high(); break;
                case CeilingFanSpeed.MEDIUM: ceilingFan.medium(); break;
                case CeilingFanSpeed.LOW: ceilingFan.low(); break;
                default: ceilingFan.off(); break;
            }
        }
    }

    public class CeilingFanOffCommand : Command
    {
        CeilingFan ceilingFan;
        CeilingFanSpeed prevSpeed;

        public CeilingFanOffCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }
        public void Execute()
        {
            prevSpeed = ceilingFan.getSpeed();
            ceilingFan.off();
        }

        public void Undo()
        {
            switch (prevSpeed)
            {
                case CeilingFanSpeed.HIGH: ceilingFan.high(); break;
                case CeilingFanSpeed.MEDIUM: ceilingFan.medium(); break;
                case CeilingFanSpeed.LOW: ceilingFan.low(); break;
                default: ceilingFan.off(); break;
            }
        }
    }
}