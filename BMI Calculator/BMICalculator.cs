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
                        progressBar.Value = 0;
                        break;
                    case "calculate":
                        //var height = Convert.ToDouble(myHeightLabel.Text);
                        //var weight = Convert.ToDouble(MyWeightLabel.Text);
                        //if (height !=0 && weight!=0)
                        //{
                            BMIResult();
                        //}
                        //else
                        //{
                        //    resultLabel.Text = "Please enter all values";
                        //    resultLabel.ForeColor = Color.Red;
                        //}
                        //clearKeypad();
                        break;
                }
            }
        }

        private void clearKeypad()
        {
            resultLabel.Text = "0";
            resultLabel.ForeColor = Color.Black;
            outputString = "";
            outputValue = 0;
            //ActiveLabel.Text = "0";
            myHeightLabel.Text = "0";
            MyWeightLabel.Text = "0";
            conditionLabel.Text = "";
            myHeightLabel.BackColor = Color.PaleGreen;
            MyWeightLabel.BackColor = Color.PaleGreen;
        }

        private void ActiveLabel_click(object sender, EventArgs e)
        {
            outputValue = 0;
            outputString = "";
            ActiveLabel = sender as Label;
            ActiveLabel.BackColor = Color.SeaGreen;
        }

        private void BMIResult()
        {
            var height = Convert.ToDouble(myHeightLabel.Text);
            var weight = Convert.ToDouble(MyWeightLabel.Text);
            if(Height!=0 && weight != 0)
            {
                if (metricButton.Checked == true)
                {
                    Result = (weight / height / height) * 10000;
                    resultLabel.Text = string.Format($"{Result:F1}").ToString();
                    //resultLabel.Text = Result.ToString();
                    DisplayCondition();
                    //clearKeypad();
                }
                else if (ImperialButton.Checked == true)
                {
                    Result = weight * 703 / (height * height);
                    resultLabel.Text = string.Format($"{Result:F1}").ToString();
                    DisplayCondition();
                    clearKeypad();
                }
            }
            else
            {
                resultLabel.Text = "Please enter all values";
                resultLabel.ForeColor = Color.Red;
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
