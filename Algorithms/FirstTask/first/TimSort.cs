using System;

namespace Algorithms.FirstTask.first
{
    public class TimSort
    {
        public static int[] Calculate(int[] vector)
        {
            var minRun = GetMinRun(vector.Length);
            var length = vector.Length;
            // for (int i = 0; i < length; i++)
            // {
            //     InsertionSort(vector, i, Math.Min((i + minRun - 1), (length - 1)));
            // }

            for (int size = minRun; size < length; size = 2 * size)
            {
                for (int left = 0; left < length; left += 2 * size)
                {
                    int mid = left + size - 1;
                    int right = Math.Min((left + 2 * size - 1), (length - 1));
                    if (mid < right)
                    {
                        Merge(vector, left, mid, right);
                    }
                }
            }

            return vector;
        }
        static int[] InsertionSort(int[] inputArray)
        {
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (inputArray[j - 1] > inputArray[j])
                    {
                        (inputArray[j - 1], inputArray[j]) = (inputArray[j], inputArray[j - 1]);
                    }
                }
            }
            return inputArray;         
        }

        private static void Merge(int[] vector, int left, int mid, int right)
        {
            int lengthLeft = mid - left + 1;
            int lengthRight = right - mid;
            int[] leftArr = new int[lengthLeft];
            int[] rightArr = new int[lengthRight];
            for (int x = 0; x < lengthLeft; x++)
            {
                leftArr[x] = vector[left + x];
            }

            for (int x = 0; x < lengthRight; x++)
            {
                rightArr[x] = vector[mid + 1 + x];
            }

            int i = 0, j = 0, k = left;
            while (i < lengthRight && j < lengthRight)
            {
                if (leftArr[i] <= rightArr[j])
                {
                    vector[k] = leftArr[i];
                    i++;
                }
                else
                {
                    vector[k] = rightArr[j];
                    j++;
                }
                k++;
            }

            while (i < lengthLeft)
            {
                vector[k] = leftArr[j];
                k++;
                i++;
            }

            while (j < lengthRight)
            {
                vector[k] = rightArr[j];
                k++;
                j++;
            }
            
        }

        private static int GetMinRun(int n)
        {
            int r = 0;
            while (n >= 64)
            {
                r |= n & 1;
                n >>= 1;
            }

            return n + r;
        }
    }
}