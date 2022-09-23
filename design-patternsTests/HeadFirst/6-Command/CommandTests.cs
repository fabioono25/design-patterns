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
            var garageDoorOpen = new GarageDoorOpenCommand(garageDoor);

            remote.setCommand(lightOn);
            remote.buttonWasPressed();
            remote.setCommand(garageDoorOpen);
            remote.buttonWasPressed();
        }

        [Fact]
        public void WorkingWithCommand()
        {
            RemoteControl remoteControl = new RemoteControl();

            Light livingRoomLight = new Light("Living Room");
            Light kitchenLight = new Light("Kitchen");
            CeilingFan ceilingFan = new CeilingFan("Living Room");
            GarageDoor garageDoor = new GarageDoor("Garage");

            LightOnCommand livingRoomLightOn =
                    new LightOnCommand(livingRoomLight);
            LightOffCommand livingRoomLightOff =
                    new LightOffCommand(livingRoomLight);
            LightOnCommand kitchenLightOn =
                    new LightOnCommand(kitchenLight);
            LightOffCommand kitchenLightOff =
                    new LightOffCommand(kitchenLight);

            GarageDoorOpenCommand garageDoorUp =
                    new GarageDoorOpenCommand(garageDoor);
            GarageDoorCloseCommand garageDoorDown =
                    new GarageDoorCloseCommand(garageDoor);

            CeilingFanOnCommand ceilingFanOn =
                    new CeilingFanOnCommand(ceilingFan);
            CeilingFanOffCommand ceilingFanOff =
                    new CeilingFanOffCommand(ceilingFan);

            remoteControl.setCommand(0, livingRoomLightOn, livingRoomLightOff);
            remoteControl.setCommand(1, kitchenLightOn, kitchenLightOff);
            remoteControl.setCommand(2, ceilingFanOn, ceilingFanOff);

            Console.WriteLine(remoteControl);

            remoteControl.onButtonWasPushed(0);
            remoteControl.offButtonWasPushed(0);
            remoteControl.onButtonWasPushed(1);
            remoteControl.offButtonWasPushed(1);
            remoteControl.onButtonWasPushed(2);
            remoteControl.offButtonWasPushed(2);
            remoteControl.onButtonWasPushed(3);
            remoteControl.offButtonWasPushed(3);
        }
    }
}

