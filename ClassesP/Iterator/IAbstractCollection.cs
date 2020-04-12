using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesP.Volunteers;

namespace ClassesP.Iterator
{
    interface IAbstractCollection
    {
        VolunteerIterator CreateIterator();
        int Count { get; }
        Volunteer this[int index] { get; }

        bool Empty { get; }
    }
}
