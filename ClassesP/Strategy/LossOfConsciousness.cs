using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesP.Strategy
{
    class LossOfConsciousness :IInjectWhite
    {
        public StateAfterInjection InjectWhite()
        {
            return new StateAfterInjection("Потеря сознания, учащение сердцебиения, внушительный храп", false);
        }
    }
}
