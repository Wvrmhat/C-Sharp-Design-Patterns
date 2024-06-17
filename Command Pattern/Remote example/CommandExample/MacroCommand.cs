using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandExample
{
    class MacroCommand : CommandBase
    {
        List<CommandBase> Commands;

        public MacroCommand(List<CommandBase> Commands)
        {
            this.Commands = Commands;
        }

        public void Execute()
        {
            foreach (CommandBase Current in Commands)
                Current.Execute();
        }

        public void Undo()
        {
            foreach (CommandBase Current in Commands)
                Current.Undo();
        }
    }

    

}
