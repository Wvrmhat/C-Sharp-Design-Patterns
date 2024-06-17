using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandExample
{
    class UniversalRemote       // Invoker
    {
        public CommandBase PowerCom { get; set; }
        public CommandBase MuteCom { get; set; }
        public CommandBase VolumeUpCom { get; set; }
        public CommandBase VolumeDownCom { get; set; }
        
        public CommandBase Source1Com { get; set; }
        public CommandBase Source2Com { get; set; }
        public CommandBase Source3Com { get; set; }

        public CommandBase MacroCom { get; set; }

        public Queue<CommandBase> Commands = new Queue<CommandBase>();
        private Stack<CommandBase> _undoStack = new Stack<CommandBase>();

        public void ExecuteCommand()
        {
            while(Commands.Count>0)
            {
                CommandBase command = Commands.Dequeue();
                command.Execute();
                _undoStack.Push(command);
            }
        }

        public void UndoCommand(int numUndos)
        {
            while(numUndos > 0 && _undoStack.Count > 0)
            {
                CommandBase command = _undoStack.Pop();
                command.Undo();
                numUndos--;
            }
        }





        bool PoweredOn = false;
        bool Muted = false;

        public void Power()
        {
            if(PoweredOn)
            {
                PowerCom.Undo();
            }
            else
            {
                PowerCom.Execute();
            }
            PoweredOn = !PoweredOn;
        }

        public void Mute()
        {
            if(Muted)
            {
                MuteCom.Undo();
            }
            else
            {
                MuteCom.Execute();
            }

            Muted = !Muted;
        }

        public void VolumeUp()
        {
            VolumeUpCom.Execute();
        }

        public void VolumeDown()
        {
            VolumeDownCom.Execute();
        }

        public void SetSource1()
        {
            Source1Com.Execute();
        }

        public void SetSource2()
        {
            Source2Com.Execute();
        }
        public void SetSource3()
        {
            Source3Com.Execute();
        }
        public void Macro()     //command consisting of various other commands
        {
            MacroCom.Execute();
        }

    }
}
