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
                btnAutoGenerateKey.Enabled = true;
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
            try
            {
                fillMatrixFromInterface();
            }
            catch (FormatException)
            {
                MessageBox.Show("Заполните матрицу ключа!");
                return;
            }

            if (MatrixHelper.CheckConstraints(_keyMatrix))
            {
                _inverseKeyMatrix = MatrixHelper.Inverse(_keyMatrix);
                fillInputsForMatrix("inverse");
            }
            else
            {
                MessageBox.Show("Матрица не удовлетворяет ограничениям!");
            }
            
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

        private void btnAutoGenerateKey_Click(object sender, EventArgs e)
        {
            _keyMatrix = MatrixHelper.GetRandomMatrix(_matrixSize);
            fillInputsForMatrix("matrix");
        }

        private void outputTextBox_TextChanged(object sender, EventArgs e)
        {
            if (outputTextBox.Text.Length > 0)
            {
                btnDecrypt.Enabled = true;
                btnSaveTextToFile.Enabled = true;
                btnShowFreqDict.Enabled = true;
            }
            else
            {
                btnDecrypt.Enabled = false;
                btnSaveTextToFile.Enabled = false;
                btnShowFreqDict.Enabled = false;
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (_keyMatrix != null)
            {
                var text = "";
                foreach (var ch in inputTextBox.Text.Where(x => Settings.ALPHABET.Contains(x)).ToArray())
                {
                    text += ch;
                }
                outputTextBox.Text = MergeEncryptAndOriginalStrings(HillEncoder.Encrypt(text, _keyMatrix),inputTextBox.Text);
            }
        }

        private string MergeEncryptAndOriginalStrings(string encryptString, string originalString)
        {
            var mergedString = "";
            foreach (var ch in originalString)
            {
                if (Settings.ALPHABET.Contains(ch))
                {
                    mergedString += encryptString[0];
                    encryptString = encryptString.Remove(0, 1);
                }
                else
                {
                    mergedString += ch;
                }
            }

            return mergedString;
        }

        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {
            if (inputTextBox.Text.Length > 0)
            {
                btnEncrypt.Enabled = true;
            }
            else
            {
                btnEncrypt.Enabled = false;
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (_inverseKeyMatrix != null)
            {
                var text = "";
                foreach (var ch in outputTextBox.Text.Where(x => Settings.ALPHABET.Contains(x)).ToArray())
                {
                    text += ch;
                }
                outputTextBox.Text = MergeEncryptAndOriginalStrings(HillEncoder.Encrypt(text, _inverseKeyMatrix), outputTextBox.Text);
            }
        }

        private void btnShowFreqDict_Click(object sender, EventArgs e)
        {
            var dict = FrequentCounter.countAppearencesOfLetter(outputTextBox.Text);
            new FreqDictForm(dict.Values.ToArray()).ShowDialog(this);
        }
    }
}
