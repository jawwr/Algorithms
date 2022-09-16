namespace Algorithms.tasks
{
    public class PowFunctions
    {
        public int Pow(int num, int rank)
        {
            int result = 1;
            for (int i = 0; i < rank; i++)
            {
                result *= num;
            }

            return result;
        }

        public int RecPow(int num, int rank)
        {
            if (rank == 0) return 1;
            int result = RecPow(num, rank / 2);
            if (rank % 2 == 1)
            {
                result = result * result * num;
            }
            else
            {
                result *= result;
            }

            return result;
        }

        public int QuickPow(int num, int rank)
        {
            int result;
            if (rank % 2 == 1)
            {
                result = num;
            }
            else
            {
                result = 1;
            }

            while (rank != 0)
            {
                rank /= 2;
                num *= num;
                if (rank % 2 == 1)
                {
                    result *= num;
                }
            }

            return result;
        }

        public int MyRecPow(int num, int rank)
        {
            if (rank == 1)
            {
                return num;
            }

            return num * MyRecPow(num, rank - 1);
        }
    }
}