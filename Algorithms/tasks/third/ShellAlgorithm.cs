namespace Algorithms.tasks.third
{
    public class ShellAlgorithm
    {
        public static void Calculate(int[] vector)
        {
            int size = vector.Length;

            for (int h = size / 2; h > 0; h /= 2)
            {
                for (int i = h; i < size; i += 1)
                {
                    int temp = vector[i];

                    int j;
                    for (j = i; j >= h && vector[j - h] > temp; j -= h)
                    {
                        vector[j] = vector[j - h];
                    }

                    vector[j] = temp;
                }
            }
        }
    }
}