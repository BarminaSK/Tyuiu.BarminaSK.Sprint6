using Tyuiu.BarminaSK.Sprint6.Task4.V19.Lib;

namespace Tyuiu.BarminaSK.Sprint6.Task4.V19.Test
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
            mass[0] = 23.61;
            mass[1] = 16.08;
            mass[2] = 7.84;
            mass[3] = 4.58;
            mass[4] = 2.88;
            mass[5] = 0.75;
            mass[6] = -4.47;
            mass[7] = -9.46;
            mass[8] = -7.41;
            mass[9] = -6.16;
            mass[10] = -7.29;
            double[] res;
            res = new double[length];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(mass, res);
        }
    }
}
