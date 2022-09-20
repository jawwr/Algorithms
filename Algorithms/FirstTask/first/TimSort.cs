using System;

namespace Algorithms.FirstTask.first
{
    public static class TimSort
    {
        public static double[] Calculate(double[] arr)
        {
            static int GetMinrun(int n)
            {
                int r = 0;
                while (n >= 64)
                {
                    r |= n & 1;
                    n >>= 1;
                }
                return n + r;
            }
            var minRun = GetMinrun(arr.Length);
            var lenght = arr.Length;
            // Sort individual subarrays of size RUN
            for (int i = 0; i < lenght; i += minRun)
            {
                InsertionSort(arr, i, Math.Min((i + minRun - 1), (lenght - 1)));
            }
            for (int size = minRun; size < lenght; size = 2 * size)
            {
                for (int left = 0; left < lenght; left += 2 * size)
                {

                    int mid = left + size - 1;
                    int right = Math.Min((left + 2 * size - 1), (lenght - 1));

                    if (mid < right)
                    {
                        Merge(arr, left, mid, right);
                    }

                }
            }
            return arr;
        }
        public static double[] InsertionSort(double[] vector, int left = 0, int right = 0)
        {
            if (right == 0) right = vector.Length - 1;
            for(int j = left + 1; j <= right; j++)
            {
                var currentEl = vector[j];
                var i = j - 1;
                while((i >= left) && (vector[i] > currentEl))
                {
                    vector[i + 1] = vector[i];
                    i--;
                }
                vector[i + 1] = currentEl;
            }
            return vector;
        }
        
        private static void Merge(double[] arr, int left, int midle, int right)
        {
            int lenghtLeft = midle - left + 1, lenghtRight = right - midle;
            double[] leftArr = new double[lenghtLeft];
            double[] rightArr = new double[lenghtRight];
            for (int x = 0; x < lenghtLeft; x++)
                leftArr[x] = arr[left + x];
            for (int x = 0; x < lenghtRight; x++)
                rightArr[x] = arr[midle + 1 + x];

            int i = 0;
            int j = 0;
            int k = left;

            while (i < lenghtLeft && j < lenghtRight)
            {
                if (leftArr[i] <= rightArr[j])
                {
                    arr[k] = leftArr[i];
                    i++;
                }
                else
                {
                    arr[k] = rightArr[j];
                    j++;
                }
                k++;
            }
            while (i < lenghtLeft)
            {
                arr[k] = leftArr[i];
                k++;
                i++;
            }
            while (j < lenghtRight)
            {
                arr[k] = rightArr[j];
                k++;
                j++;
            }
        }
    }
}