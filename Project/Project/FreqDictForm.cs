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
    public partial class FreqDictForm : Form
    {
        public FreqDictForm(double[] frequencies)
        {
            InitializeComponent();
            int i = 0;
            foreach (var frequency in frequencies)
            {
                chartFreqDict.Series["freqs"].Points.AddXY(i++, frequency);
            }

            chartFreqDict.Titles.Add("Частотный словарь");
        }
    }
}
