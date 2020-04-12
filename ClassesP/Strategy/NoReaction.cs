using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesP.Strategy
{
    class NoReaction : IInjectWhite, IInjectBlack, IInjectRed
    {
        public StateAfterInjection InjectWhite()
        {
            return new StateAfterInjection("Нет реакции", false);
        }

        public StateAfterInjection InjectBlack()
        {
            return new StateAfterInjection("Нет реакции", false);
        }

        public StateAfterInjection InjectRed()
        {
            return new StateAfterInjection("Нет реакции", false);
        }
    }
}
