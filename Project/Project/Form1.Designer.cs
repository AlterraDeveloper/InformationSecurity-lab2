namespace Project
{
    partial class Form1
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
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnLoadTextFromFile = new System.Windows.Forms.Button();
            this.cmbboxMatrixSize = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.matrix00 = new System.Windows.Forms.TextBox();
            this.matrix01 = new System.Windows.Forms.TextBox();
            this.matrix02 = new System.Windows.Forms.TextBox();
            this.matrix03 = new System.Windows.Forms.TextBox();
            this.matrix04 = new System.Windows.Forms.TextBox();
            this.matrix14 = new System.Windows.Forms.TextBox();
            this.matrix13 = new System.Windows.Forms.TextBox();
            this.matrix12 = new System.Windows.Forms.TextBox();
            this.matrix11 = new System.Windows.Forms.TextBox();
            this.matrix10 = new System.Windows.Forms.TextBox();
            this.matrix24 = new System.Windows.Forms.TextBox();
            this.matrix23 = new System.Windows.Forms.TextBox();
            this.matrix22 = new System.Windows.Forms.TextBox();
            this.matrix21 = new System.Windows.Forms.TextBox();
            this.matrix20 = new System.Windows.Forms.TextBox();
            this.matrix34 = new System.Windows.Forms.TextBox();
            this.matrix33 = new System.Windows.Forms.TextBox();
            this.matrix32 = new System.Windows.Forms.TextBox();
            this.matrix31 = new System.Windows.Forms.TextBox();
            this.matrix30 = new System.Windows.Forms.TextBox();
            this.matrix44 = new System.Windows.Forms.TextBox();
            this.matrix43 = new System.Windows.Forms.TextBox();
            this.matrix42 = new System.Windows.Forms.TextBox();
            this.matrix41 = new System.Windows.Forms.TextBox();
            this.matrix40 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inverse44 = new System.Windows.Forms.TextBox();
            this.inverse43 = new System.Windows.Forms.TextBox();
            this.inverse42 = new System.Windows.Forms.TextBox();
            this.inverse41 = new System.Windows.Forms.TextBox();
            this.inverse40 = new System.Windows.Forms.TextBox();
            this.inverse34 = new System.Windows.Forms.TextBox();
            this.inverse33 = new System.Windows.Forms.TextBox();
            this.inverse32 = new System.Windows.Forms.TextBox();
            this.inverse31 = new System.Windows.Forms.TextBox();
            this.inverse30 = new System.Windows.Forms.TextBox();
            this.inverse24 = new System.Windows.Forms.TextBox();
            this.inverse23 = new System.Windows.Forms.TextBox();
            this.inverse22 = new System.Windows.Forms.TextBox();
            this.inverse21 = new System.Windows.Forms.TextBox();
            this.inverse20 = new System.Windows.Forms.TextBox();
            this.inverse14 = new System.Windows.Forms.TextBox();
            this.inverse13 = new System.Windows.Forms.TextBox();
            this.inverse12 = new System.Windows.Forms.TextBox();
            this.inverse11 = new System.Windows.Forms.TextBox();
            this.inverse10 = new System.Windows.Forms.TextBox();
            this.inverse04 = new System.Windows.Forms.TextBox();
            this.inverse03 = new System.Windows.Forms.TextBox();
            this.inverse02 = new System.Windows.Forms.TextBox();
            this.inverse01 = new System.Windows.Forms.TextBox();
            this.inverse00 = new System.Windows.Forms.TextBox();
            this.btnFindInverseMatrix = new System.Windows.Forms.Button();
            this.btnSaveTextToFile = new System.Windows.Forms.Button();
            this.btnShowFreqDict = new System.Windows.Forms.Button();
            this.btnAutoGenerateKey = new System.Windows.Forms.Button();
            this.btnGuessMatrixOfKey = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(33, 20);
            this.inputTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.inputTextBox.Multiline = true;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.inputTextBox.Size = new System.Drawing.Size(845, 176);
            this.inputTextBox.TabIndex = 0;
            this.inputTextBox.TextChanged += new System.EventHandler(this.inputTextBox_TextChanged);
            // 
            // outputTextBox
            // 
            this.outputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputTextBox.Location = new System.Drawing.Point(33, 443);
            this.outputTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputTextBox.Size = new System.Drawing.Size(845, 176);
            this.outputTextBox.TabIndex = 1;
            this.outputTextBox.TextChanged += new System.EventHandler(this.outputTextBox_TextChanged);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Enabled = false;
            this.btnEncrypt.Location = new System.Drawing.Point(33, 217);
            this.btnEncrypt.Margin = new System.Windows.Forms.Padding(4);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(195, 28);
            this.btnEncrypt.TabIndex = 2;
            this.btnEncrypt.Text = "Зашифровать";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Enabled = false;
            this.btnDecrypt.Location = new System.Drawing.Point(33, 253);
            this.btnDecrypt.Margin = new System.Windows.Forms.Padding(4);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(195, 28);
            this.btnDecrypt.TabIndex = 3;
            this.btnDecrypt.Text = "Расшифровать";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnLoadTextFromFile
            // 
            this.btnLoadTextFromFile.Location = new System.Drawing.Point(893, 20);
            this.btnLoadTextFromFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadTextFromFile.Name = "btnLoadTextFromFile";
            this.btnLoadTextFromFile.Size = new System.Drawing.Size(167, 80);
            this.btnLoadTextFromFile.TabIndex = 4;
            this.btnLoadTextFromFile.Text = "Загрузить текст из файла";
            this.btnLoadTextFromFile.UseVisualStyleBackColor = true;
            this.btnLoadTextFromFile.Click += new System.EventHandler(this.btnLoadTextFromFile_Click);
            // 
            // cmbboxMatrixSize
            // 
            this.cmbboxMatrixSize.FormattingEnabled = true;
            this.cmbboxMatrixSize.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5"});
            this.cmbboxMatrixSize.Location = new System.Drawing.Point(56, 320);
            this.cmbboxMatrixSize.Margin = new System.Windows.Forms.Padding(4);
            this.cmbboxMatrixSize.Name = "cmbboxMatrixSize";
            this.cmbboxMatrixSize.Size = new System.Drawing.Size(160, 24);
            this.cmbboxMatrixSize.TabIndex = 5;
            this.cmbboxMatrixSize.SelectedIndexChanged += new System.EventHandler(this.cmbboxMatrixSize_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 297);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Размерность матрицы ключа";
            // 
            // matrix00
            // 
            this.matrix00.Enabled = false;
            this.matrix00.Location = new System.Drawing.Point(262, 247);
            this.matrix00.Margin = new System.Windows.Forms.Padding(4);
            this.matrix00.Name = "matrix00";
            this.matrix00.Size = new System.Drawing.Size(53, 23);
            this.matrix00.TabIndex = 7;
            this.matrix00.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // matrix01
            // 
            this.matrix01.Enabled = false;
            this.matrix01.Location = new System.Drawing.Point(330, 247);
            this.matrix01.Margin = new System.Windows.Forms.Padding(4);
            this.matrix01.Name = "matrix01";
            this.matrix01.Size = new System.Drawing.Size(53, 23);
            this.matrix01.TabIndex = 8;
            this.matrix01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // matrix02
            // 
            this.matrix02.Enabled = false;
            this.matrix02.Location = new System.Drawing.Point(398, 247);
            this.matrix02.Margin = new System.Windows.Forms.Padding(4);
            this.matrix02.Name = "matrix02";
            this.matrix02.Size = new System.Drawing.Size(53, 23);
            this.matrix02.TabIndex = 9;
            this.matrix02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // matrix03
            // 
            this.matrix03.Enabled = false;
            this.matrix03.Location = new System.Drawing.Point(466, 247);
            this.matrix03.Margin = new System.Windows.Forms.Padding(4);
            this.matrix03.Name = "matrix03";
            this.matrix03.Size = new System.Drawing.Size(53, 23);
            this.matrix03.TabIndex = 10;
            this.matrix03.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // matrix04
            // 
            this.matrix04.Enabled = false;
            this.matrix04.Location = new System.Drawing.Point(534, 247);
            this.matrix04.Margin = new System.Windows.Forms.Padding(4);
            this.matrix04.Name = "matrix04";
            this.matrix04.Size = new System.Drawing.Size(53, 23);
            this.matrix04.TabIndex = 11;
            this.matrix04.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // matrix14
            // 
            this.matrix14.Enabled = false;
            this.matrix14.Location = new System.Drawing.Point(534, 279);
            this.matrix14.Margin = new System.Windows.Forms.Padding(4);
            this.matrix14.Name = "matrix14";
            this.matrix14.Size = new System.Drawing.Size(53, 23);
            this.matrix14.TabIndex = 16;
            this.matrix14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // matrix13
            // 
            this.matrix13.Enabled = false;
            this.matrix13.Location = new System.Drawing.Point(466, 279);
            this.matrix13.Margin = new System.Windows.Forms.Padding(4);
            this.matrix13.Name = "matrix13";
            this.matrix13.Size = new System.Drawing.Size(53, 23);
            this.matrix13.TabIndex = 15;
            this.matrix13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // matrix12
            // 
            this.matrix12.Enabled = false;
            this.matrix12.Location = new System.Drawing.Point(398, 279);
            this.matrix12.Margin = new System.Windows.Forms.Padding(4);
            this.matrix12.Name = "matrix12";
            this.matrix12.Size = new System.Drawing.Size(53, 23);
            this.matrix12.TabIndex = 14;
            this.matrix12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // matrix11
            // 
            this.matrix11.Enabled = false;
            this.matrix11.Location = new System.Drawing.Point(330, 279);
            this.matrix11.Margin = new System.Windows.Forms.Padding(4);
            this.matrix11.Name = "matrix11";
            this.matrix11.Size = new System.Drawing.Size(53, 23);
            this.matrix11.TabIndex = 13;
            this.matrix11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // matrix10
            // 
            this.matrix10.Enabled = false;
            this.matrix10.Location = new System.Drawing.Point(262, 279);
            this.matrix10.Margin = new System.Windows.Forms.Padding(4);
            this.matrix10.Name = "matrix10";
            this.matrix10.Size = new System.Drawing.Size(53, 23);
            this.matrix10.TabIndex = 12;
            this.matrix10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // matrix24
            // 
            this.matrix24.Enabled = false;
            this.matrix24.Location = new System.Drawing.Point(534, 311);
            this.matrix24.Margin = new System.Windows.Forms.Padding(4);
            this.matrix24.Name = "matrix24";
            this.matrix24.Size = new System.Drawing.Size(53, 23);
            this.matrix24.TabIndex = 21;
            this.matrix24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // matrix23
            // 
            this.matrix23.Enabled = false;
            this.matrix23.Location = new System.Drawing.Point(466, 311);
            this.matrix23.Margin = new System.Windows.Forms.Padding(4);
            this.matrix23.Name = "matrix23";
            this.matrix23.Size = new System.Drawing.Size(53, 23);
            this.matrix23.TabIndex = 20;
            this.matrix23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // matrix22
            // 
            this.matrix22.Enabled = false;
            this.matrix22.Location = new System.Drawing.Point(398, 311);
            this.matrix22.Margin = new System.Windows.Forms.Padding(4);
            this.matrix22.Name = "matrix22";
            this.matrix22.Size = new System.Drawing.Size(53, 23);
            this.matrix22.TabIndex = 19;
            this.matrix22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // matrix21
            // 
            this.matrix21.Enabled = false;
            this.matrix21.Location = new System.Drawing.Point(330, 311);
            this.matrix21.Margin = new System.Windows.Forms.Padding(4);
            this.matrix21.Name = "matrix21";
            this.matrix21.Size = new System.Drawing.Size(53, 23);
            this.matrix21.TabIndex = 18;
            this.matrix21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // matrix20
            // 
            this.matrix20.Enabled = false;
            this.matrix20.Location = new System.Drawing.Point(262, 311);
            this.matrix20.Margin = new System.Windows.Forms.Padding(4);
            this.matrix20.Name = "matrix20";
            this.matrix20.Size = new System.Drawing.Size(53, 23);
            this.matrix20.TabIndex = 17;
            this.matrix20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // matrix34
            // 
            this.matrix34.Enabled = false;
            this.matrix34.Location = new System.Drawing.Point(534, 343);
            this.matrix34.Margin = new System.Windows.Forms.Padding(4);
            this.matrix34.Name = "matrix34";
            this.matrix34.Size = new System.Drawing.Size(53, 23);
            this.matrix34.TabIndex = 26;
            this.matrix34.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // matrix33
            // 
            this.matrix33.Enabled = false;
            this.matrix33.Location = new System.Drawing.Point(466, 343);
            this.matrix33.Margin = new System.Windows.Forms.Padding(4);
            this.matrix33.Name = "matrix33";
            this.matrix33.Size = new System.Drawing.Size(53, 23);
            this.matrix33.TabIndex = 25;
            this.matrix33.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // matrix32
            // 
            this.matrix32.Enabled = false;
            this.matrix32.Location = new System.Drawing.Point(398, 343);
            this.matrix32.Margin = new System.Windows.Forms.Padding(4);
            this.matrix32.Name = "matrix32";
            this.matrix32.Size = new System.Drawing.Size(53, 23);
            this.matrix32.TabIndex = 24;
            this.matrix32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // matrix31
            // 
            this.matrix31.Enabled = false;
            this.matrix31.Location = new System.Drawing.Point(330, 343);
            this.matrix31.Margin = new System.Windows.Forms.Padding(4);
            this.matrix31.Name = "matrix31";
            this.matrix31.Size = new System.Drawing.Size(53, 23);
            this.matrix31.TabIndex = 23;
            this.matrix31.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // matrix30
            // 
            this.matrix30.Enabled = false;
            this.matrix30.Location = new System.Drawing.Point(262, 343);
            this.matrix30.Margin = new System.Windows.Forms.Padding(4);
            this.matrix30.Name = "matrix30";
            this.matrix30.Size = new System.Drawing.Size(53, 23);
            this.matrix30.TabIndex = 22;
            this.matrix30.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // matrix44
            // 
            this.matrix44.Enabled = false;
            this.matrix44.Location = new System.Drawing.Point(534, 377);
            this.matrix44.Margin = new System.Windows.Forms.Padding(4);
            this.matrix44.Name = "matrix44";
            this.matrix44.Size = new System.Drawing.Size(53, 23);
            this.matrix44.TabIndex = 31;
            this.matrix44.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // matrix43
            // 
            this.matrix43.Enabled = false;
            this.matrix43.Location = new System.Drawing.Point(466, 377);
            this.matrix43.Margin = new System.Windows.Forms.Padding(4);
            this.matrix43.Name = "matrix43";
            this.matrix43.Size = new System.Drawing.Size(53, 23);
            this.matrix43.TabIndex = 30;
            this.matrix43.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // matrix42
            // 
            this.matrix42.Enabled = false;
            this.matrix42.Location = new System.Drawing.Point(398, 377);
            this.matrix42.Margin = new System.Windows.Forms.Padding(4);
            this.matrix42.Name = "matrix42";
            this.matrix42.Size = new System.Drawing.Size(53, 23);
            this.matrix42.TabIndex = 29;
            this.matrix42.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // matrix41
            // 
            this.matrix41.Enabled = false;
            this.matrix41.Location = new System.Drawing.Point(330, 377);
            this.matrix41.Margin = new System.Windows.Forms.Padding(4);
            this.matrix41.Name = "matrix41";
            this.matrix41.Size = new System.Drawing.Size(53, 23);
            this.matrix41.TabIndex = 28;
            this.matrix41.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // matrix40
            // 
            this.matrix40.Enabled = false;
            this.matrix40.Location = new System.Drawing.Point(262, 377);
            this.matrix40.Margin = new System.Windows.Forms.Padding(4);
            this.matrix40.Name = "matrix40";
            this.matrix40.Size = new System.Drawing.Size(53, 23);
            this.matrix40.TabIndex = 27;
            this.matrix40.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(376, 217);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Матрица ключа";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(796, 217);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 17);
            this.label3.TabIndex = 58;
            this.label3.Text = "Обратная матрица";
            // 
            // inverse44
            // 
            this.inverse44.Enabled = false;
            this.inverse44.Location = new System.Drawing.Point(961, 377);
            this.inverse44.Margin = new System.Windows.Forms.Padding(4);
            this.inverse44.Name = "inverse44";
            this.inverse44.ReadOnly = true;
            this.inverse44.Size = new System.Drawing.Size(53, 23);
            this.inverse44.TabIndex = 57;
            this.inverse44.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inverse44.TextChanged += new System.EventHandler(this.btnLoadTextFromFile_Click);
            // 
            // inverse43
            // 
            this.inverse43.Enabled = false;
            this.inverse43.Location = new System.Drawing.Point(893, 377);
            this.inverse43.Margin = new System.Windows.Forms.Padding(4);
            this.inverse43.Name = "inverse43";
            this.inverse43.ReadOnly = true;
            this.inverse43.Size = new System.Drawing.Size(53, 23);
            this.inverse43.TabIndex = 56;
            this.inverse43.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inverse42
            // 
            this.inverse42.Enabled = false;
            this.inverse42.Location = new System.Drawing.Point(825, 377);
            this.inverse42.Margin = new System.Windows.Forms.Padding(4);
            this.inverse42.Name = "inverse42";
            this.inverse42.ReadOnly = true;
            this.inverse42.Size = new System.Drawing.Size(53, 23);
            this.inverse42.TabIndex = 55;
            this.inverse42.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inverse41
            // 
            this.inverse41.Enabled = false;
            this.inverse41.Location = new System.Drawing.Point(757, 377);
            this.inverse41.Margin = new System.Windows.Forms.Padding(4);
            this.inverse41.Name = "inverse41";
            this.inverse41.ReadOnly = true;
            this.inverse41.Size = new System.Drawing.Size(53, 23);
            this.inverse41.TabIndex = 54;
            this.inverse41.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inverse40
            // 
            this.inverse40.Enabled = false;
            this.inverse40.Location = new System.Drawing.Point(689, 377);
            this.inverse40.Margin = new System.Windows.Forms.Padding(4);
            this.inverse40.Name = "inverse40";
            this.inverse40.ReadOnly = true;
            this.inverse40.Size = new System.Drawing.Size(53, 23);
            this.inverse40.TabIndex = 53;
            this.inverse40.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inverse34
            // 
            this.inverse34.Enabled = false;
            this.inverse34.Location = new System.Drawing.Point(961, 343);
            this.inverse34.Margin = new System.Windows.Forms.Padding(4);
            this.inverse34.Name = "inverse34";
            this.inverse34.ReadOnly = true;
            this.inverse34.Size = new System.Drawing.Size(53, 23);
            this.inverse34.TabIndex = 52;
            this.inverse34.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inverse33
            // 
            this.inverse33.Enabled = false;
            this.inverse33.Location = new System.Drawing.Point(893, 343);
            this.inverse33.Margin = new System.Windows.Forms.Padding(4);
            this.inverse33.Name = "inverse33";
            this.inverse33.ReadOnly = true;
            this.inverse33.Size = new System.Drawing.Size(53, 23);
            this.inverse33.TabIndex = 51;
            this.inverse33.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inverse32
            // 
            this.inverse32.Enabled = false;
            this.inverse32.Location = new System.Drawing.Point(825, 343);
            this.inverse32.Margin = new System.Windows.Forms.Padding(4);
            this.inverse32.Name = "inverse32";
            this.inverse32.ReadOnly = true;
            this.inverse32.Size = new System.Drawing.Size(53, 23);
            this.inverse32.TabIndex = 50;
            this.inverse32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inverse31
            // 
            this.inverse31.Enabled = false;
            this.inverse31.Location = new System.Drawing.Point(757, 343);
            this.inverse31.Margin = new System.Windows.Forms.Padding(4);
            this.inverse31.Name = "inverse31";
            this.inverse31.ReadOnly = true;
            this.inverse31.Size = new System.Drawing.Size(53, 23);
            this.inverse31.TabIndex = 49;
            this.inverse31.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inverse30
            // 
            this.inverse30.Enabled = false;
            this.inverse30.Location = new System.Drawing.Point(689, 343);
            this.inverse30.Margin = new System.Windows.Forms.Padding(4);
            this.inverse30.Name = "inverse30";
            this.inverse30.ReadOnly = true;
            this.inverse30.Size = new System.Drawing.Size(53, 23);
            this.inverse30.TabIndex = 48;
            this.inverse30.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inverse24
            // 
            this.inverse24.Enabled = false;
            this.inverse24.Location = new System.Drawing.Point(961, 311);
            this.inverse24.Margin = new System.Windows.Forms.Padding(4);
            this.inverse24.Name = "inverse24";
            this.inverse24.ReadOnly = true;
            this.inverse24.Size = new System.Drawing.Size(53, 23);
            this.inverse24.TabIndex = 47;
            this.inverse24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inverse23
            // 
            this.inverse23.Enabled = false;
            this.inverse23.Location = new System.Drawing.Point(893, 311);
            this.inverse23.Margin = new System.Windows.Forms.Padding(4);
            this.inverse23.Name = "inverse23";
            this.inverse23.ReadOnly = true;
            this.inverse23.Size = new System.Drawing.Size(53, 23);
            this.inverse23.TabIndex = 46;
            this.inverse23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inverse22
            // 
            this.inverse22.Enabled = false;
            this.inverse22.Location = new System.Drawing.Point(825, 311);
            this.inverse22.Margin = new System.Windows.Forms.Padding(4);
            this.inverse22.Name = "inverse22";
            this.inverse22.ReadOnly = true;
            this.inverse22.Size = new System.Drawing.Size(53, 23);
            this.inverse22.TabIndex = 45;
            this.inverse22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inverse21
            // 
            this.inverse21.Enabled = false;
            this.inverse21.Location = new System.Drawing.Point(757, 311);
            this.inverse21.Margin = new System.Windows.Forms.Padding(4);
            this.inverse21.Name = "inverse21";
            this.inverse21.ReadOnly = true;
            this.inverse21.Size = new System.Drawing.Size(53, 23);
            this.inverse21.TabIndex = 44;
            this.inverse21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inverse20
            // 
            this.inverse20.Enabled = false;
            this.inverse20.Location = new System.Drawing.Point(689, 311);
            this.inverse20.Margin = new System.Windows.Forms.Padding(4);
            this.inverse20.Name = "inverse20";
            this.inverse20.ReadOnly = true;
            this.inverse20.Size = new System.Drawing.Size(53, 23);
            this.inverse20.TabIndex = 43;
            this.inverse20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inverse14
            // 
            this.inverse14.Enabled = false;
            this.inverse14.Location = new System.Drawing.Point(961, 279);
            this.inverse14.Margin = new System.Windows.Forms.Padding(4);
            this.inverse14.Name = "inverse14";
            this.inverse14.ReadOnly = true;
            this.inverse14.Size = new System.Drawing.Size(53, 23);
            this.inverse14.TabIndex = 42;
            this.inverse14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inverse13
            // 
            this.inverse13.Enabled = false;
            this.inverse13.Location = new System.Drawing.Point(893, 279);
            this.inverse13.Margin = new System.Windows.Forms.Padding(4);
            this.inverse13.Name = "inverse13";
            this.inverse13.ReadOnly = true;
            this.inverse13.Size = new System.Drawing.Size(53, 23);
            this.inverse13.TabIndex = 41;
            this.inverse13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inverse12
            // 
            this.inverse12.Enabled = false;
            this.inverse12.Location = new System.Drawing.Point(825, 279);
            this.inverse12.Margin = new System.Windows.Forms.Padding(4);
            this.inverse12.Name = "inverse12";
            this.inverse12.ReadOnly = true;
            this.inverse12.Size = new System.Drawing.Size(53, 23);
            this.inverse12.TabIndex = 40;
            this.inverse12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inverse11
            // 
            this.inverse11.Enabled = false;
            this.inverse11.Location = new System.Drawing.Point(757, 279);
            this.inverse11.Margin = new System.Windows.Forms.Padding(4);
            this.inverse11.Name = "inverse11";
            this.inverse11.ReadOnly = true;
            this.inverse11.Size = new System.Drawing.Size(53, 23);
            this.inverse11.TabIndex = 39;
            this.inverse11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inverse10
            // 
            this.inverse10.Enabled = false;
            this.inverse10.Location = new System.Drawing.Point(689, 279);
            this.inverse10.Margin = new System.Windows.Forms.Padding(4);
            this.inverse10.Name = "inverse10";
            this.inverse10.ReadOnly = true;
            this.inverse10.Size = new System.Drawing.Size(53, 23);
            this.inverse10.TabIndex = 38;
            this.inverse10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inverse04
            // 
            this.inverse04.Enabled = false;
            this.inverse04.Location = new System.Drawing.Point(961, 247);
            this.inverse04.Margin = new System.Windows.Forms.Padding(4);
            this.inverse04.Name = "inverse04";
            this.inverse04.ReadOnly = true;
            this.inverse04.Size = new System.Drawing.Size(53, 23);
            this.inverse04.TabIndex = 37;
            this.inverse04.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inverse03
            // 
            this.inverse03.Enabled = false;
            this.inverse03.Location = new System.Drawing.Point(893, 247);
            this.inverse03.Margin = new System.Windows.Forms.Padding(4);
            this.inverse03.Name = "inverse03";
            this.inverse03.ReadOnly = true;
            this.inverse03.Size = new System.Drawing.Size(53, 23);
            this.inverse03.TabIndex = 36;
            this.inverse03.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inverse02
            // 
            this.inverse02.Enabled = false;
            this.inverse02.Location = new System.Drawing.Point(825, 247);
            this.inverse02.Margin = new System.Windows.Forms.Padding(4);
            this.inverse02.Name = "inverse02";
            this.inverse02.ReadOnly = true;
            this.inverse02.Size = new System.Drawing.Size(53, 23);
            this.inverse02.TabIndex = 35;
            this.inverse02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inverse01
            // 
            this.inverse01.Enabled = false;
            this.inverse01.Location = new System.Drawing.Point(757, 247);
            this.inverse01.Margin = new System.Windows.Forms.Padding(4);
            this.inverse01.Name = "inverse01";
            this.inverse01.ReadOnly = true;
            this.inverse01.Size = new System.Drawing.Size(53, 23);
            this.inverse01.TabIndex = 34;
            this.inverse01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inverse00
            // 
            this.inverse00.Enabled = false;
            this.inverse00.Location = new System.Drawing.Point(689, 247);
            this.inverse00.Margin = new System.Windows.Forms.Padding(4);
            this.inverse00.Name = "inverse00";
            this.inverse00.ReadOnly = true;
            this.inverse00.Size = new System.Drawing.Size(53, 23);
            this.inverse00.TabIndex = 33;
            this.inverse00.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnFindInverseMatrix
            // 
            this.btnFindInverseMatrix.Location = new System.Drawing.Point(607, 247);
            this.btnFindInverseMatrix.Name = "btnFindInverseMatrix";
            this.btnFindInverseMatrix.Size = new System.Drawing.Size(62, 153);
            this.btnFindInverseMatrix.TabIndex = 59;
            this.btnFindInverseMatrix.Text = "->";
            this.btnFindInverseMatrix.UseVisualStyleBackColor = true;
            this.btnFindInverseMatrix.Click += new System.EventHandler(this.btnFindInverseMatrix_Click);
            // 
            // btnSaveTextToFile
            // 
            this.btnSaveTextToFile.Enabled = false;
            this.btnSaveTextToFile.Location = new System.Drawing.Point(893, 443);
            this.btnSaveTextToFile.Name = "btnSaveTextToFile";
            this.btnSaveTextToFile.Size = new System.Drawing.Size(167, 80);
            this.btnSaveTextToFile.TabIndex = 60;
            this.btnSaveTextToFile.Text = "Сохранить в файл";
            this.btnSaveTextToFile.UseVisualStyleBackColor = true;
            this.btnSaveTextToFile.Click += new System.EventHandler(this.btnSaveTextToFile_Click);
            // 
            // btnShowFreqDict
            // 
            this.btnShowFreqDict.Enabled = false;
            this.btnShowFreqDict.Location = new System.Drawing.Point(893, 529);
            this.btnShowFreqDict.Name = "btnShowFreqDict";
            this.btnShowFreqDict.Size = new System.Drawing.Size(167, 80);
            this.btnShowFreqDict.TabIndex = 61;
            this.btnShowFreqDict.Text = "Показать частотный словарь";
            this.btnShowFreqDict.UseVisualStyleBackColor = true;
            this.btnShowFreqDict.Click += new System.EventHandler(this.btnShowFreqDict_Click);
            // 
            // btnAutoGenerateKey
            // 
            this.btnAutoGenerateKey.Enabled = false;
            this.btnAutoGenerateKey.Location = new System.Drawing.Point(33, 351);
            this.btnAutoGenerateKey.Name = "btnAutoGenerateKey";
            this.btnAutoGenerateKey.Size = new System.Drawing.Size(195, 28);
            this.btnAutoGenerateKey.TabIndex = 62;
            this.btnAutoGenerateKey.Text = "Автогенерация ключа";
            this.btnAutoGenerateKey.UseVisualStyleBackColor = true;
            this.btnAutoGenerateKey.Click += new System.EventHandler(this.btnAutoGenerateKey_Click);
            // 
            // btnGuessMatrixOfKey
            // 
            this.btnGuessMatrixOfKey.Location = new System.Drawing.Point(33, 385);
            this.btnGuessMatrixOfKey.Name = "btnGuessMatrixOfKey";
            this.btnGuessMatrixOfKey.Size = new System.Drawing.Size(195, 28);
            this.btnGuessMatrixOfKey.TabIndex = 63;
            this.btnGuessMatrixOfKey.Text = "Вычислить матрицу ключа";
            this.btnGuessMatrixOfKey.UseVisualStyleBackColor = true;
            this.btnGuessMatrixOfKey.Click += new System.EventHandler(this.btnGuessMatrixOfKey_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 635);
            this.Controls.Add(this.btnGuessMatrixOfKey);
            this.Controls.Add(this.btnAutoGenerateKey);
            this.Controls.Add(this.btnShowFreqDict);
            this.Controls.Add(this.btnSaveTextToFile);
            this.Controls.Add(this.btnFindInverseMatrix);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inverse44);
            this.Controls.Add(this.inverse43);
            this.Controls.Add(this.inverse42);
            this.Controls.Add(this.inverse41);
            this.Controls.Add(this.inverse40);
            this.Controls.Add(this.inverse34);
            this.Controls.Add(this.inverse33);
            this.Controls.Add(this.inverse32);
            this.Controls.Add(this.inverse31);
            this.Controls.Add(this.inverse30);
            this.Controls.Add(this.inverse24);
            this.Controls.Add(this.inverse23);
            this.Controls.Add(this.inverse22);
            this.Controls.Add(this.inverse21);
            this.Controls.Add(this.inverse20);
            this.Controls.Add(this.inverse14);
            this.Controls.Add(this.inverse13);
            this.Controls.Add(this.inverse12);
            this.Controls.Add(this.inverse11);
            this.Controls.Add(this.inverse10);
            this.Controls.Add(this.inverse04);
            this.Controls.Add(this.inverse03);
            this.Controls.Add(this.inverse02);
            this.Controls.Add(this.inverse01);
            this.Controls.Add(this.inverse00);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.matrix44);
            this.Controls.Add(this.matrix43);
            this.Controls.Add(this.matrix42);
            this.Controls.Add(this.matrix41);
            this.Controls.Add(this.matrix40);
            this.Controls.Add(this.matrix34);
            this.Controls.Add(this.matrix33);
            this.Controls.Add(this.matrix32);
            this.Controls.Add(this.matrix31);
            this.Controls.Add(this.matrix30);
            this.Controls.Add(this.matrix24);
            this.Controls.Add(this.matrix23);
            this.Controls.Add(this.matrix22);
            this.Controls.Add(this.matrix21);
            this.Controls.Add(this.matrix20);
            this.Controls.Add(this.matrix14);
            this.Controls.Add(this.matrix13);
            this.Controls.Add(this.matrix12);
            this.Controls.Add(this.matrix11);
            this.Controls.Add(this.matrix10);
            this.Controls.Add(this.matrix04);
            this.Controls.Add(this.matrix03);
            this.Controls.Add(this.matrix02);
            this.Controls.Add(this.matrix01);
            this.Controls.Add(this.matrix00);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbboxMatrixSize);
            this.Controls.Add(this.btnLoadTextFromFile);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.inputTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnLoadTextFromFile;
        private System.Windows.Forms.ComboBox cmbboxMatrixSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox matrix00;
        private System.Windows.Forms.TextBox matrix01;
        private System.Windows.Forms.TextBox matrix02;
        private System.Windows.Forms.TextBox matrix03;
        private System.Windows.Forms.TextBox matrix04;
        private System.Windows.Forms.TextBox matrix14;
        private System.Windows.Forms.TextBox matrix13;
        private System.Windows.Forms.TextBox matrix12;
        private System.Windows.Forms.TextBox matrix11;
        private System.Windows.Forms.TextBox matrix10;
        private System.Windows.Forms.TextBox matrix24;
        private System.Windows.Forms.TextBox matrix23;
        private System.Windows.Forms.TextBox matrix22;
        private System.Windows.Forms.TextBox matrix21;
        private System.Windows.Forms.TextBox matrix20;
        private System.Windows.Forms.TextBox matrix34;
        private System.Windows.Forms.TextBox matrix33;
        private System.Windows.Forms.TextBox matrix32;
        private System.Windows.Forms.TextBox matrix31;
        private System.Windows.Forms.TextBox matrix30;
        private System.Windows.Forms.TextBox matrix44;
        private System.Windows.Forms.TextBox matrix43;
        private System.Windows.Forms.TextBox matrix42;
        private System.Windows.Forms.TextBox matrix41;
        private System.Windows.Forms.TextBox matrix40;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inverse44;
        private System.Windows.Forms.TextBox inverse43;
        private System.Windows.Forms.TextBox inverse42;
        private System.Windows.Forms.TextBox inverse41;
        private System.Windows.Forms.TextBox inverse40;
        private System.Windows.Forms.TextBox inverse34;
        private System.Windows.Forms.TextBox inverse33;
        private System.Windows.Forms.TextBox inverse32;
        private System.Windows.Forms.TextBox inverse31;
        private System.Windows.Forms.TextBox inverse30;
        private System.Windows.Forms.TextBox inverse24;
        private System.Windows.Forms.TextBox inverse23;
        private System.Windows.Forms.TextBox inverse22;
        private System.Windows.Forms.TextBox inverse21;
        private System.Windows.Forms.TextBox inverse20;
        private System.Windows.Forms.TextBox inverse14;
        private System.Windows.Forms.TextBox inverse13;
        private System.Windows.Forms.TextBox inverse12;
        private System.Windows.Forms.TextBox inverse11;
        private System.Windows.Forms.TextBox inverse10;
        private System.Windows.Forms.TextBox inverse04;
        private System.Windows.Forms.TextBox inverse03;
        private System.Windows.Forms.TextBox inverse02;
        private System.Windows.Forms.TextBox inverse01;
        private System.Windows.Forms.TextBox inverse00;
        private System.Windows.Forms.Button btnFindInverseMatrix;
        private System.Windows.Forms.Button btnSaveTextToFile;
        private System.Windows.Forms.Button btnShowFreqDict;
        private System.Windows.Forms.Button btnAutoGenerateKey;
        private System.Windows.Forms.Button btnGuessMatrixOfKey;
    }
}

