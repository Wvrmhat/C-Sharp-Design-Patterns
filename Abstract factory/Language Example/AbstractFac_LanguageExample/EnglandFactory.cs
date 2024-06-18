using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFac_LanguageExample
{
    public class EnglandFactory : IInternationalFactory    // concrete factory 1
    {
        public ICapitalCity CreateCapital()
        {
            return new London();
        }

        public ILanguage Createlanguage()
        {
            return new English();
        }
    }
}
