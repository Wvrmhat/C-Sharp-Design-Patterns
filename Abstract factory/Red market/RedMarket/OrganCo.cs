using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedMarket
{
    abstract class OrganCo      // another client??
    {
        protected OrganBank theBank = null;

        public OrganCo(OrganBank theBank)
        {
            this.theBank = theBank;
        }

        public OrganHarvest OrderOrgan(string OrganName)
        {
            OrganHarvest Organ = FetchOrgan(OrganName);

            if(Organ != null)
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Getting: " + Organ.GetType().Name);
                Organ.OrderBrain();
                Organ.OrderHeart();

                Console.WriteLine("---------------------------------------");
                Console.WriteLine();
            }
            return Organ;
        }

        public abstract OrganHarvest FetchOrgan(string OrganName);

    }
}
