using Tyuiu.BarminaSK.Sprint6.Task2.V21.Lib;

namespace Tyuiu.BarminaSK.Sprint6.Task2.V21.Test
{
    [TestClass]
    public sealed class Test1
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
            mass[0] = 15.19;
            mass[1] = 11.67;
            mass[2] = 9.00;
            mass[3] = 0.00;
            mass[4] = 4.08;
            mass[5] = 1.50;
            mass[6] = -2.28;
            mass[7] = -6.52;
            mass[8] = -10.19;
            mass[9] = -12.76;
            mass[10] = -14.68;
            double[] res;
            res = new double[length];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(mass, res);
        }
    }
}
