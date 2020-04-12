using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesP.Strategy
{
    class FreezeOnTheSpot : IInjectBlack
    {
        public StateAfterInjection InjectBlack()
        {
            return new StateAfterInjection("Застывание на месте в одной позе на несколько часов.", false);
        }
    }
}
