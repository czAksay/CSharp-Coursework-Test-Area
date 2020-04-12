using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using ClassesP.Strategy;

namespace ClassesP.Volunteers
{
    public enum Architecture { KASint, AmdRodeon, Intpel };
    public class Robot : Volunteer
    {
        String model;
        String company;
        int tech_condition;
        Architecture architecture;

        public Robot(int _id, String _model, String _company, Architecture _architecture) : base(_id)
        {
            model = _model;
            company = _company;
            voltype = VolType.Robot;
            architecture = _architecture;
            tech_condition = 0;

            switch (architecture)
            {
                case Architecture.AmdRodeon:
                    whiteInject = new TurnOffCommunicativeServices();
                    blackInject = new BodyWarmUp();
                    redInject = new NoReaction();
                    img = Properties.Resources.rodeon;
                    break;
                case Architecture.KASint:
                    whiteInject = new NoReaction();
                    blackInject = new FreezeOnTheSpot();
                    redInject = new SuicideByWall();
                    img = Properties.Resources.sintka;
                    break;
                case Architecture.Intpel:
                    whiteInject = new UnstoppableScream();
                    blackInject = new NoReaction();
                    redInject = new SuicideByHead();
                    img = Properties.Resources.intpel;
                    break;
            }
        }

        public override String Introduce()
        {
            return "Модель " + model + " компании " + company + ". Архитектура: " + architecture + ". Id: " + id;
        }

        public override String GetState()
        {
            return "Мое техническое состояние: " + (100 - tech_condition) + "%";
        }

        public override String Feed()
        {
            return "Еда мне не нужна";
        }

        public override String GiveDrink()
        {
            return "Вода мне не нужна";
        }

        public override String Repair()
        {
            int n;
            if (tech_condition >= 80)
            {
                n = 80;
                tech_condition -= 80;
            }
            else
            {
                n = tech_condition;
                tech_condition = 0;
            }
            return "Отремонтировае на " + n + "%";
        }

        public override bool HourOfLife()
        {
            tech_condition += 5;
            time_in_area++;
            if (tech_condition >= 100)
                return true;
            else
                return false;
        }

        public override string GetName()
        {
            return model + "(" + company + ")";
        }
    }
}
