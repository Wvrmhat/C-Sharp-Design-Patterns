using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFac_LanguageExample
{
    class Program
    {
        static void Main(string[] args)
        {
            IInternationalFactory factory = new EnglandFactory();
            ILanguage language = factory.CreateLanguage();
            ICapitalCity capital = factory.CreateCapital();

            language.Greet();
            Console.WriteLine("Total Population: ", capital.getPopulation());
            Console.WriteLine("Top Attractions: ", string.Join(",", capital.ListTopAttractions()));
        }
    }
}
