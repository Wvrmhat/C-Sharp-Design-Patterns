using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellAttacks
{
    class Spells            // Invoker
    {
        public CommandBase DestrucCom { get; set; }
        public CommandBase IlluCom { get; set; }
        public CommandBase ConjurCom { get; set; }

        public CommandBase ChargeUpCom { get; set; }
        
        public CommandBase Spell1Com { get; set; }
        public CommandBase Spell2Com { get; set; }
        public CommandBase Spell3Com { get; set; }

       // public CommandBase StanceCom { get; set; }

        bool bDestruc = false;
        bool bIllu = false;
        bool bConjur = false;

        public void Destruction()   // Used in MAIN
        {
            if(bDestruc)
            {
                DestrucCom.Undo();
            }
            else
            {
            
                DestrucCom.Execute();
            }
            bDestruc = !bDestruc;
        }

        public void Illusion()
        {
            if (bIllu)
            {
                IlluCom.Undo();
            }
            else
            { 
                IlluCom.Execute(); 
            }
            bIllu = !bIllu;
        }

        public void Conjuration()
        {
            if(bConjur)
            {
                ConjurCom.Undo();
            }
            else
            {
                ConjurCom.Execute();
            }
            bConjur = !bConjur;
        }

        public void ChargeUp()
        {
            ChargeUpCom.Execute();
        }

        public void SetSpell1()
        {
            Spell1Com.Execute();
        }

        public void SetSpell2()
        {
            Spell2Com.Execute();
        }

        public void SetSpell3()
        {
            Spell3Com.Execute();
        }

       


    }
}
