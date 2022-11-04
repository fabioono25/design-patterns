using System;

namespace design_patterns.HeadFirst.Command
{
    // invoker: holds command, set + has its own method that calls execute() method
    public class SimpleRemoteControl
    {
        Command slot;

        public void setCommand(Command command)
        {
            slot = command;
        }

        public void buttonWasPressed()
        {
            slot.Execute();
        }
    }
}

