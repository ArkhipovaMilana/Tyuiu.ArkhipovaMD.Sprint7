using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Tyuiu.ArkhipovaMD.Sprint7.Project.V9.Lib;
namespace Tyuiu.ArkhipovaMD.Sprint7.Project.V9
{
    public partial class FormInstruments_AMD : Form
    {
        public string[,] GetMatrix()
        {
            int row = dataGridView_AMD.RowCount;
            int col = dataGridView_AMD.ColumnCount;

            string[,] array = new string[row, col];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    array[i, j] = Convert.ToString(dataGridView_AMD.Rows[i].Cells[j].Value);
                }
            }
            return array;
        }
        public string LoadMatrix()
        {
            int rowCount = dataGridView_AMD.RowCount;
            int colCount = dataGridView_AMD.ColumnCount;

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < rowCount; i++)
            {
                if (dataGridView_AMD.Rows[i].IsNewRow)
                    continue;

                for (int j = 0; j < colCount; j++)
                {
                    object cellValue = dataGridView_AMD.Rows[i].Cells[j].Value;
                    string value = cellValue == null ? "" : cellValue.ToString();

                    sb.Append(value);

                    if (j < colCount - 1)
                        sb.Append(';');
                }

                sb.AppendLine();
            }
            return sb.ToString();
        }
        public FormInstruments_AMD()
        {
            InitializeComponent();
            saveFileDialog_AMD.Filter = "Значения разделённые точкой с запятой (*.csv)|*.csv|Все файлы (*.*)|*.*";
            openFileDialog_AMD.Filter = "Значения разделённые точкой с запятой (*.csv)|*.csv|Все файлы (*.*)|*.*";
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                if (openFileDialog_AMD.ShowDialog() == DialogResult.OK)
                {
                    string path = openFileDialog_AMD.FileName;

                    string[,] arrayvalues = ds.LoadDataFromFile(path);
                    int row = arrayvalues.GetLength(0);
                    int col = arrayvalues.GetLength(1);
                    dataGridView_AMD.RowCount = row;
                    dataGridView_AMD.ColumnCount = col;
                    for (int i = 0; i < row; i++)
                    {
                        for (int j = 0; j < col; j++)
                        {
                            dataGridView_AMD.Rows[i].Cells[j].Value = arrayvalues[i, j];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog_AMD.RestoreDirectory = true;
                saveFileDialog_AMD.InitialDirectory = Directory.GetCurrentDirectory();

                if (saveFileDialog_AMD.ShowDialog() != DialogResult.OK)
                    return;

                string path = saveFileDialog_AMD.FileName;
                string data = LoadMatrix();

                File.WriteAllText(path, data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonFind_AMD_Click(object sender, EventArgs e)
        {
            try
            {
                string searchText = textBoxFind_AMD.Text;

                if (string.IsNullOrWhiteSpace(searchText))
                {
                    foreach (DataGridViewRow row in dataGridView_AMD.Rows)
                    {
                        if (!row.IsNewRow)
                            row.Visible = true;
                    }
                    return;
                }

                searchText = searchText.ToLower();

                foreach (DataGridViewRow row in dataGridView_AMD.Rows)
                {
                    if (row.IsNewRow)
                        continue;

                    bool found = false;

                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value == null)
                            continue;

                        string cellText = cell.Value.ToString().ToLower();

                        if (cellText.Contains(searchText))
                        {
                            found = true;
                            break;
                        }
                    }

                    row.Visible = found;
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void buttonStatisticApply_AMD_Click(object sender, EventArgs e)
        {
            try
            {
                DataService ds = new DataService();
                string action = Convert.ToString(comboBoxStatisticAction_AMD.Text);
                int column = Convert.ToInt32(textBoxStatisticColumn_AMD.Text);

                string[,] matrix = GetMatrix();

                double result = ds.DataStatistics(matrix, action, column);

                textBoxStatisticOutput_AMD.Text = Convert.ToString(result);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void buttonSortSort_AMD_Click(object sender, EventArgs e)
        {
            
            try
            {
                DataService ds = new DataService();
                int col = Convert.ToInt32(comboBoxSortColumn_AMD.Text);
                string sort = Convert.ToString(comboBoxSortSort_AMD.Text);
                string[,] matrix= GetMatrix();
                string[,] array = ds.SaleSort(matrix,col,sort);

                for (int r = 0; r < matrix.GetLength(0); r++)
                {
                    for (int c = 0; c < matrix.GetLength(1); c++)
                    {
                        dataGridView_AMD.Rows[r].Cells[c].Value = array[r, c];
                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }

}
