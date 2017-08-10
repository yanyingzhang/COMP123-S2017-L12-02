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
 * Version: 0.6 - Added the _showResult method;
 */
namespace COMP123_S2017_L12_02
{
    public partial class CalculatorForm : Form
    { 
        // PRIVATE INSTANCE VARIABLE
        private bool _isDecimalClicked;
        private string _currentOperator;
        private List<double> _operandList;
        private double _result;

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
        public string CurrentOperator
        {
            get
            {
                return this._currentOperator;
            }
            set
            {
                this._currentOperator = value;
            }
        }
        public List<double> OperandList
        {
            get
            {
                return this._operandList;
            }
            set
            {
                this._operandList = value;
            }
        }
        public double Result
        {
            get
            {
                return this._result;
            }
            set
            {
                this._result = value;
            }
        }

        //CONSTRUCTORS

        public CalculatorForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is an event handler for the "FormClosing" event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            double operand = this._convertOperand(ResultTextBox.Text);

            if ((this.IsDecimalClicked) && (calculatorButton.Text == "."))
            {
                return;
            }

            if (calculatorButton.Text == ".")
            {
                this.IsDecimalClicked = true;
            }

            if (ResultTextBox.Text == "0")
            {
                if (calculatorButton.Text == "0")
                {
                    ResultTextBox.Text = calculatorButton.Text;
                }
                else
                {
                    ResultTextBox.Text = calculatorButton.Text;
                }
            }
            else
            {
                ResultTextBox.Text += calculatorButton.Text;
            }
        }
            //ResultTextBox.Text += calculatorButton.Text;
        
        /// <summary>
        /// This is a shared event handler for the 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OperatorButton_Click(object sender, EventArgs e)
        {
            Button operatorButton = sender as Button;

            switch (operatorButton.Text)
            {
                case "C":
                    this._clear();
                    break;
                case "+":
                    break;
                case "-":
                    break;
                case "⌫":
                    break;
                case "=":
                    this._showResult(operand);
                    break;
                default:
                    this._calculate(operand, operatorButton.Text);
                    break;
            }
        }

        /// <summary>
        /// This method shows the Result of the last operation in the ResultTextBox
        /// </summary>
        /// <param name="text"></param>
        private void _showResult(double operand)
        {
            this._calculate(operand,this.CurrentOperator);
            ResultTextBox.Text = this.Result.ToString();
        }

        /// <summary>
        /// This is the private _clear method
        /// It resets the calculator
        /// </summary>
        private void _clear()
        {
            this.IsDecimalClicked = false;
            ResultTextBox.Text = "0";
            this.CurrentOperator = "C";
            this.OperandList = new List<double>();
        }

        private void CalculatorForm_Loade(object sender, EventArgs e)
        {
            this._clear();
        }
        /// <summary>
        /// This method calculates the result of all the operands in the operandList
        /// </summary>
        /// <param name="operandString"></param>
        /// <param name="operatorString"></param>
        private void _calculate(double operand, string operatorString)
        {
            OperandList.Add(operand);
            if (OperandList.Count > 1)
            {
                switch(operatorString)
                {
                    case "+":
                        this.Result = this.OperandList[0] + this.OperandList[1];
                        break;
                    case "-":
                        this.Result = this.OperandList[0] - this.OperandList[1];
                        break;
                }
            }
            this.CurrentOperator = operatorString;
        }
        private double _convertOperand(double operand)
        {
            try
            {
                return Convert.ToDouble(operand);
            }
            catch (Exception exception)
            {
                //Debug.WriteLine("An Error Occurred");
                //Debug.WriteLine(exception.Message);
                
            }
            return 0;
        }
    }
}
