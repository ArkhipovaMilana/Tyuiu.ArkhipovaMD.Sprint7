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
            if (columns == 0)
            {
                string[,] array = new string[1,1];
                return array;
            }

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

        public string SaveData(string path, string[,] matrix)
        {
            int row = matrix.GetLength(0);
            int col = matrix.GetLength(1);
            string data = "";

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (j != col - 1)
                    {
                        data = data + matrix[i, j] + ";";
                    }
                    else
                    {
                        data += matrix[i, j];
                    }
                }
                if (i != row - 1)
                {
                    data += "\t\n";
                }
            }
            File.WriteAllText(path, data);
            return path;
        }
    
        public double DataStatistics(object[,] data, string commandStat, int column)
        {
            int numRows = data.GetLength(0);
            int numColumns = data.GetLength(1);

            double result = 0;
            if (commandStat == "sum")
            {
                for (int i = 0; i < numRows; i++)
                {
                    result += Convert.ToInt32(data[i, column]);
                }

            }

            List<int> termsList = new List<int>();
            if (commandStat == "min")
            {
                for (int i = 0; i < numRows; i++)
                {
                    termsList.Add(Convert.ToInt32(data[i, column]));
                }

                int[] statElements = new int[numRows];
                statElements = termsList.ToArray();

                result = Convert.ToDouble(statElements.Min());
            }

            if (commandStat == "max")
            {
                for (int i = 0; i < numRows; i++)
                {
                    termsList.Add(Convert.ToInt32(data[i, column]));
                }

                int[] statElements = new int[numRows];
                statElements = termsList.ToArray();

                result = Convert.ToDouble(statElements.Max());
            }

            if (commandStat == "avg")
            {
                double resSum = 0;
                for (int i = 0; i < numRows; i++)
                {
                    resSum += Convert.ToDouble(data[i, column]);
                }
                result = resSum / numRows;
                result = Math.Round(result, 2);
            }
            if (commandStat == "amo")
            {
                result = data.GetLength(0);
            }

            return result;
        }
        public string[,] SaleSort(string[,] data, int targetCol, string command)
        {
            int rows = data.GetLength(0);
            int cols = data.GetLength(1);

            // Проверка номера столбца
            if (targetCol < 0 || targetCol >= cols)
                throw new ArgumentException("Неверный номер столбца");

            // Проверка команды
            if (command != "ascending" && command != "decreasing")
                throw new ArgumentException("Неизвестная команда сортировки");

            // Копируем исходный массив (исходный менять нельзя)
            string[,] result = new string[rows, cols];
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    result[i, j] = data[i, j];

            // Массив для числовых значений столбца
            double[] values = new double[rows];
            bool[] isEmpty = new bool[rows];

            for (int i = 0; i < rows; i++)
            {
                string cell = result[i, targetCol];

                if (string.IsNullOrWhiteSpace(cell))
                {
                    isEmpty[i] = true;
                }
                else
                {
                    if (!double.TryParse(cell, out values[i]))
                        throw new Exception($"В столбце {targetCol} обнаружено нечисловое значение");

                    isEmpty[i] = false;
                }
            }

            // Стабильная сортировка (пузырёк)
            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < rows - i - 1; j++)
                {
                    bool needSwap = false;

                    // Пустые строки всегда идут в конец
                    if (isEmpty[j] && !isEmpty[j + 1])
                        needSwap = false;
                    else if (!isEmpty[j] && isEmpty[j + 1])
                        needSwap = true;
                    else if (!isEmpty[j] && !isEmpty[j + 1])
                    {
                        if (command == "ascending" && values[j] > values[j + 1])
                            needSwap = true;

                        if (command == "decreasing" && values[j] < values[j + 1])
                            needSwap = true;
                    }

                    if (needSwap)
                    {
                        // меняем числовые значения
                        double tmpVal = values[j];
                        values[j] = values[j + 1];
                        values[j + 1] = tmpVal;

                        bool tmpEmpty = isEmpty[j];
                        isEmpty[j] = isEmpty[j + 1];
                        isEmpty[j + 1] = tmpEmpty;

                        // меняем строки целиком
                        for (int c = 0; c < cols; c++)
                        {
                            string tmp = result[j, c];
                            result[j, c] = result[j + 1, c];
                            result[j + 1, c] = tmp;
                        }
                    }
                }
            }

            return result;
        }
    }
}