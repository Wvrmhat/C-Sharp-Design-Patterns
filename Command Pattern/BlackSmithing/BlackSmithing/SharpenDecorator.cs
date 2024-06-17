using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackSmithing
{
    class SharpenDecorator : ICommandBase
    {
        private readonly ICommandBase wrappedWeapon;
        private readonly string enchantment;

        public SharpenDecorator(ICommandBase wrappedWeapon, string enchantment)
        {
            this.wrappedWeapon = wrappedWeapon;
            this.enchantment = enchantment;
        }

        public void Execute()
        {
            Console.WriteLine("Applying {0} to {1}", enchantment, wrappedWeapon.ToString());
            wrappedWeapon.Execute();
        }

        public void Undo()
        {

        }
    }
}
