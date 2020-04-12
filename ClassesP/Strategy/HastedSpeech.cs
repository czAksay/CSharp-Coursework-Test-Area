using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesP.Strategy
{
    class HastedSpeech : IInjectBlack
    {
        public StateAfterInjection InjectBlack()
        {
            return new StateAfterInjection("Ускорение речи, темные пятна на коже.", false);
        }
    }
}
