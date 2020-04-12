using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesP.Strategy
{
    public struct StateAfterInjection
    {
        private String state_descr;
        private bool death;

        public String StateDescription { get { return state_descr; } }
        public bool Death { get { return death; } }

        public StateAfterInjection(String _descr, bool _death)
        {
            state_descr = _descr;
            death = _death;
        }
    }

    public interface IInjectBlack
    {
        StateAfterInjection InjectBlack();
    }
}
