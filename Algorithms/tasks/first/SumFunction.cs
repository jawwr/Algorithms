namespace Algorithms.tasks
{
    public class SumFunction : Algorithm
    {
        public override string GetAlgName() => "SumFunction";

        public override int Calculate(int[] vector)
        {
            int result = 0;
            foreach (var num in vector)
            {
                result += num;
            }

            return result;
        }
    }
}