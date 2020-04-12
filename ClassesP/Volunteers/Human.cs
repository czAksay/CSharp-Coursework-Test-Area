using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using ClassesP.Strategy;

namespace ClassesP.Volunteers
{
    public enum Race { European, American, African };
    public class Human : Volunteer
    {
        String first_name;
        String last_name;
        int age;
        Race race;
        int hunger;
        int thirst;

        public Human(int _id, String _fname, String _lname, int _age, Race _race) : base(_id)
        {
            first_name = _fname;
            last_name = _lname;
            voltype = VolType.Human;
            age = _age;
            race = _race;
            hunger = 0;
            thirst = 0;

            switch (race)
            {
                case Race.African:
                    whiteInject = new ImmediateDeath();
                    blackInject = new NoReaction();
                    redInject = new HairGrowth();
                    img = Properties.Resources.african;
                    break;
                case Race.American:
                    whiteInject = new LossOfConsciousness();
                    blackInject = new WorsePerseption();
                    redInject = new NoReaction();
                    img = Properties.Resources.american;
                    break;
                case Race.European:
                    whiteInject = new NoReaction();
                    blackInject = new HastedSpeech();
                    redInject = new NoseBleeding();
                    img = Properties.Resources.european;
                    break;
            }
        }

        public override String Introduce()
        {
            return "Меня зовут " + first_name + " " + last_name + ". Возраст: " + age.ToString() + ". Раса: " + race.ToString() + ". Id: " + id;
        }

        public override String GetState()
        {
            return "Мое состояние\nГолод: " + hunger + "%\nЖажда: " + thirst + "%";
        }

        public override String Feed()
        {
            int n;
            if (hunger >= 50)
            {
                hunger -= 50;
                n = 50;
            }
            else
            {
                n = hunger;
                hunger = 0;
            }
            return "Голод уменьшен на " + n + "%";
        }

        public override String GiveDrink()
        {
            int n;
            if (thirst >= 60)
            {
                thirst -= 60;
                n = 60;
            }
            else
            {
                n = thirst;
                thirst = 0;
            }
            return "Жажда уменьшена на " + n + "%";
        }

        public override String Repair()
        {
            return "Нет, мне что-то не хочется";
        }

        public override bool HourOfLife()
        {
            hunger += 4;
            thirst += 6;
            time_in_area++;
            if (hunger >= 100 || thirst >= 100)
                return true;
            else
                return false;
        }

        public override string GetName()
        {
            return first_name + " " + last_name;
        }
    }
}
