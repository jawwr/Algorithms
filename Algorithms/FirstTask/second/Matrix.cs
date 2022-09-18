namespace Algorithms.FirstTask.second
{
    public class Matrix
    {
        public static int[,] MultipleMatrix(int[,] firstArray, int[,] secondArray)
        {
            int[,] result = new int[firstArray.GetLength(0),secondArray.GetLength(1)];
            for (int i = 0; i < firstArray.GetLength(0); ++i)
            {
                for (int j = 0; j < secondArray.GetLength(1); ++j)
                {
                    int sum = 0;
                    for (int g = 0; g < firstArray.GetLength(1); ++g)
                    {
                        sum += firstArray[i, g] * secondArray[g, j];
                    }

                    result[i, j] = sum;
                }
            }

            return result;
        }
    }
}