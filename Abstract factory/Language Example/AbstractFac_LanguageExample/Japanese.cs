using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFac_LanguageExample
{
    class Japanese : ILanguage  // Concrete product A2
    {
        public void Greet()
        {
            Console.WriteLine("Konnichiwa~");
        }
    }
}
