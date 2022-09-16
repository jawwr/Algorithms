namespace Algorithms.tasks
{
    public class BoubleSort
    {
        public int[] Calculate(int[] vector)
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