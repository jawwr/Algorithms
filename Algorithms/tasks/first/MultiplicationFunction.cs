namespace Algorithms.tasks
{
    public class MultiplicationFunction : Algorithm
    {
        public override string GetAlgName() => "MultiplicationFunction";

        public override int Calculate(int[] vector)
        {
            int result = 1;
            foreach (var num in vector)
            {
                result *= num;
            }

            return result;
        }
    }
}