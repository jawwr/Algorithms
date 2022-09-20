namespace Algorithms.FirstTask.first
{
    public static class PowFunctions
    {
        public static (double, int) Pow(int num, int rank, int count = 0)
        {
            double result = 1;
            count += 1;
            for (int i = 0; i < rank; i++)
            {
                result *= num;
                count += 1;
            }
            return (result, count);
        }

        public static (double, int) RecPow(int num, int rank, int count = 0)
        {
            if (rank == 0)
            {
                count += 1;
                return (1, count);
            }
            (double, int) result = RecPow(num, rank / 2, count);
            if (rank % 2 == 1)
            {
                result.Item1 = result.Item1 * result.Item1 * num;
                result.Item2 += 1;
            }
            else
            {
                result.Item1 *= result.Item1;
                result.Item2 += 1;
            }
            return (result.Item1, result.Item2);
        }

        public static (double, int) QuickPow(int num, int rank, int count = 0)
        {
            double result;
            if (rank % 2 == 1)
            {
                count += 1;
                result = num;
            }
            else
            {
                count += 1;
                result = 1;
            }

            while (rank != 0)
            {
                rank /= 2;
                count += 1;
                num *= num;
                count += 1;
                if (rank % 2 == 1)
                {
                    count += 1;
                    result *= num;
                }
            }
            return (result, count);
        }

        public static (double, int) QuickPowAlt(int num, int rank, int count = 0)
        {
            double result = 1;
            count += 1;
            while (rank != 0)
            {
                if (rank % 2 == 0)
                {
                    count += 1;
                    num *= num;
                    count += 1;
                    rank /= 2;
                }
                else
                {
                    count += 1;
                    result *= num;
                    count += 1;
                    rank--;
                }
            }
            return (result, count);
        }
    }
}