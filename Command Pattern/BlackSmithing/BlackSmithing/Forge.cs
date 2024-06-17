using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackSmithing
{
    class Forge  // Invoker and decorater base????
    {
        private readonly IForge Decorator;


        public ICommandBase SmeltingCom { get; set; }
        public ICommandBase QuenchingCom { get; set; }
        //  public ICommandBase HoldingCom { get; set; }
        //  public ICommandBase WeldingCom { get; set; }
        // public ICommandBase CastingCom { get; set; }
        public ICommandBase HittingCom { get; set; }
        public ICommandBase ShapingCom { get; set; }
        public ICommandBase StaminaUpCom { get; set; }
        public ICommandBase Forging1Com { get; set; }
        public ICommandBase Forging2Com { get; set; }
        public ICommandBase Forging3Com { get; set; }

        


        bool bSmelting = false;
        bool bQuenching = false;

        public Forge()
        {
            this.Decorator = Decorator ?? throw new ArgumentException(nameof(Decorator));
        }

        public void Invoke(ICommandBase command)
        {
            //command.Execute();
            //Decorate.Invoke(command);

            try
            {
                Decorator.Invoke(command);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Weapon broke");
            }
        }

        public void Smelting()
        {
            if (bSmelting)
            {
                SmeltingCom.Undo();
            }
            else
            {
                 SmeltingCom.Execute();
               // Decorate.Invoke(SmeltingCom);
            }
            bSmelting = !bSmelting;       // toggles heating mode
        }

        public void Quenching()         // blacksmith quenching and stopping
        {
            if (bQuenching)
            {
                
                QuenchingCom.Undo();
            }
            else
            {
                QuenchingCom.Undo();
            }
            bQuenching = !bQuenching;

        }

        public void Hitting()
        {
            HittingCom.Execute();
        }
        public void Shaping()
        {
            ShapingCom.Execute();
        }

        public void Eating()
        {
            StaminaUpCom.Execute();
        }

        public void SetForge1()
        {
            Forging1Com.Execute();
        }

        public void SetForge2()
        {
            Forging2Com.Execute();
        }

        public void SetForge3()
        {
            Forging3Com.Execute();
        }
    }

}
