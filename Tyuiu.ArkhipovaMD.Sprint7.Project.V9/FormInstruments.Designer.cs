namespace Tyuiu.ArkhipovaMD.Sprint7.Project.V9
{
    partial class FormInstruments_AMD
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
            components = new System.ComponentModel.Container();
            openFileDialog_AMD = new OpenFileDialog();
            dataGridView_AMD = new DataGridView();
            VideoCode = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Duration = new DataGridViewTextBoxColumn();
            Theme = new DataGridViewTextBoxColumn();
            Cost = new DataGridViewTextBoxColumn();
            saveFileDialog_AMD = new SaveFileDialog();
            panel1 = new Panel();
            tabControl_AMD = new TabControl();
            tabPageFile_AMD = new TabPage();
            buttonSaveFile_AMD = new Button();
            buttonOpenFile_AMD = new Button();
            tabPageMatrix_AMD = new TabPage();
            buttonEditDeleteRow_AMD = new Button();
            buttonEditAddRow_AMD = new Button();
            tabPageOperations_AMD = new TabPage();
            labelSort_AMD = new Label();
            comboBoxSortSort_AMD = new ComboBox();
            comboBoxSortColumn_AMD = new ComboBox();
            buttonSortSort_AMD = new Button();
            textBoxStatisticOutput_AMD = new TextBox();
            labelStatistic_AMD = new Label();
            labelSearch_AMD = new Label();
            textBoxStatisticColumn_AMD = new TextBox();
            comboBoxStatisticAction_AMD = new ComboBox();
            buttonStatisticApply_AMD = new Button();
            textBoxFind_AMD = new TextBox();
            buttonFind_AMD = new Button();
            toolTip_AMD = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView_AMD).BeginInit();
            panel1.SuspendLayout();
            tabControl_AMD.SuspendLayout();
            tabPageFile_AMD.SuspendLayout();
            tabPageMatrix_AMD.SuspendLayout();
            tabPageOperations_AMD.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog_AMD
            // 
            openFileDialog_AMD.FileName = "openFileDialog1";
            // 
            // dataGridView_AMD
            // 
            dataGridView_AMD.AllowUserToAddRows = false;
            dataGridView_AMD.AllowUserToDeleteRows = false;
            dataGridView_AMD.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView_AMD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView_AMD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_AMD.Columns.AddRange(new DataGridViewColumn[] { VideoCode, Date, Duration, Theme, Cost });
            dataGridView_AMD.Location = new Point(0, 81);
            dataGridView_AMD.Name = "dataGridView_AMD";
            dataGridView_AMD.Size = new Size(800, 294);
            dataGridView_AMD.TabIndex = 6;
            // 
            // VideoCode
            // 
            VideoCode.HeaderText = "код видеоленты";
            VideoCode.Name = "VideoCode";
            VideoCode.SortMode = DataGridViewColumnSortMode.NotSortable;
            VideoCode.Width = 91;
            // 
            // Date
            // 
            Date.HeaderText = "дата записи";
            Date.Name = "Date";
            Date.SortMode = DataGridViewColumnSortMode.NotSortable;
            Date.Width = 69;
            // 
            // Duration
            // 
            Duration.HeaderText = "длительность";
            Duration.Name = "Duration";
            Duration.SortMode = DataGridViewColumnSortMode.NotSortable;
            Duration.Width = 88;
            // 
            // Theme
            // 
            Theme.HeaderText = "тема";
            Theme.Name = "Theme";
            Theme.SortMode = DataGridViewColumnSortMode.NotSortable;
            Theme.Width = 39;
            // 
            // Cost
            // 
            Cost.HeaderText = "стоимость";
            Cost.Name = "Cost";
            Cost.SortMode = DataGridViewColumnSortMode.NotSortable;
            Cost.Width = 71;
            // 
            // panel1
            // 
            panel1.Controls.Add(tabControl_AMD);
            panel1.Controls.Add(dataGridView_AMD);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 375);
            panel1.TabIndex = 7;
            // 
            // tabControl_AMD
            // 
            tabControl_AMD.Controls.Add(tabPageFile_AMD);
            tabControl_AMD.Controls.Add(tabPageMatrix_AMD);
            tabControl_AMD.Controls.Add(tabPageOperations_AMD);
            tabControl_AMD.Dock = DockStyle.Top;
            tabControl_AMD.Location = new Point(0, 0);
            tabControl_AMD.Name = "tabControl_AMD";
            tabControl_AMD.SelectedIndex = 0;
            tabControl_AMD.Size = new Size(800, 79);
            tabControl_AMD.TabIndex = 7;
            // 
            // tabPageFile_AMD
            // 
            tabPageFile_AMD.Controls.Add(buttonSaveFile_AMD);
            tabPageFile_AMD.Controls.Add(buttonOpenFile_AMD);
            tabPageFile_AMD.Location = new Point(4, 24);
            tabPageFile_AMD.Name = "tabPageFile_AMD";
            tabPageFile_AMD.Padding = new Padding(3);
            tabPageFile_AMD.Size = new Size(792, 51);
            tabPageFile_AMD.TabIndex = 0;
            tabPageFile_AMD.Text = "File";
            tabPageFile_AMD.UseVisualStyleBackColor = true;
            // 
            // buttonSaveFile_AMD
            // 
            buttonSaveFile_AMD.Location = new Point(102, 15);
            buttonSaveFile_AMD.Name = "buttonSaveFile_AMD";
            buttonSaveFile_AMD.Size = new Size(75, 23);
            buttonSaveFile_AMD.TabIndex = 1;
            buttonSaveFile_AMD.Text = "Save";
            buttonSaveFile_AMD.UseVisualStyleBackColor = true;
            buttonSaveFile_AMD.Click += saveToolStripMenuItem_Click;
            // 
            // buttonOpenFile_AMD
            // 
            buttonOpenFile_AMD.Location = new Point(8, 15);
            buttonOpenFile_AMD.Name = "buttonOpenFile_AMD";
            buttonOpenFile_AMD.Size = new Size(75, 23);
            buttonOpenFile_AMD.TabIndex = 0;
            buttonOpenFile_AMD.Text = "Open";
            buttonOpenFile_AMD.UseVisualStyleBackColor = true;
            buttonOpenFile_AMD.Click += openToolStripMenuItem_Click;
            // 
            // tabPageMatrix_AMD
            // 
            tabPageMatrix_AMD.Controls.Add(buttonEditDeleteRow_AMD);
            tabPageMatrix_AMD.Controls.Add(buttonEditAddRow_AMD);
            tabPageMatrix_AMD.Location = new Point(4, 24);
            tabPageMatrix_AMD.Name = "tabPageMatrix_AMD";
            tabPageMatrix_AMD.Padding = new Padding(3);
            tabPageMatrix_AMD.Size = new Size(792, 51);
            tabPageMatrix_AMD.TabIndex = 2;
            tabPageMatrix_AMD.Text = "Edit";
            tabPageMatrix_AMD.UseVisualStyleBackColor = true;
            // 
            // buttonEditDeleteRow_AMD
            // 
            buttonEditDeleteRow_AMD.Location = new Point(108, 14);
            buttonEditDeleteRow_AMD.Name = "buttonEditDeleteRow_AMD";
            buttonEditDeleteRow_AMD.Size = new Size(75, 23);
            buttonEditDeleteRow_AMD.TabIndex = 1;
            buttonEditDeleteRow_AMD.Text = "Delete row";
            buttonEditDeleteRow_AMD.UseVisualStyleBackColor = true;
            buttonEditDeleteRow_AMD.Click += buttonEditDeleteRow_AMD_Click;
            // 
            // buttonEditAddRow_AMD
            // 
            buttonEditAddRow_AMD.Location = new Point(10, 14);
            buttonEditAddRow_AMD.Name = "buttonEditAddRow_AMD";
            buttonEditAddRow_AMD.Size = new Size(75, 23);
            buttonEditAddRow_AMD.TabIndex = 0;
            buttonEditAddRow_AMD.Text = "Add row";
            buttonEditAddRow_AMD.UseVisualStyleBackColor = true;
            buttonEditAddRow_AMD.Click += buttonEditAddRow_AMD_Click;
            // 
            // tabPageOperations_AMD
            // 
            tabPageOperations_AMD.Controls.Add(labelSort_AMD);
            tabPageOperations_AMD.Controls.Add(comboBoxSortSort_AMD);
            tabPageOperations_AMD.Controls.Add(comboBoxSortColumn_AMD);
            tabPageOperations_AMD.Controls.Add(buttonSortSort_AMD);
            tabPageOperations_AMD.Controls.Add(textBoxStatisticOutput_AMD);
            tabPageOperations_AMD.Controls.Add(labelStatistic_AMD);
            tabPageOperations_AMD.Controls.Add(labelSearch_AMD);
            tabPageOperations_AMD.Controls.Add(textBoxStatisticColumn_AMD);
            tabPageOperations_AMD.Controls.Add(comboBoxStatisticAction_AMD);
            tabPageOperations_AMD.Controls.Add(buttonStatisticApply_AMD);
            tabPageOperations_AMD.Controls.Add(textBoxFind_AMD);
            tabPageOperations_AMD.Controls.Add(buttonFind_AMD);
            tabPageOperations_AMD.Location = new Point(4, 24);
            tabPageOperations_AMD.Name = "tabPageOperations_AMD";
            tabPageOperations_AMD.Padding = new Padding(3);
            tabPageOperations_AMD.Size = new Size(792, 51);
            tabPageOperations_AMD.TabIndex = 1;
            tabPageOperations_AMD.Text = "Operations";
            tabPageOperations_AMD.UseVisualStyleBackColor = true;
            // 
            // labelSort_AMD
            // 
            labelSort_AMD.AutoSize = true;
            labelSort_AMD.Location = new Point(196, 4);
            labelSort_AMD.Name = "labelSort_AMD";
            labelSort_AMD.Size = new Size(34, 15);
            labelSort_AMD.TabIndex = 11;
            labelSort_AMD.Text = "Sort :";
            // 
            // comboBoxSortSort_AMD
            // 
            comboBoxSortSort_AMD.FormattingEnabled = true;
            comboBoxSortSort_AMD.Items.AddRange(new object[] { "ascending", "decreasing" });
            comboBoxSortSort_AMD.Location = new Point(247, 22);
            comboBoxSortSort_AMD.Name = "comboBoxSortSort_AMD";
            comboBoxSortSort_AMD.Size = new Size(62, 23);
            comboBoxSortSort_AMD.TabIndex = 10;
            // 
            // comboBoxSortColumn_AMD
            // 
            comboBoxSortColumn_AMD.FormattingEnabled = true;
            comboBoxSortColumn_AMD.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            comboBoxSortColumn_AMD.Location = new Point(196, 22);
            comboBoxSortColumn_AMD.Name = "comboBoxSortColumn_AMD";
            comboBoxSortColumn_AMD.Size = new Size(45, 23);
            comboBoxSortColumn_AMD.TabIndex = 9;
            // 
            // buttonSortSort_AMD
            // 
            buttonSortSort_AMD.Location = new Point(315, 22);
            buttonSortSort_AMD.Name = "buttonSortSort_AMD";
            buttonSortSort_AMD.Size = new Size(49, 23);
            buttonSortSort_AMD.TabIndex = 8;
            buttonSortSort_AMD.Text = "Sort";
            toolTip_AMD.SetToolTip(buttonSortSort_AMD, "Sorting");
            buttonSortSort_AMD.UseVisualStyleBackColor = true;
            buttonSortSort_AMD.Click += buttonSortSort_AMD_Click;
            // 
            // textBoxStatisticOutput_AMD
            // 
            textBoxStatisticOutput_AMD.Location = new Point(727, 21);
            textBoxStatisticOutput_AMD.Name = "textBoxStatisticOutput_AMD";
            textBoxStatisticOutput_AMD.ReadOnly = true;
            textBoxStatisticOutput_AMD.Size = new Size(57, 23);
            textBoxStatisticOutput_AMD.TabIndex = 7;
            // 
            // labelStatistic_AMD
            // 
            labelStatistic_AMD.AutoSize = true;
            labelStatistic_AMD.Location = new Point(550, 4);
            labelStatistic_AMD.Name = "labelStatistic_AMD";
            labelStatistic_AMD.Size = new Size(54, 15);
            labelStatistic_AMD.TabIndex = 6;
            labelStatistic_AMD.Text = "Statistic :";
            labelStatistic_AMD.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelSearch_AMD
            // 
            labelSearch_AMD.AutoSize = true;
            labelSearch_AMD.Location = new Point(8, 4);
            labelSearch_AMD.Name = "labelSearch_AMD";
            labelSearch_AMD.Size = new Size(48, 15);
            labelSearch_AMD.TabIndex = 5;
            labelSearch_AMD.Text = "Search :";
            // 
            // textBoxStatisticColumn_AMD
            // 
            textBoxStatisticColumn_AMD.Location = new Point(550, 21);
            textBoxStatisticColumn_AMD.Name = "textBoxStatisticColumn_AMD";
            textBoxStatisticColumn_AMD.Size = new Size(41, 23);
            textBoxStatisticColumn_AMD.TabIndex = 4;
            // 
            // comboBoxStatisticAction_AMD
            // 
            comboBoxStatisticAction_AMD.FormattingEnabled = true;
            comboBoxStatisticAction_AMD.Items.AddRange(new object[] { "amo", "sum", "avg", "min", "max" });
            comboBoxStatisticAction_AMD.Location = new Point(597, 21);
            comboBoxStatisticAction_AMD.Name = "comboBoxStatisticAction_AMD";
            comboBoxStatisticAction_AMD.Size = new Size(63, 23);
            comboBoxStatisticAction_AMD.TabIndex = 3;
            // 
            // buttonStatisticApply_AMD
            // 
            buttonStatisticApply_AMD.Location = new Point(666, 21);
            buttonStatisticApply_AMD.Name = "buttonStatisticApply_AMD";
            buttonStatisticApply_AMD.Size = new Size(55, 23);
            buttonStatisticApply_AMD.TabIndex = 2;
            buttonStatisticApply_AMD.Text = "Apply";
            toolTip_AMD.SetToolTip(buttonStatisticApply_AMD, "Some statistic stuff");
            buttonStatisticApply_AMD.UseVisualStyleBackColor = true;
            buttonStatisticApply_AMD.Click += buttonStatisticApply_AMD_Click;
            // 
            // textBoxFind_AMD
            // 
            textBoxFind_AMD.Location = new Point(8, 22);
            textBoxFind_AMD.Name = "textBoxFind_AMD";
            textBoxFind_AMD.Size = new Size(48, 23);
            textBoxFind_AMD.TabIndex = 1;
            // 
            // buttonFind_AMD
            // 
            buttonFind_AMD.Location = new Point(62, 21);
            buttonFind_AMD.Name = "buttonFind_AMD";
            buttonFind_AMD.Size = new Size(49, 23);
            buttonFind_AMD.TabIndex = 0;
            buttonFind_AMD.Text = "Find";
            toolTip_AMD.SetToolTip(buttonFind_AMD, "Find a value");
            buttonFind_AMD.UseVisualStyleBackColor = true;
            buttonFind_AMD.Click += buttonFind_AMD_Click;
            // 
            // FormInstruments_AMD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 375);
            Controls.Add(panel1);
            Name = "FormInstruments_AMD";
            Text = "Instruments";
            ((System.ComponentModel.ISupportInitialize)dataGridView_AMD).EndInit();
            panel1.ResumeLayout(false);
            tabControl_AMD.ResumeLayout(false);
            tabPageFile_AMD.ResumeLayout(false);
            tabPageMatrix_AMD.ResumeLayout(false);
            tabPageOperations_AMD.ResumeLayout(false);
            tabPageOperations_AMD.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private OpenFileDialog openFileDialog_AMD;
        private DataGridView dataGridView_AMD;
        private SaveFileDialog saveFileDialog_AMD;
        private Panel panel1;
        private TabControl tabControl_AMD;
        private TabPage tabPageFile_AMD;
        private Button buttonSaveFile_AMD;
        private Button buttonOpenFile_AMD;
        private TabPage tabPageOperations_AMD;
        private Button buttonStatisticApply_AMD;
        private TextBox textBoxFind_AMD;
        private Button buttonFind_AMD;
        private ComboBox comboBoxStatisticAction_AMD;
        private TextBox textBoxStatisticColumn_AMD;
        private Label labelSearch_AMD;
        private Label labelStatistic_AMD;
        private TextBox textBoxStatisticOutput_AMD;
        private ToolTip toolTip_AMD;
        private ComboBox comboBoxSortSort_AMD;
        private ComboBox comboBoxSortColumn_AMD;
        private Button buttonSortSort_AMD;
        private Label labelSort_AMD;
        private TabPage tabPageMatrix_AMD;
        private Button buttonEditDeleteRow_AMD;
        private Button buttonEditAddRow_AMD;
        private DataGridViewTextBoxColumn VideoCode;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Duration;
        private DataGridViewTextBoxColumn Theme;
        private DataGridViewTextBoxColumn Cost;
    }
}