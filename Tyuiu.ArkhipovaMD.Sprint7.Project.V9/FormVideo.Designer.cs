namespace Tyuiu.ArkhipovaMD.Sprint7.Project.V9
{
    partial class FormVideo_AMD
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVideo_AMD));
            menuStrip_AMD = new MenuStrip();
            openToolStripMenuItem_AMD = new ToolStripMenuItem();
            returnToolStripMenuItem = new ToolStripMenuItem();
            WMP_AMD = new AxWMPLib.AxWindowsMediaPlayer();
            openFileDialog_AMD = new OpenFileDialog();
            toolTip_AMD = new ToolTip(components);
            panel1 = new Panel();
            buttonStop_AMD = new Button();
            buttonPlay_AMD = new Button();
            buttonForward_AMD = new Button();
            buttonBack_AMD = new Button();
            menuStrip_AMD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)WMP_AMD).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip_AMD
            // 
            menuStrip_AMD.Items.AddRange(new ToolStripItem[] { openToolStripMenuItem_AMD, returnToolStripMenuItem });
            menuStrip_AMD.Location = new Point(0, 0);
            menuStrip_AMD.Name = "menuStrip_AMD";
            menuStrip_AMD.Size = new Size(635, 24);
            menuStrip_AMD.TabIndex = 0;
            menuStrip_AMD.Text = "menuStrip1";
            // 
            // openToolStripMenuItem_AMD
            // 
            openToolStripMenuItem_AMD.Name = "openToolStripMenuItem_AMD";
            openToolStripMenuItem_AMD.Size = new Size(48, 20);
            openToolStripMenuItem_AMD.Text = "Open";
            openToolStripMenuItem_AMD.ToolTipText = "Open video file";
            openToolStripMenuItem_AMD.Click += openToolStripMenuItem_AMD_Click;
            // 
            // returnToolStripMenuItem
            // 
            returnToolStripMenuItem.Name = "returnToolStripMenuItem";
            returnToolStripMenuItem.Size = new Size(54, 20);
            returnToolStripMenuItem.Text = "Return";
            returnToolStripMenuItem.ToolTipText = "Return to menu";
            returnToolStripMenuItem.Click += returnToolStripMenuItem_Click;
            // 
            // WMP_AMD
            // 
            WMP_AMD.Dock = DockStyle.Fill;
            WMP_AMD.Enabled = true;
            WMP_AMD.Location = new Point(0, 24);
            WMP_AMD.Name = "WMP_AMD";
            WMP_AMD.OcxState = (AxHost.State)resources.GetObject("WMP_AMD.OcxState");
            WMP_AMD.Size = new Size(635, 455);
            WMP_AMD.TabIndex = 1;
            // 
            // openFileDialog_AMD
            // 
            openFileDialog_AMD.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonStop_AMD);
            panel1.Controls.Add(buttonPlay_AMD);
            panel1.Controls.Add(buttonForward_AMD);
            panel1.Controls.Add(buttonBack_AMD);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 416);
            panel1.Name = "panel1";
            panel1.Size = new Size(635, 63);
            panel1.TabIndex = 2;
            // 
            // buttonStop_AMD
            // 
            buttonStop_AMD.BackgroundImageLayout = ImageLayout.None;
            buttonStop_AMD.FlatStyle = FlatStyle.Popup;
            buttonStop_AMD.Image = Properties.Resources.control_stop_blue;
            buttonStop_AMD.Location = new Point(268, 3);
            buttonStop_AMD.Name = "buttonStop_AMD";
            buttonStop_AMD.Size = new Size(55, 55);
            buttonStop_AMD.TabIndex = 4;
            buttonStop_AMD.Text = " ";
            buttonStop_AMD.TextImageRelation = TextImageRelation.TextAboveImage;
            buttonStop_AMD.UseVisualStyleBackColor = true;
            buttonStop_AMD.Click += buttonStop_AMD_Click;
            // 
            // buttonPlay_AMD
            // 
            buttonPlay_AMD.BackgroundImageLayout = ImageLayout.None;
            buttonPlay_AMD.FlatStyle = FlatStyle.Popup;
            buttonPlay_AMD.Image = Properties.Resources.control_play_blue;
            buttonPlay_AMD.Location = new Point(268, 3);
            buttonPlay_AMD.Name = "buttonPlay_AMD";
            buttonPlay_AMD.Size = new Size(55, 55);
            buttonPlay_AMD.TabIndex = 3;
            buttonPlay_AMD.Text = " ";
            buttonPlay_AMD.TextImageRelation = TextImageRelation.TextAboveImage;
            buttonPlay_AMD.UseVisualStyleBackColor = true;
            buttonPlay_AMD.Click += buttonPlay_AMD_Click;
            // 
            // buttonForward_AMD
            // 
            buttonForward_AMD.BackgroundImageLayout = ImageLayout.None;
            buttonForward_AMD.FlatStyle = FlatStyle.Popup;
            buttonForward_AMD.Image = (Image)resources.GetObject("buttonForward_AMD.Image");
            buttonForward_AMD.Location = new Point(329, 3);
            buttonForward_AMD.Name = "buttonForward_AMD";
            buttonForward_AMD.Size = new Size(55, 55);
            buttonForward_AMD.TabIndex = 2;
            buttonForward_AMD.Text = " ";
            buttonForward_AMD.TextImageRelation = TextImageRelation.TextAboveImage;
            buttonForward_AMD.UseVisualStyleBackColor = true;
            buttonForward_AMD.Click += buttonForward_AMD_Click;
            // 
            // buttonBack_AMD
            // 
            buttonBack_AMD.BackgroundImageLayout = ImageLayout.None;
            buttonBack_AMD.FlatStyle = FlatStyle.Popup;
            buttonBack_AMD.Image = (Image)resources.GetObject("buttonBack_AMD.Image");
            buttonBack_AMD.Location = new Point(207, 3);
            buttonBack_AMD.Name = "buttonBack_AMD";
            buttonBack_AMD.Size = new Size(55, 55);
            buttonBack_AMD.TabIndex = 1;
            buttonBack_AMD.Text = " ";
            buttonBack_AMD.TextImageRelation = TextImageRelation.TextAboveImage;
            buttonBack_AMD.UseVisualStyleBackColor = true;
            buttonBack_AMD.Click += buttonBack_AMD_Click;
            // 
            // FormVideo_AMD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 479);
            Controls.Add(panel1);
            Controls.Add(WMP_AMD);
            Controls.Add(menuStrip_AMD);
            MainMenuStrip = menuStrip_AMD;
            Name = "FormVideo_AMD";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Video Player";
            menuStrip_AMD.ResumeLayout(false);
            menuStrip_AMD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)WMP_AMD).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip_AMD;
        private ToolStripMenuItem openToolStripMenuItem_AMD;
        private AxWMPLib.AxWindowsMediaPlayer WMP_AMD;
        private OpenFileDialog openFileDialog_AMD;
        private ToolStripMenuItem returnToolStripMenuItem;
        private ToolTip toolTip_AMD;
        private Panel panel1;
        private Button buttonForward_AMD;
        private Button buttonBack_AMD;
        private Button buttonPlay_AMD;
        private Button buttonStop_AMD;
    }
}
