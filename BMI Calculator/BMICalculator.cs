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

        public Label ActiveLabel { get; set; }

        public BMICalculatorForm()
        {
            InitializeComponent();
        }

        private void BMICalculatorForm_Load(object sender, EventArgs e)
        {
            clearKeypad();
            ActiveLabel = null;
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
                //resultLabel.Text = outputString;
                ActiveLabel.Text = outputString;
            }
            else
            {
                switch (tag)
                {
                    case "backspace":
                        //var lastchar = outputString.Substring(outputString.Length - 1);
                        outputString = outputString.Remove(outputString.Length - 1);
                        ActiveLabel.Text = outputString;
                        break;
                    case "clear":
                        clearKeypad();
                        break;
                    case "calculate":
                        BMIResult();
                        //outputValue = x;
                        //outputString = x.ToString();
                        //resultLabel.Text = x.ToString();
                        //resultLabel.Text = outputString;
                        break;
                }
            }
        }

        private void clearKeypad()
        {
            resultLabel.Text = "0";
            outputString = "";
            outputValue = 0;
            //ActiveLabel.Text = "0";
            myHeightLabel.Text = "0";
            MyWeightLabel.Text = "0";
        }

        private void ActiveLabel_click(object sender, EventArgs e)
        {
            outputValue = 0;
            outputString = "";
            ActiveLabel = sender as Label;  
        }

        private void BMIResult()
        {
            //double result = 0;
            var height = Convert.ToDouble(myHeightLabel.Text);
            var weight = Convert.ToDouble(MyWeightLabel.Text);
            if (metricButton.Checked == true)
            {
                Result = (weight / height/height)*10000;
                resultLabel.Text = string.Format($"{Result:F1}").ToString();
                //resultLabel.Text = Result.ToString();
                DisplayCondition();
            }
            else if (ImperialButton.Checked == true)
            {
                Result = weight * 703 / (height * height);
                resultLabel.Text = string.Format($"{Result:F1}").ToString();
                DisplayCondition();
            }
            else
            {
                Result = 10;
                resultLabel.Text = "Please select a unit type";
            }

        }

        private void metricButton_CheckedChanged(object sender, EventArgs e)
        {
            heightUnitLabel.Text = "cm";
            weightUnitLabel.Text = "kg";
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
                conditionLabel.ForeColor = Color.Bisque;
                progressBar.Value += 1;
            }
            else if (Result >= 18.5 && Result <= 24.9)
            {
                conditionLabel.Text = "Normal";
                conditionLabel.ForeColor = Color.Green;
                progressBar.Value += 2;
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
            }
        }
    }
}
