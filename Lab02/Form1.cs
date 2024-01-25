using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Form1 : Form
    {
        // calculator status
        private bool calcStatus;

        // variables for number button handling
        private string calcText;
        private float calcTextAsNum;

        // variables for operations
        private int historyListIndex = 0;
        private float operandOne;
        private float operandTwo;
        private float calcOperationResult = 0;
        private string operationQueue;

        public Form1()
        {
            InitializeComponent();
            calcStatus = false; // set calculator status to false at start up
        }

        /// <summary>
        /// Loops through every button in every container and sets the button property, Enabled,
        /// depending on the parameter given
        /// </summary>
        /// <param name="status"></param>
        private void turnOnCalculator(bool status)
        {
            foreach (Control control in mButtonsContainer.Controls)
            {
                if (control is Button)
                {
                    Button button = control as Button;
                    button.Enabled = status;
                }
            }
            foreach (Control control in calcNumberContainer.Controls)
            {
                if (control is Button)
                {
                    Button button = control as Button;
                    button.Enabled = status;
                }
            }
            foreach (Control control in calcOperatorContainer.Controls)
            {
                if (control is Button)
                {
                    Button button = control as Button;
                    button.Enabled = status;
                }
            }
            foreach (Control control in calcControlContainer.Controls)
            {
                if (control is Button)
                {
                    Button button = control as Button;
                    button.Enabled = status;
                }
            }
            if (calcStatus)
            {
                pictureBox1.BackColor = Color.Red;
            }
            else
            {
                pictureBox1.BackColor = Color.Transparent;
            }
        }

        /// <summary>
        /// clears all operands in calculator
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void clear()
        {
            // calc number container variables
            calcText = "0";
            calcTextAsNum = 0;
            // calc operation container variables
            historyListIndex = 0;
            calcOperationResult = 0;
            operandOne = 0;
            operandTwo = 0;
            // calc display variable
            calcValue.Text = calcText;
        }

        /// <summary>
        /// negates instance variable calcStatus and calls turnOnCalculator function with
        /// calcStatus as the parameter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calcOnButton_Click(object sender, EventArgs e)
        {
            calcStatus = !calcStatus;
            turnOnCalculator(calcStatus);
            calcOnButton.Text = calcStatus ? "Off" : "On";
            clear();
        }

        /// <summary>
        /// inputs the desired number into the calculator
        /// </summary>
        /// <param name="buttonNumber"></param>
        private void numberButtonClick(string buttonNumber)
        {
            bool isZero = calcText == "0";
            bool containsDecimal = calcText.Contains(".");
            // if the input is not just zero or contains a decimal, continue to concatenate the number at the end
            if (!isZero || containsDecimal)
            {
                calcText += buttonNumber;
            }
            else
            {
                calcText = buttonNumber;
            }
            calcTextAsNum = float.Parse(calcText);
            calcValue.Text = calcText;
        }

        /// <summary>
        /// calculates operation
        /// </summary>
        /// <param name="operation"></param>
        private void doOperation(string operation)
        {
            if (historyListIndex == 0)
            {
                operandOne = calcTextAsNum;
                calcText = "0";
                calcTextAsNum = 0;
                historyListIndex++;
            }
            else
            {
                operandTwo = calcTextAsNum;
                switch (operationQueue)
                {
                    case "add":
                        calcOperationResult = operandOne + operandTwo;
                        break;
                    case "subtract":
                        calcOperationResult = operandOne - operandTwo;
                        break;
                    case "multiply":
                        calcOperationResult = operandOne * operandTwo;
                        break;
                    case "divide":
                        calcOperationResult = operandOne / operandTwo;
                        break;
                    case "remainder":
                        calcOperationResult = operandOne % operandTwo;
                        break;
                }
                if (float.IsInfinity(calcOperationResult))
                {
                    clear();
                    calcValue.Text = "NaN";
                }
                else
                {
                    operandOne = calcOperationResult;
                    operandTwo = 0;
                    calcValue.Text = calcOperationResult.ToString();
                    calcTextAsNum = 0;
                    calcText = "0";
                }
                
            }
            operationQueue = operation;
        }

        /// <summary>
        /// calculates single operations
        /// </summary>
        /// <param name="operation"></param>
        private void doSingleOperation(string operation)
        {
            operandOne = calcTextAsNum;
            switch (operation)
            {
                case "oneOver":
                    calcOperationResult = 1 / operandOne;
                    break;
                case "powerOfTwo":
                    calcOperationResult = operandOne * operandOne;
                    break;
                case "sqrt":
                    calcOperationResult = (float)Math.Sqrt(operandOne);
                    break;
            }
            if (float.IsInfinity(calcOperationResult))
            {
                clear();
                calcValue.Text = "NaN";
            }
            else
            {
                operandOne = calcOperationResult;
                calcValue.Text = calcOperationResult.ToString();
                calcTextAsNum = calcOperationResult;
                calcText = calcOperationResult.ToString();
            }

        }

        /// <summary>
        /// adds zero to the calculator
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonZero_Click(object sender, EventArgs e)
        {
            bool text_status = calcText == "0";
            if (!text_status || calcText.Contains("."))
            {
                calcText += "0";
                calcTextAsNum = float.Parse(calcText);
                calcValue.Text = calcText;
            }
            else
            {
                calcValue.Text = "0";
            }
        }
        /// <summary>
        /// adds decimal point to the calculator
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeciamlPoint_Click(object sender, EventArgs e)
        {
            bool text_status = calcValue.Text.Contains('.');
            if (!text_status)
            {
                calcText += ".";
                calcValue.Text += ".";
            }
        }

        /// <summary>
        /// clears current operand
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearOperandButton_Click(object sender, EventArgs e)
        {
            calcText = "0";
            calcTextAsNum = 0;
            calcValue.Text = "0";

        }

        private void fullClearButton_Click(object sender, EventArgs e)
        {
            clear();
        }

        /// <summary>
        /// shows the sum of the operation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void equalButton_Click(object sender, EventArgs e)
        {
            operandTwo = float.Parse(calcValue.Text);
            switch (operationQueue)
            {
                case "add":
                    calcOperationResult = operandOne + operandTwo;
                    break;
                case "subtract":
                    calcOperationResult = operandOne - operandTwo;
                    break;
                case "multiply":
                    calcOperationResult = operandOne * operandTwo;
                    break;
                case "divide":
                    calcOperationResult = operandOne / operandTwo;
                    break;
                case "remainder":
                    calcOperationResult = operandOne % operandTwo;
                    break;
            }
            if (float.IsInfinity(calcOperationResult))
            {
                clear();
                calcValue.Text = "NaN";
            }
            else
            {
                operandOne = calcOperationResult;
                operandTwo = 0;
                calcValue.Text = calcOperationResult.ToString();
                calcTextAsNum = 0;
                calcText = "0";
            }
        }

        /// <summary>
        /// deletes the last digit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backButton_Click(object sender, EventArgs e)
        {
            if (calcText.Length > 1)
            {
                calcText = calcText.Remove(calcText.Length - 1);
                calcTextAsNum = float.Parse(calcText);
            }
            else
            {
                calcText = "0";
                calcTextAsNum = 0;
            }
            calcValue.Text = calcText;
        }

        /// <summary>
        /// every method under here are button event handlers that call the main methods
        /// </summary>
        private void buttonOne_Click(object sender, EventArgs e)
        {
            numberButtonClick("1");
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            numberButtonClick("2");
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            numberButtonClick("3");
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            numberButtonClick("4");
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            numberButtonClick("5");
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            numberButtonClick("6");
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            numberButtonClick("7");
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            numberButtonClick("8");
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            numberButtonClick("9");
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            doOperation("add");
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            doOperation("subtract");
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            doOperation("multiply");
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            doOperation("divide");
        }

        private void oneOverButton_Click(object sender, EventArgs e)
        {
            doSingleOperation("oneOver");
        }

        private void powerOfTwoButton_Click(object sender, EventArgs e)
        {
            doSingleOperation("powerOfTwo");
        }

        private void sqrtButton_Click(object sender, EventArgs e)
        {
            doSingleOperation("sqrt");
        }
    }
}
 
