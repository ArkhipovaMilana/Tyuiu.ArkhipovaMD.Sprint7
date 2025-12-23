using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.ArkhipovaMD.Sprint7.Project.V9
{
    public partial class FormMain_AMD : Form
    {
        public FormMain_AMD()
        {
            InitializeComponent();
        }

        private void buttonVideo_AMD_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormVideo_AMD formVieo = new FormVideo_AMD();
            formVieo.Show();
        }

        private void buttonInfo_AMD_Click(object sender, EventArgs e)
        {
            FormInfo_AMD inf = new FormInfo_AMD();
            inf.Show();
        }

        private void buttonHelp_AMD_Click(object sender, EventArgs e)
        {
            FormUserGuide_AMD help = new FormUserGuide_AMD();
            help.Show();
        }

        private void buttonInstrument_AMD_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormInstruments_AMD instruments = new FormInstruments_AMD();
            instruments.Show();
        }
    }
}
