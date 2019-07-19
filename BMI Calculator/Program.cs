using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/* BMI Calculator
 * Description: COMP123 Assignment
 * Author: Avijit Bagchi
 * ID# 301007115
 * Version: 1.0 Project started
 * Last modified: July 19, 2019
 */
namespace BMI_Calculator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BMICalculatorForm());
        }
    }
}
