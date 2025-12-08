using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.BarminaSK.Sprint6.Task4.V19.Lib
{
    public class DataService : ISprint6Task4V19
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue - startValue) + 1;
            double[] valueArray = new double[len];

            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                double y;

                if (Math.Sin(x) == 2)
                {
                    y = 0;
                }
                else
                {
                    double part1 = 5*x + 2.5;
                    double part2 = Math.Sin(x) - 2;

                    y = part1 / part2 + 2;
                }

                y = Math.Round(y, 2);

                valueArray[count] = y;
                count++;
            }

            return valueArray;
        }
    }
}
