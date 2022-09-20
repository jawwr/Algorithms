using System;

namespace Algorithms.Tester.DataTypes
{
    public class Matrix
    {
        private readonly double[,] _values;

        private int RowLength { get; }
        private int ColumnLength { get; }

        public Matrix(int rowLength, int columnLength)
        {
            RowLength = rowLength;
            ColumnLength = columnLength;
            _values = new double[rowLength, columnLength];
        }

        public static double[,] RandomGenerate(int row, int column)
        {
            var rnd = new Random();
            double[,] matrix = new double[row, column];
            
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    matrix[i, j] = rnd.Next(0, int.MaxValue);
                }
            }

            return matrix;
        }
    }
}