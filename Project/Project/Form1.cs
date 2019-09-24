using MathNet.Numerics.LinearAlgebra.Double;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics.LinearAlgebra;

namespace Project
{
    public partial class Form1 : Form
    {
        private Matrix<double> _keyMatrix;
        private Matrix<double> _inverseKeyMatrix;
        private int _matrixSize;

        public Form1()
        {
            InitializeComponent();

            //var matrix = DenseMatrix.OfArray(new double[,]
            //{
            //    { 17,17,5},
            //    {21,18,21 },
            //    {2,2,19}
            //});

            //var matrix2 = DenseMatrix.OfArray(new double[,]
            //{
            //    {5,17},
            //    {8,3 }
            //});

            //inputTextBox.Text = matrix.ToMatrixString();

            //inputTextBox.Text = inputTextBox.Text + "\ndet: " + Math.Abs(matrix.Determinant()) % 26;

            //outputTextBox.Text = Inverse(matrix2).ToMatrixString();

        }

        private Matrix<double> Inverse(Matrix<double> matrix)
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

        private void btnLoadTextFromFile_Click(object sender, EventArgs e)
        {
            var explorer = new OpenFileDialog();

            if (explorer.ShowDialog() == DialogResult.OK)
            {
                var textFromFile = File.ReadAllText(explorer.FileName, Encoding.Default);

                inputTextBox.Text = textFromFile;
            }
        }

        private void btnSaveTextToFile_Click(object sender, EventArgs e)
        {
            var explorer = new OpenFileDialog();

            if (explorer.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(explorer.FileName, outputTextBox.Text);

                MessageBox.Show($"Файл {explorer.FileName}  успешно сохранен!", "Success", MessageBoxButtons.OK);

                outputTextBox.Text = string.Empty;
            }
        }

        private void cmbboxMatrixSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            var matrixSize = int.Parse(cmbboxMatrixSize.SelectedItem.ToString());
            if (matrixSize != 0)
            {
                _matrixSize = matrixSize;
                enableMatrixInputs(_matrixSize);
            }
        }

        private void enableMatrixInputs(int size)
        {
            disableMatrixInputs();

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    var controls = Controls.Find("matrix" + i + j, false);
                    foreach (var control in controls) control.Enabled = true;
                    controls = Controls.Find("inverse" + i + j, false);
                    foreach (var control in controls) control.Enabled = true;
                }
            }
        }

        private void disableMatrixInputs()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    var controls = Controls.Find("matrix" + i + j, false);
                    foreach (var control in controls) control.Enabled = false;
                    controls = Controls.Find("inverse" + i + j, false);
                    foreach (var control in controls) control.Enabled = false;
                }
            }
        }

        private void btnFindInverseMatrix_Click(object sender, EventArgs e)
        {
            fillMatrixFromInterface();
            _inverseKeyMatrix = Inverse(_keyMatrix);
            fillInputsForMatrix("inverse");
        }

        private void fillMatrixFromInterface()
        {
            _keyMatrix = DenseMatrix.Build.DenseDiagonal(_matrixSize, _matrixSize, 0);

            for (int i = 0; i < _matrixSize; i++)
            {
                for (int j = 0; j < _matrixSize; j++)
                {
                    var controls = Controls.Find("matrix" + i + j, false);
                    _keyMatrix.At(i, j, double.Parse(controls[0].Text));
                }
            }
        }

        private void fillInputsForMatrix(string matrixName)
        {
            Matrix<double> tempMatrix;

            if (matrixName == "matrix")
            {
                tempMatrix = _keyMatrix;
            }
            else if (matrixName == "inverse")
            {
                tempMatrix = _inverseKeyMatrix;
            }
            else
            {
                return;
            }

            for (int i = 0; i < _matrixSize; i++)
            {
                for (int j = 0; j < _matrixSize; j++)
                {
                    var controls = Controls.Find(matrixName + i + j, false);
                    controls[0].Text = tempMatrix.At(i, j).ToString();
                }
            }
        }
    }
}
