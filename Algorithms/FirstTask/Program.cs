using System;
using Algorithms.FirstTask.first;
using Algorithms.FirstTask.second;
using Algorithms.FirstTask.third;
using Algorithms.Tester;
using Algorithms.Tester.interfaces;
using MatrixType = Algorithms.Tester.DataTypes.Matrix;
using Vector = Algorithms.Tester.DataTypes.Vector;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            /*TestVectorAlgorithm(x => LinearFunction.Calculate(x), "LinearAlgorithm", 5);
            TestVectorAlgorithm(x => SumFunction.Calculate(x), "SumAlgorithm", 5);
            TestVectorAlgorithm(x => MultiplicationFunction.Calculate(x), "MultiplicationAlgorithm", 5);
            TestVectorAlgorithm(x => BoubleSort.Calculate(x), "BoubleSort", 5);
            TestVectorAlgorithm(x => QuickSort.Calculate(x), "QuickSort", 5);
            TestVectorAlgorithm(x => ShellAlgorithm.Calculate(x), "ShellAlgorithm", 5);
            TestQuadraticMatrixAlgorithm(x => FloydWarshallAlgorithm.Calculate(x), "FloydWarshallAlgorithm", 5);
            TestQuadraticMatrixAlgorithm(x => DetermMatrix.Calculate(x), "DetermMatrixAlgorithm", 5);*/
            TestDoubleMatrixAlgorithm(Matrix.MultipleMatrix,  "MulMatrix", 5);
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

        public static void TestQuadraticMatrixAlgorithm(Func<double[,], object> func, string name, int iterCount)
        {
            ITester<double> tester = new TimeTester();
            for (int i = 0; i < 300; i++)
            {
                var matrix = MatrixType.RandomGenerate(i, i);
                tester.Test(() => func.Invoke(matrix), iterCount, name);
                Console.WriteLine("Тест алгоритма: {0} | Итерация: {1}", name, i);
            }
            tester.SaveAsExcel(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), name);
            tester.AllResults.Clear();
        }
        
        public static void TestDoubleMatrixAlgorithm(Func<double[,],double[,], object> func, string name, int iterCount)
        {
            ITester<double> tester = new TimeTester();
            for (int i = 0; i < 300; i++)
            {
                var matrix1 = MatrixType.RandomGenerate(i, i);
                var matrix2 = MatrixType.RandomGenerate(i, i);
                tester.Test(() => func.Invoke(matrix1, matrix2), iterCount, name);
                Console.WriteLine("Тест алгоритма: {0} | Итерация: {1}x{2}", name, i, i);
                
            }
            tester.SaveAsExcel(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), name);
            tester.AllResults.Clear();
        }
        
    }
}