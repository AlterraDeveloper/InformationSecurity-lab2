using MathNet.Numerics.LinearAlgebra.Double;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var matrix = DenseMatrix.OfArray(new double[,]
            {
                { 17,17,5},
                {21,18,21 },
                {2,2,19}
            });

            textBox1.Text = matrix.ToMatrixString();

            textBox1.Text = textBox1.Text + "\ndet: " + Math.Abs(matrix.Determinant()) % 26;

            textBox2.Text = Inverse(matrix).ToMatrixString();

        }

        private Matrix Inverse(Matrix matrix)
        {
            var outputMatrix = DenseMatrix.Build.DenseDiagonal(matrix.RowCount, matrix.ColumnCount, 0);
            var matrixDet = (int) matrix.Determinant() % 26;
            for (int i = 0; i < matrix.RowCount; i++)
            {
                for (int j = 0; j < matrix.ColumnCount; j++)
                {
                    var tempMatrix = matrix.RemoveRow(i).RemoveColumn(j);
                    var insertedValue = Math.Pow(-1, i + j) * tempMatrix.Determinant();
                    outputMatrix.At(j, i, Math.Round(insertedValue / matrixDet));
                }
            }

            return (Matrix)outputMatrix;
        }
    }
}
