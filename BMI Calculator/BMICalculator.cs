using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calculator
{
    public partial class BMICalculatorForm : Form
    {
        public string outputString { get; set; }
        public float outputValue { get; set; }
        public double Result { get; set; }
        //public Label ActiveLabel { get; set; }
        public TextBox ActiveTextBox { get; set; }

        public BMICalculatorForm()
        {
            InitializeComponent();
        }

        private void BMICalculatorForm_Load(object sender, EventArgs e)
        {
            clearKeypad();
            //Program.splashForm.Close();
            //ActiveLabel = null;
            ActiveTextBox = heightTextBox;
            heightUnitLabel.Text = "cm";
            weightUnitLabel.Text = "kg";
        }

        private void keypadButton_click(object sender, EventArgs e)
        {
            Button TheButton = sender as Button;
            var tag = TheButton.Tag.ToString();
            int numericValue=0;
            bool numericResult = int.TryParse(tag, out numericValue);
            if (numericResult)
            {
                outputString += tag;
                ActiveTextBox.Text = outputString;
            }
            else
            {
                switch (tag)
                {
                    case "backspace":
                        outputString = outputString.Remove(outputString.Length - 1);
                        ActiveTextBox.Text = outputString;
                        break;
                    case "clear":
                        clearKeypad();
                        progressBar.Value = 0;
                        break;
                    case "calculate":
                        progressBar.Value = 0;
                        BMIResult();
                        outputValue = 0;
                        break;
                }
            }
        }

        private void clearKeypad()
        {
            resultTextBox.Text = "0";
            resultTextBox.ForeColor = Color.Black;
            outputString = "";
            outputValue = 0;
            //ActiveLabel.Text = "0";
            heightTextBox.Text = "0";
            weightTextBox.Text = "0";
            conditionLabel.Text = "";
            heightTextBox.BackColor = Color.WhiteSmoke;
            heightTextBox.BackColor = Color.WhiteSmoke;
        }

        private void ActiveTextBox_click(object sender, EventArgs e)
        {
            outputValue = 0;
            outputString = "";
            ActiveTextBox = sender as TextBox;
            //ActiveTextBox.BackColor = Color.PaleGreen;
        }

        private void BMIResult()
        {
            if(int.TryParse(heightTextBox.Text, out int myHeight) && int.TryParse(weightTextBox.Text, out int myWeight))
            {
                var height = Convert.ToDouble(heightTextBox.Text);
                var weight = Convert.ToDouble(weightTextBox.Text);
                if (height != 0 && weight != 0)
                {
                    if (metricButton.Checked == true)
                    {
                        Result = (weight / height / height) * 10000;
                        resultTextBox.Text = string.Format($"{Result:F1}").ToString();
                        DisplayCondition();
                    }
                    else if (ImperialButton.Checked == true)
                    {
                        Result = weight * 703 / (height * height);
                        resultTextBox.Text = string.Format($"{Result:F1}").ToString();
                        DisplayCondition();
                    }
                }

                else
                {
                    resultTextBox.Text = "Please enter all values";
                    resultTextBox.ForeColor = Color.Red;
                }
            }
            else
            {
                resultTextBox.Text = "Please enter all values";
                resultTextBox.ForeColor = Color.Red;
            }
        }

        private void metricButton_CheckedChanged(object sender, EventArgs e)
        {
            heightUnitLabel.Text = "cm";
            weightUnitLabel.Text = "kg";
            heightUnitLabel.ForeColor = Color.Black;
        }

        private void ImperialButton_CheckedChanged(object sender, EventArgs e)
        {
            heightUnitLabel.Text = "in";
            weightUnitLabel.Text = "lb";
        }

        private void DisplayCondition()
        {
            progressBar.Maximum = 4;
            if (Result < 18.5)
            {
                conditionLabel.Text = "Underweight";
                conditionLabel.ForeColor = Color.SaddleBrown;
                progressBar.Value += 1;
                progressBar.ForeColor = Color.SaddleBrown;
            }
            else if (Result >= 18.5 && Result <= 24.9)
            {
                conditionLabel.Text = "Normal";
                conditionLabel.ForeColor = Color.Green;
                progressBar.Value += 2;
                progressBar.ForeColor = Color.Green;
            }
            else if (Result >= 25 && Result <= 29.9)
            {
                conditionLabel.Text = "Overweight";
                conditionLabel.ForeColor = Color.Orange;
                progressBar.Value += 3;
                progressBar.ForeColor = Color.Orange;
            }
            else if (Result >= 30)
            {
                conditionLabel.Text = "Obese";
                conditionLabel.ForeColor = Color.Red;
                progressBar.Value += 4;
                progressBar.ForeColor = Color.Red;
            }
        }
    }
}
