using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassesP.Volunteers;
using ClassesP.Iterator;
using ClassesP.Strategy;

namespace TestAreaNS
{
    public partial class FTestArea : Form
    {
        ClassesP.Iterator.TestArea ta;
        VolunteerIterator iterator;

        public FTestArea()
        {
            InitializeComponent();
            ta = ClassesP.Iterator.TestArea.getInstance();
            iterator = new VolunteerIterator(ta);
            UpdateIterator();
        }

        protected void UpdateIterator()
        {
            iterator.Update(ta);
            if (ta.Empty)
            {
                lblPointer.Text = "0/0";
                pnlCommands.Enabled = false;
                btnDelete.Enabled = false;
            }
            else
            {
                lblPointer.Text = (iterator.Index + 1).ToString() + "/" + ta.Count.ToString();
                pnlCommands.Enabled = true;
                btnDelete.Enabled = true;
            }



            VolunteerIterator iterator2 = new VolunteerIterator(ta, iterator.Index);
            if (!ta.Empty)
            {
                pbCurrent.Image = iterator2.Current().Photo;
                pbCurrent.Visible = true;
            }
            else
                pbCurrent.Visible = false;
            if (iterator2.isNext())
            {
                pbNext.Image = iterator2.Next().Photo;
                pbNext.Visible = true;
            }
            else
                pbNext.Visible = false;
            if (iterator2.isNext())
            {
                lblNext2.Visible = true;
            }
            else
                lblNext2.Visible = false;

            iterator2 = new VolunteerIterator(ta, iterator.Index);
            if (iterator2.isPrev())
            {
                pbPrev.Image = iterator2.Prev().Photo;
                pbPrev.Visible = true;
            }
            else
                pbPrev.Visible = false;
            if (iterator2.isPrev())
            {
                lblPrev2.Visible = true;
            }
            else
                lblPrev2.Visible = false;
        }

        private void btnPrevVol_Click(object sender, EventArgs e)
        {
            if (iterator.isPrev())
            {
                iterator.Prev();
                UpdateIterator();
            }
        }

        private void btnNextVol_Click(object sender, EventArgs e)
        {
            if (iterator.isNext())
            {
                iterator.Next();
                UpdateIterator();
            }
        }

        private void btnIntroduce_Click(object sender, EventArgs e)
        {
            Output(iterator.Current().Introduce());
        }

        private void Output(String text)
        {
            lblOutput.Text = text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddVol av = new AddVol();
            var result = av.ShowDialog();
            if (result == DialogResult.OK)
            {
                //ta.AddVolunteer(av.NewMember);
                Log(av.LogMessage);
            }
            UpdateIterator();
        }

        private void btnGetState_Click(object sender, EventArgs e)
        {
            Output(iterator.Current().GetState());
        }

        private void btnTime_Click(object sender, EventArgs e)
        {
            Output(iterator.Current().GetTimeInArea());
        }

        private void btnRepair_Click(object sender, EventArgs e)
        {
            if (!ckbxAll.Checked)
                Output(iterator.Current().Repair());
            else if (!ta.Empty)
            {
                VolunteerIterator iter = new VolunteerIterator(ta);
                Volunteer member = iter.First();
                while (!iter.isDone())
                {
                    member.Repair();
                    member = iter.Next();
                }
                Output("Все отремонтированы.");
            }
        }

        private void btnDrink_Click(object sender, EventArgs e)
        {
            if (!ckbxAll.Checked)
                Output(iterator.Current().GiveDrink());
            else if (!ta.Empty)
            {
                VolunteerIterator iter = new VolunteerIterator(ta);
                Volunteer member = iter.First();
                while (!iter.isDone())
                {
                    member.GiveDrink();
                    member = iter.Next();
                }
                Output("Все напоены.");
            }
        }

        private void btnFeed_Click(object sender, EventArgs e)
        {
            if (!ckbxAll.Checked)
                Output(iterator.Current().Feed());
            else if (!ta.Empty)
            {
                VolunteerIterator iter = new VolunteerIterator(ta);
                Volunteer member = iter.First();
                while (!iter.isDone())
                {
                    member.Feed();
                    member = iter.Next();
                }
                Output("Все накормлены.");
            }
        }

        private void tmrClock_Tick(object sender, EventArgs e)
        {
            if (!ta.Empty)
            {
                VolunteerIterator iter = new VolunteerIterator(ta);
                Volunteer member = iter.First();
                while (!iter.isDone())
                {
                    if (member.HourOfLife())
                    {
                        Log(member.GetName() + "[id:" + member.ID.ToString() + "] погибает.");
                        ta.RemoveVolunteer(iter.Index);
                    }
                    member = iter.Next();
                }
                UpdateIterator();
            }
        }

        public void Log(String text)
        {
            lbLog.Items.Add(text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Log(iterator.Current().GetName() + "[id:" + iterator.Current().ID.ToString() + "] покидает комнату.");
            ta.RemoveVolunteer(iterator.Index);
            UpdateIterator();
        }

        private void btnInject_Click(object sender, EventArgs e)
        {
            Inject inj = new Inject();
            var result = inj.ShowDialog();
            if (result == DialogResult.OK)
            {
                StateAfterInjection state = new StateAfterInjection();
                switch (inj.SelectedColor)
                {
                    case InjectColor.Black:
                        state = iterator.Current().InjectBlack();
                        break;
                    case InjectColor.Red:
                        state = iterator.Current().InjectRed();
                        break;
                    case InjectColor.White:
                        state = iterator.Current().InjectWhite();
                        break;
                }
                Output("Реакция: " + state.StateDescription);
                if (state.Death)
                {
                    Log(iterator.Current().GetName() + "[id:" + iterator.Current().ID.ToString() + "] погибает.");
                    ta.RemoveVolunteer(iterator.Index);
                }
            }
            UpdateIterator();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            if (tbVolNumber.Text == String.Empty)
            {
                MessageBox.Show("Введите порядковый номер добровольца.", "К размышлению", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int index;
                if (!Int32.TryParse(tbVolNumber.Text, out index))
                {
                    MessageBox.Show("Некорректный номер добровольца.", "К размышлению", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!iterator.SetCurrent(index - 1))
                {
                    MessageBox.Show("Добровольца с заданным порядковым номером нет.", "К размышлению", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    UpdateIterator();
                }
            }
        }
    }

}
