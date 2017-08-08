using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name:Yanying Zhan
 * Date: Aug 8
 * Description: SplashForm
 * Version: 0.3 - Created a public property as an Alias to Program.calculatorForm
 */
namespace COMP123_S2017_L12_02
{
    public partial class SplashForm : Form
    {
        // PRIVATE INSTANCE VARIABLES

        // PUBLIC PROPERTIES
        public CalculatorForm CalculatorForm
        {
            get
            {
                return Program.calculatorForm;
            }
        }

        // CONSTRUCTORS
        public SplashForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the event handler for the "tick"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            //CalculatorForm calculatorForm = new CalculatorForm();
            this.CalculatorForm.Show();
            this.Hide();

            SplashFormTimer.Enabled = false; // turn timer off
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SplashForm_Load(object sender, EventArgs e)
        {

        }
    }
}
