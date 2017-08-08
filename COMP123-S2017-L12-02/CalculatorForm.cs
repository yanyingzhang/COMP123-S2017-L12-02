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
 * Date: Aug 3
 * Description: Calculator Demo Projet
 * Version: 0.4 - Added the CalculatorForm_Load
 */
namespace COMP123_S2017_L12_02
{
    public partial class CalculatorForm : Form
    {
        // PRIVATE INSTANCE VARIABLE
        private bool _isDecimalClicked;

        //PUBLIC PROPERTIES
        public bool IsDecimalClicked
        {
            get
            {
                return this._isDecimalClicked;
            }
            set
            {
                this._isDecimalClicked = value;
            }
        }
        //CONSTRUCTORS
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {

        }

        private void ButtonLabel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void CalculatorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// This is the shared event handler for the calculator buttons
        /// not including the opertor Buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculatorButton_Click(object sender, EventArgs e)
        {
            //Button calculatorButton = (Button)sender; //method 1
            Button calculatorButton = sender as Button; //method 2

            if((calculatorButton.Text == ".")&&(this.IsDecimalClicked))
            {
                return;
            }
            ResultTextBox.Text += calculatorButton.Text;
            //Debug.writeLine("A Calculator Button was clicked");
        }
        /// <summary>
        /// This is a shared event handler for the 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OperatorButton_Click(object sender, EventArgs e)
        {
            Button operatorButton = sender as Button;
        }
        private void CalculatorForm_Loade(object sender, EventArgs e)
        {

        }
    }
}
