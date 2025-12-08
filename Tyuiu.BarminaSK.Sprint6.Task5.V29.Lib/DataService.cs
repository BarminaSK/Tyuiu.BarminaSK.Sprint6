using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.BarminaSK.Sprint6.Task5.V29.Lib
{
    public class DataService : ISprint6Task5V29
    {

        public int len = 0;
        public double[] LoadFromDataFile(string path)
        {
            string fileContent = File.ReadAllText(path);

            string[] numbersStr = fileContent.Split(new char[] { ' ', '\t', '\r', '\n' },
                                                   StringSplitOptions.RemoveEmptyEntries);

            double[] numsArray = new double[numbersStr.Length];
            for (int i = 0; i < numbersStr.Length; i++)
            {
                numsArray[i] = Convert.ToDouble(numbersStr[i], CultureInfo.InvariantCulture);
            }

            numsArray = numsArray.Where(val => val > 10).Select(val => Math.Round(val, 3)).ToArray();

            return numsArray;
        }
    }
}
