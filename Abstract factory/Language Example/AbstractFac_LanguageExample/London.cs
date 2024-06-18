using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFac_LanguageExample
{
    public class London : ICapitalCity // Concrete product B1
    {
        public int getPopulation()
        {
            return 8900000;
        }

        public List<string> ListTopAttractions()
        {
            return new List<string> { "Tower bride", "Buckingham Palace", "Big Ben" };
        }
    }
}
