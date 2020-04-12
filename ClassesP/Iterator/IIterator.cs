using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesP.Volunteers;

namespace ClassesP.Iterator
{
    interface IIterator
    {
        Volunteer First();
        Volunteer Next();
        Volunteer Prev();
        Volunteer Last();
        Volunteer Current();
        bool isDone();
    }
}
