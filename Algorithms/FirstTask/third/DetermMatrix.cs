using System;
using System.Diagnostics;
using System.Text;

namespace Algorithms.FirstTask.third
{
    class DetermMatrix
    {
        public static double Calculate(double[,] matrix)
        {
            if (matrix.GetLength(0) != matrix.GetLength(1)) 
                throw new ArithmeticException();
            const double eps = 1E-9;
            var n = matrix.GetLength(0);
            double[][] a = new double[n][];
            for (int i = 0; i < n; i++)
            {
                a[i] = new double[n];
                for (int j = 0; j < n; j++)
                    a[i][j] = matrix[i, j];
            }
            var b = new double[1][];
            var det = 1d;
            for (int i = 0; i < n; ++i)
            {
                var k = i;
                for (int j = i + 1; j < n; ++j)
                {
                    if (Math.Abs(matrix[j, i]) > Math.Abs(matrix[k, i]))
                        k = j;
                }

                if (Math.Abs(a[k][i]) < eps)
                {
                    det = 0;
                    break;
                }

                b[0] = a[i];
                a[i] = a[k];
                a[k] = b[0];
                if (i != k)
                    det = -det;
                det *= a[i][i];
                for (int j = i + 1; j < n; ++j)
                {
                    a[i][j] /= a[i][i];
                }

                for (int j = 0; j < n; ++j)
                
                    if ((j != i)&&(Math.Abs(a[j][i]) > eps))
                        for (k = i + 1; k < n; ++k)
                            a[j][k] -= a[i][k] * a[j][i];
            }
            return det;
        }
    }
}
