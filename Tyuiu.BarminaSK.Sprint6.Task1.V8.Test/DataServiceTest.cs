using Tyuiu.BarminaSK.Sprint6.Task1.V8.Lib;

namespace Tyuiu.BarminaSK.Sprint6.Task1.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            int length = stopValue - startValue + 1;

            double[] mass;
            mass = new double[length];
            mass[0] = -36.41;
            mass[1] = -22.07;
            mass[2] = 5.68;
            mass[3] = 16.72;
            mass[4] = 8.35;
            mass[5] = -0.50;
            mass[6] = 9.63;
            mass[7] = 16.29;
            mass[8] = 5.01;
            mass[9] = -22.40;
            mass[10] = -36.30;
            double[] res;
            res = new double[length];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(mass, res);
        }
    }
}
