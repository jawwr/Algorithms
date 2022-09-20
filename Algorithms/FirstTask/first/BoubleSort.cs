namespace Algorithms.FirstTask.first
{
    public static class BoubleSort
    {
        public static double[] Calculate(double[] vector)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                for (int j = i + 1; j < vector.Length; j++)
                {
                    if (vector[i] > vector[j])
                    {
                        (vector[j], vector[i]) = (vector[i], vector[j]);
                    }
                }
            }
            return vector;
        }
    }
}