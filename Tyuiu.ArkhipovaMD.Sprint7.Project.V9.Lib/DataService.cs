using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tyuiu.ArkhipovaMD.Sprint7.Project.V9.Lib
{
    public class DataService
    {
        public string[,] LoadDataFromFile(string path)
        {
            string[] lines = File.ReadAllLines(path).Where(l => !string.IsNullOrWhiteSpace(l)).ToArray();

            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;

            string[,] result = new string[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] parts = lines[r].Split(';');

                for (int c = 0; c < columns; c++)
                {
                    result[r, c] = c < parts.Length ? parts[c] : string.Empty;
                }
            }

            return result;
        }
    }
}