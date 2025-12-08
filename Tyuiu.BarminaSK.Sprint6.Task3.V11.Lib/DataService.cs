using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.BarminaSK.Sprint6.Task3.V11.Lib
{
    public class DataService : ISprint6Task3V11
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = 5;
            int cols = 5;

            int[] firstColumn = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                firstColumn[i] = matrix[i, 0];
            }

            int[,] result = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = matrix[i, j];
                }
            }

            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < rows - 1 - i; j++)
                {
                    if (result[j, 0] > result[j + 1, 0])
                    {
                        int temp = result[j, 0];
                        result[j, 0] = result[j + 1, 0];
                        result[j + 1, 0] = temp;
                    }
                }
            }

            return result;
        }

        public int[,] GetInitialMatrix()
        {
            return new int[5, 5]
            {
                {27, -15, 14, 2, 27},
                {-8, 14, -10, 33, 0},
                {1, 7, -11, -11, 23},
                {-13, -20, 15, -16, 34},
                {-3, 1, -1, 5, 1}
            };
        }
    }
}
