namespace Algorithms.FirstTask.first
{
    public static class SumFunction
    {
        public static int Calculate(double[] vector)
        {
            int result = 0;
            foreach (var num in vector)
            {
                result += (int)num;
            }
            return result;
        }
    }
}