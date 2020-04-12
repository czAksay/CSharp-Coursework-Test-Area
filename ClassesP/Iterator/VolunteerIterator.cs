using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesP.Iterator;
using ClassesP.Volunteers;

namespace ClassesP.Iterator
{
    public class VolunteerIterator : IIterator
    {
        private TestArea testarea;
        private int current;

        public VolunteerIterator(TestArea _testarea)
        {
            testarea = _testarea;
        }

        public VolunteerIterator(TestArea _testarea, int index)
        {
            testarea = _testarea;
            current = index;
        }

        public Volunteer First()
        {
            current = 0;
            return testarea[current];
        }

        public int Index { get { return current; } }

        public Volunteer Current()
        {
            return testarea[current];
        }

        public bool isDone()
        {
            return current >= testarea.Count || current < 0;
        }

        public bool isPrev()
        {
            return current > 0;
        }

        public bool isNext()
        {
            return current < testarea.Count-1;
        }

        public Volunteer Last()
        {
            current = testarea.Count - 1;
            return testarea[current];
        }

        public void Update(TestArea _testarea)
        {
            testarea = _testarea;
            if (testarea.Empty)
                current = 0;
            else if (current >= testarea.Count)
                current = testarea.Count - 1;
        }

        public Volunteer Next()
        {
            current++;
            if (!isDone())
            {
                return testarea[current];
            }
            else
            {
                return null;
            }
        }

        public Volunteer Prev()
        {
            current--;
            if (!isDone())
            {
                return testarea[current];
            }
            else
            {
                return null;
            }
        }

        public bool SetCurrent(int index)
        {
            if (index < 0 || index > testarea.Count-1 || testarea.Empty)
            {
                return false;
            }
            else
            {
                current = index;
                return true;
            }
        }
    }
}