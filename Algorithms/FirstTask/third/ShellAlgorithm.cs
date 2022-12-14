namespace Algorithms.FirstTask.third
{
    public class ShellAlgorithm
    {
        public static double[] Calculate(double[] vector)
        {
            int size = vector.Length;

            for (int h = size / 2; h > 0; h /= 2)
            {
                for (int i = h; i < size; i += 1)
                {
                    double temp = vector[i];

                    int j;
                    for (j = i; j >= h && vector[j - h] > temp; j -= h)
                    {
                        vector[j] = vector[j - h];
                    }

                    vector[j] = temp;
                }
            }

            return vector;
        }
    }
}