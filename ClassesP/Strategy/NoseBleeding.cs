using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesP.Strategy
{
    class NoseBleeding : IInjectRed
    {
        public StateAfterInjection InjectRed()
        {
            return new StateAfterInjection("Потеря сознания, учащение сердцебиения, внушительный храп", false);
        }
    }
}
