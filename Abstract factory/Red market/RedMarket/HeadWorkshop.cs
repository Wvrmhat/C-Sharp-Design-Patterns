using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedMarket
{
    class HeadWorkshop : OrganCo        // Concrete factory
    {
        public HeadWorkshop(OrganBank theBank) : base(theBank)
        { 
        }

        public override OrganHarvest FetchOrgan(string OrganName)
        {
            OrganHarvest theOrgan = null;

            if (OrganName == "Human Brain")
            {
                theOrgan = new FreshHumanBrain(this.theBank);
            }
            if(OrganName == "Spinal Cord")
            {
                theOrgan = new SpinalCord(this.theBank);
            }
            return theOrgan;
        }
    }
}
