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
            this.Hide();
            Info inf = new Info();
            inf.Show();
        }

        private void buttonHelp_AMD_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserGuide_AMD help = new UserGuide_AMD();
            help.Show();
        }
    }
}
