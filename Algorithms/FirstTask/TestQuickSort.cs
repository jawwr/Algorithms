namespace Algorithms.FirstTask
{
    public class TestQuickSort
    {
        public void QuickSort(int[] vector, int from, int to)
        {
            int pivot;
            if (from < to)
            {
                pivot = Partitioner(vector, from, to);
                if (pivot > 1)
                {
                    QuickSort(vector, from, pivot - 1);
                }

                if (pivot + 1 < to)
                {
                    QuickSort(vector, pivot + 1, to);
                }
            }
        }

        private int Partitioner(int[] vector, int from, int to)
        {
            int pivot = vector[from];
            while (true)
            {
                while (vector[from] < pivot)
                {
                    from++;
                }

                while (vector[to] > pivot)
                {
                    to--;
                }

                if (from < to)
                {
                    (vector[from], vector[to]) = (vector[to], vector[from]);
                }
                else
                {
                    return to;
                }
            }
        }
    }
}