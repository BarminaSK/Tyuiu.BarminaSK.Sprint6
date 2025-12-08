using Tyuiu.BarminaSK.Sprint6.Task0.V6.Lib;

namespace Tyuiu.BarminaSK.Sprint6.Task0.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int x = 3;
            double result = ds.Calculate(x);

            double expected = x / Math.Sqrt(x * x + x);
            expected = Math.Round(expected, 3);
            Assert.AreEqual(expected, result); 
        }
    }
}
