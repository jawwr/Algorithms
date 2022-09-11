using System.Numerics;

namespace Algorithms.tasks
{
    public class ThirdSolution
    {
        public static double Calculate(double[] vector)
        {
            double result = 1;
            foreach (var num in vector)
            {
                result *= num;
            }

            return result;
        }
    }
}