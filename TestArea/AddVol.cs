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

namespace TestAreaNS
{
    partial class AddVol : Form
    {
        bool add_human;
        private String log_message;
        public String LogMessage { get { return log_message; } }
        public AddVol()
        {
            InitializeComponent();
            btnHuman.PerformClick();
            btnHuman_Click(new object(), new EventArgs());
            cmbRace.SelectedIndex = 0;
            cbArch.SelectedIndex = 0;
        }

        private void btnHuman_Click(object sender, EventArgs e)
        {
            btnHuman.BackColor = Color.Silver;
            btnRobot.BackColor = Control.DefaultBackColor;
            pnlAddHuman.Visible = true;
            pnlRobot.Visible = false;
            add_human = true;
        }

        private void btnRobot_Click(object sender, EventArgs e)
        {
            btnRobot.BackColor = Color.Silver;
            btnHuman.BackColor = Control.DefaultBackColor;
            pnlAddHuman.Visible = false;
            pnlRobot.Visible = true;
            add_human = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClassesP.Iterator.TestArea ta2 = ClassesP.Iterator.TestArea.getInstance();
            Volunteer member;
            if (add_human)
            {
                if (tbFirstName.Text != String.Empty && tbLastName.Text != String.Empty)
                {
                    member = new Human(ta2.Serial(), tbFirstName.Text, tbLastName.Text, (int)numAge.Value, (Race)cmbRace.SelectedIndex);
                }
                else
                {
                    MessageBox.Show("Заполните все поля!", "К размышлению", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                if (tbModel.Text != String.Empty && tbCompany.Text != String.Empty)
                {
                    member = new Robot(ta2.Serial(), tbModel.Text, tbCompany.Text, (Architecture)cbArch.SelectedIndex);
                }
                else
                {
                    MessageBox.Show("Заполните все поля!", "К размышлению", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            this.log_message = member.GetName() + "[id:" + member.ID.ToString() + "] поступает";
            ta2.AddVolunteer(member);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
