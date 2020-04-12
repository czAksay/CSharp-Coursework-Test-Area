using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesP.Volunteers;

namespace ClassesP.Iterator
{
    public class TestArea : IAbstractCollection
    {
        private static TestArea instance;

        private List<Volunteer> members = new List<Volunteer>();

        private int next_member_id;

        private TestArea()
        {
            next_member_id = 1;
        }


        public static TestArea getInstance()
        {
            if (instance == null)
                instance = new TestArea();
            return instance;
        }

        public int Serial()
        {
            return next_member_id++;
        }

        public void AddVolunteer(Volunteer volunteer)
        {
            members.Add(volunteer);
        }

        public void RemoveVolunteer(int index)
        {
            members.RemoveAt(index);
        }

        public Volunteer this[int index] { get { return members[index]; } }

        public int Count { get { return members.Count; } }

        public bool Empty { get { return members.Count == 0; } }

        public VolunteerIterator CreateIterator()
        {
            return new VolunteerIterator(this);
        }
    }
}
