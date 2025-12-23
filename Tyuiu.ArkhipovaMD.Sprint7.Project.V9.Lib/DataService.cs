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
                result = data.GetLength(0) * data.GetLength(1);
            }

            return result;
        }
        public string[,] SaleSort(string[,] data,int targetCol,string command)
        {
            
            int rows = data.GetLength(0);
            int columns = data.GetLength(1);
            targetCol -= 1;

            string[,] sortedArray = (string[,])data.Clone();
            if (command == "ascending")
            {

                for (int i = 0; i < rows - 1; i++)
                {

                    if (Convert.ToInt32(sortedArray[i, targetCol]) > Convert.ToInt32(sortedArray[i + 1, targetCol]))
                    {
                        for (int k = 0; k < columns; k++)
                        {
                            string temp = sortedArray[i, k];
                            sortedArray[i, k] = sortedArray[i + 1, k];
                            sortedArray[i + 1, k] = temp;
                        }
                    }

                }
            }
            if (command=="decreasing")
            {
                for (int i = 0; i < rows - 1; i++)
                {

                    if (Convert.ToInt32(sortedArray[i, targetCol]) < Convert.ToInt32(sortedArray[i + 1, targetCol]))
                    {
                        for (int k = 0; k < columns; k++)
                        {
                            string temp = sortedArray[i, k];
                            sortedArray[i, k] = sortedArray[i + 1, k];
                            sortedArray[i + 1, k] = temp;
                        }
                    }

                }
            }
            return sortedArray;
        }
    }
}