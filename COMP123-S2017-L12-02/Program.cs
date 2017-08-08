using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name:Yanying Zhan
 * Date: Aug 3
 * Description: Calculator Demo Projet
 * Version: 0.2 - Start the SplashForm first
 */
namespace COMP123_S2017_L12_02
{
    public static class Program
    {
        // created reference to Forms
        public static CalculatorForm calculatorForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            calculatorForm = new CalculatorForm(); // instantiate a new object of type CalculatorForm
            Application.Run(new SplashForm());
        }
    }
}
