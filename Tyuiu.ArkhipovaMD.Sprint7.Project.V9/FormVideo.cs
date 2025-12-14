using AxWMPLib;
using System.Xml;
using Tyuiu.ArkhipovaMD.Sprint7.Project.V9.Properties;

namespace Tyuiu.ArkhipovaMD.Sprint7.Project.V9
{
    public partial class FormVideo_AMD : Form
    {
        public FormVideo_AMD()
        {
            InitializeComponent();
        }
        private void openToolStripMenuItem_AMD_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Video files|*.mp4;*.avi;*.wmv;*.mov;*.mkv|" + "All files|*.*";
            openFileDialog.Title = "Choose file";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (WMP_AMD.playState == WMPLib.WMPPlayState.wmppsPlaying)
                    {
                        WMP_AMD.Ctlcontrols.stop();
                    }
                    string path = openFileDialog.FileName;
                    WMP_AMD.URL = path;
                    WMP_AMD.Ctlcontrols.play();
                    this.Text = "Media - " + Path.GetFileName(path);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                FormMain_AMD formMain_AMD = new FormMain_AMD();
                formMain_AMD.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonBack_AMD_Click(object sender, EventArgs e)
        {
            try
            {
                if (WMP_AMD.currentMedia != null)
                {
                    double currentPosition = WMP_AMD.Ctlcontrols.currentPosition;
                    double newPosition = currentPosition - 5;
                    if (newPosition < 0)
                    {
                        newPosition = 0;
                    }
                    WMP_AMD.Ctlcontrols.currentPosition = newPosition;
                }
                else
                {
                    MessageBox.Show("Сначала откройте видеофайл!", "Информация",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonForward_AMD_Click(object sender, EventArgs e)
        {
            try
            {
                if (WMP_AMD.currentMedia != null)
                {
                    double currentPosition = WMP_AMD.Ctlcontrols.currentPosition;
                    double duration = WMP_AMD.currentMedia.duration;
                    double newPosition = currentPosition + 5;
                    if (newPosition > duration)
                    { 
                        newPosition = duration;
                    }
                    WMP_AMD.Ctlcontrols.currentPosition = newPosition;
                }
                else
                {
                    MessageBox.Show("Сначала откройте видеофайл!", "Информация",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonPlay_AMD_Click(object sender, EventArgs e)
        {
            try
            {
                if (WMP_AMD.currentMedia != null)
                {
                    WMP_AMD.Ctlcontrols.play();
                    buttonPlay_AMD.Hide();
                    buttonStop_AMD.Visible = true;
                }
                else
                {
                    MessageBox.Show("Сначала откройте видеофайл!", "Информация",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonStop_AMD_Click(object sender, EventArgs e)
        {
            try
            {
                if (WMP_AMD.currentMedia != null)
                {
                    WMP_AMD.Ctlcontrols.pause();
                    buttonStop_AMD.Hide();
                    buttonPlay_AMD.Visible = true;
                }
                else
                {
                    MessageBox.Show("Сначала откройте видеофайл!", "Информация",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
