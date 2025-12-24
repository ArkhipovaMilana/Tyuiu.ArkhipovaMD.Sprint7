using Tyuiu.ArkhipovaMD.Sprint7.Project.V9.Lib;

namespace Tyuiu.ArkhipovaMD.Sprint7.Project.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidLoad()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\arkhi\Downloads\papa.csv";
            string[,] data =ds.LoadDataFromFile(path);
            string[,] exp = { {"1"} };
            CollectionAssert.AreEqual(exp, data);
        }
        [TestMethod]
        public void ValidSort()
        {
            DataService ds = new DataService();
            string[,] data = new string[,] { { "1", "2", "3" }, { "3", "2", "1" } };
            int targetCol = 0;
            string command = "decreasing";
            string[,] result = ds.SaleSort(data, targetCol, command);
            string[,] expect = { { "3", "2", "1" }, { "1", "2", "3" } };
        }
        [TestMethod]
        public void ValidStatisticsSum()
        {
            DataService ds = new DataService();
            string[,] data = new string[,] { { "1", "2", "3" }, { "3", "2", "1" } };
            string command = "sum";
            int column = 0;
            double result = ds.DataStatistics(data,command,column);
            double expect = 4;

            Assert.AreEqual(expect, result);
        }

        [TestMethod]
        public void ValidStatisticsMin()
        {
            DataService ds = new DataService();
            string[,] data = new string[,] { { "1", "2", "3" }, { "3", "2", "1" } };
            string command = "min";
            int column = 0;
            double result = ds.DataStatistics(data, command, column);
            double expect = 1;

            Assert.AreEqual(expect, result);
        }

        [TestMethod]
        public void ValidStatisticsMax()
        {
            DataService ds = new DataService();
            string[,] data = new string[,] { { "1", "2", "3" }, { "3", "2", "1" } };
            string command = "max";
            int column = 0;
            double result = ds.DataStatistics(data, command, column);
            double expect = 3;

            Assert.AreEqual(expect, result);
        }

        [TestMethod]
        public void ValidStatisticsAvg()
        {
            DataService ds = new DataService();
            string[,] data = new string[,] { { "1", "2", "3" }, { "3", "2", "1" } };
            string command = "avg";
            int column = 0;
            double result = ds.DataStatistics(data, command, column);
            double expect = 2;

            Assert.AreEqual(expect, result);
        }
        [TestMethod]
        public void ValidStatisticsAmo()
        {
            DataService ds = new DataService();
            string[,] data = new string[,] { { "1", "2", "3" }, { "3", "2", "1" } };
            string command = "amo";
            int column = 0;
            double result = ds.DataStatistics(data, command, column);
            double expect = 2;

            Assert.AreEqual(expect, result);
        }
    }
}
