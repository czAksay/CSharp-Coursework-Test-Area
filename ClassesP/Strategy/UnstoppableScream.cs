using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesP.Strategy
{
    class UnstoppableScream : IInjectWhite
    {
        public StateAfterInjection InjectWhite()
        {
            return new StateAfterInjection("Безостановочный крик", false);
        }
    }
}
