using System;

namespace Algorithms.FirstTask.first
{
    public class FourthSolution
    {
        public double Calculate(double[] vector, double x)
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