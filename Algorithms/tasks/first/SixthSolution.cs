using System;
using System.Collections.Concurrent;

namespace Algorithms.tasks
{
    public class SixthSolution
    {
        public static void QuickSort(int[] vector, int from, int to)
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

        private static int Partitioner(int[] vector, int from, int to)
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
        public static double[] QuickSort(double[] vector)
        {
            if (vector.Length <= 1) return vector;
            double randomValue = vector[new Random().Next(0, vector.Length)];
            int leftCount = 0;
            int rightCount = 0;
            int middleCount = 0;

            foreach (var num in vector)
            {
                if (num > randomValue)
                {
                    rightCount++;
                }
                else if (num < randomValue)
                {
                    leftCount++;
                }
                else
                {
                    middleCount++;
                }
            }

            double[] leftElements = new double[leftCount];
            double[] rightElements = new double[rightCount];
            double[] middleElements = new double[middleCount];

            int leftIndex = 0;
            int rightIndex = 0;
            int middleIndex = 0;

            for (int i = 0; i < vector.Length; i++)
            {
                var currentElement = vector[i];
                if (currentElement > randomValue)
                {
                    rightElements[rightIndex++] = currentElement;
                }
                else if (currentElement < randomValue)
                {
                    leftElements[leftIndex++] = currentElement;
                }
                else
                {
                    middleElements[middleIndex++] = currentElement;
                }
            }

            QuickSort(leftElements);
            QuickSort(rightElements);
            for (int i = 0; i < vector.Length; i++)
            {
                if (i < leftElements.Length)
                {
                    vector[i] = leftElements[i];
                }
                else if (i - leftElements.Length < middleElements.Length)
                {
                    vector[i] = middleElements[i - leftElements.Length];
                }
                else
                {
                    vector[i] = rightElements[i - leftElements.Length - middleElements.Length];
                }
            }

            return vector;
        }
    }
}