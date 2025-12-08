using Tyuiu.BarminaSK.Sprint6.Task3.V11.Lib;

namespace Tyuiu.BarminaSK.Sprint6.Task3.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] result = ds.Calculate(ds.GetInitialMatrix());

            Assert.AreEqual(-13, result[0, 0]);
            Assert.AreEqual(-8, result[1, 0]);
            Assert.AreEqual(-3, result[2, 0]);
            Assert.AreEqual(1, result[3, 0]);
            Assert.AreEqual(27, result[4, 0]);
        }
    }
}
