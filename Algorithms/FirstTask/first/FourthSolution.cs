using System;

namespace Algorithms.FirstTask.first
{
    public static class FourthSolution
    {
        public static double Calculate(double[] vector, double x = 1.5)
        {
            double result = 0;
            for (int k = 0; k < vector.Length; k++)
            {
                result += vector[k] * Math.Pow(x, k);
            }
            return result;
        }
    }
}