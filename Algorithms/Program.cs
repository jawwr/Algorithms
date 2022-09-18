using System;
using System.Collections.Generic;
using System.Diagnostics;
using Algorithms.FirstTask;
using Algorithms.FirstTask.first;
using Algorithms.FirstTask.second;

namespace Algorithms
{
    class Program
    {
        private static readonly int[] Array = NumbersArray.Numbers;


        private static readonly List<Algorithm> Algorithms = new List<Algorithm>()
        {
            new LinearFunction(),
            new SumFunction(),
            new MultiplicationFunction(),
            // new FourthSolution(),
        };

        static void Main(string[] args)
        {
            // var inf = uint.MaxValue;
            // var graph = new uint[,]{{0, inf, 2, inf}, {4, 0, 3, inf}, {inf, inf, 0, 2}, {inf, 1, inf, 0}};
            // FloydWarshallAlgorithm.Calculate(graph);
            var first = new int[,] {{1, 2, -1}, {0, 1, 2}};
            var second = new int[,] {{3, 1}, {-1, 2}, {1, 2}};
            var r = Matrix.MultipleMatrix(first, second);
            Stopwatch stopwatch = new Stopwatch();
            // stopwatch.Start();
            // PowFunctions solution = new PowFunctions();
            // var first = solution.Pow(3, 4);
            // stopwatch.Stop();
            // Console.WriteLine($"{first} {stopwatch.ElapsedMilliseconds} ms");
            // stopwatch.Start();
            // var second = solution.RecPow(2, 8);
            // stopwatch.Stop();
            // Console.WriteLine($"{second} {stopwatch.ElapsedMilliseconds} ms");
            // stopwatch.Start();
            // var third = solution.QuickPow(5,10);
            // stopwatch.Stop();
            // Console.WriteLine($"{third} {stopwatch.ElapsedMilliseconds} ms");
            // stopwatch.Start();
            // stopwatch.Start();
            // var fourth = solution.MyRecPow(5,10);
            // stopwatch.Stop();
            // Console.WriteLine($"{fourth} {stopwatch.ElapsedMilliseconds} ms");
            // stopwatch.Start();
            // return;
            foreach (var algorithm in Algorithms)
            {
                Console.WriteLine(algorithm.GetAlgName());
                int limit = 0;
                for (int i = 1; i <= 5; i++)
                {
                    Console.WriteLine($"{i})");
                    int[] testArray = LimitArray(limit);
                    stopwatch.Start();
                    for (int j = 1; j <= 5; j++)
                    {
                        algorithm.Calculate(testArray);
                        stopwatch.Stop();
                        var ticks = stopwatch.ElapsedTicks;
                        Console.WriteLine($"\t{j}) {ticks} tick");
                    }

                    limit += 500;
                }
            }
        }

        private static int[] LimitArray(int limit)
        {
            int[] newArray = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                newArray[i] = Array[i];
            }

            return newArray;
        }
    }
}