using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            OrganCo organco = new HeadWorkshop(new HumanOrganFactory());
            OrganHarvest theOrgan = organco.OrderOrgan("Human Brain");
            theOrgan = organco.OrderOrgan("Human Heart");

            Console.ReadLine();
        }
    }
}
