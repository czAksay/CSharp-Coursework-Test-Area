using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesP.Strategy
{
    class BodyWarmUp : IInjectBlack
    {
        public StateAfterInjection InjectBlack()
        {
            return new StateAfterInjection("Сильное нагревание тела.", false);
        }
    }
}
