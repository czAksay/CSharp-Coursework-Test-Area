using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesP.Strategy
{
    class WorsePerseption : IInjectBlack
    {
        public StateAfterInjection InjectBlack()
        {
            return new StateAfterInjection("Ухудшение восприятия окружающего мира, заметное помутнение сознания.", false);
        }
    }
}
