using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using ClassesP.Strategy;

namespace ClassesP.Volunteers
{
    public enum VolType { Human, Robot};

    abstract public class Volunteer
    {
        protected int id;
        protected int time_in_area;
        protected VolType voltype;
        protected Image img;

        protected IInjectBlack blackInject;
        protected IInjectRed redInject;
        protected IInjectWhite whiteInject;

        public Volunteer(int _id)
        {
            id = _id;
            time_in_area = 0;
        }

        public int ID { get { return id; } }

        public VolType Type { get { return voltype; } }

        public Image Photo { get { return img; } }

        public abstract String Introduce();
        public abstract String GetState();
        public String GetTimeInArea()
        {
            return "Время нахождения в испытательной комнате: " + time_in_area + " час(-ов)";
        }

        public abstract String Feed();
        public abstract String GiveDrink();
        public abstract String Repair();
        public abstract bool HourOfLife();
        public abstract String GetName();

        public StateAfterInjection InjectBlack()
        {
            return blackInject.InjectBlack();
        }

        public StateAfterInjection InjectRed()
        {
            return redInject.InjectRed();
        }

        public StateAfterInjection InjectWhite()
        {
            return whiteInject.InjectWhite();
        }
    }
}
