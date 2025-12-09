using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.BarminaSK.Sprint6.Task7.V23.Lib
{
    public class DataService : ISprint6Task7V23
    {
        public int[,] GetMatrix(string path)
        {
            string[] lines = File.ReadAllLines(path);

            int rows = lines.Length;
            string[] firstLine = lines[0].Split(';');
            int cols = firstLine.Length;

            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                string[] values = lines[i].Split(';');

                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = int.Parse(values[j]);
                }
            }

            int lastCol = cols - 1;

            for (int i = 0; i < rows; i++)
            {
                if (matrix[i, lastCol] < 2)
                {
                    matrix[i, lastCol] = 2;
                }
            }

            return matrix;
        }
    }
}
