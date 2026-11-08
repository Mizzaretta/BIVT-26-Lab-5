using System.Linq;
using System.Runtime.InteropServices;

namespace Lab5
{
    public class Purple
    {
        public int[] Task1(int[,] matrix)
        {
            int[] answer = null;

            // code here
            answer = new int[matrix.GetLength(1)];

            for (int col = 0, j = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    if (matrix[row, col] < 0)
                        answer[j]++;
                }
                j++;
            }
            // end

            return answer;
        }
        public void Task2(int[,] matrix)
        {

            // code here

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int iMin = 0;
                int temp = matrix[row, 0];

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] < matrix[row, iMin])
                        iMin = col;
                }

                for (int col = iMin; col > 0; col--)
                {
                    (matrix[row,col], matrix[row,col - 1]) = (matrix[row, col - 1], matrix[row, col]);
                }

            }

            // end

        }
        public int[,] Task3(int[,] matrix)
        {
            int[,] answer = null;

            // code here
            answer = new int[matrix.GetLength(0), matrix.GetLength(1) + 1];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int jMax = 0;
                int max = int.MinValue;

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                        jMax = j;
                    }
                }

                for (int j = 0; j < answer.GetLength(1); j++)
                {
                    if (j <= jMax)
                        answer[i, j] = matrix[i, j];
                    else if (j == jMax + 1)
                        answer[i, j] = max;
                    else
                        answer[i, j] = matrix[i, j - 1];
                }
            }

            // end

            return answer;
        }
        public void Task4(int[,] matrix)
        {

            // code here

            // end

        }
        public void Task5(int[,] matrix, int k)
        {

            // code here

            // end

        }
        public void Task6(int[,] matrix, int[] array)
        {

            // code here

            // end

        }
        public void Task7(int[,] matrix)
        {

            // code here

            // end

        }
        public int[] Task8(int[,] matrix)
        {
            int[] answer = null;

            // code here

            // end

            return answer;
        }
        public void Task9(int[,] matrix, int k)
        {

            // code here

            // end

        }
        public int[,] Task10(int[,] A, int[,] B)
        {
            int[,] answer = null;

            // code here

            // end

            return answer;
        }
        public int[][] Task11(int[,] matrix)
        {
            int[][] answer = null;

            // code here

            // end

            return answer;
        }
        public int[,] Task12(int[][] array)
        {
            int[,] answer = null;

            // code here

            // end

            return answer;
        }
    }
}