using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFac_LanguageExample
{
    public interface IInternationalFactory      // Abstract factory
    {
        ILanguage CreateLanguage();

        ICapitalCity CreateCapital();
    }
}
