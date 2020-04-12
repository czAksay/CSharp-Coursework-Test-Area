using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesP.Strategy
{
    class SuicideByWall : IInjectRed
    {
        public StateAfterInjection InjectRed()
        {
            return new StateAfterInjection("Самоуничтожение путем биения головой об стенку.", true);
        }
    }
}
