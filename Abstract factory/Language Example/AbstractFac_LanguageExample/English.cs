﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFac_LanguageExample
{
    class English : ILanguage   // ConcreteProduct A1
    {
        public void Greet()
        {
            Console.WriteLine("Hello");
        }
    }
}
