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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_AMD));
            panel1 = new Panel();
            textBox1 = new TextBox();
            buttonHelp_AMD = new Button();
            buttonVideo_AMD = new Button();
            buttonInfo_AMD = new Button();
            buttonInstrument_AMD = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(buttonHelp_AMD);
            panel1.Controls.Add(buttonVideo_AMD);
            panel1.Controls.Add(buttonInfo_AMD);
            panel1.Controls.Add(buttonInstrument_AMD);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(224, 339);
            panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(199, 16);
            textBox1.TabIndex = 6;
            textBox1.Text = "Sprint 7 Project Application";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonHelp_AMD
            // 
            buttonHelp_AMD.Location = new Point(99, 277);
            buttonHelp_AMD.Name = "buttonHelp_AMD";
            buttonHelp_AMD.Size = new Size(112, 54);
            buttonHelp_AMD.TabIndex = 5;
            buttonHelp_AMD.Text = "Help";
            buttonHelp_AMD.UseVisualStyleBackColor = true;
            buttonHelp_AMD.Click += buttonHelp_AMD_Click;
            // 
            // buttonVideo_AMD
            // 
            buttonVideo_AMD.Location = new Point(12, 214);
            buttonVideo_AMD.Name = "buttonVideo_AMD";
            buttonVideo_AMD.Size = new Size(199, 57);
            buttonVideo_AMD.TabIndex = 4;
            buttonVideo_AMD.Text = "Video Player";
            buttonVideo_AMD.UseVisualStyleBackColor = true;
            buttonVideo_AMD.Click += buttonVideo_AMD_Click;
            // 
            // buttonInfo_AMD
            // 
            buttonInfo_AMD.Location = new Point(12, 277);
            buttonInfo_AMD.Name = "buttonInfo_AMD";
            buttonInfo_AMD.Size = new Size(81, 54);
            buttonInfo_AMD.TabIndex = 3;
            buttonInfo_AMD.Text = "Info";
            buttonInfo_AMD.UseVisualStyleBackColor = true;
            buttonInfo_AMD.Click += buttonInfo_AMD_Click;
            // 
            // buttonInstrument_AMD
            // 
            buttonInstrument_AMD.Location = new Point(12, 151);
            buttonInstrument_AMD.Name = "buttonInstrument_AMD";
            buttonInstrument_AMD.Size = new Size(199, 57);
            buttonInstrument_AMD.TabIndex = 0;
            buttonInstrument_AMD.Text = "Instruments";
            buttonInstrument_AMD.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(224, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(128, 339);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 339);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FormMain_AMD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 339);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormMain_AMD";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Project App";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonHelp_AMD;
        private Button buttonVideo_AMD;
        private Button buttonInfo_AMD;
        private Button buttonInstrument_AMD;
        private Panel panel2;
        private PictureBox pictureBox1;
        private TextBox textBox1;
    }
}