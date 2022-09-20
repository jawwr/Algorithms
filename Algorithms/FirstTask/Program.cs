using System;
using Algorithms.FirstTask.first;
using Algorithms.FirstTask.second;
using Algorithms.FirstTask.third;
using Algorithms.Tester;
using Algorithms.Tester.interfaces;
using Vector = Algorithms.Tester.DataTypes.Vector;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            TestVectorAlgorithm(x => LinearFunction.Calculate(x), "LinearAlgorithm", 5);
            TestVectorAlgorithm(x => SumFunction.Calculate(x), "SumAlgorithm", 5);
            TestVectorAlgorithm(x => MultiplicationFunction.Calculate(x), "MultiplicationAlgorithm", 5);
            TestVectorAlgorithm(x => BoubleSort.Calculate(x), "BoubleSort", 5);
            TestVectorAlgorithm(x => QuickSort.Calculate(x), "QuickSort", 5);
            TestVectorAlgorithm(x => ShellAlgorithm.Calculate(x), "ShellAlgorithm", 5);
        }

        private static void TestVectorAlgorithm(Func<double[], object> func, string name, int iterCount)
        {
            ITester<double> tester = new TimeTester();
            for (int i = 0; i < 2000; i++)
            {
                var vector = Vector.RandomGenerate(i);
                tester.Test(() => func.Invoke(vector), iterCount, name);
                Console.WriteLine("Тест алгоритма: {0} | Итерация: {1}", name, i);
            }
            tester.SaveAsExcel(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), name);
            tester.AllResults.Clear();
        }
        
    }
}