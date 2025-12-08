using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.BarminaSK.Sprint6.Task1.V8.Lib
{
    public class DataService : ISprint6Task1V8
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue - startValue) + 1;
            double[] valueArray = new double[len];

            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                double y;

                if (Math.Abs(x - 0.4) < 0.000001)
                {
                    y = 0;
                }
                else
                {
                    double part1 = Math.Cos(x) / (x - 0.4);
                    double part2 = Math.Sin(x) * 8 * x;

                    y = part1 + part2 + 2;
                }

                y = Math.Round(y, 2);

                valueArray[count] = y;
                count++;
            }

            return valueArray;
        }
    }
}
