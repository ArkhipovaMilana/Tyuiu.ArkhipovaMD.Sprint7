namespace Tyuiu.ArkhipovaMD.Sprint7.Project.V9
{
    partial class Instruments_AMD
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
            menuStrip_AMD = new MenuStrip();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            returnToolStripMenuItem = new ToolStripMenuItem();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            findToolStripMenuItem = new ToolStripMenuItem();
            filterToolStripMenuItem = new ToolStripMenuItem();
            chartToolStripMenuItem = new ToolStripMenuItem();
            openFileDialog_AMD = new OpenFileDialog();
            dataGridView_AMD = new DataGridView();
            saveFileDialog_AMD = new SaveFileDialog();
            panel1 = new Panel();
            menuStrip_AMD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_AMD).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip_AMD
            // 
            menuStrip_AMD.Items.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem, toolsToolStripMenuItem, returnToolStripMenuItem });
            menuStrip_AMD.Location = new Point(0, 0);
            menuStrip_AMD.Name = "menuStrip_AMD";
            menuStrip_AMD.Size = new Size(800, 24);
            menuStrip_AMD.TabIndex = 5;
            menuStrip_AMD.Text = "menuStrip1";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(48, 20);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(43, 20);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // returnToolStripMenuItem
            // 
            returnToolStripMenuItem.Name = "returnToolStripMenuItem";
            returnToolStripMenuItem.Size = new Size(54, 20);
            returnToolStripMenuItem.Text = "Return";
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { findToolStripMenuItem, filterToolStripMenuItem, chartToolStripMenuItem });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new Size(46, 20);
            toolsToolStripMenuItem.Text = "Tools";
            // 
            // findToolStripMenuItem
            // 
            findToolStripMenuItem.Name = "findToolStripMenuItem";
            findToolStripMenuItem.Size = new Size(180, 22);
            findToolStripMenuItem.Text = "Find";
            // 
            // filterToolStripMenuItem
            // 
            filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            filterToolStripMenuItem.Size = new Size(180, 22);
            filterToolStripMenuItem.Text = "Filter";
            // 
            // chartToolStripMenuItem
            // 
            chartToolStripMenuItem.Name = "chartToolStripMenuItem";
            chartToolStripMenuItem.Size = new Size(180, 22);
            chartToolStripMenuItem.Text = "Chart";
            // 
            // openFileDialog_AMD
            // 
            openFileDialog_AMD.FileName = "openFileDialog1";
            // 
            // dataGridView_AMD
            // 
            dataGridView_AMD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_AMD.Location = new Point(12, 27);
            dataGridView_AMD.Name = "dataGridView_AMD";
            dataGridView_AMD.Size = new Size(776, 336);
            dataGridView_AMD.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView_AMD);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 375);
            panel1.TabIndex = 7;
            // 
            // Instruments_AMD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 375);
            Controls.Add(menuStrip_AMD);
            Controls.Add(panel1);
            MainMenuStrip = menuStrip_AMD;
            Name = "Instruments_AMD";
            Text = "Instruments";
            menuStrip_AMD.ResumeLayout(false);
            menuStrip_AMD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_AMD).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip_AMD;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem returnToolStripMenuItem;
        private OpenFileDialog openFileDialog_AMD;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem findToolStripMenuItem;
        private ToolStripMenuItem filterToolStripMenuItem;
        private ToolStripMenuItem chartToolStripMenuItem;
        private DataGridView dataGridView_AMD;
        private SaveFileDialog saveFileDialog_AMD;
        private Panel panel1;
    }
}