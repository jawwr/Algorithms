namespace Algorithms.FirstTask.first
{
    public static class MultiplicationFunction
    {
        public static int Calculate(double[] vector)
        {
            int result = 1;
            foreach (var num in vector)
            {
                result *= (int)num;
            }
            return result;
        }
    }
}