using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackSmithing
{
    class Program
    {
        static void Main(string[] args)
        {
            BlackSmith TheBlacksmith = new BlackSmith();
            Forge TheForge = new Forge();

        

            TheForge.Forging1Com = new SetForgeCommand(TheBlacksmith, "Sword");
            TheForge.SmeltingCom = new SmeltCommand(TheBlacksmith, "Steel");         // melting metal for the weapon command
            TheForge.ShapingCom = new ShapingCommand(TheBlacksmith);        // shaping the metal
            TheForge.QuenchingCom = new QuenchSelected(TheBlacksmith);      // dipping the blade in water
            TheForge.StaminaUpCom = new IncreaseStaminaCommand(TheBlacksmith);

            TheForge.SmeltingCom.Execute();
            TheForge.ShapingCom.Execute();
            TheForge.QuenchingCom.Execute();
            TheForge.StaminaUpCom.Execute();

            Console.WriteLine("------------------------");

            IForge sharpen = new SharpeningForge(Console.WriteLine, new BaseForge());

            Console.ReadLine();
        }
    }
}
