namespace Project
{
    partial class FreqDictForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartFreqDict = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartFreqDict)).BeginInit();
            this.SuspendLayout();
            // 
            // chartFreqDict
            // 
            this.chartFreqDict.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chartFreqDict.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFreqDict.Legends.Add(legend1);
            this.chartFreqDict.Location = new System.Drawing.Point(13, 13);
            this.chartFreqDict.Name = "chartFreqDict";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.LegendText = "Частоты";
            series1.Name = "freqs";
            this.chartFreqDict.Series.Add(series1);
            this.chartFreqDict.Size = new System.Drawing.Size(775, 300);
            this.chartFreqDict.TabIndex = 0;
            this.chartFreqDict.Text = "chart1";
            // 
            // FreqDictForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 330);
            this.Controls.Add(this.chartFreqDict);
            this.Name = "FreqDictForm";
            this.Text = "FreqDict";
            ((System.ComponentModel.ISupportInitialize)(this.chartFreqDict)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartFreqDict;
    }
}