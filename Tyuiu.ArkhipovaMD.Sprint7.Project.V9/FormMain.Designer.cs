namespace Tyuiu.ArkhipovaMD.Sprint7.Project.V9
{
    partial class FormMain_AMD
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_AMD));
            menuStrip_AMD = new MenuStrip();
            openToolStripMenuItem_AMD = new ToolStripMenuItem();
            changeToolStripMenuItem_AMD = new ToolStripMenuItem();
            settingsToolStripMenuItem_AMD = new ToolStripMenuItem();
            infoToolStripMenuItem_AMD = new ToolStripMenuItem();
            helpToolStripMenuItem_AMD = new ToolStripMenuItem();
            windowsMediaPlayer_AMD = new AxWMPLib.AxWindowsMediaPlayer();
            fileInfoGrid_AMD = new DataGridView();
            openFileDialog_AMD = new OpenFileDialog();
            menuStrip_AMD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)windowsMediaPlayer_AMD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileInfoGrid_AMD).BeginInit();
            SuspendLayout();
            // 
            // menuStrip_AMD
            // 
            menuStrip_AMD.Items.AddRange(new ToolStripItem[] { openToolStripMenuItem_AMD, changeToolStripMenuItem_AMD, settingsToolStripMenuItem_AMD, infoToolStripMenuItem_AMD, helpToolStripMenuItem_AMD });
            menuStrip_AMD.Location = new Point(0, 0);
            menuStrip_AMD.Name = "menuStrip_AMD";
            menuStrip_AMD.Size = new Size(993, 24);
            menuStrip_AMD.TabIndex = 0;
            menuStrip_AMD.Text = "menuStrip1";
            // 
            // openToolStripMenuItem_AMD
            // 
            openToolStripMenuItem_AMD.Name = "openToolStripMenuItem_AMD";
            openToolStripMenuItem_AMD.Size = new Size(78, 20);
            openToolStripMenuItem_AMD.Text = "open video";
            openToolStripMenuItem_AMD.Click += openToolStripMenuItem_AMD_Click;
            // 
            // changeToolStripMenuItem_AMD
            // 
            changeToolStripMenuItem_AMD.Name = "changeToolStripMenuItem_AMD";
            changeToolStripMenuItem_AMD.Size = new Size(124, 20);
            changeToolStripMenuItem_AMD.Text = "change information";
            // 
            // settingsToolStripMenuItem_AMD
            // 
            settingsToolStripMenuItem_AMD.Name = "settingsToolStripMenuItem_AMD";
            settingsToolStripMenuItem_AMD.Size = new Size(60, 20);
            settingsToolStripMenuItem_AMD.Text = "settings";
            // 
            // infoToolStripMenuItem_AMD
            // 
            infoToolStripMenuItem_AMD.Name = "infoToolStripMenuItem_AMD";
            infoToolStripMenuItem_AMD.Size = new Size(40, 20);
            infoToolStripMenuItem_AMD.Text = "info";
            // 
            // helpToolStripMenuItem_AMD
            // 
            helpToolStripMenuItem_AMD.Name = "helpToolStripMenuItem_AMD";
            helpToolStripMenuItem_AMD.Size = new Size(42, 20);
            helpToolStripMenuItem_AMD.Text = "help";
            // 
            // windowsMediaPlayer_AMD
            // 
            windowsMediaPlayer_AMD.Dock = DockStyle.Left;
            windowsMediaPlayer_AMD.Enabled = true;
            windowsMediaPlayer_AMD.Location = new Point(0, 24);
            windowsMediaPlayer_AMD.Name = "windowsMediaPlayer_AMD";
            windowsMediaPlayer_AMD.OcxState = (AxHost.State)resources.GetObject("windowsMediaPlayer_AMD.OcxState");
            windowsMediaPlayer_AMD.Size = new Size(763, 426);
            windowsMediaPlayer_AMD.TabIndex = 1;
            // 
            // fileInfoGrid_AMD
            // 
            fileInfoGrid_AMD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            fileInfoGrid_AMD.Dock = DockStyle.Right;
            fileInfoGrid_AMD.Location = new Point(769, 24);
            fileInfoGrid_AMD.Name = "fileInfoGrid_AMD";
            fileInfoGrid_AMD.Size = new Size(224, 426);
            fileInfoGrid_AMD.TabIndex = 2;
            // 
            // openFileDialog_AMD
            // 
            openFileDialog_AMD.FileName = "openFileDialog1";
            // 
            // FormMain_AMD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(993, 450);
            Controls.Add(fileInfoGrid_AMD);
            Controls.Add(windowsMediaPlayer_AMD);
            Controls.Add(menuStrip_AMD);
            MainMenuStrip = menuStrip_AMD;
            Name = "FormMain_AMD";
            Text = "Video Player";
            menuStrip_AMD.ResumeLayout(false);
            menuStrip_AMD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)windowsMediaPlayer_AMD).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileInfoGrid_AMD).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip_AMD;
        private ToolStripMenuItem openToolStripMenuItem_AMD;
        private ToolStripMenuItem changeToolStripMenuItem_AMD;
        private ToolStripMenuItem settingsToolStripMenuItem_AMD;
        private ToolStripMenuItem infoToolStripMenuItem_AMD;
        private ToolStripMenuItem helpToolStripMenuItem_AMD;
        private AxWMPLib.AxWindowsMediaPlayer windowsMediaPlayer_AMD;
        private DataGridView fileInfoGrid_AMD;
        private OpenFileDialog openFileDialog_AMD;
    }
}
