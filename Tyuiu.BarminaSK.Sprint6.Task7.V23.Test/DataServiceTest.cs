using Tyuiu.BarminaSK.Sprint6.Task7.V23.Lib;

namespace Tyuiu.BarminaSK.Sprint6.Task7.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\makar\source\repos\Tyuiu.BarminaSK.Sprint6\Tyuiu.BarminaSK.Sprint6.Task7.V23\InPutDataFileTask7V23.csv";
            int[,] result = ds.GetMatrix(path);

            int rows = result.GetLength(0);
            int lastCol = result.GetLength(1) - 1;

            string[] actual = new string[rows];
            for (int i = 0; i < rows; i++)
            {
                actual[i] = result[i, lastCol].ToString();
            }

            string[] expected = ["2", "2", "2", "4", "2", "19", "7", "2", "10", "2"];

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
