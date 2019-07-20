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
                resultLabel.Text = outputString;
                //ActiveLabel.Text = outputValue.ToString();
                ActiveLabel.Text = outputString;
            }
            else
            {
                switch (tag)
                {
                    case "backspace":
                        //var lastchar = outputString.Substring(outputString.Length - 1);
                        outputString = outputString.Remove(outputString.Length - 1);
                        resultLabel.Text = outputString;
                        break;
                    case "clear":
                        clearKeypad();
                        break;
                    case "calculate":

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
    }
}
