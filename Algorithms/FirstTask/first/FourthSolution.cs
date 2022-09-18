namespace Algorithms.FirstTask.first
{
    public class FourthSolution : Algorithm
    {
        public override string GetAlgName() => "";

        public override int Calculate(int[] vector)
        {
            int result = 1;
            foreach (var num in vector)
            {
                result *= num;//TODO доделать
            }

            return result;
        }
    }
}