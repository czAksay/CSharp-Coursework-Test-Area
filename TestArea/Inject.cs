using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestAreaNS
{
    enum InjectColor { Red, White, Black};
    partial class Inject : Form
    {
        private InjectColor selected_color;
        public InjectColor SelectedColor {  get { return selected_color; } }
        public Inject()
        {
            InitializeComponent();
        }

        private void btnInject_Click(object sender, EventArgs e)
        {
            if (rbBlack.Checked)
                selected_color = InjectColor.Black;
            else if (rbRed.Checked)
                selected_color = InjectColor.Red;
            else if (rbWhite.Checked)
                selected_color = InjectColor.White;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
