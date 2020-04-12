﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesP.Strategy
{
    class ImmediateDeath : IInjectWhite
    {
        public StateAfterInjection InjectWhite()
        {
            return new StateAfterInjection("Мгновенная смерть", true);
        }
    }
}
