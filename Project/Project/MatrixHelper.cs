using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics;
using MathNet.Numerics.Distributions;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;

namespace Project
{
    public static class MatrixHelper
    {
        public static Matrix<double> Inverse(Matrix<double> matrix)
        {
            var outputMatrix = DenseMatrix.Build.DenseDiagonal(matrix.RowCount, matrix.ColumnCount, 0);
            var matrixDet = (int)Math.Round(matrix.Determinant());

            while (matrixDet < 0)
            {
                matrixDet += 26;
            }

            for (int i = 0; i < matrix.RowCount; i++)
            {
                for (int j = 0; j < matrix.ColumnCount; j++)
                {
                    var tempMatrix = matrix.RemoveRow(i).RemoveColumn(j);
                    var insertedValue = Math.Pow(-1, i + j) * tempMatrix.Determinant();

                    while (insertedValue < 0)
                    {
                        insertedValue += 26;
                    }

                    while (insertedValue % matrixDet != 0)
                    {
                        insertedValue += 26;
                    }
                    outputMatrix.At(j, i, Math.Round(insertedValue / matrixDet) % 26);
                }
            }
            return (Matrix)outputMatrix;
        }

        public static bool CheckConstraints(Matrix<double> matrix)
        {
            var determinant = (long)Math.Round(matrix.Determinant(), 0);

            var firstCondition = determinant != 0;
            var secondCondition = Euclid.GreatestCommonDivisor(determinant, Settings.ALPHABET_LENGTH) == 1;

            return firstCondition && secondCondition;
        }

        public static Matrix<double> GetRandomMatrix(int size)
        {
            if (size < 0 || size > 5) return null;

            var outputMatrix = DenseMatrix.CreateRandom(size, size, new Cauchy());

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    outputMatrix.At(i, j, Math.Round(outputMatrix.At(i,j),0));
                }
            }

            return outputMatrix;
        }
    }
}
