using System;
using System.Text;

namespace design_patterns.HeadFirst.Command
{
    public class RemoteControl
    {
        Command[] onCommands;
        Command[] offCommands;
        Command undoCommand;

        public RemoteControl()
        {
            onCommands = new Command[7];
            offCommands = new Command[7];

            var noCommand = new NoCommand();
            for (int i = 0; i < 7; i++)
            {
                onCommands[i] = noCommand;
                offCommands[i] = noCommand;
            }

            undoCommand = noCommand;
        }

        public void setCommand(int slot, Command onCommand, Command offCommand)
        {
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }

        public void onButtonWasPushed(int slot)
        {
            onCommands[slot].Execute();
            undoCommand = onCommands[slot];
        }

        public void offButtonWasPushed(int slot)
        {
            offCommands[slot].Execute();
            undoCommand = offCommands[slot];
        }

        public void undoButtonWasPushed()
        {
            undoCommand.Undo();
        }

        public override string ToString()
        {
            var stringBuff = new StringBuilder();
            stringBuff.Append("\n------ Remote Control -------\n");
            for (int i = 0; i < onCommands.Length; i++)
            {
                stringBuff.Append("[slot " + i + "] " + onCommands[i].GetType().Name
                    + "    " + offCommands[i].GetType().Name + "\n");
            }
            return stringBuff.ToString();
        }
    }
}

