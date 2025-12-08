using Tyuiu.BarminaSK.Sprint6.Task5.V29.Lib;

namespace Tyuiu.BarminaSK.Sprint6.Task5.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();
            double[] result = ds.LoadFromDataFile(@"C:\Users\makar\source\repos\Tyuiu.BarminaSK.Sprint6\Tyuiu.BarminaSK.Sprint6.Task5.V29\bin\Debug\net8.0-windows\InPutDataFileTask5V29.txt");

            double[] expected = { 18, 18.17, 12, 11, 18 };

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i], 0.01);
            }
        }
    }
}
