using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesP.Strategy
{
    class TurnOffCommunicativeServices : IInjectWhite
    {
        public StateAfterInjection InjectWhite()
        {
            return new StateAfterInjection("Полное отключение коммуникативных служб.", false);
        }
    }
}
