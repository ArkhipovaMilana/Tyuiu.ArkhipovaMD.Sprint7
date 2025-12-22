using Tyuiu.ArkhipovaMD.Sprint7.Project.V9.Lib;

namespace Tyuiu.ArkhipovaMD.Sprint7.Project.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\arkhi\Downloads\papa.csv";
            string[,] data =ds.LoadDataFromFile(path);
            string[,] exp = { {"1"} };
            CollectionAssert.AreEqual(exp, data);
        }
    }
}
