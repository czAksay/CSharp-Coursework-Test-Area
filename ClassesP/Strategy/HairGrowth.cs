using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesP.Strategy
{
    class HairGrowth : IInjectRed
    {
        public StateAfterInjection InjectRed()
        {
            return new StateAfterInjection("Крайне интенсивный рост бровей и волос на щиколотках", false);
        }
    }
}
