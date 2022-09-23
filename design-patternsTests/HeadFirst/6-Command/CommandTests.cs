using System;
using design_patterns.HeadFirst.Command;
using design_patterns.HeadFirst.Singleton;
using Xunit;

namespace design_patternsTests.HeadFirst.Command
{
    public class CommandTests
    {
        [Fact]
        public void WorkingWithSimpleCommand()
        {
            var remote = new SimpleRemoteControl();
            var light = new Light();
            var lightOn = new LightOnCommand(light);

            var garageDoor = new GarageDoor();
            var garageDoorOpen = new GarageDoorOpen(garageDoor);

            remote.setCommand(lightOn);
            remote.buttonWasPressed();
            remote.setCommand(garageDoorOpen);
            remote.buttonWasPressed();
        }
    }
}

