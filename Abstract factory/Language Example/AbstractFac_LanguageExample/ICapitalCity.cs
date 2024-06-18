using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFac_LanguageExample
{
    public interface ICapitalCity   //Abstract product B
    {
        int getPopulation();
        List <string> ListTopAttractions();
    }
}
