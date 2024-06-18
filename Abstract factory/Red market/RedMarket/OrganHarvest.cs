using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedMarket
{
    abstract class OrganHarvest     // client
    {
        protected OrganBank TheBank;
        protected IHeart theHeart;
        protected IBrain theBrain;

        public OrganHarvest(OrganBank TheBank)
        {
            this.TheBank = TheBank;
            this.theHeart = TheBank.GetHeart();
            this.theBrain = TheBank.GetBrain();    


        }

        public virtual void OrderHeart()
        {
            Console.WriteLine(theHeart);
        }

        public virtual void OrderBrain()
        {

            Console.WriteLine(theBrain);
        }
    }
}
