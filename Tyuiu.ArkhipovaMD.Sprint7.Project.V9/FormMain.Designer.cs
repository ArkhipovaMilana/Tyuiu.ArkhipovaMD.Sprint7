namespace Tyuiu.ArkhipovaMD.Sprint7.Project.V9
{
    partial class FormMain_AMD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelMain_AMD = new Panel();
            labelMain_AMD = new Label();
            buttonHelp_AMD = new Button();
            buttonVideo_AMD = new Button();
            buttonInfo_AMD = new Button();
            buttonInstrument_AMD = new Button();
            panel2 = new Panel();
            pictureBoxMain_AMD = new PictureBox();
            panelMain_AMD.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMain_AMD).BeginInit();
            SuspendLayout();
            // 
            // panelMain_AMD
            // 
            panelMain_AMD.Controls.Add(labelMain_AMD);
            panelMain_AMD.Controls.Add(buttonHelp_AMD);
            panelMain_AMD.Controls.Add(buttonVideo_AMD);
            panelMain_AMD.Controls.Add(buttonInfo_AMD);
            panelMain_AMD.Controls.Add(buttonInstrument_AMD);
            panelMain_AMD.Dock = DockStyle.Left;
            panelMain_AMD.Location = new Point(0, 0);
            panelMain_AMD.Name = "panelMain_AMD";
            panelMain_AMD.Size = new Size(224, 250);
            panelMain_AMD.TabIndex = 0;
            // 
            // labelMain_AMD
            // 
            labelMain_AMD.AutoSize = true;
            labelMain_AMD.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelMain_AMD.Location = new Point(32, 18);
            labelMain_AMD.Name = "labelMain_AMD";
            labelMain_AMD.Size = new Size(159, 15);
            labelMain_AMD.TabIndex = 7;
            labelMain_AMD.Text = "Sprint 7 Project Application";
            // 
            // buttonHelp_AMD
            // 
            buttonHelp_AMD.Location = new Point(99, 170);
            buttonHelp_AMD.Name = "buttonHelp_AMD";
            buttonHelp_AMD.Size = new Size(112, 54);
            buttonHelp_AMD.TabIndex = 5;
            buttonHelp_AMD.Text = "Help";
            buttonHelp_AMD.UseVisualStyleBackColor = true;
            buttonHelp_AMD.Click += buttonHelp_AMD_Click;
            // 
            // buttonVideo_AMD
            // 
            buttonVideo_AMD.Location = new Point(12, 107);
            buttonVideo_AMD.Name = "buttonVideo_AMD";
            buttonVideo_AMD.Size = new Size(199, 57);
            buttonVideo_AMD.TabIndex = 4;
            buttonVideo_AMD.Text = "Video Player";
            buttonVideo_AMD.UseVisualStyleBackColor = true;
            buttonVideo_AMD.Click += buttonVideo_AMD_Click;
            // 
            // buttonInfo_AMD
            // 
            buttonInfo_AMD.Location = new Point(12, 170);
            buttonInfo_AMD.Name = "buttonInfo_AMD";
            buttonInfo_AMD.Size = new Size(81, 54);
            buttonInfo_AMD.TabIndex = 3;
            buttonInfo_AMD.Text = "Info";
            buttonInfo_AMD.UseVisualStyleBackColor = true;
            buttonInfo_AMD.Click += buttonInfo_AMD_Click;
            // 
            // buttonInstrument_AMD
            // 
            buttonInstrument_AMD.Location = new Point(12, 44);
            buttonInstrument_AMD.Name = "buttonInstrument_AMD";
            buttonInstrument_AMD.Size = new Size(199, 57);
            buttonInstrument_AMD.TabIndex = 0;
            buttonInstrument_AMD.Text = "Instruments";
            buttonInstrument_AMD.UseVisualStyleBackColor = true;
            buttonInstrument_AMD.Click += buttonInstrument_AMD_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBoxMain_AMD);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(224, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(92, 250);
            panel2.TabIndex = 1;
            // 
            // pictureBoxMain_AMD
            // 
            pictureBoxMain_AMD.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxMain_AMD.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxMain_AMD.Image = Properties.Resources.i;
            pictureBoxMain_AMD.Location = new Point(0, 0);
            pictureBoxMain_AMD.Name = "pictureBoxMain_AMD";
            pictureBoxMain_AMD.Size = new Size(1202, 802);
            pictureBoxMain_AMD.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxMain_AMD.TabIndex = 0;
            pictureBoxMain_AMD.TabStop = false;
            // 
            // FormMain_AMD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(316, 250);
            Controls.Add(panel2);
            Controls.Add(panelMain_AMD);
            Name = "FormMain_AMD";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Project App";
            panelMain_AMD.ResumeLayout(false);
            panelMain_AMD.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxMain_AMD).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain_AMD;
        private Button buttonHelp_AMD;
        private Button buttonVideo_AMD;
        private Button buttonInfo_AMD;
        private Button buttonInstrument_AMD;
        private Panel panel2;
        private PictureBox pictureBoxMain_AMD;
        private Label labelMain_AMD;
    }
}