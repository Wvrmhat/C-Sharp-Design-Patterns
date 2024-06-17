using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SpellAttacks
{
    class FlameStatusDecorator : CommandBase
    {
        // private string ICommand _decorateCommand;
        CommandBase _decorateCommand = null;
        public FlameStatusDecorator(CommandBase _decorateCommand)
        {
            _decorateCommand = _decorateCommand;
        }

        public void Execute()
        {
            Console.WriteLine("Applied flame status effect");
            _decorateCommand.Execute();
        }

        public void Undo()
        {
            Console.WriteLine("Removed flame status effect");
            _decorateCommand.Undo();
        }
    }
}
