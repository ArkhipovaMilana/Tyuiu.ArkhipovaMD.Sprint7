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
    public partial class Instruments_AMD : Form
    {
        public Instruments_AMD()
        {
            InitializeComponent();
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog_AMD.Filter = "Значения разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            DataService ds = new DataService();
            try
            {
                openFileDialog_AMD.ShowDialog();
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog_AMD.Filter = "Значения разделённые точкой с запятой (*.csv)|*.csv|Все файлы (*.*)|*.*";
                saveFileDialog_AMD.RestoreDirectory = true;
                saveFileDialog_AMD.InitialDirectory = Directory.GetCurrentDirectory();

                if (saveFileDialog_AMD.ShowDialog() != DialogResult.OK)
                    return;

                string path = saveFileDialog_AMD.FileName;

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

                File.WriteAllText(path, sb.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
