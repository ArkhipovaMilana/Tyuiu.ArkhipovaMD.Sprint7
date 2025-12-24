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
        public void ShowMatrix(string[,] array)
        {
            int row = array.GetLength(0);
            int col = array.GetLength(1);
            dataGridView_AMD.RowCount = row;
            dataGridView_AMD.ColumnCount = col;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    dataGridView_AMD.Rows[i].Cells[j].Value = array[i, j];
                }
            }
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
                if (openFileDialog_AMD.ShowDialog() != DialogResult.OK)
                    return;
                string path = openFileDialog_AMD.FileName;

                string[,] arrayvalues = ds.LoadDataFromFile(path);
                ShowMatrix(arrayvalues);

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
                DataService ds = new DataService();
                saveFileDialog_AMD.RestoreDirectory = true;
                saveFileDialog_AMD.InitialDirectory = Directory.GetCurrentDirectory();

                if (saveFileDialog_AMD.ShowDialog() != DialogResult.OK)
                    return;

                string path = saveFileDialog_AMD.FileName;
                string[,] matrix = GetMatrix();
                string result = ds.SaveData(path, matrix);
                MessageBox.Show($"File : {result}Saved Succsessfully!");
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

                double result = ds.DataStatistics(matrix, action, column-1);

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
                string[,] matrix = GetMatrix();
                string[,] sortedMatrix = ds.SaleSort(matrix, col-1, sort);

                ShowMatrix(sortedMatrix);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonEditAddRow_AMD_Click(object sender, EventArgs e)
        {
            dataGridView_AMD.Rows.Add();
        }

        private void buttonEditDeleteRow_AMD_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dataGridView_AMD.SelectedRows)
            {
                dataGridView_AMD.Rows.Remove(row);
            }
        }
    }

}
