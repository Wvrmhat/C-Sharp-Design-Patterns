using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShootingTest
{
    interface CommandBase       // Command base
    {
        void Execute();
        void Undo();
    }
}
