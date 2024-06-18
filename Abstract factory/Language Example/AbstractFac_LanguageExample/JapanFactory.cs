using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFac_LanguageExample
{
    class JapanFactory : IInternationalFactory      // Concrete Factory 2
    {
        public ICapitalCity CreateCapital()
        {
            return new Kyoto();
        }

        public ILanguage language()
        {
            return new Japanese();
        }
    }
}
