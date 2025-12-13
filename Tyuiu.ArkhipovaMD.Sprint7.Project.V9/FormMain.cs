using AxWMPLib;
using System.Xml;

namespace Tyuiu.ArkhipovaMD.Sprint7.Project.V9
{
    public partial class FormMain_AMD : Form
    {
        public FormMain_AMD()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_AMD_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Видео файлы|*.mp4;*.avi;*.wmv;*.mov;*.mkv|" +
                                    "Все файлы|*.*";
            openFileDialog.Title = "Выберите видеофайл";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (windowsMediaPlayer_AMD.playState == WMPLib.WMPPlayState.wmppsPlaying)
                    {
                        windowsMediaPlayer_AMD.Ctlcontrols.stop();
                    }

                    windowsMediaPlayer_AMD.URL = openFileDialog.FileName;

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при открытии файла: {ex.Message}",
                                  "Ошибка",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
                }
            }
        }
    }
}
