namespace Algorithms.tasks
{
    public class SecondSolution
    {
        public static double Calculate(double[] vector)
        {
            double result = 0;
            foreach (var num in vector)
            {
                result += num;
            }

            return result;
        }
    }
}