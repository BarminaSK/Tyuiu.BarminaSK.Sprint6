using Tyuiu.BarminaSK.Sprint6.Task6.V27.Lib;

namespace Tyuiu.BarminaSK.Sprint6.Task6.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            DataService ds = new DataService();

            string path = @"C:\DataSprint6\InPutDataFileTask6V27.txt";

            string result = ds.CollectTextFromFile(path);

            string expected = "UpGwjzkBH OHcr KgepHrKCHa";

            Assert.AreEqual(expected, result);
        }
    }
}
