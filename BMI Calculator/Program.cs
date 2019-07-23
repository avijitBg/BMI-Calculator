using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/* BMI Calculator
 * Description: COMP123 Assignment
 * Author: Avijit Bagchi
 * ID# 301007115
 * Version: 2.4 Additional features and validation added
 * Last modified: July 22, 2019
 */
namespace BMI_Calculator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static SplashForm splashForm;
        public static BMICalculatorForm bmiCalculatorForm;
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new BMICalculatorForm());
            splashForm = new SplashForm();
            bmiCalculatorForm = new BMICalculatorForm();
            Application.Run(new SplashForm());
        }
    }
}
