namespace BMI_Calculator
{
    partial class BMICalculatorForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.backspaceButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.threeButton = new System.Windows.Forms.Button();
            this.twoButton = new System.Windows.Forms.Button();
            this.oneButton = new System.Windows.Forms.Button();
            this.sixButton = new System.Windows.Forms.Button();
            this.fiveButton = new System.Windows.Forms.Button();
            this.fourButton = new System.Windows.Forms.Button();
            this.nineButton = new System.Windows.Forms.Button();
            this.eightButton = new System.Windows.Forms.Button();
            this.sevenButton = new System.Windows.Forms.Button();
            this.zeroButton = new System.Windows.Forms.Button();
            this.metricButton = new System.Windows.Forms.RadioButton();
            this.ImperialButton = new System.Windows.Forms.RadioButton();
            this.myHeightLabel = new System.Windows.Forms.Label();
            this.MyWeightLabel = new System.Windows.Forms.Label();
            this.heightUnitLabel = new System.Windows.Forms.TextBox();
            this.weightUnitLabel = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.calculateBMIButton = new System.Windows.Forms.Button();
            this.heightText = new System.Windows.Forms.TextBox();
            this.weightText = new System.Windows.Forms.TextBox();
            this.conditionTextBox = new System.Windows.Forms.TextBox();
            this.conditionLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.backspaceButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.clearButton, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.threeButton, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.twoButton, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.oneButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.sixButton, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.fiveButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.fourButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.nineButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.eightButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.sevenButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.zeroButton, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 285);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(280, 144);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // backspaceButton
            // 
            this.backspaceButton.BackColor = System.Drawing.Color.Orange;
            this.backspaceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backspaceButton.Location = new System.Drawing.Point(3, 111);
            this.backspaceButton.Name = "backspaceButton";
            this.backspaceButton.Size = new System.Drawing.Size(87, 30);
            this.backspaceButton.TabIndex = 12;
            this.backspaceButton.Tag = "backspace";
            this.backspaceButton.Text = "<=";
            this.backspaceButton.UseVisualStyleBackColor = false;
            this.backspaceButton.Click += new System.EventHandler(this.keypadButton_click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.LawnGreen;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(189, 111);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(87, 30);
            this.clearButton.TabIndex = 11;
            this.clearButton.Tag = "clear";
            this.clearButton.Text = "CLEAR";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.keypadButton_click);
            // 
            // threeButton
            // 
            this.threeButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.threeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threeButton.Location = new System.Drawing.Point(189, 75);
            this.threeButton.Name = "threeButton";
            this.threeButton.Size = new System.Drawing.Size(87, 30);
            this.threeButton.TabIndex = 8;
            this.threeButton.Tag = "3";
            this.threeButton.Text = "3";
            this.threeButton.UseVisualStyleBackColor = false;
            this.threeButton.Click += new System.EventHandler(this.keypadButton_click);
            // 
            // twoButton
            // 
            this.twoButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.twoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twoButton.Location = new System.Drawing.Point(96, 75);
            this.twoButton.Name = "twoButton";
            this.twoButton.Size = new System.Drawing.Size(87, 30);
            this.twoButton.TabIndex = 7;
            this.twoButton.Tag = "2";
            this.twoButton.Text = "2";
            this.twoButton.UseVisualStyleBackColor = false;
            this.twoButton.Click += new System.EventHandler(this.keypadButton_click);
            // 
            // oneButton
            // 
            this.oneButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.oneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneButton.Location = new System.Drawing.Point(3, 75);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(87, 30);
            this.oneButton.TabIndex = 6;
            this.oneButton.Tag = "1";
            this.oneButton.Text = "1";
            this.oneButton.UseVisualStyleBackColor = false;
            this.oneButton.Click += new System.EventHandler(this.keypadButton_click);
            // 
            // sixButton
            // 
            this.sixButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.sixButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sixButton.Location = new System.Drawing.Point(189, 39);
            this.sixButton.Name = "sixButton";
            this.sixButton.Size = new System.Drawing.Size(87, 30);
            this.sixButton.TabIndex = 5;
            this.sixButton.Tag = "6";
            this.sixButton.Text = "6";
            this.sixButton.UseVisualStyleBackColor = false;
            this.sixButton.Click += new System.EventHandler(this.keypadButton_click);
            // 
            // fiveButton
            // 
            this.fiveButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.fiveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fiveButton.Location = new System.Drawing.Point(96, 39);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(87, 30);
            this.fiveButton.TabIndex = 4;
            this.fiveButton.Tag = "5";
            this.fiveButton.Text = "5";
            this.fiveButton.UseVisualStyleBackColor = false;
            this.fiveButton.Click += new System.EventHandler(this.keypadButton_click);
            // 
            // fourButton
            // 
            this.fourButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.fourButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourButton.Location = new System.Drawing.Point(3, 39);
            this.fourButton.Name = "fourButton";
            this.fourButton.Size = new System.Drawing.Size(87, 30);
            this.fourButton.TabIndex = 3;
            this.fourButton.Tag = "4";
            this.fourButton.Text = "4";
            this.fourButton.UseVisualStyleBackColor = false;
            this.fourButton.Click += new System.EventHandler(this.keypadButton_click);
            // 
            // nineButton
            // 
            this.nineButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.nineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nineButton.Location = new System.Drawing.Point(189, 3);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(87, 30);
            this.nineButton.TabIndex = 2;
            this.nineButton.Tag = "9";
            this.nineButton.Text = "9";
            this.nineButton.UseVisualStyleBackColor = false;
            this.nineButton.Click += new System.EventHandler(this.keypadButton_click);
            // 
            // eightButton
            // 
            this.eightButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.eightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eightButton.Location = new System.Drawing.Point(96, 3);
            this.eightButton.Name = "eightButton";
            this.eightButton.Size = new System.Drawing.Size(87, 30);
            this.eightButton.TabIndex = 1;
            this.eightButton.Tag = "8";
            this.eightButton.Text = "8";
            this.eightButton.UseVisualStyleBackColor = false;
            this.eightButton.Click += new System.EventHandler(this.keypadButton_click);
            // 
            // sevenButton
            // 
            this.sevenButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.sevenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sevenButton.Location = new System.Drawing.Point(3, 3);
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.Size = new System.Drawing.Size(87, 30);
            this.sevenButton.TabIndex = 0;
            this.sevenButton.Tag = "7";
            this.sevenButton.Text = "7";
            this.sevenButton.UseVisualStyleBackColor = false;
            this.sevenButton.Click += new System.EventHandler(this.keypadButton_click);
            // 
            // zeroButton
            // 
            this.zeroButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.zeroButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zeroButton.Location = new System.Drawing.Point(96, 111);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(87, 30);
            this.zeroButton.TabIndex = 10;
            this.zeroButton.Tag = "0";
            this.zeroButton.Text = "0";
            this.zeroButton.UseVisualStyleBackColor = false;
            this.zeroButton.Click += new System.EventHandler(this.keypadButton_click);
            // 
            // metricButton
            // 
            this.metricButton.AutoSize = true;
            this.metricButton.Location = new System.Drawing.Point(15, 13);
            this.metricButton.Name = "metricButton";
            this.metricButton.Size = new System.Drawing.Size(106, 35);
            this.metricButton.TabIndex = 1;
            this.metricButton.TabStop = true;
            this.metricButton.Text = "Metric";
            this.metricButton.UseVisualStyleBackColor = true;
            // 
            // ImperialButton
            // 
            this.ImperialButton.AutoSize = true;
            this.ImperialButton.Location = new System.Drawing.Point(164, 13);
            this.ImperialButton.Name = "ImperialButton";
            this.ImperialButton.Size = new System.Drawing.Size(128, 35);
            this.ImperialButton.TabIndex = 2;
            this.ImperialButton.TabStop = true;
            this.ImperialButton.Text = "Imperial";
            this.ImperialButton.UseVisualStyleBackColor = true;
            // 
            // myHeightLabel
            // 
            this.myHeightLabel.BackColor = System.Drawing.Color.LightGray;
            this.myHeightLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.myHeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myHeightLabel.Location = new System.Drawing.Point(116, 56);
            this.myHeightLabel.Name = "myHeightLabel";
            this.myHeightLabel.Size = new System.Drawing.Size(109, 31);
            this.myHeightLabel.TabIndex = 3;
            this.myHeightLabel.Tag = "height";
            this.myHeightLabel.Click += new System.EventHandler(this.ActiveLabel_click);
            // 
            // MyWeightLabel
            // 
            this.MyWeightLabel.BackColor = System.Drawing.Color.LightGray;
            this.MyWeightLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MyWeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyWeightLabel.Location = new System.Drawing.Point(116, 100);
            this.MyWeightLabel.Name = "MyWeightLabel";
            this.MyWeightLabel.Size = new System.Drawing.Size(109, 30);
            this.MyWeightLabel.TabIndex = 4;
            this.MyWeightLabel.Tag = "weight";
            this.MyWeightLabel.Click += new System.EventHandler(this.ActiveLabel_click);
            // 
            // heightUnitLabel
            // 
            this.heightUnitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightUnitLabel.Location = new System.Drawing.Point(232, 54);
            this.heightUnitLabel.Name = "heightUnitLabel";
            this.heightUnitLabel.Size = new System.Drawing.Size(63, 30);
            this.heightUnitLabel.TabIndex = 5;
            // 
            // weightUnitLabel
            // 
            this.weightUnitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightUnitLabel.Location = new System.Drawing.Point(232, 100);
            this.weightUnitLabel.Name = "weightUnitLabel";
            this.weightUnitLabel.Size = new System.Drawing.Size(63, 30);
            this.weightUnitLabel.TabIndex = 6;
            // 
            // resultLabel
            // 
            this.resultLabel.BackColor = System.Drawing.Color.White;
            this.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultLabel.Location = new System.Drawing.Point(15, 133);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(280, 36);
            this.resultLabel.TabIndex = 7;
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(15, 172);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(280, 23);
            this.progressBar.TabIndex = 8;
            // 
            // calculateBMIButton
            // 
            this.calculateBMIButton.BackColor = System.Drawing.Color.Violet;
            this.calculateBMIButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateBMIButton.Location = new System.Drawing.Point(57, 244);
            this.calculateBMIButton.Name = "calculateBMIButton";
            this.calculateBMIButton.Size = new System.Drawing.Size(185, 35);
            this.calculateBMIButton.TabIndex = 9;
            this.calculateBMIButton.Tag = "calculate";
            this.calculateBMIButton.Text = "Calculate BMI";
            this.calculateBMIButton.UseVisualStyleBackColor = false;
            // 
            // heightText
            // 
            this.heightText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightText.Location = new System.Drawing.Point(12, 58);
            this.heightText.Name = "heightText";
            this.heightText.Size = new System.Drawing.Size(90, 26);
            this.heightText.TabIndex = 10;
            this.heightText.Text = "My Height";
            // 
            // weightText
            // 
            this.weightText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightText.Location = new System.Drawing.Point(12, 102);
            this.weightText.Name = "weightText";
            this.weightText.Size = new System.Drawing.Size(90, 26);
            this.weightText.TabIndex = 11;
            this.weightText.Text = "My Weight";
            // 
            // conditionTextBox
            // 
            this.conditionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conditionTextBox.Location = new System.Drawing.Point(15, 202);
            this.conditionTextBox.Name = "conditionTextBox";
            this.conditionTextBox.Size = new System.Drawing.Size(155, 30);
            this.conditionTextBox.TabIndex = 12;
            this.conditionTextBox.Text = "Your Condition";
            // 
            // conditionLabel
            // 
            this.conditionLabel.BackColor = System.Drawing.Color.White;
            this.conditionLabel.Location = new System.Drawing.Point(176, 202);
            this.conditionLabel.Name = "conditionLabel";
            this.conditionLabel.Size = new System.Drawing.Size(116, 30);
            this.conditionLabel.TabIndex = 13;
            // 
            // BMICalculatorForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.conditionLabel);
            this.Controls.Add(this.conditionTextBox);
            this.Controls.Add(this.weightText);
            this.Controls.Add(this.heightText);
            this.Controls.Add(this.calculateBMIButton);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.weightUnitLabel);
            this.Controls.Add(this.heightUnitLabel);
            this.Controls.Add(this.MyWeightLabel);
            this.Controls.Add(this.myHeightLabel);
            this.Controls.Add(this.ImperialButton);
            this.Controls.Add(this.metricButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "BMICalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.Load += new System.EventHandler(this.BMICalculatorForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button threeButton;
        private System.Windows.Forms.Button twoButton;
        private System.Windows.Forms.Button oneButton;
        private System.Windows.Forms.Button sixButton;
        private System.Windows.Forms.Button fiveButton;
        private System.Windows.Forms.Button fourButton;
        private System.Windows.Forms.Button nineButton;
        private System.Windows.Forms.Button eightButton;
        private System.Windows.Forms.Button sevenButton;
        private System.Windows.Forms.Button zeroButton;
        private System.Windows.Forms.RadioButton metricButton;
        private System.Windows.Forms.RadioButton ImperialButton;
        private System.Windows.Forms.Label myHeightLabel;
        private System.Windows.Forms.Label MyWeightLabel;
        private System.Windows.Forms.TextBox heightUnitLabel;
        private System.Windows.Forms.TextBox weightUnitLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button calculateBMIButton;
        private System.Windows.Forms.TextBox heightText;
        private System.Windows.Forms.TextBox weightText;
        private System.Windows.Forms.TextBox conditionTextBox;
        private System.Windows.Forms.Label conditionLabel;
        private System.Windows.Forms.Button backspaceButton;
    }
}

