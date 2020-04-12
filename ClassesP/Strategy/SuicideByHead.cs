using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesP.Strategy
{
    class SuicideByHead : IInjectRed
    {
        public StateAfterInjection InjectRed()
        {
            return new StateAfterInjection("Самоуничтожение путем откручивания собственной головы.", true);
        }
    }
}
