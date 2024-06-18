using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFac_LanguageExample
{
    class Kyoto : ICapitalCity // concrete product B2
    {
        public int getPopulation()
        {
            return 5400000;
        }

        public List<string> ListTopAttractions()
        {
            return new List<string> { "Mount fuji", "Isakawa Tower", "Nijo Castle" };
        }
    }
}
