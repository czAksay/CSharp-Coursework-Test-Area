using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassesP.Volunteers;
using ClassesP.Iterator;
using ClassesP.Strategy;


namespace AreaTests 
{
    [TestClass]
    public class AreaTests
    {
        [TestMethod]
        public void CreateHuman()
        {
            Volunteer vl = new Human(1, "Джонни", "Вашингтон", 37, Race.American);
            Assert.AreEqual(vl.Type, VolType.Human);
        }

        [TestMethod]
        public void AddSomeVolsInTestArea()
        {
            TestArea ta = TestArea.getInstance();
            ta.AddVolunteer(new Human(ta.Serial(), "Джонни", "Вашингтон", 37, Race.American));
            ta.AddVolunteer(new Human(ta.Serial(), "Жан Клод", "Ван Дамович", 46, Race.American));
            ta.AddVolunteer(new Robot(ta.Serial(), "Киборг убийца", "ООО Какие люди", Architecture.KASint));
            Assert.AreEqual(3, ta.Count);
            Assert.AreEqual(false, ta.Empty);
        }

        [TestMethod]
        public void UseIterator()
        {
            TestArea ta = TestArea.getInstance();
            VolunteerIterator it = new VolunteerIterator(ta);
            Human vl = new Human(ta.Serial(), "Терминатор", "Ятуев", 19, Race.European);
            ta.AddVolunteer(vl);
            Assert.AreEqual(it.Last(), vl);
        }

        [TestMethod]
        public void CreateAfricanAndInjectHimBlack()
        {
            Human vl = new Human(100, "Аглы", "Матумба", 45, Race.African);
            StateAfterInjection sai = vl.InjectBlack();
            Assert.AreEqual(sai.StateDescription, "Нет реакции");
            Assert.AreEqual(sai.Death, false);
        }
    }
}
