using System;
using System.Threading;

namespace Algorithms.tasks
{
    public class FourthSolution
    {
        public static double Calculate(double[] vector, float x)
        {
            double result = 1;
            foreach (var num in vector)
            {
                result *= num;//TODO доделать
            }

            return result;
        }
    }
}