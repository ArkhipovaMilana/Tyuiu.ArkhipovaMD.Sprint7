namespace Tyuiu.ArkhipovaMD.Sprint7.Project.V9
{
    partial class FormUserGuide_AMD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUserGuide_AMD));
            richTextBoxUserGuide_AMD = new RichTextBox();
            SuspendLayout();
            // 
            // richTextBoxUserGuide_AMD
            // 
            richTextBoxUserGuide_AMD.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBoxUserGuide_AMD.Location = new Point(12, 12);
            richTextBoxUserGuide_AMD.Name = "richTextBoxUserGuide_AMD";
            richTextBoxUserGuide_AMD.ReadOnly = true;
            richTextBoxUserGuide_AMD.Size = new Size(380, 290);
            richTextBoxUserGuide_AMD.TabIndex = 0;
            richTextBoxUserGuide_AMD.Text = resources.GetString("richTextBoxUserGuide_AMD.Text");
            // 
            // FormUserGuide_AMD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 315);
            Controls.Add(richTextBoxUserGuide_AMD);
            Name = "FormUserGuide_AMD";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User Guide";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBoxUserGuide_AMD;
    }
}