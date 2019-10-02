using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;

namespace Project
{
    public static class HillEncoder
    {
        public static string Encrypt(string inputText, Matrix<double> matrixOfKey)
        {
            inputText = PrepareTextToEncrypting(inputText);
            var outputText = "";
            var portionSize = matrixOfKey.RowCount;

            while (inputText.Length % portionSize != 0)
            {
                inputText += 'x';
            }

            for (int i = 0; i < inputText.Length; i += portionSize)
            {
                var portion = inputText.Substring(i, portionSize);
                var arrayOfIndexes = portion.Select(x => (double)Settings.ALPHABET.IndexOf(x)).ToArray();
                Vector<double> vector = Vector<double>.Build.DenseOfArray(arrayOfIndexes);
                foreach (var elem in matrixOfKey.Multiply(vector))
                {
                    outputText += Settings.ALPHABET[((int)elem) % Settings.ALPHABET_LENGTH];
                }
            }

            return outputText;
        }

        private static string PrepareTextToEncrypting(string original,int? length = null)
        {
            var text = "";
            foreach (var ch in original.Where(x => Settings.ALPHABET.Contains(x)).ToArray())
            {
                text += ch;
                if (length != null && text.Length == length) break;
            }

            return text;
        }

        public static Matrix<double> CalculateMatrixOfKey(string originalText, string encryptedText, int size)
        {
            var matrix = DenseMatrix.Build.DenseDiagonal(size,size, 0);

            originalText = PrepareTextToEncrypting(originalText, size * size);
            encryptedText = PrepareTextToEncrypting(encryptedText, size * size);

            return matrix;
        }
    }
}
