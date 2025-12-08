using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.BarminaSK.Sprint6.Task2.V21.Lib
{
    public class DataService : ISprint6Task2V21
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue - startValue) + 1;
            double[] valueArray = new double[len];

            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                double y;

                if (x == -2)
                {
                    y = 0;
                }
                else
                {
                    double part1 = Math.Cos(x);
                    double part2 = Math.Cos(x) / (x + 2);

                    y = part1 + part2 - 3*x;
                }

                y = Math.Round(y, 2);

                valueArray[count] = y;
                count++;
            }

            return valueArray;
        }
    }
}
